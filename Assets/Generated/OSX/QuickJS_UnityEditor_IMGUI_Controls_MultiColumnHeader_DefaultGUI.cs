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
    // Type: UnityEditor.IMGUI.Controls.MultiColumnHeader+DefaultGUI
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_IMGUI_Controls_MultiColumnHeader_DefaultGUI
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_defaultHeight(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.IMGUI.Controls.MultiColumnHeader.DefaultGUI.defaultHeight;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_minimumHeight(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.IMGUI.Controls.MultiColumnHeader.DefaultGUI.minimumHeight;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_columnContentMargin(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.IMGUI.Controls.MultiColumnHeader.DefaultGUI.columnContentMargin;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("DefaultGUI", typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader.DefaultGUI), QuickJS.JSNative.class_private_ctor);
            cls.AddProperty(true, "defaultHeight", BindStaticRead_defaultHeight, null);
            cls.AddProperty(true, "minimumHeight", BindStaticRead_minimumHeight, null);
            cls.AddProperty(true, "columnContentMargin", BindStaticRead_columnContentMargin, null);
            return cls;
        }
    }
}
#endif
#endif
