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
    // Type: UnityEditor.Media.MediaTime
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_Media_MediaTime
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        long arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Media.MediaTime), ".ctor", typeof(long), 0);
                        }
                        uint arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.Media.MediaTime), ".ctor", typeof(uint), 1);
                        }
                        uint arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.Media.MediaTime), ".ctor", typeof(uint), 2);
                        }
                        var o = new UnityEditor.Media.MediaTime(arg0, arg1, arg2);
                        var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                        return val;
                    }
                    if (argc == 1)
                    {
                        long arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Media.MediaTime), ".ctor", typeof(long), 0);
                        }
                        var o = new UnityEditor.Media.MediaTime(arg0);
                        var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                        return val;
                    }
                } while(false);
                throw new NoSuitableMethodException("constructor", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_op_Explicit(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.Media.MediaTime arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Media.MediaTime), "op_Explicit", typeof(UnityEditor.Media.MediaTime), 0);
                    }
                    var ret = (double)arg0;
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("op_Explicit", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_count(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.Media.MediaTime self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.count;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_count(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.Media.MediaTime self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                long value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.Media.MediaTime), "count", typeof(long), 0);
                }
                self.count = value;
                Values.js_rebind_this(ctx, this_obj, ref self);
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_rate(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.Media.MediaTime self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.rate;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_rate(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.Media.MediaTime self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEditor.Media.MediaRational value;
                if (!Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.Media.MediaTime), "rate", typeof(UnityEditor.Media.MediaRational), 0);
                }
                self.rate = value;
                Values.js_rebind_this(ctx, this_obj, ref self);
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_Invalid(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Media.MediaTime.Invalid;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("MediaTime", typeof(UnityEditor.Media.MediaTime), BindConstructor);
            cls.AddMethod(true, "op_Explicit", BindStatic_op_Explicit);
            cls.AddProperty(false, "count", BindRead_count, BindWrite_count);
            cls.AddProperty(false, "rate", BindRead_rate, BindWrite_rate);
            cls.AddField(true, "Invalid", BindStaticRead_Invalid, null);
            return cls;
        }
    }
}
#endif
#endif
