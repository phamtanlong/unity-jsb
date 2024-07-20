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
    // Type: UnityEditor.Analytics.AnalyticsSettings
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_Analytics_AnalyticsSettings
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_enabled(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Analytics.AnalyticsSettings.enabled;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_enabled(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.Analytics.AnalyticsSettings), "enabled", typeof(bool), 0);
                }
                UnityEditor.Analytics.AnalyticsSettings.enabled = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_testMode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Analytics.AnalyticsSettings.testMode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_testMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.Analytics.AnalyticsSettings), "testMode", typeof(bool), 0);
                }
                UnityEditor.Analytics.AnalyticsSettings.testMode = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_initializeOnStartup(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Analytics.AnalyticsSettings.initializeOnStartup;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_initializeOnStartup(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.Analytics.AnalyticsSettings), "initializeOnStartup", typeof(bool), 0);
                }
                UnityEditor.Analytics.AnalyticsSettings.initializeOnStartup = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_deviceStatsEnabledInBuild(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Analytics.AnalyticsSettings.deviceStatsEnabledInBuild;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_packageRequiringCoreStatsPresent(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Analytics.AnalyticsSettings.packageRequiringCoreStatsPresent;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_packageRequiringCoreStatsPresent(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.Analytics.AnalyticsSettings), "packageRequiringCoreStatsPresent", typeof(bool), 0);
                }
                UnityEditor.Analytics.AnalyticsSettings.packageRequiringCoreStatsPresent = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_eventUrl(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Analytics.AnalyticsSettings.eventUrl;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_eventUrl(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.Analytics.AnalyticsSettings), "eventUrl", typeof(string), 0);
                }
                UnityEditor.Analytics.AnalyticsSettings.eventUrl = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_configUrl(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Analytics.AnalyticsSettings.configUrl;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_configUrl(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.Analytics.AnalyticsSettings), "configUrl", typeof(string), 0);
                }
                UnityEditor.Analytics.AnalyticsSettings.configUrl = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_dashboardUrl(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Analytics.AnalyticsSettings.dashboardUrl;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_dashboardUrl(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.Analytics.AnalyticsSettings), "dashboardUrl", typeof(string), 0);
                }
                UnityEditor.Analytics.AnalyticsSettings.dashboardUrl = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_OnRequireInBuildHandler(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                UnityEditor.Analytics.AnalyticsSettings.RequireInBuildDelegate value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.Analytics.AnalyticsSettings), "OnRequireInBuildHandler", typeof(UnityEditor.Analytics.AnalyticsSettings.RequireInBuildDelegate), 1);
                        }
                        UnityEditor.Analytics.AnalyticsSettings.OnRequireInBuildHandler += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.Analytics.AnalyticsSettings), "OnRequireInBuildHandler", typeof(UnityEditor.Analytics.AnalyticsSettings.RequireInBuildDelegate), 1);
                        }
                        UnityEditor.Analytics.AnalyticsSettings.OnRequireInBuildHandler -= value;
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
            var cls = register.CreateClass("AnalyticsSettings", typeof(UnityEditor.Analytics.AnalyticsSettings), QuickJS.JSNative.class_private_ctor);
            cls.AddProperty(true, "enabled", BindStaticRead_enabled, BindStaticWrite_enabled);
            cls.AddProperty(true, "testMode", BindStaticRead_testMode, BindStaticWrite_testMode);
            cls.AddProperty(true, "initializeOnStartup", BindStaticRead_initializeOnStartup, BindStaticWrite_initializeOnStartup);
            cls.AddProperty(true, "deviceStatsEnabledInBuild", BindStaticRead_deviceStatsEnabledInBuild, null);
            cls.AddProperty(true, "packageRequiringCoreStatsPresent", BindStaticRead_packageRequiringCoreStatsPresent, BindStaticWrite_packageRequiringCoreStatsPresent);
            cls.AddProperty(true, "eventUrl", BindStaticRead_eventUrl, BindStaticWrite_eventUrl);
            cls.AddProperty(true, "configUrl", BindStaticRead_configUrl, BindStaticWrite_configUrl);
            cls.AddProperty(true, "dashboardUrl", BindStaticRead_dashboardUrl, BindStaticWrite_dashboardUrl);
            cls.AddMethod(true, "OnRequireInBuildHandler", BindStaticEvent_OnRequireInBuildHandler);
            return cls;
        }
    }
}
#endif
#endif
