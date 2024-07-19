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
    // Assembly: UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Users/longpt/Documents/SkyMavis/unity-jsb-2/Library/ScriptAssemblies/UnityEngine.UI.dll
    // Type: UnityEngine.EventSystems.EventTriggerType
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_EventSystems_EventTriggerType
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("EventTriggerType", typeof(UnityEngine.EventSystems.EventTriggerType));
            cls.AddConstValue("PointerEnter", 0);
            cls.AddConstValue("PointerExit", 1);
            cls.AddConstValue("PointerDown", 2);
            cls.AddConstValue("PointerUp", 3);
            cls.AddConstValue("PointerClick", 4);
            cls.AddConstValue("Drag", 5);
            cls.AddConstValue("Drop", 6);
            cls.AddConstValue("Scroll", 7);
            cls.AddConstValue("UpdateSelected", 8);
            cls.AddConstValue("Select", 9);
            cls.AddConstValue("Deselect", 10);
            cls.AddConstValue("Move", 11);
            cls.AddConstValue("InitializePotentialDrag", 12);
            cls.AddConstValue("BeginDrag", 13);
            cls.AddConstValue("EndDrag", 14);
            cls.AddConstValue("Submit", 15);
            cls.AddConstValue("Cancel", 16);
            return cls;
        }
    }
}
#endif
