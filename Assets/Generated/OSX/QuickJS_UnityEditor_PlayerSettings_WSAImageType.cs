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
    // Type: UnityEditor.PlayerSettings+WSAImageType
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_PlayerSettings_WSAImageType
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("WSAImageType", typeof(UnityEditor.PlayerSettings.WSAImageType));
            cls.AddConstValue("PackageLogo", 1);
            cls.AddConstValue("SplashScreenImage", 2);
            cls.AddConstValue("UWPSquare44x44Logo", 31);
            cls.AddConstValue("UWPSquare71x71Logo", 32);
            cls.AddConstValue("UWPSquare150x150Logo", 33);
            cls.AddConstValue("UWPSquare310x310Logo", 34);
            cls.AddConstValue("UWPWide310x150Logo", 35);
            return cls;
        }
    }
}
#endif
#endif
