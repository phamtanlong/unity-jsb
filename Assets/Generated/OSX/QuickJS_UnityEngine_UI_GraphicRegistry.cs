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
    // Assembly: UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Users/longpt/Documents/SkyMavis/unity-jsb-2021/Library/ScriptAssemblies/UnityEngine.UI.dll
    // Type: UnityEngine.UI.GraphicRegistry
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_UI_GraphicRegistry
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RegisterGraphicForCanvas(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Canvas arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.GraphicRegistry), "RegisterGraphicForCanvas", typeof(UnityEngine.Canvas), 0);
                    }
                    UnityEngine.UI.Graphic arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.GraphicRegistry), "RegisterGraphicForCanvas", typeof(UnityEngine.UI.Graphic), 1);
                    }
                    UnityEngine.UI.GraphicRegistry.RegisterGraphicForCanvas(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RegisterGraphicForCanvas", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RegisterRaycastGraphicForCanvas(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Canvas arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.GraphicRegistry), "RegisterRaycastGraphicForCanvas", typeof(UnityEngine.Canvas), 0);
                    }
                    UnityEngine.UI.Graphic arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.GraphicRegistry), "RegisterRaycastGraphicForCanvas", typeof(UnityEngine.UI.Graphic), 1);
                    }
                    UnityEngine.UI.GraphicRegistry.RegisterRaycastGraphicForCanvas(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RegisterRaycastGraphicForCanvas", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_UnregisterGraphicForCanvas(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Canvas arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.GraphicRegistry), "UnregisterGraphicForCanvas", typeof(UnityEngine.Canvas), 0);
                    }
                    UnityEngine.UI.Graphic arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.GraphicRegistry), "UnregisterGraphicForCanvas", typeof(UnityEngine.UI.Graphic), 1);
                    }
                    UnityEngine.UI.GraphicRegistry.UnregisterGraphicForCanvas(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("UnregisterGraphicForCanvas", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_UnregisterRaycastGraphicForCanvas(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Canvas arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.GraphicRegistry), "UnregisterRaycastGraphicForCanvas", typeof(UnityEngine.Canvas), 0);
                    }
                    UnityEngine.UI.Graphic arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.GraphicRegistry), "UnregisterRaycastGraphicForCanvas", typeof(UnityEngine.UI.Graphic), 1);
                    }
                    UnityEngine.UI.GraphicRegistry.UnregisterRaycastGraphicForCanvas(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("UnregisterRaycastGraphicForCanvas", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DisableGraphicForCanvas(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Canvas arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.GraphicRegistry), "DisableGraphicForCanvas", typeof(UnityEngine.Canvas), 0);
                    }
                    UnityEngine.UI.Graphic arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.GraphicRegistry), "DisableGraphicForCanvas", typeof(UnityEngine.UI.Graphic), 1);
                    }
                    UnityEngine.UI.GraphicRegistry.DisableGraphicForCanvas(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DisableGraphicForCanvas", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DisableRaycastGraphicForCanvas(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Canvas arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.GraphicRegistry), "DisableRaycastGraphicForCanvas", typeof(UnityEngine.Canvas), 0);
                    }
                    UnityEngine.UI.Graphic arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.GraphicRegistry), "DisableRaycastGraphicForCanvas", typeof(UnityEngine.UI.Graphic), 1);
                    }
                    UnityEngine.UI.GraphicRegistry.DisableRaycastGraphicForCanvas(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DisableRaycastGraphicForCanvas", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetGraphicsForCanvas(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Canvas arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.GraphicRegistry), "GetGraphicsForCanvas", typeof(UnityEngine.Canvas), 0);
                    }
                    var ret = UnityEngine.UI.GraphicRegistry.GetGraphicsForCanvas(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetGraphicsForCanvas", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetRaycastableGraphicsForCanvas(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Canvas arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.GraphicRegistry), "GetRaycastableGraphicsForCanvas", typeof(UnityEngine.Canvas), 0);
                    }
                    var ret = UnityEngine.UI.GraphicRegistry.GetRaycastableGraphicsForCanvas(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetRaycastableGraphicsForCanvas", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_instance(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.UI.GraphicRegistry.instance;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("GraphicRegistry", typeof(UnityEngine.UI.GraphicRegistry), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "RegisterGraphicForCanvas", BindStatic_RegisterGraphicForCanvas);
            cls.AddMethod(true, "RegisterRaycastGraphicForCanvas", BindStatic_RegisterRaycastGraphicForCanvas);
            cls.AddMethod(true, "UnregisterGraphicForCanvas", BindStatic_UnregisterGraphicForCanvas);
            cls.AddMethod(true, "UnregisterRaycastGraphicForCanvas", BindStatic_UnregisterRaycastGraphicForCanvas);
            cls.AddMethod(true, "DisableGraphicForCanvas", BindStatic_DisableGraphicForCanvas);
            cls.AddMethod(true, "DisableRaycastGraphicForCanvas", BindStatic_DisableRaycastGraphicForCanvas);
            cls.AddMethod(true, "GetGraphicsForCanvas", BindStatic_GetGraphicsForCanvas);
            cls.AddMethod(true, "GetRaycastableGraphicsForCanvas", BindStatic_GetRaycastableGraphicsForCanvas);
            cls.AddProperty(true, "instance", BindStaticRead_instance, null);
            return cls;
        }
    }
}
#endif
