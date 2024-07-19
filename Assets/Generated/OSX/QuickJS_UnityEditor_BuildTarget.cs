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
    // Type: UnityEditor.BuildTarget
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_BuildTarget
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("BuildTarget", typeof(UnityEditor.BuildTarget));
            cls.AddConstValue("StandaloneOSX", 2);
            cls.AddConstValue("StandaloneOSXUniversal", 3);
            cls.AddConstValue("StandaloneOSXIntel", 4);
            cls.AddConstValue("StandaloneWindows", 5);
            cls.AddConstValue("WebPlayer", 6);
            cls.AddConstValue("WebPlayerStreamed", 7);
            cls.AddConstValue("iOS", 9);
            cls.AddConstValue("PS3", 10);
            cls.AddConstValue("XBOX360", 11);
            cls.AddConstValue("Android", 13);
            cls.AddConstValue("StandaloneLinux", 17);
            cls.AddConstValue("StandaloneWindows64", 19);
            cls.AddConstValue("WebGL", 20);
            cls.AddConstValue("WSAPlayer", 21);
            cls.AddConstValue("StandaloneLinux64", 24);
            cls.AddConstValue("StandaloneLinuxUniversal", 25);
            cls.AddConstValue("WP8Player", 26);
            cls.AddConstValue("StandaloneOSXIntel64", 27);
            cls.AddConstValue("BlackBerry", 28);
            cls.AddConstValue("Tizen", 29);
            cls.AddConstValue("PSP2", 30);
            cls.AddConstValue("PS4", 31);
            cls.AddConstValue("PSM", 32);
            cls.AddConstValue("XboxOne", 33);
            cls.AddConstValue("SamsungTV", 34);
            cls.AddConstValue("N3DS", 35);
            cls.AddConstValue("WiiU", 36);
            cls.AddConstValue("tvOS", 37);
            cls.AddConstValue("Switch", 38);
            cls.AddConstValue("Lumin", 39);
            cls.AddConstValue("Stadia", 40);
            cls.AddConstValue("CloudRendering", 41);
            cls.AddConstValue("GameCoreScarlett", 42);
            cls.AddConstValue("GameCoreXboxSeries", 42);
            cls.AddConstValue("GameCoreXboxOne", 43);
            cls.AddConstValue("PS5", 44);
            cls.AddConstValue("NoTarget", -2);
            cls.AddConstValue("iPhone", -1);
            cls.AddConstValue("BB10", -1);
            cls.AddConstValue("MetroPlayer", -1);
            return cls;
        }
    }
}
#endif
#endif
