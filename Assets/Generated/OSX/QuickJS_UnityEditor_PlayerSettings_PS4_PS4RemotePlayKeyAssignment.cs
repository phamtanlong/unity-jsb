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
    // Type: UnityEditor.PlayerSettings+PS4+PS4RemotePlayKeyAssignment
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_PlayerSettings_PS4_PS4RemotePlayKeyAssignment
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("PS4RemotePlayKeyAssignment", typeof(UnityEditor.PlayerSettings.PS4.PS4RemotePlayKeyAssignment));
            cls.AddConstValue("PatternA", 0);
            cls.AddConstValue("PatternB", 1);
            cls.AddConstValue("PatternC", 2);
            cls.AddConstValue("PatternD", 3);
            cls.AddConstValue("PatternE", 4);
            cls.AddConstValue("PatternF", 5);
            cls.AddConstValue("PatternG", 6);
            cls.AddConstValue("PatternH", 7);
            cls.AddConstValue("None", -1);
            return cls;
        }
    }
}
#endif
#endif
