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
    // Type: UnityEditor.GameViewSizeGroupType
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_GameViewSizeGroupType
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("GameViewSizeGroupType", typeof(UnityEditor.GameViewSizeGroupType));
            cls.AddConstValue("Standalone", 0);
            cls.AddConstValue("WebPlayer", 1);
            cls.AddConstValue("iOS", 2);
            cls.AddConstValue("Android", 3);
            cls.AddConstValue("PS3", 4);
            cls.AddConstValue("WiiU", 5);
            cls.AddConstValue("Tizen", 6);
            cls.AddConstValue("WP8", 7);
            cls.AddConstValue("N3DS", 8);
            cls.AddConstValue("HMD", 9);
            return cls;
        }
    }
}
#endif
#endif
