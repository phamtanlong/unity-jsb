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
    // Assembly: UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Users/longpt/Documents/SkyMavis/unity-jsb-2021/Library/ScriptAssemblies/UnityEngine.UI.dll
    // Type: UnityEngine.EventSystems.PointerEventData+FramePressState
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_EventSystems_PointerEventData_FramePressState
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("FramePressState", typeof(UnityEngine.EventSystems.PointerEventData.FramePressState));
            cls.AddConstValue("Pressed", 0);
            cls.AddConstValue("Released", 1);
            cls.AddConstValue("PressedAndReleased", 2);
            cls.AddConstValue("NotChanged", 3);
            return cls;
        }
    }
}
#endif
