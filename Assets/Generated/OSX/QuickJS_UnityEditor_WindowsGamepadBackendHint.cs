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
    // Type: UnityEditor.WindowsGamepadBackendHint
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_WindowsGamepadBackendHint
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("WindowsGamepadBackendHint", typeof(UnityEditor.WindowsGamepadBackendHint));
            cls.AddConstValue("WindowsGamepadBackendHintDefault", 0);
            cls.AddConstValue("WindowsGamepadBackendHintXInput", 1);
            cls.AddConstValue("WindowsGamepadBackendHintWindowsGamingInput", 2);
            return cls;
        }
    }
}
#endif
#endif