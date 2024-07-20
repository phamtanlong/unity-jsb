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
    // Type: UnityEditor.PlayerSettings+WSATargetFamily
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_PlayerSettings_WSATargetFamily
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("WSATargetFamily", typeof(UnityEditor.PlayerSettings.WSATargetFamily));
            cls.AddConstValue("Desktop", 0);
            cls.AddConstValue("Mobile", 1);
            cls.AddConstValue("Xbox", 2);
            cls.AddConstValue("Holographic", 3);
            cls.AddConstValue("Team", 4);
            cls.AddConstValue("IoT", 5);
            cls.AddConstValue("IoTHeadless", 6);
            return cls;
        }
    }
}
#endif
#endif
