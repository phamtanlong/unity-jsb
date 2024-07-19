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
    // Type: UnityEditor.IMGUI.Controls.MultiColumnHeader+DefaultStyles
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_IMGUI_Controls_MultiColumnHeader_DefaultStyles
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_columnHeader(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.IMGUI.Controls.MultiColumnHeader.DefaultStyles.columnHeader;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_columnHeader(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader.DefaultStyles), "columnHeader", typeof(UnityEngine.GUIStyle), 0);
                }
                UnityEditor.IMGUI.Controls.MultiColumnHeader.DefaultStyles.columnHeader = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_columnHeaderRightAligned(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.IMGUI.Controls.MultiColumnHeader.DefaultStyles.columnHeaderRightAligned;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_columnHeaderRightAligned(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader.DefaultStyles), "columnHeaderRightAligned", typeof(UnityEngine.GUIStyle), 0);
                }
                UnityEditor.IMGUI.Controls.MultiColumnHeader.DefaultStyles.columnHeaderRightAligned = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_columnHeaderCenterAligned(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.IMGUI.Controls.MultiColumnHeader.DefaultStyles.columnHeaderCenterAligned;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_columnHeaderCenterAligned(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader.DefaultStyles), "columnHeaderCenterAligned", typeof(UnityEngine.GUIStyle), 0);
                }
                UnityEditor.IMGUI.Controls.MultiColumnHeader.DefaultStyles.columnHeaderCenterAligned = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_background(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.IMGUI.Controls.MultiColumnHeader.DefaultStyles.background;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_background(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader.DefaultStyles), "background", typeof(UnityEngine.GUIStyle), 0);
                }
                UnityEditor.IMGUI.Controls.MultiColumnHeader.DefaultStyles.background = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("DefaultStyles", typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader.DefaultStyles), QuickJS.JSNative.class_private_ctor);
            cls.AddField(true, "columnHeader", BindStaticRead_columnHeader, BindStaticWrite_columnHeader);
            cls.AddField(true, "columnHeaderRightAligned", BindStaticRead_columnHeaderRightAligned, BindStaticWrite_columnHeaderRightAligned);
            cls.AddField(true, "columnHeaderCenterAligned", BindStaticRead_columnHeaderCenterAligned, BindStaticWrite_columnHeaderCenterAligned);
            cls.AddField(true, "background", BindStaticRead_background, BindStaticWrite_background);
            return cls;
        }
    }
}
#endif
#endif
