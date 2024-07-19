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
    // Type: UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle+Axes
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_IMGUI_Controls_PrimitiveBoundsHandle_Axes
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("Axes", typeof(UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle.Axes));
            cls.AddConstValue("None", 0);
            cls.AddConstValue("X", 1);
            cls.AddConstValue("Y", 2);
            cls.AddConstValue("Z", 4);
            cls.AddConstValue("All", 7);
            return cls;
        }
    }
}
#endif
#endif
