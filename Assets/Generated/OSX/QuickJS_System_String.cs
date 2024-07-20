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
    // Type: System.String
    [JSBindingAttribute]
    public class QuickJS_System_String
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
                        char[] arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), ".ctor", typeof(char[]), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(string), ".ctor", typeof(int), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(string), ".ctor", typeof(int), 2);
                        }
                        var o = new string(arg0, arg1, arg2);
                        var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                        return val;
                    }
                    if (argc == 2)
                    {
                        char arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), ".ctor", typeof(char), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(string), ".ctor", typeof(int), 1);
                        }
                        var o = new string(arg0, arg1);
                        var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                        return val;
                    }
                    if (argc == 1)
                    {
                        char[] arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), ".ctor", typeof(char[]), 0);
                        }
                        var o = new string(arg0);
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
        public static JSValue Bind_CompareTo(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(object)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            object arg0;
                            if (!Values.js_get_var(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "CompareTo", typeof(object), 0);
                            }
                            var ret = self.CompareTo(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "CompareTo", typeof(string), 0);
                            }
                            var ret = self.CompareTo(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("CompareTo", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_EndsWith(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "EndsWith", typeof(string), 0);
                        }
                        bool arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(string), "EndsWith", typeof(bool), 1);
                        }
                        System.Globalization.CultureInfo arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(string), "EndsWith", typeof(System.Globalization.CultureInfo), 2);
                        }
                        var ret = self.EndsWith(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "EndsWith", typeof(string), 0);
                        }
                        System.StringComparison arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(string), "EndsWith", typeof(System.StringComparison), 1);
                        }
                        var ret = self.EndsWith(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "EndsWith", typeof(string), 0);
                            }
                            var ret = self.EndsWith(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(char)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            char arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "EndsWith", typeof(char), 0);
                            }
                            var ret = self.EndsWith(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("EndsWith", argc);
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
                    if (argc == 2)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "Equals", typeof(string), 0);
                        }
                        System.StringComparison arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(string), "Equals", typeof(System.StringComparison), 1);
                        }
                        var ret = self.Equals(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(object)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            object arg0;
                            if (!Values.js_get_var(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Equals", typeof(object), 0);
                            }
                            var ret = self.Equals(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Equals", typeof(string), 0);
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
        public static JSValue Bind_GetHashCode(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        System.StringComparison arg0;
                        if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "GetHashCode", typeof(System.StringComparison), 0);
                        }
                        var ret = self.GetHashCode(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 0)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        var ret = self.GetHashCode();
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("GetHashCode", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_StartsWith(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "StartsWith", typeof(string), 0);
                        }
                        bool arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(string), "StartsWith", typeof(bool), 1);
                        }
                        System.Globalization.CultureInfo arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(string), "StartsWith", typeof(System.Globalization.CultureInfo), 2);
                        }
                        var ret = self.StartsWith(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "StartsWith", typeof(string), 0);
                        }
                        System.StringComparison arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(string), "StartsWith", typeof(System.StringComparison), 1);
                        }
                        var ret = self.StartsWith(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "StartsWith", typeof(string), 0);
                            }
                            var ret = self.StartsWith(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(char)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            char arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "StartsWith", typeof(char), 0);
                            }
                            var ret = self.StartsWith(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("StartsWith", argc);
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
                    string self;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
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
        public static JSValue Bind_CopyTo(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 4)
                {
                    string self;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(string), "CopyTo", typeof(int), 0);
                    }
                    char[] arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(string), "CopyTo", typeof(char[]), 1);
                    }
                    int arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(string), "CopyTo", typeof(int), 2);
                    }
                    int arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(string), "CopyTo", typeof(int), 3);
                    }
                    self.CopyTo(arg0, arg1, arg2, arg3);
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
        public static JSValue Bind_ToCharArray(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "ToCharArray", typeof(int), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(string), "ToCharArray", typeof(int), 1);
                        }
                        var ret = self.ToCharArray(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 0)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        var ret = self.ToCharArray();
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("ToCharArray", argc);
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
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        System.IFormatProvider arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "ToString", typeof(System.IFormatProvider), 0);
                        }
                        var ret = self.ToString(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 0)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
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
        public static JSValue Bind_GetEnumerator(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    string self;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
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
        public static JSValue Bind_GetTypeCode(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    string self;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.GetTypeCode();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                }
                throw new NoSuitableMethodException("GetTypeCode", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_IsNormalized(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        System.Text.NormalizationForm arg0;
                        if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "IsNormalized", typeof(System.Text.NormalizationForm), 0);
                        }
                        var ret = self.IsNormalized(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 0)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        var ret = self.IsNormalized();
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("IsNormalized", argc);
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
                do
                {
                    if (argc == 1)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        System.Text.NormalizationForm arg0;
                        if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "Normalize", typeof(System.Text.NormalizationForm), 0);
                        }
                        var ret = self.Normalize(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 0)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        var ret = self.Normalize();
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("Normalize", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Insert(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string self;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(string), "Insert", typeof(int), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(string), "Insert", typeof(string), 1);
                    }
                    var ret = self.Insert(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("Insert", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_PadLeft(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "PadLeft", typeof(int), 0);
                        }
                        char arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(string), "PadLeft", typeof(char), 1);
                        }
                        var ret = self.PadLeft(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "PadLeft", typeof(int), 0);
                        }
                        var ret = self.PadLeft(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("PadLeft", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_PadRight(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "PadRight", typeof(int), 0);
                        }
                        char arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(string), "PadRight", typeof(char), 1);
                        }
                        var ret = self.PadRight(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "PadRight", typeof(int), 0);
                        }
                        var ret = self.PadRight(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("PadRight", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Remove(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "Remove", typeof(int), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(string), "Remove", typeof(int), 1);
                        }
                        var ret = self.Remove(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "Remove", typeof(int), 0);
                        }
                        var ret = self.Remove(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("Remove", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Replace(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "Replace", typeof(string), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(string), "Replace", typeof(string), 1);
                        }
                        bool arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(string), "Replace", typeof(bool), 2);
                        }
                        System.Globalization.CultureInfo arg3;
                        if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(string), "Replace", typeof(System.Globalization.CultureInfo), 3);
                        }
                        var ret = self.Replace(arg0, arg1, arg2, arg3);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "Replace", typeof(string), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(string), "Replace", typeof(string), 1);
                        }
                        System.StringComparison arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(string), "Replace", typeof(System.StringComparison), 2);
                        }
                        var ret = self.Replace(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(char)) && Values.js_match_type(ctx, argv[1], typeof(char)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            char arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Replace", typeof(char), 0);
                            }
                            char arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Replace", typeof(char), 1);
                            }
                            var ret = self.Replace(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(string)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Replace", typeof(string), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Replace", typeof(string), 1);
                            }
                            var ret = self.Replace(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Replace", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Split(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(char)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(System.StringSplitOptions)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            char arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Split", typeof(char), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Split", typeof(int), 1);
                            }
                            System.StringSplitOptions arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(string), "Split", typeof(System.StringSplitOptions), 2);
                            }
                            var ret = self.Split(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(char[])) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(System.StringSplitOptions)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            char[] arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Split", typeof(char[]), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Split", typeof(int), 1);
                            }
                            System.StringSplitOptions arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(string), "Split", typeof(System.StringSplitOptions), 2);
                            }
                            var ret = self.Split(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(System.StringSplitOptions)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Split", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Split", typeof(int), 1);
                            }
                            System.StringSplitOptions arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(string), "Split", typeof(System.StringSplitOptions), 2);
                            }
                            var ret = self.Split(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string[])) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(System.StringSplitOptions)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string[] arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Split", typeof(string[]), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Split", typeof(int), 1);
                            }
                            System.StringSplitOptions arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(string), "Split", typeof(System.StringSplitOptions), 2);
                            }
                            var ret = self.Split(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(char)) && Values.js_match_type(ctx, argv[1], typeof(System.StringSplitOptions)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            char arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Split", typeof(char), 0);
                            }
                            System.StringSplitOptions arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Split", typeof(System.StringSplitOptions), 1);
                            }
                            var ret = self.Split(arg0, arg1);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(char[])) && Values.js_match_type(ctx, argv[1], typeof(int)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            char[] arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Split", typeof(char[]), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Split", typeof(int), 1);
                            }
                            var ret = self.Split(arg0, arg1);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(char[])) && Values.js_match_type(ctx, argv[1], typeof(System.StringSplitOptions)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            char[] arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Split", typeof(char[]), 0);
                            }
                            System.StringSplitOptions arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Split", typeof(System.StringSplitOptions), 1);
                            }
                            var ret = self.Split(arg0, arg1);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(System.StringSplitOptions)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Split", typeof(string), 0);
                            }
                            System.StringSplitOptions arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Split", typeof(System.StringSplitOptions), 1);
                            }
                            var ret = self.Split(arg0, arg1);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string[])) && Values.js_match_type(ctx, argv[1], typeof(System.StringSplitOptions)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string[] arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Split", typeof(string[]), 0);
                            }
                            System.StringSplitOptions arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Split", typeof(System.StringSplitOptions), 1);
                            }
                            var ret = self.Split(arg0, arg1);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (Values.js_match_param_types(ctx, 0, argv, typeof(char)))
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        char[] arg0 = null;
                        if (argc > 0)
                        {
                            arg0 = new char[argc];
                            for (var i = 0; i < argc; i++)
                            {
                                QuickJS.Binding.Values.js_get_primitive(ctx, argv[i], out arg0[i]);
                            }
                        }
                        var ret = self.Split(arg0);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("Split", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Substring(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "Substring", typeof(int), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(string), "Substring", typeof(int), 1);
                        }
                        var ret = self.Substring(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "Substring", typeof(int), 0);
                        }
                        var ret = self.Substring(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("Substring", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ToLower(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        System.Globalization.CultureInfo arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "ToLower", typeof(System.Globalization.CultureInfo), 0);
                        }
                        var ret = self.ToLower(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 0)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        var ret = self.ToLower();
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("ToLower", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ToLowerInvariant(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    string self;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.ToLowerInvariant();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ToLowerInvariant", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ToUpper(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        System.Globalization.CultureInfo arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "ToUpper", typeof(System.Globalization.CultureInfo), 0);
                        }
                        var ret = self.ToUpper(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 0)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        var ret = self.ToUpper();
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("ToUpper", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ToUpperInvariant(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    string self;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.ToUpperInvariant();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ToUpperInvariant", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Trim(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        char arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "Trim", typeof(char), 0);
                        }
                        var ret = self.Trim(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 0)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        var ret = self.Trim();
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (Values.js_match_param_types(ctx, 0, argv, typeof(char)))
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        char[] arg0 = null;
                        if (argc > 0)
                        {
                            arg0 = new char[argc];
                            for (var i = 0; i < argc; i++)
                            {
                                QuickJS.Binding.Values.js_get_primitive(ctx, argv[i], out arg0[i]);
                            }
                        }
                        var ret = self.Trim(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("Trim", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_TrimStart(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        char arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "TrimStart", typeof(char), 0);
                        }
                        var ret = self.TrimStart(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 0)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        var ret = self.TrimStart();
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (Values.js_match_param_types(ctx, 0, argv, typeof(char)))
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        char[] arg0 = null;
                        if (argc > 0)
                        {
                            arg0 = new char[argc];
                            for (var i = 0; i < argc; i++)
                            {
                                QuickJS.Binding.Values.js_get_primitive(ctx, argv[i], out arg0[i]);
                            }
                        }
                        var ret = self.TrimStart(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("TrimStart", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_TrimEnd(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        char arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "TrimEnd", typeof(char), 0);
                        }
                        var ret = self.TrimEnd(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 0)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        var ret = self.TrimEnd();
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (Values.js_match_param_types(ctx, 0, argv, typeof(char)))
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        char[] arg0 = null;
                        if (argc > 0)
                        {
                            arg0 = new char[argc];
                            for (var i = 0; i < argc; i++)
                            {
                                QuickJS.Binding.Values.js_get_primitive(ctx, argv[i], out arg0[i]);
                            }
                        }
                        var ret = self.TrimEnd(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("TrimEnd", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Contains(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(System.StringComparison)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Contains", typeof(string), 0);
                            }
                            System.StringComparison arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Contains", typeof(System.StringComparison), 1);
                            }
                            var ret = self.Contains(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(char)) && Values.js_match_type(ctx, argv[1], typeof(System.StringComparison)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            char arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Contains", typeof(char), 0);
                            }
                            System.StringComparison arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Contains", typeof(System.StringComparison), 1);
                            }
                            var ret = self.Contains(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Contains", typeof(string), 0);
                            }
                            var ret = self.Contains(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(char)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            char arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Contains", typeof(char), 0);
                            }
                            var ret = self.Contains(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Contains", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_IndexOf(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "IndexOf", typeof(string), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(string), "IndexOf", typeof(int), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(string), "IndexOf", typeof(int), 2);
                        }
                        System.StringComparison arg3;
                        if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(string), "IndexOf", typeof(System.StringComparison), 3);
                        }
                        var ret = self.IndexOf(arg0, arg1, arg2, arg3);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(char)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(int)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            char arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "IndexOf", typeof(char), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "IndexOf", typeof(int), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(string), "IndexOf", typeof(int), 2);
                            }
                            var ret = self.IndexOf(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(int)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "IndexOf", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "IndexOf", typeof(int), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(string), "IndexOf", typeof(int), 2);
                            }
                            var ret = self.IndexOf(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(System.StringComparison)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "IndexOf", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "IndexOf", typeof(int), 1);
                            }
                            System.StringComparison arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(string), "IndexOf", typeof(System.StringComparison), 2);
                            }
                            var ret = self.IndexOf(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(char)) && Values.js_match_type(ctx, argv[1], typeof(int)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            char arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "IndexOf", typeof(char), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "IndexOf", typeof(int), 1);
                            }
                            var ret = self.IndexOf(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(char)) && Values.js_match_type(ctx, argv[1], typeof(System.StringComparison)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            char arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "IndexOf", typeof(char), 0);
                            }
                            System.StringComparison arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "IndexOf", typeof(System.StringComparison), 1);
                            }
                            var ret = self.IndexOf(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(int)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "IndexOf", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "IndexOf", typeof(int), 1);
                            }
                            var ret = self.IndexOf(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(System.StringComparison)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "IndexOf", typeof(string), 0);
                            }
                            System.StringComparison arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "IndexOf", typeof(System.StringComparison), 1);
                            }
                            var ret = self.IndexOf(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(char)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            char arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "IndexOf", typeof(char), 0);
                            }
                            var ret = self.IndexOf(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "IndexOf", typeof(string), 0);
                            }
                            var ret = self.IndexOf(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
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
        public static JSValue Bind_IndexOfAny(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        char[] arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "IndexOfAny", typeof(char[]), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(string), "IndexOfAny", typeof(int), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(string), "IndexOfAny", typeof(int), 2);
                        }
                        var ret = self.IndexOfAny(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        char[] arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "IndexOfAny", typeof(char[]), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(string), "IndexOfAny", typeof(int), 1);
                        }
                        var ret = self.IndexOfAny(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        char[] arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "IndexOfAny", typeof(char[]), 0);
                        }
                        var ret = self.IndexOfAny(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("IndexOfAny", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_LastIndexOf(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "LastIndexOf", typeof(string), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(string), "LastIndexOf", typeof(int), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(string), "LastIndexOf", typeof(int), 2);
                        }
                        System.StringComparison arg3;
                        if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(string), "LastIndexOf", typeof(System.StringComparison), 3);
                        }
                        var ret = self.LastIndexOf(arg0, arg1, arg2, arg3);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(char)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(int)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            char arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "LastIndexOf", typeof(char), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "LastIndexOf", typeof(int), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(string), "LastIndexOf", typeof(int), 2);
                            }
                            var ret = self.LastIndexOf(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(int)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "LastIndexOf", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "LastIndexOf", typeof(int), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(string), "LastIndexOf", typeof(int), 2);
                            }
                            var ret = self.LastIndexOf(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(System.StringComparison)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "LastIndexOf", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "LastIndexOf", typeof(int), 1);
                            }
                            System.StringComparison arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(string), "LastIndexOf", typeof(System.StringComparison), 2);
                            }
                            var ret = self.LastIndexOf(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(char)) && Values.js_match_type(ctx, argv[1], typeof(int)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            char arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "LastIndexOf", typeof(char), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "LastIndexOf", typeof(int), 1);
                            }
                            var ret = self.LastIndexOf(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(int)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "LastIndexOf", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "LastIndexOf", typeof(int), 1);
                            }
                            var ret = self.LastIndexOf(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(System.StringComparison)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "LastIndexOf", typeof(string), 0);
                            }
                            System.StringComparison arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "LastIndexOf", typeof(System.StringComparison), 1);
                            }
                            var ret = self.LastIndexOf(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(char)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            char arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "LastIndexOf", typeof(char), 0);
                            }
                            var ret = self.LastIndexOf(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "LastIndexOf", typeof(string), 0);
                            }
                            var ret = self.LastIndexOf(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
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
        public static JSValue Bind_LastIndexOfAny(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        char[] arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "LastIndexOfAny", typeof(char[]), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(string), "LastIndexOfAny", typeof(int), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(string), "LastIndexOfAny", typeof(int), 2);
                        }
                        var ret = self.LastIndexOfAny(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        char[] arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "LastIndexOfAny", typeof(char[]), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(string), "LastIndexOfAny", typeof(int), 1);
                        }
                        var ret = self.LastIndexOfAny(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        char[] arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "LastIndexOfAny", typeof(char[]), 0);
                        }
                        var ret = self.LastIndexOfAny(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("LastIndexOfAny", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_AsMemory(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        int arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.MemoryExtensions), "AsMemory", typeof(int), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.MemoryExtensions), "AsMemory", typeof(int), 1);
                        }
                        var ret = System.MemoryExtensions.AsMemory(self, arg0, arg1);
                        return Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(System.MemoryExtensions), "AsMemory", typeof(int), 0);
                            }
                            var ret = System.MemoryExtensions.AsMemory(self, arg0);
                            return Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Index)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            System.Index arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(System.MemoryExtensions), "AsMemory", typeof(System.Index), 0);
                            }
                            var ret = System.MemoryExtensions.AsMemory(self, arg0);
                            return Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Range)))
                        {
                            string self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            System.Range arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(System.MemoryExtensions), "AsMemory", typeof(System.Range), 0);
                            }
                            var ret = System.MemoryExtensions.AsMemory(self, arg0);
                            return Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc == 0)
                    {
                        string self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        var ret = System.MemoryExtensions.AsMemory(self);
                        return Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("AsMemory", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ArrayListFromJson(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    string self;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = UnityEngine.Purchasing.MiniJSON.MiniJsonExtensions.ArrayListFromJson(self);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("ArrayListFromJson", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_HashtableFromJson(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    string self;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = UnityEngine.Purchasing.MiniJSON.MiniJsonExtensions.HashtableFromJson(self);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("HashtableFromJson", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ToIntArray(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    string self;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = TMPro.TMPro_ExtensionMethods.ToIntArray(self);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("ToIntArray", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_VarName(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    string self;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = MobileConsole.StringExtension.VarName(self);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("VarName", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetReadableName(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    string self;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = MobileConsole.StringExtension.GetReadableName(self);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetReadableName", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        // [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        // public static JSValue Bind_ToNPath(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        // {
        //     try
        //     {
        //         if (argc == 0)
        //         {
        //             string self;
        //             if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
        //             {
        //                 throw new ThisBoundException();
        //             }
        //             var ret = NiceIO.Extensions.ToNPath(self);
        //             return Values.js_push_classvalue(ctx, ret);
        //         }
        //         throw new NoSuitableMethodException("ToNPath", argc);
        //     }
        //     catch (Exception exception)
        //     {
        //         return JSNative.ThrowException(ctx, exception);
        //     }
        // }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Compare(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 7)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(string)) && Values.js_match_type(ctx, argv[3], typeof(int)) && Values.js_match_type(ctx, argv[4], typeof(int)) && Values.js_match_type(ctx, argv[5], typeof(bool)) && Values.js_match_type(ctx, argv[6], typeof(System.Globalization.CultureInfo)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(int), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(string), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(int), 3);
                            }
                            int arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(int), 4);
                            }
                            bool arg5;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(bool), 5);
                            }
                            System.Globalization.CultureInfo arg6;
                            if (!Values.js_get_classvalue(ctx, argv[6], out arg6))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(System.Globalization.CultureInfo), 6);
                            }
                            var ret = string.Compare(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(string)) && Values.js_match_type(ctx, argv[3], typeof(int)) && Values.js_match_type(ctx, argv[4], typeof(int)) && Values.js_match_type(ctx, argv[5], typeof(System.Globalization.CultureInfo)) && Values.js_match_type(ctx, argv[6], typeof(System.Globalization.CompareOptions)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(int), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(string), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(int), 3);
                            }
                            int arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(int), 4);
                            }
                            System.Globalization.CultureInfo arg5;
                            if (!Values.js_get_classvalue(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(System.Globalization.CultureInfo), 5);
                            }
                            System.Globalization.CompareOptions arg6;
                            if (!Values.js_get_enumvalue(ctx, argv[6], out arg6))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(System.Globalization.CompareOptions), 6);
                            }
                            var ret = string.Compare(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 6)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(string)) && Values.js_match_type(ctx, argv[3], typeof(int)) && Values.js_match_type(ctx, argv[4], typeof(int)) && Values.js_match_type(ctx, argv[5], typeof(bool)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(int), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(string), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(int), 3);
                            }
                            int arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(int), 4);
                            }
                            bool arg5;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(bool), 5);
                            }
                            var ret = string.Compare(arg0, arg1, arg2, arg3, arg4, arg5);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(string)) && Values.js_match_type(ctx, argv[3], typeof(int)) && Values.js_match_type(ctx, argv[4], typeof(int)) && Values.js_match_type(ctx, argv[5], typeof(System.StringComparison)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(string), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(int), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(string), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(int), 3);
                            }
                            int arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(int), 4);
                            }
                            System.StringComparison arg5;
                            if (!Values.js_get_enumvalue(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(System.StringComparison), 5);
                            }
                            var ret = string.Compare(arg0, arg1, arg2, arg3, arg4, arg5);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 5)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "Compare", typeof(string), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(string), "Compare", typeof(int), 1);
                        }
                        string arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(string), "Compare", typeof(string), 2);
                        }
                        int arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(string), "Compare", typeof(int), 3);
                        }
                        int arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(string), "Compare", typeof(int), 4);
                        }
                        var ret = string.Compare(arg0, arg1, arg2, arg3, arg4);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(System.Globalization.CultureInfo)) && Values.js_match_type(ctx, argv[3], typeof(System.Globalization.CompareOptions)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(string), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(string), 1);
                            }
                            System.Globalization.CultureInfo arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(System.Globalization.CultureInfo), 2);
                            }
                            System.Globalization.CompareOptions arg3;
                            if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(System.Globalization.CompareOptions), 3);
                            }
                            var ret = string.Compare(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(bool)) && Values.js_match_type(ctx, argv[3], typeof(System.Globalization.CultureInfo)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(string), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(string), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(bool), 2);
                            }
                            System.Globalization.CultureInfo arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(System.Globalization.CultureInfo), 3);
                            }
                            var ret = string.Compare(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(bool)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(string), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(string), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(bool), 2);
                            }
                            var ret = string.Compare(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(System.StringComparison)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(string), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(string), 1);
                            }
                            System.StringComparison arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(string), "Compare", typeof(System.StringComparison), 2);
                            }
                            var ret = string.Compare(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "Compare", typeof(string), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(string), "Compare", typeof(string), 1);
                        }
                        var ret = string.Compare(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("Compare", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CompareOrdinal(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "CompareOrdinal", typeof(string), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(string), "CompareOrdinal", typeof(int), 1);
                        }
                        string arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(string), "CompareOrdinal", typeof(string), 2);
                        }
                        int arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(string), "CompareOrdinal", typeof(int), 3);
                        }
                        int arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(string), "CompareOrdinal", typeof(int), 4);
                        }
                        var ret = string.CompareOrdinal(arg0, arg1, arg2, arg3, arg4);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "CompareOrdinal", typeof(string), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(string), "CompareOrdinal", typeof(string), 1);
                        }
                        var ret = string.CompareOrdinal(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("CompareOrdinal", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Equals(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "Equals", typeof(string), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(string), "Equals", typeof(string), 1);
                        }
                        System.StringComparison arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(string), "Equals", typeof(System.StringComparison), 2);
                        }
                        var ret = string.Equals(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "Equals", typeof(string), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(string), "Equals", typeof(string), 1);
                        }
                        var ret = string.Equals(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
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
        public static JSValue BindStatic_op_Equality(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(string), "op_Equality", typeof(string), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(string), "op_Equality", typeof(string), 1);
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
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(string), "op_Inequality", typeof(string), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(string), "op_Inequality", typeof(string), 1);
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
        public static JSValue BindStatic_Copy(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(string), "Copy", typeof(string), 0);
                    }
                    var ret = string.Copy(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("Copy", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsNullOrEmpty(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(string), "IsNullOrEmpty", typeof(string), 0);
                    }
                    var ret = string.IsNullOrEmpty(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsNullOrEmpty", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsNullOrWhiteSpace(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(string), "IsNullOrWhiteSpace", typeof(string), 0);
                    }
                    var ret = string.IsNullOrWhiteSpace(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsNullOrWhiteSpace", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Concat(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(string)) && Values.js_match_type(ctx, argv[3], typeof(string)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Concat", typeof(string), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Concat", typeof(string), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(string), "Concat", typeof(string), 2);
                            }
                            string arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(string), "Concat", typeof(string), 3);
                            }
                            var ret = string.Concat(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(object)) && Values.js_match_type(ctx, argv[1], typeof(object)) && Values.js_match_type(ctx, argv[2], typeof(object)) && Values.js_match_type(ctx, argv[3], typeof(object)))
                        {
                            object arg0;
                            if (!Values.js_get_var(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Concat", typeof(object), 0);
                            }
                            object arg1;
                            if (!Values.js_get_var(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Concat", typeof(object), 1);
                            }
                            object arg2;
                            if (!Values.js_get_var(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(string), "Concat", typeof(object), 2);
                            }
                            object arg3;
                            if (!Values.js_get_var(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(string), "Concat", typeof(object), 3);
                            }
                            var ret = string.Concat(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(object)) && Values.js_match_type(ctx, argv[1], typeof(object)) && Values.js_match_type(ctx, argv[2], typeof(object)))
                        {
                            object arg0;
                            if (!Values.js_get_var(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Concat", typeof(object), 0);
                            }
                            object arg1;
                            if (!Values.js_get_var(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Concat", typeof(object), 1);
                            }
                            object arg2;
                            if (!Values.js_get_var(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(string), "Concat", typeof(object), 2);
                            }
                            var ret = string.Concat(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(string)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Concat", typeof(string), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Concat", typeof(string), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(string), "Concat", typeof(string), 2);
                            }
                            var ret = string.Concat(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(object)) && Values.js_match_type(ctx, argv[1], typeof(object)))
                        {
                            object arg0;
                            if (!Values.js_get_var(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Concat", typeof(object), 0);
                            }
                            object arg1;
                            if (!Values.js_get_var(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Concat", typeof(object), 1);
                            }
                            var ret = string.Concat(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(string)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Concat", typeof(string), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Concat", typeof(string), 1);
                            }
                            var ret = string.Concat(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(object)))
                        {
                            object arg0;
                            if (!Values.js_get_var(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Concat", typeof(object), 0);
                            }
                            var ret = string.Concat(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Collections.Generic.IEnumerable<string>)))
                        {
                            System.Collections.Generic.IEnumerable<string> arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Concat", typeof(System.Collections.Generic.IEnumerable<string>), 0);
                            }
                            var ret = string.Concat(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (Values.js_match_param_types(ctx, 0, argv, typeof(object)))
                    {
                        object[] arg0 = null;
                        if (argc > 0)
                        {
                            arg0 = new object[argc];
                            for (var i = 0; i < argc; i++)
                            {
                                Values.js_get_var(ctx, argv[i], out arg0[i]);
                            }
                        }
                        var ret = string.Concat(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (Values.js_match_param_types(ctx, 0, argv, typeof(string)))
                    {
                        string[] arg0 = null;
                        if (argc > 0)
                        {
                            arg0 = new string[argc];
                            for (var i = 0; i < argc; i++)
                            {
                                QuickJS.Binding.Values.js_get_primitive(ctx, argv[i], out arg0[i]);
                            }
                        }
                        var ret = string.Concat(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("Concat", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Format(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        System.IFormatProvider arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "Format", typeof(System.IFormatProvider), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(string), "Format", typeof(string), 1);
                        }
                        object arg2;
                        if (!Values.js_get_var(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(string), "Format", typeof(object), 2);
                        }
                        object arg3;
                        if (!Values.js_get_var(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(string), "Format", typeof(object), 3);
                        }
                        object arg4;
                        if (!Values.js_get_var(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(string), "Format", typeof(object), 4);
                        }
                        var ret = string.Format(arg0, arg1, arg2, arg3, arg4);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(object)) && Values.js_match_type(ctx, argv[2], typeof(object)) && Values.js_match_type(ctx, argv[3], typeof(object)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Format", typeof(string), 0);
                            }
                            object arg1;
                            if (!Values.js_get_var(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Format", typeof(object), 1);
                            }
                            object arg2;
                            if (!Values.js_get_var(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(string), "Format", typeof(object), 2);
                            }
                            object arg3;
                            if (!Values.js_get_var(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(string), "Format", typeof(object), 3);
                            }
                            var ret = string.Format(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(System.IFormatProvider)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(object)) && Values.js_match_type(ctx, argv[3], typeof(object)))
                        {
                            System.IFormatProvider arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Format", typeof(System.IFormatProvider), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Format", typeof(string), 1);
                            }
                            object arg2;
                            if (!Values.js_get_var(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(string), "Format", typeof(object), 2);
                            }
                            object arg3;
                            if (!Values.js_get_var(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(string), "Format", typeof(object), 3);
                            }
                            var ret = string.Format(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(object)) && Values.js_match_type(ctx, argv[2], typeof(object)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Format", typeof(string), 0);
                            }
                            object arg1;
                            if (!Values.js_get_var(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Format", typeof(object), 1);
                            }
                            object arg2;
                            if (!Values.js_get_var(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(string), "Format", typeof(object), 2);
                            }
                            var ret = string.Format(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(System.IFormatProvider)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(object)))
                        {
                            System.IFormatProvider arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Format", typeof(System.IFormatProvider), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Format", typeof(string), 1);
                            }
                            object arg2;
                            if (!Values.js_get_var(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(string), "Format", typeof(object), 2);
                            }
                            var ret = string.Format(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 2)
                    {
                        if (argc == 2)
                        {
                            if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(object)))
                            {
                                string arg0;
                                if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                                {
                                    throw new ParameterException(typeof(string), "Format", typeof(string), 0);
                                }
                                object arg1;
                                if (!Values.js_get_var(ctx, argv[1], out arg1))
                                {
                                    throw new ParameterException(typeof(string), "Format", typeof(object), 1);
                                }
                                var ret = string.Format(arg0, arg1);
                                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                            }
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(System.IFormatProvider)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_param_types(ctx, 2, argv, typeof(object)))
                        {
                            System.IFormatProvider arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Format", typeof(System.IFormatProvider), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Format", typeof(string), 1);
                            }
                            object[] arg2 = null;
                            if (argc - 2 > 0)
                            {
                                arg2 = new object[argc - 2];
                                for (var i = 2; i < argc; i++)
                                {
                                    Values.js_get_var(ctx, argv[i], out arg2[i - 2]);
                                }
                            }
                            var ret = string.Format(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_param_types(ctx, 1, argv, typeof(object)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Format", typeof(string), 0);
                            }
                            object[] arg1 = null;
                            if (argc - 1 > 0)
                            {
                                arg1 = new object[argc - 1];
                                for (var i = 1; i < argc; i++)
                                {
                                    Values.js_get_var(ctx, argv[i], out arg1[i - 1]);
                                }
                            }
                            var ret = string.Format(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Format", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Join(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(char)) && Values.js_match_type(ctx, argv[1], typeof(string[])) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(int)))
                        {
                            char arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Join", typeof(char), 0);
                            }
                            string[] arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Join", typeof(string[]), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(string), "Join", typeof(int), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(string), "Join", typeof(int), 3);
                            }
                            var ret = string.Join(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(string[])) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(int)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Join", typeof(string), 0);
                            }
                            string[] arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(string), "Join", typeof(string[]), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(string), "Join", typeof(int), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(string), "Join", typeof(int), 3);
                            }
                            var ret = string.Join(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(string), "Join", typeof(string), 0);
                        }
                        System.Collections.Generic.IEnumerable<string> arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(string), "Join", typeof(System.Collections.Generic.IEnumerable<string>), 1);
                        }
                        var ret = string.Join(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc >= 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(char)) && Values.js_match_param_types(ctx, 1, argv, typeof(string)))
                        {
                            char arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Join", typeof(char), 0);
                            }
                            string[] arg1 = null;
                            if (argc - 1 > 0)
                            {
                                arg1 = new string[argc - 1];
                                for (var i = 1; i < argc; i++)
                                {
                                    QuickJS.Binding.Values.js_get_primitive(ctx, argv[i], out arg1[i - 1]);
                                }
                            }
                            var ret = string.Join(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(char)) && Values.js_match_param_types(ctx, 1, argv, typeof(object)))
                        {
                            char arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Join", typeof(char), 0);
                            }
                            object[] arg1 = null;
                            if (argc - 1 > 0)
                            {
                                arg1 = new object[argc - 1];
                                for (var i = 1; i < argc; i++)
                                {
                                    Values.js_get_var(ctx, argv[i], out arg1[i - 1]);
                                }
                            }
                            var ret = string.Join(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_param_types(ctx, 1, argv, typeof(string)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Join", typeof(string), 0);
                            }
                            string[] arg1 = null;
                            if (argc - 1 > 0)
                            {
                                arg1 = new string[argc - 1];
                                for (var i = 1; i < argc; i++)
                                {
                                    QuickJS.Binding.Values.js_get_primitive(ctx, argv[i], out arg1[i - 1]);
                                }
                            }
                            var ret = string.Join(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_param_types(ctx, 1, argv, typeof(object)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(string), "Join", typeof(string), 0);
                            }
                            object[] arg1 = null;
                            if (argc - 1 > 0)
                            {
                                arg1 = new object[argc - 1];
                                for (var i = 1; i < argc; i++)
                                {
                                    Values.js_get_var(ctx, argv[i], out arg1[i - 1]);
                                }
                            }
                            var ret = string.Join(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Join", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Intern(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(string), "Intern", typeof(string), 0);
                    }
                    var ret = string.Intern(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("Intern", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsInterned(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(string), "IsInterned", typeof(string), 0);
                    }
                    var ret = string.IsInterned(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsInterned", argc);
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
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(string), "op_Equality", typeof(string), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(string), "op_Equality", typeof(string), 1);
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
        public static JSValue BindRead_Length(JSContext ctx, JSValue this_obj)
        {
            try
            {
                string self;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
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
        public static JSValue BindStaticRead_Empty(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = string.Empty;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("String", typeof(string), BindConstructor);
            cls.AddSelfOperator("==", BindStatic_op_Equality_qjs, 2);
            cls.AddMethod(false, "CompareTo", Bind_CompareTo);
            cls.AddMethod(false, "EndsWith", Bind_EndsWith);
            cls.AddMethod(false, "Equals", Bind_Equals);
            cls.AddMethod(false, "GetHashCode", Bind_GetHashCode);
            cls.AddMethod(false, "StartsWith", Bind_StartsWith);
            cls.AddMethod(false, "Clone", Bind_Clone);
            cls.AddMethod(false, "CopyTo", Bind_CopyTo);
            cls.AddMethod(false, "ToCharArray", Bind_ToCharArray);
            cls.AddMethod(false, "toString", Bind_ToString);
            cls.AddMethod(false, "GetEnumerator", Bind_GetEnumerator);
            cls.AddMethod(false, "GetTypeCode", Bind_GetTypeCode);
            cls.AddMethod(false, "IsNormalized", Bind_IsNormalized);
            cls.AddMethod(false, "Normalize", Bind_Normalize);
            cls.AddMethod(false, "Insert", Bind_Insert);
            cls.AddMethod(false, "PadLeft", Bind_PadLeft);
            cls.AddMethod(false, "PadRight", Bind_PadRight);
            cls.AddMethod(false, "Remove", Bind_Remove);
            cls.AddMethod(false, "Replace", Bind_Replace);
            cls.AddMethod(false, "Split", Bind_Split);
            cls.AddMethod(false, "Substring", Bind_Substring);
            cls.AddMethod(false, "ToLower", Bind_ToLower);
            cls.AddMethod(false, "ToLowerInvariant", Bind_ToLowerInvariant);
            cls.AddMethod(false, "ToUpper", Bind_ToUpper);
            cls.AddMethod(false, "ToUpperInvariant", Bind_ToUpperInvariant);
            cls.AddMethod(false, "Trim", Bind_Trim);
            cls.AddMethod(false, "TrimStart", Bind_TrimStart);
            cls.AddMethod(false, "TrimEnd", Bind_TrimEnd);
            cls.AddMethod(false, "Contains", Bind_Contains);
            cls.AddMethod(false, "IndexOf", Bind_IndexOf);
            cls.AddMethod(false, "IndexOfAny", Bind_IndexOfAny);
            cls.AddMethod(false, "LastIndexOf", Bind_LastIndexOf);
            cls.AddMethod(false, "LastIndexOfAny", Bind_LastIndexOfAny);
            cls.AddMethod(false, "AsMemory", Bind_AsMemory);
            cls.AddMethod(false, "ArrayListFromJson", Bind_ArrayListFromJson);
            cls.AddMethod(false, "HashtableFromJson", Bind_HashtableFromJson);
            cls.AddMethod(false, "ToIntArray", Bind_ToIntArray);
            cls.AddMethod(false, "VarName", Bind_VarName);
            cls.AddMethod(false, "GetReadableName", Bind_GetReadableName);
            // cls.AddMethod(false, "ToNPath", Bind_ToNPath);
            cls.AddMethod(true, "Compare", BindStatic_Compare);
            cls.AddMethod(true, "CompareOrdinal", BindStatic_CompareOrdinal);
            cls.AddMethod(true, "Equals", BindStatic_Equals);
            cls.AddMethod(true, "op_Equality", BindStatic_op_Equality);
            cls.AddMethod(true, "op_Inequality", BindStatic_op_Inequality);
            cls.AddMethod(true, "Copy", BindStatic_Copy);
            cls.AddMethod(true, "IsNullOrEmpty", BindStatic_IsNullOrEmpty);
            cls.AddMethod(true, "IsNullOrWhiteSpace", BindStatic_IsNullOrWhiteSpace);
            cls.AddMethod(true, "Concat", BindStatic_Concat);
            cls.AddMethod(true, "Format", BindStatic_Format);
            cls.AddMethod(true, "Join", BindStatic_Join);
            cls.AddMethod(true, "Intern", BindStatic_Intern);
            cls.AddMethod(true, "IsInterned", BindStatic_IsInterned);
            cls.AddProperty(false, "Length", BindRead_Length, null);
            cls.AddField(true, "Empty", BindStaticRead_Empty, null);
            return cls;
        }
    }
}
#endif
