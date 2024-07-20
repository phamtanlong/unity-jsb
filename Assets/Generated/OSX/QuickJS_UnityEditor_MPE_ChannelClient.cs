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
    // Type: UnityEditor.MPE.ChannelClient
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_MPE_ChannelClient
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_IsConnected(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.MPE.ChannelClient self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.IsConnected();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsConnected", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Start(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.MPE.ChannelClient self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    bool arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.MPE.ChannelClient), "Start", typeof(bool), 0);
                    }
                    self.Start(arg0);
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
        public static JSValue Bind_Stop(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.MPE.ChannelClient self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.Stop();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Stop", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Close(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.MPE.ChannelClient self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.Close();
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
        public static JSValue Bind_Tick(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.MPE.ChannelClient self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.Tick();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Tick", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Send(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            UnityEditor.MPE.ChannelClient self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.ChannelClient), "Send", typeof(string), 0);
                            }
                            self.Send(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(byte[])))
                        {
                            UnityEditor.MPE.ChannelClient self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            byte[] arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.ChannelClient), "Send", typeof(byte[]), 0);
                            }
                            self.Send(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Send", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_RegisterMessageHandler(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Action<string>)))
                        {
                            UnityEditor.MPE.ChannelClient self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            System.Action<string> arg0;
                            if (!Values.js_get_delegate(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.ChannelClient), "RegisterMessageHandler", typeof(System.Action<string>), 0);
                            }
                            var ret = self.RegisterMessageHandler(arg0);
                            return Values.js_push_delegate(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Action<byte[]>)))
                        {
                            UnityEditor.MPE.ChannelClient self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            System.Action<byte[]> arg0;
                            if (!Values.js_get_delegate(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.ChannelClient), "RegisterMessageHandler", typeof(System.Action<byte[]>), 0);
                            }
                            var ret = self.RegisterMessageHandler(arg0);
                            return Values.js_push_delegate(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("RegisterMessageHandler", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_UnregisterMessageHandler(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Action<string>)))
                        {
                            UnityEditor.MPE.ChannelClient self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            System.Action<string> arg0;
                            if (!Values.js_get_delegate(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.ChannelClient), "UnregisterMessageHandler", typeof(System.Action<string>), 0);
                            }
                            self.UnregisterMessageHandler(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Action<byte[]>)))
                        {
                            UnityEditor.MPE.ChannelClient self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            System.Action<byte[]> arg0;
                            if (!Values.js_get_delegate(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.ChannelClient), "UnregisterMessageHandler", typeof(System.Action<byte[]>), 0);
                            }
                            self.UnregisterMessageHandler(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("UnregisterMessageHandler", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_NewRequestId(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.MPE.ChannelClient self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.NewRequestId();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("NewRequestId", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetChannelClientInfo(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.MPE.ChannelClient self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.GetChannelClientInfo();
                    return Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetChannelClientInfo", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_NewRequestId(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.MPE.ChannelClient), "NewRequestId", typeof(int), 0);
                    }
                    var ret = UnityEditor.MPE.ChannelClient.NewRequestId(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("NewRequestId", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetChannelClientInfo(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.ChannelClient), "GetChannelClientInfo", typeof(int), 0);
                            }
                            var ret = UnityEditor.MPE.ChannelClient.GetChannelClientInfo(arg0);
                            return Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.ChannelClient), "GetChannelClientInfo", typeof(string), 0);
                            }
                            var ret = UnityEditor.MPE.ChannelClient.GetChannelClientInfo(arg0);
                            return Values.js_push_structvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("GetChannelClientInfo", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetChannelClientList(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.MPE.ChannelClient.GetChannelClientList();
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetChannelClientList", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Send(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.MPE.ChannelClient), "Send", typeof(int), 0);
                    }
                    byte[] arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.MPE.ChannelClient), "Send", typeof(byte[]), 1);
                    }
                    UnityEditor.MPE.ChannelClient.Send(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Send", argc);
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
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.MPE.ChannelClient), "Close", typeof(string), 0);
                    }
                    UnityEditor.MPE.ChannelClient.Close(arg0);
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
        public static JSValue BindStatic_GetOrCreateClient(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.MPE.ChannelClient), "GetOrCreateClient", typeof(string), 0);
                    }
                    var ret = UnityEditor.MPE.ChannelClient.GetOrCreateClient(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetOrCreateClient", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Shutdown(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.MPE.ChannelClient.Shutdown();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Shutdown", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_clientId(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.MPE.ChannelClient self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.clientId;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_channelName(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.MPE.ChannelClient self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.channelName;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_isAutoTick(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.MPE.ChannelClient self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.isAutoTick;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("ChannelClient", typeof(UnityEditor.MPE.ChannelClient), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(false, "IsConnected", Bind_IsConnected);
            cls.AddMethod(false, "Start", Bind_Start);
            cls.AddMethod(false, "Stop", Bind_Stop);
            cls.AddMethod(false, "Close", Bind_Close);
            cls.AddMethod(false, "Tick", Bind_Tick);
            cls.AddMethod(false, "Send", Bind_Send);
            cls.AddMethod(false, "RegisterMessageHandler", Bind_RegisterMessageHandler);
            cls.AddMethod(false, "UnregisterMessageHandler", Bind_UnregisterMessageHandler);
            cls.AddMethod(false, "NewRequestId", Bind_NewRequestId);
            cls.AddMethod(false, "GetChannelClientInfo", Bind_GetChannelClientInfo);
            cls.AddMethod(true, "NewRequestId", BindStatic_NewRequestId);
            cls.AddMethod(true, "GetChannelClientInfo", BindStatic_GetChannelClientInfo);
            cls.AddMethod(true, "GetChannelClientList", BindStatic_GetChannelClientList);
            cls.AddMethod(true, "Send", BindStatic_Send);
            cls.AddMethod(true, "Close", BindStatic_Close);
            cls.AddMethod(true, "GetOrCreateClient", BindStatic_GetOrCreateClient);
            cls.AddMethod(true, "Shutdown", BindStatic_Shutdown);
            cls.AddProperty(false, "clientId", BindRead_clientId, null);
            cls.AddProperty(false, "channelName", BindRead_channelName, null);
            cls.AddProperty(false, "isAutoTick", BindRead_isAutoTick, null);
            return cls;
        }
    }
}
#endif
#endif
