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
    // Type: UnityEditor.MouseCursor
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_MouseCursor
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("MouseCursor", typeof(UnityEditor.MouseCursor));
            cls.AddConstValue("Arrow", 0);
            cls.AddConstValue("Text", 1);
            cls.AddConstValue("ResizeVertical", 2);
            cls.AddConstValue("ResizeHorizontal", 3);
            cls.AddConstValue("Link", 4);
            cls.AddConstValue("SlideArrow", 5);
            cls.AddConstValue("ResizeUpRight", 6);
            cls.AddConstValue("ResizeUpLeft", 7);
            cls.AddConstValue("MoveArrow", 8);
            cls.AddConstValue("RotateArrow", 9);
            cls.AddConstValue("ScaleArrow", 10);
            cls.AddConstValue("ArrowPlus", 11);
            cls.AddConstValue("ArrowMinus", 12);
            cls.AddConstValue("Pan", 13);
            cls.AddConstValue("Orbit", 14);
            cls.AddConstValue("Zoom", 15);
            cls.AddConstValue("FPS", 16);
            cls.AddConstValue("CustomCursor", 17);
            cls.AddConstValue("SplitResizeUpDown", 18);
            cls.AddConstValue("SplitResizeLeftRight", 19);
            return cls;
        }
    }
}
#endif
#endif
