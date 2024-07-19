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
    // Assembly: UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2019.4.40f1/Unity.app/Contents/Managed/UnityEngine/UnityEngine.IMGUIModule.dll
    // Type: UnityEngine.EventType
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_EventType
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("EventType", typeof(UnityEngine.EventType));
            cls.AddConstValue("MouseDown", 0);
            cls.AddConstValue("MouseUp", 1);
            cls.AddConstValue("MouseMove", 2);
            cls.AddConstValue("MouseDrag", 3);
            cls.AddConstValue("KeyDown", 4);
            cls.AddConstValue("KeyUp", 5);
            cls.AddConstValue("ScrollWheel", 6);
            cls.AddConstValue("Repaint", 7);
            cls.AddConstValue("Layout", 8);
            cls.AddConstValue("DragUpdated", 9);
            cls.AddConstValue("DragPerform", 10);
            cls.AddConstValue("Ignore", 11);
            cls.AddConstValue("Used", 12);
            cls.AddConstValue("ValidateCommand", 13);
            cls.AddConstValue("ExecuteCommand", 14);
            cls.AddConstValue("DragExited", 15);
            cls.AddConstValue("ContextClick", 16);
            cls.AddConstValue("MouseEnterWindow", 20);
            cls.AddConstValue("MouseLeaveWindow", 21);
            return cls;
        }
    }
}
#endif
