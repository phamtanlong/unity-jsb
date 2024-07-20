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
    // Type: UnityEditor.MPE.EventService
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_MPE_EventService
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Start(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.MPE.EventService.Start();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Start", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Close(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.MPE.EventService.Close();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Close", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RegisterEventHandler(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(System.Action<string, object[]>)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.EventService), "RegisterEventHandler", typeof(string), 0);
                            }
                            System.Action<string, object[]> arg1;
                            if (!Values.js_get_delegate(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.EventService), "RegisterEventHandler", typeof(System.Action<string, object[]>), 1);
                            }
                            var ret = UnityEditor.MPE.EventService.RegisterEventHandler(arg0, arg1);
                            return Values.js_push_delegate(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(System.Func<string, object[], object>)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.EventService), "RegisterEventHandler", typeof(string), 0);
                            }
                            System.Func<string, object[], object> arg1;
                            if (!Values.js_get_delegate(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.EventService), "RegisterEventHandler", typeof(System.Func<string, object[], object>), 1);
                            }
                            var ret = UnityEditor.MPE.EventService.RegisterEventHandler(arg0, arg1);
                            return Values.js_push_delegate(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("RegisterEventHandler", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_UnregisterEventHandler(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.MPE.EventService), "UnregisterEventHandler", typeof(string), 0);
                    }
                    System.Func<string, object[], object> arg1;
                    if (!Values.js_get_delegate(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.MPE.EventService), "UnregisterEventHandler", typeof(System.Func<string, object[], object>), 1);
                    }
                    UnityEditor.MPE.EventService.UnregisterEventHandler(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("UnregisterEventHandler", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Clear(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.MPE.EventService.Clear();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Clear", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Emit(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(object)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(UnityEditor.MPE.EventDataSerialization)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.EventService), "Emit", typeof(string), 0);
                            }
                            object arg1;
                            if (!Values.js_get_var(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.EventService), "Emit", typeof(object), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.EventService), "Emit", typeof(int), 2);
                            }
                            UnityEditor.MPE.EventDataSerialization arg3;
                            if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.EventService), "Emit", typeof(UnityEditor.MPE.EventDataSerialization), 3);
                            }
                            UnityEditor.MPE.EventService.Emit(arg0, arg1, arg2, arg3);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(object[])) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(UnityEditor.MPE.EventDataSerialization)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.EventService), "Emit", typeof(string), 0);
                            }
                            object[] arg1;
                            if (!Values.js_get_var(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.EventService), "Emit", typeof(object[]), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.EventService), "Emit", typeof(int), 2);
                            }
                            UnityEditor.MPE.EventDataSerialization arg3;
                            if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.EventService), "Emit", typeof(UnityEditor.MPE.EventDataSerialization), 3);
                            }
                            UnityEditor.MPE.EventService.Emit(arg0, arg1, arg2, arg3);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Emit", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsRequestPending(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.MPE.EventService), "IsRequestPending", typeof(string), 0);
                    }
                    var ret = UnityEditor.MPE.EventService.IsRequestPending(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsRequestPending", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CancelRequest(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.MPE.EventService), "CancelRequest", typeof(string), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.MPE.EventService), "CancelRequest", typeof(string), 1);
                    }
                    var ret = UnityEditor.MPE.EventService.CancelRequest(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("CancelRequest", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Request(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(System.Action<System.Exception, object[]>)) && Values.js_match_type(ctx, argv[2], typeof(object)) && Values.js_match_type(ctx, argv[3], typeof(long)) && Values.js_match_type(ctx, argv[4], typeof(UnityEditor.MPE.EventDataSerialization)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.EventService), "Request", typeof(string), 0);
                            }
                            System.Action<System.Exception, object[]> arg1;
                            if (!Values.js_get_delegate(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.EventService), "Request", typeof(System.Action<System.Exception, object[]>), 1);
                            }
                            object arg2;
                            if (!Values.js_get_var(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.EventService), "Request", typeof(object), 2);
                            }
                            long arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.EventService), "Request", typeof(long), 3);
                            }
                            UnityEditor.MPE.EventDataSerialization arg4;
                            if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.EventService), "Request", typeof(UnityEditor.MPE.EventDataSerialization), 4);
                            }
                            UnityEditor.MPE.EventService.Request(arg0, arg1, arg2, arg3, arg4);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(System.Action<System.Exception, object[]>)) && Values.js_match_type(ctx, argv[2], typeof(object[])) && Values.js_match_type(ctx, argv[3], typeof(long)) && Values.js_match_type(ctx, argv[4], typeof(UnityEditor.MPE.EventDataSerialization)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.EventService), "Request", typeof(string), 0);
                            }
                            System.Action<System.Exception, object[]> arg1;
                            if (!Values.js_get_delegate(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.EventService), "Request", typeof(System.Action<System.Exception, object[]>), 1);
                            }
                            object[] arg2;
                            if (!Values.js_get_var(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.EventService), "Request", typeof(object[]), 2);
                            }
                            long arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.EventService), "Request", typeof(long), 3);
                            }
                            UnityEditor.MPE.EventDataSerialization arg4;
                            if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.EventService), "Request", typeof(UnityEditor.MPE.EventDataSerialization), 4);
                            }
                            UnityEditor.MPE.EventService.Request(arg0, arg1, arg2, arg3, arg4);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Request", argc);
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
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.MPE.EventService), "Log", typeof(string), 0);
                        }
                        UnityEngine.LogType arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.MPE.EventService), "Log", typeof(UnityEngine.LogType), 1);
                        }
                        UnityEditor.MPE.EventService.Log(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.MPE.EventService), "Log", typeof(string), 0);
                        }
                        UnityEditor.MPE.EventService.Log(arg0);
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
        public static JSValue BindStatic_Tick(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.MPE.EventService.Tick();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Tick", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_isConnected(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.MPE.EventService.isConnected;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("EventService", typeof(UnityEditor.MPE.EventService), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "Start", BindStatic_Start);
            cls.AddMethod(true, "Close", BindStatic_Close);
            cls.AddMethod(true, "RegisterEventHandler", BindStatic_RegisterEventHandler);
            cls.AddMethod(true, "UnregisterEventHandler", BindStatic_UnregisterEventHandler);
            cls.AddMethod(true, "Clear", BindStatic_Clear);
            cls.AddMethod(true, "Emit", BindStatic_Emit);
            cls.AddMethod(true, "IsRequestPending", BindStatic_IsRequestPending);
            cls.AddMethod(true, "CancelRequest", BindStatic_CancelRequest);
            cls.AddMethod(true, "Request", BindStatic_Request);
            cls.AddMethod(true, "Log", BindStatic_Log);
            cls.AddMethod(true, "Tick", BindStatic_Tick);
            cls.AddProperty(true, "isConnected", BindStaticRead_isConnected, null);
            return cls;
        }
    }
}
#endif
#endif
