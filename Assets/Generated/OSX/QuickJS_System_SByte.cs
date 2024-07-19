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
    // Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
    // Location: /Applications/Unity/Hub/Editor/2019.4.40f1/Unity.app/Contents/MonoBleedingEdge/lib/mono/unityjit/mscorlib.dll
    // Type: System.SByte
    [JSBindingAttribute]
    public class QuickJS_System_SByte
    {
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
                            sbyte self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            object arg0;
                            if (!Values.js_get_var(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(sbyte), "CompareTo", typeof(object), 0);
                            }
                            var ret = self.CompareTo(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(sbyte)))
                        {
                            sbyte self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            sbyte arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(sbyte), "CompareTo", typeof(sbyte), 0);
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
                            sbyte self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            object arg0;
                            if (!Values.js_get_var(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(sbyte), "Equals", typeof(object), 0);
                            }
                            var ret = self.Equals(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(sbyte)))
                        {
                            sbyte self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            sbyte arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(sbyte), "Equals", typeof(sbyte), 0);
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
                if (argc == 0)
                {
                    sbyte self;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
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
        public static JSValue Bind_ToString(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        sbyte self;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(sbyte), "ToString", typeof(string), 0);
                        }
                        System.IFormatProvider arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(sbyte), "ToString", typeof(System.IFormatProvider), 1);
                        }
                        var ret = self.ToString(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(System.IFormatProvider)))
                        {
                            sbyte self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            System.IFormatProvider arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(sbyte), "ToString", typeof(System.IFormatProvider), 0);
                            }
                            var ret = self.ToString(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            sbyte self;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(sbyte), "ToString", typeof(string), 0);
                            }
                            var ret = self.ToString(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 0)
                    {
                        sbyte self;
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
        public static JSValue Bind_GetTypeCode(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    sbyte self;
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
        public static JSValue BindStatic_Parse(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(sbyte), "Parse", typeof(string), 0);
                        }
                        System.Globalization.NumberStyles arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(sbyte), "Parse", typeof(System.Globalization.NumberStyles), 1);
                        }
                        System.IFormatProvider arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(sbyte), "Parse", typeof(System.IFormatProvider), 2);
                        }
                        var ret = sbyte.Parse(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(System.Globalization.NumberStyles)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(sbyte), "Parse", typeof(string), 0);
                            }
                            System.Globalization.NumberStyles arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(sbyte), "Parse", typeof(System.Globalization.NumberStyles), 1);
                            }
                            var ret = sbyte.Parse(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(System.IFormatProvider)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(sbyte), "Parse", typeof(string), 0);
                            }
                            System.IFormatProvider arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(sbyte), "Parse", typeof(System.IFormatProvider), 1);
                            }
                            var ret = sbyte.Parse(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 1)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(sbyte), "Parse", typeof(string), 0);
                        }
                        var ret = sbyte.Parse(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("Parse", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_TryParse(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(sbyte), "TryParse", typeof(string), 0);
                        }
                        System.Globalization.NumberStyles arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(sbyte), "TryParse", typeof(System.Globalization.NumberStyles), 1);
                        }
                        System.IFormatProvider arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(sbyte), "TryParse", typeof(System.IFormatProvider), 2);
                        }
                        sbyte arg3;
                        var ret = sbyte.TryParse(arg0, arg1, arg2, out arg3);
                        var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg3);
                        if (JSApi.JS_IsException(out0))
                        {
                            return out0;
                        }
                        var context = ScriptEngine.GetContext(ctx);
                        JSApi.JS_SetProperty(ctx, argv[3], context.GetAtom("value"), out0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(sbyte), "TryParse", typeof(string), 0);
                        }
                        sbyte arg1;
                        var ret = sbyte.TryParse(arg0, out arg1);
                        var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg1);
                        if (JSApi.JS_IsException(out0))
                        {
                            return out0;
                        }
                        var context = ScriptEngine.GetContext(ctx);
                        JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("TryParse", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("SByte", typeof(sbyte), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(false, "CompareTo", Bind_CompareTo);
            cls.AddMethod(false, "Equals", Bind_Equals);
            cls.AddMethod(false, "GetHashCode", Bind_GetHashCode);
            cls.AddMethod(false, "toString", Bind_ToString);
            cls.AddMethod(false, "GetTypeCode", Bind_GetTypeCode);
            cls.AddMethod(true, "Parse", BindStatic_Parse);
            cls.AddMethod(true, "TryParse", BindStatic_TryParse);
            cls.AddConstValue("MaxValue", 127);
            cls.AddConstValue("MinValue", -128);
            return cls;
        }
    }
}
#endif
