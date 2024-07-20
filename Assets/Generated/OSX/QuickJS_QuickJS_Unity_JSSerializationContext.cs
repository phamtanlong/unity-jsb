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
    // Assembly: jsb.core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Users/longpt/Documents/SkyMavis/unity-jsb-2021/Library/ScriptAssemblies/jsb.core.dll
    // Type: QuickJS.Unity.JSSerializationContext
    [JSBindingAttribute]
    public class QuickJS_QuickJS_Unity_JSSerializationContext
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_AddReferencedObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    QuickJS.Unity.JSSerializationContext self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(QuickJS.Unity.JSSerializationContext), "AddReferencedObject", typeof(UnityEngine.Object), 0);
                    }
                    var ret = self.AddReferencedObject(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("AddReferencedObject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetReferencedObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    QuickJS.Unity.JSSerializationContext self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(QuickJS.Unity.JSSerializationContext), "GetReferencedObject", typeof(int), 0);
                    }
                    var ret = self.GetReferencedObject(arg0);
                    return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetReferencedObject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Flush(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    QuickJS.Unity.JSSerializationContext self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    QuickJS.IO.ByteBuffer arg0;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(QuickJS.Unity.JSSerializationContext), "Flush", typeof(QuickJS.IO.ByteBuffer), 0);
                    }
                    self.Flush(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Flush", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_AllocByteBuffer(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 0)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(QuickJS.ScriptRuntime)))
                        {
                            QuickJS.Unity.JSSerializationContext self1;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self1))
                            {
                                throw new ThisBoundException();
                            }
                            QuickJS.ScriptRuntime arg0;
                            arg0 = ScriptEngine.GetRuntime(ctx);
                            var ret1 = self1.AllocByteBuffer(arg0);
                            return Values.js_push_classvalue(ctx, ret1);
                        }
                        QuickJS.Unity.JSSerializationContext self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        var ret = self.AllocByteBuffer();
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("AllocByteBuffer", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Release(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    QuickJS.Unity.JSSerializationContext self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.Release();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Release", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_dataFormat(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Unity.JSSerializationContext self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.dataFormat;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_dataFormat(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Unity.JSSerializationContext self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Unity.JSSerializationContext), "dataFormat", typeof(int), 0);
                }
                self.dataFormat = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("JSSerializationContext", typeof(QuickJS.Unity.JSSerializationContext), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(false, "AddReferencedObject", Bind_AddReferencedObject);
            cls.AddMethod(false, "GetReferencedObject", Bind_GetReferencedObject);
            cls.AddMethod(false, "Flush", Bind_Flush);
            cls.AddMethod(false, "AllocByteBuffer", Bind_AllocByteBuffer);
            cls.AddMethod(false, "Release", Bind_Release);
            cls.AddProperty(false, "dataFormat", BindRead_dataFormat, BindWrite_dataFormat);
            return cls;
        }
    }
}
#endif
