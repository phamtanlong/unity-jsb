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
    // Assembly: UnityEngine.InputLegacyModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2019.4.40f1/Unity.app/Contents/Managed/UnityEngine/UnityEngine.InputLegacyModule.dll
    // Type: UnityEngine.Input
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_Input
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new UnityEngine.Input();
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
        public static JSValue BindStatic_GetAxis(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Input), "GetAxis", typeof(string), 0);
                    }
                    var ret = UnityEngine.Input.GetAxis(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetAxis", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetAxisRaw(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Input), "GetAxisRaw", typeof(string), 0);
                    }
                    var ret = UnityEngine.Input.GetAxisRaw(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetAxisRaw", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetButton(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Input), "GetButton", typeof(string), 0);
                    }
                    var ret = UnityEngine.Input.GetButton(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetButton", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetButtonDown(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Input), "GetButtonDown", typeof(string), 0);
                    }
                    var ret = UnityEngine.Input.GetButtonDown(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetButtonDown", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetButtonUp(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Input), "GetButtonUp", typeof(string), 0);
                    }
                    var ret = UnityEngine.Input.GetButtonUp(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetButtonUp", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetMouseButton(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Input), "GetMouseButton", typeof(int), 0);
                    }
                    var ret = UnityEngine.Input.GetMouseButton(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetMouseButton", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetMouseButtonDown(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Input), "GetMouseButtonDown", typeof(int), 0);
                    }
                    var ret = UnityEngine.Input.GetMouseButtonDown(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetMouseButtonDown", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetMouseButtonUp(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Input), "GetMouseButtonUp", typeof(int), 0);
                    }
                    var ret = UnityEngine.Input.GetMouseButtonUp(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetMouseButtonUp", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ResetInputAxes(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Input.ResetInputAxes();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ResetInputAxes", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetJoystickNames(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEngine.Input.GetJoystickNames();
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetJoystickNames", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetTouch(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Input), "GetTouch", typeof(int), 0);
                    }
                    var ret = UnityEngine.Input.GetTouch(arg0);
                    return Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetTouch", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetAccelerationEvent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Input), "GetAccelerationEvent", typeof(int), 0);
                    }
                    var ret = UnityEngine.Input.GetAccelerationEvent(arg0);
                    return Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetAccelerationEvent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetKey(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.KeyCode)))
                        {
                            UnityEngine.KeyCode arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Input), "GetKey", typeof(UnityEngine.KeyCode), 0);
                            }
                            var ret = UnityEngine.Input.GetKey(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Input), "GetKey", typeof(string), 0);
                            }
                            var ret = UnityEngine.Input.GetKey(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("GetKey", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetKeyUp(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.KeyCode)))
                        {
                            UnityEngine.KeyCode arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Input), "GetKeyUp", typeof(UnityEngine.KeyCode), 0);
                            }
                            var ret = UnityEngine.Input.GetKeyUp(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Input), "GetKeyUp", typeof(string), 0);
                            }
                            var ret = UnityEngine.Input.GetKeyUp(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("GetKeyUp", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetKeyDown(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.KeyCode)))
                        {
                            UnityEngine.KeyCode arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Input), "GetKeyDown", typeof(UnityEngine.KeyCode), 0);
                            }
                            var ret = UnityEngine.Input.GetKeyDown(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Input), "GetKeyDown", typeof(string), 0);
                            }
                            var ret = UnityEngine.Input.GetKeyDown(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("GetKeyDown", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_simulateMouseWithTouches(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Input.simulateMouseWithTouches;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_simulateMouseWithTouches(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Input), "simulateMouseWithTouches", typeof(bool), 0);
                }
                UnityEngine.Input.simulateMouseWithTouches = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_anyKey(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Input.anyKey;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_anyKeyDown(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Input.anyKeyDown;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_inputString(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Input.inputString;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_mousePosition(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Input.mousePosition;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_mouseScrollDelta(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Input.mouseScrollDelta;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_imeCompositionMode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Input.imeCompositionMode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_imeCompositionMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.IMECompositionMode value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Input), "imeCompositionMode", typeof(UnityEngine.IMECompositionMode), 0);
                }
                UnityEngine.Input.imeCompositionMode = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_compositionString(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Input.compositionString;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_imeIsSelected(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Input.imeIsSelected;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_compositionCursorPos(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Input.compositionCursorPos;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_compositionCursorPos(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Vector2 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Input), "compositionCursorPos", typeof(UnityEngine.Vector2), 0);
                }
                UnityEngine.Input.compositionCursorPos = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_mousePresent(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Input.mousePresent;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_touchCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Input.touchCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_touchPressureSupported(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Input.touchPressureSupported;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_stylusTouchSupported(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Input.stylusTouchSupported;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_touchSupported(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Input.touchSupported;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_multiTouchEnabled(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Input.multiTouchEnabled;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_multiTouchEnabled(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Input), "multiTouchEnabled", typeof(bool), 0);
                }
                UnityEngine.Input.multiTouchEnabled = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_deviceOrientation(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Input.deviceOrientation;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_acceleration(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Input.acceleration;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_compensateSensors(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Input.compensateSensors;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_compensateSensors(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Input), "compensateSensors", typeof(bool), 0);
                }
                UnityEngine.Input.compensateSensors = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_accelerationEventCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Input.accelerationEventCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_backButtonLeavesApp(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Input.backButtonLeavesApp;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_backButtonLeavesApp(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Input), "backButtonLeavesApp", typeof(bool), 0);
                }
                UnityEngine.Input.backButtonLeavesApp = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_location(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Input.location;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_compass(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Input.compass;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_gyro(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Input.gyro;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_touches(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Input.touches;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_accelerationEvents(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Input.accelerationEvents;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("Input", typeof(UnityEngine.Input), BindConstructor);
            cls.AddMethod(true, "GetAxis", BindStatic_GetAxis);
            cls.AddMethod(true, "GetAxisRaw", BindStatic_GetAxisRaw);
            cls.AddMethod(true, "GetButton", BindStatic_GetButton);
            cls.AddMethod(true, "GetButtonDown", BindStatic_GetButtonDown);
            cls.AddMethod(true, "GetButtonUp", BindStatic_GetButtonUp);
            cls.AddMethod(true, "GetMouseButton", BindStatic_GetMouseButton);
            cls.AddMethod(true, "GetMouseButtonDown", BindStatic_GetMouseButtonDown);
            cls.AddMethod(true, "GetMouseButtonUp", BindStatic_GetMouseButtonUp);
            cls.AddMethod(true, "ResetInputAxes", BindStatic_ResetInputAxes);
            cls.AddMethod(true, "GetJoystickNames", BindStatic_GetJoystickNames);
            cls.AddMethod(true, "GetTouch", BindStatic_GetTouch);
            cls.AddMethod(true, "GetAccelerationEvent", BindStatic_GetAccelerationEvent);
            cls.AddMethod(true, "GetKey", BindStatic_GetKey);
            cls.AddMethod(true, "GetKeyUp", BindStatic_GetKeyUp);
            cls.AddMethod(true, "GetKeyDown", BindStatic_GetKeyDown);
            cls.AddProperty(true, "simulateMouseWithTouches", BindStaticRead_simulateMouseWithTouches, BindStaticWrite_simulateMouseWithTouches);
            cls.AddProperty(true, "anyKey", BindStaticRead_anyKey, null);
            cls.AddProperty(true, "anyKeyDown", BindStaticRead_anyKeyDown, null);
            cls.AddProperty(true, "inputString", BindStaticRead_inputString, null);
            cls.AddProperty(true, "mousePosition", BindStaticRead_mousePosition, null);
            cls.AddProperty(true, "mouseScrollDelta", BindStaticRead_mouseScrollDelta, null);
            cls.AddProperty(true, "imeCompositionMode", BindStaticRead_imeCompositionMode, BindStaticWrite_imeCompositionMode);
            cls.AddProperty(true, "compositionString", BindStaticRead_compositionString, null);
            cls.AddProperty(true, "imeIsSelected", BindStaticRead_imeIsSelected, null);
            cls.AddProperty(true, "compositionCursorPos", BindStaticRead_compositionCursorPos, BindStaticWrite_compositionCursorPos);
            cls.AddProperty(true, "mousePresent", BindStaticRead_mousePresent, null);
            cls.AddProperty(true, "touchCount", BindStaticRead_touchCount, null);
            cls.AddProperty(true, "touchPressureSupported", BindStaticRead_touchPressureSupported, null);
            cls.AddProperty(true, "stylusTouchSupported", BindStaticRead_stylusTouchSupported, null);
            cls.AddProperty(true, "touchSupported", BindStaticRead_touchSupported, null);
            cls.AddProperty(true, "multiTouchEnabled", BindStaticRead_multiTouchEnabled, BindStaticWrite_multiTouchEnabled);
            cls.AddProperty(true, "deviceOrientation", BindStaticRead_deviceOrientation, null);
            cls.AddProperty(true, "acceleration", BindStaticRead_acceleration, null);
            cls.AddProperty(true, "compensateSensors", BindStaticRead_compensateSensors, BindStaticWrite_compensateSensors);
            cls.AddProperty(true, "accelerationEventCount", BindStaticRead_accelerationEventCount, null);
            cls.AddProperty(true, "backButtonLeavesApp", BindStaticRead_backButtonLeavesApp, BindStaticWrite_backButtonLeavesApp);
            cls.AddProperty(true, "location", BindStaticRead_location, null);
            cls.AddProperty(true, "compass", BindStaticRead_compass, null);
            cls.AddProperty(true, "gyro", BindStaticRead_gyro, null);
            cls.AddProperty(true, "touches", BindStaticRead_touches, null);
            cls.AddProperty(true, "accelerationEvents", BindStaticRead_accelerationEvents, null);
            return cls;
        }
    }
}
#endif
