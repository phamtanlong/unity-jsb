#if UNITY_EDITOR
#if UNITY_STANDALONE_OSX
// Unity: 2021.3.37f1
using System;
using System.Collections.Generic;

namespace jsb {
    using QuickJS.Errors;
    using JSValue = QuickJS.Native.JSValue;
    using JSApi = QuickJS.Native.JSApi;
    using JSNative = QuickJS.JSNative;
    using JSContext = QuickJS.Native.JSContext;
    using Values = QuickJS.Binding.Values;
    using ScriptEngine = QuickJS.ScriptEngine;
    using JSBindingAttribute = QuickJS.JSBindingAttribute;
    using MonoPInvokeCallbackAttribute = QuickJS.MonoPInvokeCallbackAttribute;
    // Assembly: UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2021.3.37f1/Unity.app/Contents/Managed/UnityEngine/UnityEditor.CoreModule.dll
    // Type: UnityEditor.ObjectChangeKind
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_ObjectChangeKind
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("ObjectChangeKind", typeof(UnityEditor.ObjectChangeKind));
            cls.AddConstValue("None", 0);
            cls.AddConstValue("ChangeScene", 1);
            cls.AddConstValue("CreateGameObjectHierarchy", 2);
            cls.AddConstValue("ChangeGameObjectStructureHierarchy", 3);
            cls.AddConstValue("ChangeGameObjectStructure", 4);
            cls.AddConstValue("ChangeGameObjectParent", 5);
            cls.AddConstValue("ChangeGameObjectOrComponentProperties", 6);
            cls.AddConstValue("DestroyGameObjectHierarchy", 7);
            cls.AddConstValue("CreateAssetObject", 8);
            cls.AddConstValue("DestroyAssetObject", 9);
            cls.AddConstValue("ChangeAssetObjectProperties", 10);
            cls.AddConstValue("UpdatePrefabInstances", 11);
            return cls;
        }
    }
}
#endif
#endif
