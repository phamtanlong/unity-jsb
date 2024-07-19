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
    // Type: UnityEditor.StaticOcclusionCullingVisualization
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_StaticOcclusionCullingVisualization
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_showOcclusionCulling(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.StaticOcclusionCullingVisualization.showOcclusionCulling;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_showOcclusionCulling(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.StaticOcclusionCullingVisualization), "showOcclusionCulling", typeof(bool), 0);
                }
                UnityEditor.StaticOcclusionCullingVisualization.showOcclusionCulling = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_showPreVisualization(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.StaticOcclusionCullingVisualization.showPreVisualization;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_showPreVisualization(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.StaticOcclusionCullingVisualization), "showPreVisualization", typeof(bool), 0);
                }
                UnityEditor.StaticOcclusionCullingVisualization.showPreVisualization = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_showViewVolumes(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.StaticOcclusionCullingVisualization.showViewVolumes;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_showViewVolumes(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.StaticOcclusionCullingVisualization), "showViewVolumes", typeof(bool), 0);
                }
                UnityEditor.StaticOcclusionCullingVisualization.showViewVolumes = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_showDynamicObjectBounds(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.StaticOcclusionCullingVisualization.showDynamicObjectBounds;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_showDynamicObjectBounds(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.StaticOcclusionCullingVisualization), "showDynamicObjectBounds", typeof(bool), 0);
                }
                UnityEditor.StaticOcclusionCullingVisualization.showDynamicObjectBounds = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_showPortals(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.StaticOcclusionCullingVisualization.showPortals;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_showPortals(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.StaticOcclusionCullingVisualization), "showPortals", typeof(bool), 0);
                }
                UnityEditor.StaticOcclusionCullingVisualization.showPortals = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_showVisibilityLines(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.StaticOcclusionCullingVisualization.showVisibilityLines;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_showVisibilityLines(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.StaticOcclusionCullingVisualization), "showVisibilityLines", typeof(bool), 0);
                }
                UnityEditor.StaticOcclusionCullingVisualization.showVisibilityLines = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_showGeometryCulling(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.StaticOcclusionCullingVisualization.showGeometryCulling;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_showGeometryCulling(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.StaticOcclusionCullingVisualization), "showGeometryCulling", typeof(bool), 0);
                }
                UnityEditor.StaticOcclusionCullingVisualization.showGeometryCulling = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_isPreviewOcclusionCullingCameraInPVS(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.StaticOcclusionCullingVisualization.isPreviewOcclusionCullingCameraInPVS;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_previewOcclusionCamera(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.StaticOcclusionCullingVisualization.previewOcclusionCamera;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_previewOcclucionCamera(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.StaticOcclusionCullingVisualization.previewOcclucionCamera;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("StaticOcclusionCullingVisualization", typeof(UnityEditor.StaticOcclusionCullingVisualization), QuickJS.JSNative.class_private_ctor);
            cls.AddProperty(true, "showOcclusionCulling", BindStaticRead_showOcclusionCulling, BindStaticWrite_showOcclusionCulling);
            cls.AddProperty(true, "showPreVisualization", BindStaticRead_showPreVisualization, BindStaticWrite_showPreVisualization);
            cls.AddProperty(true, "showViewVolumes", BindStaticRead_showViewVolumes, BindStaticWrite_showViewVolumes);
            cls.AddProperty(true, "showDynamicObjectBounds", BindStaticRead_showDynamicObjectBounds, BindStaticWrite_showDynamicObjectBounds);
            cls.AddProperty(true, "showPortals", BindStaticRead_showPortals, BindStaticWrite_showPortals);
            cls.AddProperty(true, "showVisibilityLines", BindStaticRead_showVisibilityLines, BindStaticWrite_showVisibilityLines);
            cls.AddProperty(true, "showGeometryCulling", BindStaticRead_showGeometryCulling, BindStaticWrite_showGeometryCulling);
            cls.AddProperty(true, "isPreviewOcclusionCullingCameraInPVS", BindStaticRead_isPreviewOcclusionCullingCameraInPVS, null);
            cls.AddProperty(true, "previewOcclusionCamera", BindStaticRead_previewOcclusionCamera, null);
            cls.AddProperty(true, "previewOcclucionCamera", BindStaticRead_previewOcclucionCamera, null);
            return cls;
        }
    }
}
#endif
#endif
