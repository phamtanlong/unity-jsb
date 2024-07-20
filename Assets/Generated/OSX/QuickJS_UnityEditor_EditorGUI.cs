#if UNITY_EDITOR
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
    // Assembly: UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2021.3.37f1/Unity.app/Contents/Managed/UnityEngine/UnityEditor.CoreModule.dll
    // Type: UnityEditor.EditorGUI
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_EditorGUI
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_FocusTextInControl(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUI), "FocusTextInControl", typeof(string), 0);
                    }
                    UnityEditor.EditorGUI.FocusTextInControl(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("FocusTextInControl", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BeginDisabledGroup(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    bool arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUI), "BeginDisabledGroup", typeof(bool), 0);
                    }
                    UnityEditor.EditorGUI.BeginDisabledGroup(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("BeginDisabledGroup", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_EndDisabledGroup(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorGUI.EndDisabledGroup();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("EndDisabledGroup", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BeginChangeCheck(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorGUI.BeginChangeCheck();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("BeginChangeCheck", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_EndChangeCheck(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.EditorGUI.EndChangeCheck();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("EndChangeCheck", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DropShadowLabel(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DropShadowLabel", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DropShadowLabel", typeof(string), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DropShadowLabel", typeof(UnityEngine.GUIStyle), 2);
                            }
                            UnityEditor.EditorGUI.DropShadowLabel(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DropShadowLabel", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DropShadowLabel", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DropShadowLabel", typeof(UnityEngine.GUIStyle), 2);
                            }
                            UnityEditor.EditorGUI.DropShadowLabel(arg0, arg1, arg2);
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
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DropShadowLabel", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DropShadowLabel", typeof(string), 1);
                            }
                            UnityEditor.EditorGUI.DropShadowLabel(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DropShadowLabel", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DropShadowLabel", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEditor.EditorGUI.DropShadowLabel(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("DropShadowLabel", argc);
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
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(bool)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Toggle", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Toggle", typeof(string), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Toggle", typeof(bool), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Toggle", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.Toggle(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(bool)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Toggle", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Toggle", typeof(UnityEngine.GUIContent), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Toggle", typeof(bool), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Toggle", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.Toggle(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(bool)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Toggle", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Toggle", typeof(string), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Toggle", typeof(bool), 2);
                            }
                            var ret = UnityEditor.EditorGUI.Toggle(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Toggle", typeof(UnityEngine.Rect), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Toggle", typeof(bool), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Toggle", typeof(UnityEngine.GUIStyle), 2);
                            }
                            var ret = UnityEditor.EditorGUI.Toggle(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(bool)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Toggle", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Toggle", typeof(UnityEngine.GUIContent), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Toggle", typeof(bool), 2);
                            }
                            var ret = UnityEditor.EditorGUI.Toggle(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "Toggle", typeof(UnityEngine.Rect), 0);
                        }
                        bool arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "Toggle", typeof(bool), 1);
                        }
                        var ret = UnityEditor.EditorGUI.Toggle(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
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
        public static JSValue BindStatic_Slider(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(float)) && Values.js_match_type(ctx, argv[4], typeof(float)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Slider", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Slider", typeof(string), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Slider", typeof(float), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Slider", typeof(float), 3);
                            }
                            float arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Slider", typeof(float), 4);
                            }
                            var ret = UnityEditor.EditorGUI.Slider(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(float)) && Values.js_match_type(ctx, argv[4], typeof(float)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Slider", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Slider", typeof(UnityEngine.GUIContent), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Slider", typeof(float), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Slider", typeof(float), 3);
                            }
                            float arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Slider", typeof(float), 4);
                            }
                            var ret = UnityEditor.EditorGUI.Slider(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(float)) && Values.js_match_type(ctx, argv[4], typeof(string)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Slider", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEditor.SerializedProperty arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Slider", typeof(UnityEditor.SerializedProperty), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Slider", typeof(float), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Slider", typeof(float), 3);
                            }
                            string arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Slider", typeof(string), 4);
                            }
                            UnityEditor.EditorGUI.Slider(arg0, arg1, arg2, arg3, arg4);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(float)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIContent)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Slider", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEditor.SerializedProperty arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Slider", typeof(UnityEditor.SerializedProperty), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Slider", typeof(float), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Slider", typeof(float), 3);
                            }
                            UnityEngine.GUIContent arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Slider", typeof(UnityEngine.GUIContent), 4);
                            }
                            UnityEditor.EditorGUI.Slider(arg0, arg1, arg2, arg3, arg4);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(float)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Slider", typeof(UnityEngine.Rect), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Slider", typeof(float), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Slider", typeof(float), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Slider", typeof(float), 3);
                            }
                            var ret = UnityEditor.EditorGUI.Slider(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(float)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Slider", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEditor.SerializedProperty arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Slider", typeof(UnityEditor.SerializedProperty), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Slider", typeof(float), 2);
                            }
                            float arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Slider", typeof(float), 3);
                            }
                            UnityEditor.EditorGUI.Slider(arg0, arg1, arg2, arg3);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Slider", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IntSlider(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(int)) && Values.js_match_type(ctx, argv[4], typeof(int)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntSlider", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntSlider", typeof(string), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntSlider", typeof(int), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntSlider", typeof(int), 3);
                            }
                            int arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntSlider", typeof(int), 4);
                            }
                            var ret = UnityEditor.EditorGUI.IntSlider(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(int)) && Values.js_match_type(ctx, argv[4], typeof(int)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntSlider", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntSlider", typeof(UnityEngine.GUIContent), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntSlider", typeof(int), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntSlider", typeof(int), 3);
                            }
                            int arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntSlider", typeof(int), 4);
                            }
                            var ret = UnityEditor.EditorGUI.IntSlider(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(int)) && Values.js_match_type(ctx, argv[4], typeof(string)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntSlider", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEditor.SerializedProperty arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntSlider", typeof(UnityEditor.SerializedProperty), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntSlider", typeof(int), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntSlider", typeof(int), 3);
                            }
                            string arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntSlider", typeof(string), 4);
                            }
                            UnityEditor.EditorGUI.IntSlider(arg0, arg1, arg2, arg3, arg4);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(int)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIContent)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntSlider", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEditor.SerializedProperty arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntSlider", typeof(UnityEditor.SerializedProperty), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntSlider", typeof(int), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntSlider", typeof(int), 3);
                            }
                            UnityEngine.GUIContent arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntSlider", typeof(UnityEngine.GUIContent), 4);
                            }
                            UnityEditor.EditorGUI.IntSlider(arg0, arg1, arg2, arg3, arg4);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(int)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntSlider", typeof(UnityEngine.Rect), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntSlider", typeof(int), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntSlider", typeof(int), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntSlider", typeof(int), 3);
                            }
                            var ret = UnityEditor.EditorGUI.IntSlider(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(int)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntSlider", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEditor.SerializedProperty arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntSlider", typeof(UnityEditor.SerializedProperty), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntSlider", typeof(int), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntSlider", typeof(int), 3);
                            }
                            UnityEditor.EditorGUI.IntSlider(arg0, arg1, arg2, arg3);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("IntSlider", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_MinMaxSlider(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 6)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type_hint(ctx, argv[2], typeof(float)) && Values.js_match_type_hint(ctx, argv[3], typeof(float)) && Values.js_match_type(ctx, argv[4], typeof(float)) && Values.js_match_type(ctx, argv[5], typeof(float)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MinMaxSlider", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MinMaxSlider", typeof(string), 1);
                            }
                            float arg2;
                            var refVal2 = Values.js_read_wrap(ctx, argv[2]);
                            if (refVal2.IsException())
                            {
                                return refVal2;
                            }
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, refVal2, out arg2))
                            {
                                JSApi.JS_FreeValue(ctx, refVal2);
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MinMaxSlider", typeof(float), 2);
                            }
                            JSApi.JS_FreeValue(ctx, refVal2);
                            float arg3;
                            var refVal3 = Values.js_read_wrap(ctx, argv[3]);
                            if (refVal3.IsException())
                            {
                                return refVal3;
                            }
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, refVal3, out arg3))
                            {
                                JSApi.JS_FreeValue(ctx, refVal3);
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MinMaxSlider", typeof(float), 3);
                            }
                            JSApi.JS_FreeValue(ctx, refVal3);
                            float arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MinMaxSlider", typeof(float), 4);
                            }
                            float arg5;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MinMaxSlider", typeof(float), 5);
                            }
                            UnityEditor.EditorGUI.MinMaxSlider(arg0, arg1, ref arg2, ref arg3, arg4, arg5);
                            var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg2);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out0);
                            var out1 = QuickJS.Binding.Values.js_push_primitive(ctx, arg3);
                            if (JSApi.JS_IsException(out1))
                            {
                                return out1;
                            }
                            JSApi.JS_SetProperty(ctx, argv[3], context.GetAtom("value"), out1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type_hint(ctx, argv[2], typeof(float)) && Values.js_match_type_hint(ctx, argv[3], typeof(float)) && Values.js_match_type(ctx, argv[4], typeof(float)) && Values.js_match_type(ctx, argv[5], typeof(float)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MinMaxSlider", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MinMaxSlider", typeof(UnityEngine.GUIContent), 1);
                            }
                            float arg2;
                            var refVal2 = Values.js_read_wrap(ctx, argv[2]);
                            if (refVal2.IsException())
                            {
                                return refVal2;
                            }
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, refVal2, out arg2))
                            {
                                JSApi.JS_FreeValue(ctx, refVal2);
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MinMaxSlider", typeof(float), 2);
                            }
                            JSApi.JS_FreeValue(ctx, refVal2);
                            float arg3;
                            var refVal3 = Values.js_read_wrap(ctx, argv[3]);
                            if (refVal3.IsException())
                            {
                                return refVal3;
                            }
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, refVal3, out arg3))
                            {
                                JSApi.JS_FreeValue(ctx, refVal3);
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MinMaxSlider", typeof(float), 3);
                            }
                            JSApi.JS_FreeValue(ctx, refVal3);
                            float arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MinMaxSlider", typeof(float), 4);
                            }
                            float arg5;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MinMaxSlider", typeof(float), 5);
                            }
                            UnityEditor.EditorGUI.MinMaxSlider(arg0, arg1, ref arg2, ref arg3, arg4, arg5);
                            var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg2);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out0);
                            var out1 = QuickJS.Binding.Values.js_push_primitive(ctx, arg3);
                            if (JSApi.JS_IsException(out1))
                            {
                                return out1;
                            }
                            JSApi.JS_SetProperty(ctx, argv[3], context.GetAtom("value"), out1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 5)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "MinMaxSlider", typeof(UnityEngine.Rect), 0);
                        }
                        float arg1;
                        var refVal1 = Values.js_read_wrap(ctx, argv[1]);
                        if (refVal1.IsException())
                        {
                            return refVal1;
                        }
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, refVal1, out arg1))
                        {
                            JSApi.JS_FreeValue(ctx, refVal1);
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "MinMaxSlider", typeof(float), 1);
                        }
                        JSApi.JS_FreeValue(ctx, refVal1);
                        float arg2;
                        var refVal2 = Values.js_read_wrap(ctx, argv[2]);
                        if (refVal2.IsException())
                        {
                            return refVal2;
                        }
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, refVal2, out arg2))
                        {
                            JSApi.JS_FreeValue(ctx, refVal2);
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "MinMaxSlider", typeof(float), 2);
                        }
                        JSApi.JS_FreeValue(ctx, refVal2);
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "MinMaxSlider", typeof(float), 3);
                        }
                        float arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "MinMaxSlider", typeof(float), 4);
                        }
                        UnityEditor.EditorGUI.MinMaxSlider(arg0, ref arg1, ref arg2, arg3, arg4);
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
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("MinMaxSlider", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_EnumFlagsField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumFlagsField", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.GUIContent arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumFlagsField", typeof(UnityEngine.GUIContent), 1);
                        }
                        System.Enum arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumFlagsField", typeof(System.Enum), 2);
                        }
                        bool arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumFlagsField", typeof(bool), 3);
                        }
                        UnityEngine.GUIStyle arg4;
                        if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumFlagsField", typeof(UnityEngine.GUIStyle), 4);
                        }
                        var ret = UnityEditor.EditorGUI.EnumFlagsField(arg0, arg1, arg2, arg3, arg4);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(System.Enum)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumFlagsField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumFlagsField", typeof(string), 1);
                            }
                            System.Enum arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumFlagsField", typeof(System.Enum), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumFlagsField", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.EnumFlagsField(arg0, arg1, arg2, arg3);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(System.Enum)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumFlagsField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumFlagsField", typeof(UnityEngine.GUIContent), 1);
                            }
                            System.Enum arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumFlagsField", typeof(System.Enum), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumFlagsField", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.EnumFlagsField(arg0, arg1, arg2, arg3);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(System.Enum)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumFlagsField", typeof(UnityEngine.Rect), 0);
                            }
                            System.Enum arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumFlagsField", typeof(System.Enum), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumFlagsField", typeof(UnityEngine.GUIStyle), 2);
                            }
                            var ret = UnityEditor.EditorGUI.EnumFlagsField(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(System.Enum)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumFlagsField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumFlagsField", typeof(string), 1);
                            }
                            System.Enum arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumFlagsField", typeof(System.Enum), 2);
                            }
                            var ret = UnityEditor.EditorGUI.EnumFlagsField(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(System.Enum)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumFlagsField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumFlagsField", typeof(UnityEngine.GUIContent), 1);
                            }
                            System.Enum arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumFlagsField", typeof(System.Enum), 2);
                            }
                            var ret = UnityEditor.EditorGUI.EnumFlagsField(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumFlagsField", typeof(UnityEngine.Rect), 0);
                        }
                        System.Enum arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumFlagsField", typeof(System.Enum), 1);
                        }
                        var ret = UnityEditor.EditorGUI.EnumFlagsField(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("EnumFlagsField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ObjectField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[3], typeof(System.Type)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.Object)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(string), 1);
                            }
                            UnityEngine.Object arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(UnityEngine.Object), 2);
                            }
                            System.Type arg3;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(System.Type), 3);
                            }
                            UnityEngine.Object arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(UnityEngine.Object), 4);
                            }
                            var ret = UnityEditor.EditorGUI.ObjectField(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[3], typeof(System.Type)) && Values.js_match_type(ctx, argv[4], typeof(bool)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(string), 1);
                            }
                            UnityEngine.Object arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(UnityEngine.Object), 2);
                            }
                            System.Type arg3;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(System.Type), 3);
                            }
                            bool arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(bool), 4);
                            }
                            var ret = UnityEditor.EditorGUI.ObjectField(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[3], typeof(System.Type)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.Object)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.Object arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(UnityEngine.Object), 2);
                            }
                            System.Type arg3;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(System.Type), 3);
                            }
                            UnityEngine.Object arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(UnityEngine.Object), 4);
                            }
                            var ret = UnityEditor.EditorGUI.ObjectField(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[3], typeof(System.Type)) && Values.js_match_type(ctx, argv[4], typeof(bool)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.Object arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(UnityEngine.Object), 2);
                            }
                            System.Type arg3;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(System.Type), 3);
                            }
                            bool arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(bool), 4);
                            }
                            var ret = UnityEditor.EditorGUI.ObjectField(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[2], typeof(System.Type)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIContent)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEditor.SerializedProperty arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(UnityEditor.SerializedProperty), 1);
                            }
                            System.Type arg2;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(System.Type), 2);
                            }
                            UnityEngine.GUIContent arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(UnityEngine.GUIContent), 3);
                            }
                            UnityEditor.EditorGUI.ObjectField(arg0, arg1, arg2, arg3);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[2], typeof(System.Type)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Object)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.Object arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(UnityEngine.Object), 1);
                            }
                            System.Type arg2;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(System.Type), 2);
                            }
                            UnityEngine.Object arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(UnityEngine.Object), 3);
                            }
                            var ret = UnityEditor.EditorGUI.ObjectField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[2], typeof(System.Type)) && Values.js_match_type(ctx, argv[3], typeof(bool)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.Object arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(UnityEngine.Object), 1);
                            }
                            System.Type arg2;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(System.Type), 2);
                            }
                            bool arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(bool), 3);
                            }
                            var ret = UnityEditor.EditorGUI.ObjectField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIContent)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEditor.SerializedProperty arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(UnityEditor.SerializedProperty), 1);
                            }
                            UnityEngine.GUIContent arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(UnityEngine.GUIContent), 2);
                            }
                            UnityEditor.EditorGUI.ObjectField(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[2], typeof(System.Type)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEditor.SerializedProperty arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(UnityEditor.SerializedProperty), 1);
                            }
                            System.Type arg2;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(System.Type), 2);
                            }
                            UnityEditor.EditorGUI.ObjectField(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEditor.SerializedProperty arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "ObjectField", typeof(UnityEditor.SerializedProperty), 1);
                        }
                        UnityEditor.EditorGUI.ObjectField(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("ObjectField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IndentedRect(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUI), "IndentedRect", typeof(UnityEngine.Rect), 0);
                    }
                    var ret = UnityEditor.EditorGUI.IndentedRect(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("IndentedRect", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Vector2Field(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector2)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Vector2Field", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Vector2Field", typeof(string), 1);
                            }
                            UnityEngine.Vector2 arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Vector2Field", typeof(UnityEngine.Vector2), 2);
                            }
                            var ret = UnityEditor.EditorGUI.Vector2Field(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector2)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Vector2Field", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Vector2Field", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.Vector2 arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Vector2Field", typeof(UnityEngine.Vector2), 2);
                            }
                            var ret = UnityEditor.EditorGUI.Vector2Field(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Vector2Field", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Vector3Field(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector3)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Vector3Field", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Vector3Field", typeof(string), 1);
                            }
                            UnityEngine.Vector3 arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Vector3Field", typeof(UnityEngine.Vector3), 2);
                            }
                            var ret = UnityEditor.EditorGUI.Vector3Field(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector3)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Vector3Field", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Vector3Field", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.Vector3 arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Vector3Field", typeof(UnityEngine.Vector3), 2);
                            }
                            var ret = UnityEditor.EditorGUI.Vector3Field(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Vector3Field", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Vector4Field(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector4)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Vector4Field", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Vector4Field", typeof(string), 1);
                            }
                            UnityEngine.Vector4 arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Vector4Field", typeof(UnityEngine.Vector4), 2);
                            }
                            var ret = UnityEditor.EditorGUI.Vector4Field(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector4)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Vector4Field", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Vector4Field", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.Vector4 arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Vector4Field", typeof(UnityEngine.Vector4), 2);
                            }
                            var ret = UnityEditor.EditorGUI.Vector4Field(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Vector4Field", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Vector2IntField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector2Int)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Vector2IntField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Vector2IntField", typeof(string), 1);
                            }
                            UnityEngine.Vector2Int arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Vector2IntField", typeof(UnityEngine.Vector2Int), 2);
                            }
                            var ret = UnityEditor.EditorGUI.Vector2IntField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector2Int)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Vector2IntField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Vector2IntField", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.Vector2Int arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Vector2IntField", typeof(UnityEngine.Vector2Int), 2);
                            }
                            var ret = UnityEditor.EditorGUI.Vector2IntField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Vector2IntField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Vector3IntField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector3Int)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Vector3IntField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Vector3IntField", typeof(string), 1);
                            }
                            UnityEngine.Vector3Int arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Vector3IntField", typeof(UnityEngine.Vector3Int), 2);
                            }
                            var ret = UnityEditor.EditorGUI.Vector3IntField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Vector3Int)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Vector3IntField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Vector3IntField", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.Vector3Int arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Vector3IntField", typeof(UnityEngine.Vector3Int), 2);
                            }
                            var ret = UnityEditor.EditorGUI.Vector3IntField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Vector3IntField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RectField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Rect)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "RectField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "RectField", typeof(string), 1);
                            }
                            UnityEngine.Rect arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "RectField", typeof(UnityEngine.Rect), 2);
                            }
                            var ret = UnityEditor.EditorGUI.RectField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Rect)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "RectField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "RectField", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.Rect arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "RectField", typeof(UnityEngine.Rect), 2);
                            }
                            var ret = UnityEditor.EditorGUI.RectField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "RectField", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Rect arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "RectField", typeof(UnityEngine.Rect), 1);
                        }
                        var ret = UnityEditor.EditorGUI.RectField(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("RectField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RectIntField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.RectInt)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "RectIntField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "RectIntField", typeof(string), 1);
                            }
                            UnityEngine.RectInt arg2;
                            if (!Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "RectIntField", typeof(UnityEngine.RectInt), 2);
                            }
                            var ret = UnityEditor.EditorGUI.RectIntField(arg0, arg1, arg2);
                            return Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.RectInt)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "RectIntField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "RectIntField", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.RectInt arg2;
                            if (!Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "RectIntField", typeof(UnityEngine.RectInt), 2);
                            }
                            var ret = UnityEditor.EditorGUI.RectIntField(arg0, arg1, arg2);
                            return Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "RectIntField", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.RectInt arg1;
                        if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "RectIntField", typeof(UnityEngine.RectInt), 1);
                        }
                        var ret = UnityEditor.EditorGUI.RectIntField(arg0, arg1);
                        return Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("RectIntField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BoundsField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Bounds)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "BoundsField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "BoundsField", typeof(string), 1);
                            }
                            UnityEngine.Bounds arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "BoundsField", typeof(UnityEngine.Bounds), 2);
                            }
                            var ret = UnityEditor.EditorGUI.BoundsField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Bounds)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "BoundsField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "BoundsField", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.Bounds arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "BoundsField", typeof(UnityEngine.Bounds), 2);
                            }
                            var ret = UnityEditor.EditorGUI.BoundsField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "BoundsField", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Bounds arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "BoundsField", typeof(UnityEngine.Bounds), 1);
                        }
                        var ret = UnityEditor.EditorGUI.BoundsField(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("BoundsField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BoundsIntField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.BoundsInt)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "BoundsIntField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "BoundsIntField", typeof(string), 1);
                            }
                            UnityEngine.BoundsInt arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "BoundsIntField", typeof(UnityEngine.BoundsInt), 2);
                            }
                            var ret = UnityEditor.EditorGUI.BoundsIntField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.BoundsInt)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "BoundsIntField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "BoundsIntField", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.BoundsInt arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "BoundsIntField", typeof(UnityEngine.BoundsInt), 2);
                            }
                            var ret = UnityEditor.EditorGUI.BoundsIntField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "BoundsIntField", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.BoundsInt arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "BoundsIntField", typeof(UnityEngine.BoundsInt), 1);
                        }
                        var ret = UnityEditor.EditorGUI.BoundsIntField(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("BoundsIntField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_MultiFloatField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "MultiFloatField", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.GUIContent arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "MultiFloatField", typeof(UnityEngine.GUIContent), 1);
                        }
                        UnityEngine.GUIContent[] arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "MultiFloatField", typeof(UnityEngine.GUIContent[]), 2);
                        }
                        float[] arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "MultiFloatField", typeof(float[]), 3);
                        }
                        UnityEditor.EditorGUI.MultiFloatField(arg0, arg1, arg2, arg3);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "MultiFloatField", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.GUIContent[] arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "MultiFloatField", typeof(UnityEngine.GUIContent[]), 1);
                        }
                        float[] arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "MultiFloatField", typeof(float[]), 2);
                        }
                        UnityEditor.EditorGUI.MultiFloatField(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("MultiFloatField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_MultiIntField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUI), "MultiIntField", typeof(UnityEngine.Rect), 0);
                    }
                    UnityEngine.GUIContent[] arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUI), "MultiIntField", typeof(UnityEngine.GUIContent[]), 1);
                    }
                    int[] arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUI), "MultiIntField", typeof(int[]), 2);
                    }
                    UnityEditor.EditorGUI.MultiIntField(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("MultiIntField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_MultiPropertyField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "MultiPropertyField", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.GUIContent[] arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "MultiPropertyField", typeof(UnityEngine.GUIContent[]), 1);
                        }
                        UnityEditor.SerializedProperty arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "MultiPropertyField", typeof(UnityEditor.SerializedProperty), 2);
                        }
                        UnityEngine.GUIContent arg3;
                        if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "MultiPropertyField", typeof(UnityEngine.GUIContent), 3);
                        }
                        UnityEditor.EditorGUI.MultiPropertyField(arg0, arg1, arg2, arg3);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "MultiPropertyField", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.GUIContent[] arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "MultiPropertyField", typeof(UnityEngine.GUIContent[]), 1);
                        }
                        UnityEditor.SerializedProperty arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "MultiPropertyField", typeof(UnityEditor.SerializedProperty), 2);
                        }
                        UnityEditor.EditorGUI.MultiPropertyField(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("MultiPropertyField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ColorField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "ColorField", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.GUIContent arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "ColorField", typeof(UnityEngine.GUIContent), 1);
                        }
                        UnityEngine.Color arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "ColorField", typeof(UnityEngine.Color), 2);
                        }
                        bool arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "ColorField", typeof(bool), 3);
                        }
                        bool arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "ColorField", typeof(bool), 4);
                        }
                        bool arg5;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "ColorField", typeof(bool), 5);
                        }
                        var ret = UnityEditor.EditorGUI.ColorField(arg0, arg1, arg2, arg3, arg4, arg5);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Color)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ColorField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ColorField", typeof(string), 1);
                            }
                            UnityEngine.Color arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ColorField", typeof(UnityEngine.Color), 2);
                            }
                            var ret = UnityEditor.EditorGUI.ColorField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Color)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ColorField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ColorField", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.Color arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ColorField", typeof(UnityEngine.Color), 2);
                            }
                            var ret = UnityEditor.EditorGUI.ColorField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "ColorField", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Color arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "ColorField", typeof(UnityEngine.Color), 1);
                        }
                        var ret = UnityEditor.EditorGUI.ColorField(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("ColorField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CurveField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.AnimationCurve)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Color)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.Rect)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "CurveField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "CurveField", typeof(string), 1);
                            }
                            UnityEngine.AnimationCurve arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "CurveField", typeof(UnityEngine.AnimationCurve), 2);
                            }
                            UnityEngine.Color arg3;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "CurveField", typeof(UnityEngine.Color), 3);
                            }
                            UnityEngine.Rect arg4;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "CurveField", typeof(UnityEngine.Rect), 4);
                            }
                            var ret = UnityEditor.EditorGUI.CurveField(arg0, arg1, arg2, arg3, arg4);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.AnimationCurve)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Color)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.Rect)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "CurveField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "CurveField", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.AnimationCurve arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "CurveField", typeof(UnityEngine.AnimationCurve), 2);
                            }
                            UnityEngine.Color arg3;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "CurveField", typeof(UnityEngine.Color), 3);
                            }
                            UnityEngine.Rect arg4;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "CurveField", typeof(UnityEngine.Rect), 4);
                            }
                            var ret = UnityEditor.EditorGUI.CurveField(arg0, arg1, arg2, arg3, arg4);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Color)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIContent)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "CurveField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEditor.SerializedProperty arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "CurveField", typeof(UnityEditor.SerializedProperty), 1);
                            }
                            UnityEngine.Color arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "CurveField", typeof(UnityEngine.Color), 2);
                            }
                            UnityEngine.Rect arg3;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "CurveField", typeof(UnityEngine.Rect), 3);
                            }
                            UnityEngine.GUIContent arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "CurveField", typeof(UnityEngine.GUIContent), 4);
                            }
                            UnityEditor.EditorGUI.CurveField(arg0, arg1, arg2, arg3, arg4);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.AnimationCurve)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Color)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Rect)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "CurveField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.AnimationCurve arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "CurveField", typeof(UnityEngine.AnimationCurve), 1);
                            }
                            UnityEngine.Color arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "CurveField", typeof(UnityEngine.Color), 2);
                            }
                            UnityEngine.Rect arg3;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "CurveField", typeof(UnityEngine.Rect), 3);
                            }
                            var ret = UnityEditor.EditorGUI.CurveField(arg0, arg1, arg2, arg3);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Color)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Rect)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "CurveField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEditor.SerializedProperty arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "CurveField", typeof(UnityEditor.SerializedProperty), 1);
                            }
                            UnityEngine.Color arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "CurveField", typeof(UnityEngine.Color), 2);
                            }
                            UnityEngine.Rect arg3;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "CurveField", typeof(UnityEngine.Rect), 3);
                            }
                            UnityEditor.EditorGUI.CurveField(arg0, arg1, arg2, arg3);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.AnimationCurve)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "CurveField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "CurveField", typeof(string), 1);
                            }
                            UnityEngine.AnimationCurve arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "CurveField", typeof(UnityEngine.AnimationCurve), 2);
                            }
                            var ret = UnityEditor.EditorGUI.CurveField(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.AnimationCurve)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "CurveField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "CurveField", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.AnimationCurve arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "CurveField", typeof(UnityEngine.AnimationCurve), 2);
                            }
                            var ret = UnityEditor.EditorGUI.CurveField(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "CurveField", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.AnimationCurve arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "CurveField", typeof(UnityEngine.AnimationCurve), 1);
                        }
                        var ret = UnityEditor.EditorGUI.CurveField(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("CurveField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_InspectorTitlebar(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[3], typeof(bool)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "InspectorTitlebar", typeof(UnityEngine.Rect), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "InspectorTitlebar", typeof(bool), 1);
                            }
                            UnityEngine.Object arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "InspectorTitlebar", typeof(UnityEngine.Object), 2);
                            }
                            bool arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "InspectorTitlebar", typeof(bool), 3);
                            }
                            var ret = UnityEditor.EditorGUI.InspectorTitlebar(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Object[])) && Values.js_match_type(ctx, argv[3], typeof(bool)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "InspectorTitlebar", typeof(UnityEngine.Rect), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "InspectorTitlebar", typeof(bool), 1);
                            }
                            UnityEngine.Object[] arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "InspectorTitlebar", typeof(UnityEngine.Object[]), 2);
                            }
                            bool arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "InspectorTitlebar", typeof(bool), 3);
                            }
                            var ret = UnityEditor.EditorGUI.InspectorTitlebar(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "InspectorTitlebar", typeof(UnityEngine.Rect), 0);
                        }
                        bool arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "InspectorTitlebar", typeof(bool), 1);
                        }
                        UnityEditor.Editor arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "InspectorTitlebar", typeof(UnityEditor.Editor), 2);
                        }
                        var ret = UnityEditor.EditorGUI.InspectorTitlebar(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "InspectorTitlebar", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Object[] arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "InspectorTitlebar", typeof(UnityEngine.Object[]), 1);
                        }
                        UnityEditor.EditorGUI.InspectorTitlebar(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("InspectorTitlebar", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ProgressBar(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUI), "ProgressBar", typeof(UnityEngine.Rect), 0);
                    }
                    float arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUI), "ProgressBar", typeof(float), 1);
                    }
                    string arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUI), "ProgressBar", typeof(string), 2);
                    }
                    UnityEditor.EditorGUI.ProgressBar(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ProgressBar", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_HelpBox(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUI), "HelpBox", typeof(UnityEngine.Rect), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUI), "HelpBox", typeof(string), 1);
                    }
                    UnityEditor.MessageType arg2;
                    if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUI), "HelpBox", typeof(UnityEditor.MessageType), 2);
                    }
                    UnityEditor.EditorGUI.HelpBox(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("HelpBox", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_PrefixLabel(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "PrefixLabel", typeof(UnityEngine.Rect), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "PrefixLabel", typeof(int), 1);
                        }
                        UnityEngine.GUIContent arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "PrefixLabel", typeof(UnityEngine.GUIContent), 2);
                        }
                        UnityEngine.GUIStyle arg3;
                        if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "PrefixLabel", typeof(UnityEngine.GUIStyle), 3);
                        }
                        var ret = UnityEditor.EditorGUI.PrefixLabel(arg0, arg1, arg2, arg3);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "PrefixLabel", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "PrefixLabel", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "PrefixLabel", typeof(UnityEngine.GUIStyle), 2);
                            }
                            var ret = UnityEditor.EditorGUI.PrefixLabel(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIContent)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "PrefixLabel", typeof(UnityEngine.Rect), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "PrefixLabel", typeof(int), 1);
                            }
                            UnityEngine.GUIContent arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "PrefixLabel", typeof(UnityEngine.GUIContent), 2);
                            }
                            var ret = UnityEditor.EditorGUI.PrefixLabel(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "PrefixLabel", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.GUIContent arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "PrefixLabel", typeof(UnityEngine.GUIContent), 1);
                        }
                        var ret = UnityEditor.EditorGUI.PrefixLabel(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("PrefixLabel", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BeginProperty(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUI), "BeginProperty", typeof(UnityEngine.Rect), 0);
                    }
                    UnityEngine.GUIContent arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUI), "BeginProperty", typeof(UnityEngine.GUIContent), 1);
                    }
                    UnityEditor.SerializedProperty arg2;
                    if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUI), "BeginProperty", typeof(UnityEditor.SerializedProperty), 2);
                    }
                    var ret = UnityEditor.EditorGUI.BeginProperty(arg0, arg1, arg2);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("BeginProperty", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_EndProperty(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorGUI.EndProperty();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("EndProperty", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetPropertyHeight(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        UnityEditor.SerializedProperty arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "GetPropertyHeight", typeof(UnityEditor.SerializedProperty), 0);
                        }
                        UnityEngine.GUIContent arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "GetPropertyHeight", typeof(UnityEngine.GUIContent), 1);
                        }
                        bool arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "GetPropertyHeight", typeof(bool), 2);
                        }
                        var ret = UnityEditor.EditorGUI.GetPropertyHeight(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.SerializedPropertyType)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)))
                        {
                            UnityEditor.SerializedPropertyType arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "GetPropertyHeight", typeof(UnityEditor.SerializedPropertyType), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "GetPropertyHeight", typeof(UnityEngine.GUIContent), 1);
                            }
                            var ret = UnityEditor.EditorGUI.GetPropertyHeight(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[1], typeof(bool)))
                        {
                            UnityEditor.SerializedProperty arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "GetPropertyHeight", typeof(UnityEditor.SerializedProperty), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "GetPropertyHeight", typeof(bool), 1);
                            }
                            var ret = UnityEditor.EditorGUI.GetPropertyHeight(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)))
                        {
                            UnityEditor.SerializedProperty arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "GetPropertyHeight", typeof(UnityEditor.SerializedProperty), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "GetPropertyHeight", typeof(UnityEngine.GUIContent), 1);
                            }
                            var ret = UnityEditor.EditorGUI.GetPropertyHeight(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 1)
                    {
                        UnityEditor.SerializedProperty arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "GetPropertyHeight", typeof(UnityEditor.SerializedProperty), 0);
                        }
                        var ret = UnityEditor.EditorGUI.GetPropertyHeight(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("GetPropertyHeight", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CanCacheInspectorGUI(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.SerializedProperty arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUI), "CanCacheInspectorGUI", typeof(UnityEditor.SerializedProperty), 0);
                    }
                    var ret = UnityEditor.EditorGUI.CanCacheInspectorGUI(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("CanCacheInspectorGUI", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DropdownButton(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DropdownButton", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.GUIContent arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DropdownButton", typeof(UnityEngine.GUIContent), 1);
                        }
                        UnityEngine.FocusType arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DropdownButton", typeof(UnityEngine.FocusType), 2);
                        }
                        UnityEngine.GUIStyle arg3;
                        if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DropdownButton", typeof(UnityEngine.GUIStyle), 3);
                        }
                        var ret = UnityEditor.EditorGUI.DropdownButton(arg0, arg1, arg2, arg3);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DropdownButton", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.GUIContent arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DropdownButton", typeof(UnityEngine.GUIContent), 1);
                        }
                        UnityEngine.FocusType arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DropdownButton", typeof(UnityEngine.FocusType), 2);
                        }
                        var ret = UnityEditor.EditorGUI.DropdownButton(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("DropdownButton", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawTextureAlpha(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureAlpha", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Texture arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureAlpha", typeof(UnityEngine.Texture), 1);
                        }
                        UnityEngine.ScaleMode arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureAlpha", typeof(UnityEngine.ScaleMode), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureAlpha", typeof(float), 3);
                        }
                        float arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureAlpha", typeof(float), 4);
                        }
                        UnityEditor.EditorGUI.DrawTextureAlpha(arg0, arg1, arg2, arg3, arg4);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 4)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureAlpha", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Texture arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureAlpha", typeof(UnityEngine.Texture), 1);
                        }
                        UnityEngine.ScaleMode arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureAlpha", typeof(UnityEngine.ScaleMode), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureAlpha", typeof(float), 3);
                        }
                        UnityEditor.EditorGUI.DrawTextureAlpha(arg0, arg1, arg2, arg3);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureAlpha", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Texture arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureAlpha", typeof(UnityEngine.Texture), 1);
                        }
                        UnityEngine.ScaleMode arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureAlpha", typeof(UnityEngine.ScaleMode), 2);
                        }
                        UnityEditor.EditorGUI.DrawTextureAlpha(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureAlpha", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Texture arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureAlpha", typeof(UnityEngine.Texture), 1);
                        }
                        UnityEditor.EditorGUI.DrawTextureAlpha(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("DrawTextureAlpha", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawTextureTransparent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureTransparent", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Texture arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureTransparent", typeof(UnityEngine.Texture), 1);
                        }
                        UnityEngine.ScaleMode arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureTransparent", typeof(UnityEngine.ScaleMode), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureTransparent", typeof(float), 3);
                        }
                        float arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureTransparent", typeof(float), 4);
                        }
                        UnityEngine.Rendering.ColorWriteMask arg5;
                        if (!Values.js_get_enumvalue(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureTransparent", typeof(UnityEngine.Rendering.ColorWriteMask), 5);
                        }
                        float arg6;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureTransparent", typeof(float), 6);
                        }
                        UnityEditor.EditorGUI.DrawTextureTransparent(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 6)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureTransparent", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Texture arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureTransparent", typeof(UnityEngine.Texture), 1);
                        }
                        UnityEngine.ScaleMode arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureTransparent", typeof(UnityEngine.ScaleMode), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureTransparent", typeof(float), 3);
                        }
                        float arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureTransparent", typeof(float), 4);
                        }
                        UnityEngine.Rendering.ColorWriteMask arg5;
                        if (!Values.js_get_enumvalue(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureTransparent", typeof(UnityEngine.Rendering.ColorWriteMask), 5);
                        }
                        UnityEditor.EditorGUI.DrawTextureTransparent(arg0, arg1, arg2, arg3, arg4, arg5);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 5)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureTransparent", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Texture arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureTransparent", typeof(UnityEngine.Texture), 1);
                        }
                        UnityEngine.ScaleMode arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureTransparent", typeof(UnityEngine.ScaleMode), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureTransparent", typeof(float), 3);
                        }
                        float arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureTransparent", typeof(float), 4);
                        }
                        UnityEditor.EditorGUI.DrawTextureTransparent(arg0, arg1, arg2, arg3, arg4);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 4)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureTransparent", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Texture arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureTransparent", typeof(UnityEngine.Texture), 1);
                        }
                        UnityEngine.ScaleMode arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureTransparent", typeof(UnityEngine.ScaleMode), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureTransparent", typeof(float), 3);
                        }
                        UnityEditor.EditorGUI.DrawTextureTransparent(arg0, arg1, arg2, arg3);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureTransparent", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Texture arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureTransparent", typeof(UnityEngine.Texture), 1);
                        }
                        UnityEngine.ScaleMode arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureTransparent", typeof(UnityEngine.ScaleMode), 2);
                        }
                        UnityEditor.EditorGUI.DrawTextureTransparent(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureTransparent", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Texture arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawTextureTransparent", typeof(UnityEngine.Texture), 1);
                        }
                        UnityEditor.EditorGUI.DrawTextureTransparent(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("DrawTextureTransparent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawPreviewTexture(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 8)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Texture arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(UnityEngine.Texture), 1);
                        }
                        UnityEngine.Material arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(UnityEngine.Material), 2);
                        }
                        UnityEngine.ScaleMode arg3;
                        if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(UnityEngine.ScaleMode), 3);
                        }
                        float arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(float), 4);
                        }
                        float arg5;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(float), 5);
                        }
                        UnityEngine.Rendering.ColorWriteMask arg6;
                        if (!Values.js_get_enumvalue(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(UnityEngine.Rendering.ColorWriteMask), 6);
                        }
                        float arg7;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[7], out arg7))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(float), 7);
                        }
                        UnityEditor.EditorGUI.DrawPreviewTexture(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 7)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Texture arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(UnityEngine.Texture), 1);
                        }
                        UnityEngine.Material arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(UnityEngine.Material), 2);
                        }
                        UnityEngine.ScaleMode arg3;
                        if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(UnityEngine.ScaleMode), 3);
                        }
                        float arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(float), 4);
                        }
                        float arg5;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(float), 5);
                        }
                        UnityEngine.Rendering.ColorWriteMask arg6;
                        if (!Values.js_get_enumvalue(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(UnityEngine.Rendering.ColorWriteMask), 6);
                        }
                        UnityEditor.EditorGUI.DrawPreviewTexture(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 6)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Texture arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(UnityEngine.Texture), 1);
                        }
                        UnityEngine.Material arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(UnityEngine.Material), 2);
                        }
                        UnityEngine.ScaleMode arg3;
                        if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(UnityEngine.ScaleMode), 3);
                        }
                        float arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(float), 4);
                        }
                        float arg5;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(float), 5);
                        }
                        UnityEditor.EditorGUI.DrawPreviewTexture(arg0, arg1, arg2, arg3, arg4, arg5);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 5)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Texture arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(UnityEngine.Texture), 1);
                        }
                        UnityEngine.Material arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(UnityEngine.Material), 2);
                        }
                        UnityEngine.ScaleMode arg3;
                        if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(UnityEngine.ScaleMode), 3);
                        }
                        float arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(float), 4);
                        }
                        UnityEditor.EditorGUI.DrawPreviewTexture(arg0, arg1, arg2, arg3, arg4);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 4)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Texture arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(UnityEngine.Texture), 1);
                        }
                        UnityEngine.Material arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(UnityEngine.Material), 2);
                        }
                        UnityEngine.ScaleMode arg3;
                        if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(UnityEngine.ScaleMode), 3);
                        }
                        UnityEditor.EditorGUI.DrawPreviewTexture(arg0, arg1, arg2, arg3);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Texture arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(UnityEngine.Texture), 1);
                        }
                        UnityEngine.Material arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(UnityEngine.Material), 2);
                        }
                        UnityEditor.EditorGUI.DrawPreviewTexture(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Texture arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawPreviewTexture", typeof(UnityEngine.Texture), 1);
                        }
                        UnityEditor.EditorGUI.DrawPreviewTexture(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("DrawPreviewTexture", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LabelField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(string)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LabelField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LabelField", typeof(string), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LabelField", typeof(string), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LabelField", typeof(UnityEngine.GUIStyle), 3);
                            }
                            UnityEditor.EditorGUI.LabelField(arg0, arg1, arg2, arg3);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LabelField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LabelField", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.GUIContent arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LabelField", typeof(UnityEngine.GUIContent), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LabelField", typeof(UnityEngine.GUIStyle), 3);
                            }
                            UnityEditor.EditorGUI.LabelField(arg0, arg1, arg2, arg3);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LabelField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LabelField", typeof(string), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LabelField", typeof(UnityEngine.GUIStyle), 2);
                            }
                            UnityEditor.EditorGUI.LabelField(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LabelField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LabelField", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LabelField", typeof(UnityEngine.GUIStyle), 2);
                            }
                            UnityEditor.EditorGUI.LabelField(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(string)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LabelField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LabelField", typeof(string), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LabelField", typeof(string), 2);
                            }
                            UnityEditor.EditorGUI.LabelField(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIContent)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LabelField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LabelField", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.GUIContent arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LabelField", typeof(UnityEngine.GUIContent), 2);
                            }
                            UnityEditor.EditorGUI.LabelField(arg0, arg1, arg2);
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
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LabelField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LabelField", typeof(string), 1);
                            }
                            UnityEditor.EditorGUI.LabelField(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LabelField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LabelField", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEditor.EditorGUI.LabelField(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("LabelField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LinkButton(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LinkButton", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LinkButton", typeof(string), 1);
                            }
                            var ret = UnityEditor.EditorGUI.LinkButton(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LinkButton", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LinkButton", typeof(UnityEngine.GUIContent), 1);
                            }
                            var ret = UnityEditor.EditorGUI.LinkButton(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("LinkButton", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ToggleLeft(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(bool)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ToggleLeft", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ToggleLeft", typeof(string), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ToggleLeft", typeof(bool), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ToggleLeft", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.ToggleLeft(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(bool)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ToggleLeft", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ToggleLeft", typeof(UnityEngine.GUIContent), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ToggleLeft", typeof(bool), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ToggleLeft", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.ToggleLeft(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(bool)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ToggleLeft", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ToggleLeft", typeof(string), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ToggleLeft", typeof(bool), 2);
                            }
                            var ret = UnityEditor.EditorGUI.ToggleLeft(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(bool)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ToggleLeft", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ToggleLeft", typeof(UnityEngine.GUIContent), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "ToggleLeft", typeof(bool), 2);
                            }
                            var ret = UnityEditor.EditorGUI.ToggleLeft(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("ToggleLeft", argc);
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
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(string)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TextField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TextField", typeof(string), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TextField", typeof(string), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TextField", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.TextField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(string)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TextField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TextField", typeof(UnityEngine.GUIContent), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TextField", typeof(string), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TextField", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.TextField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TextField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TextField", typeof(string), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TextField", typeof(UnityEngine.GUIStyle), 2);
                            }
                            var ret = UnityEditor.EditorGUI.TextField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(string)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TextField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TextField", typeof(string), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TextField", typeof(string), 2);
                            }
                            var ret = UnityEditor.EditorGUI.TextField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(string)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TextField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TextField", typeof(UnityEngine.GUIContent), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TextField", typeof(string), 2);
                            }
                            var ret = UnityEditor.EditorGUI.TextField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "TextField", typeof(UnityEngine.Rect), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "TextField", typeof(string), 1);
                        }
                        var ret = UnityEditor.EditorGUI.TextField(arg0, arg1);
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
        public static JSValue BindStatic_DelayedTextField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.GUIContent arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(UnityEngine.GUIContent), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(int), 2);
                        }
                        string arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(string), 3);
                        }
                        UnityEngine.GUIStyle arg4;
                        if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(UnityEngine.GUIStyle), 4);
                        }
                        var ret = UnityEditor.EditorGUI.DelayedTextField(arg0, arg1, arg2, arg3, arg4);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(string)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(string), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(string), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.DelayedTextField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(string)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(UnityEngine.GUIContent), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(string), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.DelayedTextField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(string)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(UnityEngine.GUIContent), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(int), 2);
                            }
                            string arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(string), 3);
                            }
                            var ret = UnityEditor.EditorGUI.DelayedTextField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(string), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(UnityEngine.GUIStyle), 2);
                            }
                            var ret = UnityEditor.EditorGUI.DelayedTextField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(string)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(string), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(string), 2);
                            }
                            var ret = UnityEditor.EditorGUI.DelayedTextField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(string)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(UnityEngine.GUIContent), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(string), 2);
                            }
                            var ret = UnityEditor.EditorGUI.DelayedTextField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIContent)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEditor.SerializedProperty arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(UnityEditor.SerializedProperty), 1);
                            }
                            UnityEngine.GUIContent arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(UnityEngine.GUIContent), 2);
                            }
                            UnityEditor.EditorGUI.DelayedTextField(arg0, arg1, arg2);
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
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(string), 1);
                            }
                            var ret = UnityEditor.EditorGUI.DelayedTextField(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.SerializedProperty)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEditor.SerializedProperty arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedTextField", typeof(UnityEditor.SerializedProperty), 1);
                            }
                            UnityEditor.EditorGUI.DelayedTextField(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("DelayedTextField", argc);
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
                    if (argc == 3)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "TextArea", typeof(UnityEngine.Rect), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "TextArea", typeof(string), 1);
                        }
                        UnityEngine.GUIStyle arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "TextArea", typeof(UnityEngine.GUIStyle), 2);
                        }
                        var ret = UnityEditor.EditorGUI.TextArea(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "TextArea", typeof(UnityEngine.Rect), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "TextArea", typeof(string), 1);
                        }
                        var ret = UnityEditor.EditorGUI.TextArea(arg0, arg1);
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
        public static JSValue BindStatic_SelectableLabel(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "SelectableLabel", typeof(UnityEngine.Rect), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "SelectableLabel", typeof(string), 1);
                        }
                        UnityEngine.GUIStyle arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "SelectableLabel", typeof(UnityEngine.GUIStyle), 2);
                        }
                        UnityEditor.EditorGUI.SelectableLabel(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "SelectableLabel", typeof(UnityEngine.Rect), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "SelectableLabel", typeof(string), 1);
                        }
                        UnityEditor.EditorGUI.SelectableLabel(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("SelectableLabel", argc);
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
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(string)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "PasswordField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "PasswordField", typeof(string), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "PasswordField", typeof(string), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "PasswordField", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.PasswordField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(string)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "PasswordField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "PasswordField", typeof(UnityEngine.GUIContent), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "PasswordField", typeof(string), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "PasswordField", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.PasswordField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "PasswordField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "PasswordField", typeof(string), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "PasswordField", typeof(UnityEngine.GUIStyle), 2);
                            }
                            var ret = UnityEditor.EditorGUI.PasswordField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(string)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "PasswordField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "PasswordField", typeof(string), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "PasswordField", typeof(string), 2);
                            }
                            var ret = UnityEditor.EditorGUI.PasswordField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(string)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "PasswordField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "PasswordField", typeof(UnityEngine.GUIContent), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "PasswordField", typeof(string), 2);
                            }
                            var ret = UnityEditor.EditorGUI.PasswordField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "PasswordField", typeof(UnityEngine.Rect), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "PasswordField", typeof(string), 1);
                        }
                        var ret = UnityEditor.EditorGUI.PasswordField(arg0, arg1);
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
        public static JSValue BindStatic_FloatField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "FloatField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "FloatField", typeof(string), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "FloatField", typeof(float), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "FloatField", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.FloatField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "FloatField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "FloatField", typeof(UnityEngine.GUIContent), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "FloatField", typeof(float), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "FloatField", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.FloatField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "FloatField", typeof(UnityEngine.Rect), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "FloatField", typeof(float), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "FloatField", typeof(UnityEngine.GUIStyle), 2);
                            }
                            var ret = UnityEditor.EditorGUI.FloatField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(float)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "FloatField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "FloatField", typeof(string), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "FloatField", typeof(float), 2);
                            }
                            var ret = UnityEditor.EditorGUI.FloatField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(float)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "FloatField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "FloatField", typeof(UnityEngine.GUIContent), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "FloatField", typeof(float), 2);
                            }
                            var ret = UnityEditor.EditorGUI.FloatField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "FloatField", typeof(UnityEngine.Rect), 0);
                        }
                        float arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "FloatField", typeof(float), 1);
                        }
                        var ret = UnityEditor.EditorGUI.FloatField(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("FloatField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DelayedFloatField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedFloatField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedFloatField", typeof(string), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedFloatField", typeof(float), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedFloatField", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.DelayedFloatField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(float)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedFloatField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedFloatField", typeof(UnityEngine.GUIContent), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedFloatField", typeof(float), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedFloatField", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.DelayedFloatField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(float)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedFloatField", typeof(UnityEngine.Rect), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedFloatField", typeof(float), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedFloatField", typeof(UnityEngine.GUIStyle), 2);
                            }
                            var ret = UnityEditor.EditorGUI.DelayedFloatField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(float)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedFloatField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedFloatField", typeof(string), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedFloatField", typeof(float), 2);
                            }
                            var ret = UnityEditor.EditorGUI.DelayedFloatField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(float)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedFloatField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedFloatField", typeof(UnityEngine.GUIContent), 1);
                            }
                            float arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedFloatField", typeof(float), 2);
                            }
                            var ret = UnityEditor.EditorGUI.DelayedFloatField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIContent)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedFloatField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEditor.SerializedProperty arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedFloatField", typeof(UnityEditor.SerializedProperty), 1);
                            }
                            UnityEngine.GUIContent arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedFloatField", typeof(UnityEngine.GUIContent), 2);
                            }
                            UnityEditor.EditorGUI.DelayedFloatField(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(float)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedFloatField", typeof(UnityEngine.Rect), 0);
                            }
                            float arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedFloatField", typeof(float), 1);
                            }
                            var ret = UnityEditor.EditorGUI.DelayedFloatField(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.SerializedProperty)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedFloatField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEditor.SerializedProperty arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedFloatField", typeof(UnityEditor.SerializedProperty), 1);
                            }
                            UnityEditor.EditorGUI.DelayedFloatField(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("DelayedFloatField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DoubleField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(double)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DoubleField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DoubleField", typeof(string), 1);
                            }
                            double arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DoubleField", typeof(double), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DoubleField", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.DoubleField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(double)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DoubleField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DoubleField", typeof(UnityEngine.GUIContent), 1);
                            }
                            double arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DoubleField", typeof(double), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DoubleField", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.DoubleField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(double)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DoubleField", typeof(UnityEngine.Rect), 0);
                            }
                            double arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DoubleField", typeof(double), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DoubleField", typeof(UnityEngine.GUIStyle), 2);
                            }
                            var ret = UnityEditor.EditorGUI.DoubleField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(double)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DoubleField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DoubleField", typeof(string), 1);
                            }
                            double arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DoubleField", typeof(double), 2);
                            }
                            var ret = UnityEditor.EditorGUI.DoubleField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(double)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DoubleField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DoubleField", typeof(UnityEngine.GUIContent), 1);
                            }
                            double arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DoubleField", typeof(double), 2);
                            }
                            var ret = UnityEditor.EditorGUI.DoubleField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DoubleField", typeof(UnityEngine.Rect), 0);
                        }
                        double arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DoubleField", typeof(double), 1);
                        }
                        var ret = UnityEditor.EditorGUI.DoubleField(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("DoubleField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DelayedDoubleField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(double)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedDoubleField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedDoubleField", typeof(string), 1);
                            }
                            double arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedDoubleField", typeof(double), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedDoubleField", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.DelayedDoubleField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(double)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedDoubleField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedDoubleField", typeof(UnityEngine.GUIContent), 1);
                            }
                            double arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedDoubleField", typeof(double), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedDoubleField", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.DelayedDoubleField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(double)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedDoubleField", typeof(UnityEngine.Rect), 0);
                            }
                            double arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedDoubleField", typeof(double), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedDoubleField", typeof(UnityEngine.GUIStyle), 2);
                            }
                            var ret = UnityEditor.EditorGUI.DelayedDoubleField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(double)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedDoubleField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedDoubleField", typeof(string), 1);
                            }
                            double arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedDoubleField", typeof(double), 2);
                            }
                            var ret = UnityEditor.EditorGUI.DelayedDoubleField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(double)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedDoubleField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedDoubleField", typeof(UnityEngine.GUIContent), 1);
                            }
                            double arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedDoubleField", typeof(double), 2);
                            }
                            var ret = UnityEditor.EditorGUI.DelayedDoubleField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedDoubleField", typeof(UnityEngine.Rect), 0);
                        }
                        double arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedDoubleField", typeof(double), 1);
                        }
                        var ret = UnityEditor.EditorGUI.DelayedDoubleField(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("DelayedDoubleField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IntField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntField", typeof(string), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntField", typeof(int), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntField", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.IntField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntField", typeof(UnityEngine.GUIContent), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntField", typeof(int), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntField", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.IntField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntField", typeof(UnityEngine.Rect), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntField", typeof(int), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntField", typeof(UnityEngine.GUIStyle), 2);
                            }
                            var ret = UnityEditor.EditorGUI.IntField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(int)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntField", typeof(string), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntField", typeof(int), 2);
                            }
                            var ret = UnityEditor.EditorGUI.IntField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(int)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntField", typeof(UnityEngine.GUIContent), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntField", typeof(int), 2);
                            }
                            var ret = UnityEditor.EditorGUI.IntField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntField", typeof(UnityEngine.Rect), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntField", typeof(int), 1);
                        }
                        var ret = UnityEditor.EditorGUI.IntField(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("IntField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DelayedIntField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedIntField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedIntField", typeof(string), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedIntField", typeof(int), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedIntField", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.DelayedIntField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedIntField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedIntField", typeof(UnityEngine.GUIContent), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedIntField", typeof(int), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedIntField", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.DelayedIntField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedIntField", typeof(UnityEngine.Rect), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedIntField", typeof(int), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedIntField", typeof(UnityEngine.GUIStyle), 2);
                            }
                            var ret = UnityEditor.EditorGUI.DelayedIntField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(int)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedIntField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedIntField", typeof(string), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedIntField", typeof(int), 2);
                            }
                            var ret = UnityEditor.EditorGUI.DelayedIntField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(int)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedIntField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedIntField", typeof(UnityEngine.GUIContent), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedIntField", typeof(int), 2);
                            }
                            var ret = UnityEditor.EditorGUI.DelayedIntField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIContent)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedIntField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEditor.SerializedProperty arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedIntField", typeof(UnityEditor.SerializedProperty), 1);
                            }
                            UnityEngine.GUIContent arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedIntField", typeof(UnityEngine.GUIContent), 2);
                            }
                            UnityEditor.EditorGUI.DelayedIntField(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(int)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedIntField", typeof(UnityEngine.Rect), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedIntField", typeof(int), 1);
                            }
                            var ret = UnityEditor.EditorGUI.DelayedIntField(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.SerializedProperty)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedIntField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEditor.SerializedProperty arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "DelayedIntField", typeof(UnityEditor.SerializedProperty), 1);
                            }
                            UnityEditor.EditorGUI.DelayedIntField(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("DelayedIntField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LongField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(long)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LongField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LongField", typeof(string), 1);
                            }
                            long arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LongField", typeof(long), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LongField", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.LongField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(long)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LongField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LongField", typeof(UnityEngine.GUIContent), 1);
                            }
                            long arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LongField", typeof(long), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LongField", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.LongField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(long)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LongField", typeof(UnityEngine.Rect), 0);
                            }
                            long arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LongField", typeof(long), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LongField", typeof(UnityEngine.GUIStyle), 2);
                            }
                            var ret = UnityEditor.EditorGUI.LongField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(long)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LongField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LongField", typeof(string), 1);
                            }
                            long arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LongField", typeof(long), 2);
                            }
                            var ret = UnityEditor.EditorGUI.LongField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(long)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LongField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LongField", typeof(UnityEngine.GUIContent), 1);
                            }
                            long arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LongField", typeof(long), 2);
                            }
                            var ret = UnityEditor.EditorGUI.LongField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "LongField", typeof(UnityEngine.Rect), 0);
                        }
                        long arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "LongField", typeof(long), 1);
                        }
                        var ret = UnityEditor.EditorGUI.LongField(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("LongField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Popup(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(string[])) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(string), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(int), 2);
                            }
                            string[] arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(string[]), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(UnityEngine.GUIStyle), 4);
                            }
                            var ret = UnityEditor.EditorGUI.Popup(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIContent[])) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(UnityEngine.GUIContent), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(int), 2);
                            }
                            UnityEngine.GUIContent[] arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(UnityEngine.GUIContent[]), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(UnityEngine.GUIStyle), 4);
                            }
                            var ret = UnityEditor.EditorGUI.Popup(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(string[])) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(UnityEngine.Rect), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(int), 1);
                            }
                            string[] arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(string[]), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.Popup(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIContent[])) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(UnityEngine.Rect), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(int), 1);
                            }
                            UnityEngine.GUIContent[] arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(UnityEngine.GUIContent[]), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.Popup(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(string[])))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(string), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(int), 2);
                            }
                            string[] arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(string[]), 3);
                            }
                            var ret = UnityEditor.EditorGUI.Popup(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIContent[])))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(UnityEngine.GUIContent), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(int), 2);
                            }
                            UnityEngine.GUIContent[] arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(UnityEngine.GUIContent[]), 3);
                            }
                            var ret = UnityEditor.EditorGUI.Popup(arg0, arg1, arg2, arg3);
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
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(UnityEngine.Rect), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(int), 1);
                            }
                            string[] arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(string[]), 2);
                            }
                            var ret = UnityEditor.EditorGUI.Popup(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIContent[])))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(UnityEngine.Rect), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(int), 1);
                            }
                            UnityEngine.GUIContent[] arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Popup", typeof(UnityEngine.GUIContent[]), 2);
                            }
                            var ret = UnityEditor.EditorGUI.Popup(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Popup", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_EnumPopup(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumPopup", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.GUIContent arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumPopup", typeof(UnityEngine.GUIContent), 1);
                        }
                        System.Enum arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumPopup", typeof(System.Enum), 2);
                        }
                        System.Func<System.Enum, bool> arg3;
                        if (!Values.js_get_delegate(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumPopup", typeof(System.Func<System.Enum, bool>), 3);
                        }
                        bool arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumPopup", typeof(bool), 4);
                        }
                        UnityEngine.GUIStyle arg5;
                        if (!Values.js_get_classvalue(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumPopup", typeof(UnityEngine.GUIStyle), 5);
                        }
                        var ret = UnityEditor.EditorGUI.EnumPopup(arg0, arg1, arg2, arg3, arg4, arg5);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(System.Enum)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumPopup", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumPopup", typeof(string), 1);
                            }
                            System.Enum arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumPopup", typeof(System.Enum), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumPopup", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.EnumPopup(arg0, arg1, arg2, arg3);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(System.Enum)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumPopup", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumPopup", typeof(UnityEngine.GUIContent), 1);
                            }
                            System.Enum arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumPopup", typeof(System.Enum), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumPopup", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.EnumPopup(arg0, arg1, arg2, arg3);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(System.Enum)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumPopup", typeof(UnityEngine.Rect), 0);
                            }
                            System.Enum arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumPopup", typeof(System.Enum), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumPopup", typeof(UnityEngine.GUIStyle), 2);
                            }
                            var ret = UnityEditor.EditorGUI.EnumPopup(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(System.Enum)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumPopup", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumPopup", typeof(string), 1);
                            }
                            System.Enum arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumPopup", typeof(System.Enum), 2);
                            }
                            var ret = UnityEditor.EditorGUI.EnumPopup(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(System.Enum)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumPopup", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumPopup", typeof(UnityEngine.GUIContent), 1);
                            }
                            System.Enum arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumPopup", typeof(System.Enum), 2);
                            }
                            var ret = UnityEditor.EditorGUI.EnumPopup(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumPopup", typeof(UnityEngine.Rect), 0);
                        }
                        System.Enum arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "EnumPopup", typeof(System.Enum), 1);
                        }
                        var ret = UnityEditor.EditorGUI.EnumPopup(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("EnumPopup", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IntPopup(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 6)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIContent[])) && Values.js_match_type(ctx, argv[4], typeof(int[])) && Values.js_match_type(ctx, argv[5], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(UnityEngine.GUIContent), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(int), 2);
                            }
                            UnityEngine.GUIContent[] arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(UnityEngine.GUIContent[]), 3);
                            }
                            int[] arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(int[]), 4);
                            }
                            UnityEngine.GUIStyle arg5;
                            if (!Values.js_get_classvalue(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(UnityEngine.GUIStyle), 5);
                            }
                            var ret = UnityEditor.EditorGUI.IntPopup(arg0, arg1, arg2, arg3, arg4, arg5);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(string[])) && Values.js_match_type(ctx, argv[4], typeof(int[])) && Values.js_match_type(ctx, argv[5], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(string), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(int), 2);
                            }
                            string[] arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(string[]), 3);
                            }
                            int[] arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(int[]), 4);
                            }
                            UnityEngine.GUIStyle arg5;
                            if (!Values.js_get_classvalue(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(UnityEngine.GUIStyle), 5);
                            }
                            var ret = UnityEditor.EditorGUI.IntPopup(arg0, arg1, arg2, arg3, arg4, arg5);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(string[])) && Values.js_match_type(ctx, argv[3], typeof(int[])) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(UnityEngine.Rect), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(int), 1);
                            }
                            string[] arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(string[]), 2);
                            }
                            int[] arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(int[]), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(UnityEngine.GUIStyle), 4);
                            }
                            var ret = UnityEditor.EditorGUI.IntPopup(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIContent[])) && Values.js_match_type(ctx, argv[3], typeof(int[])) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(UnityEngine.Rect), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(int), 1);
                            }
                            UnityEngine.GUIContent[] arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(UnityEngine.GUIContent[]), 2);
                            }
                            int[] arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(int[]), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(UnityEngine.GUIStyle), 4);
                            }
                            var ret = UnityEditor.EditorGUI.IntPopup(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIContent[])) && Values.js_match_type(ctx, argv[4], typeof(int[])))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(UnityEngine.GUIContent), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(int), 2);
                            }
                            UnityEngine.GUIContent[] arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(UnityEngine.GUIContent[]), 3);
                            }
                            int[] arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(int[]), 4);
                            }
                            var ret = UnityEditor.EditorGUI.IntPopup(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIContent[])) && Values.js_match_type(ctx, argv[3], typeof(int[])) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIContent)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEditor.SerializedProperty arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(UnityEditor.SerializedProperty), 1);
                            }
                            UnityEngine.GUIContent[] arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(UnityEngine.GUIContent[]), 2);
                            }
                            int[] arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(int[]), 3);
                            }
                            UnityEngine.GUIContent arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(UnityEngine.GUIContent), 4);
                            }
                            UnityEditor.EditorGUI.IntPopup(arg0, arg1, arg2, arg3, arg4);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(string[])) && Values.js_match_type(ctx, argv[4], typeof(int[])))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(string), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(int), 2);
                            }
                            string[] arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(string[]), 3);
                            }
                            int[] arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(int[]), 4);
                            }
                            var ret = UnityEditor.EditorGUI.IntPopup(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(string[])) && Values.js_match_type(ctx, argv[3], typeof(int[])))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(UnityEngine.Rect), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(int), 1);
                            }
                            string[] arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(string[]), 2);
                            }
                            int[] arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(int[]), 3);
                            }
                            var ret = UnityEditor.EditorGUI.IntPopup(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIContent[])) && Values.js_match_type(ctx, argv[3], typeof(int[])))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(UnityEngine.Rect), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(int), 1);
                            }
                            UnityEngine.GUIContent[] arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(UnityEngine.GUIContent[]), 2);
                            }
                            int[] arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(int[]), 3);
                            }
                            var ret = UnityEditor.EditorGUI.IntPopup(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIContent[])) && Values.js_match_type(ctx, argv[3], typeof(int[])))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEditor.SerializedProperty arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(UnityEditor.SerializedProperty), 1);
                            }
                            UnityEngine.GUIContent[] arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(UnityEngine.GUIContent[]), 2);
                            }
                            int[] arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "IntPopup", typeof(int[]), 3);
                            }
                            UnityEditor.EditorGUI.IntPopup(arg0, arg1, arg2, arg3);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("IntPopup", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_TagField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(string)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TagField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TagField", typeof(string), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TagField", typeof(string), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TagField", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.TagField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(string)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TagField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TagField", typeof(UnityEngine.GUIContent), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TagField", typeof(string), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TagField", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.TagField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TagField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TagField", typeof(string), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TagField", typeof(UnityEngine.GUIStyle), 2);
                            }
                            var ret = UnityEditor.EditorGUI.TagField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(string)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TagField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TagField", typeof(string), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TagField", typeof(string), 2);
                            }
                            var ret = UnityEditor.EditorGUI.TagField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(string)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TagField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TagField", typeof(UnityEngine.GUIContent), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "TagField", typeof(string), 2);
                            }
                            var ret = UnityEditor.EditorGUI.TagField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "TagField", typeof(UnityEngine.Rect), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "TagField", typeof(string), 1);
                        }
                        var ret = UnityEditor.EditorGUI.TagField(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("TagField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LayerField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LayerField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LayerField", typeof(string), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LayerField", typeof(int), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LayerField", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.LayerField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LayerField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LayerField", typeof(UnityEngine.GUIContent), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LayerField", typeof(int), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LayerField", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.LayerField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LayerField", typeof(UnityEngine.Rect), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LayerField", typeof(int), 1);
                            }
                            UnityEngine.GUIStyle arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LayerField", typeof(UnityEngine.GUIStyle), 2);
                            }
                            var ret = UnityEditor.EditorGUI.LayerField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(int)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LayerField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LayerField", typeof(string), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LayerField", typeof(int), 2);
                            }
                            var ret = UnityEditor.EditorGUI.LayerField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(int)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LayerField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LayerField", typeof(UnityEngine.GUIContent), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "LayerField", typeof(int), 2);
                            }
                            var ret = UnityEditor.EditorGUI.LayerField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "LayerField", typeof(UnityEngine.Rect), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "LayerField", typeof(int), 1);
                        }
                        var ret = UnityEditor.EditorGUI.LayerField(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("LayerField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_MaskField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(string[])) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MaskField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MaskField", typeof(UnityEngine.GUIContent), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MaskField", typeof(int), 2);
                            }
                            string[] arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MaskField", typeof(string[]), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MaskField", typeof(UnityEngine.GUIStyle), 4);
                            }
                            var ret = UnityEditor.EditorGUI.MaskField(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(string[])) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MaskField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MaskField", typeof(string), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MaskField", typeof(int), 2);
                            }
                            string[] arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MaskField", typeof(string[]), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MaskField", typeof(UnityEngine.GUIStyle), 4);
                            }
                            var ret = UnityEditor.EditorGUI.MaskField(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(string[])))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MaskField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MaskField", typeof(UnityEngine.GUIContent), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MaskField", typeof(int), 2);
                            }
                            string[] arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MaskField", typeof(string[]), 3);
                            }
                            var ret = UnityEditor.EditorGUI.MaskField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(string[])))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MaskField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MaskField", typeof(string), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MaskField", typeof(int), 2);
                            }
                            string[] arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MaskField", typeof(string[]), 3);
                            }
                            var ret = UnityEditor.EditorGUI.MaskField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(string[])) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MaskField", typeof(UnityEngine.Rect), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MaskField", typeof(int), 1);
                            }
                            string[] arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MaskField", typeof(string[]), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "MaskField", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.MaskField(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "MaskField", typeof(UnityEngine.Rect), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "MaskField", typeof(int), 1);
                        }
                        string[] arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "MaskField", typeof(string[]), 2);
                        }
                        var ret = UnityEditor.EditorGUI.MaskField(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("MaskField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Foldout(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_type(ctx, argv[2], typeof(string)) && Values.js_match_type(ctx, argv[3], typeof(bool)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(UnityEngine.Rect), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(bool), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(string), 2);
                            }
                            bool arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(bool), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(UnityEngine.GUIStyle), 4);
                            }
                            var ret = UnityEditor.EditorGUI.Foldout(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[3], typeof(bool)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(UnityEngine.Rect), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(bool), 1);
                            }
                            UnityEngine.GUIContent arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(UnityEngine.GUIContent), 2);
                            }
                            bool arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(bool), 3);
                            }
                            UnityEngine.GUIStyle arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(UnityEngine.GUIStyle), 4);
                            }
                            var ret = UnityEditor.EditorGUI.Foldout(arg0, arg1, arg2, arg3, arg4);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_type(ctx, argv[2], typeof(string)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(UnityEngine.Rect), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(bool), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(string), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.Foldout(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_type(ctx, argv[2], typeof(string)) && Values.js_match_type(ctx, argv[3], typeof(bool)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(UnityEngine.Rect), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(bool), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(string), 2);
                            }
                            bool arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(bool), 3);
                            }
                            var ret = UnityEditor.EditorGUI.Foldout(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(UnityEngine.Rect), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(bool), 1);
                            }
                            UnityEngine.GUIContent arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(UnityEngine.GUIContent), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(UnityEngine.GUIStyle), 3);
                            }
                            var ret = UnityEditor.EditorGUI.Foldout(arg0, arg1, arg2, arg3);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[3], typeof(bool)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(UnityEngine.Rect), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(bool), 1);
                            }
                            UnityEngine.GUIContent arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(UnityEngine.GUIContent), 2);
                            }
                            bool arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(bool), 3);
                            }
                            var ret = UnityEditor.EditorGUI.Foldout(arg0, arg1, arg2, arg3);
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
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(UnityEngine.Rect), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(bool), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(string), 2);
                            }
                            var ret = UnityEditor.EditorGUI.Foldout(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIContent)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(UnityEngine.Rect), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(bool), 1);
                            }
                            UnityEngine.GUIContent arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "Foldout", typeof(UnityEngine.GUIContent), 2);
                            }
                            var ret = UnityEditor.EditorGUI.Foldout(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Foldout", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_HandlePrefixLabel(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "HandlePrefixLabel", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Rect arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "HandlePrefixLabel", typeof(UnityEngine.Rect), 1);
                        }
                        UnityEngine.GUIContent arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "HandlePrefixLabel", typeof(UnityEngine.GUIContent), 2);
                        }
                        int arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "HandlePrefixLabel", typeof(int), 3);
                        }
                        UnityEngine.GUIStyle arg4;
                        if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "HandlePrefixLabel", typeof(UnityEngine.GUIStyle), 4);
                        }
                        UnityEditor.EditorGUI.HandlePrefixLabel(arg0, arg1, arg2, arg3, arg4);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 4)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "HandlePrefixLabel", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Rect arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "HandlePrefixLabel", typeof(UnityEngine.Rect), 1);
                        }
                        UnityEngine.GUIContent arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "HandlePrefixLabel", typeof(UnityEngine.GUIContent), 2);
                        }
                        int arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "HandlePrefixLabel", typeof(int), 3);
                        }
                        UnityEditor.EditorGUI.HandlePrefixLabel(arg0, arg1, arg2, arg3);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "HandlePrefixLabel", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Rect arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "HandlePrefixLabel", typeof(UnityEngine.Rect), 1);
                        }
                        UnityEngine.GUIContent arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "HandlePrefixLabel", typeof(UnityEngine.GUIContent), 2);
                        }
                        UnityEditor.EditorGUI.HandlePrefixLabel(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("HandlePrefixLabel", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_PropertyField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "PropertyField", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEditor.SerializedProperty arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "PropertyField", typeof(UnityEditor.SerializedProperty), 1);
                        }
                        UnityEngine.GUIContent arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "PropertyField", typeof(UnityEngine.GUIContent), 2);
                        }
                        bool arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "PropertyField", typeof(bool), 3);
                        }
                        var ret = UnityEditor.EditorGUI.PropertyField(arg0, arg1, arg2, arg3);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[2], typeof(bool)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "PropertyField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEditor.SerializedProperty arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "PropertyField", typeof(UnityEditor.SerializedProperty), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "PropertyField", typeof(bool), 2);
                            }
                            var ret = UnityEditor.EditorGUI.PropertyField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIContent)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "PropertyField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEditor.SerializedProperty arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "PropertyField", typeof(UnityEditor.SerializedProperty), 1);
                            }
                            UnityEngine.GUIContent arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "PropertyField", typeof(UnityEngine.GUIContent), 2);
                            }
                            var ret = UnityEditor.EditorGUI.PropertyField(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "PropertyField", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEditor.SerializedProperty arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "PropertyField", typeof(UnityEditor.SerializedProperty), 1);
                        }
                        var ret = UnityEditor.EditorGUI.PropertyField(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("PropertyField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BeginFoldoutHeaderGroup(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 6)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_type(ctx, argv[2], typeof(string)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)) && Values.js_match_type(ctx, argv[4], typeof(System.Action<UnityEngine.Rect>)) && Values.js_match_type(ctx, argv[5], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "BeginFoldoutHeaderGroup", typeof(UnityEngine.Rect), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "BeginFoldoutHeaderGroup", typeof(bool), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "BeginFoldoutHeaderGroup", typeof(string), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "BeginFoldoutHeaderGroup", typeof(UnityEngine.GUIStyle), 3);
                            }
                            System.Action<UnityEngine.Rect> arg4;
                            if (!Values.js_get_delegate(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "BeginFoldoutHeaderGroup", typeof(System.Action<UnityEngine.Rect>), 4);
                            }
                            UnityEngine.GUIStyle arg5;
                            if (!Values.js_get_classvalue(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "BeginFoldoutHeaderGroup", typeof(UnityEngine.GUIStyle), 5);
                            }
                            var ret = UnityEditor.EditorGUI.BeginFoldoutHeaderGroup(arg0, arg1, arg2, arg3, arg4, arg5);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.GUIStyle)) && Values.js_match_type(ctx, argv[4], typeof(System.Action<UnityEngine.Rect>)) && Values.js_match_type(ctx, argv[5], typeof(UnityEngine.GUIStyle)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "BeginFoldoutHeaderGroup", typeof(UnityEngine.Rect), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "BeginFoldoutHeaderGroup", typeof(bool), 1);
                            }
                            UnityEngine.GUIContent arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "BeginFoldoutHeaderGroup", typeof(UnityEngine.GUIContent), 2);
                            }
                            UnityEngine.GUIStyle arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "BeginFoldoutHeaderGroup", typeof(UnityEngine.GUIStyle), 3);
                            }
                            System.Action<UnityEngine.Rect> arg4;
                            if (!Values.js_get_delegate(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "BeginFoldoutHeaderGroup", typeof(System.Action<UnityEngine.Rect>), 4);
                            }
                            UnityEngine.GUIStyle arg5;
                            if (!Values.js_get_classvalue(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "BeginFoldoutHeaderGroup", typeof(UnityEngine.GUIStyle), 5);
                            }
                            var ret = UnityEditor.EditorGUI.BeginFoldoutHeaderGroup(arg0, arg1, arg2, arg3, arg4, arg5);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("BeginFoldoutHeaderGroup", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_EndFoldoutHeaderGroup(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorGUI.EndFoldoutHeaderGroup();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("EndFoldoutHeaderGroup", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawRect(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawRect", typeof(UnityEngine.Rect), 0);
                    }
                    UnityEngine.Color arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUI), "DrawRect", typeof(UnityEngine.Color), 1);
                    }
                    UnityEditor.EditorGUI.DrawRect(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawRect", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GradientField(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "GradientField", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.GUIContent arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "GradientField", typeof(UnityEngine.GUIContent), 1);
                        }
                        UnityEngine.Gradient arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "GradientField", typeof(UnityEngine.Gradient), 2);
                        }
                        bool arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "GradientField", typeof(bool), 3);
                        }
                        UnityEngine.ColorSpace arg4;
                        if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "GradientField", typeof(UnityEngine.ColorSpace), 4);
                        }
                        var ret = UnityEditor.EditorGUI.GradientField(arg0, arg1, arg2, arg3, arg4);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 4)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "GradientField", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.GUIContent arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "GradientField", typeof(UnityEngine.GUIContent), 1);
                        }
                        UnityEngine.Gradient arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "GradientField", typeof(UnityEngine.Gradient), 2);
                        }
                        bool arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "GradientField", typeof(bool), 3);
                        }
                        var ret = UnityEditor.EditorGUI.GradientField(arg0, arg1, arg2, arg3);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Gradient)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "GradientField", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "GradientField", typeof(string), 1);
                            }
                            UnityEngine.Gradient arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "GradientField", typeof(UnityEngine.Gradient), 2);
                            }
                            var ret = UnityEditor.EditorGUI.GradientField(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Gradient)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "GradientField", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "GradientField", typeof(UnityEngine.GUIContent), 1);
                            }
                            UnityEngine.Gradient arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUI), "GradientField", typeof(UnityEngine.Gradient), 2);
                            }
                            var ret = UnityEditor.EditorGUI.GradientField(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "GradientField", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.Gradient arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "GradientField", typeof(UnityEngine.Gradient), 1);
                        }
                        var ret = UnityEditor.EditorGUI.GradientField(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("GradientField", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_showMixedValue(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorGUI.showMixedValue;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_showMixedValue(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorGUI), "showMixedValue", typeof(bool), 0);
                }
                UnityEditor.EditorGUI.showMixedValue = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_actionKey(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorGUI.actionKey;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_indentLevel(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorGUI.indentLevel;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_indentLevel(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorGUI), "indentLevel", typeof(int), 0);
                }
                UnityEditor.EditorGUI.indentLevel = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_hyperLinkClicked(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                System.Action<UnityEditor.EditorWindow, UnityEditor.HyperLinkClickedEventArgs> value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "hyperLinkClicked", typeof(System.Action<UnityEditor.EditorWindow, UnityEditor.HyperLinkClickedEventArgs>), 1);
                        }
                        UnityEditor.EditorGUI.hyperLinkClicked += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUI), "hyperLinkClicked", typeof(System.Action<UnityEditor.EditorWindow, UnityEditor.HyperLinkClickedEventArgs>), 1);
                        }
                        UnityEditor.EditorGUI.hyperLinkClicked -= value;
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
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("EditorGUI", typeof(UnityEditor.EditorGUI), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "FocusTextInControl", BindStatic_FocusTextInControl);
            cls.AddMethod(true, "BeginDisabledGroup", BindStatic_BeginDisabledGroup);
            cls.AddMethod(true, "EndDisabledGroup", BindStatic_EndDisabledGroup);
            cls.AddMethod(true, "BeginChangeCheck", BindStatic_BeginChangeCheck);
            cls.AddMethod(true, "EndChangeCheck", BindStatic_EndChangeCheck);
            cls.AddMethod(true, "DropShadowLabel", BindStatic_DropShadowLabel);
            cls.AddMethod(true, "Toggle", BindStatic_Toggle);
            cls.AddMethod(true, "Slider", BindStatic_Slider);
            cls.AddMethod(true, "IntSlider", BindStatic_IntSlider);
            cls.AddMethod(true, "MinMaxSlider", BindStatic_MinMaxSlider);
            cls.AddMethod(true, "EnumFlagsField", BindStatic_EnumFlagsField);
            cls.AddMethod(true, "ObjectField", BindStatic_ObjectField);
            cls.AddMethod(true, "IndentedRect", BindStatic_IndentedRect);
            cls.AddMethod(true, "Vector2Field", BindStatic_Vector2Field);
            cls.AddMethod(true, "Vector3Field", BindStatic_Vector3Field);
            cls.AddMethod(true, "Vector4Field", BindStatic_Vector4Field);
            cls.AddMethod(true, "Vector2IntField", BindStatic_Vector2IntField);
            cls.AddMethod(true, "Vector3IntField", BindStatic_Vector3IntField);
            cls.AddMethod(true, "RectField", BindStatic_RectField);
            cls.AddMethod(true, "RectIntField", BindStatic_RectIntField);
            cls.AddMethod(true, "BoundsField", BindStatic_BoundsField);
            cls.AddMethod(true, "BoundsIntField", BindStatic_BoundsIntField);
            cls.AddMethod(true, "MultiFloatField", BindStatic_MultiFloatField);
            cls.AddMethod(true, "MultiIntField", BindStatic_MultiIntField);
            cls.AddMethod(true, "MultiPropertyField", BindStatic_MultiPropertyField);
            cls.AddMethod(true, "ColorField", BindStatic_ColorField);
            cls.AddMethod(true, "CurveField", BindStatic_CurveField);
            cls.AddMethod(true, "InspectorTitlebar", BindStatic_InspectorTitlebar);
            cls.AddMethod(true, "ProgressBar", BindStatic_ProgressBar);
            cls.AddMethod(true, "HelpBox", BindStatic_HelpBox);
            cls.AddMethod(true, "PrefixLabel", BindStatic_PrefixLabel);
            cls.AddMethod(true, "BeginProperty", BindStatic_BeginProperty);
            cls.AddMethod(true, "EndProperty", BindStatic_EndProperty);
            cls.AddMethod(true, "GetPropertyHeight", BindStatic_GetPropertyHeight);
            cls.AddMethod(true, "CanCacheInspectorGUI", BindStatic_CanCacheInspectorGUI);
            cls.AddMethod(true, "DropdownButton", BindStatic_DropdownButton);
            cls.AddMethod(true, "DrawTextureAlpha", BindStatic_DrawTextureAlpha);
            cls.AddMethod(true, "DrawTextureTransparent", BindStatic_DrawTextureTransparent);
            cls.AddMethod(true, "DrawPreviewTexture", BindStatic_DrawPreviewTexture);
            cls.AddMethod(true, "LabelField", BindStatic_LabelField);
            cls.AddMethod(true, "LinkButton", BindStatic_LinkButton);
            cls.AddMethod(true, "ToggleLeft", BindStatic_ToggleLeft);
            cls.AddMethod(true, "TextField", BindStatic_TextField);
            cls.AddMethod(true, "DelayedTextField", BindStatic_DelayedTextField);
            cls.AddMethod(true, "TextArea", BindStatic_TextArea);
            cls.AddMethod(true, "SelectableLabel", BindStatic_SelectableLabel);
            cls.AddMethod(true, "PasswordField", BindStatic_PasswordField);
            cls.AddMethod(true, "FloatField", BindStatic_FloatField);
            cls.AddMethod(true, "DelayedFloatField", BindStatic_DelayedFloatField);
            cls.AddMethod(true, "DoubleField", BindStatic_DoubleField);
            cls.AddMethod(true, "DelayedDoubleField", BindStatic_DelayedDoubleField);
            cls.AddMethod(true, "IntField", BindStatic_IntField);
            cls.AddMethod(true, "DelayedIntField", BindStatic_DelayedIntField);
            cls.AddMethod(true, "LongField", BindStatic_LongField);
            cls.AddMethod(true, "Popup", BindStatic_Popup);
            cls.AddMethod(true, "EnumPopup", BindStatic_EnumPopup);
            cls.AddMethod(true, "IntPopup", BindStatic_IntPopup);
            cls.AddMethod(true, "TagField", BindStatic_TagField);
            cls.AddMethod(true, "LayerField", BindStatic_LayerField);
            cls.AddMethod(true, "MaskField", BindStatic_MaskField);
            cls.AddMethod(true, "Foldout", BindStatic_Foldout);
            cls.AddMethod(true, "HandlePrefixLabel", BindStatic_HandlePrefixLabel);
            cls.AddMethod(true, "PropertyField", BindStatic_PropertyField);
            cls.AddMethod(true, "BeginFoldoutHeaderGroup", BindStatic_BeginFoldoutHeaderGroup);
            cls.AddMethod(true, "EndFoldoutHeaderGroup", BindStatic_EndFoldoutHeaderGroup);
            cls.AddMethod(true, "DrawRect", BindStatic_DrawRect);
            cls.AddMethod(true, "GradientField", BindStatic_GradientField);
            cls.AddProperty(true, "showMixedValue", BindStaticRead_showMixedValue, BindStaticWrite_showMixedValue);
            cls.AddProperty(true, "actionKey", BindStaticRead_actionKey, null);
            cls.AddProperty(true, "indentLevel", BindStaticRead_indentLevel, BindStaticWrite_indentLevel);
            cls.AddMethod(true, "hyperLinkClicked", BindStaticEvent_hyperLinkClicked);
            return cls;
        }
    }
}
#endif
#endif
