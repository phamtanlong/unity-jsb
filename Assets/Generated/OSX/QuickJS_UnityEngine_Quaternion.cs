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
    // Type: UnityEngine.Quaternion
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_Quaternion
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 4)
                {
                    float arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), ".ctor", typeof(float), 0);
                    }
                    float arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), ".ctor", typeof(float), 1);
                    }
                    float arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), ".ctor", typeof(float), 2);
                    }
                    float arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), ".ctor", typeof(float), 3);
                    }
                    var o = new UnityEngine.Quaternion(arg0, arg1, arg2, arg3);
                    var val = QuickJS.Binding.Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
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
        public static JSValue Bind_get_Item(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Quaternion self;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "get_Item", typeof(int), 0);
                    }
                    var ret = self[arg0];
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("$GetValue", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_set_Item(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Quaternion self;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "set_Item", typeof(int), 0);
                    }
                    float arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "set_Item", typeof(float), 1);
                    }
                    self[arg0] = arg1;
                    QuickJS.Binding.Values.js_rebind_this(ctx, this_obj, ref self);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("$SetValue", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Set(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 4)
                {
                    UnityEngine.Quaternion self;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    float arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "Set", typeof(float), 0);
                    }
                    float arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "Set", typeof(float), 1);
                    }
                    float arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "Set", typeof(float), 2);
                    }
                    float arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "Set", typeof(float), 3);
                    }
                    self.Set(arg0, arg1, arg2, arg3);
                    QuickJS.Binding.Values.js_rebind_this(ctx, this_obj, ref self);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Set", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetLookRotation(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEngine.Quaternion self;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Quaternion), "SetLookRotation", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Quaternion), "SetLookRotation", typeof(UnityEngine.Vector3), 1);
                        }
                        self.SetLookRotation(arg0, arg1);
                        QuickJS.Binding.Values.js_rebind_this(ctx, this_obj, ref self);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Quaternion self;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Quaternion), "SetLookRotation", typeof(UnityEngine.Vector3), 0);
                        }
                        self.SetLookRotation(arg0);
                        QuickJS.Binding.Values.js_rebind_this(ctx, this_obj, ref self);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("SetLookRotation", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ToAngleAxis(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Quaternion self;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    float arg0;
                    UnityEngine.Vector3 arg1;
                    self.ToAngleAxis(out arg0, out arg1);
                    var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg0);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[0], context.GetAtom("value"), out0);
                    var out1 = QuickJS.Binding.Values.js_push_structvalue(ctx, arg1);
                    if (JSApi.JS_IsException(out1))
                    {
                        return out1;
                    }
                    JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out1);
                    QuickJS.Binding.Values.js_rebind_this(ctx, this_obj, ref self);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ToAngleAxis", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetFromToRotation(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Quaternion self;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "SetFromToRotation", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "SetFromToRotation", typeof(UnityEngine.Vector3), 1);
                    }
                    self.SetFromToRotation(arg0, arg1);
                    QuickJS.Binding.Values.js_rebind_this(ctx, this_obj, ref self);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetFromToRotation", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Normalize(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Quaternion self;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.Normalize();
                    QuickJS.Binding.Values.js_rebind_this(ctx, this_obj, ref self);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Normalize", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetHashCode(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Quaternion self;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.GetHashCode();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetHashCode", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Equals(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(object)))
                        {
                            UnityEngine.Quaternion self;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            object arg0;
                            if (!Values.js_get_var(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Quaternion), "Equals", typeof(object), 0);
                            }
                            var ret = self.Equals(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Quaternion)))
                        {
                            UnityEngine.Quaternion self;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEngine.Quaternion arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Quaternion), "Equals", typeof(UnityEngine.Quaternion), 0);
                            }
                            var ret = self.Equals(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Equals", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ToString(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        UnityEngine.Quaternion self;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Quaternion), "ToString", typeof(string), 0);
                        }
                        var ret = self.ToString(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 0)
                    {
                        UnityEngine.Quaternion self;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        var ret = self.ToString();
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("toString", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_FromToRotation(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Vector3 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "FromToRotation", typeof(UnityEngine.Vector3), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "FromToRotation", typeof(UnityEngine.Vector3), 1);
                    }
                    var ret = UnityEngine.Quaternion.FromToRotation(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("FromToRotation", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Inverse(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Quaternion arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "Inverse", typeof(UnityEngine.Quaternion), 0);
                    }
                    var ret = UnityEngine.Quaternion.Inverse(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("Inverse", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Slerp(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Quaternion arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "Slerp", typeof(UnityEngine.Quaternion), 0);
                    }
                    UnityEngine.Quaternion arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "Slerp", typeof(UnityEngine.Quaternion), 1);
                    }
                    float arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "Slerp", typeof(float), 2);
                    }
                    var ret = UnityEngine.Quaternion.Slerp(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("Slerp", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SlerpUnclamped(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Quaternion arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "SlerpUnclamped", typeof(UnityEngine.Quaternion), 0);
                    }
                    UnityEngine.Quaternion arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "SlerpUnclamped", typeof(UnityEngine.Quaternion), 1);
                    }
                    float arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "SlerpUnclamped", typeof(float), 2);
                    }
                    var ret = UnityEngine.Quaternion.SlerpUnclamped(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("SlerpUnclamped", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Lerp(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Quaternion arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "Lerp", typeof(UnityEngine.Quaternion), 0);
                    }
                    UnityEngine.Quaternion arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "Lerp", typeof(UnityEngine.Quaternion), 1);
                    }
                    float arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "Lerp", typeof(float), 2);
                    }
                    var ret = UnityEngine.Quaternion.Lerp(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("Lerp", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LerpUnclamped(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Quaternion arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "LerpUnclamped", typeof(UnityEngine.Quaternion), 0);
                    }
                    UnityEngine.Quaternion arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "LerpUnclamped", typeof(UnityEngine.Quaternion), 1);
                    }
                    float arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "LerpUnclamped", typeof(float), 2);
                    }
                    var ret = UnityEngine.Quaternion.LerpUnclamped(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("LerpUnclamped", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_AngleAxis(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    float arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "AngleAxis", typeof(float), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "AngleAxis", typeof(UnityEngine.Vector3), 1);
                    }
                    var ret = UnityEngine.Quaternion.AngleAxis(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("AngleAxis", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LookRotation(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Quaternion), "LookRotation", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Quaternion), "LookRotation", typeof(UnityEngine.Vector3), 1);
                        }
                        var ret = UnityEngine.Quaternion.LookRotation(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Quaternion), "LookRotation", typeof(UnityEngine.Vector3), 0);
                        }
                        var ret = UnityEngine.Quaternion.LookRotation(arg0);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("LookRotation", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_op_Multiply(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Quaternion)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Quaternion)))
                        {
                            UnityEngine.Quaternion arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Quaternion), "op_Multiply", typeof(UnityEngine.Quaternion), 0);
                            }
                            UnityEngine.Quaternion arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Quaternion), "op_Multiply", typeof(UnityEngine.Quaternion), 1);
                            }
                            var ret = arg0 * arg1;
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Quaternion)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)))
                        {
                            UnityEngine.Quaternion arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Quaternion), "op_Multiply", typeof(UnityEngine.Quaternion), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.Quaternion), "op_Multiply", typeof(UnityEngine.Vector3), 1);
                            }
                            var ret = arg0 * arg1;
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("op_Multiply", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_op_Equality(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Quaternion arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "op_Equality", typeof(UnityEngine.Quaternion), 0);
                    }
                    UnityEngine.Quaternion arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "op_Equality", typeof(UnityEngine.Quaternion), 1);
                    }
                    var ret = arg0 == arg1;
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("op_Equality", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_op_Inequality(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Quaternion arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "op_Inequality", typeof(UnityEngine.Quaternion), 0);
                    }
                    UnityEngine.Quaternion arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "op_Inequality", typeof(UnityEngine.Quaternion), 1);
                    }
                    var ret = arg0 != arg1;
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("op_Inequality", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Dot(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Quaternion arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "Dot", typeof(UnityEngine.Quaternion), 0);
                    }
                    UnityEngine.Quaternion arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "Dot", typeof(UnityEngine.Quaternion), 1);
                    }
                    var ret = UnityEngine.Quaternion.Dot(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("Dot", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Angle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Quaternion arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "Angle", typeof(UnityEngine.Quaternion), 0);
                    }
                    UnityEngine.Quaternion arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "Angle", typeof(UnityEngine.Quaternion), 1);
                    }
                    var ret = UnityEngine.Quaternion.Angle(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("Angle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Euler(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        float arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Quaternion), "Euler", typeof(float), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Quaternion), "Euler", typeof(float), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Quaternion), "Euler", typeof(float), 2);
                        }
                        var ret = UnityEngine.Quaternion.Euler(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Quaternion), "Euler", typeof(UnityEngine.Vector3), 0);
                        }
                        var ret = UnityEngine.Quaternion.Euler(arg0);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("Euler", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RotateTowards(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Quaternion arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "RotateTowards", typeof(UnityEngine.Quaternion), 0);
                    }
                    UnityEngine.Quaternion arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "RotateTowards", typeof(UnityEngine.Quaternion), 1);
                    }
                    float arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "RotateTowards", typeof(float), 2);
                    }
                    var ret = UnityEngine.Quaternion.RotateTowards(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("RotateTowards", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Normalize(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Quaternion arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "Normalize", typeof(UnityEngine.Quaternion), 0);
                    }
                    var ret = UnityEngine.Quaternion.Normalize(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("Normalize", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_op_Multiply_QuickJS_UnityEngine_Quaternion_QuickJS_UnityEngine_Quaternion_qjs_m(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Quaternion arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "op_Multiply", typeof(UnityEngine.Quaternion), 0);
                    }
                    UnityEngine.Quaternion arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "op_Multiply", typeof(UnityEngine.Quaternion), 1);
                    }
                    var ret = arg0 * arg1;
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("*", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_op_Multiply_QuickJS_UnityEngine_Quaternion_QuickJS_UnityEngine_Vector3_qjs_m(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Quaternion arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "op_Multiply", typeof(UnityEngine.Quaternion), 0);
                    }
                    UnityEngine.Vector3 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "op_Multiply", typeof(UnityEngine.Vector3), 1);
                    }
                    var ret = arg0 * arg1;
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("*", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_op_Equality_qjs(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Quaternion arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "op_Equality", typeof(UnityEngine.Quaternion), 0);
                    }
                    UnityEngine.Quaternion arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Quaternion), "op_Equality", typeof(UnityEngine.Quaternion), 1);
                    }
                    var ret = arg0 == arg1;
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("==", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_identity(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.Quaternion.identity;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_eulerAngles(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Quaternion self;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.eulerAngles;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_eulerAngles(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Quaternion self;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Vector3 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Quaternion), "eulerAngles", typeof(UnityEngine.Vector3), 0);
                }
                self.eulerAngles = value;
                QuickJS.Binding.Values.js_rebind_this(ctx, this_obj, ref self);
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_normalized(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Quaternion self;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.normalized;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_x(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Quaternion self;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.x;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_x(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Quaternion self;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Quaternion), "x", typeof(float), 0);
                }
                self.x = value;
                QuickJS.Binding.Values.js_rebind_this(ctx, this_obj, ref self);
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_y(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Quaternion self;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.y;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_y(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Quaternion self;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Quaternion), "y", typeof(float), 0);
                }
                self.y = value;
                QuickJS.Binding.Values.js_rebind_this(ctx, this_obj, ref self);
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_z(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Quaternion self;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.z;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_z(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Quaternion self;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Quaternion), "z", typeof(float), 0);
                }
                self.z = value;
                QuickJS.Binding.Values.js_rebind_this(ctx, this_obj, ref self);
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_w(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Quaternion self;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.w;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_w(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Quaternion self;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.Quaternion), "w", typeof(float), 0);
                }
                self.w = value;
                QuickJS.Binding.Values.js_rebind_this(ctx, this_obj, ref self);
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("Quaternion", typeof(UnityEngine.Quaternion), BindConstructor);
            cls.AddSelfOperator("*", BindStatic_op_Multiply_QuickJS_UnityEngine_Quaternion_QuickJS_UnityEngine_Quaternion_qjs_m, 2);
            cls.AddRightOperator("*", BindStatic_op_Multiply_QuickJS_UnityEngine_Quaternion_QuickJS_UnityEngine_Vector3_qjs_m, 2, typeof(UnityEngine.Vector3));
            cls.AddSelfOperator("==", BindStatic_op_Equality_qjs, 2);
            cls.AddMethod(false, "$GetValue", Bind_get_Item);
            cls.AddMethod(false, "$SetValue", Bind_set_Item);
            cls.AddMethod(false, "Set", Bind_Set);
            cls.AddMethod(false, "SetLookRotation", Bind_SetLookRotation);
            cls.AddMethod(false, "ToAngleAxis", Bind_ToAngleAxis);
            cls.AddMethod(false, "SetFromToRotation", Bind_SetFromToRotation);
            cls.AddMethod(false, "Normalize", Bind_Normalize);
            cls.AddMethod(false, "GetHashCode", Bind_GetHashCode);
            cls.AddMethod(false, "Equals", Bind_Equals);
            cls.AddMethod(false, "toString", Bind_ToString);
            cls.AddMethod(true, "FromToRotation", BindStatic_FromToRotation);
            cls.AddMethod(true, "Inverse", BindStatic_Inverse);
            cls.AddMethod(true, "Slerp", BindStatic_Slerp);
            cls.AddMethod(true, "SlerpUnclamped", BindStatic_SlerpUnclamped);
            cls.AddMethod(true, "Lerp", BindStatic_Lerp);
            cls.AddMethod(true, "LerpUnclamped", BindStatic_LerpUnclamped);
            cls.AddMethod(true, "AngleAxis", BindStatic_AngleAxis);
            cls.AddMethod(true, "LookRotation", BindStatic_LookRotation);
            cls.AddMethod(true, "op_Multiply", BindStatic_op_Multiply);
            cls.AddMethod(true, "op_Equality", BindStatic_op_Equality);
            cls.AddMethod(true, "op_Inequality", BindStatic_op_Inequality);
            cls.AddMethod(true, "Dot", BindStatic_Dot);
            cls.AddMethod(true, "Angle", BindStatic_Angle);
            cls.AddMethod(true, "Euler", BindStatic_Euler);
            cls.AddMethod(true, "RotateTowards", BindStatic_RotateTowards);
            cls.AddMethod(true, "Normalize", BindStatic_Normalize);
            cls.AddProperty(true, "identity", BindStaticRead_identity, null);
            cls.AddProperty(false, "eulerAngles", BindRead_eulerAngles, BindWrite_eulerAngles);
            cls.AddProperty(false, "normalized", BindRead_normalized, null);
            cls.AddField(false, "x", BindRead_x, BindWrite_x);
            cls.AddField(false, "y", BindRead_y, BindWrite_y);
            cls.AddField(false, "z", BindRead_z, BindWrite_z);
            cls.AddField(false, "w", BindRead_w, BindWrite_w);
            cls.AddConstValue("kEpsilon", 1E-06);
            return cls;
        }
    }
}
#endif
