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
    // Type: UnityEditor.PlayerSettings+Switch+Languages
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_PlayerSettings_Switch_Languages
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("Languages", typeof(UnityEditor.PlayerSettings.Switch.Languages));
            cls.AddConstValue("AmericanEnglish", 0);
            cls.AddConstValue("BritishEnglish", 1);
            cls.AddConstValue("Japanese", 2);
            cls.AddConstValue("French", 3);
            cls.AddConstValue("German", 4);
            cls.AddConstValue("LatinAmericanSpanish", 5);
            cls.AddConstValue("Spanish", 6);
            cls.AddConstValue("Italian", 7);
            cls.AddConstValue("Dutch", 8);
            cls.AddConstValue("CanadianFrench", 9);
            cls.AddConstValue("Portuguese", 10);
            cls.AddConstValue("Russian", 11);
            cls.AddConstValue("SimplifiedChinese", 12);
            cls.AddConstValue("TraditionalChinese", 13);
            cls.AddConstValue("Korean", 14);
            cls.AddConstValue("BrazilianPortuguese", 15);
            return cls;
        }
    }
}
#endif
#endif
