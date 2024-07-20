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
    // Type: UnityEditor.Connect.UnityOAuth
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_Connect_UnityOAuth
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetAuthorizationCodeAsync(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Connect.UnityOAuth), "GetAuthorizationCodeAsync", typeof(string), 0);
                    }
                    System.Action<UnityEditor.Connect.UnityOAuth.AuthCodeResponse> arg1;
                    if (!Values.js_get_delegate(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Connect.UnityOAuth), "GetAuthorizationCodeAsync", typeof(System.Action<UnityEditor.Connect.UnityOAuth.AuthCodeResponse>), 1);
                    }
                    UnityEditor.Connect.UnityOAuth.GetAuthorizationCodeAsync(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("GetAuthorizationCodeAsync", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_UserLoggedIn(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                System.Action value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.Connect.UnityOAuth), "UserLoggedIn", typeof(System.Action), 1);
                        }
                        UnityEditor.Connect.UnityOAuth.UserLoggedIn += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.Connect.UnityOAuth), "UserLoggedIn", typeof(System.Action), 1);
                        }
                        UnityEditor.Connect.UnityOAuth.UserLoggedIn -= value;
                        break;
                    default: throw new JSException("invalid event op");
                }
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_UserLoggedOut(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                System.Action value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.Connect.UnityOAuth), "UserLoggedOut", typeof(System.Action), 1);
                        }
                        UnityEditor.Connect.UnityOAuth.UserLoggedOut += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.Connect.UnityOAuth), "UserLoggedOut", typeof(System.Action), 1);
                        }
                        UnityEditor.Connect.UnityOAuth.UserLoggedOut -= value;
                        break;
                    default: throw new JSException("invalid event op");
                }
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("UnityOAuth", typeof(UnityEditor.Connect.UnityOAuth), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "GetAuthorizationCodeAsync", BindStatic_GetAuthorizationCodeAsync);
            cls.AddMethod(true, "UserLoggedIn", BindStaticEvent_UserLoggedIn);
            cls.AddMethod(true, "UserLoggedOut", BindStaticEvent_UserLoggedOut);
            return cls;
        }
    }
}
#endif
#endif
