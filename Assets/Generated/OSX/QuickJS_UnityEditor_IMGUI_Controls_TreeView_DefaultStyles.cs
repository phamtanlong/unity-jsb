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
    // Type: UnityEditor.IMGUI.Controls.TreeView+DefaultStyles
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_IMGUI_Controls_TreeView_DefaultStyles
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_foldoutLabel(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.IMGUI.Controls.TreeView.DefaultStyles.foldoutLabel;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_foldoutLabel(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.TreeView.DefaultStyles), "foldoutLabel", typeof(UnityEngine.GUIStyle), 0);
                }
                UnityEditor.IMGUI.Controls.TreeView.DefaultStyles.foldoutLabel = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_label(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.IMGUI.Controls.TreeView.DefaultStyles.label;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_label(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.TreeView.DefaultStyles), "label", typeof(UnityEngine.GUIStyle), 0);
                }
                UnityEditor.IMGUI.Controls.TreeView.DefaultStyles.label = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_labelRightAligned(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.IMGUI.Controls.TreeView.DefaultStyles.labelRightAligned;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_labelRightAligned(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.TreeView.DefaultStyles), "labelRightAligned", typeof(UnityEngine.GUIStyle), 0);
                }
                UnityEditor.IMGUI.Controls.TreeView.DefaultStyles.labelRightAligned = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_boldLabel(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.IMGUI.Controls.TreeView.DefaultStyles.boldLabel;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_boldLabel(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.TreeView.DefaultStyles), "boldLabel", typeof(UnityEngine.GUIStyle), 0);
                }
                UnityEditor.IMGUI.Controls.TreeView.DefaultStyles.boldLabel = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_boldLabelRightAligned(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.IMGUI.Controls.TreeView.DefaultStyles.boldLabelRightAligned;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_boldLabelRightAligned(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.TreeView.DefaultStyles), "boldLabelRightAligned", typeof(UnityEngine.GUIStyle), 0);
                }
                UnityEditor.IMGUI.Controls.TreeView.DefaultStyles.boldLabelRightAligned = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_backgroundEven(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.IMGUI.Controls.TreeView.DefaultStyles.backgroundEven;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_backgroundEven(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.TreeView.DefaultStyles), "backgroundEven", typeof(UnityEngine.GUIStyle), 0);
                }
                UnityEditor.IMGUI.Controls.TreeView.DefaultStyles.backgroundEven = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_backgroundOdd(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.IMGUI.Controls.TreeView.DefaultStyles.backgroundOdd;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_backgroundOdd(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.TreeView.DefaultStyles), "backgroundOdd", typeof(UnityEngine.GUIStyle), 0);
                }
                UnityEditor.IMGUI.Controls.TreeView.DefaultStyles.backgroundOdd = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("DefaultStyles", typeof(UnityEditor.IMGUI.Controls.TreeView.DefaultStyles), QuickJS.JSNative.class_private_ctor);
            cls.AddField(true, "foldoutLabel", BindStaticRead_foldoutLabel, BindStaticWrite_foldoutLabel);
            cls.AddField(true, "label", BindStaticRead_label, BindStaticWrite_label);
            cls.AddField(true, "labelRightAligned", BindStaticRead_labelRightAligned, BindStaticWrite_labelRightAligned);
            cls.AddField(true, "boldLabel", BindStaticRead_boldLabel, BindStaticWrite_boldLabel);
            cls.AddField(true, "boldLabelRightAligned", BindStaticRead_boldLabelRightAligned, BindStaticWrite_boldLabelRightAligned);
            cls.AddField(true, "backgroundEven", BindStaticRead_backgroundEven, BindStaticWrite_backgroundEven);
            cls.AddField(true, "backgroundOdd", BindStaticRead_backgroundOdd, BindStaticWrite_backgroundOdd);
            return cls;
        }
    }
}
#endif
#endif
