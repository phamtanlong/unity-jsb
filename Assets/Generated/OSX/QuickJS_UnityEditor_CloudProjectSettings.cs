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
    // Type: UnityEditor.CloudProjectSettings
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_CloudProjectSettings
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new UnityEditor.CloudProjectSettings();
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
        public static JSValue BindStatic_RefreshAccessToken(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    System.Action<bool> arg0;
                    if (!Values.js_get_delegate(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.CloudProjectSettings), "RefreshAccessToken", typeof(System.Action<bool>), 0);
                    }
                    UnityEditor.CloudProjectSettings.RefreshAccessToken(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RefreshAccessToken", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_userId(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.CloudProjectSettings.userId;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_userName(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.CloudProjectSettings.userName;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_accessToken(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.CloudProjectSettings.accessToken;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_projectId(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.CloudProjectSettings.projectId;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_projectName(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.CloudProjectSettings.projectName;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_organizationId(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.CloudProjectSettings.organizationId;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_organizationName(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.CloudProjectSettings.organizationName;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("CloudProjectSettings", typeof(UnityEditor.CloudProjectSettings), BindConstructor);
            cls.AddMethod(true, "RefreshAccessToken", BindStatic_RefreshAccessToken);
            cls.AddProperty(true, "userId", BindStaticRead_userId, null);
            cls.AddProperty(true, "userName", BindStaticRead_userName, null);
            cls.AddProperty(true, "accessToken", BindStaticRead_accessToken, null);
            cls.AddProperty(true, "projectId", BindStaticRead_projectId, null);
            cls.AddProperty(true, "projectName", BindStaticRead_projectName, null);
            cls.AddProperty(true, "organizationId", BindStaticRead_organizationId, null);
            cls.AddProperty(true, "organizationName", BindStaticRead_organizationName, null);
            return cls;
        }
    }
}
#endif
#endif
