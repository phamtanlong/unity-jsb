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
    // Type: UnityEditor.Handles
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_Handles
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawPolyLine(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (Values.js_match_param_types(ctx, 0, argv, typeof(UnityEngine.Vector3)))
                {
                    UnityEngine.Vector3[] arg0 = null;
                    if (argc > 0)
                    {
                        arg0 = new UnityEngine.Vector3[argc];
                        for (var i = 0; i < argc; i++)
                        {
                            QuickJS.Binding.Values.js_get_structvalue(ctx, argv[i], out arg0[i]);
                        }
                    }
                    UnityEditor.Handles.DrawPolyLine(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawPolyLine", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawLine(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawLine", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawLine", typeof(UnityEngine.Vector3), 1);
                    }
                    UnityEditor.Handles.DrawLine(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawLine", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawLines(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEngine.Vector3[] arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "DrawLines", typeof(UnityEngine.Vector3[]), 0);
                        }
                        int[] arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "DrawLines", typeof(int[]), 1);
                        }
                        UnityEditor.Handles.DrawLines(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Vector3[] arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "DrawLines", typeof(UnityEngine.Vector3[]), 0);
                        }
                        UnityEditor.Handles.DrawLines(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("DrawLines", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawDottedLine(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawDottedLine", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawDottedLine", typeof(UnityEngine.Vector3), 1);
                    }
                    float arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawDottedLine", typeof(float), 2);
                    }
                    UnityEditor.Handles.DrawDottedLine(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawDottedLine", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawDottedLines(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        UnityEngine.Vector3[] arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "DrawDottedLines", typeof(UnityEngine.Vector3[]), 0);
                        }
                        int[] arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "DrawDottedLines", typeof(int[]), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "DrawDottedLines", typeof(float), 2);
                        }
                        UnityEditor.Handles.DrawDottedLines(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Vector3[] arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "DrawDottedLines", typeof(UnityEngine.Vector3[]), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "DrawDottedLines", typeof(float), 1);
                        }
                        UnityEditor.Handles.DrawDottedLines(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("DrawDottedLines", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawWireCube(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawWireCube", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawWireCube", typeof(UnityEngine.Vector3), 1);
                    }
                    UnityEditor.Handles.DrawWireCube(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawWireCube", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ShouldRenderGizmos(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.Handles.ShouldRenderGizmos();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ShouldRenderGizmos", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawGizmos(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Camera arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawGizmos", typeof(UnityEngine.Camera), 0);
                    }
                    UnityEditor.Handles.DrawGizmos(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawGizmos", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Disc(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 7)
                    {
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Disc", typeof(int), 0);
                        }
                        UnityEngine.Quaternion arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Disc", typeof(UnityEngine.Quaternion), 1);
                        }
                        UnityEngine.Vector3 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Disc", typeof(UnityEngine.Vector3), 2);
                        }
                        UnityEngine.Vector3 arg3;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Disc", typeof(UnityEngine.Vector3), 3);
                        }
                        float arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Disc", typeof(float), 4);
                        }
                        bool arg5;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Disc", typeof(bool), 5);
                        }
                        float arg6;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Disc", typeof(float), 6);
                        }
                        var ret = UnityEditor.Handles.Disc(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 6)
                    {
                        UnityEngine.Quaternion arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Disc", typeof(UnityEngine.Quaternion), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Disc", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Vector3 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Disc", typeof(UnityEngine.Vector3), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Disc", typeof(float), 3);
                        }
                        bool arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Disc", typeof(bool), 4);
                        }
                        float arg5;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Disc", typeof(float), 5);
                        }
                        var ret = UnityEditor.Handles.Disc(arg0, arg1, arg2, arg3, arg4, arg5);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("Disc", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_FreeRotateHandle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "FreeRotateHandle", typeof(int), 0);
                        }
                        UnityEngine.Quaternion arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "FreeRotateHandle", typeof(UnityEngine.Quaternion), 1);
                        }
                        UnityEngine.Vector3 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "FreeRotateHandle", typeof(UnityEngine.Vector3), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "FreeRotateHandle", typeof(float), 3);
                        }
                        var ret = UnityEditor.Handles.FreeRotateHandle(arg0, arg1, arg2, arg3);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Quaternion arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "FreeRotateHandle", typeof(UnityEngine.Quaternion), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "FreeRotateHandle", typeof(UnityEngine.Vector3), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "FreeRotateHandle", typeof(float), 2);
                        }
                        var ret = UnityEditor.Handles.FreeRotateHandle(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("FreeRotateHandle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Slider(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 7)
                    {
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Slider", typeof(int), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Slider", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Vector3 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Slider", typeof(UnityEngine.Vector3), 2);
                        }
                        UnityEngine.Vector3 arg3;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Slider", typeof(UnityEngine.Vector3), 3);
                        }
                        float arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Slider", typeof(float), 4);
                        }
                        UnityEditor.Handles.CapFunction arg5;
                        if (!Values.js_get_delegate(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Slider", typeof(UnityEditor.Handles.CapFunction), 5);
                        }
                        float arg6;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Slider", typeof(float), 6);
                        }
                        var ret = UnityEditor.Handles.Slider(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 6)
                    {
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Slider", typeof(int), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Slider", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Vector3 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Slider", typeof(UnityEngine.Vector3), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Slider", typeof(float), 3);
                        }
                        UnityEditor.Handles.CapFunction arg4;
                        if (!Values.js_get_delegate(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Slider", typeof(UnityEditor.Handles.CapFunction), 4);
                        }
                        float arg5;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Slider", typeof(float), 5);
                        }
                        var ret = UnityEditor.Handles.Slider(arg0, arg1, arg2, arg3, arg4, arg5);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 5)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Slider", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Slider", typeof(UnityEngine.Vector3), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Slider", typeof(float), 2);
                        }
                        UnityEditor.Handles.CapFunction arg3;
                        if (!Values.js_get_delegate(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Slider", typeof(UnityEditor.Handles.CapFunction), 3);
                        }
                        float arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Slider", typeof(float), 4);
                        }
                        var ret = UnityEditor.Handles.Slider(arg0, arg1, arg2, arg3, arg4);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Slider", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Slider", typeof(UnityEngine.Vector3), 1);
                        }
                        var ret = UnityEditor.Handles.Slider(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("Slider", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_FreeMoveHandle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 6)
                    {
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "FreeMoveHandle", typeof(int), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "FreeMoveHandle", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Quaternion arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "FreeMoveHandle", typeof(UnityEngine.Quaternion), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "FreeMoveHandle", typeof(float), 3);
                        }
                        UnityEngine.Vector3 arg4;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "FreeMoveHandle", typeof(UnityEngine.Vector3), 4);
                        }
                        UnityEditor.Handles.CapFunction arg5;
                        if (!Values.js_get_delegate(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "FreeMoveHandle", typeof(UnityEditor.Handles.CapFunction), 5);
                        }
                        var ret = UnityEditor.Handles.FreeMoveHandle(arg0, arg1, arg2, arg3, arg4, arg5);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 5)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "FreeMoveHandle", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Quaternion arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "FreeMoveHandle", typeof(UnityEngine.Quaternion), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "FreeMoveHandle", typeof(float), 2);
                        }
                        UnityEngine.Vector3 arg3;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "FreeMoveHandle", typeof(UnityEngine.Vector3), 3);
                        }
                        UnityEditor.Handles.CapFunction arg4;
                        if (!Values.js_get_delegate(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "FreeMoveHandle", typeof(UnityEditor.Handles.CapFunction), 4);
                        }
                        var ret = UnityEditor.Handles.FreeMoveHandle(arg0, arg1, arg2, arg3, arg4);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("FreeMoveHandle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ScaleValueHandle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 7)
                    {
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "ScaleValueHandle", typeof(int), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "ScaleValueHandle", typeof(float), 1);
                        }
                        UnityEngine.Vector3 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "ScaleValueHandle", typeof(UnityEngine.Vector3), 2);
                        }
                        UnityEngine.Quaternion arg3;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "ScaleValueHandle", typeof(UnityEngine.Quaternion), 3);
                        }
                        float arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "ScaleValueHandle", typeof(float), 4);
                        }
                        UnityEditor.Handles.CapFunction arg5;
                        if (!Values.js_get_delegate(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "ScaleValueHandle", typeof(UnityEditor.Handles.CapFunction), 5);
                        }
                        float arg6;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "ScaleValueHandle", typeof(float), 6);
                        }
                        var ret = UnityEditor.Handles.ScaleValueHandle(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 6)
                    {
                        float arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "ScaleValueHandle", typeof(float), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "ScaleValueHandle", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Quaternion arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "ScaleValueHandle", typeof(UnityEngine.Quaternion), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "ScaleValueHandle", typeof(float), 3);
                        }
                        UnityEditor.Handles.CapFunction arg4;
                        if (!Values.js_get_delegate(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "ScaleValueHandle", typeof(UnityEditor.Handles.CapFunction), 4);
                        }
                        float arg5;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "ScaleValueHandle", typeof(float), 5);
                        }
                        var ret = UnityEditor.Handles.ScaleValueHandle(arg0, arg1, arg2, arg3, arg4, arg5);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("ScaleValueHandle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Button(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 5)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "Button", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Quaternion arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "Button", typeof(UnityEngine.Quaternion), 1);
                    }
                    float arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "Button", typeof(float), 2);
                    }
                    float arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "Button", typeof(float), 3);
                    }
                    UnityEditor.Handles.CapFunction arg4;
                    if (!Values.js_get_delegate(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "Button", typeof(UnityEditor.Handles.CapFunction), 4);
                    }
                    var ret = UnityEditor.Handles.Button(arg0, arg1, arg2, arg3, arg4);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("Button", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CubeHandleCap(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 5)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "CubeHandleCap", typeof(int), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "CubeHandleCap", typeof(UnityEngine.Vector3), 1);
                    }
                    UnityEngine.Quaternion arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "CubeHandleCap", typeof(UnityEngine.Quaternion), 2);
                    }
                    float arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "CubeHandleCap", typeof(float), 3);
                    }
                    UnityEngine.EventType arg4;
                    if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "CubeHandleCap", typeof(UnityEngine.EventType), 4);
                    }
                    UnityEditor.Handles.CubeHandleCap(arg0, arg1, arg2, arg3, arg4);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CubeHandleCap", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SphereHandleCap(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 5)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "SphereHandleCap", typeof(int), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "SphereHandleCap", typeof(UnityEngine.Vector3), 1);
                    }
                    UnityEngine.Quaternion arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "SphereHandleCap", typeof(UnityEngine.Quaternion), 2);
                    }
                    float arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "SphereHandleCap", typeof(float), 3);
                    }
                    UnityEngine.EventType arg4;
                    if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "SphereHandleCap", typeof(UnityEngine.EventType), 4);
                    }
                    UnityEditor.Handles.SphereHandleCap(arg0, arg1, arg2, arg3, arg4);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SphereHandleCap", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ConeHandleCap(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 5)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "ConeHandleCap", typeof(int), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "ConeHandleCap", typeof(UnityEngine.Vector3), 1);
                    }
                    UnityEngine.Quaternion arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "ConeHandleCap", typeof(UnityEngine.Quaternion), 2);
                    }
                    float arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "ConeHandleCap", typeof(float), 3);
                    }
                    UnityEngine.EventType arg4;
                    if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "ConeHandleCap", typeof(UnityEngine.EventType), 4);
                    }
                    UnityEditor.Handles.ConeHandleCap(arg0, arg1, arg2, arg3, arg4);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ConeHandleCap", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CylinderHandleCap(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 5)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "CylinderHandleCap", typeof(int), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "CylinderHandleCap", typeof(UnityEngine.Vector3), 1);
                    }
                    UnityEngine.Quaternion arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "CylinderHandleCap", typeof(UnityEngine.Quaternion), 2);
                    }
                    float arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "CylinderHandleCap", typeof(float), 3);
                    }
                    UnityEngine.EventType arg4;
                    if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "CylinderHandleCap", typeof(UnityEngine.EventType), 4);
                    }
                    UnityEditor.Handles.CylinderHandleCap(arg0, arg1, arg2, arg3, arg4);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CylinderHandleCap", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RectangleHandleCap(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 5)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "RectangleHandleCap", typeof(int), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "RectangleHandleCap", typeof(UnityEngine.Vector3), 1);
                    }
                    UnityEngine.Quaternion arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "RectangleHandleCap", typeof(UnityEngine.Quaternion), 2);
                    }
                    float arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "RectangleHandleCap", typeof(float), 3);
                    }
                    UnityEngine.EventType arg4;
                    if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "RectangleHandleCap", typeof(UnityEngine.EventType), 4);
                    }
                    UnityEditor.Handles.RectangleHandleCap(arg0, arg1, arg2, arg3, arg4);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RectangleHandleCap", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DotHandleCap(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 5)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DotHandleCap", typeof(int), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DotHandleCap", typeof(UnityEngine.Vector3), 1);
                    }
                    UnityEngine.Quaternion arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DotHandleCap", typeof(UnityEngine.Quaternion), 2);
                    }
                    float arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DotHandleCap", typeof(float), 3);
                    }
                    UnityEngine.EventType arg4;
                    if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DotHandleCap", typeof(UnityEngine.EventType), 4);
                    }
                    UnityEditor.Handles.DotHandleCap(arg0, arg1, arg2, arg3, arg4);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DotHandleCap", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CircleHandleCap(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 5)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "CircleHandleCap", typeof(int), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "CircleHandleCap", typeof(UnityEngine.Vector3), 1);
                    }
                    UnityEngine.Quaternion arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "CircleHandleCap", typeof(UnityEngine.Quaternion), 2);
                    }
                    float arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "CircleHandleCap", typeof(float), 3);
                    }
                    UnityEngine.EventType arg4;
                    if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "CircleHandleCap", typeof(UnityEngine.EventType), 4);
                    }
                    UnityEditor.Handles.CircleHandleCap(arg0, arg1, arg2, arg3, arg4);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CircleHandleCap", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ArrowHandleCap(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 5)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "ArrowHandleCap", typeof(int), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "ArrowHandleCap", typeof(UnityEngine.Vector3), 1);
                    }
                    UnityEngine.Quaternion arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "ArrowHandleCap", typeof(UnityEngine.Quaternion), 2);
                    }
                    float arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "ArrowHandleCap", typeof(float), 3);
                    }
                    UnityEngine.EventType arg4;
                    if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "ArrowHandleCap", typeof(UnityEngine.EventType), 4);
                    }
                    UnityEditor.Handles.ArrowHandleCap(arg0, arg1, arg2, arg3, arg4);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ArrowHandleCap", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawSelectionFrame(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 5)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawSelectionFrame", typeof(int), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawSelectionFrame", typeof(UnityEngine.Vector3), 1);
                    }
                    UnityEngine.Quaternion arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawSelectionFrame", typeof(UnityEngine.Quaternion), 2);
                    }
                    float arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawSelectionFrame", typeof(float), 3);
                    }
                    UnityEngine.EventType arg4;
                    if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawSelectionFrame", typeof(UnityEngine.EventType), 4);
                    }
                    UnityEditor.Handles.DrawSelectionFrame(arg0, arg1, arg2, arg3, arg4);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawSelectionFrame", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_PositionHandle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "PositionHandle", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Quaternion arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "PositionHandle", typeof(UnityEngine.Quaternion), 1);
                    }
                    var ret = UnityEditor.Handles.PositionHandle(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("PositionHandle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RotationHandle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Quaternion arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "RotationHandle", typeof(UnityEngine.Quaternion), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "RotationHandle", typeof(UnityEngine.Vector3), 1);
                    }
                    var ret = UnityEditor.Handles.RotationHandle(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("RotationHandle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ScaleHandle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 4)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "ScaleHandle", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "ScaleHandle", typeof(UnityEngine.Vector3), 1);
                    }
                    UnityEngine.Quaternion arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "ScaleHandle", typeof(UnityEngine.Quaternion), 2);
                    }
                    float arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "ScaleHandle", typeof(float), 3);
                    }
                    var ret = UnityEditor.Handles.ScaleHandle(arg0, arg1, arg2, arg3);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("ScaleHandle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RadiusHandle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        UnityEngine.Quaternion arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "RadiusHandle", typeof(UnityEngine.Quaternion), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "RadiusHandle", typeof(UnityEngine.Vector3), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "RadiusHandle", typeof(float), 2);
                        }
                        bool arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "RadiusHandle", typeof(bool), 3);
                        }
                        var ret = UnityEditor.Handles.RadiusHandle(arg0, arg1, arg2, arg3);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Quaternion arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "RadiusHandle", typeof(UnityEngine.Quaternion), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "RadiusHandle", typeof(UnityEngine.Vector3), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "RadiusHandle", typeof(float), 2);
                        }
                        var ret = UnityEditor.Handles.RadiusHandle(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("RadiusHandle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Slider2D(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 10)
                    {
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(int), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Vector3 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 2);
                        }
                        UnityEngine.Vector3 arg3;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 3);
                        }
                        UnityEngine.Vector3 arg4;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 4);
                        }
                        UnityEngine.Vector3 arg5;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 5);
                        }
                        float arg6;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(float), 6);
                        }
                        UnityEditor.Handles.CapFunction arg7;
                        if (!Values.js_get_delegate(ctx, argv[7], out arg7))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEditor.Handles.CapFunction), 7);
                        }
                        UnityEngine.Vector2 arg8;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[8], out arg8))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector2), 8);
                        }
                        bool arg9;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[9], out arg9))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(bool), 9);
                        }
                        var ret = UnityEditor.Handles.Slider2D(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 9)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[5], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[6], typeof(float)) && Values.js_match_type(ctx, argv[7], typeof(UnityEditor.Handles.CapFunction)) && Values.js_match_type(ctx, argv[8], typeof(UnityEngine.Vector2)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(int), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 1);
                            }
                            UnityEngine.Vector3 arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 2);
                            }
                            UnityEngine.Vector3 arg3;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 3);
                            }
                            UnityEngine.Vector3 arg4;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 4);
                            }
                            UnityEngine.Vector3 arg5;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 5);
                            }
                            float arg6;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[6], out arg6))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(float), 6);
                            }
                            UnityEditor.Handles.CapFunction arg7;
                            if (!Values.js_get_delegate(ctx, argv[7], out arg7))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEditor.Handles.CapFunction), 7);
                            }
                            UnityEngine.Vector2 arg8;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[8], out arg8))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector2), 8);
                            }
                            var ret = UnityEditor.Handles.Slider2D(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[5], typeof(float)) && Values.js_match_type(ctx, argv[6], typeof(UnityEditor.Handles.CapFunction)) && Values.js_match_type(ctx, argv[7], typeof(UnityEngine.Vector2)) && Values.js_match_type(ctx, argv[8], typeof(bool)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(int), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 1);
                            }
                            UnityEngine.Vector3 arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 2);
                            }
                            UnityEngine.Vector3 arg3;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 3);
                            }
                            UnityEngine.Vector3 arg4;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 4);
                            }
                            float arg5;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(float), 5);
                            }
                            UnityEditor.Handles.CapFunction arg6;
                            if (!Values.js_get_delegate(ctx, argv[6], out arg6))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEditor.Handles.CapFunction), 6);
                            }
                            UnityEngine.Vector2 arg7;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[7], out arg7))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector2), 7);
                            }
                            bool arg8;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[8], out arg8))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(bool), 8);
                            }
                            var ret = UnityEditor.Handles.Slider2D(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc == 8)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[4], typeof(float)) && Values.js_match_type(ctx, argv[5], typeof(UnityEditor.Handles.CapFunction)) && Values.js_match_type(ctx, argv[6], typeof(UnityEngine.Vector2)) && Values.js_match_type(ctx, argv[7], typeof(bool)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 1);
                            }
                            UnityEngine.Vector3 arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 2);
                            }
                            UnityEngine.Vector3 arg3;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 3);
                            }
                            float arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(float), 4);
                            }
                            UnityEditor.Handles.CapFunction arg5;
                            if (!Values.js_get_delegate(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEditor.Handles.CapFunction), 5);
                            }
                            UnityEngine.Vector2 arg6;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[6], out arg6))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector2), 6);
                            }
                            bool arg7;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[7], out arg7))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(bool), 7);
                            }
                            var ret = UnityEditor.Handles.Slider2D(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[5], typeof(float)) && Values.js_match_type(ctx, argv[6], typeof(UnityEditor.Handles.CapFunction)) && Values.js_match_type(ctx, argv[7], typeof(UnityEngine.Vector2)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(int), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 1);
                            }
                            UnityEngine.Vector3 arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 2);
                            }
                            UnityEngine.Vector3 arg3;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 3);
                            }
                            UnityEngine.Vector3 arg4;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 4);
                            }
                            float arg5;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(float), 5);
                            }
                            UnityEditor.Handles.CapFunction arg6;
                            if (!Values.js_get_delegate(ctx, argv[6], out arg6))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEditor.Handles.CapFunction), 6);
                            }
                            UnityEngine.Vector2 arg7;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[7], out arg7))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector2), 7);
                            }
                            var ret = UnityEditor.Handles.Slider2D(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[4], typeof(float)) && Values.js_match_type(ctx, argv[5], typeof(UnityEditor.Handles.CapFunction)) && Values.js_match_type(ctx, argv[6], typeof(float)) && Values.js_match_type(ctx, argv[7], typeof(bool)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 1);
                            }
                            UnityEngine.Vector3 arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 2);
                            }
                            UnityEngine.Vector3 arg3;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 3);
                            }
                            float arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(float), 4);
                            }
                            UnityEditor.Handles.CapFunction arg5;
                            if (!Values.js_get_delegate(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEditor.Handles.CapFunction), 5);
                            }
                            float arg6;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[6], out arg6))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(float), 6);
                            }
                            bool arg7;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[7], out arg7))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(bool), 7);
                            }
                            var ret = UnityEditor.Handles.Slider2D(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc == 7)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[4], typeof(float)) && Values.js_match_type(ctx, argv[5], typeof(UnityEditor.Handles.CapFunction)) && Values.js_match_type(ctx, argv[6], typeof(UnityEngine.Vector2)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 1);
                            }
                            UnityEngine.Vector3 arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 2);
                            }
                            UnityEngine.Vector3 arg3;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 3);
                            }
                            float arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(float), 4);
                            }
                            UnityEditor.Handles.CapFunction arg5;
                            if (!Values.js_get_delegate(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEditor.Handles.CapFunction), 5);
                            }
                            UnityEngine.Vector2 arg6;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[6], out arg6))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector2), 6);
                            }
                            var ret = UnityEditor.Handles.Slider2D(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[4], typeof(float)) && Values.js_match_type(ctx, argv[5], typeof(UnityEditor.Handles.CapFunction)) && Values.js_match_type(ctx, argv[6], typeof(float)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 1);
                            }
                            UnityEngine.Vector3 arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 2);
                            }
                            UnityEngine.Vector3 arg3;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEngine.Vector3), 3);
                            }
                            float arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(float), 4);
                            }
                            UnityEditor.Handles.CapFunction arg5;
                            if (!Values.js_get_delegate(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(UnityEditor.Handles.CapFunction), 5);
                            }
                            float arg6;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[6], out arg6))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Slider2D", typeof(float), 6);
                            }
                            var ret = UnityEditor.Handles.Slider2D(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Slider2D", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ScaleSlider(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 6)
                {
                    float arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "ScaleSlider", typeof(float), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "ScaleSlider", typeof(UnityEngine.Vector3), 1);
                    }
                    UnityEngine.Vector3 arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "ScaleSlider", typeof(UnityEngine.Vector3), 2);
                    }
                    UnityEngine.Quaternion arg3;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "ScaleSlider", typeof(UnityEngine.Quaternion), 3);
                    }
                    float arg4;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "ScaleSlider", typeof(float), 4);
                    }
                    float arg5;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "ScaleSlider", typeof(float), 5);
                    }
                    var ret = UnityEditor.Handles.ScaleSlider(arg0, arg1, arg2, arg3, arg4, arg5);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ScaleSlider", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SnapValue(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(float)) && Values.js_match_type(ctx, argv[1], typeof(float)))
                        {
                            float arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "SnapValue", typeof(float), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "SnapValue", typeof(float), 1);
                            }
                            var ret = UnityEditor.Handles.SnapValue(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector2)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector2)))
                        {
                            UnityEngine.Vector2 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "SnapValue", typeof(UnityEngine.Vector2), 0);
                            }
                            UnityEngine.Vector2 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "SnapValue", typeof(UnityEngine.Vector2), 1);
                            }
                            var ret = UnityEditor.Handles.SnapValue(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "SnapValue", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "SnapValue", typeof(UnityEngine.Vector3), 1);
                            }
                            var ret = UnityEditor.Handles.SnapValue(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("SnapValue", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SnapToGrid(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Transform[] arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "SnapToGrid", typeof(UnityEngine.Transform[]), 0);
                    }
                    UnityEngine.SnapAxis arg1;
                    if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "SnapToGrid", typeof(UnityEngine.SnapAxis), 1);
                    }
                    UnityEditor.Handles.SnapToGrid(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SnapToGrid", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SelectionFrame(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 4)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "SelectionFrame", typeof(int), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "SelectionFrame", typeof(UnityEngine.Vector3), 1);
                    }
                    UnityEngine.Quaternion arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "SelectionFrame", typeof(UnityEngine.Quaternion), 2);
                    }
                    float arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "SelectionFrame", typeof(float), 3);
                    }
                    UnityEditor.Handles.SelectionFrame(arg0, arg1, arg2, arg3);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SelectionFrame", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawAAPolyLine(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(float)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.Vector3)))
                        {
                            float arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "DrawAAPolyLine", typeof(float), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "DrawAAPolyLine", typeof(int), 1);
                            }
                            UnityEngine.Vector3[] arg2 = null;
                            if (argc - 2 > 0)
                            {
                                arg2 = new UnityEngine.Vector3[argc - 2];
                                for (var i = 2; i < argc; i++)
                                {
                                    QuickJS.Binding.Values.js_get_structvalue(ctx, argv[i], out arg2[i - 2]);
                                }
                            }
                            UnityEditor.Handles.DrawAAPolyLine(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Texture2D)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_param_types(ctx, 2, argv, typeof(UnityEngine.Vector3)))
                        {
                            UnityEngine.Texture2D arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "DrawAAPolyLine", typeof(UnityEngine.Texture2D), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "DrawAAPolyLine", typeof(float), 1);
                            }
                            UnityEngine.Vector3[] arg2 = null;
                            if (argc - 2 > 0)
                            {
                                arg2 = new UnityEngine.Vector3[argc - 2];
                                for (var i = 2; i < argc; i++)
                                {
                                    QuickJS.Binding.Values.js_get_structvalue(ctx, argv[i], out arg2[i - 2]);
                                }
                            }
                            UnityEditor.Handles.DrawAAPolyLine(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(float)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.Vector3)))
                        {
                            float arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "DrawAAPolyLine", typeof(float), 0);
                            }
                            UnityEngine.Vector3[] arg1 = null;
                            if (argc - 1 > 0)
                            {
                                arg1 = new UnityEngine.Vector3[argc - 1];
                                for (var i = 1; i < argc; i++)
                                {
                                    QuickJS.Binding.Values.js_get_structvalue(ctx, argv[i], out arg1[i - 1]);
                                }
                            }
                            UnityEditor.Handles.DrawAAPolyLine(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Texture2D)) && Values.js_match_param_types(ctx, 1, argv, typeof(UnityEngine.Vector3)))
                        {
                            UnityEngine.Texture2D arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "DrawAAPolyLine", typeof(UnityEngine.Texture2D), 0);
                            }
                            UnityEngine.Vector3[] arg1 = null;
                            if (argc - 1 > 0)
                            {
                                arg1 = new UnityEngine.Vector3[argc - 1];
                                for (var i = 1; i < argc; i++)
                                {
                                    QuickJS.Binding.Values.js_get_structvalue(ctx, argv[i], out arg1[i - 1]);
                                }
                            }
                            UnityEditor.Handles.DrawAAPolyLine(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (Values.js_match_param_types(ctx, 0, argv, typeof(UnityEngine.Vector3)))
                    {
                        UnityEngine.Vector3[] arg0 = null;
                        if (argc > 0)
                        {
                            arg0 = new UnityEngine.Vector3[argc];
                            for (var i = 0; i < argc; i++)
                            {
                                QuickJS.Binding.Values.js_get_structvalue(ctx, argv[i], out arg0[i]);
                            }
                        }
                        UnityEditor.Handles.DrawAAPolyLine(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("DrawAAPolyLine", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawAAConvexPolygon(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (Values.js_match_param_types(ctx, 0, argv, typeof(UnityEngine.Vector3)))
                {
                    UnityEngine.Vector3[] arg0 = null;
                    if (argc > 0)
                    {
                        arg0 = new UnityEngine.Vector3[argc];
                        for (var i = 0; i < argc; i++)
                        {
                            QuickJS.Binding.Values.js_get_structvalue(ctx, argv[i], out arg0[i]);
                        }
                    }
                    UnityEditor.Handles.DrawAAConvexPolygon(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawAAConvexPolygon", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawBezier(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 7)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawBezier", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawBezier", typeof(UnityEngine.Vector3), 1);
                    }
                    UnityEngine.Vector3 arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawBezier", typeof(UnityEngine.Vector3), 2);
                    }
                    UnityEngine.Vector3 arg3;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawBezier", typeof(UnityEngine.Vector3), 3);
                    }
                    UnityEngine.Color arg4;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawBezier", typeof(UnityEngine.Color), 4);
                    }
                    UnityEngine.Texture2D arg5;
                    if (!Values.js_get_classvalue(ctx, argv[5], out arg5))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawBezier", typeof(UnityEngine.Texture2D), 5);
                    }
                    float arg6;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[6], out arg6))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawBezier", typeof(float), 6);
                    }
                    UnityEditor.Handles.DrawBezier(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawBezier", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawWireDisc(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawWireDisc", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawWireDisc", typeof(UnityEngine.Vector3), 1);
                    }
                    float arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawWireDisc", typeof(float), 2);
                    }
                    UnityEditor.Handles.DrawWireDisc(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawWireDisc", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawWireArc(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 5)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawWireArc", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawWireArc", typeof(UnityEngine.Vector3), 1);
                    }
                    UnityEngine.Vector3 arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawWireArc", typeof(UnityEngine.Vector3), 2);
                    }
                    float arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawWireArc", typeof(float), 3);
                    }
                    float arg4;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawWireArc", typeof(float), 4);
                    }
                    UnityEditor.Handles.DrawWireArc(arg0, arg1, arg2, arg3, arg4);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawWireArc", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawSolidRectangleWithOutline(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Color)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Color)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "DrawSolidRectangleWithOutline", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.Color arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "DrawSolidRectangleWithOutline", typeof(UnityEngine.Color), 1);
                            }
                            UnityEngine.Color arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "DrawSolidRectangleWithOutline", typeof(UnityEngine.Color), 2);
                            }
                            UnityEditor.Handles.DrawSolidRectangleWithOutline(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3[])) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Color)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Color)))
                        {
                            UnityEngine.Vector3[] arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "DrawSolidRectangleWithOutline", typeof(UnityEngine.Vector3[]), 0);
                            }
                            UnityEngine.Color arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "DrawSolidRectangleWithOutline", typeof(UnityEngine.Color), 1);
                            }
                            UnityEngine.Color arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "DrawSolidRectangleWithOutline", typeof(UnityEngine.Color), 2);
                            }
                            UnityEditor.Handles.DrawSolidRectangleWithOutline(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("DrawSolidRectangleWithOutline", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawSolidDisc(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawSolidDisc", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawSolidDisc", typeof(UnityEngine.Vector3), 1);
                    }
                    float arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawSolidDisc", typeof(float), 2);
                    }
                    UnityEditor.Handles.DrawSolidDisc(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawSolidDisc", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawSolidArc(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 5)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawSolidArc", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawSolidArc", typeof(UnityEngine.Vector3), 1);
                    }
                    UnityEngine.Vector3 arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawSolidArc", typeof(UnityEngine.Vector3), 2);
                    }
                    float arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawSolidArc", typeof(float), 3);
                    }
                    float arg4;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DrawSolidArc", typeof(float), 4);
                    }
                    UnityEditor.Handles.DrawSolidArc(arg0, arg1, arg2, arg3, arg4);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawSolidArc", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Label(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Label", typeof(UnityEngine.Vector3), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Label", typeof(string), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Label", typeof(UnityEngine.GUIStyle), 2);
                            }
                            UnityEditor.Handles.Label(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Label", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Label", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Label", typeof(UnityEngine.GUIStyle), 2);
                            }
                            UnityEditor.Handles.Label(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(string)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Label", typeof(UnityEngine.Vector3), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Label", typeof(string), 1);
                            }
                            UnityEditor.Handles.Label(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Texture)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Label", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Texture arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Label", typeof(UnityEngine.Texture), 1);
                            }
                            UnityEditor.Handles.Label(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Label", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "Label", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEditor.Handles.Label(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Label", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetMainGameViewSize(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.Handles.GetMainGameViewSize();
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetMainGameViewSize", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ClearCamera(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "ClearCamera", typeof(UnityEngine.Rect), 0);
                    }
                    UnityEngine.Camera arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "ClearCamera", typeof(UnityEngine.Camera), 1);
                    }
                    UnityEditor.Handles.ClearCamera(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ClearCamera", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawCamera(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(UnityEditor.Handles), "DrawCamera", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Camera arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "DrawCamera", typeof(UnityEngine.Camera), 1);
                        }
                        UnityEditor.DrawCameraMode arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "DrawCamera", typeof(UnityEditor.DrawCameraMode), 2);
                        }
                        UnityEditor.Handles.DrawCamera(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "DrawCamera", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Camera arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "DrawCamera", typeof(UnityEngine.Camera), 1);
                        }
                        UnityEditor.Handles.DrawCamera(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("DrawCamera", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetCamera(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "SetCamera", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Camera arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "SetCamera", typeof(UnityEngine.Camera), 1);
                        }
                        UnityEditor.Handles.SetCamera(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Camera arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles), "SetCamera", typeof(UnityEngine.Camera), 0);
                        }
                        UnityEditor.Handles.SetCamera(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("SetCamera", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BeginGUI(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.Handles.BeginGUI();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("BeginGUI", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_EndGUI(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.Handles.EndGUI();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("EndGUI", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_MakeBezierPoints(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 5)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "MakeBezierPoints", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "MakeBezierPoints", typeof(UnityEngine.Vector3), 1);
                    }
                    UnityEngine.Vector3 arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "MakeBezierPoints", typeof(UnityEngine.Vector3), 2);
                    }
                    UnityEngine.Vector3 arg3;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "MakeBezierPoints", typeof(UnityEngine.Vector3), 3);
                    }
                    int arg4;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "MakeBezierPoints", typeof(int), 4);
                    }
                    var ret = UnityEditor.Handles.MakeBezierPoints(arg0, arg1, arg2, arg3, arg4);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("MakeBezierPoints", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DoPositionHandle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DoPositionHandle", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Quaternion arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DoPositionHandle", typeof(UnityEngine.Quaternion), 1);
                    }
                    var ret = UnityEditor.Handles.DoPositionHandle(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("DoPositionHandle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DoRotationHandle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Quaternion arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DoRotationHandle", typeof(UnityEngine.Quaternion), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DoRotationHandle", typeof(UnityEngine.Vector3), 1);
                    }
                    var ret = UnityEditor.Handles.DoRotationHandle(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("DoRotationHandle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DoScaleHandle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 4)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DoScaleHandle", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DoScaleHandle", typeof(UnityEngine.Vector3), 1);
                    }
                    UnityEngine.Quaternion arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DoScaleHandle", typeof(UnityEngine.Quaternion), 2);
                    }
                    float arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.Handles), "DoScaleHandle", typeof(float), 3);
                    }
                    var ret = UnityEditor.Handles.DoScaleHandle(arg0, arg1, arg2, arg3);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("DoScaleHandle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_TransformHandle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type_hint(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type_hint(ctx, argv[1], typeof(UnityEngine.Quaternion)) && Values.js_match_type_hint(ctx, argv[2], typeof(UnityEngine.Vector3)))
                        {
                            UnityEngine.Vector3 arg0;
                            var refVal0 = Values.js_read_wrap(ctx, argv[0]);
                            if (refVal0.IsException())
                            {
                                return refVal0;
                            }
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, refVal0, out arg0))
                            {
                                JSApi.JS_FreeValue(ctx, refVal0);
                                throw new ParameterException(typeof(UnityEditor.Handles), "TransformHandle", typeof(UnityEngine.Vector3), 0);
                            }
                            JSApi.JS_FreeValue(ctx, refVal0);
                            UnityEngine.Quaternion arg1;
                            var refVal1 = Values.js_read_wrap(ctx, argv[1]);
                            if (refVal1.IsException())
                            {
                                return refVal1;
                            }
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, refVal1, out arg1))
                            {
                                JSApi.JS_FreeValue(ctx, refVal1);
                                throw new ParameterException(typeof(UnityEditor.Handles), "TransformHandle", typeof(UnityEngine.Quaternion), 1);
                            }
                            JSApi.JS_FreeValue(ctx, refVal1);
                            UnityEngine.Vector3 arg2;
                            var refVal2 = Values.js_read_wrap(ctx, argv[2]);
                            if (refVal2.IsException())
                            {
                                return refVal2;
                            }
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, refVal2, out arg2))
                            {
                                JSApi.JS_FreeValue(ctx, refVal2);
                                throw new ParameterException(typeof(UnityEditor.Handles), "TransformHandle", typeof(UnityEngine.Vector3), 2);
                            }
                            JSApi.JS_FreeValue(ctx, refVal2);
                            UnityEditor.Handles.TransformHandle(ref arg0, ref arg1, ref arg2);
                            var out0 = QuickJS.Binding.Values.js_push_structvalue(ctx, arg0);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[0], context.GetAtom("value"), out0);
                            var out1 = QuickJS.Binding.Values.js_push_structvalue(ctx, arg1);
                            if (JSApi.JS_IsException(out1))
                            {
                                return out1;
                            }
                            JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out1);
                            var out2 = QuickJS.Binding.Values.js_push_structvalue(ctx, arg2);
                            if (JSApi.JS_IsException(out2))
                            {
                                return out2;
                            }
                            JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type_hint(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Quaternion)) && Values.js_match_type_hint(ctx, argv[2], typeof(UnityEngine.Vector3)))
                        {
                            UnityEngine.Vector3 arg0;
                            var refVal0 = Values.js_read_wrap(ctx, argv[0]);
                            if (refVal0.IsException())
                            {
                                return refVal0;
                            }
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, refVal0, out arg0))
                            {
                                JSApi.JS_FreeValue(ctx, refVal0);
                                throw new ParameterException(typeof(UnityEditor.Handles), "TransformHandle", typeof(UnityEngine.Vector3), 0);
                            }
                            JSApi.JS_FreeValue(ctx, refVal0);
                            UnityEngine.Quaternion arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "TransformHandle", typeof(UnityEngine.Quaternion), 1);
                            }
                            UnityEngine.Vector3 arg2;
                            var refVal2 = Values.js_read_wrap(ctx, argv[2]);
                            if (refVal2.IsException())
                            {
                                return refVal2;
                            }
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, refVal2, out arg2))
                            {
                                JSApi.JS_FreeValue(ctx, refVal2);
                                throw new ParameterException(typeof(UnityEditor.Handles), "TransformHandle", typeof(UnityEngine.Vector3), 2);
                            }
                            JSApi.JS_FreeValue(ctx, refVal2);
                            UnityEditor.Handles.TransformHandle(ref arg0, arg1, ref arg2);
                            var out0 = QuickJS.Binding.Values.js_push_structvalue(ctx, arg0);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[0], context.GetAtom("value"), out0);
                            var out1 = QuickJS.Binding.Values.js_push_structvalue(ctx, arg2);
                            if (JSApi.JS_IsException(out1))
                            {
                                return out1;
                            }
                            JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type_hint(ctx, argv[1], typeof(UnityEngine.Quaternion)) && Values.js_match_type_hint(ctx, argv[2], typeof(UnityEngine.Vector3)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "TransformHandle", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Quaternion arg1;
                            var refVal1 = Values.js_read_wrap(ctx, argv[1]);
                            if (refVal1.IsException())
                            {
                                return refVal1;
                            }
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, refVal1, out arg1))
                            {
                                JSApi.JS_FreeValue(ctx, refVal1);
                                throw new ParameterException(typeof(UnityEditor.Handles), "TransformHandle", typeof(UnityEngine.Quaternion), 1);
                            }
                            JSApi.JS_FreeValue(ctx, refVal1);
                            UnityEngine.Vector3 arg2;
                            var refVal2 = Values.js_read_wrap(ctx, argv[2]);
                            if (refVal2.IsException())
                            {
                                return refVal2;
                            }
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, refVal2, out arg2))
                            {
                                JSApi.JS_FreeValue(ctx, refVal2);
                                throw new ParameterException(typeof(UnityEditor.Handles), "TransformHandle", typeof(UnityEngine.Vector3), 2);
                            }
                            JSApi.JS_FreeValue(ctx, refVal2);
                            UnityEditor.Handles.TransformHandle(arg0, ref arg1, ref arg2);
                            var out0 = QuickJS.Binding.Values.js_push_structvalue(ctx, arg1);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                            var out1 = QuickJS.Binding.Values.js_push_structvalue(ctx, arg2);
                            if (JSApi.JS_IsException(out1))
                            {
                                return out1;
                            }
                            JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type_hint(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type_hint(ctx, argv[1], typeof(UnityEngine.Quaternion)) && Values.js_match_type_hint(ctx, argv[2], typeof(float)))
                        {
                            UnityEngine.Vector3 arg0;
                            var refVal0 = Values.js_read_wrap(ctx, argv[0]);
                            if (refVal0.IsException())
                            {
                                return refVal0;
                            }
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, refVal0, out arg0))
                            {
                                JSApi.JS_FreeValue(ctx, refVal0);
                                throw new ParameterException(typeof(UnityEditor.Handles), "TransformHandle", typeof(UnityEngine.Vector3), 0);
                            }
                            JSApi.JS_FreeValue(ctx, refVal0);
                            UnityEngine.Quaternion arg1;
                            var refVal1 = Values.js_read_wrap(ctx, argv[1]);
                            if (refVal1.IsException())
                            {
                                return refVal1;
                            }
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, refVal1, out arg1))
                            {
                                JSApi.JS_FreeValue(ctx, refVal1);
                                throw new ParameterException(typeof(UnityEditor.Handles), "TransformHandle", typeof(UnityEngine.Quaternion), 1);
                            }
                            JSApi.JS_FreeValue(ctx, refVal1);
                            float arg2;
                            var refVal2 = Values.js_read_wrap(ctx, argv[2]);
                            if (refVal2.IsException())
                            {
                                return refVal2;
                            }
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, refVal2, out arg2))
                            {
                                JSApi.JS_FreeValue(ctx, refVal2);
                                throw new ParameterException(typeof(UnityEditor.Handles), "TransformHandle", typeof(float), 2);
                            }
                            JSApi.JS_FreeValue(ctx, refVal2);
                            UnityEditor.Handles.TransformHandle(ref arg0, ref arg1, ref arg2);
                            var out0 = QuickJS.Binding.Values.js_push_structvalue(ctx, arg0);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[0], context.GetAtom("value"), out0);
                            var out1 = QuickJS.Binding.Values.js_push_structvalue(ctx, arg1);
                            if (JSApi.JS_IsException(out1))
                            {
                                return out1;
                            }
                            JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out1);
                            var out2 = QuickJS.Binding.Values.js_push_primitive(ctx, arg2);
                            if (JSApi.JS_IsException(out2))
                            {
                                return out2;
                            }
                            JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type_hint(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Quaternion)) && Values.js_match_type_hint(ctx, argv[2], typeof(float)))
                        {
                            UnityEngine.Vector3 arg0;
                            var refVal0 = Values.js_read_wrap(ctx, argv[0]);
                            if (refVal0.IsException())
                            {
                                return refVal0;
                            }
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, refVal0, out arg0))
                            {
                                JSApi.JS_FreeValue(ctx, refVal0);
                                throw new ParameterException(typeof(UnityEditor.Handles), "TransformHandle", typeof(UnityEngine.Vector3), 0);
                            }
                            JSApi.JS_FreeValue(ctx, refVal0);
                            UnityEngine.Quaternion arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "TransformHandle", typeof(UnityEngine.Quaternion), 1);
                            }
                            float arg2;
                            var refVal2 = Values.js_read_wrap(ctx, argv[2]);
                            if (refVal2.IsException())
                            {
                                return refVal2;
                            }
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, refVal2, out arg2))
                            {
                                JSApi.JS_FreeValue(ctx, refVal2);
                                throw new ParameterException(typeof(UnityEditor.Handles), "TransformHandle", typeof(float), 2);
                            }
                            JSApi.JS_FreeValue(ctx, refVal2);
                            UnityEditor.Handles.TransformHandle(ref arg0, arg1, ref arg2);
                            var out0 = QuickJS.Binding.Values.js_push_structvalue(ctx, arg0);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[0], context.GetAtom("value"), out0);
                            var out1 = QuickJS.Binding.Values.js_push_primitive(ctx, arg2);
                            if (JSApi.JS_IsException(out1))
                            {
                                return out1;
                            }
                            JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector3)) && Values.js_match_type_hint(ctx, argv[1], typeof(UnityEngine.Quaternion)) && Values.js_match_type_hint(ctx, argv[2], typeof(float)))
                        {
                            UnityEngine.Vector3 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles), "TransformHandle", typeof(UnityEngine.Vector3), 0);
                            }
                            UnityEngine.Quaternion arg1;
                            var refVal1 = Values.js_read_wrap(ctx, argv[1]);
                            if (refVal1.IsException())
                            {
                                return refVal1;
                            }
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, refVal1, out arg1))
                            {
                                JSApi.JS_FreeValue(ctx, refVal1);
                                throw new ParameterException(typeof(UnityEditor.Handles), "TransformHandle", typeof(UnityEngine.Quaternion), 1);
                            }
                            JSApi.JS_FreeValue(ctx, refVal1);
                            float arg2;
                            var refVal2 = Values.js_read_wrap(ctx, argv[2]);
                            if (refVal2.IsException())
                            {
                                return refVal2;
                            }
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, refVal2, out arg2))
                            {
                                JSApi.JS_FreeValue(ctx, refVal2);
                                throw new ParameterException(typeof(UnityEditor.Handles), "TransformHandle", typeof(float), 2);
                            }
                            JSApi.JS_FreeValue(ctx, refVal2);
                            UnityEditor.Handles.TransformHandle(arg0, ref arg1, ref arg2);
                            var out0 = QuickJS.Binding.Values.js_push_structvalue(ctx, arg1);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                            var out1 = QuickJS.Binding.Values.js_push_primitive(ctx, arg2);
                            if (JSApi.JS_IsException(out1))
                            {
                                return out1;
                            }
                            JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Vector3 arg0;
                        var refVal0 = Values.js_read_wrap(ctx, argv[0]);
                        if (refVal0.IsException())
                        {
                            return refVal0;
                        }
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, refVal0, out arg0))
                        {
                            JSApi.JS_FreeValue(ctx, refVal0);
                            throw new ParameterException(typeof(UnityEditor.Handles), "TransformHandle", typeof(UnityEngine.Vector3), 0);
                        }
                        JSApi.JS_FreeValue(ctx, refVal0);
                        UnityEngine.Quaternion arg1;
                        var refVal1 = Values.js_read_wrap(ctx, argv[1]);
                        if (refVal1.IsException())
                        {
                            return refVal1;
                        }
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, refVal1, out arg1))
                        {
                            JSApi.JS_FreeValue(ctx, refVal1);
                            throw new ParameterException(typeof(UnityEditor.Handles), "TransformHandle", typeof(UnityEngine.Quaternion), 1);
                        }
                        JSApi.JS_FreeValue(ctx, refVal1);
                        UnityEditor.Handles.TransformHandle(ref arg0, ref arg1);
                        var out0 = QuickJS.Binding.Values.js_push_structvalue(ctx, arg0);
                        if (JSApi.JS_IsException(out0))
                        {
                            return out0;
                        }
                        var context = ScriptEngine.GetContext(ctx);
                        JSApi.JS_SetProperty(ctx, argv[0], context.GetAtom("value"), out0);
                        var out1 = QuickJS.Binding.Values.js_push_structvalue(ctx, arg1);
                        if (JSApi.JS_IsException(out1))
                        {
                            return out1;
                        }
                        JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out1);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("TransformHandle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_lighting(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Handles.lighting;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_lighting(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.Handles), "lighting", typeof(bool), 0);
                }
                UnityEditor.Handles.lighting = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_color(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Handles.color;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_color(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Color value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.Handles), "color", typeof(UnityEngine.Color), 0);
                }
                UnityEditor.Handles.color = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_zTest(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Handles.zTest;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_zTest(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Rendering.CompareFunction value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.Handles), "zTest", typeof(UnityEngine.Rendering.CompareFunction), 0);
                }
                UnityEditor.Handles.zTest = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_matrix(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Handles.matrix;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_matrix(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Matrix4x4 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.Handles), "matrix", typeof(UnityEngine.Matrix4x4), 0);
                }
                UnityEditor.Handles.matrix = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_inverseMatrix(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Handles.inverseMatrix;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_xAxisColor(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Handles.xAxisColor;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_yAxisColor(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Handles.yAxisColor;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_zAxisColor(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Handles.zAxisColor;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_centerColor(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Handles.centerColor;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_selectedColor(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Handles.selectedColor;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_preselectionColor(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Handles.preselectionColor;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_secondaryColor(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Handles.secondaryColor;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_currentCamera(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.Handles self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.currentCamera;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_currentCamera(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.Handles self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Camera value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.Handles), "currentCamera", typeof(UnityEngine.Camera), 0);
                }
                self.currentCamera = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("Handles", typeof(UnityEditor.Handles), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "DrawPolyLine", BindStatic_DrawPolyLine);
            cls.AddMethod(true, "DrawLine", BindStatic_DrawLine);
            cls.AddMethod(true, "DrawLines", BindStatic_DrawLines);
            cls.AddMethod(true, "DrawDottedLine", BindStatic_DrawDottedLine);
            cls.AddMethod(true, "DrawDottedLines", BindStatic_DrawDottedLines);
            cls.AddMethod(true, "DrawWireCube", BindStatic_DrawWireCube);
            cls.AddMethod(true, "ShouldRenderGizmos", BindStatic_ShouldRenderGizmos);
            cls.AddMethod(true, "DrawGizmos", BindStatic_DrawGizmos);
            cls.AddMethod(true, "Disc", BindStatic_Disc);
            cls.AddMethod(true, "FreeRotateHandle", BindStatic_FreeRotateHandle);
            cls.AddMethod(true, "Slider", BindStatic_Slider);
            cls.AddMethod(true, "FreeMoveHandle", BindStatic_FreeMoveHandle);
            cls.AddMethod(true, "ScaleValueHandle", BindStatic_ScaleValueHandle);
            cls.AddMethod(true, "Button", BindStatic_Button);
            cls.AddMethod(true, "CubeHandleCap", BindStatic_CubeHandleCap);
            cls.AddMethod(true, "SphereHandleCap", BindStatic_SphereHandleCap);
            cls.AddMethod(true, "ConeHandleCap", BindStatic_ConeHandleCap);
            cls.AddMethod(true, "CylinderHandleCap", BindStatic_CylinderHandleCap);
            cls.AddMethod(true, "RectangleHandleCap", BindStatic_RectangleHandleCap);
            cls.AddMethod(true, "DotHandleCap", BindStatic_DotHandleCap);
            cls.AddMethod(true, "CircleHandleCap", BindStatic_CircleHandleCap);
            cls.AddMethod(true, "ArrowHandleCap", BindStatic_ArrowHandleCap);
            cls.AddMethod(true, "DrawSelectionFrame", BindStatic_DrawSelectionFrame);
            cls.AddMethod(true, "PositionHandle", BindStatic_PositionHandle);
            cls.AddMethod(true, "RotationHandle", BindStatic_RotationHandle);
            cls.AddMethod(true, "ScaleHandle", BindStatic_ScaleHandle);
            cls.AddMethod(true, "RadiusHandle", BindStatic_RadiusHandle);
            cls.AddMethod(true, "Slider2D", BindStatic_Slider2D);
            cls.AddMethod(true, "ScaleSlider", BindStatic_ScaleSlider);
            cls.AddMethod(true, "SnapValue", BindStatic_SnapValue);
            cls.AddMethod(true, "SnapToGrid", BindStatic_SnapToGrid);
            cls.AddMethod(true, "SelectionFrame", BindStatic_SelectionFrame);
            cls.AddMethod(true, "DrawAAPolyLine", BindStatic_DrawAAPolyLine);
            cls.AddMethod(true, "DrawAAConvexPolygon", BindStatic_DrawAAConvexPolygon);
            cls.AddMethod(true, "DrawBezier", BindStatic_DrawBezier);
            cls.AddMethod(true, "DrawWireDisc", BindStatic_DrawWireDisc);
            cls.AddMethod(true, "DrawWireArc", BindStatic_DrawWireArc);
            cls.AddMethod(true, "DrawSolidRectangleWithOutline", BindStatic_DrawSolidRectangleWithOutline);
            cls.AddMethod(true, "DrawSolidDisc", BindStatic_DrawSolidDisc);
            cls.AddMethod(true, "DrawSolidArc", BindStatic_DrawSolidArc);
            cls.AddMethod(true, "Label", BindStatic_Label);
            cls.AddMethod(true, "GetMainGameViewSize", BindStatic_GetMainGameViewSize);
            cls.AddMethod(true, "ClearCamera", BindStatic_ClearCamera);
            cls.AddMethod(true, "DrawCamera", BindStatic_DrawCamera);
            cls.AddMethod(true, "SetCamera", BindStatic_SetCamera);
            cls.AddMethod(true, "BeginGUI", BindStatic_BeginGUI);
            cls.AddMethod(true, "EndGUI", BindStatic_EndGUI);
            cls.AddMethod(true, "MakeBezierPoints", BindStatic_MakeBezierPoints);
            cls.AddMethod(true, "DoPositionHandle", BindStatic_DoPositionHandle);
            cls.AddMethod(true, "DoRotationHandle", BindStatic_DoRotationHandle);
            cls.AddMethod(true, "DoScaleHandle", BindStatic_DoScaleHandle);
            cls.AddMethod(true, "TransformHandle", BindStatic_TransformHandle);
            cls.AddProperty(true, "lighting", BindStaticRead_lighting, BindStaticWrite_lighting);
            cls.AddProperty(true, "color", BindStaticRead_color, BindStaticWrite_color);
            cls.AddProperty(true, "zTest", BindStaticRead_zTest, BindStaticWrite_zTest);
            cls.AddProperty(true, "matrix", BindStaticRead_matrix, BindStaticWrite_matrix);
            cls.AddProperty(true, "inverseMatrix", BindStaticRead_inverseMatrix, null);
            cls.AddProperty(true, "xAxisColor", BindStaticRead_xAxisColor, null);
            cls.AddProperty(true, "yAxisColor", BindStaticRead_yAxisColor, null);
            cls.AddProperty(true, "zAxisColor", BindStaticRead_zAxisColor, null);
            cls.AddProperty(true, "centerColor", BindStaticRead_centerColor, null);
            cls.AddProperty(true, "selectedColor", BindStaticRead_selectedColor, null);
            cls.AddProperty(true, "preselectionColor", BindStaticRead_preselectionColor, null);
            cls.AddProperty(true, "secondaryColor", BindStaticRead_secondaryColor, null);
            cls.AddProperty(false, "currentCamera", BindRead_currentCamera, BindWrite_currentCamera);
            return cls;
        }
    }
}
#endif
#endif
