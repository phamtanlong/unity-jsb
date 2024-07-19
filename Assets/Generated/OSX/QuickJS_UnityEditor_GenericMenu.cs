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
    // Type: UnityEditor.GenericMenu
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_GenericMenu
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new UnityEditor.GenericMenu();
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
        public static JSValue Bind_AddItem(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        UnityEditor.GenericMenu self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.GUIContent arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.GenericMenu), "AddItem", typeof(UnityEngine.GUIContent), 0);
                        }
                        bool arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.GenericMenu), "AddItem", typeof(bool), 1);
                        }
                        UnityEditor.GenericMenu.MenuFunction2 arg2;
                        if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.GenericMenu), "AddItem", typeof(UnityEditor.GenericMenu.MenuFunction2), 2);
                        }
                        object arg3;
                        if (!Values.js_get_var(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.GenericMenu), "AddItem", typeof(object), 3);
                        }
                        self.AddItem(arg0, arg1, arg2, arg3);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 3)
                    {
                        UnityEditor.GenericMenu self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.GUIContent arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.GenericMenu), "AddItem", typeof(UnityEngine.GUIContent), 0);
                        }
                        bool arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.GenericMenu), "AddItem", typeof(bool), 1);
                        }
                        UnityEditor.GenericMenu.MenuFunction arg2;
                        if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.GenericMenu), "AddItem", typeof(UnityEditor.GenericMenu.MenuFunction), 2);
                        }
                        self.AddItem(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("AddItem", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_AddDisabledItem(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEditor.GenericMenu self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.GUIContent arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.GenericMenu), "AddDisabledItem", typeof(UnityEngine.GUIContent), 0);
                        }
                        bool arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.GenericMenu), "AddDisabledItem", typeof(bool), 1);
                        }
                        self.AddDisabledItem(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        UnityEditor.GenericMenu self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.GUIContent arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.GenericMenu), "AddDisabledItem", typeof(UnityEngine.GUIContent), 0);
                        }
                        self.AddDisabledItem(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("AddDisabledItem", argc);
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
                if (argc == 1)
                {
                    UnityEditor.GenericMenu self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.GenericMenu), "AddSeparator", typeof(string), 0);
                    }
                    self.AddSeparator(arg0);
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
        public static JSValue Bind_GetItemCount(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.GenericMenu self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.GetItemCount();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetItemCount", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ShowAsContext(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.GenericMenu self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.ShowAsContext();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ShowAsContext", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DropDown(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.GenericMenu self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.GenericMenu), "DropDown", typeof(UnityEngine.Rect), 0);
                    }
                    self.DropDown(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DropDown", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_allowDuplicateNames(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.GenericMenu self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.allowDuplicateNames;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_allowDuplicateNames(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.GenericMenu self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.GenericMenu), "allowDuplicateNames", typeof(bool), 0);
                }
                self.allowDuplicateNames = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("GenericMenu", typeof(UnityEditor.GenericMenu), BindConstructor);
            cls.AddMethod(false, "AddItem", Bind_AddItem);
            cls.AddMethod(false, "AddDisabledItem", Bind_AddDisabledItem);
            cls.AddMethod(false, "AddSeparator", Bind_AddSeparator);
            cls.AddMethod(false, "GetItemCount", Bind_GetItemCount);
            cls.AddMethod(false, "ShowAsContext", Bind_ShowAsContext);
            cls.AddMethod(false, "DropDown", Bind_DropDown);
            cls.AddProperty(false, "allowDuplicateNames", BindRead_allowDuplicateNames, BindWrite_allowDuplicateNames);
            return cls;
        }
    }
}
#endif
#endif
