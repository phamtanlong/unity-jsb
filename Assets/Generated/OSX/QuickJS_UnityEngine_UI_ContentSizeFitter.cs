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
    // Type: UnityEngine.UI.ContentSizeFitter
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_UI_ContentSizeFitter
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetLayoutHorizontal(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.UI.ContentSizeFitter self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.SetLayoutHorizontal();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetLayoutHorizontal", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetLayoutVertical(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.UI.ContentSizeFitter self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.SetLayoutVertical();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetLayoutVertical", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_horizontalFit(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.ContentSizeFitter self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.horizontalFit;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_horizontalFit(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.UI.ContentSizeFitter self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.UI.ContentSizeFitter.FitMode value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.UI.ContentSizeFitter), "horizontalFit", typeof(UnityEngine.UI.ContentSizeFitter.FitMode), 0);
                }
                self.horizontalFit = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_verticalFit(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.ContentSizeFitter self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.verticalFit;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_verticalFit(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.UI.ContentSizeFitter self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.UI.ContentSizeFitter.FitMode value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.UI.ContentSizeFitter), "verticalFit", typeof(UnityEngine.UI.ContentSizeFitter.FitMode), 0);
                }
                self.verticalFit = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("ContentSizeFitter", typeof(UnityEngine.UI.ContentSizeFitter), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(false, "SetLayoutHorizontal", Bind_SetLayoutHorizontal);
            cls.AddMethod(false, "SetLayoutVertical", Bind_SetLayoutVertical);
            cls.AddProperty(false, "horizontalFit", BindRead_horizontalFit, BindWrite_horizontalFit);
            cls.AddProperty(false, "verticalFit", BindRead_verticalFit, BindWrite_verticalFit);
            return cls;
        }
    }
}
#endif
