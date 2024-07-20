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
    // Type: UnityEditor.ModelImporterNormals
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_ModelImporterNormals
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("ModelImporterNormals", typeof(UnityEditor.ModelImporterNormals));
            cls.AddConstValue("Import", 0);
            cls.AddConstValue("Calculate", 1);
            cls.AddConstValue("None", 2);
            return cls;
        }
    }
}
#endif
#endif
