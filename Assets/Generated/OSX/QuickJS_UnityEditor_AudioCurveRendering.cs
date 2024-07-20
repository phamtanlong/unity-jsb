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
    // Type: UnityEditor.AudioCurveRendering
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_AudioCurveRendering
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new UnityEditor.AudioCurveRendering();
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
        public static JSValue BindStatic_BeginCurveFrame(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AudioCurveRendering), "BeginCurveFrame", typeof(UnityEngine.Rect), 0);
                    }
                    var ret = UnityEditor.AudioCurveRendering.BeginCurveFrame(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("BeginCurveFrame", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_EndCurveFrame(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.AudioCurveRendering.EndCurveFrame();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("EndCurveFrame", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawCurveFrame(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AudioCurveRendering), "DrawCurveFrame", typeof(UnityEngine.Rect), 0);
                    }
                    var ret = UnityEditor.AudioCurveRendering.DrawCurveFrame(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("DrawCurveFrame", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawCurveBackground(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AudioCurveRendering), "DrawCurveBackground", typeof(UnityEngine.Rect), 0);
                    }
                    UnityEditor.AudioCurveRendering.DrawCurveBackground(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawCurveBackground", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawFilledCurve(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.AudioCurveRendering), "DrawFilledCurve", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEditor.AudioCurveRendering.AudioCurveEvaluator arg1;
                        if (!Values.js_get_delegate(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.AudioCurveRendering), "DrawFilledCurve", typeof(UnityEditor.AudioCurveRendering.AudioCurveEvaluator), 1);
                        }
                        UnityEngine.Color arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.AudioCurveRendering), "DrawFilledCurve", typeof(UnityEngine.Color), 2);
                        }
                        UnityEditor.AudioCurveRendering.DrawFilledCurve(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.AudioCurveRendering), "DrawFilledCurve", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEditor.AudioCurveRendering.AudioCurveAndColorEvaluator arg1;
                        if (!Values.js_get_delegate(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.AudioCurveRendering), "DrawFilledCurve", typeof(UnityEditor.AudioCurveRendering.AudioCurveAndColorEvaluator), 1);
                        }
                        UnityEditor.AudioCurveRendering.DrawFilledCurve(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("DrawFilledCurve", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawMinMaxFilledCurve(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AudioCurveRendering), "DrawMinMaxFilledCurve", typeof(UnityEngine.Rect), 0);
                    }
                    UnityEditor.AudioCurveRendering.AudioMinMaxCurveAndColorEvaluator arg1;
                    if (!Values.js_get_delegate(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AudioCurveRendering), "DrawMinMaxFilledCurve", typeof(UnityEditor.AudioCurveRendering.AudioMinMaxCurveAndColorEvaluator), 1);
                    }
                    UnityEditor.AudioCurveRendering.DrawMinMaxFilledCurve(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawMinMaxFilledCurve", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawSymmetricFilledCurve(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AudioCurveRendering), "DrawSymmetricFilledCurve", typeof(UnityEngine.Rect), 0);
                    }
                    UnityEditor.AudioCurveRendering.AudioCurveAndColorEvaluator arg1;
                    if (!Values.js_get_delegate(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AudioCurveRendering), "DrawSymmetricFilledCurve", typeof(UnityEditor.AudioCurveRendering.AudioCurveAndColorEvaluator), 1);
                    }
                    UnityEditor.AudioCurveRendering.DrawSymmetricFilledCurve(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawSymmetricFilledCurve", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawCurve(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AudioCurveRendering), "DrawCurve", typeof(UnityEngine.Rect), 0);
                    }
                    UnityEditor.AudioCurveRendering.AudioCurveEvaluator arg1;
                    if (!Values.js_get_delegate(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AudioCurveRendering), "DrawCurve", typeof(UnityEditor.AudioCurveRendering.AudioCurveEvaluator), 1);
                    }
                    UnityEngine.Color arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.AudioCurveRendering), "DrawCurve", typeof(UnityEngine.Color), 2);
                    }
                    UnityEditor.AudioCurveRendering.DrawCurve(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawCurve", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawGradientRect(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 5)
                {
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AudioCurveRendering), "DrawGradientRect", typeof(UnityEngine.Rect), 0);
                    }
                    UnityEngine.Color arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AudioCurveRendering), "DrawGradientRect", typeof(UnityEngine.Color), 1);
                    }
                    UnityEngine.Color arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.AudioCurveRendering), "DrawGradientRect", typeof(UnityEngine.Color), 2);
                    }
                    float arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.AudioCurveRendering), "DrawGradientRect", typeof(float), 3);
                    }
                    bool arg4;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.AudioCurveRendering), "DrawGradientRect", typeof(bool), 4);
                    }
                    UnityEditor.AudioCurveRendering.DrawGradientRect(arg0, arg1, arg2, arg3, arg4);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawGradientRect", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_kAudioOrange(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.AudioCurveRendering.kAudioOrange;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("AudioCurveRendering", typeof(UnityEditor.AudioCurveRendering), BindConstructor);
            cls.AddMethod(true, "BeginCurveFrame", BindStatic_BeginCurveFrame);
            cls.AddMethod(true, "EndCurveFrame", BindStatic_EndCurveFrame);
            cls.AddMethod(true, "DrawCurveFrame", BindStatic_DrawCurveFrame);
            cls.AddMethod(true, "DrawCurveBackground", BindStatic_DrawCurveBackground);
            cls.AddMethod(true, "DrawFilledCurve", BindStatic_DrawFilledCurve);
            cls.AddMethod(true, "DrawMinMaxFilledCurve", BindStatic_DrawMinMaxFilledCurve);
            cls.AddMethod(true, "DrawSymmetricFilledCurve", BindStatic_DrawSymmetricFilledCurve);
            cls.AddMethod(true, "DrawCurve", BindStatic_DrawCurve);
            cls.AddMethod(true, "DrawGradientRect", BindStatic_DrawGradientRect);
            cls.AddField(true, "kAudioOrange", BindStaticRead_kAudioOrange, null);
            return cls;
        }
    }
}
#endif
#endif
