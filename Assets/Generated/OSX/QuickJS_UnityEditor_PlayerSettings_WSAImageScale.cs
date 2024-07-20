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
    // Type: UnityEditor.PlayerSettings+WSAImageScale
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_PlayerSettings_WSAImageScale
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("WSAImageScale", typeof(UnityEditor.PlayerSettings.WSAImageScale));
            cls.AddConstValue("Target16", 16);
            cls.AddConstValue("Target24", 24);
            cls.AddConstValue("Target32", 32);
            cls.AddConstValue("Target48", 48);
            cls.AddConstValue("_80", 80);
            cls.AddConstValue("_100", 100);
            cls.AddConstValue("_125", 125);
            cls.AddConstValue("_140", 140);
            cls.AddConstValue("_150", 150);
            cls.AddConstValue("_180", 180);
            cls.AddConstValue("_200", 200);
            cls.AddConstValue("_240", 240);
            cls.AddConstValue("Target256", 256);
            cls.AddConstValue("_400", 400);
            return cls;
        }
    }
}
#endif
#endif
