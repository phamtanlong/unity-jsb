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
    // Type: UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_IMGUI_Controls_PrimitiveBoundsHandle
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetColor(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Color arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle), "SetColor", typeof(UnityEngine.Color), 0);
                    }
                    self.SetColor(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetColor", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawHandle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawHandle();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawHandle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DefaultMidpointHandleSizeFunction(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle), "DefaultMidpointHandleSizeFunction", typeof(UnityEngine.Vector3), 0);
                    }
                    var ret = UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle.DefaultMidpointHandleSizeFunction(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("DefaultMidpointHandleSizeFunction", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_center(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.center;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_center(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Vector3 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle), "center", typeof(UnityEngine.Vector3), 0);
                }
                self.center = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_axes(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.axes;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_axes(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle.Axes value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle), "axes", typeof(UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle.Axes), 0);
                }
                self.axes = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_handleColor(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.handleColor;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_handleColor(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Color value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle), "handleColor", typeof(UnityEngine.Color), 0);
                }
                self.handleColor = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_wireframeColor(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.wireframeColor;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_wireframeColor(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Color value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle), "wireframeColor", typeof(UnityEngine.Color), 0);
                }
                self.wireframeColor = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindDelegate_midpointHandleDrawFunction(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                    {
                        UnityEditor.Handles.CapFunction value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle), "midpointHandleDrawFunction", typeof(UnityEditor.Handles.CapFunction), 1);
                        }
                        self.midpointHandleDrawFunction += value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_REMOVE:
                    {
                        UnityEditor.Handles.CapFunction value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle), "midpointHandleDrawFunction", typeof(UnityEditor.Handles.CapFunction), 1);
                        }
                        self.midpointHandleDrawFunction -= value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_SET:
                    {
                        UnityEditor.Handles.CapFunction value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle), "midpointHandleDrawFunction", typeof(UnityEditor.Handles.CapFunction), 1);
                        }
                        self.midpointHandleDrawFunction = value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_GET:
                    {
                        var ret = self.midpointHandleDrawFunction;
                        return Values.js_push_delegate(ctx, ret);
                    }
                    default: throw new JSException("invalid event op");
                }
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindDelegate_midpointHandleSizeFunction(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                    {
                        UnityEditor.Handles.SizeFunction value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle), "midpointHandleSizeFunction", typeof(UnityEditor.Handles.SizeFunction), 1);
                        }
                        self.midpointHandleSizeFunction += value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_REMOVE:
                    {
                        UnityEditor.Handles.SizeFunction value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle), "midpointHandleSizeFunction", typeof(UnityEditor.Handles.SizeFunction), 1);
                        }
                        self.midpointHandleSizeFunction -= value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_SET:
                    {
                        UnityEditor.Handles.SizeFunction value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle), "midpointHandleSizeFunction", typeof(UnityEditor.Handles.SizeFunction), 1);
                        }
                        self.midpointHandleSizeFunction = value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_GET:
                    {
                        var ret = self.midpointHandleSizeFunction;
                        return Values.js_push_delegate(ctx, ret);
                    }
                    default: throw new JSException("invalid event op");
                }
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("PrimitiveBoundsHandle", typeof(UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(false, "SetColor", Bind_SetColor);
            cls.AddMethod(false, "DrawHandle", Bind_DrawHandle);
            cls.AddMethod(true, "DefaultMidpointHandleSizeFunction", BindStatic_DefaultMidpointHandleSizeFunction);
            cls.AddProperty(false, "center", BindRead_center, BindWrite_center);
            cls.AddProperty(false, "axes", BindRead_axes, BindWrite_axes);
            cls.AddProperty(false, "handleColor", BindRead_handleColor, BindWrite_handleColor);
            cls.AddProperty(false, "wireframeColor", BindRead_wireframeColor, BindWrite_wireframeColor);
            cls.AddMethod(false, "midpointHandleDrawFunction", BindDelegate_midpointHandleDrawFunction);
            cls.AddMethod(false, "midpointHandleSizeFunction", BindDelegate_midpointHandleSizeFunction);
            return cls;
        }
    }
}
#endif
#endif
