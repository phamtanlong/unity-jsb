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
    // Type: UnityEditor.PlayerSettings+Switch+ScreenResolutionBehavior
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_PlayerSettings_Switch_ScreenResolutionBehavior
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("ScreenResolutionBehavior", typeof(UnityEditor.PlayerSettings.Switch.ScreenResolutionBehavior));
            cls.AddConstValue("Manual", 0);
            cls.AddConstValue("OperationMode", 1);
            cls.AddConstValue("PerformanceMode", 2);
            cls.AddConstValue("Both", 3);
            return cls;
        }
    }
}
#endif
#endif
