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
    // Type: UnityEditor.GizmoType
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_GizmoType
    {
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateEnum("GizmoType", typeof(UnityEditor.GizmoType));
            cls.AddConstValue("Pickable", 1);
            cls.AddConstValue("NotInSelectionHierarchy", 2);
            cls.AddConstValue("Selected", 4);
            cls.AddConstValue("Active", 8);
            cls.AddConstValue("InSelectionHierarchy", 16);
            cls.AddConstValue("NonSelected", 32);
            cls.AddConstValue("NotSelected", -127);
            cls.AddConstValue("SelectedOrChild", -127);
            return cls;
        }
    }
}
#endif
#endif
