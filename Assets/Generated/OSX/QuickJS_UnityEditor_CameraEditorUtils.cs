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
    // Type: UnityEditor.CameraEditorUtils
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_CameraEditorUtils
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_HandleFrustum(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Camera arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.CameraEditorUtils), "HandleFrustum", typeof(UnityEngine.Camera), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.CameraEditorUtils), "HandleFrustum", typeof(int), 1);
                    }
                    UnityEditor.CameraEditorUtils.HandleFrustum(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("HandleFrustum", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawFrustumGizmo(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Camera arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.CameraEditorUtils), "DrawFrustumGizmo", typeof(UnityEngine.Camera), 0);
                    }
                    UnityEditor.CameraEditorUtils.DrawFrustumGizmo(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawFrustumGizmo", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_TryGetSensorGateFrustum(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 4)
                {
                    UnityEngine.Camera arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.CameraEditorUtils), "TryGetSensorGateFrustum", typeof(UnityEngine.Camera), 0);
                    }
                    UnityEngine.Vector3[] arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.CameraEditorUtils), "TryGetSensorGateFrustum", typeof(UnityEngine.Vector3[]), 1);
                    }
                    UnityEngine.Vector3[] arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.CameraEditorUtils), "TryGetSensorGateFrustum", typeof(UnityEngine.Vector3[]), 2);
                    }
                    float arg3;
                    var ret = UnityEditor.CameraEditorUtils.TryGetSensorGateFrustum(arg0, arg1, arg2, out arg3);
                    var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg3);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[3], context.GetAtom("value"), out0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("TryGetSensorGateFrustum", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_TryGetFrustum(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 4)
                {
                    UnityEngine.Camera arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.CameraEditorUtils), "TryGetFrustum", typeof(UnityEngine.Camera), 0);
                    }
                    UnityEngine.Vector3[] arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.CameraEditorUtils), "TryGetFrustum", typeof(UnityEngine.Vector3[]), 1);
                    }
                    UnityEngine.Vector3[] arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.CameraEditorUtils), "TryGetFrustum", typeof(UnityEngine.Vector3[]), 2);
                    }
                    float arg3;
                    var ret = UnityEditor.CameraEditorUtils.TryGetFrustum(arg0, arg1, arg2, out arg3);
                    var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg3);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[3], context.GetAtom("value"), out0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("TryGetFrustum", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsViewportRectValidToRender(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.CameraEditorUtils), "IsViewportRectValidToRender", typeof(UnityEngine.Rect), 0);
                    }
                    var ret = UnityEditor.CameraEditorUtils.IsViewportRectValidToRender(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsViewportRectValidToRender", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetFrustumAspectRatio(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Camera arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.CameraEditorUtils), "GetFrustumAspectRatio", typeof(UnityEngine.Camera), 0);
                    }
                    var ret = UnityEditor.CameraEditorUtils.GetFrustumAspectRatio(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetFrustumAspectRatio", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_PerspectiveClipToWorld(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Matrix4x4 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.CameraEditorUtils), "PerspectiveClipToWorld", typeof(UnityEngine.Matrix4x4), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.CameraEditorUtils), "PerspectiveClipToWorld", typeof(UnityEngine.Vector3), 1);
                    }
                    UnityEngine.Vector3 arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.CameraEditorUtils), "PerspectiveClipToWorld", typeof(UnityEngine.Vector3), 2);
                    }
                    var ret = UnityEditor.CameraEditorUtils.PerspectiveClipToWorld(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("PerspectiveClipToWorld", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetFrustumPlaneAt(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 4)
                {
                    UnityEngine.Matrix4x4 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.CameraEditorUtils), "GetFrustumPlaneAt", typeof(UnityEngine.Matrix4x4), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.CameraEditorUtils), "GetFrustumPlaneAt", typeof(UnityEngine.Vector3), 1);
                    }
                    float arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.CameraEditorUtils), "GetFrustumPlaneAt", typeof(float), 2);
                    }
                    UnityEngine.Vector3[] arg3;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.CameraEditorUtils), "GetFrustumPlaneAt", typeof(UnityEngine.Vector3[]), 3);
                    }
                    UnityEditor.CameraEditorUtils.GetFrustumPlaneAt(arg0, arg1, arg2, arg3);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("GetFrustumPlaneAt", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_GameViewAspectRatio(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.CameraEditorUtils.GameViewAspectRatio;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("CameraEditorUtils", typeof(UnityEditor.CameraEditorUtils), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "HandleFrustum", BindStatic_HandleFrustum);
            cls.AddMethod(true, "DrawFrustumGizmo", BindStatic_DrawFrustumGizmo);
            cls.AddMethod(true, "TryGetSensorGateFrustum", BindStatic_TryGetSensorGateFrustum);
            cls.AddMethod(true, "TryGetFrustum", BindStatic_TryGetFrustum);
            cls.AddMethod(true, "IsViewportRectValidToRender", BindStatic_IsViewportRectValidToRender);
            cls.AddMethod(true, "GetFrustumAspectRatio", BindStatic_GetFrustumAspectRatio);
            cls.AddMethod(true, "PerspectiveClipToWorld", BindStatic_PerspectiveClipToWorld);
            cls.AddMethod(true, "GetFrustumPlaneAt", BindStatic_GetFrustumPlaneAt);
            cls.AddProperty(true, "GameViewAspectRatio", BindStaticRead_GameViewAspectRatio, null);
            return cls;
        }
    }
}
#endif
#endif
