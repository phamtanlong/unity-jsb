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
    // Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2019.4.40f1/Unity.app/Contents/Managed/UnityEngine/UnityEngine.CoreModule.dll
    // Type: UnityEngine.Camera
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_Camera
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new UnityEngine.Camera();
                    var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                    return val;
                }
                throw new NoSuitableMethodException("constructor", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Reset(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.Reset();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Reset", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ResetTransparencySortSettings(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.ResetTransparencySortSettings();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ResetTransparencySortSettings", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ResetAspect(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.ResetAspect();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ResetAspect", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ResetCullingMatrix(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.ResetCullingMatrix();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ResetCullingMatrix", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetReplacementShader(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Shader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "SetReplacementShader", typeof(UnityEngine.Shader), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "SetReplacementShader", typeof(string), 1);
                    }
                    self.SetReplacementShader(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetReplacementShader", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ResetReplacementShader(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.ResetReplacementShader();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ResetReplacementShader", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetGateFittedFieldOfView(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.GetGateFittedFieldOfView();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetGateFittedFieldOfView", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetGateFittedLensShift(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.GetGateFittedLensShift();
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetGateFittedLensShift", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetTargetBuffers(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.RenderBuffer)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.RenderBuffer)))
                        {
                            UnityEngine.Camera self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEngine.RenderBuffer arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Camera), "SetTargetBuffers", typeof(UnityEngine.RenderBuffer), 0);
                            }
                            UnityEngine.RenderBuffer arg1;
                            if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Camera), "SetTargetBuffers", typeof(UnityEngine.RenderBuffer), 1);
                            }
                            self.SetTargetBuffers(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.RenderBuffer[])) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.RenderBuffer)))
                        {
                            UnityEngine.Camera self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEngine.RenderBuffer[] arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Camera), "SetTargetBuffers", typeof(UnityEngine.RenderBuffer[]), 0);
                            }
                            UnityEngine.RenderBuffer arg1;
                            if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Camera), "SetTargetBuffers", typeof(UnityEngine.RenderBuffer), 1);
                            }
                            self.SetTargetBuffers(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("SetTargetBuffers", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ResetWorldToCameraMatrix(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.ResetWorldToCameraMatrix();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ResetWorldToCameraMatrix", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ResetProjectionMatrix(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.ResetProjectionMatrix();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ResetProjectionMatrix", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_CalculateObliqueMatrix(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Vector4 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "CalculateObliqueMatrix", typeof(UnityEngine.Vector4), 0);
                    }
                    var ret = self.CalculateObliqueMatrix(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("CalculateObliqueMatrix", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_WorldToScreenPoint(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEngine.Camera self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Camera), "WorldToScreenPoint", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Camera.MonoOrStereoscopicEye arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Camera), "WorldToScreenPoint", typeof(UnityEngine.Camera.MonoOrStereoscopicEye), 1);
                        }
                        var ret = self.WorldToScreenPoint(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Camera self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Camera), "WorldToScreenPoint", typeof(UnityEngine.Vector3), 0);
                        }
                        var ret = self.WorldToScreenPoint(arg0);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("WorldToScreenPoint", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_WorldToViewportPoint(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEngine.Camera self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Camera), "WorldToViewportPoint", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Camera.MonoOrStereoscopicEye arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Camera), "WorldToViewportPoint", typeof(UnityEngine.Camera.MonoOrStereoscopicEye), 1);
                        }
                        var ret = self.WorldToViewportPoint(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Camera self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Camera), "WorldToViewportPoint", typeof(UnityEngine.Vector3), 0);
                        }
                        var ret = self.WorldToViewportPoint(arg0);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("WorldToViewportPoint", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ViewportToWorldPoint(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEngine.Camera self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Camera), "ViewportToWorldPoint", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Camera.MonoOrStereoscopicEye arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Camera), "ViewportToWorldPoint", typeof(UnityEngine.Camera.MonoOrStereoscopicEye), 1);
                        }
                        var ret = self.ViewportToWorldPoint(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Camera self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Camera), "ViewportToWorldPoint", typeof(UnityEngine.Vector3), 0);
                        }
                        var ret = self.ViewportToWorldPoint(arg0);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("ViewportToWorldPoint", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ScreenToWorldPoint(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEngine.Camera self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Camera), "ScreenToWorldPoint", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Camera.MonoOrStereoscopicEye arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Camera), "ScreenToWorldPoint", typeof(UnityEngine.Camera.MonoOrStereoscopicEye), 1);
                        }
                        var ret = self.ScreenToWorldPoint(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Camera self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Camera), "ScreenToWorldPoint", typeof(UnityEngine.Vector3), 0);
                        }
                        var ret = self.ScreenToWorldPoint(arg0);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("ScreenToWorldPoint", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ScreenToViewportPoint(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "ScreenToViewportPoint", typeof(UnityEngine.Vector3), 0);
                    }
                    var ret = self.ScreenToViewportPoint(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("ScreenToViewportPoint", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ViewportToScreenPoint(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "ViewportToScreenPoint", typeof(UnityEngine.Vector3), 0);
                    }
                    var ret = self.ViewportToScreenPoint(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("ViewportToScreenPoint", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ViewportPointToRay(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEngine.Camera self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Camera), "ViewportPointToRay", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Camera.MonoOrStereoscopicEye arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Camera), "ViewportPointToRay", typeof(UnityEngine.Camera.MonoOrStereoscopicEye), 1);
                        }
                        var ret = self.ViewportPointToRay(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Camera self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Camera), "ViewportPointToRay", typeof(UnityEngine.Vector3), 0);
                        }
                        var ret = self.ViewportPointToRay(arg0);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("ViewportPointToRay", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ScreenPointToRay(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEngine.Camera self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Camera), "ScreenPointToRay", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Camera.MonoOrStereoscopicEye arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Camera), "ScreenPointToRay", typeof(UnityEngine.Camera.MonoOrStereoscopicEye), 1);
                        }
                        var ret = self.ScreenPointToRay(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Camera self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Camera), "ScreenPointToRay", typeof(UnityEngine.Vector3), 0);
                        }
                        var ret = self.ScreenPointToRay(arg0);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("ScreenPointToRay", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_CalculateFrustumCorners(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 4)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "CalculateFrustumCorners", typeof(UnityEngine.Rect), 0);
                    }
                    float arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "CalculateFrustumCorners", typeof(float), 1);
                    }
                    UnityEngine.Camera.MonoOrStereoscopicEye arg2;
                    if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "CalculateFrustumCorners", typeof(UnityEngine.Camera.MonoOrStereoscopicEye), 2);
                    }
                    UnityEngine.Vector3[] arg3;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "CalculateFrustumCorners", typeof(UnityEngine.Vector3[]), 3);
                    }
                    self.CalculateFrustumCorners(arg0, arg1, arg2, arg3);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CalculateFrustumCorners", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetStereoNonJitteredProjectionMatrix(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Camera.StereoscopicEye arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "GetStereoNonJitteredProjectionMatrix", typeof(UnityEngine.Camera.StereoscopicEye), 0);
                    }
                    var ret = self.GetStereoNonJitteredProjectionMatrix(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetStereoNonJitteredProjectionMatrix", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetStereoViewMatrix(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Camera.StereoscopicEye arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "GetStereoViewMatrix", typeof(UnityEngine.Camera.StereoscopicEye), 0);
                    }
                    var ret = self.GetStereoViewMatrix(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetStereoViewMatrix", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_CopyStereoDeviceProjectionMatrixToNonJittered(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Camera.StereoscopicEye arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "CopyStereoDeviceProjectionMatrixToNonJittered", typeof(UnityEngine.Camera.StereoscopicEye), 0);
                    }
                    self.CopyStereoDeviceProjectionMatrixToNonJittered(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CopyStereoDeviceProjectionMatrixToNonJittered", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetStereoProjectionMatrix(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Camera.StereoscopicEye arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "GetStereoProjectionMatrix", typeof(UnityEngine.Camera.StereoscopicEye), 0);
                    }
                    var ret = self.GetStereoProjectionMatrix(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetStereoProjectionMatrix", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetStereoProjectionMatrix(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Camera.StereoscopicEye arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "SetStereoProjectionMatrix", typeof(UnityEngine.Camera.StereoscopicEye), 0);
                    }
                    UnityEngine.Matrix4x4 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "SetStereoProjectionMatrix", typeof(UnityEngine.Matrix4x4), 1);
                    }
                    self.SetStereoProjectionMatrix(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetStereoProjectionMatrix", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ResetStereoProjectionMatrices(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.ResetStereoProjectionMatrices();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ResetStereoProjectionMatrices", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetStereoViewMatrix(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Camera.StereoscopicEye arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "SetStereoViewMatrix", typeof(UnityEngine.Camera.StereoscopicEye), 0);
                    }
                    UnityEngine.Matrix4x4 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "SetStereoViewMatrix", typeof(UnityEngine.Matrix4x4), 1);
                    }
                    self.SetStereoViewMatrix(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetStereoViewMatrix", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ResetStereoViewMatrices(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.ResetStereoViewMatrices();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ResetStereoViewMatrices", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_RenderToCubemap(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        UnityEngine.Camera self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.RenderTexture arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Camera), "RenderToCubemap", typeof(UnityEngine.RenderTexture), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Camera), "RenderToCubemap", typeof(int), 1);
                        }
                        UnityEngine.Camera.MonoOrStereoscopicEye arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Camera), "RenderToCubemap", typeof(UnityEngine.Camera.MonoOrStereoscopicEye), 2);
                        }
                        var ret = self.RenderToCubemap(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Cubemap)) && Values.js_match_type(ctx, argv[1], typeof(int)))
                        {
                            UnityEngine.Camera self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEngine.Cubemap arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Camera), "RenderToCubemap", typeof(UnityEngine.Cubemap), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Camera), "RenderToCubemap", typeof(int), 1);
                            }
                            var ret = self.RenderToCubemap(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.RenderTexture)) && Values.js_match_type(ctx, argv[1], typeof(int)))
                        {
                            UnityEngine.Camera self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEngine.RenderTexture arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Camera), "RenderToCubemap", typeof(UnityEngine.RenderTexture), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Camera), "RenderToCubemap", typeof(int), 1);
                            }
                            var ret = self.RenderToCubemap(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Cubemap)))
                        {
                            UnityEngine.Camera self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEngine.Cubemap arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Camera), "RenderToCubemap", typeof(UnityEngine.Cubemap), 0);
                            }
                            var ret = self.RenderToCubemap(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.RenderTexture)))
                        {
                            UnityEngine.Camera self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEngine.RenderTexture arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Camera), "RenderToCubemap", typeof(UnityEngine.RenderTexture), 0);
                            }
                            var ret = self.RenderToCubemap(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("RenderToCubemap", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Render(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.Render();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Render", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_RenderWithShader(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Shader arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "RenderWithShader", typeof(UnityEngine.Shader), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "RenderWithShader", typeof(string), 1);
                    }
                    self.RenderWithShader(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RenderWithShader", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_RenderDontRestore(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.RenderDontRestore();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RenderDontRestore", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_CopyFrom(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Camera arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "CopyFrom", typeof(UnityEngine.Camera), 0);
                    }
                    self.CopyFrom(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CopyFrom", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_RemoveCommandBuffers(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Rendering.CameraEvent arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "RemoveCommandBuffers", typeof(UnityEngine.Rendering.CameraEvent), 0);
                    }
                    self.RemoveCommandBuffers(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RemoveCommandBuffers", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_RemoveAllCommandBuffers(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.RemoveAllCommandBuffers();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RemoveAllCommandBuffers", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_AddCommandBuffer(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Rendering.CameraEvent arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "AddCommandBuffer", typeof(UnityEngine.Rendering.CameraEvent), 0);
                    }
                    UnityEngine.Rendering.CommandBuffer arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "AddCommandBuffer", typeof(UnityEngine.Rendering.CommandBuffer), 1);
                    }
                    self.AddCommandBuffer(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("AddCommandBuffer", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_AddCommandBufferAsync(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Rendering.CameraEvent arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "AddCommandBufferAsync", typeof(UnityEngine.Rendering.CameraEvent), 0);
                    }
                    UnityEngine.Rendering.CommandBuffer arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "AddCommandBufferAsync", typeof(UnityEngine.Rendering.CommandBuffer), 1);
                    }
                    UnityEngine.Rendering.ComputeQueueType arg2;
                    if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "AddCommandBufferAsync", typeof(UnityEngine.Rendering.ComputeQueueType), 2);
                    }
                    self.AddCommandBufferAsync(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("AddCommandBufferAsync", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_RemoveCommandBuffer(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Rendering.CameraEvent arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "RemoveCommandBuffer", typeof(UnityEngine.Rendering.CameraEvent), 0);
                    }
                    UnityEngine.Rendering.CommandBuffer arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "RemoveCommandBuffer", typeof(UnityEngine.Rendering.CommandBuffer), 1);
                    }
                    self.RemoveCommandBuffer(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RemoveCommandBuffer", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetCommandBuffers(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Camera self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Rendering.CameraEvent arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "GetCommandBuffers", typeof(UnityEngine.Rendering.CameraEvent), 0);
                    }
                    var ret = self.GetCommandBuffers(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetCommandBuffers", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_TryGetCullingParameters(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEngine.Camera self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        bool arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Camera), "TryGetCullingParameters", typeof(bool), 0);
                        }
                        UnityEngine.Rendering.ScriptableCullingParameters arg1;
                        var ret = self.TryGetCullingParameters(arg0, out arg1);
                        var out0 = Values.js_push_structvalue(ctx, arg1);
                        if (JSApi.JS_IsException(out0))
                        {
                            return out0;
                        }
                        var context = ScriptEngine.GetContext(ctx);
                        JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Camera self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Rendering.ScriptableCullingParameters arg0;
                        var ret = self.TryGetCullingParameters(out arg0);
                        var out0 = Values.js_push_structvalue(ctx, arg0);
                        if (JSApi.JS_IsException(out0))
                        {
                            return out0;
                        }
                        var context = ScriptEngine.GetContext(ctx);
                        JSApi.JS_SetProperty(ctx, argv[0], context.GetAtom("value"), out0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("TryGetCullingParameters", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CalculateProjectionMatrixFromPhysicalProperties(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 7)
                {
                    UnityEngine.Matrix4x4 arg0;
                    float arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "CalculateProjectionMatrixFromPhysicalProperties", typeof(float), 1);
                    }
                    UnityEngine.Vector2 arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "CalculateProjectionMatrixFromPhysicalProperties", typeof(UnityEngine.Vector2), 2);
                    }
                    UnityEngine.Vector2 arg3;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "CalculateProjectionMatrixFromPhysicalProperties", typeof(UnityEngine.Vector2), 3);
                    }
                    float arg4;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "CalculateProjectionMatrixFromPhysicalProperties", typeof(float), 4);
                    }
                    float arg5;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "CalculateProjectionMatrixFromPhysicalProperties", typeof(float), 5);
                    }
                    UnityEngine.Camera.GateFitParameters arg6;
                    if (!Values.js_get_structvalue(ctx, argv[6], out arg6))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "CalculateProjectionMatrixFromPhysicalProperties", typeof(UnityEngine.Camera.GateFitParameters), 6);
                    }
                    UnityEngine.Camera.CalculateProjectionMatrixFromPhysicalProperties(out arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                    var out0 = QuickJS.Binding.Values.js_push_structvalue(ctx, arg0);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[0], context.GetAtom("value"), out0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CalculateProjectionMatrixFromPhysicalProperties", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_FocalLengthToFieldOfView(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    float arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "FocalLengthToFieldOfView", typeof(float), 0);
                    }
                    float arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "FocalLengthToFieldOfView", typeof(float), 1);
                    }
                    var ret = UnityEngine.Camera.FocalLengthToFieldOfView(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("FocalLengthToFieldOfView", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_FieldOfViewToFocalLength(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    float arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "FieldOfViewToFocalLength", typeof(float), 0);
                    }
                    float arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "FieldOfViewToFocalLength", typeof(float), 1);
                    }
                    var ret = UnityEngine.Camera.FieldOfViewToFocalLength(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("FieldOfViewToFocalLength", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_HorizontalToVerticalFieldOfView(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    float arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "HorizontalToVerticalFieldOfView", typeof(float), 0);
                    }
                    float arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "HorizontalToVerticalFieldOfView", typeof(float), 1);
                    }
                    var ret = UnityEngine.Camera.HorizontalToVerticalFieldOfView(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("HorizontalToVerticalFieldOfView", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_VerticalToHorizontalFieldOfView(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    float arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "VerticalToHorizontalFieldOfView", typeof(float), 0);
                    }
                    float arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "VerticalToHorizontalFieldOfView", typeof(float), 1);
                    }
                    var ret = UnityEngine.Camera.VerticalToHorizontalFieldOfView(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("VerticalToHorizontalFieldOfView", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetAllCameras(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Camera[] arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "GetAllCameras", typeof(UnityEngine.Camera[]), 0);
                    }
                    var ret = UnityEngine.Camera.GetAllCameras(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetAllCameras", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetupCurrent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Camera arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Camera), "SetupCurrent", typeof(UnityEngine.Camera), 0);
                    }
                    UnityEngine.Camera.SetupCurrent(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetupCurrent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_nearClipPlane(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.nearClipPlane;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_nearClipPlane(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "nearClipPlane", typeof(float), 0);
                }
                self.nearClipPlane = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_farClipPlane(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.farClipPlane;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_farClipPlane(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "farClipPlane", typeof(float), 0);
                }
                self.farClipPlane = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_fieldOfView(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.fieldOfView;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_fieldOfView(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "fieldOfView", typeof(float), 0);
                }
                self.fieldOfView = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_renderingPath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.renderingPath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_renderingPath(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.RenderingPath value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "renderingPath", typeof(UnityEngine.RenderingPath), 0);
                }
                self.renderingPath = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_actualRenderingPath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.actualRenderingPath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_allowHDR(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.allowHDR;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_allowHDR(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "allowHDR", typeof(bool), 0);
                }
                self.allowHDR = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_allowMSAA(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.allowMSAA;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_allowMSAA(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "allowMSAA", typeof(bool), 0);
                }
                self.allowMSAA = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_allowDynamicResolution(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.allowDynamicResolution;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_allowDynamicResolution(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "allowDynamicResolution", typeof(bool), 0);
                }
                self.allowDynamicResolution = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_forceIntoRenderTexture(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.forceIntoRenderTexture;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_forceIntoRenderTexture(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "forceIntoRenderTexture", typeof(bool), 0);
                }
                self.forceIntoRenderTexture = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_orthographicSize(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.orthographicSize;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_orthographicSize(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "orthographicSize", typeof(float), 0);
                }
                self.orthographicSize = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_orthographic(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.orthographic;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_orthographic(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "orthographic", typeof(bool), 0);
                }
                self.orthographic = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_opaqueSortMode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.opaqueSortMode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_opaqueSortMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Rendering.OpaqueSortMode value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "opaqueSortMode", typeof(UnityEngine.Rendering.OpaqueSortMode), 0);
                }
                self.opaqueSortMode = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_transparencySortMode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.transparencySortMode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_transparencySortMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.TransparencySortMode value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "transparencySortMode", typeof(UnityEngine.TransparencySortMode), 0);
                }
                self.transparencySortMode = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_transparencySortAxis(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.transparencySortAxis;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_transparencySortAxis(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Vector3 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "transparencySortAxis", typeof(UnityEngine.Vector3), 0);
                }
                self.transparencySortAxis = value;
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
                UnityEngine.Camera self;
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
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_depth(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "depth", typeof(float), 0);
                }
                self.depth = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_aspect(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.aspect;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_aspect(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "aspect", typeof(float), 0);
                }
                self.aspect = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_velocity(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.velocity;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_cullingMask(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.cullingMask;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_cullingMask(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "cullingMask", typeof(int), 0);
                }
                self.cullingMask = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_eventMask(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.eventMask;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_eventMask(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "eventMask", typeof(int), 0);
                }
                self.eventMask = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_layerCullSpherical(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.layerCullSpherical;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_layerCullSpherical(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "layerCullSpherical", typeof(bool), 0);
                }
                self.layerCullSpherical = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_cameraType(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.cameraType;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_cameraType(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.CameraType value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "cameraType", typeof(UnityEngine.CameraType), 0);
                }
                self.cameraType = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_overrideSceneCullingMask(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.overrideSceneCullingMask;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_overrideSceneCullingMask(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                ulong value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "overrideSceneCullingMask", typeof(ulong), 0);
                }
                self.overrideSceneCullingMask = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_layerCullDistances(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.layerCullDistances;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_layerCullDistances(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                float[] value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "layerCullDistances", typeof(float[]), 0);
                }
                self.layerCullDistances = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_useOcclusionCulling(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.useOcclusionCulling;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_useOcclusionCulling(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "useOcclusionCulling", typeof(bool), 0);
                }
                self.useOcclusionCulling = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_cullingMatrix(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.cullingMatrix;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_cullingMatrix(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Matrix4x4 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "cullingMatrix", typeof(UnityEngine.Matrix4x4), 0);
                }
                self.cullingMatrix = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_backgroundColor(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.backgroundColor;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_backgroundColor(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Color value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "backgroundColor", typeof(UnityEngine.Color), 0);
                }
                self.backgroundColor = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_clearFlags(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.clearFlags;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_clearFlags(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.CameraClearFlags value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "clearFlags", typeof(UnityEngine.CameraClearFlags), 0);
                }
                self.clearFlags = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_depthTextureMode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.depthTextureMode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_depthTextureMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.DepthTextureMode value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "depthTextureMode", typeof(UnityEngine.DepthTextureMode), 0);
                }
                self.depthTextureMode = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_clearStencilAfterLightingPass(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.clearStencilAfterLightingPass;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_clearStencilAfterLightingPass(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "clearStencilAfterLightingPass", typeof(bool), 0);
                }
                self.clearStencilAfterLightingPass = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_usePhysicalProperties(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.usePhysicalProperties;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_usePhysicalProperties(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "usePhysicalProperties", typeof(bool), 0);
                }
                self.usePhysicalProperties = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_sensorSize(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.sensorSize;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_sensorSize(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Vector2 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "sensorSize", typeof(UnityEngine.Vector2), 0);
                }
                self.sensorSize = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_lensShift(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.lensShift;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_lensShift(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Vector2 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "lensShift", typeof(UnityEngine.Vector2), 0);
                }
                self.lensShift = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_focalLength(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.focalLength;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_focalLength(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "focalLength", typeof(float), 0);
                }
                self.focalLength = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_gateFit(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.gateFit;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_gateFit(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Camera.GateFitMode value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "gateFit", typeof(UnityEngine.Camera.GateFitMode), 0);
                }
                self.gateFit = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_rect(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.rect;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_rect(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Rect value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "rect", typeof(UnityEngine.Rect), 0);
                }
                self.rect = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_pixelRect(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.pixelRect;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_pixelRect(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Rect value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "pixelRect", typeof(UnityEngine.Rect), 0);
                }
                self.pixelRect = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_pixelWidth(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.pixelWidth;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_pixelHeight(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.pixelHeight;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_scaledPixelWidth(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.scaledPixelWidth;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_scaledPixelHeight(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.scaledPixelHeight;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_targetTexture(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.targetTexture;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_targetTexture(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.RenderTexture value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "targetTexture", typeof(UnityEngine.RenderTexture), 0);
                }
                self.targetTexture = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_activeTexture(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.activeTexture;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_targetDisplay(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.targetDisplay;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_targetDisplay(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "targetDisplay", typeof(int), 0);
                }
                self.targetDisplay = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_cameraToWorldMatrix(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.cameraToWorldMatrix;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_worldToCameraMatrix(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.worldToCameraMatrix;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_worldToCameraMatrix(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Matrix4x4 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "worldToCameraMatrix", typeof(UnityEngine.Matrix4x4), 0);
                }
                self.worldToCameraMatrix = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_projectionMatrix(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.projectionMatrix;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_projectionMatrix(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Matrix4x4 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "projectionMatrix", typeof(UnityEngine.Matrix4x4), 0);
                }
                self.projectionMatrix = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_nonJitteredProjectionMatrix(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.nonJitteredProjectionMatrix;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_nonJitteredProjectionMatrix(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Matrix4x4 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "nonJitteredProjectionMatrix", typeof(UnityEngine.Matrix4x4), 0);
                }
                self.nonJitteredProjectionMatrix = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_useJitteredProjectionMatrixForTransparentRendering(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.useJitteredProjectionMatrixForTransparentRendering;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_useJitteredProjectionMatrixForTransparentRendering(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "useJitteredProjectionMatrixForTransparentRendering", typeof(bool), 0);
                }
                self.useJitteredProjectionMatrixForTransparentRendering = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_previousViewProjectionMatrix(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.previousViewProjectionMatrix;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_main(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Camera.main;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_current(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Camera.current;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_scene(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.scene;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_scene(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.SceneManagement.Scene value;
                if (!Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "scene", typeof(UnityEngine.SceneManagement.Scene), 0);
                }
                self.scene = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_stereoEnabled(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.stereoEnabled;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_stereoSeparation(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.stereoSeparation;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_stereoSeparation(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "stereoSeparation", typeof(float), 0);
                }
                self.stereoSeparation = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_stereoConvergence(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.stereoConvergence;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_stereoConvergence(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "stereoConvergence", typeof(float), 0);
                }
                self.stereoConvergence = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_areVRStereoViewMatricesWithinSingleCullTolerance(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.areVRStereoViewMatricesWithinSingleCullTolerance;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_stereoTargetEye(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.stereoTargetEye;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_stereoTargetEye(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.StereoTargetEyeMask value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Camera), "stereoTargetEye", typeof(UnityEngine.StereoTargetEyeMask), 0);
                }
                self.stereoTargetEye = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_stereoActiveEye(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.stereoActiveEye;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_allCamerasCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Camera.allCamerasCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_allCameras(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Camera.allCameras;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_commandBufferCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Camera self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.commandBufferCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticDelegate_onPreCull(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                    {
                        UnityEngine.Camera.CameraCallback value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEngine.Camera), "onPreCull", typeof(UnityEngine.Camera.CameraCallback), 1);
                        }
                        UnityEngine.Camera.onPreCull += value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_REMOVE:
                    {
                        UnityEngine.Camera.CameraCallback value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEngine.Camera), "onPreCull", typeof(UnityEngine.Camera.CameraCallback), 1);
                        }
                        UnityEngine.Camera.onPreCull -= value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_SET:
                    {
                        UnityEngine.Camera.CameraCallback value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEngine.Camera), "onPreCull", typeof(UnityEngine.Camera.CameraCallback), 1);
                        }
                        UnityEngine.Camera.onPreCull = value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_GET:
                    {
                        var ret = UnityEngine.Camera.onPreCull;
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
        public static JSValue BindStaticDelegate_onPreRender(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                    {
                        UnityEngine.Camera.CameraCallback value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEngine.Camera), "onPreRender", typeof(UnityEngine.Camera.CameraCallback), 1);
                        }
                        UnityEngine.Camera.onPreRender += value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_REMOVE:
                    {
                        UnityEngine.Camera.CameraCallback value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEngine.Camera), "onPreRender", typeof(UnityEngine.Camera.CameraCallback), 1);
                        }
                        UnityEngine.Camera.onPreRender -= value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_SET:
                    {
                        UnityEngine.Camera.CameraCallback value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEngine.Camera), "onPreRender", typeof(UnityEngine.Camera.CameraCallback), 1);
                        }
                        UnityEngine.Camera.onPreRender = value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_GET:
                    {
                        var ret = UnityEngine.Camera.onPreRender;
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
        public static JSValue BindStaticDelegate_onPostRender(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                    {
                        UnityEngine.Camera.CameraCallback value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEngine.Camera), "onPostRender", typeof(UnityEngine.Camera.CameraCallback), 1);
                        }
                        UnityEngine.Camera.onPostRender += value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_REMOVE:
                    {
                        UnityEngine.Camera.CameraCallback value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEngine.Camera), "onPostRender", typeof(UnityEngine.Camera.CameraCallback), 1);
                        }
                        UnityEngine.Camera.onPostRender -= value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_SET:
                    {
                        UnityEngine.Camera.CameraCallback value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEngine.Camera), "onPostRender", typeof(UnityEngine.Camera.CameraCallback), 1);
                        }
                        UnityEngine.Camera.onPostRender = value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_GET:
                    {
                        var ret = UnityEngine.Camera.onPostRender;
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
            var cls = register.CreateClass("Camera", typeof(UnityEngine.Camera), BindConstructor);
            cls.AddMethod(false, "Reset", Bind_Reset);
            cls.AddMethod(false, "ResetTransparencySortSettings", Bind_ResetTransparencySortSettings);
            cls.AddMethod(false, "ResetAspect", Bind_ResetAspect);
            cls.AddMethod(false, "ResetCullingMatrix", Bind_ResetCullingMatrix);
            cls.AddMethod(false, "SetReplacementShader", Bind_SetReplacementShader);
            cls.AddMethod(false, "ResetReplacementShader", Bind_ResetReplacementShader);
            cls.AddMethod(false, "GetGateFittedFieldOfView", Bind_GetGateFittedFieldOfView);
            cls.AddMethod(false, "GetGateFittedLensShift", Bind_GetGateFittedLensShift);
            cls.AddMethod(false, "SetTargetBuffers", Bind_SetTargetBuffers);
            cls.AddMethod(false, "ResetWorldToCameraMatrix", Bind_ResetWorldToCameraMatrix);
            cls.AddMethod(false, "ResetProjectionMatrix", Bind_ResetProjectionMatrix);
            cls.AddMethod(false, "CalculateObliqueMatrix", Bind_CalculateObliqueMatrix);
            cls.AddMethod(false, "WorldToScreenPoint", Bind_WorldToScreenPoint);
            cls.AddMethod(false, "WorldToViewportPoint", Bind_WorldToViewportPoint);
            cls.AddMethod(false, "ViewportToWorldPoint", Bind_ViewportToWorldPoint);
            cls.AddMethod(false, "ScreenToWorldPoint", Bind_ScreenToWorldPoint);
            cls.AddMethod(false, "ScreenToViewportPoint", Bind_ScreenToViewportPoint);
            cls.AddMethod(false, "ViewportToScreenPoint", Bind_ViewportToScreenPoint);
            cls.AddMethod(false, "ViewportPointToRay", Bind_ViewportPointToRay);
            cls.AddMethod(false, "ScreenPointToRay", Bind_ScreenPointToRay);
            cls.AddMethod(false, "CalculateFrustumCorners", Bind_CalculateFrustumCorners);
            cls.AddMethod(false, "GetStereoNonJitteredProjectionMatrix", Bind_GetStereoNonJitteredProjectionMatrix);
            cls.AddMethod(false, "GetStereoViewMatrix", Bind_GetStereoViewMatrix);
            cls.AddMethod(false, "CopyStereoDeviceProjectionMatrixToNonJittered", Bind_CopyStereoDeviceProjectionMatrixToNonJittered);
            cls.AddMethod(false, "GetStereoProjectionMatrix", Bind_GetStereoProjectionMatrix);
            cls.AddMethod(false, "SetStereoProjectionMatrix", Bind_SetStereoProjectionMatrix);
            cls.AddMethod(false, "ResetStereoProjectionMatrices", Bind_ResetStereoProjectionMatrices);
            cls.AddMethod(false, "SetStereoViewMatrix", Bind_SetStereoViewMatrix);
            cls.AddMethod(false, "ResetStereoViewMatrices", Bind_ResetStereoViewMatrices);
            cls.AddMethod(false, "RenderToCubemap", Bind_RenderToCubemap);
            cls.AddMethod(false, "Render", Bind_Render);
            cls.AddMethod(false, "RenderWithShader", Bind_RenderWithShader);
            cls.AddMethod(false, "RenderDontRestore", Bind_RenderDontRestore);
            cls.AddMethod(false, "CopyFrom", Bind_CopyFrom);
            cls.AddMethod(false, "RemoveCommandBuffers", Bind_RemoveCommandBuffers);
            cls.AddMethod(false, "RemoveAllCommandBuffers", Bind_RemoveAllCommandBuffers);
            cls.AddMethod(false, "AddCommandBuffer", Bind_AddCommandBuffer);
            cls.AddMethod(false, "AddCommandBufferAsync", Bind_AddCommandBufferAsync);
            cls.AddMethod(false, "RemoveCommandBuffer", Bind_RemoveCommandBuffer);
            cls.AddMethod(false, "GetCommandBuffers", Bind_GetCommandBuffers);
            cls.AddMethod(false, "TryGetCullingParameters", Bind_TryGetCullingParameters);
            cls.AddMethod(true, "CalculateProjectionMatrixFromPhysicalProperties", BindStatic_CalculateProjectionMatrixFromPhysicalProperties);
            cls.AddMethod(true, "FocalLengthToFieldOfView", BindStatic_FocalLengthToFieldOfView);
            cls.AddMethod(true, "FieldOfViewToFocalLength", BindStatic_FieldOfViewToFocalLength);
            cls.AddMethod(true, "HorizontalToVerticalFieldOfView", BindStatic_HorizontalToVerticalFieldOfView);
            cls.AddMethod(true, "VerticalToHorizontalFieldOfView", BindStatic_VerticalToHorizontalFieldOfView);
            cls.AddMethod(true, "GetAllCameras", BindStatic_GetAllCameras);
            cls.AddMethod(true, "SetupCurrent", BindStatic_SetupCurrent);
            cls.AddProperty(false, "nearClipPlane", BindRead_nearClipPlane, BindWrite_nearClipPlane);
            cls.AddProperty(false, "farClipPlane", BindRead_farClipPlane, BindWrite_farClipPlane);
            cls.AddProperty(false, "fieldOfView", BindRead_fieldOfView, BindWrite_fieldOfView);
            cls.AddProperty(false, "renderingPath", BindRead_renderingPath, BindWrite_renderingPath);
            cls.AddProperty(false, "actualRenderingPath", BindRead_actualRenderingPath, null);
            cls.AddProperty(false, "allowHDR", BindRead_allowHDR, BindWrite_allowHDR);
            cls.AddProperty(false, "allowMSAA", BindRead_allowMSAA, BindWrite_allowMSAA);
            cls.AddProperty(false, "allowDynamicResolution", BindRead_allowDynamicResolution, BindWrite_allowDynamicResolution);
            cls.AddProperty(false, "forceIntoRenderTexture", BindRead_forceIntoRenderTexture, BindWrite_forceIntoRenderTexture);
            cls.AddProperty(false, "orthographicSize", BindRead_orthographicSize, BindWrite_orthographicSize);
            cls.AddProperty(false, "orthographic", BindRead_orthographic, BindWrite_orthographic);
            cls.AddProperty(false, "opaqueSortMode", BindRead_opaqueSortMode, BindWrite_opaqueSortMode);
            cls.AddProperty(false, "transparencySortMode", BindRead_transparencySortMode, BindWrite_transparencySortMode);
            cls.AddProperty(false, "transparencySortAxis", BindRead_transparencySortAxis, BindWrite_transparencySortAxis);
            cls.AddProperty(false, "depth", BindRead_depth, BindWrite_depth);
            cls.AddProperty(false, "aspect", BindRead_aspect, BindWrite_aspect);
            cls.AddProperty(false, "velocity", BindRead_velocity, null);
            cls.AddProperty(false, "cullingMask", BindRead_cullingMask, BindWrite_cullingMask);
            cls.AddProperty(false, "eventMask", BindRead_eventMask, BindWrite_eventMask);
            cls.AddProperty(false, "layerCullSpherical", BindRead_layerCullSpherical, BindWrite_layerCullSpherical);
            cls.AddProperty(false, "cameraType", BindRead_cameraType, BindWrite_cameraType);
            cls.AddProperty(false, "overrideSceneCullingMask", BindRead_overrideSceneCullingMask, BindWrite_overrideSceneCullingMask);
            cls.AddProperty(false, "layerCullDistances", BindRead_layerCullDistances, BindWrite_layerCullDistances);
            cls.AddProperty(false, "useOcclusionCulling", BindRead_useOcclusionCulling, BindWrite_useOcclusionCulling);
            cls.AddProperty(false, "cullingMatrix", BindRead_cullingMatrix, BindWrite_cullingMatrix);
            cls.AddProperty(false, "backgroundColor", BindRead_backgroundColor, BindWrite_backgroundColor);
            cls.AddProperty(false, "clearFlags", BindRead_clearFlags, BindWrite_clearFlags);
            cls.AddProperty(false, "depthTextureMode", BindRead_depthTextureMode, BindWrite_depthTextureMode);
            cls.AddProperty(false, "clearStencilAfterLightingPass", BindRead_clearStencilAfterLightingPass, BindWrite_clearStencilAfterLightingPass);
            cls.AddProperty(false, "usePhysicalProperties", BindRead_usePhysicalProperties, BindWrite_usePhysicalProperties);
            cls.AddProperty(false, "sensorSize", BindRead_sensorSize, BindWrite_sensorSize);
            cls.AddProperty(false, "lensShift", BindRead_lensShift, BindWrite_lensShift);
            cls.AddProperty(false, "focalLength", BindRead_focalLength, BindWrite_focalLength);
            cls.AddProperty(false, "gateFit", BindRead_gateFit, BindWrite_gateFit);
            cls.AddProperty(false, "rect", BindRead_rect, BindWrite_rect);
            cls.AddProperty(false, "pixelRect", BindRead_pixelRect, BindWrite_pixelRect);
            cls.AddProperty(false, "pixelWidth", BindRead_pixelWidth, null);
            cls.AddProperty(false, "pixelHeight", BindRead_pixelHeight, null);
            cls.AddProperty(false, "scaledPixelWidth", BindRead_scaledPixelWidth, null);
            cls.AddProperty(false, "scaledPixelHeight", BindRead_scaledPixelHeight, null);
            cls.AddProperty(false, "targetTexture", BindRead_targetTexture, BindWrite_targetTexture);
            cls.AddProperty(false, "activeTexture", BindRead_activeTexture, null);
            cls.AddProperty(false, "targetDisplay", BindRead_targetDisplay, BindWrite_targetDisplay);
            cls.AddProperty(false, "cameraToWorldMatrix", BindRead_cameraToWorldMatrix, null);
            cls.AddProperty(false, "worldToCameraMatrix", BindRead_worldToCameraMatrix, BindWrite_worldToCameraMatrix);
            cls.AddProperty(false, "projectionMatrix", BindRead_projectionMatrix, BindWrite_projectionMatrix);
            cls.AddProperty(false, "nonJitteredProjectionMatrix", BindRead_nonJitteredProjectionMatrix, BindWrite_nonJitteredProjectionMatrix);
            cls.AddProperty(false, "useJitteredProjectionMatrixForTransparentRendering", BindRead_useJitteredProjectionMatrixForTransparentRendering, BindWrite_useJitteredProjectionMatrixForTransparentRendering);
            cls.AddProperty(false, "previousViewProjectionMatrix", BindRead_previousViewProjectionMatrix, null);
            cls.AddProperty(true, "main", BindStaticRead_main, null);
            cls.AddProperty(true, "current", BindStaticRead_current, null);
            cls.AddProperty(false, "scene", BindRead_scene, BindWrite_scene);
            cls.AddProperty(false, "stereoEnabled", BindRead_stereoEnabled, null);
            cls.AddProperty(false, "stereoSeparation", BindRead_stereoSeparation, BindWrite_stereoSeparation);
            cls.AddProperty(false, "stereoConvergence", BindRead_stereoConvergence, BindWrite_stereoConvergence);
            cls.AddProperty(false, "areVRStereoViewMatricesWithinSingleCullTolerance", BindRead_areVRStereoViewMatricesWithinSingleCullTolerance, null);
            cls.AddProperty(false, "stereoTargetEye", BindRead_stereoTargetEye, BindWrite_stereoTargetEye);
            cls.AddProperty(false, "stereoActiveEye", BindRead_stereoActiveEye, null);
            cls.AddProperty(true, "allCamerasCount", BindStaticRead_allCamerasCount, null);
            cls.AddProperty(true, "allCameras", BindStaticRead_allCameras, null);
            cls.AddProperty(false, "commandBufferCount", BindRead_commandBufferCount, null);
            cls.AddMethod(true, "onPreCull", BindStaticDelegate_onPreCull);
            cls.AddMethod(true, "onPreRender", BindStaticDelegate_onPreRender);
            cls.AddMethod(true, "onPostRender", BindStaticDelegate_onPostRender);
            return cls;
        }
    }
}
#endif
