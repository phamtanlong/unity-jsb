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
    // Type: UnityEditor.VideoResizeMode
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_VideoResizeMode
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("VideoResizeMode", typeof(UnityEditor.VideoResizeMode));
            cls.AddConstValue("OriginalSize", 0);
            cls.AddConstValue("ThreeQuarterRes", 1);
            cls.AddConstValue("HalfRes", 2);
            cls.AddConstValue("QuarterRes", 3);
            cls.AddConstValue("Square1024", 4);
            cls.AddConstValue("Square512", 5);
            cls.AddConstValue("Square256", 6);
            cls.AddConstValue("CustomSize", 7);
            return cls;
        }
    }
}
#endif
#endif
