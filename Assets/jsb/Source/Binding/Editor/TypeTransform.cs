using System;
using System.IO;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Linq;

namespace QuickJS.Binding
{
    public class BindingPoints
    {
        public const string METHOD_BINDING_FULL = "METHOD_BINDING_FULL";
        public const string METHOD_BINDING_BEFORE_INVOKE = "METHOD_BINDING_BEFORE_INVOKE";
    }

    public class TypeTransform
    {
        private Type _type;
        private JSHotfixAttribute _hotfix;
        private string _typeNaming;
        private bool _enableOperatorOverloading = true;
        private bool _disposable;

        public bool crossbind => _csConstructorOverride != null;

        public bool disposable => _disposable;

        public TypeBindingFlags bindingFlags = TypeBindingFlags.Default;

        // 此类型依赖特定的预编译指令
        public HashSet<string> requiredDefines = new HashSet<string>();

        private Dictionary<string, HashSet<string>> _requiredDefinesOfMember;

        // 扩展方法
        public readonly List<MethodInfo> extensionMethods = new List<MethodInfo>();

        // 附加的静态方法
        public readonly List<Native.JSCFunction> staticMethods = new List<Native.JSCFunction>();

        // 按名字屏蔽导出
        private HashSet<string> _memberBlacklist = new HashSet<string>();

        // 强制不导出的方法
        private HashSet<MethodBase> _blockedMethods = new HashSet<MethodBase>();

        // 针对特定方法的 ts 声明优化
        private Dictionary<MethodBase, string> _tsMethodDeclarations = new Dictionary<MethodBase, string>();
        private Dictionary<string, Native.JSCFunction> _csMethodOverride = new Dictionary<string, Native.JSCFunction>();
        private Native.JSCFunctionMagic _csConstructorOverride = null;

        // d.ts 中额外输出附加方法声明 (例如 Vector3, js中需要通过方法调用进行 +-*/== 等运算)
        private List<string> _tsAdditionalMethodDeclarations = new List<string>();

        private Dictionary<Type, Delegate> _filters = new Dictionary<Type, Delegate>();
        // private Func<ConstructorInfo, bool> _filterConstructorInfo;
        // private Func<PropertyInfo, bool> _filterPropertyInfo;
        // private Func<FieldInfo, bool> _filterFieldInfo;
        // private Func<EventInfo, bool> _filterEventInfo;
        // private Func<MethodInfo, bool> _filterMethodInfo;

        private Dictionary<MemberInfo, string> _memberNameRules = new Dictionary<MemberInfo, string>();

        private Dictionary<MemberInfo, string> _memberNameAlias = new Dictionary<MemberInfo, string>();

        /// <summary>
        /// 是否需要 UNITY_EDITOR 条件
        /// </summary>
        public bool isEditorRuntime { get { return requiredDefines.Contains("UNITY_EDITOR"); } }

        public bool enableOperatorOverloading => _enableOperatorOverloading;

        public Type type => _type;

        public Native.JSCFunctionMagic csConstructorOverride => _csConstructorOverride;

        public TypeTransform(Type type)
        {
            _type = type;
            if (_type.IsGenericTypeDefinition)
            {
                bindingFlags = TypeBindingFlags.Default & ~TypeBindingFlags.BindingCode;
            }
        }

        public TypeTransform EnableOperatorOverloading(bool value)
        {
            _enableOperatorOverloading = value;
            return this;
        }

        /// <summary>
        /// let this type's lifetime totally managed by JS.
        /// it means the underlying C# object will be automatically disposed after JS object's releasing.
        /// NOTE: it's only valid for the objects created by JS ('new XXX()' in JS).
        /// </summary>
        public TypeTransform SetDisposable()
        {
            _disposable = true;
            return this;
        }

        /// <summary>
        /// the generated static binding code for this type will be guarded by UNITY_EDITOR
        /// </summary>
        public TypeTransform EditorRuntime()
        {
            return AddRequiredDefines("UNITY_EDITOR");
        }

        /// <summary>
        /// let this type binding only available with specified C# DefineConstants
        /// </summary>
        public TypeTransform AddRequiredDefines(params string[] defines)
        {
            foreach (var def in defines)
            {
                requiredDefines.Add(def);
            }
            return this;
        }

        /// <summary>
        /// this type will not guarded by unity target platform define constants (UNITY_ANDROID, UNITY_IOS etc.)
        /// it's only used for generating static binding code.
        /// </summary>
        public TypeTransform SystemRuntime()
        {
            bindingFlags &= ~TypeBindingFlags.BuildTargetPlatformOnly;
            return this;
        }

        public HashSet<string> GetRequiredDefinesOfMember(string memberName)
        {
            if (_requiredDefinesOfMember != null) 
            {
                HashSet<string> requiredDefines;
                if (_requiredDefinesOfMember.TryGetValue(memberName, out requiredDefines))
                {
                    return requiredDefines;
                }
            }
            return null;
        }

        public TypeTransform AddRequiredDefinesForMember(string memberName, params string[] requiredDefines)
        {
            if (_requiredDefinesOfMember == null) 
            {
                _requiredDefinesOfMember = new Dictionary<string, HashSet<string>>();
            }
            HashSet<string> oldValues;
            if (_requiredDefinesOfMember.TryGetValue(memberName, out oldValues))
            {
                oldValues.UnionWith(requiredDefines);
            }
            else
            {
                _requiredDefinesOfMember[memberName] = new HashSet<string>(requiredDefines);
            }
            return this;
        }

        /// <summary>
        /// filter out the member if the callback returns true.
        /// </summary>
        public TypeTransform OnFilter<T>(Func<T, bool> callback)
        {
            _filters[typeof(T)] = callback;
            return this;
        }

        public bool Filter<T>(T info)
        {
            Delegate d;
            if (!_filters.TryGetValue(typeof(T), out d))
            {
                return false;
            }
            var t = (Func<T, bool>)d;
            return t(info);
        }

        public string GetNameAlias(MemberInfo info)
        {
            string alias;
            return _memberNameAlias.TryGetValue(info, out alias) ? alias : info.Name;
        }

        public string GetNameRule(MemberInfo info)
        {
            string rule;
            return _memberNameRules.TryGetValue(info, out rule) ? rule : null;
        }

        public void SetNameRule(Func<MemberInfo, string> callback)
        {
            foreach (var m in _type.GetMembers())
            {
                var r = callback(m);
                if (r != null)
                {
                    _memberNameRules[m] = r;
                }
            }
        }

        #region Extension Method Management
        public TypeTransform AddExtensionMethod<T>(Action<T> method, string tsDecl = null)
        {
            return AddExtensionMethod(method.Method, tsDecl);
        }

        public TypeTransform AddExtensionMethod<T1, T2>(Action<T1, T2> method, string tsDecl = null)
        {
            return AddExtensionMethod(method.Method, tsDecl);
        }

        public TypeTransform AddExtensionMethod<T1, T2, T3>(Action<T1, T2, T3> method, string tsDecl = null)
        {
            return AddExtensionMethod(method.Method, tsDecl);
        }

        public TypeTransform AddExtensionMethod<TResult>(Func<TResult> method, string tsDecl = null)
        {
            return AddExtensionMethod(method.Method, tsDecl);
        }

        public TypeTransform AddExtensionMethod<T1, TResult>(Func<T1, TResult> method, string tsDecl = null)
        {
            return AddExtensionMethod(method.Method, tsDecl);
        }

        public TypeTransform AddExtensionMethod<T1, T2, TResult>(Func<T1, T2, TResult> method, string tsDecl = null)
        {
            return AddExtensionMethod(method.Method, tsDecl);
        }

        public TypeTransform AddExtensionMethod(MethodInfo method, string tsDecl = null)
        {
            if (!extensionMethods.Contains(method) && !Filter(method))
            {
                extensionMethods.Add(method);

                AddTSMethodDeclaration(method, tsDecl);
            }

            return this;
        }
        #endregion

        public TypeTransform AddStaticMethod(Native.JSCFunction method, string tsDecl = null)
        {
            if (!staticMethods.Contains(method))
            {
                staticMethods.Add(method);
                AddTSMethodDeclaration(method.Method, tsDecl);
            }

            return this;
        }


        public JSHotfixAttribute GetHotfix()
        {
            return _hotfix;
        }

        public void SetHotfix(JSHotfixAttribute attr)
        {
            _hotfix = attr;
        }

        public void ForEachAdditionalTSMethodDeclaration(Action<string> fn)
        {
            foreach (var decl in _tsAdditionalMethodDeclarations)
            {
                fn(decl);
            }
        }

        public string GetTypeNaming()
        {
            return _typeNaming;
        }

        public TypeTransform Rename(string name)
        {
            _typeNaming = name;
            return this;
        }

        public TypeTransform AddTSMethodDeclaration(string spec)
        {
            _tsAdditionalMethodDeclarations.Add(spec);
            return this;
        }

        public TypeTransform AddTSMethodDeclaration(params string[] specs)
        {
            _tsAdditionalMethodDeclarations.AddRange(specs);
            return this;
        }

        public bool IsMemberBlocked(string memeberName)
        {
            return _memberBlacklist.Contains(memeberName);
        }

        /// <summary>
        /// mark any member as blocked with specific name. 
        /// </summary>
        /// <param name="memberName">the name of member you want to block</param>
        public TypeTransform SetMemberBlocked(string memberName)
        {
            _memberBlacklist.Add(memberName);
            return this;
        }

        // 指定的方法是否被屏蔽
        public bool IsBlocked(MethodBase method)
        {
            return _blockedMethods.Contains(method);
        }

        public bool IsBlocked(int token)
        {
            return _blockedMethods.Any(i => i.MetadataToken == token);
        }

        /// <summary>
        /// block all of the constructors 
        /// </summary>
        public TypeTransform SetAllConstructorsBlocked()
        {
            foreach (var ctor in _type.GetConstructors())
            {
                _blockedMethods.Add(ctor);
            }

            return this;
        }

        /// <summary>
        /// block the constructors with specific parameters
        /// </summary>
        public TypeTransform SetConstructorBlocked(params Type[] parameters)
        {
            var method = _type.GetConstructor(parameters);
            if (method != null)
            {
                _blockedMethods.Add(method);
            }
            return this;
        }

        /// <summary>
        /// 屏蔽指定名字与签名的方法
        /// </summary>
        public TypeTransform SetMethodBlocked(string name, params Type[] parameters)
        {
            var method = _type.GetMethod(name, parameters);
            if (method != null)
            {
                _blockedMethods.Add(method);
            }
            return this;
        }

        /// <summary>
        /// specify the method name in JS instead of it's C# name
        /// </summary>
        public TypeTransform SetMethodJSName(string jsName, string name, params Type[] parameters)
        {
            var method = _type.GetMethod(name, parameters);
            if (method != null)
            {
                _memberNameAlias[method] = jsName;
            }

            return this;
        }

        // TS: 为指定类型的匹配方法添加声明映射 (仅用于优化代码提示体验)
        public TypeTransform AddTSMethodDeclaration(string spec, string name, params Type[] parameters)
        {
            var method = _type.GetMethod(name, parameters);
            if (method != null)
            {
                _tsMethodDeclarations[method] = spec;
            }
            return this;
        }

        public TypeTransform AddTSMethodDeclaration(MethodBase method, string spec)
        {
            if (method != null && spec != null)
            {
                _tsMethodDeclarations[method] = spec;
            }
            return this;
        }

        public bool GetTSMethodDeclaration(MethodBase method, out string code)
        {
            return _tsMethodDeclarations.TryGetValue(method, out code);
        }

        public TypeTransform WriteCrossBindingConstructor(params Type[] parameters)
        {
            _csConstructorOverride = CommonFix.CrossBindConstructor;
            return this;
        }

        public TypeTransform WriteCSMethodOverrideBinding(string methodName, Native.JSCFunction writer)
        {
            _csMethodOverride[methodName] = writer;
            return this;
        }

        public Native.JSCFunction GetCSMethodOverrideBinding(string methodName)
        {
            return _csMethodOverride.TryGetValue(methodName, out var func) ? func : null;
        }
    }
}
