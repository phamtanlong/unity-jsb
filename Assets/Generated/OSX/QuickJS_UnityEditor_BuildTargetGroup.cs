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
    // Type: UnityEditor.BuildTargetGroup
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_BuildTargetGroup
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("BuildTargetGroup", typeof(UnityEditor.BuildTargetGroup));
            cls.AddConstValue("Unknown", 0);
            cls.AddConstValue("Standalone", 1);
            cls.AddConstValue("WebPlayer", 2);
            cls.AddConstValue("iPhone", 4);
            cls.AddConstValue("iOS", 4);
            cls.AddConstValue("PS3", 5);
            cls.AddConstValue("XBOX360", 6);
            cls.AddConstValue("Android", 7);
            cls.AddConstValue("WebGL", 13);
            cls.AddConstValue("WSA", 14);
            cls.AddConstValue("Metro", 14);
            cls.AddConstValue("WP8", 15);
            cls.AddConstValue("BlackBerry", 16);
            cls.AddConstValue("Tizen", 17);
            cls.AddConstValue("PSP2", 18);
            cls.AddConstValue("PS4", 19);
            cls.AddConstValue("PSM", 20);
            cls.AddConstValue("XboxOne", 21);
            cls.AddConstValue("SamsungTV", 22);
            cls.AddConstValue("N3DS", 23);
            cls.AddConstValue("WiiU", 24);
            cls.AddConstValue("tvOS", 25);
            cls.AddConstValue("Facebook", 26);
            cls.AddConstValue("Switch", 27);
            cls.AddConstValue("Lumin", 28);
            cls.AddConstValue("Stadia", 29);
            cls.AddConstValue("CloudRendering", 30);
            cls.AddConstValue("GameCoreScarlett", 31);
            cls.AddConstValue("GameCoreXboxSeries", 31);
            cls.AddConstValue("GameCoreXboxOne", 32);
            cls.AddConstValue("PS5", 33);
            return cls;
        }
    }
}
#endif
#endif
