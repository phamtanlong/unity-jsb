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
    // Type: UnityEditor.PlayerSettings+Switch+RatingCategories
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_PlayerSettings_Switch_RatingCategories
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("RatingCategories", typeof(UnityEditor.PlayerSettings.Switch.RatingCategories));
            cls.AddConstValue("CERO", 0);
            cls.AddConstValue("GRACGCRB", 1);
            cls.AddConstValue("GSRMR", 2);
            cls.AddConstValue("ESRB", 3);
            cls.AddConstValue("ClassInd", 4);
            cls.AddConstValue("USK", 5);
            cls.AddConstValue("PEGI", 6);
            cls.AddConstValue("PEGIPortugal", 7);
            cls.AddConstValue("PEGIBBFC", 8);
            cls.AddConstValue("Russian", 9);
            cls.AddConstValue("ACB", 10);
            cls.AddConstValue("OFLC", 11);
            cls.AddConstValue("IARCGeneric", 12);
            return cls;
        }
    }
}
#endif
#endif
