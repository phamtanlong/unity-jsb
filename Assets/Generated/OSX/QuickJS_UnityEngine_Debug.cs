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
    // Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2021.3.37f1/Unity.app/Contents/Managed/UnityEngine/UnityEngine.CoreModule.dll
    // Type: UnityEngine.Debug
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_Debug
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new UnityEngine.Debug();
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
        public static JSValue BindStatic_DrawLine(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "DrawLine", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "DrawLine", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Color arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "DrawLine", typeof(UnityEngine.Color), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "DrawLine", typeof(float), 3);
                        }
                        bool arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "DrawLine", typeof(bool), 4);
                        }
                        UnityEngine.Debug.DrawLine(arg0, arg1, arg2, arg3, arg4);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 4)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "DrawLine", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "DrawLine", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Color arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "DrawLine", typeof(UnityEngine.Color), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "DrawLine", typeof(float), 3);
                        }
                        UnityEngine.Debug.DrawLine(arg0, arg1, arg2, arg3);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "DrawLine", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "DrawLine", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Color arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "DrawLine", typeof(UnityEngine.Color), 2);
                        }
                        UnityEngine.Debug.DrawLine(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "DrawLine", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "DrawLine", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Debug.DrawLine(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("DrawLine", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawRay(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "DrawRay", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "DrawRay", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Color arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "DrawRay", typeof(UnityEngine.Color), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "DrawRay", typeof(float), 3);
                        }
                        bool arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "DrawRay", typeof(bool), 4);
                        }
                        UnityEngine.Debug.DrawRay(arg0, arg1, arg2, arg3, arg4);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 4)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "DrawRay", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "DrawRay", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Color arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "DrawRay", typeof(UnityEngine.Color), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "DrawRay", typeof(float), 3);
                        }
                        UnityEngine.Debug.DrawRay(arg0, arg1, arg2, arg3);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "DrawRay", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "DrawRay", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Color arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "DrawRay", typeof(UnityEngine.Color), 2);
                        }
                        UnityEngine.Debug.DrawRay(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "DrawRay", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "DrawRay", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Debug.DrawRay(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("DrawRay", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Break(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Debug.Break();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Break", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DebugBreak(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Debug.DebugBreak();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DebugBreak", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Log(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        object arg0;
                        if (!Values.js_get_var(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "Log", typeof(object), 0);
                        }
                        UnityEngine.Object arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "Log", typeof(UnityEngine.Object), 1);
                        }
                        UnityEngine.Debug.Log(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        object arg0;
                        if (!Values.js_get_var(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "Log", typeof(object), 0);
                        }
                        UnityEngine.Debug.Log(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("Log", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LogFormat(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.LogType)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.LogOption)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[3], typeof(string)) && Values.js_match_param_types(ctx, 4, argv, typeof(object)))
                        {
                            UnityEngine.LogType arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "LogFormat", typeof(UnityEngine.LogType), 0);
                            }
                            UnityEngine.LogOption arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "LogFormat", typeof(UnityEngine.LogOption), 1);
                            }
                            UnityEngine.Object arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "LogFormat", typeof(UnityEngine.Object), 2);
                            }
                            string arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "LogFormat", typeof(string), 3);
                            }
                            object[] arg4 = null;
                            if (argc - 4 > 0)
                            {
                                arg4 = new object[argc - 4];
                                for (var i = 4; i < argc; i++)
                                {
                                    Values.js_get_var(ctx, argv[i], out arg4[i - 4]);
                                }
                            }
                            UnityEngine.Debug.LogFormat(arg0, arg1, arg2, arg3, arg4);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_param_types(ctx, 2, argv, typeof(object)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "LogFormat", typeof(UnityEngine.Object), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "LogFormat", typeof(string), 1);
                            }
                            object[] arg2 = null;
                            if (argc - 2 > 0)
                            {
                                arg2 = new object[argc - 2];
                                for (var i = 2; i < argc; i++)
                                {
                                    Values.js_get_var(ctx, argv[i], out arg2[i - 2]);
                                }
                            }
                            UnityEngine.Debug.LogFormat(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_param_types(ctx, 1, argv, typeof(object)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "LogFormat", typeof(string), 0);
                            }
                            object[] arg1 = null;
                            if (argc - 1 > 0)
                            {
                                arg1 = new object[argc - 1];
                                for (var i = 1; i < argc; i++)
                                {
                                    Values.js_get_var(ctx, argv[i], out arg1[i - 1]);
                                }
                            }
                            UnityEngine.Debug.LogFormat(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("LogFormat", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LogError(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        object arg0;
                        if (!Values.js_get_var(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "LogError", typeof(object), 0);
                        }
                        UnityEngine.Object arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "LogError", typeof(UnityEngine.Object), 1);
                        }
                        UnityEngine.Debug.LogError(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        object arg0;
                        if (!Values.js_get_var(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "LogError", typeof(object), 0);
                        }
                        UnityEngine.Debug.LogError(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("LogError", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LogErrorFormat(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_param_types(ctx, 2, argv, typeof(object)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "LogErrorFormat", typeof(UnityEngine.Object), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "LogErrorFormat", typeof(string), 1);
                            }
                            object[] arg2 = null;
                            if (argc - 2 > 0)
                            {
                                arg2 = new object[argc - 2];
                                for (var i = 2; i < argc; i++)
                                {
                                    Values.js_get_var(ctx, argv[i], out arg2[i - 2]);
                                }
                            }
                            UnityEngine.Debug.LogErrorFormat(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_param_types(ctx, 1, argv, typeof(object)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "LogErrorFormat", typeof(string), 0);
                            }
                            object[] arg1 = null;
                            if (argc - 1 > 0)
                            {
                                arg1 = new object[argc - 1];
                                for (var i = 1; i < argc; i++)
                                {
                                    Values.js_get_var(ctx, argv[i], out arg1[i - 1]);
                                }
                            }
                            UnityEngine.Debug.LogErrorFormat(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("LogErrorFormat", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ClearDeveloperConsole(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Debug.ClearDeveloperConsole();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ClearDeveloperConsole", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LogException(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        System.Exception arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "LogException", typeof(System.Exception), 0);
                        }
                        UnityEngine.Object arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "LogException", typeof(UnityEngine.Object), 1);
                        }
                        UnityEngine.Debug.LogException(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        System.Exception arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "LogException", typeof(System.Exception), 0);
                        }
                        UnityEngine.Debug.LogException(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("LogException", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LogWarning(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        object arg0;
                        if (!Values.js_get_var(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "LogWarning", typeof(object), 0);
                        }
                        UnityEngine.Object arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "LogWarning", typeof(UnityEngine.Object), 1);
                        }
                        UnityEngine.Debug.LogWarning(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        object arg0;
                        if (!Values.js_get_var(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "LogWarning", typeof(object), 0);
                        }
                        UnityEngine.Debug.LogWarning(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("LogWarning", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LogWarningFormat(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_param_types(ctx, 2, argv, typeof(object)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "LogWarningFormat", typeof(UnityEngine.Object), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "LogWarningFormat", typeof(string), 1);
                            }
                            object[] arg2 = null;
                            if (argc - 2 > 0)
                            {
                                arg2 = new object[argc - 2];
                                for (var i = 2; i < argc; i++)
                                {
                                    Values.js_get_var(ctx, argv[i], out arg2[i - 2]);
                                }
                            }
                            UnityEngine.Debug.LogWarningFormat(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_param_types(ctx, 1, argv, typeof(object)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "LogWarningFormat", typeof(string), 0);
                            }
                            object[] arg1 = null;
                            if (argc - 1 > 0)
                            {
                                arg1 = new object[argc - 1];
                                for (var i = 1; i < argc; i++)
                                {
                                    Values.js_get_var(ctx, argv[i], out arg1[i - 1]);
                                }
                            }
                            UnityEngine.Debug.LogWarningFormat(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("LogWarningFormat", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Assert(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(object)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Object)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "Assert", typeof(bool), 0);
                            }
                            object arg1;
                            if (!Values.js_get_var(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "Assert", typeof(object), 1);
                            }
                            UnityEngine.Object arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "Assert", typeof(UnityEngine.Object), 2);
                            }
                            UnityEngine.Debug.Assert(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Object)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "Assert", typeof(bool), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "Assert", typeof(string), 1);
                            }
                            UnityEngine.Object arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "Assert", typeof(UnityEngine.Object), 2);
                            }
                            UnityEngine.Debug.Assert(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Object)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "Assert", typeof(bool), 0);
                            }
                            UnityEngine.Object arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "Assert", typeof(UnityEngine.Object), 1);
                            }
                            UnityEngine.Debug.Assert(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(object)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "Assert", typeof(bool), 0);
                            }
                            object arg1;
                            if (!Values.js_get_var(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "Assert", typeof(object), 1);
                            }
                            UnityEngine.Debug.Assert(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(string)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "Assert", typeof(bool), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "Assert", typeof(string), 1);
                            }
                            UnityEngine.Debug.Assert(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 1)
                    {
                        bool arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "Assert", typeof(bool), 0);
                        }
                        UnityEngine.Debug.Assert(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("Assert", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_AssertFormat(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[2], typeof(string)) && Values.js_match_param_types(ctx, 3, argv, typeof(object)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "AssertFormat", typeof(bool), 0);
                            }
                            UnityEngine.Object arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "AssertFormat", typeof(UnityEngine.Object), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "AssertFormat", typeof(string), 2);
                            }
                            object[] arg3 = null;
                            if (argc - 3 > 0)
                            {
                                arg3 = new object[argc - 3];
                                for (var i = 3; i < argc; i++)
                                {
                                    Values.js_get_var(ctx, argv[i], out arg3[i - 3]);
                                }
                            }
                            UnityEngine.Debug.AssertFormat(arg0, arg1, arg2, arg3);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_param_types(ctx, 2, argv, typeof(object)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "AssertFormat", typeof(bool), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "AssertFormat", typeof(string), 1);
                            }
                            object[] arg2 = null;
                            if (argc - 2 > 0)
                            {
                                arg2 = new object[argc - 2];
                                for (var i = 2; i < argc; i++)
                                {
                                    Values.js_get_var(ctx, argv[i], out arg2[i - 2]);
                                }
                            }
                            UnityEngine.Debug.AssertFormat(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("AssertFormat", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LogAssertion(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        object arg0;
                        if (!Values.js_get_var(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "LogAssertion", typeof(object), 0);
                        }
                        UnityEngine.Object arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "LogAssertion", typeof(UnityEngine.Object), 1);
                        }
                        UnityEngine.Debug.LogAssertion(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        object arg0;
                        if (!Values.js_get_var(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Debug), "LogAssertion", typeof(object), 0);
                        }
                        UnityEngine.Debug.LogAssertion(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("LogAssertion", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LogAssertionFormat(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc >= 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_param_types(ctx, 2, argv, typeof(object)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "LogAssertionFormat", typeof(UnityEngine.Object), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "LogAssertionFormat", typeof(string), 1);
                            }
                            object[] arg2 = null;
                            if (argc - 2 > 0)
                            {
                                arg2 = new object[argc - 2];
                                for (var i = 2; i < argc; i++)
                                {
                                    Values.js_get_var(ctx, argv[i], out arg2[i - 2]);
                                }
                            }
                            UnityEngine.Debug.LogAssertionFormat(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_param_types(ctx, 1, argv, typeof(object)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Debug), "LogAssertionFormat", typeof(string), 0);
                            }
                            object[] arg1 = null;
                            if (argc - 1 > 0)
                            {
                                arg1 = new object[argc - 1];
                                for (var i = 1; i < argc; i++)
                                {
                                    Values.js_get_var(ctx, argv[i], out arg1[i - 1]);
                                }
                            }
                            UnityEngine.Debug.LogAssertionFormat(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("LogAssertionFormat", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_unityLogger(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Debug.unityLogger;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_developerConsoleVisible(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Debug.developerConsoleVisible;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_developerConsoleVisible(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Debug), "developerConsoleVisible", typeof(bool), 0);
                }
                UnityEngine.Debug.developerConsoleVisible = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_isDebugBuild(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Debug.isDebugBuild;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("Debug", typeof(UnityEngine.Debug), BindConstructor);
            cls.AddMethod(true, "DrawLine", BindStatic_DrawLine);
            cls.AddMethod(true, "DrawRay", BindStatic_DrawRay);
            cls.AddMethod(true, "Break", BindStatic_Break);
            cls.AddMethod(true, "DebugBreak", BindStatic_DebugBreak);
            cls.AddMethod(true, "Log", BindStatic_Log);
            cls.AddMethod(true, "LogFormat", BindStatic_LogFormat);
            cls.AddMethod(true, "LogError", BindStatic_LogError);
            cls.AddMethod(true, "LogErrorFormat", BindStatic_LogErrorFormat);
            cls.AddMethod(true, "ClearDeveloperConsole", BindStatic_ClearDeveloperConsole);
            cls.AddMethod(true, "LogException", BindStatic_LogException);
            cls.AddMethod(true, "LogWarning", BindStatic_LogWarning);
            cls.AddMethod(true, "LogWarningFormat", BindStatic_LogWarningFormat);
            cls.AddMethod(true, "Assert", BindStatic_Assert);
            cls.AddMethod(true, "AssertFormat", BindStatic_AssertFormat);
            cls.AddMethod(true, "LogAssertion", BindStatic_LogAssertion);
            cls.AddMethod(true, "LogAssertionFormat", BindStatic_LogAssertionFormat);
            cls.AddProperty(true, "unityLogger", BindStaticRead_unityLogger, null);
            cls.AddProperty(true, "developerConsoleVisible", BindStaticRead_developerConsoleVisible, BindStaticWrite_developerConsoleVisible);
            cls.AddProperty(true, "isDebugBuild", BindStaticRead_isDebugBuild, null);
            return cls;
        }
    }
}
#endif
