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
    // Type: UnityEngine.UI.Graphic
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_UI_Graphic
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetAllDirty(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.UI.Graphic self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.SetAllDirty();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetAllDirty", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetLayoutDirty(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.UI.Graphic self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.SetLayoutDirty();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetLayoutDirty", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetVerticesDirty(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.UI.Graphic self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.SetVerticesDirty();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetVerticesDirty", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetMaterialDirty(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.UI.Graphic self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.SetMaterialDirty();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetMaterialDirty", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_OnCullingChanged(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.UI.Graphic self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.OnCullingChanged();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("OnCullingChanged", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Rebuild(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.UI.Graphic self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.UI.CanvasUpdate arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.Graphic), "Rebuild", typeof(UnityEngine.UI.CanvasUpdate), 0);
                    }
                    self.Rebuild(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Rebuild", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_LayoutComplete(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.UI.Graphic self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.LayoutComplete();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("LayoutComplete", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GraphicUpdateComplete(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.UI.Graphic self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.GraphicUpdateComplete();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("GraphicUpdateComplete", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetNativeSize(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.UI.Graphic self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.SetNativeSize();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetNativeSize", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Raycast(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.UI.Graphic self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Vector2 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.Graphic), "Raycast", typeof(UnityEngine.Vector2), 0);
                    }
                    UnityEngine.Camera arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.Graphic), "Raycast", typeof(UnityEngine.Camera), 1);
                    }
                    var ret = self.Raycast(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("Raycast", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_PixelAdjustPoint(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.UI.Graphic self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Vector2 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.Graphic), "PixelAdjustPoint", typeof(UnityEngine.Vector2), 0);
                    }
                    var ret = self.PixelAdjustPoint(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("PixelAdjustPoint", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetPixelAdjustedRect(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.UI.Graphic self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.GetPixelAdjustedRect();
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetPixelAdjustedRect", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_CrossFadeColor(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        UnityEngine.UI.Graphic self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Color arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.Graphic), "CrossFadeColor", typeof(UnityEngine.Color), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.Graphic), "CrossFadeColor", typeof(float), 1);
                        }
                        bool arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.Graphic), "CrossFadeColor", typeof(bool), 2);
                        }
                        bool arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.Graphic), "CrossFadeColor", typeof(bool), 3);
                        }
                        bool arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.Graphic), "CrossFadeColor", typeof(bool), 4);
                        }
                        self.CrossFadeColor(arg0, arg1, arg2, arg3, arg4);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 4)
                    {
                        UnityEngine.UI.Graphic self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Color arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.Graphic), "CrossFadeColor", typeof(UnityEngine.Color), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.Graphic), "CrossFadeColor", typeof(float), 1);
                        }
                        bool arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.Graphic), "CrossFadeColor", typeof(bool), 2);
                        }
                        bool arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.Graphic), "CrossFadeColor", typeof(bool), 3);
                        }
                        self.CrossFadeColor(arg0, arg1, arg2, arg3);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("CrossFadeColor", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_CrossFadeAlpha(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.UI.Graphic self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    float arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.Graphic), "CrossFadeAlpha", typeof(float), 0);
                    }
                    float arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.Graphic), "CrossFadeAlpha", typeof(float), 1);
                    }
                    bool arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.Graphic), "CrossFadeAlpha", typeof(bool), 2);
                    }
                    self.CrossFadeAlpha(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CrossFadeAlpha", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_RegisterDirtyLayoutCallback(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.UI.Graphic self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Events.UnityAction arg0;
                    if (!Values.js_get_delegate(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.Graphic), "RegisterDirtyLayoutCallback", typeof(UnityEngine.Events.UnityAction), 0);
                    }
                    self.RegisterDirtyLayoutCallback(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RegisterDirtyLayoutCallback", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_UnregisterDirtyLayoutCallback(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.UI.Graphic self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Events.UnityAction arg0;
                    if (!Values.js_get_delegate(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.Graphic), "UnregisterDirtyLayoutCallback", typeof(UnityEngine.Events.UnityAction), 0);
                    }
                    self.UnregisterDirtyLayoutCallback(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("UnregisterDirtyLayoutCallback", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_RegisterDirtyVerticesCallback(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.UI.Graphic self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Events.UnityAction arg0;
                    if (!Values.js_get_delegate(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.Graphic), "RegisterDirtyVerticesCallback", typeof(UnityEngine.Events.UnityAction), 0);
                    }
                    self.RegisterDirtyVerticesCallback(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RegisterDirtyVerticesCallback", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_UnregisterDirtyVerticesCallback(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.UI.Graphic self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Events.UnityAction arg0;
                    if (!Values.js_get_delegate(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.Graphic), "UnregisterDirtyVerticesCallback", typeof(UnityEngine.Events.UnityAction), 0);
                    }
                    self.UnregisterDirtyVerticesCallback(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("UnregisterDirtyVerticesCallback", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_RegisterDirtyMaterialCallback(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.UI.Graphic self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Events.UnityAction arg0;
                    if (!Values.js_get_delegate(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.Graphic), "RegisterDirtyMaterialCallback", typeof(UnityEngine.Events.UnityAction), 0);
                    }
                    self.RegisterDirtyMaterialCallback(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RegisterDirtyMaterialCallback", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_UnregisterDirtyMaterialCallback(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.UI.Graphic self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Events.UnityAction arg0;
                    if (!Values.js_get_delegate(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.Graphic), "UnregisterDirtyMaterialCallback", typeof(UnityEngine.Events.UnityAction), 0);
                    }
                    self.UnregisterDirtyMaterialCallback(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("UnregisterDirtyMaterialCallback", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_defaultGraphicMaterial(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.UI.Graphic.defaultGraphicMaterial;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_color(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.Graphic self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.color;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_color(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.UI.Graphic self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Color value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.UI.Graphic), "color", typeof(UnityEngine.Color), 0);
                }
                self.color = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_raycastTarget(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.Graphic self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.raycastTarget;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_raycastTarget(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.UI.Graphic self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.UI.Graphic), "raycastTarget", typeof(bool), 0);
                }
                self.raycastTarget = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_depth(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.Graphic self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.depth;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_rectTransform(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.Graphic self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.rectTransform;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_canvas(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.Graphic self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.canvas;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_canvasRenderer(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.Graphic self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.canvasRenderer;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_defaultMaterial(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.Graphic self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.defaultMaterial;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_material(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.Graphic self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.material;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_material(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.UI.Graphic self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Material value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.UI.Graphic), "material", typeof(UnityEngine.Material), 0);
                }
                self.material = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_materialForRendering(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.Graphic self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.materialForRendering;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_mainTexture(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.Graphic self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.mainTexture;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("Graphic", typeof(UnityEngine.UI.Graphic), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(false, "SetAllDirty", Bind_SetAllDirty);
            cls.AddMethod(false, "SetLayoutDirty", Bind_SetLayoutDirty);
            cls.AddMethod(false, "SetVerticesDirty", Bind_SetVerticesDirty);
            cls.AddMethod(false, "SetMaterialDirty", Bind_SetMaterialDirty);
            cls.AddMethod(false, "OnCullingChanged", Bind_OnCullingChanged);
            cls.AddMethod(false, "Rebuild", Bind_Rebuild);
            cls.AddMethod(false, "LayoutComplete", Bind_LayoutComplete);
            cls.AddMethod(false, "GraphicUpdateComplete", Bind_GraphicUpdateComplete);
            cls.AddMethod(false, "SetNativeSize", Bind_SetNativeSize);
            cls.AddMethod(false, "Raycast", Bind_Raycast);
            cls.AddMethod(false, "PixelAdjustPoint", Bind_PixelAdjustPoint);
            cls.AddMethod(false, "GetPixelAdjustedRect", Bind_GetPixelAdjustedRect);
            cls.AddMethod(false, "CrossFadeColor", Bind_CrossFadeColor);
            cls.AddMethod(false, "CrossFadeAlpha", Bind_CrossFadeAlpha);
            cls.AddMethod(false, "RegisterDirtyLayoutCallback", Bind_RegisterDirtyLayoutCallback);
            cls.AddMethod(false, "UnregisterDirtyLayoutCallback", Bind_UnregisterDirtyLayoutCallback);
            cls.AddMethod(false, "RegisterDirtyVerticesCallback", Bind_RegisterDirtyVerticesCallback);
            cls.AddMethod(false, "UnregisterDirtyVerticesCallback", Bind_UnregisterDirtyVerticesCallback);
            cls.AddMethod(false, "RegisterDirtyMaterialCallback", Bind_RegisterDirtyMaterialCallback);
            cls.AddMethod(false, "UnregisterDirtyMaterialCallback", Bind_UnregisterDirtyMaterialCallback);
            cls.AddProperty(true, "defaultGraphicMaterial", BindStaticRead_defaultGraphicMaterial, null);
            cls.AddProperty(false, "color", BindRead_color, BindWrite_color);
            cls.AddProperty(false, "raycastTarget", BindRead_raycastTarget, BindWrite_raycastTarget);
            cls.AddProperty(false, "depth", BindRead_depth, null);
            cls.AddProperty(false, "rectTransform", BindRead_rectTransform, null);
            cls.AddProperty(false, "canvas", BindRead_canvas, null);
            cls.AddProperty(false, "canvasRenderer", BindRead_canvasRenderer, null);
            cls.AddProperty(false, "defaultMaterial", BindRead_defaultMaterial, null);
            cls.AddProperty(false, "material", BindRead_material, BindWrite_material);
            cls.AddProperty(false, "materialForRendering", BindRead_materialForRendering, null);
            cls.AddProperty(false, "mainTexture", BindRead_mainTexture, null);
            return cls;
        }
    }
}
#endif
