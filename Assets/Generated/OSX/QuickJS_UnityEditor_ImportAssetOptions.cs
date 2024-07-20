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
    // Type: UnityEditor.ImportAssetOptions
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_ImportAssetOptions
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("ImportAssetOptions", typeof(UnityEditor.ImportAssetOptions));
            cls.AddConstValue("Default", 0);
            cls.AddConstValue("ForceUpdate", 1);
            cls.AddConstValue("ForceSynchronousImport", 8);
            cls.AddConstValue("ImportRecursive", 256);
            cls.AddConstValue("DontDownloadFromCacheServer", 8192);
            cls.AddConstValue("ForceUncompressedImport", 16384);
            return cls;
        }
    }
}
#endif
#endif
