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
    // Type: QuickJS.IO.ByteBuffer
    [JSBindingAttribute]
    public class QuickJS_QuickJS_IO_ByteBuffer
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
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), ".ctor", typeof(int), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), ".ctor", typeof(int), 1);
                        }
                        QuickJS.IO.IByteBufferAllocator arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), ".ctor", typeof(QuickJS.IO.IByteBufferAllocator), 2);
                        }
                        var o = new QuickJS.IO.ByteBuffer(arg0, arg1, arg2);
                        var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                        return val;
                    }
                    if (argc == 2)
                    {
                        byte[] arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), ".ctor", typeof(byte[]), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), ".ctor", typeof(int), 1);
                        }
                        var o = new QuickJS.IO.ByteBuffer(arg0, arg1);
                        var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                        return val;
                    }
                    if (argc == 1)
                    {
                        byte[] arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), ".ctor", typeof(byte[]), 0);
                        }
                        var o = new QuickJS.IO.ByteBuffer(arg0);
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
        public static JSValue Bind_ToString(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    QuickJS.IO.ByteBuffer self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.ToString();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("toString", argc);
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
                    QuickJS.IO.ByteBuffer self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
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
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Retain(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    QuickJS.IO.ByteBuffer self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.Retain();
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("Retain", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Slice(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    QuickJS.IO.ByteBuffer self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), "Slice", typeof(int), 0);
                    }
                    var ret = self.Slice(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("Slice", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_CheckReadalbe(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    QuickJS.IO.ByteBuffer self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), "CheckReadalbe", typeof(int), 0);
                    }
                    self.CheckReadalbe(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CheckReadalbe", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ReadBytes(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        QuickJS.IO.ByteBuffer self;
                        if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        byte[] arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), "ReadBytes", typeof(byte[]), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), "ReadBytes", typeof(int), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), "ReadBytes", typeof(int), 2);
                        }
                        var ret = self.ReadBytes(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        QuickJS.IO.ByteBuffer self;
                        if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        System.IntPtr arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), "ReadBytes", typeof(System.IntPtr), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), "ReadBytes", typeof(int), 1);
                        }
                        var ret = self.ReadBytes(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        QuickJS.IO.ByteBuffer self;
                        if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), "ReadBytes", typeof(int), 0);
                        }
                        self.ReadBytes(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("ReadBytes", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ReadUByte(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    QuickJS.IO.ByteBuffer self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.ReadUByte();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ReadUByte", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ReadSByte(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    QuickJS.IO.ByteBuffer self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.ReadSByte();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ReadSByte", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ReadBoolean(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    QuickJS.IO.ByteBuffer self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.ReadBoolean();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ReadBoolean", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ReadAllBytes(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    QuickJS.IO.ByteBuffer self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.ReadAllBytes();
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("ReadAllBytes", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ReadSingle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    QuickJS.IO.ByteBuffer self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.ReadSingle();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ReadSingle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ReadDouble(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    QuickJS.IO.ByteBuffer self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.ReadDouble();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ReadDouble", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ReadString(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    QuickJS.IO.ByteBuffer self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.ReadString();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ReadString", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ReadInt16(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    QuickJS.IO.ByteBuffer self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.ReadInt16();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ReadInt16", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ReadUInt16(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    QuickJS.IO.ByteBuffer self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.ReadUInt16();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ReadUInt16", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ReadInt32(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    QuickJS.IO.ByteBuffer self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.ReadInt32();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ReadInt32", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ReadUInt32(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    QuickJS.IO.ByteBuffer self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.ReadUInt32();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ReadUInt32", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ReadInt64(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    QuickJS.IO.ByteBuffer self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.ReadInt64();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ReadInt64", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ReadUInt64(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    QuickJS.IO.ByteBuffer self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.ReadUInt64();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ReadUInt64", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_EnsureCapacity(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    QuickJS.IO.ByteBuffer self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), "EnsureCapacity", typeof(int), 0);
                    }
                    self.EnsureCapacity(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("EnsureCapacity", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_WriteByte(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    QuickJS.IO.ByteBuffer self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    byte arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), "WriteByte", typeof(byte), 0);
                    }
                    self.WriteByte(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("WriteByte", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_WriteSByte(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    QuickJS.IO.ByteBuffer self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    sbyte arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), "WriteSByte", typeof(sbyte), 0);
                    }
                    self.WriteSByte(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("WriteSByte", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_WriteBytes(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        QuickJS.IO.ByteBuffer self;
                        if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        byte[] arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), "WriteBytes", typeof(byte[]), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), "WriteBytes", typeof(int), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), "WriteBytes", typeof(int), 2);
                        }
                        self.WriteBytes(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        QuickJS.IO.ByteBuffer self;
                        if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        System.IO.MemoryStream arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), "WriteBytes", typeof(System.IO.MemoryStream), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), "WriteBytes", typeof(int), 1);
                        }
                        self.WriteBytes(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(QuickJS.IO.ByteBuffer)))
                        {
                            QuickJS.IO.ByteBuffer self;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            QuickJS.IO.ByteBuffer arg0;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), "WriteBytes", typeof(QuickJS.IO.ByteBuffer), 0);
                            }
                            self.WriteBytes(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)))
                        {
                            QuickJS.IO.ByteBuffer self;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), "WriteBytes", typeof(int), 0);
                            }
                            self.WriteBytes(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(byte[])))
                        {
                            QuickJS.IO.ByteBuffer self;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            byte[] arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), "WriteBytes", typeof(byte[]), 0);
                            }
                            self.WriteBytes(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("WriteBytes", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_WriteBoolean(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    QuickJS.IO.ByteBuffer self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    bool arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), "WriteBoolean", typeof(bool), 0);
                    }
                    self.WriteBoolean(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("WriteBoolean", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_WriteInt16(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    QuickJS.IO.ByteBuffer self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    short arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), "WriteInt16", typeof(short), 0);
                    }
                    self.WriteInt16(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("WriteInt16", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_WriteUInt16(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    QuickJS.IO.ByteBuffer self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    ushort arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), "WriteUInt16", typeof(ushort), 0);
                    }
                    self.WriteUInt16(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("WriteUInt16", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_WriteInt32(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    QuickJS.IO.ByteBuffer self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), "WriteInt32", typeof(int), 0);
                    }
                    self.WriteInt32(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("WriteInt32", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_WriteUInt32(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    QuickJS.IO.ByteBuffer self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    uint arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), "WriteUInt32", typeof(uint), 0);
                    }
                    self.WriteUInt32(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("WriteUInt32", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_WriteInt64(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    QuickJS.IO.ByteBuffer self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    long arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), "WriteInt64", typeof(long), 0);
                    }
                    self.WriteInt64(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("WriteInt64", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_WriteUInt64(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    QuickJS.IO.ByteBuffer self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    ulong arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), "WriteUInt64", typeof(ulong), 0);
                    }
                    self.WriteUInt64(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("WriteUInt64", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_WriteSingle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    QuickJS.IO.ByteBuffer self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    float arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), "WriteSingle", typeof(float), 0);
                    }
                    self.WriteSingle(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("WriteSingle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_WriteDouble(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    QuickJS.IO.ByteBuffer self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    double arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), "WriteDouble", typeof(double), 0);
                    }
                    self.WriteDouble(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("WriteDouble", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_WriteString(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    QuickJS.IO.ByteBuffer self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), "WriteString", typeof(string), 0);
                    }
                    self.WriteString(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("WriteString", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_data(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.IO.ByteBuffer self;
                if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.data;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_capacity(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.IO.ByteBuffer self;
                if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.capacity;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_writerIndex(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.IO.ByteBuffer self;
                if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.writerIndex;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_writerIndex(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.IO.ByteBuffer self;
                if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), "writerIndex", typeof(int), 0);
                }
                self.writerIndex = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_readableBytes(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.IO.ByteBuffer self;
                if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.readableBytes;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_readerIndex(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.IO.ByteBuffer self;
                if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.readerIndex;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_readerIndex(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.IO.ByteBuffer self;
                if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.IO.ByteBuffer), "readerIndex", typeof(int), 0);
                }
                self.readerIndex = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_maxCapacity(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.IO.ByteBuffer self;
                if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.maxCapacity;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_isWritable(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.IO.ByteBuffer self;
                if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.isWritable;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("ByteBuffer", typeof(QuickJS.IO.ByteBuffer), BindConstructor);
            cls.AddMethod(false, "toString", Bind_ToString);
            cls.AddMethod(false, "Release", Bind_Release);
            cls.AddMethod(false, "Retain", Bind_Retain);
            cls.AddMethod(false, "Slice", Bind_Slice);
            cls.AddMethod(false, "CheckReadalbe", Bind_CheckReadalbe);
            cls.AddMethod(false, "ReadBytes", Bind_ReadBytes);
            cls.AddMethod(false, "ReadUByte", Bind_ReadUByte);
            cls.AddMethod(false, "ReadSByte", Bind_ReadSByte);
            cls.AddMethod(false, "ReadBoolean", Bind_ReadBoolean);
            cls.AddMethod(false, "ReadAllBytes", Bind_ReadAllBytes);
            cls.AddMethod(false, "ReadSingle", Bind_ReadSingle);
            cls.AddMethod(false, "ReadDouble", Bind_ReadDouble);
            cls.AddMethod(false, "ReadString", Bind_ReadString);
            cls.AddMethod(false, "ReadInt16", Bind_ReadInt16);
            cls.AddMethod(false, "ReadUInt16", Bind_ReadUInt16);
            cls.AddMethod(false, "ReadInt32", Bind_ReadInt32);
            cls.AddMethod(false, "ReadUInt32", Bind_ReadUInt32);
            cls.AddMethod(false, "ReadInt64", Bind_ReadInt64);
            cls.AddMethod(false, "ReadUInt64", Bind_ReadUInt64);
            cls.AddMethod(false, "EnsureCapacity", Bind_EnsureCapacity);
            cls.AddMethod(false, "WriteByte", Bind_WriteByte);
            cls.AddMethod(false, "WriteSByte", Bind_WriteSByte);
            cls.AddMethod(false, "WriteBytes", Bind_WriteBytes);
            cls.AddMethod(false, "WriteBoolean", Bind_WriteBoolean);
            cls.AddMethod(false, "WriteInt16", Bind_WriteInt16);
            cls.AddMethod(false, "WriteUInt16", Bind_WriteUInt16);
            cls.AddMethod(false, "WriteInt32", Bind_WriteInt32);
            cls.AddMethod(false, "WriteUInt32", Bind_WriteUInt32);
            cls.AddMethod(false, "WriteInt64", Bind_WriteInt64);
            cls.AddMethod(false, "WriteUInt64", Bind_WriteUInt64);
            cls.AddMethod(false, "WriteSingle", Bind_WriteSingle);
            cls.AddMethod(false, "WriteDouble", Bind_WriteDouble);
            cls.AddMethod(false, "WriteString", Bind_WriteString);
            cls.AddProperty(false, "data", BindRead_data, null);
            cls.AddProperty(false, "capacity", BindRead_capacity, null);
            cls.AddProperty(false, "writerIndex", BindRead_writerIndex, BindWrite_writerIndex);
            cls.AddProperty(false, "readableBytes", BindRead_readableBytes, null);
            cls.AddProperty(false, "readerIndex", BindRead_readerIndex, BindWrite_readerIndex);
            cls.AddProperty(false, "maxCapacity", BindRead_maxCapacity, null);
            cls.AddProperty(false, "isWritable", BindRead_isWritable, null);
            return cls;
        }
    }
}
#endif
