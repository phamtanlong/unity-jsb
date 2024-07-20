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
    // Type: UnityEditor.SpritePackerMode
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_SpritePackerMode
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("SpritePackerMode", typeof(UnityEditor.SpritePackerMode));
            cls.AddConstValue("Disabled", 0);
            cls.AddConstValue("BuildTimeOnly", 1);
            cls.AddConstValue("AlwaysOn", 2);
            cls.AddConstValue("BuildTimeOnlyAtlas", 3);
            cls.AddConstValue("AlwaysOnAtlas", 4);
            cls.AddConstValue("SpriteAtlasV2", 5);
            return cls;
        }
    }
}
#endif
#endif
