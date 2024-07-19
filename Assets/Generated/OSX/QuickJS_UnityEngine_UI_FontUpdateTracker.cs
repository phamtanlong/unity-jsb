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
    // Assembly: UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Users/longpt/Documents/SkyMavis/unity-jsb-2/Library/ScriptAssemblies/UnityEngine.UI.dll
    // Type: UnityEngine.UI.FontUpdateTracker
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_UI_FontUpdateTracker
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_TrackText(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.UI.Text arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.FontUpdateTracker), "TrackText", typeof(UnityEngine.UI.Text), 0);
                    }
                    UnityEngine.UI.FontUpdateTracker.TrackText(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("TrackText", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_UntrackText(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.UI.Text arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.FontUpdateTracker), "UntrackText", typeof(UnityEngine.UI.Text), 0);
                    }
                    UnityEngine.UI.FontUpdateTracker.UntrackText(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("UntrackText", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("FontUpdateTracker", typeof(UnityEngine.UI.FontUpdateTracker), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "TrackText", BindStatic_TrackText);
            cls.AddMethod(true, "UntrackText", BindStatic_UntrackText);
            return cls;
        }
    }
}
#endif
