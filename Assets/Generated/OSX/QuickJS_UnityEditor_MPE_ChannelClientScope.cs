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
    // Type: UnityEditor.MPE.ChannelClientScope
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_MPE_ChannelClientScope
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(System.Action<string>)) && Values.js_match_type(ctx, argv[3], typeof(bool)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.ChannelClientScope), ".ctor", typeof(bool), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.ChannelClientScope), ".ctor", typeof(string), 1);
                            }
                            System.Action<string> arg2;
                            if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.ChannelClientScope), ".ctor", typeof(System.Action<string>), 2);
                            }
                            bool arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.ChannelClientScope), ".ctor", typeof(bool), 3);
                            }
                            var o = new UnityEditor.MPE.ChannelClientScope(arg0, arg1, arg2, arg3);
                            var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                            return val;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(bool)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(System.Action<byte[]>)) && Values.js_match_type(ctx, argv[3], typeof(bool)))
                        {
                            bool arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.ChannelClientScope), ".ctor", typeof(bool), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.ChannelClientScope), ".ctor", typeof(string), 1);
                            }
                            System.Action<byte[]> arg2;
                            if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.ChannelClientScope), ".ctor", typeof(System.Action<byte[]>), 2);
                            }
                            bool arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.MPE.ChannelClientScope), ".ctor", typeof(bool), 3);
                            }
                            var o = new UnityEditor.MPE.ChannelClientScope(arg0, arg1, arg2, arg3);
                            var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                            return val;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("constructor", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Dispose(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.MPE.ChannelClientScope self;
                    if (!Values.js_get_structvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.Dispose();
                    Values.js_rebind_this(ctx, this_obj, ref self);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Dispose", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_client(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.MPE.ChannelClientScope self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.client;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("ChannelClientScope", typeof(UnityEditor.MPE.ChannelClientScope), BindConstructor);
            cls.AddMethod(false, "Dispose", Bind_Dispose);
            cls.AddProperty(false, "client", BindRead_client, null);
            return cls;
        }
    }
}
#endif
#endif
