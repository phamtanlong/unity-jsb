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
    // Type: UnityEditor.EditorAnalytics
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_EditorAnalytics
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RegisterEventWithLimit(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorAnalytics), "RegisterEventWithLimit", typeof(string), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorAnalytics), "RegisterEventWithLimit", typeof(int), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorAnalytics), "RegisterEventWithLimit", typeof(int), 2);
                        }
                        string arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorAnalytics), "RegisterEventWithLimit", typeof(string), 3);
                        }
                        int arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorAnalytics), "RegisterEventWithLimit", typeof(int), 4);
                        }
                        var ret = UnityEditor.EditorAnalytics.RegisterEventWithLimit(arg0, arg1, arg2, arg3, arg4);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                    }
                    if (argc == 4)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorAnalytics), "RegisterEventWithLimit", typeof(string), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorAnalytics), "RegisterEventWithLimit", typeof(int), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorAnalytics), "RegisterEventWithLimit", typeof(int), 2);
                        }
                        string arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorAnalytics), "RegisterEventWithLimit", typeof(string), 3);
                        }
                        var ret = UnityEditor.EditorAnalytics.RegisterEventWithLimit(arg0, arg1, arg2, arg3);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("RegisterEventWithLimit", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SendEventWithLimit(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorAnalytics), "SendEventWithLimit", typeof(string), 0);
                        }
                        object arg1;
                        if (!Values.js_get_var(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorAnalytics), "SendEventWithLimit", typeof(object), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorAnalytics), "SendEventWithLimit", typeof(int), 2);
                        }
                        var ret = UnityEditor.EditorAnalytics.SendEventWithLimit(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                    }
                    if (argc == 2)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorAnalytics), "SendEventWithLimit", typeof(string), 0);
                        }
                        object arg1;
                        if (!Values.js_get_var(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorAnalytics), "SendEventWithLimit", typeof(object), 1);
                        }
                        var ret = UnityEditor.EditorAnalytics.SendEventWithLimit(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("SendEventWithLimit", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetEventWithLimitEndPoint(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorAnalytics), "SetEventWithLimitEndPoint", typeof(string), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorAnalytics), "SetEventWithLimitEndPoint", typeof(string), 1);
                    }
                    int arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorAnalytics), "SetEventWithLimitEndPoint", typeof(int), 2);
                    }
                    var ret = UnityEditor.EditorAnalytics.SetEventWithLimitEndPoint(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                }
                throw new NoSuitableMethodException("SetEventWithLimitEndPoint", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetEventWithLimitPriority(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorAnalytics), "SetEventWithLimitPriority", typeof(string), 0);
                    }
                    UnityEngine.Analytics.AnalyticsEventPriority arg1;
                    if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorAnalytics), "SetEventWithLimitPriority", typeof(UnityEngine.Analytics.AnalyticsEventPriority), 1);
                    }
                    int arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorAnalytics), "SetEventWithLimitPriority", typeof(int), 2);
                    }
                    var ret = UnityEditor.EditorAnalytics.SetEventWithLimitPriority(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                }
                throw new NoSuitableMethodException("SetEventWithLimitPriority", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_enabled(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorAnalytics.enabled;
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
                    throw new ParameterException(typeof(UnityEditor.EditorAnalytics), "enabled", typeof(bool), 0);
                }
                UnityEditor.EditorAnalytics.enabled = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("EditorAnalytics", typeof(UnityEditor.EditorAnalytics), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "RegisterEventWithLimit", BindStatic_RegisterEventWithLimit);
            cls.AddMethod(true, "SendEventWithLimit", BindStatic_SendEventWithLimit);
            cls.AddMethod(true, "SetEventWithLimitEndPoint", BindStatic_SetEventWithLimitEndPoint);
            cls.AddMethod(true, "SetEventWithLimitPriority", BindStatic_SetEventWithLimitPriority);
            cls.AddProperty(true, "enabled", BindStaticRead_enabled, BindStaticWrite_enabled);
            return cls;
        }
    }
}
#endif
#endif
