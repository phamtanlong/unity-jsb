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
    // Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2019.4.40f1/Unity.app/Contents/Managed/UnityEngine/UnityEngine.CoreModule.dll
    // Type: UnityEngine.Hash128
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_Hash128
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        uint arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Hash128), ".ctor", typeof(uint), 0);
                        }
                        uint arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Hash128), ".ctor", typeof(uint), 1);
                        }
                        uint arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Hash128), ".ctor", typeof(uint), 2);
                        }
                        uint arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Hash128), ".ctor", typeof(uint), 3);
                        }
                        var o = new UnityEngine.Hash128(arg0, arg1, arg2, arg3);
                        var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                        return val;
                    }
                    if (argc == 2)
                    {
                        ulong arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Hash128), ".ctor", typeof(ulong), 0);
                        }
                        ulong arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Hash128), ".ctor", typeof(ulong), 1);
                        }
                        var o = new UnityEngine.Hash128(arg0, arg1);
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
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Hash128)))
                        {
                            UnityEngine.Hash128 self;
                            if (!Values.js_get_structvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEngine.Hash128 arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Hash128), "CompareTo", typeof(UnityEngine.Hash128), 0);
                            }
                            var ret = self.CompareTo(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(object)))
                        {
                            UnityEngine.Hash128 self;
                            if (!Values.js_get_structvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            object arg0;
                            if (!Values.js_get_var(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Hash128), "CompareTo", typeof(object), 0);
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
        public static JSValue Bind_ToString(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Hash128 self;
                    if (!Values.js_get_structvalue(ctx, this_obj, out self))
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
                            UnityEngine.Hash128 self;
                            if (!Values.js_get_structvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            object arg0;
                            if (!Values.js_get_var(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Hash128), "Equals", typeof(object), 0);
                            }
                            var ret = self.Equals(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Hash128)))
                        {
                            UnityEngine.Hash128 self;
                            if (!Values.js_get_structvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEngine.Hash128 arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.Hash128), "Equals", typeof(UnityEngine.Hash128), 0);
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
                    UnityEngine.Hash128 self;
                    if (!Values.js_get_structvalue(ctx, this_obj, out self))
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
        public static JSValue BindStatic_Parse(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Hash128), "Parse", typeof(string), 0);
                    }
                    var ret = UnityEngine.Hash128.Parse(arg0);
                    return Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("Parse", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Compute(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Hash128), "Compute", typeof(string), 0);
                    }
                    var ret = UnityEngine.Hash128.Compute(arg0);
                    return Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("Compute", argc);
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
                    UnityEngine.Hash128 arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Hash128), "op_Equality", typeof(UnityEngine.Hash128), 0);
                    }
                    UnityEngine.Hash128 arg1;
                    if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Hash128), "op_Equality", typeof(UnityEngine.Hash128), 1);
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
                    UnityEngine.Hash128 arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Hash128), "op_Inequality", typeof(UnityEngine.Hash128), 0);
                    }
                    UnityEngine.Hash128 arg1;
                    if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Hash128), "op_Inequality", typeof(UnityEngine.Hash128), 1);
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
        public static JSValue BindStatic_op_LessThan(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Hash128 arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Hash128), "op_LessThan", typeof(UnityEngine.Hash128), 0);
                    }
                    UnityEngine.Hash128 arg1;
                    if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Hash128), "op_LessThan", typeof(UnityEngine.Hash128), 1);
                    }
                    var ret = arg0 < arg1;
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("op_LessThan", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_op_GreaterThan(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Hash128 arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Hash128), "op_GreaterThan", typeof(UnityEngine.Hash128), 0);
                    }
                    UnityEngine.Hash128 arg1;
                    if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Hash128), "op_GreaterThan", typeof(UnityEngine.Hash128), 1);
                    }
                    var ret = arg0 > arg1;
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("op_GreaterThan", argc);
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
                    UnityEngine.Hash128 arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Hash128), "op_Equality", typeof(UnityEngine.Hash128), 0);
                    }
                    UnityEngine.Hash128 arg1;
                    if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Hash128), "op_Equality", typeof(UnityEngine.Hash128), 1);
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
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_op_LessThan_qjs(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Hash128 arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Hash128), "op_LessThan", typeof(UnityEngine.Hash128), 0);
                    }
                    UnityEngine.Hash128 arg1;
                    if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Hash128), "op_LessThan", typeof(UnityEngine.Hash128), 1);
                    }
                    var ret = arg0 < arg1;
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("<", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_isValid(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Hash128 self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.isValid;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("Hash128", typeof(UnityEngine.Hash128), BindConstructor);
            cls.AddSelfOperator("==", BindStatic_op_Equality_qjs, 2);
            cls.AddSelfOperator("<", BindStatic_op_LessThan_qjs, 2);
            cls.AddMethod(false, "CompareTo", Bind_CompareTo);
            cls.AddMethod(false, "toString", Bind_ToString);
            cls.AddMethod(false, "Equals", Bind_Equals);
            cls.AddMethod(false, "GetHashCode", Bind_GetHashCode);
            cls.AddMethod(true, "Parse", BindStatic_Parse);
            cls.AddMethod(true, "Compute", BindStatic_Compute);
            cls.AddMethod(true, "op_Equality", BindStatic_op_Equality);
            cls.AddMethod(true, "op_Inequality", BindStatic_op_Inequality);
            cls.AddMethod(true, "op_LessThan", BindStatic_op_LessThan);
            cls.AddMethod(true, "op_GreaterThan", BindStatic_op_GreaterThan);
            cls.AddProperty(false, "isValid", BindRead_isValid, null);
            return cls;
        }
    }
}
#endif
#endif
