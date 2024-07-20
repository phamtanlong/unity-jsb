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
    // Type: System.Delegate
    [JSBindingAttribute]
    public class QuickJS_System_Delegate
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DynamicInvoke(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (Values.js_match_param_types(ctx, 0, argv, typeof(object)))
                {
                    System.Delegate self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    object[] arg0 = null;
                    if (argc > 0)
                    {
                        arg0 = new object[argc];
                        for (var i = 0; i < argc; i++)
                        {
                            Values.js_get_var(ctx, argv[i], out arg0[i]);
                        }
                    }
                    var ret = self.DynamicInvoke(arg0);
                    return QuickJS.Binding.Values.js_push_object(ctx, ret);
                }
                throw new NoSuitableMethodException("DynamicInvoke", argc);
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
                    System.Delegate self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
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
        public static JSValue Bind_Equals(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    System.Delegate self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    object arg0;
                    if (!Values.js_get_var(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.Delegate), "Equals", typeof(object), 0);
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
                    System.Delegate self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
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
        public static JSValue Bind_GetObjectData(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    System.Delegate self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    System.Runtime.Serialization.SerializationInfo arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.Delegate), "GetObjectData", typeof(System.Runtime.Serialization.SerializationInfo), 0);
                    }
                    System.Runtime.Serialization.StreamingContext arg1;
                    if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(System.Delegate), "GetObjectData", typeof(System.Runtime.Serialization.StreamingContext), 1);
                    }
                    self.GetObjectData(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("GetObjectData", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetInvocationList(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    System.Delegate self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.GetInvocationList();
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetInvocationList", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetMethodInfo(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    System.Delegate self;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = System.Reflection.RuntimeReflectionExtensions.GetMethodInfo(self);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetMethodInfo", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Combine(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        System.Delegate arg0;
                        if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.Delegate), "Combine", typeof(System.Delegate), 0);
                        }
                        System.Delegate arg1;
                        if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.Delegate), "Combine", typeof(System.Delegate), 1);
                        }
                        var ret = System.Delegate.Combine(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_delegate(ctx, ret);
                    }
                    if (Values.js_match_param_types(ctx, 0, argv, typeof(System.Delegate)))
                    {
                        System.Delegate[] arg0 = null;
                        if (argc > 0)
                        {
                            arg0 = new System.Delegate[argc];
                            for (var i = 0; i < argc; i++)
                            {
                                QuickJS.Binding.Values.js_get_classvalue(ctx, argv[i], out arg0[i]);
                            }
                        }
                        var ret = System.Delegate.Combine(arg0);
                        return QuickJS.Binding.Values.js_push_delegate(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("Combine", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Remove(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    System.Delegate arg0;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.Delegate), "Remove", typeof(System.Delegate), 0);
                    }
                    System.Delegate arg1;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(System.Delegate), "Remove", typeof(System.Delegate), 1);
                    }
                    var ret = System.Delegate.Remove(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_delegate(ctx, ret);
                }
                throw new NoSuitableMethodException("Remove", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RemoveAll(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    System.Delegate arg0;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.Delegate), "RemoveAll", typeof(System.Delegate), 0);
                    }
                    System.Delegate arg1;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(System.Delegate), "RemoveAll", typeof(System.Delegate), 1);
                    }
                    var ret = System.Delegate.RemoveAll(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_delegate(ctx, ret);
                }
                throw new NoSuitableMethodException("RemoveAll", argc);
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
                    System.Delegate arg0;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.Delegate), "op_Equality", typeof(System.Delegate), 0);
                    }
                    System.Delegate arg1;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(System.Delegate), "op_Equality", typeof(System.Delegate), 1);
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
                    System.Delegate arg0;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.Delegate), "op_Inequality", typeof(System.Delegate), 0);
                    }
                    System.Delegate arg1;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(System.Delegate), "op_Inequality", typeof(System.Delegate), 1);
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
        public static JSValue BindStatic_op_Equality_qjs(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    System.Delegate arg0;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.Delegate), "op_Equality", typeof(System.Delegate), 0);
                    }
                    System.Delegate arg1;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(System.Delegate), "op_Equality", typeof(System.Delegate), 1);
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
        public static JSValue BindRead_Method(JSContext ctx, JSValue this_obj)
        {
            try
            {
                System.Delegate self;
                if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.Method;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_Target(JSContext ctx, JSValue this_obj)
        {
            try
            {
                System.Delegate self;
                if (!QuickJS.Binding.Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.Target;
                return QuickJS.Binding.Values.js_push_object(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("Delegate", typeof(System.Delegate), QuickJS.JSNative.class_private_ctor);
            cls.AddSelfOperator("==", BindStatic_op_Equality_qjs, 2);
            cls.AddMethod(false, "DynamicInvoke", Bind_DynamicInvoke);
            cls.AddMethod(false, "Clone", Bind_Clone);
            cls.AddMethod(false, "Equals", Bind_Equals);
            cls.AddMethod(false, "GetHashCode", Bind_GetHashCode);
            cls.AddMethod(false, "GetObjectData", Bind_GetObjectData);
            cls.AddMethod(false, "GetInvocationList", Bind_GetInvocationList);
            cls.AddMethod(false, "GetMethodInfo", Bind_GetMethodInfo);
            cls.AddMethod(true, "Combine", BindStatic_Combine);
            cls.AddMethod(true, "Remove", BindStatic_Remove);
            cls.AddMethod(true, "RemoveAll", BindStatic_RemoveAll);
            cls.AddMethod(true, "op_Equality", BindStatic_op_Equality);
            cls.AddMethod(true, "op_Inequality", BindStatic_op_Inequality);
            cls.AddProperty(false, "Method", BindRead_Method, null);
            cls.AddProperty(false, "Target", BindRead_Target, null);
            return cls;
        }
    }
}
#endif
