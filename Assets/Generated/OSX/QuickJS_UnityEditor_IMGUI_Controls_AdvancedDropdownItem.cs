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
    // Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2019.4.40f1/Unity.app/Contents/Managed/UnityEditor.dll
    // Type: UnityEditor.IMGUI.Controls.AdvancedDropdownItem
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_IMGUI_Controls_AdvancedDropdownItem
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem), ".ctor", typeof(string), 0);
                    }
                    var o = new UnityEditor.IMGUI.Controls.AdvancedDropdownItem(arg0);
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
        public static JSValue Bind_AddChild(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.IMGUI.Controls.AdvancedDropdownItem self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEditor.IMGUI.Controls.AdvancedDropdownItem arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem), "AddChild", typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem), 0);
                    }
                    self.AddChild(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("AddChild", argc);
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
                    UnityEditor.IMGUI.Controls.AdvancedDropdownItem self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    object arg0;
                    if (!Values.js_get_var(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem), "CompareTo", typeof(object), 0);
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
        public static JSValue Bind_AddSeparator(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.IMGUI.Controls.AdvancedDropdownItem self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.AddSeparator();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("AddSeparator", argc);
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
                    UnityEditor.IMGUI.Controls.AdvancedDropdownItem self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
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
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_name(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.IMGUI.Controls.AdvancedDropdownItem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.name;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_name(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.IMGUI.Controls.AdvancedDropdownItem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem), "name", typeof(string), 0);
                }
                self.name = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_icon(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.IMGUI.Controls.AdvancedDropdownItem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.icon;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_icon(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.IMGUI.Controls.AdvancedDropdownItem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Texture2D value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem), "icon", typeof(UnityEngine.Texture2D), 0);
                }
                self.icon = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_id(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.IMGUI.Controls.AdvancedDropdownItem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.id;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_id(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.IMGUI.Controls.AdvancedDropdownItem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem), "id", typeof(int), 0);
                }
                self.id = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_enabled(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.IMGUI.Controls.AdvancedDropdownItem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.enabled;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_enabled(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.IMGUI.Controls.AdvancedDropdownItem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem), "enabled", typeof(bool), 0);
                }
                self.enabled = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_children(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.IMGUI.Controls.AdvancedDropdownItem self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.children;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("AdvancedDropdownItem", typeof(UnityEditor.IMGUI.Controls.AdvancedDropdownItem), BindConstructor);
            cls.AddMethod(false, "AddChild", Bind_AddChild);
            cls.AddMethod(false, "CompareTo", Bind_CompareTo);
            cls.AddMethod(false, "AddSeparator", Bind_AddSeparator);
            cls.AddMethod(false, "toString", Bind_ToString);
            cls.AddProperty(false, "name", BindRead_name, BindWrite_name);
            cls.AddProperty(false, "icon", BindRead_icon, BindWrite_icon);
            cls.AddProperty(false, "id", BindRead_id, BindWrite_id);
            cls.AddProperty(false, "enabled", BindRead_enabled, BindWrite_enabled);
            cls.AddProperty(false, "children", BindRead_children, null);
            return cls;
        }
    }
}
#endif
#endif
