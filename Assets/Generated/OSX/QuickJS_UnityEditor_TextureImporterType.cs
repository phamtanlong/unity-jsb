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
    // Type: UnityEditor.TextureImporterType
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_TextureImporterType
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("TextureImporterType", typeof(UnityEditor.TextureImporterType));
            cls.AddConstValue("Default", 0);
            cls.AddConstValue("NormalMap", 1);
            cls.AddConstValue("GUI", 2);
            cls.AddConstValue("Cookie", 4);
            cls.AddConstValue("Lightmap", 6);
            cls.AddConstValue("Cursor", 7);
            cls.AddConstValue("Sprite", 8);
            cls.AddConstValue("SingleChannel", 10);
            cls.AddConstValue("Shadowmask", 11);
            cls.AddConstValue("DirectionalLightmap", 12);
            cls.AddConstValue("Image", -2147483648);
            cls.AddConstValue("HDRI", -9);
            cls.AddConstValue("Advanced", -5);
            cls.AddConstValue("Cubemap", -3);
            cls.AddConstValue("Reflection", -3);
            cls.AddConstValue("Bump", -1);
            return cls;
        }
    }
}
#endif
#endif
