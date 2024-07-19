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
    // Type: UnityEngine.UI.LayoutUtility
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_UI_LayoutUtility
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetMinSize(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.RectTransform arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.LayoutUtility), "GetMinSize", typeof(UnityEngine.RectTransform), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.LayoutUtility), "GetMinSize", typeof(int), 1);
                    }
                    var ret = UnityEngine.UI.LayoutUtility.GetMinSize(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetMinSize", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetPreferredSize(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.RectTransform arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.LayoutUtility), "GetPreferredSize", typeof(UnityEngine.RectTransform), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.LayoutUtility), "GetPreferredSize", typeof(int), 1);
                    }
                    var ret = UnityEngine.UI.LayoutUtility.GetPreferredSize(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetPreferredSize", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetFlexibleSize(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.RectTransform arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.LayoutUtility), "GetFlexibleSize", typeof(UnityEngine.RectTransform), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.LayoutUtility), "GetFlexibleSize", typeof(int), 1);
                    }
                    var ret = UnityEngine.UI.LayoutUtility.GetFlexibleSize(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetFlexibleSize", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetMinWidth(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.RectTransform arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.LayoutUtility), "GetMinWidth", typeof(UnityEngine.RectTransform), 0);
                    }
                    var ret = UnityEngine.UI.LayoutUtility.GetMinWidth(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetMinWidth", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetPreferredWidth(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.RectTransform arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.LayoutUtility), "GetPreferredWidth", typeof(UnityEngine.RectTransform), 0);
                    }
                    var ret = UnityEngine.UI.LayoutUtility.GetPreferredWidth(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetPreferredWidth", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetFlexibleWidth(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.RectTransform arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.LayoutUtility), "GetFlexibleWidth", typeof(UnityEngine.RectTransform), 0);
                    }
                    var ret = UnityEngine.UI.LayoutUtility.GetFlexibleWidth(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetFlexibleWidth", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetMinHeight(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.RectTransform arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.LayoutUtility), "GetMinHeight", typeof(UnityEngine.RectTransform), 0);
                    }
                    var ret = UnityEngine.UI.LayoutUtility.GetMinHeight(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetMinHeight", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetPreferredHeight(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.RectTransform arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.LayoutUtility), "GetPreferredHeight", typeof(UnityEngine.RectTransform), 0);
                    }
                    var ret = UnityEngine.UI.LayoutUtility.GetPreferredHeight(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetPreferredHeight", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetFlexibleHeight(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.RectTransform arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.LayoutUtility), "GetFlexibleHeight", typeof(UnityEngine.RectTransform), 0);
                    }
                    var ret = UnityEngine.UI.LayoutUtility.GetFlexibleHeight(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetFlexibleHeight", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetLayoutProperty(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        UnityEngine.RectTransform arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.LayoutUtility), "GetLayoutProperty", typeof(UnityEngine.RectTransform), 0);
                        }
                        System.Func<UnityEngine.UI.ILayoutElement, float> arg1;
                        if (!Values.js_get_delegate(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.LayoutUtility), "GetLayoutProperty", typeof(System.Func<UnityEngine.UI.ILayoutElement, float>), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.LayoutUtility), "GetLayoutProperty", typeof(float), 2);
                        }
                        UnityEngine.UI.ILayoutElement arg3;
                        var ret = UnityEngine.UI.LayoutUtility.GetLayoutProperty(arg0, arg1, arg2, out arg3);
                        var out0 = Values.js_push_classvalue(ctx, arg3);
                        if (JSApi.JS_IsException(out0))
                        {
                            return out0;
                        }
                        var context = ScriptEngine.GetContext(ctx);
                        JSApi.JS_SetProperty(ctx, argv[3], context.GetAtom("value"), out0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        UnityEngine.RectTransform arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.LayoutUtility), "GetLayoutProperty", typeof(UnityEngine.RectTransform), 0);
                        }
                        System.Func<UnityEngine.UI.ILayoutElement, float> arg1;
                        if (!Values.js_get_delegate(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.LayoutUtility), "GetLayoutProperty", typeof(System.Func<UnityEngine.UI.ILayoutElement, float>), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.LayoutUtility), "GetLayoutProperty", typeof(float), 2);
                        }
                        var ret = UnityEngine.UI.LayoutUtility.GetLayoutProperty(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("GetLayoutProperty", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("LayoutUtility", typeof(UnityEngine.UI.LayoutUtility), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "GetMinSize", BindStatic_GetMinSize);
            cls.AddMethod(true, "GetPreferredSize", BindStatic_GetPreferredSize);
            cls.AddMethod(true, "GetFlexibleSize", BindStatic_GetFlexibleSize);
            cls.AddMethod(true, "GetMinWidth", BindStatic_GetMinWidth);
            cls.AddMethod(true, "GetPreferredWidth", BindStatic_GetPreferredWidth);
            cls.AddMethod(true, "GetFlexibleWidth", BindStatic_GetFlexibleWidth);
            cls.AddMethod(true, "GetMinHeight", BindStatic_GetMinHeight);
            cls.AddMethod(true, "GetPreferredHeight", BindStatic_GetPreferredHeight);
            cls.AddMethod(true, "GetFlexibleHeight", BindStatic_GetFlexibleHeight);
            cls.AddMethod(true, "GetLayoutProperty", BindStatic_GetLayoutProperty);
            return cls;
        }
    }
}
#endif
