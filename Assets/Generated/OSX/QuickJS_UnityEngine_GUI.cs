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
    // Assembly: UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2021.3.37f1/Unity.app/Contents/Managed/UnityEngine/UnityEngine.IMGUIModule.dll
    // Type: UnityEngine.GUI
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_GUI
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetNextControlName(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUI), "SetNextControlName", typeof(string), 0);
                    }
                    UnityEngine.GUI.SetNextControlName(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetNextControlName", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetNameOfFocusedControl(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEngine.GUI.GetNameOfFocusedControl();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetNameOfFocusedControl", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_FocusControl(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUI), "FocusControl", typeof(string), 0);
                    }
                    UnityEngine.GUI.FocusControl(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("FocusControl", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DragWindow(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "DragWindow", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.GUI.DragWindow(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 0)
                    {
                        UnityEngine.GUI.DragWindow();
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("DragWindow", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BringWindowToFront(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUI), "BringWindowToFront", typeof(int), 0);
                    }
                    UnityEngine.GUI.BringWindowToFront(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("BringWindowToFront", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BringWindowToBack(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUI), "BringWindowToBack", typeof(int), 0);
                    }
                    UnityEngine.GUI.BringWindowToBack(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("BringWindowToBack", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_FocusWindow(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUI), "FocusWindow", typeof(int), 0);
                    }
                    UnityEngine.GUI.FocusWindow(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("FocusWindow", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_UnfocusWindow(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.GUI.UnfocusWindow();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("UnfocusWindow", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Label(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Label", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Label", typeof(string), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Label", typeof(UnityEngine.GUIStyle), 2);
                            }
                            UnityEngine.GUI.Label(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Texture)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Label", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.Texture arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Label", typeof(UnityEngine.Texture), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Label", typeof(UnityEngine.GUIStyle), 2);
                            }
                            UnityEngine.GUI.Label(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Label", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Label", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Label", typeof(UnityEngine.GUIStyle), 2);
                            }
                            UnityEngine.GUI.Label(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Label", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Label", typeof(string), 1);
                            }
                            UnityEngine.GUI.Label(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Texture)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Label", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.Texture arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Label", typeof(UnityEngine.Texture), 1);
                            }
                            UnityEngine.GUI.Label(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Label", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Label", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.GUI.Label(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Label", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawTexture(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 8)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Texture)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.ScaleMode)) && Values.js_match_type(ctx, argv[3], typeof(bool)) && Values.js_match_type(ctx, argv[4], typeof(float)) && Values.js_match_type(ctx, argv[5], typeof(UnityEngine.Color)) && Values.js_match_type(ctx, argv[6], typeof(float)) && Values.js_match_type(ctx, argv[7], typeof(float)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.Texture arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(UnityEngine.Texture), 1);
                            }
                            UnityEngine.ScaleMode arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(UnityEngine.ScaleMode), 2);
                            }
                            bool arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(bool), 3);
                            }
                            float arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(float), 4);
                            }
                            UnityEngine.Color arg5;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(UnityEngine.Color), 5);
                            }
                            float arg6;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[6], out arg6))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(float), 6);
                            }
                            float arg7;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[7], out arg7))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(float), 7);
                            }
                            UnityEngine.GUI.DrawTexture(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Texture)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.ScaleMode)) && Values.js_match_type(ctx, argv[3], typeof(bool)) && Values.js_match_type(ctx, argv[4], typeof(float)) && Values.js_match_type(ctx, argv[5], typeof(UnityEngine.Color)) && Values.js_match_type(ctx, argv[6], typeof(UnityEngine.Vector4)) && Values.js_match_type(ctx, argv[7], typeof(float)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.Texture arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(UnityEngine.Texture), 1);
                            }
                            UnityEngine.ScaleMode arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(UnityEngine.ScaleMode), 2);
                            }
                            bool arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(bool), 3);
                            }
                            float arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(float), 4);
                            }
                            UnityEngine.Color arg5;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(UnityEngine.Color), 5);
                            }
                            UnityEngine.Vector4 arg6;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[6], out arg6))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(UnityEngine.Vector4), 6);
                            }
                            float arg7;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[7], out arg7))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(float), 7);
                            }
                            UnityEngine.GUI.DrawTexture(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Texture)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.ScaleMode)) && Values.js_match_type(ctx, argv[3], typeof(bool)) && Values.js_match_type(ctx, argv[4], typeof(float)) && Values.js_match_type(ctx, argv[5], typeof(UnityEngine.Color)) && Values.js_match_type(ctx, argv[6], typeof(UnityEngine.Vector4)) && Values.js_match_type(ctx, argv[7], typeof(UnityEngine.Vector4)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.Texture arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(UnityEngine.Texture), 1);
                            }
                            UnityEngine.ScaleMode arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(UnityEngine.ScaleMode), 2);
                            }
                            bool arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(bool), 3);
                            }
                            float arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(float), 4);
                            }
                            UnityEngine.Color arg5;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(UnityEngine.Color), 5);
                            }
                            UnityEngine.Vector4 arg6;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[6], out arg6))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(UnityEngine.Vector4), 6);
                            }
                            UnityEngine.Vector4 arg7;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[7], out arg7))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(UnityEngine.Vector4), 7);
                            }
                            UnityEngine.GUI.DrawTexture(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 5)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Texture arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(UnityEngine.Texture), 1);
                        }
                        UnityEngine.ScaleMode arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(UnityEngine.ScaleMode), 2);
                        }
                        bool arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(bool), 3);
                        }
                        float arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(float), 4);
                        }
                        UnityEngine.GUI.DrawTexture(arg0, arg1, arg2, arg3, arg4);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 4)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Texture arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(UnityEngine.Texture), 1);
                        }
                        UnityEngine.ScaleMode arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(UnityEngine.ScaleMode), 2);
                        }
                        bool arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(bool), 3);
                        }
                        UnityEngine.GUI.DrawTexture(arg0, arg1, arg2, arg3);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Texture arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(UnityEngine.Texture), 1);
                        }
                        UnityEngine.ScaleMode arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(UnityEngine.ScaleMode), 2);
                        }
                        UnityEngine.GUI.DrawTexture(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Texture arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "DrawTexture", typeof(UnityEngine.Texture), 1);
                        }
                        UnityEngine.GUI.DrawTexture(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("DrawTexture", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawTextureWithTexCoords(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "DrawTextureWithTexCoords", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Texture arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "DrawTextureWithTexCoords", typeof(UnityEngine.Texture), 1);
                        }
                        UnityEngine.Rect arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "DrawTextureWithTexCoords", typeof(UnityEngine.Rect), 2);
                        }
                        bool arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "DrawTextureWithTexCoords", typeof(bool), 3);
                        }
                        UnityEngine.GUI.DrawTextureWithTexCoords(arg0, arg1, arg2, arg3);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "DrawTextureWithTexCoords", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Texture arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "DrawTextureWithTexCoords", typeof(UnityEngine.Texture), 1);
                        }
                        UnityEngine.Rect arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "DrawTextureWithTexCoords", typeof(UnityEngine.Rect), 2);
                        }
                        UnityEngine.GUI.DrawTextureWithTexCoords(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("DrawTextureWithTexCoords", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Box(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Box", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Box", typeof(string), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Box", typeof(UnityEngine.GUIStyle), 2);
                            }
                            UnityEngine.GUI.Box(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Texture)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Box", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.Texture arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Box", typeof(UnityEngine.Texture), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Box", typeof(UnityEngine.GUIStyle), 2);
                            }
                            UnityEngine.GUI.Box(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Box", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Box", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Box", typeof(UnityEngine.GUIStyle), 2);
                            }
                            UnityEngine.GUI.Box(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Box", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Box", typeof(string), 1);
                            }
                            UnityEngine.GUI.Box(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Texture)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Box", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.Texture arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Box", typeof(UnityEngine.Texture), 1);
                            }
                            UnityEngine.GUI.Box(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Box", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Box", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.GUI.Box(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Box", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Button(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Button", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Button", typeof(string), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Button", typeof(UnityEngine.GUIStyle), 2);
                            }
                            var ret = UnityEngine.GUI.Button(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Texture)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Button", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.Texture arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Button", typeof(UnityEngine.Texture), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Button", typeof(UnityEngine.GUIStyle), 2);
                            }
                            var ret = UnityEngine.GUI.Button(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Button", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Button", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Button", typeof(UnityEngine.GUIStyle), 2);
                            }
                            var ret = UnityEngine.GUI.Button(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Button", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Button", typeof(string), 1);
                            }
                            var ret = UnityEngine.GUI.Button(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Texture)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Button", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.Texture arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Button", typeof(UnityEngine.Texture), 1);
                            }
                            var ret = UnityEngine.GUI.Button(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Button", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Button", typeof(UnityEngine.GUIContent), 1);
                            }
                            var ret = UnityEngine.GUI.Button(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Button", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RepeatButton(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "RepeatButton", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "RepeatButton", typeof(string), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "RepeatButton", typeof(UnityEngine.GUIStyle), 2);
                            }
                            var ret = UnityEngine.GUI.RepeatButton(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Texture)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "RepeatButton", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.Texture arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "RepeatButton", typeof(UnityEngine.Texture), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "RepeatButton", typeof(UnityEngine.GUIStyle), 2);
                            }
                            var ret = UnityEngine.GUI.RepeatButton(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "RepeatButton", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "RepeatButton", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "RepeatButton", typeof(UnityEngine.GUIStyle), 2);
                            }
                            var ret = UnityEngine.GUI.RepeatButton(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "RepeatButton", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "RepeatButton", typeof(string), 1);
                            }
                            var ret = UnityEngine.GUI.RepeatButton(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Texture)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "RepeatButton", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.Texture arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "RepeatButton", typeof(UnityEngine.Texture), 1);
                            }
                            var ret = UnityEngine.GUI.RepeatButton(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "RepeatButton", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "RepeatButton", typeof(UnityEngine.GUIContent), 1);
                            }
                            var ret = UnityEngine.GUI.RepeatButton(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("RepeatButton", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_TextField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "TextField", typeof(UnityEngine.Rect), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "TextField", typeof(string), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "TextField", typeof(int), 2);
                        }
                        UnityEngine.GUIStyle arg3;
                        if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "TextField", typeof(UnityEngine.GUIStyle), 3);
                        }
                        var ret = UnityEngine.GUI.TextField(arg0, arg1, arg2, arg3);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(int)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "TextField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "TextField", typeof(string), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "TextField", typeof(int), 2);
                            }
                            var ret = UnityEngine.GUI.TextField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "TextField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "TextField", typeof(string), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "TextField", typeof(UnityEngine.GUIStyle), 2);
                            }
                            var ret = UnityEngine.GUI.TextField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "TextField", typeof(UnityEngine.Rect), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "TextField", typeof(string), 1);
                        }
                        var ret = UnityEngine.GUI.TextField(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("TextField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_PasswordField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "PasswordField", typeof(UnityEngine.Rect), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "PasswordField", typeof(string), 1);
                        }
                        char arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "PasswordField", typeof(char), 2);
                        }
                        int arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "PasswordField", typeof(int), 3);
                        }
                        UnityEngine.GUIStyle arg4;
                        if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "PasswordField", typeof(UnityEngine.GUIStyle), 4);
                        }
                        var ret = UnityEngine.GUI.PasswordField(arg0, arg1, arg2, arg3, arg4);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(char)) && Values.js_match_type(ctx, argv[3], typeof(int)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "PasswordField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "PasswordField", typeof(string), 1);
                            }
                            char arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "PasswordField", typeof(char), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "PasswordField", typeof(int), 3);
                            }
                            var ret = UnityEngine.GUI.PasswordField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(char)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "PasswordField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "PasswordField", typeof(string), 1);
                            }
                            char arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "PasswordField", typeof(char), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "PasswordField", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEngine.GUI.PasswordField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "PasswordField", typeof(UnityEngine.Rect), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "PasswordField", typeof(string), 1);
                        }
                        char arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "PasswordField", typeof(char), 2);
                        }
                        var ret = UnityEngine.GUI.PasswordField(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("PasswordField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_TextArea(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "TextArea", typeof(UnityEngine.Rect), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "TextArea", typeof(string), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "TextArea", typeof(int), 2);
                        }
                        UnityEngine.GUIStyle arg3;
                        if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "TextArea", typeof(UnityEngine.GUIStyle), 3);
                        }
                        var ret = UnityEngine.GUI.TextArea(arg0, arg1, arg2, arg3);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(int)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "TextArea", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "TextArea", typeof(string), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "TextArea", typeof(int), 2);
                            }
                            var ret = UnityEngine.GUI.TextArea(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "TextArea", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "TextArea", typeof(string), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "TextArea", typeof(UnityEngine.GUIStyle), 2);
                            }
                            var ret = UnityEngine.GUI.TextArea(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "TextArea", typeof(UnityEngine.Rect), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "TextArea", typeof(string), 1);
                        }
                        var ret = UnityEngine.GUI.TextArea(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("TextArea", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Toggle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "Toggle", typeof(UnityEngine.Rect), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "Toggle", typeof(int), 1);
                        }
                        bool arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "Toggle", typeof(bool), 2);
                        }
                        UnityEngine.GUIContent arg3;
                        if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "Toggle", typeof(UnityEngine.GUIContent), 3);
                        }
                        UnityEngine.GUIStyle arg4;
                        if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "Toggle", typeof(UnityEngine.GUIStyle), 4);
                        }
                        var ret = UnityEngine.GUI.Toggle(arg0, arg1, arg2, arg3, arg4);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_type(ctx, argv[2], typeof(string)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toggle", typeof(UnityEngine.Rect), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toggle", typeof(bool), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toggle", typeof(string), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toggle", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEngine.GUI.Toggle(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Texture)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toggle", typeof(UnityEngine.Rect), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toggle", typeof(bool), 1);
                            }
                            UnityEngine.Texture arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toggle", typeof(UnityEngine.Texture), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toggle", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEngine.GUI.Toggle(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toggle", typeof(UnityEngine.Rect), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toggle", typeof(bool), 1);
                            }
                            UnityEngine.GUIContent arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toggle", typeof(UnityEngine.GUIContent), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toggle", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEngine.GUI.Toggle(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_type(ctx, argv[2], typeof(string)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toggle", typeof(UnityEngine.Rect), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toggle", typeof(bool), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toggle", typeof(string), 2);
                            }
                            var ret = UnityEngine.GUI.Toggle(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Texture)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toggle", typeof(UnityEngine.Rect), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toggle", typeof(bool), 1);
                            }
                            UnityEngine.Texture arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toggle", typeof(UnityEngine.Texture), 2);
                            }
                            var ret = UnityEngine.GUI.Toggle(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIContent)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toggle", typeof(UnityEngine.Rect), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toggle", typeof(bool), 1);
                            }
                            UnityEngine.GUIContent arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toggle", typeof(UnityEngine.GUIContent), 2);
                            }
                            var ret = UnityEngine.GUI.Toggle(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Toggle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Toolbar(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "Toolbar", typeof(UnityEngine.Rect), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "Toolbar", typeof(int), 1);
                        }
                        UnityEngine.GUIContent[] arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "Toolbar", typeof(UnityEngine.GUIContent[]), 2);
                        }
                        UnityEngine.GUIStyle arg3;
                        if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "Toolbar", typeof(UnityEngine.GUIStyle), 3);
                        }
                        UnityEngine.GUI.ToolbarButtonSize arg4;
                        if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "Toolbar", typeof(UnityEngine.GUI.ToolbarButtonSize), 4);
                        }
                        var ret = UnityEngine.GUI.Toolbar(arg0, arg1, arg2, arg3, arg4);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(string[])) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toolbar", typeof(UnityEngine.Rect), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toolbar", typeof(int), 1);
                            }
                            string[] arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toolbar", typeof(string[]), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toolbar", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEngine.GUI.Toolbar(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Texture[])) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toolbar", typeof(UnityEngine.Rect), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toolbar", typeof(int), 1);
                            }
                            UnityEngine.Texture[] arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toolbar", typeof(UnityEngine.Texture[]), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toolbar", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEngine.GUI.Toolbar(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIContent[])) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toolbar", typeof(UnityEngine.Rect), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toolbar", typeof(int), 1);
                            }
                            UnityEngine.GUIContent[] arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toolbar", typeof(UnityEngine.GUIContent[]), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toolbar", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEngine.GUI.Toolbar(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(string[])))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toolbar", typeof(UnityEngine.Rect), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toolbar", typeof(int), 1);
                            }
                            string[] arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toolbar", typeof(string[]), 2);
                            }
                            var ret = UnityEngine.GUI.Toolbar(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Texture[])))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toolbar", typeof(UnityEngine.Rect), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toolbar", typeof(int), 1);
                            }
                            UnityEngine.Texture[] arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toolbar", typeof(UnityEngine.Texture[]), 2);
                            }
                            var ret = UnityEngine.GUI.Toolbar(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIContent[])))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toolbar", typeof(UnityEngine.Rect), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toolbar", typeof(int), 1);
                            }
                            UnityEngine.GUIContent[] arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Toolbar", typeof(UnityEngine.GUIContent[]), 2);
                            }
                            var ret = UnityEngine.GUI.Toolbar(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Toolbar", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SelectionGrid(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(string[])) && Values.js_match_type(ctx, argv[3], typeof(int)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "SelectionGrid", typeof(UnityEngine.Rect), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "SelectionGrid", typeof(int), 1);
                            }
                            string[] arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "SelectionGrid", typeof(string[]), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "SelectionGrid", typeof(int), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "SelectionGrid", typeof(UnityEngine.GUIStyle), 4);
                            }
                            var ret = UnityEngine.GUI.SelectionGrid(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Texture[])) && Values.js_match_type(ctx, argv[3], typeof(int)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "SelectionGrid", typeof(UnityEngine.Rect), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "SelectionGrid", typeof(int), 1);
                            }
                            UnityEngine.Texture[] arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "SelectionGrid", typeof(UnityEngine.Texture[]), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "SelectionGrid", typeof(int), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "SelectionGrid", typeof(UnityEngine.GUIStyle), 4);
                            }
                            var ret = UnityEngine.GUI.SelectionGrid(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIContent[])) && Values.js_match_type(ctx, argv[3], typeof(int)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "SelectionGrid", typeof(UnityEngine.Rect), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "SelectionGrid", typeof(int), 1);
                            }
                            UnityEngine.GUIContent[] arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "SelectionGrid", typeof(UnityEngine.GUIContent[]), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "SelectionGrid", typeof(int), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "SelectionGrid", typeof(UnityEngine.GUIStyle), 4);
                            }
                            var ret = UnityEngine.GUI.SelectionGrid(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(string[])) && Values.js_match_type(ctx, argv[3], typeof(int)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "SelectionGrid", typeof(UnityEngine.Rect), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "SelectionGrid", typeof(int), 1);
                            }
                            string[] arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "SelectionGrid", typeof(string[]), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "SelectionGrid", typeof(int), 3);
                            }
                            var ret = UnityEngine.GUI.SelectionGrid(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Texture[])) && Values.js_match_type(ctx, argv[3], typeof(int)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "SelectionGrid", typeof(UnityEngine.Rect), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "SelectionGrid", typeof(int), 1);
                            }
                            UnityEngine.Texture[] arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "SelectionGrid", typeof(UnityEngine.Texture[]), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "SelectionGrid", typeof(int), 3);
                            }
                            var ret = UnityEngine.GUI.SelectionGrid(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIContent[])) && Values.js_match_type(ctx, argv[3], typeof(int)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "SelectionGrid", typeof(UnityEngine.Rect), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "SelectionGrid", typeof(int), 1);
                            }
                            UnityEngine.GUIContent[] arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "SelectionGrid", typeof(UnityEngine.GUIContent[]), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "SelectionGrid", typeof(int), 3);
                            }
                            var ret = UnityEngine.GUI.SelectionGrid(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("SelectionGrid", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_HorizontalSlider(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 7)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "HorizontalSlider", typeof(UnityEngine.Rect), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "HorizontalSlider", typeof(float), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "HorizontalSlider", typeof(float), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "HorizontalSlider", typeof(float), 3);
                        }
                        UnityEngine.GUIStyle arg4;
                        if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "HorizontalSlider", typeof(UnityEngine.GUIStyle), 4);
                        }
                        UnityEngine.GUIStyle arg5;
                        if (!Values.js_get_classvalue(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "HorizontalSlider", typeof(UnityEngine.GUIStyle), 5);
                        }
                        UnityEngine.GUIStyle arg6;
                        if (!Values.js_get_classvalue(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "HorizontalSlider", typeof(UnityEngine.GUIStyle), 6);
                        }
                        var ret = UnityEngine.GUI.HorizontalSlider(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 6)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "HorizontalSlider", typeof(UnityEngine.Rect), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "HorizontalSlider", typeof(float), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "HorizontalSlider", typeof(float), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "HorizontalSlider", typeof(float), 3);
                        }
                        UnityEngine.GUIStyle arg4;
                        if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "HorizontalSlider", typeof(UnityEngine.GUIStyle), 4);
                        }
                        UnityEngine.GUIStyle arg5;
                        if (!Values.js_get_classvalue(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "HorizontalSlider", typeof(UnityEngine.GUIStyle), 5);
                        }
                        var ret = UnityEngine.GUI.HorizontalSlider(arg0, arg1, arg2, arg3, arg4, arg5);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 4)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "HorizontalSlider", typeof(UnityEngine.Rect), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "HorizontalSlider", typeof(float), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "HorizontalSlider", typeof(float), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "HorizontalSlider", typeof(float), 3);
                        }
                        var ret = UnityEngine.GUI.HorizontalSlider(arg0, arg1, arg2, arg3);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("HorizontalSlider", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_VerticalSlider(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 7)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "VerticalSlider", typeof(UnityEngine.Rect), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "VerticalSlider", typeof(float), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "VerticalSlider", typeof(float), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "VerticalSlider", typeof(float), 3);
                        }
                        UnityEngine.GUIStyle arg4;
                        if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "VerticalSlider", typeof(UnityEngine.GUIStyle), 4);
                        }
                        UnityEngine.GUIStyle arg5;
                        if (!Values.js_get_classvalue(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "VerticalSlider", typeof(UnityEngine.GUIStyle), 5);
                        }
                        UnityEngine.GUIStyle arg6;
                        if (!Values.js_get_classvalue(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "VerticalSlider", typeof(UnityEngine.GUIStyle), 6);
                        }
                        var ret = UnityEngine.GUI.VerticalSlider(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 6)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "VerticalSlider", typeof(UnityEngine.Rect), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "VerticalSlider", typeof(float), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "VerticalSlider", typeof(float), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "VerticalSlider", typeof(float), 3);
                        }
                        UnityEngine.GUIStyle arg4;
                        if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "VerticalSlider", typeof(UnityEngine.GUIStyle), 4);
                        }
                        UnityEngine.GUIStyle arg5;
                        if (!Values.js_get_classvalue(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "VerticalSlider", typeof(UnityEngine.GUIStyle), 5);
                        }
                        var ret = UnityEngine.GUI.VerticalSlider(arg0, arg1, arg2, arg3, arg4, arg5);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 4)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "VerticalSlider", typeof(UnityEngine.Rect), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "VerticalSlider", typeof(float), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "VerticalSlider", typeof(float), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "VerticalSlider", typeof(float), 3);
                        }
                        var ret = UnityEngine.GUI.VerticalSlider(arg0, arg1, arg2, arg3);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("VerticalSlider", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Slider(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 10)
                {
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUI), "Slider", typeof(UnityEngine.Rect), 0);
                    }
                    float arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUI), "Slider", typeof(float), 1);
                    }
                    float arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUI), "Slider", typeof(float), 2);
                    }
                    float arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUI), "Slider", typeof(float), 3);
                    }
                    float arg4;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUI), "Slider", typeof(float), 4);
                    }
                    UnityEngine.GUIStyle arg5;
                    if (!Values.js_get_classvalue(ctx, argv[5], out arg5))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUI), "Slider", typeof(UnityEngine.GUIStyle), 5);
                    }
                    UnityEngine.GUIStyle arg6;
                    if (!Values.js_get_classvalue(ctx, argv[6], out arg6))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUI), "Slider", typeof(UnityEngine.GUIStyle), 6);
                    }
                    bool arg7;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[7], out arg7))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUI), "Slider", typeof(bool), 7);
                    }
                    int arg8;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[8], out arg8))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUI), "Slider", typeof(int), 8);
                    }
                    UnityEngine.GUIStyle arg9;
                    if (!Values.js_get_classvalue(ctx, argv[9], out arg9))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUI), "Slider", typeof(UnityEngine.GUIStyle), 9);
                    }
                    var ret = UnityEngine.GUI.Slider(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("Slider", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_HorizontalScrollbar(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 6)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "HorizontalScrollbar", typeof(UnityEngine.Rect), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "HorizontalScrollbar", typeof(float), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "HorizontalScrollbar", typeof(float), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "HorizontalScrollbar", typeof(float), 3);
                        }
                        float arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "HorizontalScrollbar", typeof(float), 4);
                        }
                        UnityEngine.GUIStyle arg5;
                        if (!Values.js_get_classvalue(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "HorizontalScrollbar", typeof(UnityEngine.GUIStyle), 5);
                        }
                        var ret = UnityEngine.GUI.HorizontalScrollbar(arg0, arg1, arg2, arg3, arg4, arg5);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 5)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "HorizontalScrollbar", typeof(UnityEngine.Rect), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "HorizontalScrollbar", typeof(float), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "HorizontalScrollbar", typeof(float), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "HorizontalScrollbar", typeof(float), 3);
                        }
                        float arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "HorizontalScrollbar", typeof(float), 4);
                        }
                        var ret = UnityEngine.GUI.HorizontalScrollbar(arg0, arg1, arg2, arg3, arg4);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("HorizontalScrollbar", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_VerticalScrollbar(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 6)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "VerticalScrollbar", typeof(UnityEngine.Rect), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "VerticalScrollbar", typeof(float), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "VerticalScrollbar", typeof(float), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "VerticalScrollbar", typeof(float), 3);
                        }
                        float arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "VerticalScrollbar", typeof(float), 4);
                        }
                        UnityEngine.GUIStyle arg5;
                        if (!Values.js_get_classvalue(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "VerticalScrollbar", typeof(UnityEngine.GUIStyle), 5);
                        }
                        var ret = UnityEngine.GUI.VerticalScrollbar(arg0, arg1, arg2, arg3, arg4, arg5);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 5)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "VerticalScrollbar", typeof(UnityEngine.Rect), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "VerticalScrollbar", typeof(float), 1);
                        }
                        float arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "VerticalScrollbar", typeof(float), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "VerticalScrollbar", typeof(float), 3);
                        }
                        float arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "VerticalScrollbar", typeof(float), 4);
                        }
                        var ret = UnityEngine.GUI.VerticalScrollbar(arg0, arg1, arg2, arg3, arg4);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("VerticalScrollbar", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BeginClip(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "BeginClip", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Vector2 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "BeginClip", typeof(UnityEngine.Vector2), 1);
                        }
                        UnityEngine.Vector2 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "BeginClip", typeof(UnityEngine.Vector2), 2);
                        }
                        bool arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "BeginClip", typeof(bool), 3);
                        }
                        UnityEngine.GUI.BeginClip(arg0, arg1, arg2, arg3);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "BeginClip", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.GUI.BeginClip(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("BeginClip", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BeginGroup(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "BeginGroup", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "BeginGroup", typeof(string), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "BeginGroup", typeof(UnityEngine.GUIStyle), 2);
                            }
                            UnityEngine.GUI.BeginGroup(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Texture)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "BeginGroup", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.Texture arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "BeginGroup", typeof(UnityEngine.Texture), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "BeginGroup", typeof(UnityEngine.GUIStyle), 2);
                            }
                            UnityEngine.GUI.BeginGroup(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "BeginGroup", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "BeginGroup", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "BeginGroup", typeof(UnityEngine.GUIStyle), 2);
                            }
                            UnityEngine.GUI.BeginGroup(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "BeginGroup", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "BeginGroup", typeof(string), 1);
                            }
                            UnityEngine.GUI.BeginGroup(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Texture)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "BeginGroup", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.Texture arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "BeginGroup", typeof(UnityEngine.Texture), 1);
                            }
                            UnityEngine.GUI.BeginGroup(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "BeginGroup", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "BeginGroup", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.GUI.BeginGroup(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "BeginGroup", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIStyle arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "BeginGroup", typeof(UnityEngine.GUIStyle), 1);
                            }
                            UnityEngine.GUI.BeginGroup(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "BeginGroup", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.GUI.BeginGroup(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("BeginGroup", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_EndGroup(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.GUI.EndGroup();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("EndGroup", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_EndClip(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.GUI.EndClip();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("EndClip", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BeginScrollView(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 7)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "BeginScrollView", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Vector2 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "BeginScrollView", typeof(UnityEngine.Vector2), 1);
                        }
                        UnityEngine.Rect arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "BeginScrollView", typeof(UnityEngine.Rect), 2);
                        }
                        bool arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "BeginScrollView", typeof(bool), 3);
                        }
                        bool arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "BeginScrollView", typeof(bool), 4);
                        }
                        UnityEngine.GUIStyle arg5;
                        if (!Values.js_get_classvalue(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "BeginScrollView", typeof(UnityEngine.GUIStyle), 5);
                        }
                        UnityEngine.GUIStyle arg6;
                        if (!Values.js_get_classvalue(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "BeginScrollView", typeof(UnityEngine.GUIStyle), 6);
                        }
                        var ret = UnityEngine.GUI.BeginScrollView(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector2)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[3], typeof(bool)) && Values.js_match_type(ctx, argv[4], typeof(bool)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "BeginScrollView", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.Vector2 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "BeginScrollView", typeof(UnityEngine.Vector2), 1);
                            }
                            UnityEngine.Rect arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "BeginScrollView", typeof(UnityEngine.Rect), 2);
                            }
                            bool arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "BeginScrollView", typeof(bool), 3);
                            }
                            bool arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "BeginScrollView", typeof(bool), 4);
                            }
                            var ret = UnityEngine.GUI.BeginScrollView(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector2)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "BeginScrollView", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.Vector2 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "BeginScrollView", typeof(UnityEngine.Vector2), 1);
                            }
                            UnityEngine.Rect arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "BeginScrollView", typeof(UnityEngine.Rect), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "BeginScrollView", typeof(UnityEngine.GUIStyle), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "BeginScrollView", typeof(UnityEngine.GUIStyle), 4);
                            }
                            var ret = UnityEngine.GUI.BeginScrollView(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "BeginScrollView", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Vector2 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "BeginScrollView", typeof(UnityEngine.Vector2), 1);
                        }
                        UnityEngine.Rect arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "BeginScrollView", typeof(UnityEngine.Rect), 2);
                        }
                        var ret = UnityEngine.GUI.BeginScrollView(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("BeginScrollView", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_EndScrollView(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        bool arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUI), "EndScrollView", typeof(bool), 0);
                        }
                        UnityEngine.GUI.EndScrollView(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 0)
                    {
                        UnityEngine.GUI.EndScrollView();
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("EndScrollView", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ScrollTo(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUI), "ScrollTo", typeof(UnityEngine.Rect), 0);
                    }
                    UnityEngine.GUI.ScrollTo(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ScrollTo", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ScrollTowards(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUI), "ScrollTowards", typeof(UnityEngine.Rect), 0);
                    }
                    float arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUI), "ScrollTowards", typeof(float), 1);
                    }
                    var ret = UnityEngine.GUI.ScrollTowards(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ScrollTowards", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Window(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUI.WindowFunction)) && Values.js_match_type(ctx, argv[3], typeof(string)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Window", typeof(int), 0);
                            }
                            UnityEngine.Rect arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Window", typeof(UnityEngine.Rect), 1);
                            }
                            UnityEngine.GUI.WindowFunction arg2;
                            if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Window", typeof(UnityEngine.GUI.WindowFunction), 2);
                            }
                            string arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Window", typeof(string), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Window", typeof(UnityEngine.GUIStyle), 4);
                            }
                            var ret = UnityEngine.GUI.Window(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUI.WindowFunction)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Texture)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Window", typeof(int), 0);
                            }
                            UnityEngine.Rect arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Window", typeof(UnityEngine.Rect), 1);
                            }
                            UnityEngine.GUI.WindowFunction arg2;
                            if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Window", typeof(UnityEngine.GUI.WindowFunction), 2);
                            }
                            UnityEngine.Texture arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Window", typeof(UnityEngine.Texture), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Window", typeof(UnityEngine.GUIStyle), 4);
                            }
                            var ret = UnityEngine.GUI.Window(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUI.WindowFunction)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Window", typeof(int), 0);
                            }
                            UnityEngine.Rect arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Window", typeof(UnityEngine.Rect), 1);
                            }
                            UnityEngine.GUI.WindowFunction arg2;
                            if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Window", typeof(UnityEngine.GUI.WindowFunction), 2);
                            }
                            UnityEngine.GUIContent arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Window", typeof(UnityEngine.GUIContent), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Window", typeof(UnityEngine.GUIStyle), 4);
                            }
                            var ret = UnityEngine.GUI.Window(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUI.WindowFunction)) && Values.js_match_type(ctx, argv[3], typeof(string)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Window", typeof(int), 0);
                            }
                            UnityEngine.Rect arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Window", typeof(UnityEngine.Rect), 1);
                            }
                            UnityEngine.GUI.WindowFunction arg2;
                            if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Window", typeof(UnityEngine.GUI.WindowFunction), 2);
                            }
                            string arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Window", typeof(string), 3);
                            }
                            var ret = UnityEngine.GUI.Window(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUI.WindowFunction)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Texture)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Window", typeof(int), 0);
                            }
                            UnityEngine.Rect arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Window", typeof(UnityEngine.Rect), 1);
                            }
                            UnityEngine.GUI.WindowFunction arg2;
                            if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Window", typeof(UnityEngine.GUI.WindowFunction), 2);
                            }
                            UnityEngine.Texture arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Window", typeof(UnityEngine.Texture), 3);
                            }
                            var ret = UnityEngine.GUI.Window(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUI.WindowFunction)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIContent)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Window", typeof(int), 0);
                            }
                            UnityEngine.Rect arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Window", typeof(UnityEngine.Rect), 1);
                            }
                            UnityEngine.GUI.WindowFunction arg2;
                            if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Window", typeof(UnityEngine.GUI.WindowFunction), 2);
                            }
                            UnityEngine.GUIContent arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "Window", typeof(UnityEngine.GUIContent), 3);
                            }
                            var ret = UnityEngine.GUI.Window(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Window", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ModalWindow(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUI.WindowFunction)) && Values.js_match_type(ctx, argv[3], typeof(string)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "ModalWindow", typeof(int), 0);
                            }
                            UnityEngine.Rect arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "ModalWindow", typeof(UnityEngine.Rect), 1);
                            }
                            UnityEngine.GUI.WindowFunction arg2;
                            if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "ModalWindow", typeof(UnityEngine.GUI.WindowFunction), 2);
                            }
                            string arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "ModalWindow", typeof(string), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "ModalWindow", typeof(UnityEngine.GUIStyle), 4);
                            }
                            var ret = UnityEngine.GUI.ModalWindow(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUI.WindowFunction)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Texture)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "ModalWindow", typeof(int), 0);
                            }
                            UnityEngine.Rect arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "ModalWindow", typeof(UnityEngine.Rect), 1);
                            }
                            UnityEngine.GUI.WindowFunction arg2;
                            if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "ModalWindow", typeof(UnityEngine.GUI.WindowFunction), 2);
                            }
                            UnityEngine.Texture arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "ModalWindow", typeof(UnityEngine.Texture), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "ModalWindow", typeof(UnityEngine.GUIStyle), 4);
                            }
                            var ret = UnityEngine.GUI.ModalWindow(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUI.WindowFunction)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "ModalWindow", typeof(int), 0);
                            }
                            UnityEngine.Rect arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "ModalWindow", typeof(UnityEngine.Rect), 1);
                            }
                            UnityEngine.GUI.WindowFunction arg2;
                            if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "ModalWindow", typeof(UnityEngine.GUI.WindowFunction), 2);
                            }
                            UnityEngine.GUIContent arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "ModalWindow", typeof(UnityEngine.GUIContent), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "ModalWindow", typeof(UnityEngine.GUIStyle), 4);
                            }
                            var ret = UnityEngine.GUI.ModalWindow(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUI.WindowFunction)) && Values.js_match_type(ctx, argv[3], typeof(string)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "ModalWindow", typeof(int), 0);
                            }
                            UnityEngine.Rect arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "ModalWindow", typeof(UnityEngine.Rect), 1);
                            }
                            UnityEngine.GUI.WindowFunction arg2;
                            if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "ModalWindow", typeof(UnityEngine.GUI.WindowFunction), 2);
                            }
                            string arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "ModalWindow", typeof(string), 3);
                            }
                            var ret = UnityEngine.GUI.ModalWindow(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUI.WindowFunction)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Texture)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "ModalWindow", typeof(int), 0);
                            }
                            UnityEngine.Rect arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "ModalWindow", typeof(UnityEngine.Rect), 1);
                            }
                            UnityEngine.GUI.WindowFunction arg2;
                            if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "ModalWindow", typeof(UnityEngine.GUI.WindowFunction), 2);
                            }
                            UnityEngine.Texture arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "ModalWindow", typeof(UnityEngine.Texture), 3);
                            }
                            var ret = UnityEngine.GUI.ModalWindow(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUI.WindowFunction)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIContent)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "ModalWindow", typeof(int), 0);
                            }
                            UnityEngine.Rect arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "ModalWindow", typeof(UnityEngine.Rect), 1);
                            }
                            UnityEngine.GUI.WindowFunction arg2;
                            if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "ModalWindow", typeof(UnityEngine.GUI.WindowFunction), 2);
                            }
                            UnityEngine.GUIContent arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUI), "ModalWindow", typeof(UnityEngine.GUIContent), 3);
                            }
                            var ret = UnityEngine.GUI.ModalWindow(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("ModalWindow", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_color(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.GUI.color;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_color(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Color value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUI), "color", typeof(UnityEngine.Color), 0);
                }
                UnityEngine.GUI.color = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_backgroundColor(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.GUI.backgroundColor;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_backgroundColor(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Color value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUI), "backgroundColor", typeof(UnityEngine.Color), 0);
                }
                UnityEngine.GUI.backgroundColor = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_contentColor(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.GUI.contentColor;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_contentColor(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Color value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUI), "contentColor", typeof(UnityEngine.Color), 0);
                }
                UnityEngine.GUI.contentColor = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_changed(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.GUI.changed;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_changed(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUI), "changed", typeof(bool), 0);
                }
                UnityEngine.GUI.changed = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_enabled(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.GUI.enabled;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_enabled(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUI), "enabled", typeof(bool), 0);
                }
                UnityEngine.GUI.enabled = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_depth(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.GUI.depth;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_depth(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUI), "depth", typeof(int), 0);
                }
                UnityEngine.GUI.depth = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_skin(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.GUI.skin;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_skin(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUISkin value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUI), "skin", typeof(UnityEngine.GUISkin), 0);
                }
                UnityEngine.GUI.skin = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_matrix(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.GUI.matrix;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_matrix(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Matrix4x4 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUI), "matrix", typeof(UnityEngine.Matrix4x4), 0);
                }
                UnityEngine.GUI.matrix = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_tooltip(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.GUI.tooltip;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_tooltip(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUI), "tooltip", typeof(string), 0);
                }
                UnityEngine.GUI.tooltip = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("GUI", typeof(UnityEngine.GUI), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "SetNextControlName", BindStatic_SetNextControlName);
            cls.AddMethod(true, "GetNameOfFocusedControl", BindStatic_GetNameOfFocusedControl);
            cls.AddMethod(true, "FocusControl", BindStatic_FocusControl);
            cls.AddMethod(true, "DragWindow", BindStatic_DragWindow);
            cls.AddMethod(true, "BringWindowToFront", BindStatic_BringWindowToFront);
            cls.AddMethod(true, "BringWindowToBack", BindStatic_BringWindowToBack);
            cls.AddMethod(true, "FocusWindow", BindStatic_FocusWindow);
            cls.AddMethod(true, "UnfocusWindow", BindStatic_UnfocusWindow);
            cls.AddMethod(true, "Label", BindStatic_Label);
            cls.AddMethod(true, "DrawTexture", BindStatic_DrawTexture);
            cls.AddMethod(true, "DrawTextureWithTexCoords", BindStatic_DrawTextureWithTexCoords);
            cls.AddMethod(true, "Box", BindStatic_Box);
            cls.AddMethod(true, "Button", BindStatic_Button);
            cls.AddMethod(true, "RepeatButton", BindStatic_RepeatButton);
            cls.AddMethod(true, "TextField", BindStatic_TextField);
            cls.AddMethod(true, "PasswordField", BindStatic_PasswordField);
            cls.AddMethod(true, "TextArea", BindStatic_TextArea);
            cls.AddMethod(true, "Toggle", BindStatic_Toggle);
            cls.AddMethod(true, "Toolbar", BindStatic_Toolbar);
            cls.AddMethod(true, "SelectionGrid", BindStatic_SelectionGrid);
            cls.AddMethod(true, "HorizontalSlider", BindStatic_HorizontalSlider);
            cls.AddMethod(true, "VerticalSlider", BindStatic_VerticalSlider);
            cls.AddMethod(true, "Slider", BindStatic_Slider);
            cls.AddMethod(true, "HorizontalScrollbar", BindStatic_HorizontalScrollbar);
            cls.AddMethod(true, "VerticalScrollbar", BindStatic_VerticalScrollbar);
            cls.AddMethod(true, "BeginClip", BindStatic_BeginClip);
            cls.AddMethod(true, "BeginGroup", BindStatic_BeginGroup);
            cls.AddMethod(true, "EndGroup", BindStatic_EndGroup);
            cls.AddMethod(true, "EndClip", BindStatic_EndClip);
            cls.AddMethod(true, "BeginScrollView", BindStatic_BeginScrollView);
            cls.AddMethod(true, "EndScrollView", BindStatic_EndScrollView);
            cls.AddMethod(true, "ScrollTo", BindStatic_ScrollTo);
            cls.AddMethod(true, "ScrollTowards", BindStatic_ScrollTowards);
            cls.AddMethod(true, "Window", BindStatic_Window);
            cls.AddMethod(true, "ModalWindow", BindStatic_ModalWindow);
            cls.AddProperty(true, "color", BindStaticRead_color, BindStaticWrite_color);
            cls.AddProperty(true, "backgroundColor", BindStaticRead_backgroundColor, BindStaticWrite_backgroundColor);
            cls.AddProperty(true, "contentColor", BindStaticRead_contentColor, BindStaticWrite_contentColor);
            cls.AddProperty(true, "changed", BindStaticRead_changed, BindStaticWrite_changed);
            cls.AddProperty(true, "enabled", BindStaticRead_enabled, BindStaticWrite_enabled);
            cls.AddProperty(true, "depth", BindStaticRead_depth, BindStaticWrite_depth);
            cls.AddProperty(true, "skin", BindStaticRead_skin, BindStaticWrite_skin);
            cls.AddProperty(true, "matrix", BindStaticRead_matrix, BindStaticWrite_matrix);
            cls.AddProperty(true, "tooltip", BindStaticRead_tooltip, BindStaticWrite_tooltip);
            return cls;
        }
    }
}
#endif
