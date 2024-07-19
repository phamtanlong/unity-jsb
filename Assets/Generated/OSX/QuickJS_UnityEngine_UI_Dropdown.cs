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
    // Type: UnityEngine.UI.Dropdown
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_UI_Dropdown
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetValueWithoutNotify(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.UI.Dropdown self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.Dropdown), "SetValueWithoutNotify", typeof(int), 0);
                    }
                    self.SetValueWithoutNotify(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetValueWithoutNotify", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_RefreshShownValue(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.UI.Dropdown self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.RefreshShownValue();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RefreshShownValue", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_AddOptions(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData>)))
                        {
                            UnityEngine.UI.Dropdown self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.UI.Dropdown), "AddOptions", typeof(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData>), 0);
                            }
                            self.AddOptions(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Collections.Generic.List<string>)))
                        {
                            UnityEngine.UI.Dropdown self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            System.Collections.Generic.List<string> arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.UI.Dropdown), "AddOptions", typeof(System.Collections.Generic.List<string>), 0);
                            }
                            self.AddOptions(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Collections.Generic.List<UnityEngine.Sprite>)))
                        {
                            UnityEngine.UI.Dropdown self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            System.Collections.Generic.List<UnityEngine.Sprite> arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.UI.Dropdown), "AddOptions", typeof(System.Collections.Generic.List<UnityEngine.Sprite>), 0);
                            }
                            self.AddOptions(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("AddOptions", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ClearOptions(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.UI.Dropdown self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.ClearOptions();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ClearOptions", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_OnPointerClick(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.UI.Dropdown self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.EventSystems.PointerEventData arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.Dropdown), "OnPointerClick", typeof(UnityEngine.EventSystems.PointerEventData), 0);
                    }
                    self.OnPointerClick(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("OnPointerClick", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_OnSubmit(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.UI.Dropdown self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.EventSystems.BaseEventData arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.Dropdown), "OnSubmit", typeof(UnityEngine.EventSystems.BaseEventData), 0);
                    }
                    self.OnSubmit(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("OnSubmit", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_OnCancel(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.UI.Dropdown self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.EventSystems.BaseEventData arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.Dropdown), "OnCancel", typeof(UnityEngine.EventSystems.BaseEventData), 0);
                    }
                    self.OnCancel(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("OnCancel", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Show(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.UI.Dropdown self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.Show();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Show", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Hide(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.UI.Dropdown self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.Hide();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Hide", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_template(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.Dropdown self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.template;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_template(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.UI.Dropdown self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.RectTransform value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.UI.Dropdown), "template", typeof(UnityEngine.RectTransform), 0);
                }
                self.template = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_captionText(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.Dropdown self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.captionText;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_captionText(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.UI.Dropdown self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.UI.Text value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.UI.Dropdown), "captionText", typeof(UnityEngine.UI.Text), 0);
                }
                self.captionText = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_captionImage(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.Dropdown self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.captionImage;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_captionImage(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.UI.Dropdown self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.UI.Image value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.UI.Dropdown), "captionImage", typeof(UnityEngine.UI.Image), 0);
                }
                self.captionImage = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_itemText(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.Dropdown self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.itemText;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_itemText(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.UI.Dropdown self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.UI.Text value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.UI.Dropdown), "itemText", typeof(UnityEngine.UI.Text), 0);
                }
                self.itemText = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_itemImage(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.Dropdown self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.itemImage;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_itemImage(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.UI.Dropdown self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.UI.Image value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.UI.Dropdown), "itemImage", typeof(UnityEngine.UI.Image), 0);
                }
                self.itemImage = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_options(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.Dropdown self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.options;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_options(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.UI.Dropdown self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.UI.Dropdown), "options", typeof(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData>), 0);
                }
                self.options = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_onValueChanged(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.Dropdown self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.onValueChanged;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_onValueChanged(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.UI.Dropdown self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.UI.Dropdown.DropdownEvent value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.UI.Dropdown), "onValueChanged", typeof(UnityEngine.UI.Dropdown.DropdownEvent), 0);
                }
                self.onValueChanged = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_alphaFadeSpeed(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.Dropdown self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.alphaFadeSpeed;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_alphaFadeSpeed(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.UI.Dropdown self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.UI.Dropdown), "alphaFadeSpeed", typeof(float), 0);
                }
                self.alphaFadeSpeed = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_value(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.Dropdown self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.value;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_value(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.UI.Dropdown self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.UI.Dropdown), "value", typeof(int), 0);
                }
                self.value = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("Dropdown", typeof(UnityEngine.UI.Dropdown), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(false, "SetValueWithoutNotify", Bind_SetValueWithoutNotify);
            cls.AddMethod(false, "RefreshShownValue", Bind_RefreshShownValue);
            cls.AddMethod(false, "AddOptions", Bind_AddOptions);
            cls.AddMethod(false, "ClearOptions", Bind_ClearOptions);
            cls.AddMethod(false, "OnPointerClick", Bind_OnPointerClick);
            cls.AddMethod(false, "OnSubmit", Bind_OnSubmit);
            cls.AddMethod(false, "OnCancel", Bind_OnCancel);
            cls.AddMethod(false, "Show", Bind_Show);
            cls.AddMethod(false, "Hide", Bind_Hide);
            cls.AddProperty(false, "template", BindRead_template, BindWrite_template);
            cls.AddProperty(false, "captionText", BindRead_captionText, BindWrite_captionText);
            cls.AddProperty(false, "captionImage", BindRead_captionImage, BindWrite_captionImage);
            cls.AddProperty(false, "itemText", BindRead_itemText, BindWrite_itemText);
            cls.AddProperty(false, "itemImage", BindRead_itemImage, BindWrite_itemImage);
            cls.AddProperty(false, "options", BindRead_options, BindWrite_options);
            cls.AddProperty(false, "onValueChanged", BindRead_onValueChanged, BindWrite_onValueChanged);
            cls.AddProperty(false, "alphaFadeSpeed", BindRead_alphaFadeSpeed, BindWrite_alphaFadeSpeed);
            cls.AddProperty(false, "value", BindRead_value, BindWrite_value);
            return cls;
        }
    }
}
#endif
