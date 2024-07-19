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
    // Assembly: UnityEngine.TextRenderingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2019.4.40f1/Unity.app/Contents/Managed/UnityEngine/UnityEngine.TextRenderingModule.dll
    // Type: UnityEngine.TextAnchor
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_TextAnchor
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("TextAnchor", typeof(UnityEngine.TextAnchor));
            cls.AddConstValue("UpperLeft", 0);
            cls.AddConstValue("UpperCenter", 1);
            cls.AddConstValue("UpperRight", 2);
            cls.AddConstValue("MiddleLeft", 3);
            cls.AddConstValue("MiddleCenter", 4);
            cls.AddConstValue("MiddleRight", 5);
            cls.AddConstValue("LowerLeft", 6);
            cls.AddConstValue("LowerCenter", 7);
            cls.AddConstValue("LowerRight", 8);
            return cls;
        }
    }
}
#endif
