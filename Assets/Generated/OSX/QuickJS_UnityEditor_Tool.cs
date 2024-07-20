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
    // Type: UnityEditor.Tool
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_Tool
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("Tool", typeof(UnityEditor.Tool));
            cls.AddConstValue("View", 0);
            cls.AddConstValue("Move", 1);
            cls.AddConstValue("Rotate", 2);
            cls.AddConstValue("Scale", 3);
            cls.AddConstValue("Rect", 4);
            cls.AddConstValue("Transform", 5);
            cls.AddConstValue("Custom", 6);
            cls.AddConstValue("None", -1);
            return cls;
        }
    }
}
#endif
#endif
