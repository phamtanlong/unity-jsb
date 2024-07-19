#if UNITY_EDITOR
#if UNITY_STANDALONE_OSX
// Unity: 2019.4.40f1
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
    // Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2019.4.40f1/Unity.app/Contents/Managed/UnityEditor.dll
    // Type: UnityEditor.ModelImporterNormalSmoothingSource
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_ModelImporterNormalSmoothingSource
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("ModelImporterNormalSmoothingSource", typeof(UnityEditor.ModelImporterNormalSmoothingSource));
            cls.AddConstValue("PreferSmoothingGroups", 0);
            cls.AddConstValue("FromSmoothingGroups", 1);
            cls.AddConstValue("FromAngle", 2);
            cls.AddConstValue("None", 3);
            return cls;
        }
    }
}
#endif
#endif
