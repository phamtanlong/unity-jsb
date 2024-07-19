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
    // Assembly: UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2019.4.40f1/Unity.app/Contents/Managed/UnityEngine/UnityEngine.IMGUIModule.dll
    // Type: UnityEngine.GUIContent
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_GUIContent
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
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUIContent), ".ctor", typeof(string), 0);
                        }
                        UnityEngine.Texture arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUIContent), ".ctor", typeof(UnityEngine.Texture), 1);
                        }
                        string arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUIContent), ".ctor", typeof(string), 2);
                        }
                        var o = new UnityEngine.GUIContent(arg0, arg1, arg2);
                        var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                        return val;
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Texture)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIContent), ".ctor", typeof(string), 0);
                            }
                            UnityEngine.Texture arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIContent), ".ctor", typeof(UnityEngine.Texture), 1);
                            }
                            var o = new UnityEngine.GUIContent(arg0, arg1);
                            var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                            return val;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(string)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIContent), ".ctor", typeof(string), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIContent), ".ctor", typeof(string), 1);
                            }
                            var o = new UnityEngine.GUIContent(arg0, arg1);
                            var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                            return val;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Texture)) && Values.js_match_type(ctx, argv[1], typeof(string)))
                        {
                            UnityEngine.Texture arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIContent), ".ctor", typeof(UnityEngine.Texture), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIContent), ".ctor", typeof(string), 1);
                            }
                            var o = new UnityEngine.GUIContent(arg0, arg1);
                            var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                            return val;
                        }
                    }
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIContent), ".ctor", typeof(string), 0);
                            }
                            var o = new UnityEngine.GUIContent(arg0);
                            var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                            return val;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Texture)))
                        {
                            UnityEngine.Texture arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIContent), ".ctor", typeof(UnityEngine.Texture), 0);
                            }
                            var o = new UnityEngine.GUIContent(arg0);
                            var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                            return val;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIContent), ".ctor", typeof(UnityEngine.GUIContent), 0);
                            }
                            var o = new UnityEngine.GUIContent(arg0);
                            var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                            return val;
                        }
                    }
                    if (argc == 0)
                    {
                        var o = new UnityEngine.GUIContent();
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
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_text(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GUIContent self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.text;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_text(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIContent self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIContent), "text", typeof(string), 0);
                }
                self.text = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_image(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GUIContent self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.image;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_image(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIContent self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Texture value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIContent), "image", typeof(UnityEngine.Texture), 0);
                }
                self.image = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_tooltip(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GUIContent self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.tooltip;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_tooltip(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIContent self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIContent), "tooltip", typeof(string), 0);
                }
                self.tooltip = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_none(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.GUIContent.none;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_none(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIContent value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIContent), "none", typeof(UnityEngine.GUIContent), 0);
                }
                UnityEngine.GUIContent.none = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("GUIContent", typeof(UnityEngine.GUIContent), BindConstructor);
            cls.AddProperty(false, "text", BindRead_text, BindWrite_text);
            cls.AddProperty(false, "image", BindRead_image, BindWrite_image);
            cls.AddProperty(false, "tooltip", BindRead_tooltip, BindWrite_tooltip);
            cls.AddField(true, "none", BindStaticRead_none, BindStaticWrite_none);
            return cls;
        }
    }
}
#endif
