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
    // Type: UnityEditor.LightEditor+Settings
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_LightEditor_Settings
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
                        throw new ParameterException(typeof(UnityEditor.LightEditor.Settings), ".ctor", typeof(UnityEditor.SerializedObject), 0);
                    }
                    var o = new UnityEditor.LightEditor.Settings(arg0);
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
                    UnityEditor.LightEditor.Settings self;
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
        public static JSValue Bind_OnDestroy(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.LightEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.OnDestroy();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("OnDestroy", argc);
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
                    UnityEditor.LightEditor.Settings self;
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
        public static JSValue Bind_DrawLightType(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.LightEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawLightType();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawLightType", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawRange(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.LightEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    bool arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.LightEditor.Settings), "DrawRange", typeof(bool), 0);
                    }
                    self.DrawRange(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawRange", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawSpotAngle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.LightEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawSpotAngle();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawSpotAngle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawInnerAndOuterSpotAngle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.LightEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawInnerAndOuterSpotAngle();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawInnerAndOuterSpotAngle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawArea(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.LightEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawArea();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawArea", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawColor(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.LightEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawColor();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawColor", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawLightmapping(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.LightEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawLightmapping();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawLightmapping", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawIntensity(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.LightEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawIntensity();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawIntensity", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawBounceIntensity(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.LightEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawBounceIntensity();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawBounceIntensity", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawCookie(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.LightEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawCookie();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawCookie", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawCookieSize(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.LightEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawCookieSize();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawCookieSize", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawHalo(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.LightEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawHalo();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawHalo", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawFlare(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.LightEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawFlare();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawFlare", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawRenderMode(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.LightEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawRenderMode();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawRenderMode", argc);
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
                    UnityEditor.LightEditor.Settings self;
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
        public static JSValue Bind_DrawRenderingLayerMask(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.LightEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawRenderingLayerMask();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawRenderingLayerMask", argc);
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
                    UnityEditor.LightEditor.Settings self;
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
        public static JSValue Bind_DrawShadowsType(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.LightEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawShadowsType();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawShadowsType", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawBakedShadowRadius(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.LightEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawBakedShadowRadius();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawBakedShadowRadius", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawBakedShadowAngle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.LightEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawBakedShadowAngle();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawBakedShadowAngle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawRuntimeShadow(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.LightEditor.Settings self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawRuntimeShadow();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawRuntimeShadow", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_lightType(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.lightType;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_lightShape(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.lightShape;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_range(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.range;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_spotAngle(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.spotAngle;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_innerSpotAngle(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.innerSpotAngle;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_cookieSize(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.cookieSize;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_color(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.color;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_intensity(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.intensity;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_bounceIntensity(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.bounceIntensity;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_colorTemperature(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.colorTemperature;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_useColorTemperature(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.useColorTemperature;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_cookieProp(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.cookieProp;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_shadowsType(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.shadowsType;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_shadowsStrength(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.shadowsStrength;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_shadowsResolution(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.shadowsResolution;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_shadowsBias(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.shadowsBias;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_shadowsNormalBias(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.shadowsNormalBias;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_shadowsNearPlane(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.shadowsNearPlane;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_halo(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.halo;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_flare(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.flare;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_renderMode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.renderMode;
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
                UnityEditor.LightEditor.Settings self;
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
        public static JSValue BindRead_renderingLayerMask(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.renderingLayerMask;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_lightmapping(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.lightmapping;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_areaSizeX(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.areaSizeX;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_areaSizeY(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.areaSizeY;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_bakedShadowRadiusProp(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.bakedShadowRadiusProp;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_bakedShadowAngleProp(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.bakedShadowAngleProp;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_isRealtime(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.isRealtime;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_isMixed(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.isMixed;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_isCompletelyBaked(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.isCompletelyBaked;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_isBakedOrMixed(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.isBakedOrMixed;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_isAreaLightType(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.isAreaLightType;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_light(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.light;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_cookie(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.LightEditor.Settings self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.cookie;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("Settings", typeof(UnityEditor.LightEditor.Settings), BindConstructor);
            cls.AddMethod(false, "OnEnable", Bind_OnEnable);
            cls.AddMethod(false, "OnDestroy", Bind_OnDestroy);
            cls.AddMethod(false, "Update", Bind_Update);
            cls.AddMethod(false, "DrawLightType", Bind_DrawLightType);
            cls.AddMethod(false, "DrawRange", Bind_DrawRange);
            cls.AddMethod(false, "DrawSpotAngle", Bind_DrawSpotAngle);
            cls.AddMethod(false, "DrawInnerAndOuterSpotAngle", Bind_DrawInnerAndOuterSpotAngle);
            cls.AddMethod(false, "DrawArea", Bind_DrawArea);
            cls.AddMethod(false, "DrawColor", Bind_DrawColor);
            cls.AddMethod(false, "DrawLightmapping", Bind_DrawLightmapping);
            cls.AddMethod(false, "DrawIntensity", Bind_DrawIntensity);
            cls.AddMethod(false, "DrawBounceIntensity", Bind_DrawBounceIntensity);
            cls.AddMethod(false, "DrawCookie", Bind_DrawCookie);
            cls.AddMethod(false, "DrawCookieSize", Bind_DrawCookieSize);
            cls.AddMethod(false, "DrawHalo", Bind_DrawHalo);
            cls.AddMethod(false, "DrawFlare", Bind_DrawFlare);
            cls.AddMethod(false, "DrawRenderMode", Bind_DrawRenderMode);
            cls.AddMethod(false, "DrawCullingMask", Bind_DrawCullingMask);
            cls.AddMethod(false, "DrawRenderingLayerMask", Bind_DrawRenderingLayerMask);
            cls.AddMethod(false, "ApplyModifiedProperties", Bind_ApplyModifiedProperties);
            cls.AddMethod(false, "DrawShadowsType", Bind_DrawShadowsType);
            cls.AddMethod(false, "DrawBakedShadowRadius", Bind_DrawBakedShadowRadius);
            cls.AddMethod(false, "DrawBakedShadowAngle", Bind_DrawBakedShadowAngle);
            cls.AddMethod(false, "DrawRuntimeShadow", Bind_DrawRuntimeShadow);
            cls.AddProperty(false, "lightType", BindRead_lightType, null);
            cls.AddProperty(false, "lightShape", BindRead_lightShape, null);
            cls.AddProperty(false, "range", BindRead_range, null);
            cls.AddProperty(false, "spotAngle", BindRead_spotAngle, null);
            cls.AddProperty(false, "innerSpotAngle", BindRead_innerSpotAngle, null);
            cls.AddProperty(false, "cookieSize", BindRead_cookieSize, null);
            cls.AddProperty(false, "color", BindRead_color, null);
            cls.AddProperty(false, "intensity", BindRead_intensity, null);
            cls.AddProperty(false, "bounceIntensity", BindRead_bounceIntensity, null);
            cls.AddProperty(false, "colorTemperature", BindRead_colorTemperature, null);
            cls.AddProperty(false, "useColorTemperature", BindRead_useColorTemperature, null);
            cls.AddProperty(false, "cookieProp", BindRead_cookieProp, null);
            cls.AddProperty(false, "shadowsType", BindRead_shadowsType, null);
            cls.AddProperty(false, "shadowsStrength", BindRead_shadowsStrength, null);
            cls.AddProperty(false, "shadowsResolution", BindRead_shadowsResolution, null);
            cls.AddProperty(false, "shadowsBias", BindRead_shadowsBias, null);
            cls.AddProperty(false, "shadowsNormalBias", BindRead_shadowsNormalBias, null);
            cls.AddProperty(false, "shadowsNearPlane", BindRead_shadowsNearPlane, null);
            cls.AddProperty(false, "halo", BindRead_halo, null);
            cls.AddProperty(false, "flare", BindRead_flare, null);
            cls.AddProperty(false, "renderMode", BindRead_renderMode, null);
            cls.AddProperty(false, "cullingMask", BindRead_cullingMask, null);
            cls.AddProperty(false, "renderingLayerMask", BindRead_renderingLayerMask, null);
            cls.AddProperty(false, "lightmapping", BindRead_lightmapping, null);
            cls.AddProperty(false, "areaSizeX", BindRead_areaSizeX, null);
            cls.AddProperty(false, "areaSizeY", BindRead_areaSizeY, null);
            cls.AddProperty(false, "bakedShadowRadiusProp", BindRead_bakedShadowRadiusProp, null);
            cls.AddProperty(false, "bakedShadowAngleProp", BindRead_bakedShadowAngleProp, null);
            cls.AddProperty(false, "isRealtime", BindRead_isRealtime, null);
            cls.AddProperty(false, "isMixed", BindRead_isMixed, null);
            cls.AddProperty(false, "isCompletelyBaked", BindRead_isCompletelyBaked, null);
            cls.AddProperty(false, "isBakedOrMixed", BindRead_isBakedOrMixed, null);
            cls.AddProperty(false, "isAreaLightType", BindRead_isAreaLightType, null);
            cls.AddProperty(false, "light", BindRead_light, null);
            cls.AddProperty(false, "cookie", BindRead_cookie, null);
            return cls;
        }
    }
}
#endif
#endif
