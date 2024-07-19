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
    // Assembly: UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Users/longpt/Documents/SkyMavis/unity-jsb-2/Library/ScriptAssemblies/UnityEngine.UI.dll
    // Type: UnityEngine.EventSystems.AxisEventData
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_EventSystems_AxisEventData
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.EventSystems.EventSystem arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.EventSystems.AxisEventData), ".ctor", typeof(UnityEngine.EventSystems.EventSystem), 0);
                    }
                    var o = new UnityEngine.EventSystems.AxisEventData(arg0);
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
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_moveVector(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.EventSystems.AxisEventData self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.moveVector;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_moveVector(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.EventSystems.AxisEventData self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Vector2 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.EventSystems.AxisEventData), "moveVector", typeof(UnityEngine.Vector2), 0);
                }
                self.moveVector = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_moveDir(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.EventSystems.AxisEventData self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.moveDir;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_moveDir(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.EventSystems.AxisEventData self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.EventSystems.MoveDirection value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.EventSystems.AxisEventData), "moveDir", typeof(UnityEngine.EventSystems.MoveDirection), 0);
                }
                self.moveDir = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("AxisEventData", typeof(UnityEngine.EventSystems.AxisEventData), BindConstructor);
            cls.AddProperty(false, "moveVector", BindRead_moveVector, BindWrite_moveVector);
            cls.AddProperty(false, "moveDir", BindRead_moveDir, BindWrite_moveDir);
            return cls;
        }
    }
}
#endif
