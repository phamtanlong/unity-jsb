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
    // Type: UnityEditor.PlayerSettings+PS4+PlayStationVREyeToEyeDistanceSettings
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_PlayerSettings_PS4_PlayStationVREyeToEyeDistanceSettings
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("PlayStationVREyeToEyeDistanceSettings", typeof(UnityEditor.PlayerSettings.PS4.PlayStationVREyeToEyeDistanceSettings));
            cls.AddConstValue("PerUser", 0);
            cls.AddConstValue("ForceDefault", 1);
            cls.AddConstValue("DynamicModeAtRuntime", 2);
            return cls;
        }
    }
}
#endif
#endif
