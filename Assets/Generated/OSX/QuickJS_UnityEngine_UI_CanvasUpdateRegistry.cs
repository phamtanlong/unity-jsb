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
    // Type: UnityEngine.UI.CanvasUpdateRegistry
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_UI_CanvasUpdateRegistry
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RegisterCanvasElementForLayoutRebuild(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.UI.ICanvasElement arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.CanvasUpdateRegistry), "RegisterCanvasElementForLayoutRebuild", typeof(UnityEngine.UI.ICanvasElement), 0);
                    }
                    UnityEngine.UI.CanvasUpdateRegistry.RegisterCanvasElementForLayoutRebuild(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RegisterCanvasElementForLayoutRebuild", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_TryRegisterCanvasElementForLayoutRebuild(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.UI.ICanvasElement arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.CanvasUpdateRegistry), "TryRegisterCanvasElementForLayoutRebuild", typeof(UnityEngine.UI.ICanvasElement), 0);
                    }
                    var ret = UnityEngine.UI.CanvasUpdateRegistry.TryRegisterCanvasElementForLayoutRebuild(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("TryRegisterCanvasElementForLayoutRebuild", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RegisterCanvasElementForGraphicRebuild(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.UI.ICanvasElement arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.CanvasUpdateRegistry), "RegisterCanvasElementForGraphicRebuild", typeof(UnityEngine.UI.ICanvasElement), 0);
                    }
                    UnityEngine.UI.CanvasUpdateRegistry.RegisterCanvasElementForGraphicRebuild(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RegisterCanvasElementForGraphicRebuild", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_TryRegisterCanvasElementForGraphicRebuild(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.UI.ICanvasElement arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.CanvasUpdateRegistry), "TryRegisterCanvasElementForGraphicRebuild", typeof(UnityEngine.UI.ICanvasElement), 0);
                    }
                    var ret = UnityEngine.UI.CanvasUpdateRegistry.TryRegisterCanvasElementForGraphicRebuild(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("TryRegisterCanvasElementForGraphicRebuild", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_UnRegisterCanvasElementForRebuild(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.UI.ICanvasElement arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.CanvasUpdateRegistry), "UnRegisterCanvasElementForRebuild", typeof(UnityEngine.UI.ICanvasElement), 0);
                    }
                    UnityEngine.UI.CanvasUpdateRegistry.UnRegisterCanvasElementForRebuild(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("UnRegisterCanvasElementForRebuild", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsRebuildingLayout(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEngine.UI.CanvasUpdateRegistry.IsRebuildingLayout();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsRebuildingLayout", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsRebuildingGraphics(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEngine.UI.CanvasUpdateRegistry.IsRebuildingGraphics();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsRebuildingGraphics", argc);
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
                var ret = UnityEngine.UI.CanvasUpdateRegistry.instance;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("CanvasUpdateRegistry", typeof(UnityEngine.UI.CanvasUpdateRegistry), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "RegisterCanvasElementForLayoutRebuild", BindStatic_RegisterCanvasElementForLayoutRebuild);
            cls.AddMethod(true, "TryRegisterCanvasElementForLayoutRebuild", BindStatic_TryRegisterCanvasElementForLayoutRebuild);
            cls.AddMethod(true, "RegisterCanvasElementForGraphicRebuild", BindStatic_RegisterCanvasElementForGraphicRebuild);
            cls.AddMethod(true, "TryRegisterCanvasElementForGraphicRebuild", BindStatic_TryRegisterCanvasElementForGraphicRebuild);
            cls.AddMethod(true, "UnRegisterCanvasElementForRebuild", BindStatic_UnRegisterCanvasElementForRebuild);
            cls.AddMethod(true, "IsRebuildingLayout", BindStatic_IsRebuildingLayout);
            cls.AddMethod(true, "IsRebuildingGraphics", BindStatic_IsRebuildingGraphics);
            cls.AddProperty(true, "instance", BindStaticRead_instance, null);
            return cls;
        }
    }
}
#endif
