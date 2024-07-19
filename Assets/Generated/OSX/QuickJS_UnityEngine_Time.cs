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
    // Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2019.4.40f1/Unity.app/Contents/Managed/UnityEngine/UnityEngine.CoreModule.dll
    // Type: UnityEngine.Time
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_Time
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new UnityEngine.Time();
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
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_time(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Time.time;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_timeSinceLevelLoad(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Time.timeSinceLevelLoad;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_deltaTime(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Time.deltaTime;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_fixedTime(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Time.fixedTime;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_unscaledTime(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Time.unscaledTime;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_fixedUnscaledTime(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Time.fixedUnscaledTime;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_unscaledDeltaTime(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Time.unscaledDeltaTime;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_fixedUnscaledDeltaTime(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Time.fixedUnscaledDeltaTime;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_fixedDeltaTime(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Time.fixedDeltaTime;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_fixedDeltaTime(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Time), "fixedDeltaTime", typeof(float), 0);
                }
                UnityEngine.Time.fixedDeltaTime = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_maximumDeltaTime(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Time.maximumDeltaTime;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_maximumDeltaTime(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Time), "maximumDeltaTime", typeof(float), 0);
                }
                UnityEngine.Time.maximumDeltaTime = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_smoothDeltaTime(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Time.smoothDeltaTime;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_maximumParticleDeltaTime(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Time.maximumParticleDeltaTime;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_maximumParticleDeltaTime(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Time), "maximumParticleDeltaTime", typeof(float), 0);
                }
                UnityEngine.Time.maximumParticleDeltaTime = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_timeScale(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Time.timeScale;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_timeScale(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Time), "timeScale", typeof(float), 0);
                }
                UnityEngine.Time.timeScale = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_frameCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Time.frameCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_renderedFrameCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Time.renderedFrameCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_realtimeSinceStartup(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Time.realtimeSinceStartup;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_captureDeltaTime(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Time.captureDeltaTime;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_captureDeltaTime(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Time), "captureDeltaTime", typeof(float), 0);
                }
                UnityEngine.Time.captureDeltaTime = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_captureFramerate(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Time.captureFramerate;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_captureFramerate(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Time), "captureFramerate", typeof(int), 0);
                }
                UnityEngine.Time.captureFramerate = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_inFixedTimeStep(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Time.inFixedTimeStep;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("Time", typeof(UnityEngine.Time), BindConstructor);
            cls.AddProperty(true, "time", BindStaticRead_time, null);
            cls.AddProperty(true, "timeSinceLevelLoad", BindStaticRead_timeSinceLevelLoad, null);
            cls.AddProperty(true, "deltaTime", BindStaticRead_deltaTime, null);
            cls.AddProperty(true, "fixedTime", BindStaticRead_fixedTime, null);
            cls.AddProperty(true, "unscaledTime", BindStaticRead_unscaledTime, null);
            cls.AddProperty(true, "fixedUnscaledTime", BindStaticRead_fixedUnscaledTime, null);
            cls.AddProperty(true, "unscaledDeltaTime", BindStaticRead_unscaledDeltaTime, null);
            cls.AddProperty(true, "fixedUnscaledDeltaTime", BindStaticRead_fixedUnscaledDeltaTime, null);
            cls.AddProperty(true, "fixedDeltaTime", BindStaticRead_fixedDeltaTime, BindStaticWrite_fixedDeltaTime);
            cls.AddProperty(true, "maximumDeltaTime", BindStaticRead_maximumDeltaTime, BindStaticWrite_maximumDeltaTime);
            cls.AddProperty(true, "smoothDeltaTime", BindStaticRead_smoothDeltaTime, null);
            cls.AddProperty(true, "maximumParticleDeltaTime", BindStaticRead_maximumParticleDeltaTime, BindStaticWrite_maximumParticleDeltaTime);
            cls.AddProperty(true, "timeScale", BindStaticRead_timeScale, BindStaticWrite_timeScale);
            cls.AddProperty(true, "frameCount", BindStaticRead_frameCount, null);
            cls.AddProperty(true, "renderedFrameCount", BindStaticRead_renderedFrameCount, null);
            cls.AddProperty(true, "realtimeSinceStartup", BindStaticRead_realtimeSinceStartup, null);
            cls.AddProperty(true, "captureDeltaTime", BindStaticRead_captureDeltaTime, BindStaticWrite_captureDeltaTime);
            cls.AddProperty(true, "captureFramerate", BindStaticRead_captureFramerate, BindStaticWrite_captureFramerate);
            cls.AddProperty(true, "inFixedTimeStep", BindStaticRead_inFixedTimeStep, null);
            return cls;
        }
    }
}
#endif
