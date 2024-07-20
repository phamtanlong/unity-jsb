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
    // Type: UnityEditor.ModelImporterMaterialImportMode
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_ModelImporterMaterialImportMode
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("ModelImporterMaterialImportMode", typeof(UnityEditor.ModelImporterMaterialImportMode));
            cls.AddConstValue("None", 0);
            cls.AddConstValue("ImportStandard", 1);
            cls.AddConstValue("LegacyImport", 1);
            cls.AddConstValue("ImportViaMaterialDescription", 2);
            cls.AddConstValue("Import", 2);
            return cls;
        }
    }
}
#endif
#endif
