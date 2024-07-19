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
    // Type: UnityEngine.GUIUtility
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_GUIUtility
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetControlID(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.FocusType)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Rect)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIUtility), "GetControlID", typeof(int), 0);
                            }
                            UnityEngine.FocusType arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIUtility), "GetControlID", typeof(UnityEngine.FocusType), 1);
                            }
                            UnityEngine.Rect arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIUtility), "GetControlID", typeof(UnityEngine.Rect), 2);
                            }
                            var ret = UnityEngine.GUIUtility.GetControlID(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.FocusType)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Rect)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIUtility), "GetControlID", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.FocusType arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIUtility), "GetControlID", typeof(UnityEngine.FocusType), 1);
                            }
                            UnityEngine.Rect arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIUtility), "GetControlID", typeof(UnityEngine.Rect), 2);
                            }
                            var ret = UnityEngine.GUIUtility.GetControlID(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.FocusType)))
                        {
                            UnityEngine.GUIContent arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIUtility), "GetControlID", typeof(UnityEngine.GUIContent), 0);
                            }
                            UnityEngine.FocusType arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIUtility), "GetControlID", typeof(UnityEngine.FocusType), 1);
                            }
                            var ret = UnityEngine.GUIUtility.GetControlID(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.FocusType)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Rect)))
                        {
                            UnityEngine.FocusType arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIUtility), "GetControlID", typeof(UnityEngine.FocusType), 0);
                            }
                            UnityEngine.Rect arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIUtility), "GetControlID", typeof(UnityEngine.Rect), 1);
                            }
                            var ret = UnityEngine.GUIUtility.GetControlID(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.FocusType)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIUtility), "GetControlID", typeof(int), 0);
                            }
                            UnityEngine.FocusType arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIUtility), "GetControlID", typeof(UnityEngine.FocusType), 1);
                            }
                            var ret = UnityEngine.GUIUtility.GetControlID(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 1)
                    {
                        UnityEngine.FocusType arg0;
                        if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUIUtility), "GetControlID", typeof(UnityEngine.FocusType), 0);
                        }
                        var ret = UnityEngine.GUIUtility.GetControlID(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("GetControlID", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_AlignRectToDevice(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUIUtility), "AlignRectToDevice", typeof(UnityEngine.Rect), 0);
                        }
                        int arg1;
                        int arg2;
                        var ret = UnityEngine.GUIUtility.AlignRectToDevice(arg0, out arg1, out arg2);
                        var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg1);
                        if (JSApi.JS_IsException(out0))
                        {
                            return out0;
                        }
                        var context = ScriptEngine.GetContext(ctx);
                        JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                        var out1 = QuickJS.Binding.Values.js_push_primitive(ctx, arg2);
                        if (JSApi.JS_IsException(out1))
                        {
                            return out1;
                        }
                        JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out1);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUIUtility), "AlignRectToDevice", typeof(UnityEngine.Rect), 0);
                        }
                        var ret = UnityEngine.GUIUtility.AlignRectToDevice(arg0);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("AlignRectToDevice", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetStateObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    System.Type arg0;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIUtility), "GetStateObject", typeof(System.Type), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIUtility), "GetStateObject", typeof(int), 1);
                    }
                    var ret = UnityEngine.GUIUtility.GetStateObject(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_object(ctx, ret);
                }
                throw new NoSuitableMethodException("GetStateObject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_QueryStateObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    System.Type arg0;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIUtility), "QueryStateObject", typeof(System.Type), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIUtility), "QueryStateObject", typeof(int), 1);
                    }
                    var ret = UnityEngine.GUIUtility.QueryStateObject(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_object(ctx, ret);
                }
                throw new NoSuitableMethodException("QueryStateObject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ExitGUI(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.GUIUtility.ExitGUI();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ExitGUI", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GUIToScreenPoint(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Vector2 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIUtility), "GUIToScreenPoint", typeof(UnityEngine.Vector2), 0);
                    }
                    var ret = UnityEngine.GUIUtility.GUIToScreenPoint(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GUIToScreenPoint", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GUIToScreenRect(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIUtility), "GUIToScreenRect", typeof(UnityEngine.Rect), 0);
                    }
                    var ret = UnityEngine.GUIUtility.GUIToScreenRect(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GUIToScreenRect", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ScreenToGUIPoint(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Vector2 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIUtility), "ScreenToGUIPoint", typeof(UnityEngine.Vector2), 0);
                    }
                    var ret = UnityEngine.GUIUtility.ScreenToGUIPoint(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("ScreenToGUIPoint", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ScreenToGUIRect(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIUtility), "ScreenToGUIRect", typeof(UnityEngine.Rect), 0);
                    }
                    var ret = UnityEngine.GUIUtility.ScreenToGUIRect(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("ScreenToGUIRect", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RotateAroundPivot(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    float arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIUtility), "RotateAroundPivot", typeof(float), 0);
                    }
                    UnityEngine.Vector2 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIUtility), "RotateAroundPivot", typeof(UnityEngine.Vector2), 1);
                    }
                    UnityEngine.GUIUtility.RotateAroundPivot(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RotateAroundPivot", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ScaleAroundPivot(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Vector2 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIUtility), "ScaleAroundPivot", typeof(UnityEngine.Vector2), 0);
                    }
                    UnityEngine.Vector2 arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIUtility), "ScaleAroundPivot", typeof(UnityEngine.Vector2), 1);
                    }
                    UnityEngine.GUIUtility.ScaleAroundPivot(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ScaleAroundPivot", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_hasModalWindow(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.GUIUtility.hasModalWindow;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_systemCopyBuffer(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.GUIUtility.systemCopyBuffer;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_systemCopyBuffer(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIUtility), "systemCopyBuffer", typeof(string), 0);
                }
                UnityEngine.GUIUtility.systemCopyBuffer = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_hotControl(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.GUIUtility.hotControl;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_hotControl(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIUtility), "hotControl", typeof(int), 0);
                }
                UnityEngine.GUIUtility.hotControl = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_keyboardControl(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.GUIUtility.keyboardControl;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_keyboardControl(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIUtility), "keyboardControl", typeof(int), 0);
                }
                UnityEngine.GUIUtility.keyboardControl = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("GUIUtility", typeof(UnityEngine.GUIUtility), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "GetControlID", BindStatic_GetControlID);
            cls.AddMethod(true, "AlignRectToDevice", BindStatic_AlignRectToDevice);
            cls.AddMethod(true, "GetStateObject", BindStatic_GetStateObject);
            cls.AddMethod(true, "QueryStateObject", BindStatic_QueryStateObject);
            cls.AddMethod(true, "ExitGUI", BindStatic_ExitGUI);
            cls.AddMethod(true, "GUIToScreenPoint", BindStatic_GUIToScreenPoint);
            cls.AddMethod(true, "GUIToScreenRect", BindStatic_GUIToScreenRect);
            cls.AddMethod(true, "ScreenToGUIPoint", BindStatic_ScreenToGUIPoint);
            cls.AddMethod(true, "ScreenToGUIRect", BindStatic_ScreenToGUIRect);
            cls.AddMethod(true, "RotateAroundPivot", BindStatic_RotateAroundPivot);
            cls.AddMethod(true, "ScaleAroundPivot", BindStatic_ScaleAroundPivot);
            cls.AddProperty(true, "hasModalWindow", BindStaticRead_hasModalWindow, null);
            cls.AddProperty(true, "systemCopyBuffer", BindStaticRead_systemCopyBuffer, BindStaticWrite_systemCopyBuffer);
            cls.AddProperty(true, "hotControl", BindStaticRead_hotControl, BindStaticWrite_hotControl);
            cls.AddProperty(true, "keyboardControl", BindStaticRead_keyboardControl, BindStaticWrite_keyboardControl);
            return cls;
        }
    }
}
#endif
