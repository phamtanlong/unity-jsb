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
    // Type: UnityEngine.UI.GraphicRaycaster
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_UI_GraphicRaycaster
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Raycast(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.UI.GraphicRaycaster self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.EventSystems.PointerEventData arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.GraphicRaycaster), "Raycast", typeof(UnityEngine.EventSystems.PointerEventData), 0);
                    }
                    System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.GraphicRaycaster), "Raycast", typeof(System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>), 1);
                    }
                    self.Raycast(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Raycast", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_sortOrderPriority(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.GraphicRaycaster self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.sortOrderPriority;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_renderOrderPriority(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.GraphicRaycaster self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.renderOrderPriority;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_ignoreReversedGraphics(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.GraphicRaycaster self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.ignoreReversedGraphics;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_ignoreReversedGraphics(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.UI.GraphicRaycaster self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.UI.GraphicRaycaster), "ignoreReversedGraphics", typeof(bool), 0);
                }
                self.ignoreReversedGraphics = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_blockingObjects(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.GraphicRaycaster self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.blockingObjects;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_blockingObjects(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.UI.GraphicRaycaster self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.UI.GraphicRaycaster.BlockingObjects value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.UI.GraphicRaycaster), "blockingObjects", typeof(UnityEngine.UI.GraphicRaycaster.BlockingObjects), 0);
                }
                self.blockingObjects = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_eventCamera(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.GraphicRaycaster self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.eventCamera;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("GraphicRaycaster", typeof(UnityEngine.UI.GraphicRaycaster), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(false, "Raycast", Bind_Raycast);
            cls.AddProperty(false, "sortOrderPriority", BindRead_sortOrderPriority, null);
            cls.AddProperty(false, "renderOrderPriority", BindRead_renderOrderPriority, null);
            cls.AddProperty(false, "ignoreReversedGraphics", BindRead_ignoreReversedGraphics, BindWrite_ignoreReversedGraphics);
            cls.AddProperty(false, "blockingObjects", BindRead_blockingObjects, BindWrite_blockingObjects);
            cls.AddProperty(false, "eventCamera", BindRead_eventCamera, null);
            return cls;
        }
    }
}
#endif
