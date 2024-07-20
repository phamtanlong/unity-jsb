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
    // Type: UnityEditor.CameraEditor+Settings
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_CameraEditor_Settings
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.SerializedObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.CameraEditor.Settings), ".ctor", typeof(UnityEditor.SerializedObject), 0);
                    }
                    var o = new UnityEditor.CameraEditor.Settings(arg0);
                    var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                    return val;
                }
                throw new NoSuitableMethodException("constructor", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_OnEnable(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.CameraEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.OnEnable();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("OnEnable", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Update(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.CameraEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.Update();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Update", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ApplyModifiedProperties(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.CameraEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.ApplyModifiedProperties();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ApplyModifiedProperties", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawClearFlags(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.CameraEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawClearFlags();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawClearFlags", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawBackgroundColor(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.CameraEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawBackgroundColor();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawBackgroundColor", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawCullingMask(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.CameraEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawCullingMask();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawCullingMask", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawProjection(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.CameraEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawProjection();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawProjection", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawClippingPlanes(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.CameraEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawClippingPlanes();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawClippingPlanes", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawNormalizedViewPort(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.CameraEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawNormalizedViewPort();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawNormalizedViewPort", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawDepth(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.CameraEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawDepth();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawDepth", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawRenderingPath(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.CameraEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawRenderingPath();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawRenderingPath", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawTargetTexture(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.CameraEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    bool arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.CameraEditor.Settings), "DrawTargetTexture", typeof(bool), 0);
                    }
                    self.DrawTargetTexture(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawTargetTexture", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawOcclusionCulling(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.CameraEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawOcclusionCulling();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawOcclusionCulling", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawHDR(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.CameraEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawHDR();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawHDR", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawMSAA(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.CameraEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawMSAA();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawMSAA", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawDynamicResolution(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.CameraEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawDynamicResolution();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawDynamicResolution", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawVR(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.CameraEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawVR();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawVR", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawMultiDisplay(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.CameraEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawMultiDisplay();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawMultiDisplay", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawTargetEye(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.CameraEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawTargetEye();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawTargetEye", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawCameraWarnings(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Camera arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.CameraEditor.Settings), "DrawCameraWarnings", typeof(UnityEngine.Camera), 0);
                    }
                    UnityEditor.CameraEditor.Settings.DrawCameraWarnings(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawCameraWarnings", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_ApertureFormatNames(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.CameraEditor.Settings.ApertureFormatNames;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_ApertureFormatValues(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.CameraEditor.Settings.ApertureFormatValues;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_clearFlags(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.CameraEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.clearFlags;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_backgroundColor(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.CameraEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.backgroundColor;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_normalizedViewPortRect(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.CameraEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.normalizedViewPortRect;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_sensorSize(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.CameraEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.sensorSize;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_lensShift(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.CameraEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.lensShift;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_focalLength(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.CameraEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.focalLength;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_gateFit(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.CameraEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.gateFit;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_verticalFOV(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.CameraEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.verticalFOV;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_orthographic(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.CameraEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.orthographic;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_orthographicSize(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.CameraEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.orthographicSize;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_depth(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.CameraEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.depth;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_cullingMask(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.CameraEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.cullingMask;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_renderingPath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.CameraEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.renderingPath;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_occlusionCulling(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.CameraEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.occlusionCulling;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_targetTexture(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.CameraEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.targetTexture;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_HDR(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.CameraEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.HDR;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_allowMSAA(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.CameraEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.allowMSAA;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_allowDynamicResolution(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.CameraEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.allowDynamicResolution;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_stereoConvergence(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.CameraEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.stereoConvergence;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_stereoSeparation(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.CameraEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.stereoSeparation;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_nearClippingPlane(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.CameraEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.nearClippingPlane;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_farClippingPlane(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.CameraEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.farClippingPlane;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_fovAxisMode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.CameraEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.fovAxisMode;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_targetDisplay(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.CameraEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.targetDisplay;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_targetEye(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.CameraEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.targetEye;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("Settings", typeof(UnityEditor.CameraEditor.Settings), BindConstructor);
            cls.AddMethod(false, "OnEnable", Bind_OnEnable);
            cls.AddMethod(false, "Update", Bind_Update);
            cls.AddMethod(false, "ApplyModifiedProperties", Bind_ApplyModifiedProperties);
            cls.AddMethod(false, "DrawClearFlags", Bind_DrawClearFlags);
            cls.AddMethod(false, "DrawBackgroundColor", Bind_DrawBackgroundColor);
            cls.AddMethod(false, "DrawCullingMask", Bind_DrawCullingMask);
            cls.AddMethod(false, "DrawProjection", Bind_DrawProjection);
            cls.AddMethod(false, "DrawClippingPlanes", Bind_DrawClippingPlanes);
            cls.AddMethod(false, "DrawNormalizedViewPort", Bind_DrawNormalizedViewPort);
            cls.AddMethod(false, "DrawDepth", Bind_DrawDepth);
            cls.AddMethod(false, "DrawRenderingPath", Bind_DrawRenderingPath);
            cls.AddMethod(false, "DrawTargetTexture", Bind_DrawTargetTexture);
            cls.AddMethod(false, "DrawOcclusionCulling", Bind_DrawOcclusionCulling);
            cls.AddMethod(false, "DrawHDR", Bind_DrawHDR);
            cls.AddMethod(false, "DrawMSAA", Bind_DrawMSAA);
            cls.AddMethod(false, "DrawDynamicResolution", Bind_DrawDynamicResolution);
            cls.AddMethod(false, "DrawVR", Bind_DrawVR);
            cls.AddMethod(false, "DrawMultiDisplay", Bind_DrawMultiDisplay);
            cls.AddMethod(false, "DrawTargetEye", Bind_DrawTargetEye);
            cls.AddMethod(true, "DrawCameraWarnings", BindStatic_DrawCameraWarnings);
            cls.AddProperty(true, "ApertureFormatNames", BindStaticRead_ApertureFormatNames, null);
            cls.AddProperty(true, "ApertureFormatValues", BindStaticRead_ApertureFormatValues, null);
            cls.AddProperty(false, "clearFlags", BindRead_clearFlags, null);
            cls.AddProperty(false, "backgroundColor", BindRead_backgroundColor, null);
            cls.AddProperty(false, "normalizedViewPortRect", BindRead_normalizedViewPortRect, null);
            cls.AddProperty(false, "sensorSize", BindRead_sensorSize, null);
            cls.AddProperty(false, "lensShift", BindRead_lensShift, null);
            cls.AddProperty(false, "focalLength", BindRead_focalLength, null);
            cls.AddProperty(false, "gateFit", BindRead_gateFit, null);
            cls.AddProperty(false, "verticalFOV", BindRead_verticalFOV, null);
            cls.AddProperty(false, "orthographic", BindRead_orthographic, null);
            cls.AddProperty(false, "orthographicSize", BindRead_orthographicSize, null);
            cls.AddProperty(false, "depth", BindRead_depth, null);
            cls.AddProperty(false, "cullingMask", BindRead_cullingMask, null);
            cls.AddProperty(false, "renderingPath", BindRead_renderingPath, null);
            cls.AddProperty(false, "occlusionCulling", BindRead_occlusionCulling, null);
            cls.AddProperty(false, "targetTexture", BindRead_targetTexture, null);
            cls.AddProperty(false, "HDR", BindRead_HDR, null);
            cls.AddProperty(false, "allowMSAA", BindRead_allowMSAA, null);
            cls.AddProperty(false, "allowDynamicResolution", BindRead_allowDynamicResolution, null);
            cls.AddProperty(false, "stereoConvergence", BindRead_stereoConvergence, null);
            cls.AddProperty(false, "stereoSeparation", BindRead_stereoSeparation, null);
            cls.AddProperty(false, "nearClippingPlane", BindRead_nearClippingPlane, null);
            cls.AddProperty(false, "farClippingPlane", BindRead_farClippingPlane, null);
            cls.AddProperty(false, "fovAxisMode", BindRead_fovAxisMode, null);
            cls.AddProperty(false, "targetDisplay", BindRead_targetDisplay, null);
            cls.AddProperty(false, "targetEye", BindRead_targetEye, null);
            return cls;
        }
    }
}
#endif
#endif
