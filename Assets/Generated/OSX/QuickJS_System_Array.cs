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
    // Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
    // Location: /Applications/Unity/Hub/Editor/2021.3.37f1/Unity.app/Contents/MonoBleedingEdge/lib/mono/unityjit-macos/mscorlib.dll
    // Type: System.Array
    [JSBindingAttribute]
    public class QuickJS_System_Array
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_CopyTo(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    System.Array self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    System.Array arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.Array), "CopyTo", typeof(System.Array), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(System.Array), "CopyTo", typeof(int), 1);
                    }
                    self.CopyTo(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CopyTo", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Clone(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    System.Array self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.Clone();
                    return QuickJS.Binding.Values.js_push_object(ctx, ret);
                }
                throw new NoSuitableMethodException("Clone", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetLongLength(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    System.Array self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.Array), "GetLongLength", typeof(int), 0);
                    }
                    var ret = self.GetLongLength(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetLongLength", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetEnumerator(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    System.Array self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.GetEnumerator();
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetEnumerator", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetLength(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    System.Array self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.Array), "GetLength", typeof(int), 0);
                    }
                    var ret = self.GetLength(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetLength", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetLowerBound(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    System.Array self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.Array), "GetLowerBound", typeof(int), 0);
                    }
                    var ret = self.GetLowerBound(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetLowerBound", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetValue(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        System.Array self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.Array), "GetValue", typeof(int), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.Array), "GetValue", typeof(int), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(System.Array), "GetValue", typeof(int), 2);
                        }
                        var ret = self.GetValue(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_object(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        System.Array self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.Array), "GetValue", typeof(int), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.Array), "GetValue", typeof(int), 1);
                        }
                        var ret = self.GetValue(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_object(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        System.Array self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.Array), "GetValue", typeof(int), 0);
                        }
                        var ret = self.GetValue(arg0);
                        return QuickJS.Binding.Values.js_push_object(ctx, ret);
                    }
                    if (Values.js_match_param_types(ctx, 0, argv, typeof(int)))
                    {
                        System.Array self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        int[] arg0 = null;
                        if (argc > 0)
                        {
                            arg0 = new int[argc];
                            for (var i = 0; i < argc; i++)
                            {
                                QuickJS.Binding.Values.js_get_primitive(ctx, argv[i], out arg0[i]);
                            }
                        }
                        var ret = self.GetValue(arg0);
                        return QuickJS.Binding.Values.js_push_object(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("GetValue", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetValue(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        System.Array self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        object arg0;
                        if (!Values.js_get_var(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.Array), "SetValue", typeof(object), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.Array), "SetValue", typeof(int), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(System.Array), "SetValue", typeof(int), 2);
                        }
                        int arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(System.Array), "SetValue", typeof(int), 3);
                        }
                        self.SetValue(arg0, arg1, arg2, arg3);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 3)
                    {
                        System.Array self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        object arg0;
                        if (!Values.js_get_var(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.Array), "SetValue", typeof(object), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.Array), "SetValue", typeof(int), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(System.Array), "SetValue", typeof(int), 2);
                        }
                        self.SetValue(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        System.Array self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        object arg0;
                        if (!Values.js_get_var(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.Array), "SetValue", typeof(object), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.Array), "SetValue", typeof(int), 1);
                        }
                        self.SetValue(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(object)) && Values.js_match_param_types(ctx, 1, argv, typeof(int)))
                        {
                            System.Array self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            object arg0;
                            if (!Values.js_get_var(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(System.Array), "SetValue", typeof(object), 0);
                            }
                            int[] arg1 = null;
                            if (argc - 1 > 0)
                            {
                                arg1 = new int[argc - 1];
                                for (var i = 1; i < argc; i++)
                                {
                                    QuickJS.Binding.Values.js_get_primitive(ctx, argv[i], out arg1[i - 1]);
                                }
                            }
                            self.SetValue(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("SetValue", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetUpperBound(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    System.Array self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.Array), "GetUpperBound", typeof(int), 0);
                    }
                    var ret = self.GetUpperBound(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetUpperBound", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Initialize(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    System.Array self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.Initialize();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Initialize", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BinarySearch(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        System.Array arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.Array), "BinarySearch", typeof(System.Array), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.Array), "BinarySearch", typeof(int), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(System.Array), "BinarySearch", typeof(int), 2);
                        }
                        object arg3;
                        if (!Values.js_get_var(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(System.Array), "BinarySearch", typeof(object), 3);
                        }
                        System.Collections.IComparer arg4;
                        if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(System.Array), "BinarySearch", typeof(System.Collections.IComparer), 4);
                        }
                        var ret = System.Array.BinarySearch(arg0, arg1, arg2, arg3, arg4);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 4)
                    {
                        System.Array arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.Array), "BinarySearch", typeof(System.Array), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.Array), "BinarySearch", typeof(int), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(System.Array), "BinarySearch", typeof(int), 2);
                        }
                        object arg3;
                        if (!Values.js_get_var(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(System.Array), "BinarySearch", typeof(object), 3);
                        }
                        var ret = System.Array.BinarySearch(arg0, arg1, arg2, arg3);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        System.Array arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.Array), "BinarySearch", typeof(System.Array), 0);
                        }
                        object arg1;
                        if (!Values.js_get_var(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.Array), "BinarySearch", typeof(object), 1);
                        }
                        System.Collections.IComparer arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(System.Array), "BinarySearch", typeof(System.Collections.IComparer), 2);
                        }
                        var ret = System.Array.BinarySearch(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        System.Array arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.Array), "BinarySearch", typeof(System.Array), 0);
                        }
                        object arg1;
                        if (!Values.js_get_var(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.Array), "BinarySearch", typeof(object), 1);
                        }
                        var ret = System.Array.BinarySearch(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("BinarySearch", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IndexOf(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        System.Array arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.Array), "IndexOf", typeof(System.Array), 0);
                        }
                        object arg1;
                        if (!Values.js_get_var(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.Array), "IndexOf", typeof(object), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(System.Array), "IndexOf", typeof(int), 2);
                        }
                        int arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(System.Array), "IndexOf", typeof(int), 3);
                        }
                        var ret = System.Array.IndexOf(arg0, arg1, arg2, arg3);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        System.Array arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.Array), "IndexOf", typeof(System.Array), 0);
                        }
                        object arg1;
                        if (!Values.js_get_var(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.Array), "IndexOf", typeof(object), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(System.Array), "IndexOf", typeof(int), 2);
                        }
                        var ret = System.Array.IndexOf(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        System.Array arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.Array), "IndexOf", typeof(System.Array), 0);
                        }
                        object arg1;
                        if (!Values.js_get_var(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.Array), "IndexOf", typeof(object), 1);
                        }
                        var ret = System.Array.IndexOf(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("IndexOf", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LastIndexOf(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        System.Array arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.Array), "LastIndexOf", typeof(System.Array), 0);
                        }
                        object arg1;
                        if (!Values.js_get_var(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.Array), "LastIndexOf", typeof(object), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(System.Array), "LastIndexOf", typeof(int), 2);
                        }
                        int arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(System.Array), "LastIndexOf", typeof(int), 3);
                        }
                        var ret = System.Array.LastIndexOf(arg0, arg1, arg2, arg3);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        System.Array arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.Array), "LastIndexOf", typeof(System.Array), 0);
                        }
                        object arg1;
                        if (!Values.js_get_var(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.Array), "LastIndexOf", typeof(object), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(System.Array), "LastIndexOf", typeof(int), 2);
                        }
                        var ret = System.Array.LastIndexOf(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        System.Array arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.Array), "LastIndexOf", typeof(System.Array), 0);
                        }
                        object arg1;
                        if (!Values.js_get_var(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.Array), "LastIndexOf", typeof(object), 1);
                        }
                        var ret = System.Array.LastIndexOf(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("LastIndexOf", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Reverse(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        System.Array arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.Array), "Reverse", typeof(System.Array), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.Array), "Reverse", typeof(int), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(System.Array), "Reverse", typeof(int), 2);
                        }
                        System.Array.Reverse(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        System.Array arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.Array), "Reverse", typeof(System.Array), 0);
                        }
                        System.Array.Reverse(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("Reverse", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Sort(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        System.Array arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.Array), "Sort", typeof(System.Array), 0);
                        }
                        System.Array arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.Array), "Sort", typeof(System.Array), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(System.Array), "Sort", typeof(int), 2);
                        }
                        int arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(System.Array), "Sort", typeof(int), 3);
                        }
                        System.Collections.IComparer arg4;
                        if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(System.Array), "Sort", typeof(System.Collections.IComparer), 4);
                        }
                        System.Array.Sort(arg0, arg1, arg2, arg3, arg4);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Array)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(System.Collections.IComparer)))
                        {
                            System.Array arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(System.Array), "Sort", typeof(System.Array), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(System.Array), "Sort", typeof(int), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(System.Array), "Sort", typeof(int), 2);
                            }
                            System.Collections.IComparer arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(System.Array), "Sort", typeof(System.Collections.IComparer), 3);
                            }
                            System.Array.Sort(arg0, arg1, arg2, arg3);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Array)) && Values.js_match_type(ctx, argv[1], typeof(System.Array)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(int)))
                        {
                            System.Array arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(System.Array), "Sort", typeof(System.Array), 0);
                            }
                            System.Array arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(System.Array), "Sort", typeof(System.Array), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(System.Array), "Sort", typeof(int), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(System.Array), "Sort", typeof(int), 3);
                            }
                            System.Array.Sort(arg0, arg1, arg2, arg3);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Array)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(int)))
                        {
                            System.Array arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(System.Array), "Sort", typeof(System.Array), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(System.Array), "Sort", typeof(int), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(System.Array), "Sort", typeof(int), 2);
                            }
                            System.Array.Sort(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Array)) && Values.js_match_type(ctx, argv[1], typeof(System.Array)) && Values.js_match_type(ctx, argv[2], typeof(System.Collections.IComparer)))
                        {
                            System.Array arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(System.Array), "Sort", typeof(System.Array), 0);
                            }
                            System.Array arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(System.Array), "Sort", typeof(System.Array), 1);
                            }
                            System.Collections.IComparer arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(System.Array), "Sort", typeof(System.Collections.IComparer), 2);
                            }
                            System.Array.Sort(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Array)) && Values.js_match_type(ctx, argv[1], typeof(System.Collections.IComparer)))
                        {
                            System.Array arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(System.Array), "Sort", typeof(System.Array), 0);
                            }
                            System.Collections.IComparer arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(System.Array), "Sort", typeof(System.Collections.IComparer), 1);
                            }
                            System.Array.Sort(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Array)) && Values.js_match_type(ctx, argv[1], typeof(System.Array)))
                        {
                            System.Array arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(System.Array), "Sort", typeof(System.Array), 0);
                            }
                            System.Array arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(System.Array), "Sort", typeof(System.Array), 1);
                            }
                            System.Array.Sort(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 1)
                    {
                        System.Array arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.Array), "Sort", typeof(System.Array), 0);
                        }
                        System.Array.Sort(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("Sort", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CreateInstance(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        System.Type arg0;
                        if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.Array), "CreateInstance", typeof(System.Type), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.Array), "CreateInstance", typeof(int), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(System.Array), "CreateInstance", typeof(int), 2);
                        }
                        int arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(System.Array), "CreateInstance", typeof(int), 3);
                        }
                        var ret = System.Array.CreateInstance(arg0, arg1, arg2, arg3);
                        return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Type)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(int)))
                        {
                            System.Type arg0;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(System.Array), "CreateInstance", typeof(System.Type), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(System.Array), "CreateInstance", typeof(int), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(System.Array), "CreateInstance", typeof(int), 2);
                            }
                            var ret = System.Array.CreateInstance(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Type)) && Values.js_match_type(ctx, argv[1], typeof(int[])) && Values.js_match_type(ctx, argv[2], typeof(int[])))
                        {
                            System.Type arg0;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(System.Array), "CreateInstance", typeof(System.Type), 0);
                            }
                            int[] arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(System.Array), "CreateInstance", typeof(int[]), 1);
                            }
                            int[] arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(System.Array), "CreateInstance", typeof(int[]), 2);
                            }
                            var ret = System.Array.CreateInstance(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        System.Type arg0;
                        if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.Array), "CreateInstance", typeof(System.Type), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.Array), "CreateInstance", typeof(int), 1);
                        }
                        var ret = System.Array.CreateInstance(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Type)) && Values.js_match_param_types(ctx, 1, argv, typeof(int)))
                        {
                            System.Type arg0;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(System.Array), "CreateInstance", typeof(System.Type), 0);
                            }
                            int[] arg1 = null;
                            if (argc - 1 > 0)
                            {
                                arg1 = new int[argc - 1];
                                for (var i = 1; i < argc; i++)
                                {
                                    QuickJS.Binding.Values.js_get_primitive(ctx, argv[i], out arg1[i - 1]);
                                }
                            }
                            var ret = System.Array.CreateInstance(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("CreateInstance", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Clear(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    System.Array arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.Array), "Clear", typeof(System.Array), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(System.Array), "Clear", typeof(int), 1);
                    }
                    int arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(System.Array), "Clear", typeof(int), 2);
                    }
                    System.Array.Clear(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Clear", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Copy(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        System.Array arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.Array), "Copy", typeof(System.Array), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.Array), "Copy", typeof(int), 1);
                        }
                        System.Array arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(System.Array), "Copy", typeof(System.Array), 2);
                        }
                        int arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(System.Array), "Copy", typeof(int), 3);
                        }
                        int arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(System.Array), "Copy", typeof(int), 4);
                        }
                        System.Array.Copy(arg0, arg1, arg2, arg3, arg4);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 3)
                    {
                        System.Array arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.Array), "Copy", typeof(System.Array), 0);
                        }
                        System.Array arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.Array), "Copy", typeof(System.Array), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(System.Array), "Copy", typeof(int), 2);
                        }
                        System.Array.Copy(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("Copy", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ConstrainedCopy(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 5)
                {
                    System.Array arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.Array), "ConstrainedCopy", typeof(System.Array), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(System.Array), "ConstrainedCopy", typeof(int), 1);
                    }
                    System.Array arg2;
                    if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(System.Array), "ConstrainedCopy", typeof(System.Array), 2);
                    }
                    int arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(System.Array), "ConstrainedCopy", typeof(int), 3);
                    }
                    int arg4;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(System.Array), "ConstrainedCopy", typeof(int), 4);
                    }
                    System.Array.ConstrainedCopy(arg0, arg1, arg2, arg3, arg4);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ConstrainedCopy", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_LongLength(JSContext ctx, JSValue this_obj)
        {
            try
            {
                System.Array self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.LongLength;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_IsFixedSize(JSContext ctx, JSValue this_obj)
        {
            try
            {
                System.Array self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.IsFixedSize;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_IsReadOnly(JSContext ctx, JSValue this_obj)
        {
            try
            {
                System.Array self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.IsReadOnly;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_IsSynchronized(JSContext ctx, JSValue this_obj)
        {
            try
            {
                System.Array self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.IsSynchronized;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_SyncRoot(JSContext ctx, JSValue this_obj)
        {
            try
            {
                System.Array self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.SyncRoot;
                return QuickJS.Binding.Values.js_push_object(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_Length(JSContext ctx, JSValue this_obj)
        {
            try
            {
                System.Array self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.Length;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_Rank(JSContext ctx, JSValue this_obj)
        {
            try
            {
                System.Array self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.Rank;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("Array<T, RANK = 1>", typeof(System.Array), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(false, "CopyTo", Bind_CopyTo);
            cls.AddMethod(false, "Clone", Bind_Clone);
            cls.AddMethod(false, "GetLongLength", Bind_GetLongLength);
            cls.AddMethod(false, "GetEnumerator", Bind_GetEnumerator);
            cls.AddMethod(false, "GetLength", Bind_GetLength);
            cls.AddMethod(false, "GetLowerBound", Bind_GetLowerBound);
            cls.AddMethod(false, "GetValue", Bind_GetValue);
            cls.AddMethod(false, "SetValue", Bind_SetValue);
            cls.AddMethod(false, "GetUpperBound", Bind_GetUpperBound);
            cls.AddMethod(false, "Initialize", Bind_Initialize);
            cls.AddMethod(true, "BinarySearch", BindStatic_BinarySearch);
            cls.AddMethod(true, "IndexOf", BindStatic_IndexOf);
            cls.AddMethod(true, "LastIndexOf", BindStatic_LastIndexOf);
            cls.AddMethod(true, "Reverse", BindStatic_Reverse);
            cls.AddMethod(true, "Sort", BindStatic_Sort);
            cls.AddMethod(true, "CreateInstance", BindStatic_CreateInstance);
            cls.AddMethod(true, "Clear", BindStatic_Clear);
            cls.AddMethod(true, "Copy", BindStatic_Copy);
            cls.AddMethod(true, "ConstrainedCopy", BindStatic_ConstrainedCopy);
            cls.AddProperty(false, "LongLength", BindRead_LongLength, null);
            cls.AddProperty(false, "IsFixedSize", BindRead_IsFixedSize, null);
            cls.AddProperty(false, "IsReadOnly", BindRead_IsReadOnly, null);
            cls.AddProperty(false, "IsSynchronized", BindRead_IsSynchronized, null);
            cls.AddProperty(false, "SyncRoot", BindRead_SyncRoot, null);
            cls.AddProperty(false, "Length", BindRead_Length, null);
            cls.AddProperty(false, "Rank", BindRead_Rank, null);
            return cls;
        }
    }
}
#endif
