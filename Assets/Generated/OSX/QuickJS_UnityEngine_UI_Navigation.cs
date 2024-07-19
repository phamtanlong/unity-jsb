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
    // Type: UnityEngine.UI.Navigation
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_UI_Navigation
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                var o = new UnityEngine.UI.Navigation();
                var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                return val;
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
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.UI.Navigation)))
                        {
                            UnityEngine.UI.Navigation self;
                            if (!Values.js_get_structvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEngine.UI.Navigation arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.UI.Navigation), "Equals", typeof(UnityEngine.UI.Navigation), 0);
                            }
                            var ret = self.Equals(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(object)))
                        {
                            System.ValueType self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            object arg0;
                            if (!Values.js_get_var(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(System.ValueType), "Equals", typeof(object), 0);
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
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_mode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.Navigation self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.mode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_mode(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.UI.Navigation self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.UI.Navigation.Mode value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.UI.Navigation), "mode", typeof(UnityEngine.UI.Navigation.Mode), 0);
                }
                self.mode = value;
                Values.js_rebind_this(ctx, this_obj, ref self);
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_selectOnUp(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.Navigation self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.selectOnUp;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_selectOnUp(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.UI.Navigation self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.UI.Selectable value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.UI.Navigation), "selectOnUp", typeof(UnityEngine.UI.Selectable), 0);
                }
                self.selectOnUp = value;
                Values.js_rebind_this(ctx, this_obj, ref self);
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_selectOnDown(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.Navigation self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.selectOnDown;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_selectOnDown(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.UI.Navigation self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.UI.Selectable value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.UI.Navigation), "selectOnDown", typeof(UnityEngine.UI.Selectable), 0);
                }
                self.selectOnDown = value;
                Values.js_rebind_this(ctx, this_obj, ref self);
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_selectOnLeft(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.Navigation self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.selectOnLeft;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_selectOnLeft(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.UI.Navigation self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.UI.Selectable value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.UI.Navigation), "selectOnLeft", typeof(UnityEngine.UI.Selectable), 0);
                }
                self.selectOnLeft = value;
                Values.js_rebind_this(ctx, this_obj, ref self);
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_selectOnRight(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.Navigation self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.selectOnRight;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_selectOnRight(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.UI.Navigation self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.UI.Selectable value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.UI.Navigation), "selectOnRight", typeof(UnityEngine.UI.Selectable), 0);
                }
                self.selectOnRight = value;
                Values.js_rebind_this(ctx, this_obj, ref self);
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_defaultNavigation(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.UI.Navigation.defaultNavigation;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("Navigation", typeof(UnityEngine.UI.Navigation), BindConstructor);
            cls.AddMethod(false, "Equals", Bind_Equals);
            cls.AddProperty(false, "mode", BindRead_mode, BindWrite_mode);
            cls.AddProperty(false, "selectOnUp", BindRead_selectOnUp, BindWrite_selectOnUp);
            cls.AddProperty(false, "selectOnDown", BindRead_selectOnDown, BindWrite_selectOnDown);
            cls.AddProperty(false, "selectOnLeft", BindRead_selectOnLeft, BindWrite_selectOnLeft);
            cls.AddProperty(false, "selectOnRight", BindRead_selectOnRight, BindWrite_selectOnRight);
            cls.AddProperty(true, "defaultNavigation", BindStaticRead_defaultNavigation, null);
            return cls;
        }
    }
}
#endif
