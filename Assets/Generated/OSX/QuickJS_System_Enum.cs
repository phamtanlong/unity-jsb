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
    // Type: System.Enum
    [JSBindingAttribute]
    public class QuickJS_System_Enum
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Equals(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    System.Enum self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    object arg0;
                    if (!Values.js_get_var(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.Enum), "Equals", typeof(object), 0);
                    }
                    var ret = self.Equals(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
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
                    System.Enum self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
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
                    if (argc == 1)
                    {
                        System.Enum self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.Enum), "ToString", typeof(string), 0);
                        }
                        var ret = self.ToString(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 0)
                    {
                        System.Enum self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
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
        public static JSValue Bind_CompareTo(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    System.Enum self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    object arg0;
                    if (!Values.js_get_var(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.Enum), "CompareTo", typeof(object), 0);
                    }
                    var ret = self.CompareTo(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("CompareTo", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_HasFlag(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    System.Enum self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    System.Enum arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.Enum), "HasFlag", typeof(System.Enum), 0);
                    }
                    var ret = self.HasFlag(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("HasFlag", argc);
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
                    System.Enum self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
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
                        System.Type arg0;
                        if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.Enum), "Parse", typeof(System.Type), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.Enum), "Parse", typeof(string), 1);
                        }
                        bool arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(System.Enum), "Parse", typeof(bool), 2);
                        }
                        var ret = System.Enum.Parse(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_object(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        System.Type arg0;
                        if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.Enum), "Parse", typeof(System.Type), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.Enum), "Parse", typeof(string), 1);
                        }
                        var ret = System.Enum.Parse(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_object(ctx, ret);
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
        public static JSValue BindStatic_GetUnderlyingType(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    System.Type arg0;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.Enum), "GetUnderlyingType", typeof(System.Type), 0);
                    }
                    var ret = System.Enum.GetUnderlyingType(arg0);
                    return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetUnderlyingType", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetValues(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    System.Type arg0;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.Enum), "GetValues", typeof(System.Type), 0);
                    }
                    var ret = System.Enum.GetValues(arg0);
                    return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetValues", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetName(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    System.Type arg0;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.Enum), "GetName", typeof(System.Type), 0);
                    }
                    object arg1;
                    if (!Values.js_get_var(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(System.Enum), "GetName", typeof(object), 1);
                    }
                    var ret = System.Enum.GetName(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetName", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetNames(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    System.Type arg0;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.Enum), "GetNames", typeof(System.Type), 0);
                    }
                    var ret = System.Enum.GetNames(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetNames", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ToObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Type)) && Values.js_match_type(ctx, argv[1], typeof(object)))
                        {
                            System.Type arg0;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(System.Enum), "ToObject", typeof(System.Type), 0);
                            }
                            object arg1;
                            if (!Values.js_get_var(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(System.Enum), "ToObject", typeof(object), 1);
                            }
                            var ret = System.Enum.ToObject(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_object(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Type)) && Values.js_match_type(ctx, argv[1], typeof(sbyte)))
                        {
                            System.Type arg0;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(System.Enum), "ToObject", typeof(System.Type), 0);
                            }
                            sbyte arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(System.Enum), "ToObject", typeof(sbyte), 1);
                            }
                            var ret = System.Enum.ToObject(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_object(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Type)) && Values.js_match_type(ctx, argv[1], typeof(short)))
                        {
                            System.Type arg0;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(System.Enum), "ToObject", typeof(System.Type), 0);
                            }
                            short arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(System.Enum), "ToObject", typeof(short), 1);
                            }
                            var ret = System.Enum.ToObject(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_object(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Type)) && Values.js_match_type(ctx, argv[1], typeof(int)))
                        {
                            System.Type arg0;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(System.Enum), "ToObject", typeof(System.Type), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(System.Enum), "ToObject", typeof(int), 1);
                            }
                            var ret = System.Enum.ToObject(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_object(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Type)) && Values.js_match_type(ctx, argv[1], typeof(byte)))
                        {
                            System.Type arg0;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(System.Enum), "ToObject", typeof(System.Type), 0);
                            }
                            byte arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(System.Enum), "ToObject", typeof(byte), 1);
                            }
                            var ret = System.Enum.ToObject(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_object(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Type)) && Values.js_match_type(ctx, argv[1], typeof(ushort)))
                        {
                            System.Type arg0;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(System.Enum), "ToObject", typeof(System.Type), 0);
                            }
                            ushort arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(System.Enum), "ToObject", typeof(ushort), 1);
                            }
                            var ret = System.Enum.ToObject(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_object(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Type)) && Values.js_match_type(ctx, argv[1], typeof(uint)))
                        {
                            System.Type arg0;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(System.Enum), "ToObject", typeof(System.Type), 0);
                            }
                            uint arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(System.Enum), "ToObject", typeof(uint), 1);
                            }
                            var ret = System.Enum.ToObject(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_object(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Type)) && Values.js_match_type(ctx, argv[1], typeof(long)))
                        {
                            System.Type arg0;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(System.Enum), "ToObject", typeof(System.Type), 0);
                            }
                            long arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(System.Enum), "ToObject", typeof(long), 1);
                            }
                            var ret = System.Enum.ToObject(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_object(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Type)) && Values.js_match_type(ctx, argv[1], typeof(ulong)))
                        {
                            System.Type arg0;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(System.Enum), "ToObject", typeof(System.Type), 0);
                            }
                            ulong arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(System.Enum), "ToObject", typeof(ulong), 1);
                            }
                            var ret = System.Enum.ToObject(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_object(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("ToObject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsDefined(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    System.Type arg0;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.Enum), "IsDefined", typeof(System.Type), 0);
                    }
                    object arg1;
                    if (!Values.js_get_var(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(System.Enum), "IsDefined", typeof(object), 1);
                    }
                    var ret = System.Enum.IsDefined(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsDefined", argc);
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
                if (argc == 3)
                {
                    System.Type arg0;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.Enum), "Format", typeof(System.Type), 0);
                    }
                    object arg1;
                    if (!Values.js_get_var(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(System.Enum), "Format", typeof(object), 1);
                    }
                    string arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(System.Enum), "Format", typeof(string), 2);
                    }
                    var ret = System.Enum.Format(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("Format", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("Enum", typeof(System.Enum), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(false, "Equals", Bind_Equals);
            cls.AddMethod(false, "GetHashCode", Bind_GetHashCode);
            cls.AddMethod(false, "toString", Bind_ToString);
            cls.AddMethod(false, "CompareTo", Bind_CompareTo);
            cls.AddMethod(false, "HasFlag", Bind_HasFlag);
            cls.AddMethod(false, "GetTypeCode", Bind_GetTypeCode);
            cls.AddMethod(true, "Parse", BindStatic_Parse);
            cls.AddMethod(true, "GetUnderlyingType", BindStatic_GetUnderlyingType);
            cls.AddMethod(true, "GetValues", BindStatic_GetValues);
            cls.AddMethod(true, "GetName", BindStatic_GetName);
            cls.AddMethod(true, "GetNames", BindStatic_GetNames);
            cls.AddMethod(true, "ToObject", BindStatic_ToObject);
            cls.AddMethod(true, "IsDefined", BindStatic_IsDefined);
            cls.AddMethod(true, "Format", BindStatic_Format);
            return cls;
        }
    }
}
#endif
