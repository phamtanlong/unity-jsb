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
    // Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Users/longpt/Documents/SkyMavis/unity-jsb-2/Library/ScriptAssemblies/Assembly-CSharp.dll
    // Type: Example.DelegateTest
    [JSBindingAttribute]
    public class QuickJS_Example_DelegateTest
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new Example.DelegateTest();
                    var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
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
        public static JSValue Bind_TestComplexCall(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    Example.DelegateTest self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.TestComplexCall();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("TestComplexCall", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_AddAction(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    Example.DelegateTest self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.AddAction();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("AddAction", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DipatchEvent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    Example.DelegateTest self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(Example.DelegateTest), "DipatchEvent", typeof(int), 0);
                    }
                    self.DipatchEvent(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DipatchEvent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_CallAction(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    Example.DelegateTest self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.CallAction();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CallAction", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_CallActionWithArgs(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    Example.DelegateTest self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(Example.DelegateTest), "CallActionWithArgs", typeof(string), 0);
                    }
                    float arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(Example.DelegateTest), "CallActionWithArgs", typeof(float), 1);
                    }
                    int arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(Example.DelegateTest), "CallActionWithArgs", typeof(int), 2);
                    }
                    self.CallActionWithArgs(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CallActionWithArgs", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_CallFunc(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    Example.DelegateTest self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(Example.DelegateTest), "CallFunc", typeof(int), 0);
                    }
                    var ret = self.CallFunc(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("CallFunc", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DipatchStaticEvent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(Example.DelegateTest), "DipatchStaticEvent", typeof(int), 0);
                    }
                    Example.DelegateTest.DipatchStaticEvent(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DipatchStaticEvent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_UseDelegateInParameter(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    System.Action arg0;
                    if (!Values.js_get_delegate(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(Example.DelegateTest), "UseDelegateInParameter", typeof(System.Action), 0);
                    }
                    Example.DelegateTest.UseDelegateInParameter(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("UseDelegateInParameter", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetNotExportedClass(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = Example.DelegateTest.GetNotExportedClass();
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetNotExportedClass", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CallStaticActionWithArgs(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(Example.DelegateTest), "CallStaticActionWithArgs", typeof(string), 0);
                    }
                    float arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(Example.DelegateTest), "CallStaticActionWithArgs", typeof(float), 1);
                    }
                    int arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(Example.DelegateTest), "CallStaticActionWithArgs", typeof(int), 2);
                    }
                    Example.DelegateTest.CallStaticActionWithArgs(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CallStaticActionWithArgs", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CallHotfixTest(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    Example.DelegateTest.CallHotfixTest();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CallHotfixTest", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetArray(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = Example.DelegateTest.GetArray();
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetArray", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindEvent_onEvent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                Example.DelegateTest self;
                Values.js_get_classvalue(ctx, this_obj, out self);
                System.Action<int> value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "onEvent", typeof(System.Action<int>), 1);
                        }
                        self.onEvent += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "onEvent", typeof(System.Action<int>), 1);
                        }
                        self.onEvent -= value;
                        break;
                    default: throw new JSException("invalid event op");
                }
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_onStaticEvent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                System.Action<int> value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "onStaticEvent", typeof(System.Action<int>), 1);
                        }
                        Example.DelegateTest.onStaticEvent += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "onStaticEvent", typeof(System.Action<int>), 1);
                        }
                        Example.DelegateTest.onStaticEvent -= value;
                        break;
                    default: throw new JSException("invalid event op");
                }
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindDelegate_complexCall(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                Example.DelegateTest self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                    {
                        Example.WithByRefParametersCallback value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "complexCall", typeof(Example.WithByRefParametersCallback), 1);
                        }
                        self.complexCall += value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_REMOVE:
                    {
                        Example.WithByRefParametersCallback value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "complexCall", typeof(Example.WithByRefParametersCallback), 1);
                        }
                        self.complexCall -= value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_SET:
                    {
                        Example.WithByRefParametersCallback value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "complexCall", typeof(Example.WithByRefParametersCallback), 1);
                        }
                        self.complexCall = value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_GET:
                    {
                        var ret = self.complexCall;
                        return Values.js_push_delegate(ctx, ret);
                    }
                    default: throw new JSException("invalid event op");
                }
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindDelegate_complexCall2(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                Example.DelegateTest self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                    {
                        Example.WithByRefParametersCallback2 value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "complexCall2", typeof(Example.WithByRefParametersCallback2), 1);
                        }
                        self.complexCall2 += value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_REMOVE:
                    {
                        Example.WithByRefParametersCallback2 value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "complexCall2", typeof(Example.WithByRefParametersCallback2), 1);
                        }
                        self.complexCall2 -= value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_SET:
                    {
                        Example.WithByRefParametersCallback2 value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "complexCall2", typeof(Example.WithByRefParametersCallback2), 1);
                        }
                        self.complexCall2 = value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_GET:
                    {
                        var ret = self.complexCall2;
                        return Values.js_push_delegate(ctx, ret);
                    }
                    default: throw new JSException("invalid event op");
                }
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindDelegate_actionFieldRW(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                Example.DelegateTest self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                    {
                        System.Action value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "actionFieldRW", typeof(System.Action), 1);
                        }
                        self.actionFieldRW += value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_REMOVE:
                    {
                        System.Action value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "actionFieldRW", typeof(System.Action), 1);
                        }
                        self.actionFieldRW -= value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_SET:
                    {
                        System.Action value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "actionFieldRW", typeof(System.Action), 1);
                        }
                        self.actionFieldRW = value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_GET:
                    {
                        var ret = self.actionFieldRW;
                        return Values.js_push_delegate(ctx, ret);
                    }
                    default: throw new JSException("invalid event op");
                }
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindDelegate_actionFieldR(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                Example.DelegateTest self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                switch(op)
                {
                    case Values.EVT_OP_GET:
                    {
                        var ret = self.actionFieldR;
                        return Values.js_push_delegate(ctx, ret);
                    }
                    default: throw new JSException("invalid event op");
                }
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticDelegate_actionFieldRW_s(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                    {
                        System.Action value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "actionFieldRW_s", typeof(System.Action), 1);
                        }
                        Example.DelegateTest.actionFieldRW_s += value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_REMOVE:
                    {
                        System.Action value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "actionFieldRW_s", typeof(System.Action), 1);
                        }
                        Example.DelegateTest.actionFieldRW_s -= value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_SET:
                    {
                        System.Action value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "actionFieldRW_s", typeof(System.Action), 1);
                        }
                        Example.DelegateTest.actionFieldRW_s = value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_GET:
                    {
                        var ret = Example.DelegateTest.actionFieldRW_s;
                        return Values.js_push_delegate(ctx, ret);
                    }
                    default: throw new JSException("invalid event op");
                }
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticDelegate_actionFieldR_s(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                switch(op)
                {
                    case Values.EVT_OP_GET:
                    {
                        var ret = Example.DelegateTest.actionFieldR_s;
                        return Values.js_push_delegate(ctx, ret);
                    }
                    default: throw new JSException("invalid event op");
                }
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindDelegate_onAction(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                Example.DelegateTest self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                    {
                        System.Action value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "onAction", typeof(System.Action), 1);
                        }
                        self.onAction += value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_REMOVE:
                    {
                        System.Action value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "onAction", typeof(System.Action), 1);
                        }
                        self.onAction -= value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_SET:
                    {
                        System.Action value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "onAction", typeof(System.Action), 1);
                        }
                        self.onAction = value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_GET:
                    {
                        var ret = self.onAction;
                        return Values.js_push_delegate(ctx, ret);
                    }
                    default: throw new JSException("invalid event op");
                }
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindDelegate_onActionWithArgs(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                Example.DelegateTest self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                    {
                        System.Action<string, float, int> value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "onActionWithArgs", typeof(System.Action<string, float, int>), 1);
                        }
                        self.onActionWithArgs += value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_REMOVE:
                    {
                        System.Action<string, float, int> value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "onActionWithArgs", typeof(System.Action<string, float, int>), 1);
                        }
                        self.onActionWithArgs -= value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_SET:
                    {
                        System.Action<string, float, int> value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "onActionWithArgs", typeof(System.Action<string, float, int>), 1);
                        }
                        self.onActionWithArgs = value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_GET:
                    {
                        var ret = self.onActionWithArgs;
                        return Values.js_push_delegate(ctx, ret);
                    }
                    default: throw new JSException("invalid event op");
                }
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticDelegate_onStaticActionWithArgs(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                    {
                        System.Action<string, float, int> value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "onStaticActionWithArgs", typeof(System.Action<string, float, int>), 1);
                        }
                        Example.DelegateTest.onStaticActionWithArgs += value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_REMOVE:
                    {
                        System.Action<string, float, int> value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "onStaticActionWithArgs", typeof(System.Action<string, float, int>), 1);
                        }
                        Example.DelegateTest.onStaticActionWithArgs -= value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_SET:
                    {
                        System.Action<string, float, int> value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "onStaticActionWithArgs", typeof(System.Action<string, float, int>), 1);
                        }
                        Example.DelegateTest.onStaticActionWithArgs = value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_GET:
                    {
                        var ret = Example.DelegateTest.onStaticActionWithArgs;
                        return Values.js_push_delegate(ctx, ret);
                    }
                    default: throw new JSException("invalid event op");
                }
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindDelegate_onFunc(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                Example.DelegateTest self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                    {
                        System.Func<int, int> value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "onFunc", typeof(System.Func<int, int>), 1);
                        }
                        self.onFunc += value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_REMOVE:
                    {
                        System.Func<int, int> value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "onFunc", typeof(System.Func<int, int>), 1);
                        }
                        self.onFunc -= value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_SET:
                    {
                        System.Func<int, int> value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "onFunc", typeof(System.Func<int, int>), 1);
                        }
                        self.onFunc = value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_GET:
                    {
                        var ret = self.onFunc;
                        return Values.js_push_delegate(ctx, ret);
                    }
                    default: throw new JSException("invalid event op");
                }
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindDelegate_actionPropG(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                Example.DelegateTest self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                switch(op)
                {
                    case Values.EVT_OP_GET:
                    {
                        var ret = self.actionPropG;
                        return Values.js_push_delegate(ctx, ret);
                    }
                    default: throw new JSException("invalid event op");
                }
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindDelegate_actionPropS(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                Example.DelegateTest self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                switch(op)
                {
                    case Values.EVT_OP_SET:
                    {
                        System.Action value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "actionPropS", typeof(System.Action), 1);
                        }
                        self.actionPropS = value;
                        return JSApi.JS_UNDEFINED;
                    }
                    default: throw new JSException("invalid event op");
                }
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindDelegate_actionPropGS(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                Example.DelegateTest self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                    {
                        System.Action value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "actionPropGS", typeof(System.Action), 1);
                        }
                        self.actionPropGS += value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_REMOVE:
                    {
                        System.Action value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "actionPropGS", typeof(System.Action), 1);
                        }
                        self.actionPropGS -= value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_SET:
                    {
                        System.Action value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "actionPropGS", typeof(System.Action), 1);
                        }
                        self.actionPropGS = value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_GET:
                    {
                        var ret = self.actionPropGS;
                        return Values.js_push_delegate(ctx, ret);
                    }
                    default: throw new JSException("invalid event op");
                }
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticDelegate_actionPropG_s(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                switch(op)
                {
                    case Values.EVT_OP_GET:
                    {
                        var ret = Example.DelegateTest.actionPropG_s;
                        return Values.js_push_delegate(ctx, ret);
                    }
                    default: throw new JSException("invalid event op");
                }
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticDelegate_actionPropS_s(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                switch(op)
                {
                    case Values.EVT_OP_SET:
                    {
                        System.Action value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "actionPropS_s", typeof(System.Action), 1);
                        }
                        Example.DelegateTest.actionPropS_s = value;
                        return JSApi.JS_UNDEFINED;
                    }
                    default: throw new JSException("invalid event op");
                }
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticDelegate_actionPropGS_s(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                    {
                        System.Action value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "actionPropGS_s", typeof(System.Action), 1);
                        }
                        Example.DelegateTest.actionPropGS_s += value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_REMOVE:
                    {
                        System.Action value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "actionPropGS_s", typeof(System.Action), 1);
                        }
                        Example.DelegateTest.actionPropGS_s -= value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_SET:
                    {
                        System.Action value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(Example.DelegateTest), "actionPropGS_s", typeof(System.Action), 1);
                        }
                        Example.DelegateTest.actionPropGS_s = value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_GET:
                    {
                        var ret = Example.DelegateTest.actionPropGS_s;
                        return Values.js_push_delegate(ctx, ret);
                    }
                    default: throw new JSException("invalid event op");
                }
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("DelegateTest", typeof(Example.DelegateTest), BindConstructor);
            cls.AddMethod(false, "TestComplexCall", Bind_TestComplexCall);
            cls.AddMethod(false, "AddAction", Bind_AddAction);
            cls.AddMethod(false, "DipatchEvent", Bind_DipatchEvent);
            cls.AddMethod(false, "CallAction", Bind_CallAction);
            cls.AddMethod(false, "CallActionWithArgs", Bind_CallActionWithArgs);
            cls.AddMethod(false, "CallFunc", Bind_CallFunc);
            cls.AddMethod(true, "DipatchStaticEvent", BindStatic_DipatchStaticEvent);
            cls.AddMethod(true, "UseDelegateInParameter", BindStatic_UseDelegateInParameter);
            cls.AddMethod(true, "GetNotExportedClass", BindStatic_GetNotExportedClass);
            cls.AddMethod(true, "CallStaticActionWithArgs", BindStatic_CallStaticActionWithArgs);
            cls.AddMethod(true, "CallHotfixTest", BindStatic_CallHotfixTest);
            cls.AddMethod(true, "GetArray", BindStatic_GetArray);
            cls.AddMethod(false, "onEvent", BindEvent_onEvent);
            cls.AddMethod(true, "onStaticEvent", BindStaticEvent_onStaticEvent);
            cls.AddMethod(false, "complexCall", BindDelegate_complexCall);
            cls.AddMethod(false, "complexCall2", BindDelegate_complexCall2);
            cls.AddMethod(false, "actionFieldRW", BindDelegate_actionFieldRW);
            cls.AddMethod(false, "actionFieldR", BindDelegate_actionFieldR);
            cls.AddMethod(true, "actionFieldRW_s", BindStaticDelegate_actionFieldRW_s);
            cls.AddMethod(true, "actionFieldR_s", BindStaticDelegate_actionFieldR_s);
            cls.AddMethod(false, "onAction", BindDelegate_onAction);
            cls.AddMethod(false, "onActionWithArgs", BindDelegate_onActionWithArgs);
            cls.AddMethod(true, "onStaticActionWithArgs", BindStaticDelegate_onStaticActionWithArgs);
            cls.AddMethod(false, "onFunc", BindDelegate_onFunc);
            cls.AddMethod(false, "actionPropG", BindDelegate_actionPropG);
            cls.AddMethod(false, "actionPropS", BindDelegate_actionPropS);
            cls.AddMethod(false, "actionPropGS", BindDelegate_actionPropGS);
            cls.AddMethod(true, "actionPropG_s", BindStaticDelegate_actionPropG_s);
            cls.AddMethod(true, "actionPropS_s", BindStaticDelegate_actionPropS_s);
            cls.AddMethod(true, "actionPropGS_s", BindStaticDelegate_actionPropGS_s);
            return cls;
        }
    }
}
#endif
