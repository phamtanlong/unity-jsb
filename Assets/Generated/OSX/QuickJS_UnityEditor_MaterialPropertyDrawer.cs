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
    // Type: UnityEditor.MaterialPropertyDrawer
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_MaterialPropertyDrawer
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_OnGUI(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.MaterialProperty)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[3], typeof(UnityEditor.MaterialEditor)))
                        {
                            UnityEditor.MaterialPropertyDrawer self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.MaterialPropertyDrawer), "OnGUI", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEditor.MaterialProperty arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.MaterialPropertyDrawer), "OnGUI", typeof(UnityEditor.MaterialProperty), 1);
                            }
                            UnityEngine.GUIContent arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.MaterialPropertyDrawer), "OnGUI", typeof(UnityEngine.GUIContent), 2);
                            }
                            UnityEditor.MaterialEditor arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.MaterialPropertyDrawer), "OnGUI", typeof(UnityEditor.MaterialEditor), 3);
                            }
                            self.OnGUI(arg0, arg1, arg2, arg3);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.MaterialProperty)) && Values.js_match_type(ctx, argv[2], typeof(string)) && Values.js_match_type(ctx, argv[3], typeof(UnityEditor.MaterialEditor)))
                        {
                            UnityEditor.MaterialPropertyDrawer self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.MaterialPropertyDrawer), "OnGUI", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEditor.MaterialProperty arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.MaterialPropertyDrawer), "OnGUI", typeof(UnityEditor.MaterialProperty), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.MaterialPropertyDrawer), "OnGUI", typeof(string), 2);
                            }
                            UnityEditor.MaterialEditor arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.MaterialPropertyDrawer), "OnGUI", typeof(UnityEditor.MaterialEditor), 3);
                            }
                            self.OnGUI(arg0, arg1, arg2, arg3);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("OnGUI", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetPropertyHeight(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEditor.MaterialPropertyDrawer self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEditor.MaterialProperty arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.MaterialPropertyDrawer), "GetPropertyHeight", typeof(UnityEditor.MaterialProperty), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.MaterialPropertyDrawer), "GetPropertyHeight", typeof(string), 1);
                    }
                    UnityEditor.MaterialEditor arg2;
                    if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.MaterialPropertyDrawer), "GetPropertyHeight", typeof(UnityEditor.MaterialEditor), 2);
                    }
                    var ret = self.GetPropertyHeight(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetPropertyHeight", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Apply(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.MaterialPropertyDrawer self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEditor.MaterialProperty arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.MaterialPropertyDrawer), "Apply", typeof(UnityEditor.MaterialProperty), 0);
                    }
                    self.Apply(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Apply", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("MaterialPropertyDrawer", typeof(UnityEditor.MaterialPropertyDrawer), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(false, "OnGUI", Bind_OnGUI);
            cls.AddMethod(false, "GetPropertyHeight", Bind_GetPropertyHeight);
            cls.AddMethod(false, "Apply", Bind_Apply);
            return cls;
        }
    }
}
#endif
#endif
