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
    // Type: UnityEditor.TextureImporterGenerateCubemap
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_TextureImporterGenerateCubemap
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("TextureImporterGenerateCubemap", typeof(UnityEditor.TextureImporterGenerateCubemap));
            cls.AddConstValue("None", 0);
            cls.AddConstValue("Spheremap", 1);
            cls.AddConstValue("Cylindrical", 2);
            cls.AddConstValue("SimpleSpheremap", 3);
            cls.AddConstValue("NiceSpheremap", 4);
            cls.AddConstValue("FullCubemap", 5);
            cls.AddConstValue("AutoCubemap", 6);
            return cls;
        }
    }
}
#endif
#endif
