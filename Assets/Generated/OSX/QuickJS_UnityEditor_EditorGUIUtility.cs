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
    // Type: UnityEditor.EditorGUIUtility
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_EditorGUIUtility
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SerializeMainMenuToString(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.EditorGUIUtility.SerializeMainMenuToString();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("SerializeMainMenuToString", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetMenuLocalizationTestMode(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    bool arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "SetMenuLocalizationTestMode", typeof(bool), 0);
                    }
                    UnityEditor.EditorGUIUtility.SetMenuLocalizationTestMode(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetMenuLocalizationTestMode", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetIconSize(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Vector2 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "SetIconSize", typeof(UnityEngine.Vector2), 0);
                    }
                    UnityEditor.EditorGUIUtility.SetIconSize(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetIconSize", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetWantsMouseJumping(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "SetWantsMouseJumping", typeof(int), 0);
                    }
                    UnityEditor.EditorGUIUtility.SetWantsMouseJumping(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetWantsMouseJumping", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsDisplayReferencedByCameras(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "IsDisplayReferencedByCameras", typeof(int), 0);
                    }
                    var ret = UnityEditor.EditorGUIUtility.IsDisplayReferencedByCameras(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsDisplayReferencedByCameras", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_QueueGameViewInputEvent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Event arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "QueueGameViewInputEvent", typeof(UnityEngine.Event), 0);
                    }
                    UnityEditor.EditorGUIUtility.QueueGameViewInputEvent(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("QueueGameViewInputEvent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetIconForObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "SetIconForObject", typeof(UnityEngine.Object), 0);
                    }
                    UnityEngine.Texture2D arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "SetIconForObject", typeof(UnityEngine.Texture2D), 1);
                    }
                    UnityEditor.EditorGUIUtility.SetIconForObject(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetIconForObject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetIconForObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "GetIconForObject", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.EditorGUIUtility.GetIconForObject(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetIconForObject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetMainWindowPosition(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.EditorGUIUtility.GetMainWindowPosition();
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetMainWindowPosition", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetMainWindowPosition(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "SetMainWindowPosition", typeof(UnityEngine.Rect), 0);
                    }
                    UnityEditor.EditorGUIUtility.SetMainWindowPosition(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetMainWindowPosition", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_PointsToPixels(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "PointsToPixels", typeof(UnityEngine.Rect), 0);
                            }
                            var ret = UnityEditor.EditorGUIUtility.PointsToPixels(arg0);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector2)))
                        {
                            UnityEngine.Vector2 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "PointsToPixels", typeof(UnityEngine.Vector2), 0);
                            }
                            var ret = UnityEditor.EditorGUIUtility.PointsToPixels(arg0);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("PointsToPixels", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_PixelsToPoints(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "PixelsToPoints", typeof(UnityEngine.Rect), 0);
                            }
                            var ret = UnityEditor.EditorGUIUtility.PixelsToPoints(arg0);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Vector2)))
                        {
                            UnityEngine.Vector2 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "PixelsToPoints", typeof(UnityEngine.Vector2), 0);
                            }
                            var ret = UnityEditor.EditorGUIUtility.PixelsToPoints(arg0);
                            return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("PixelsToPoints", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetFlowLayoutedRects(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 5)
                {
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "GetFlowLayoutedRects", typeof(UnityEngine.Rect), 0);
                    }
                    UnityEngine.GUIStyle arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "GetFlowLayoutedRects", typeof(UnityEngine.GUIStyle), 1);
                    }
                    float arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "GetFlowLayoutedRects", typeof(float), 2);
                    }
                    float arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "GetFlowLayoutedRects", typeof(float), 3);
                    }
                    System.Collections.Generic.List<string> arg4;
                    if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "GetFlowLayoutedRects", typeof(System.Collections.Generic.List<string>), 4);
                    }
                    var ret = UnityEditor.EditorGUIUtility.GetFlowLayoutedRects(arg0, arg1, arg2, arg3, arg4);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetFlowLayoutedRects", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_FindTexture(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "FindTexture", typeof(string), 0);
                    }
                    var ret = UnityEditor.EditorGUIUtility.FindTexture(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("FindTexture", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_TrTextContent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrTextContent", typeof(string), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrTextContent", typeof(string), 1);
                        }
                        string arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrTextContent", typeof(string), 2);
                        }
                        UnityEngine.Texture arg3;
                        if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrTextContent", typeof(UnityEngine.Texture), 3);
                        }
                        var ret = UnityEditor.EditorGUIUtility.TrTextContent(arg0, arg1, arg2, arg3);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Texture)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrTextContent", typeof(string), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrTextContent", typeof(string), 1);
                            }
                            UnityEngine.Texture arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrTextContent", typeof(UnityEngine.Texture), 2);
                            }
                            var ret = UnityEditor.EditorGUIUtility.TrTextContent(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(string)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrTextContent", typeof(string), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrTextContent", typeof(string), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrTextContent", typeof(string), 2);
                            }
                            var ret = UnityEditor.EditorGUIUtility.TrTextContent(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrTextContent", typeof(string), 0);
                        }
                        UnityEngine.Texture arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrTextContent", typeof(UnityEngine.Texture), 1);
                        }
                        var ret = UnityEditor.EditorGUIUtility.TrTextContent(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("TrTextContent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_TrTextContentWithIcon(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(string)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrTextContentWithIcon", typeof(string), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrTextContentWithIcon", typeof(string), 1);
                            }
                            string arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrTextContentWithIcon", typeof(string), 2);
                            }
                            var ret = UnityEditor.EditorGUIUtility.TrTextContentWithIcon(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Texture)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrTextContentWithIcon", typeof(string), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrTextContentWithIcon", typeof(string), 1);
                            }
                            UnityEngine.Texture arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrTextContentWithIcon", typeof(UnityEngine.Texture), 2);
                            }
                            var ret = UnityEditor.EditorGUIUtility.TrTextContentWithIcon(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEditor.MessageType)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrTextContentWithIcon", typeof(string), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrTextContentWithIcon", typeof(string), 1);
                            }
                            UnityEditor.MessageType arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrTextContentWithIcon", typeof(UnityEditor.MessageType), 2);
                            }
                            var ret = UnityEditor.EditorGUIUtility.TrTextContentWithIcon(arg0, arg1, arg2);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Texture)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrTextContentWithIcon", typeof(string), 0);
                            }
                            UnityEngine.Texture arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrTextContentWithIcon", typeof(UnityEngine.Texture), 1);
                            }
                            var ret = UnityEditor.EditorGUIUtility.TrTextContentWithIcon(arg0, arg1);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(string)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrTextContentWithIcon", typeof(string), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrTextContentWithIcon", typeof(string), 1);
                            }
                            var ret = UnityEditor.EditorGUIUtility.TrTextContentWithIcon(arg0, arg1);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.MessageType)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrTextContentWithIcon", typeof(string), 0);
                            }
                            UnityEditor.MessageType arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrTextContentWithIcon", typeof(UnityEditor.MessageType), 1);
                            }
                            var ret = UnityEditor.EditorGUIUtility.TrTextContentWithIcon(arg0, arg1);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("TrTextContentWithIcon", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_TrIconContent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(string)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrIconContent", typeof(string), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrIconContent", typeof(string), 1);
                            }
                            var ret = UnityEditor.EditorGUIUtility.TrIconContent(arg0, arg1);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Texture)) && Values.js_match_type(ctx, argv[1], typeof(string)))
                        {
                            UnityEngine.Texture arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrIconContent", typeof(UnityEngine.Texture), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrIconContent", typeof(string), 1);
                            }
                            var ret = UnityEditor.EditorGUIUtility.TrIconContent(arg0, arg1);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("TrIconContent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_TrTempContent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        string[] arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrTempContent", typeof(string[]), 0);
                        }
                        string[] arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrTempContent", typeof(string[]), 1);
                        }
                        var ret = UnityEditor.EditorGUIUtility.TrTempContent(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrTempContent", typeof(string), 0);
                            }
                            var ret = UnityEditor.EditorGUIUtility.TrTempContent(arg0);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string[])))
                        {
                            string[] arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "TrTempContent", typeof(string[]), 0);
                            }
                            var ret = UnityEditor.EditorGUIUtility.TrTempContent(arg0);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("TrTempContent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IconContent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "IconContent", typeof(string), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "IconContent", typeof(string), 1);
                        }
                        var ret = UnityEditor.EditorGUIUtility.IconContent(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "IconContent", typeof(string), 0);
                        }
                        var ret = UnityEditor.EditorGUIUtility.IconContent(arg0);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("IconContent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ObjectContent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "ObjectContent", typeof(UnityEngine.Object), 0);
                    }
                    System.Type arg1;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "ObjectContent", typeof(System.Type), 1);
                    }
                    var ret = UnityEditor.EditorGUIUtility.ObjectContent(arg0, arg1);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("ObjectContent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_HasObjectThumbnail(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    System.Type arg0;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "HasObjectThumbnail", typeof(System.Type), 0);
                    }
                    var ret = UnityEditor.EditorGUIUtility.HasObjectThumbnail(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("HasObjectThumbnail", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetIconSize(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.EditorGUIUtility.GetIconSize();
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetIconSize", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetBuiltinSkin(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.EditorSkin arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "GetBuiltinSkin", typeof(UnityEditor.EditorSkin), 0);
                    }
                    var ret = UnityEditor.EditorGUIUtility.GetBuiltinSkin(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetBuiltinSkin", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LoadRequired(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "LoadRequired", typeof(string), 0);
                    }
                    var ret = UnityEditor.EditorGUIUtility.LoadRequired(arg0);
                    return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("LoadRequired", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Load(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "Load", typeof(string), 0);
                    }
                    var ret = UnityEditor.EditorGUIUtility.Load(arg0);
                    return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("Load", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_PingObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "PingObject", typeof(UnityEngine.Object), 0);
                            }
                            UnityEditor.EditorGUIUtility.PingObject(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "PingObject", typeof(int), 0);
                            }
                            UnityEditor.EditorGUIUtility.PingObject(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("PingObject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CommandEvent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "CommandEvent", typeof(string), 0);
                    }
                    var ret = UnityEditor.EditorGUIUtility.CommandEvent(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("CommandEvent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawColorSwatch(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawColorSwatch", typeof(UnityEngine.Rect), 0);
                    }
                    UnityEngine.Color arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawColorSwatch", typeof(UnityEngine.Color), 1);
                    }
                    UnityEditor.EditorGUIUtility.DrawColorSwatch(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawColorSwatch", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawCurveSwatch(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawCurveSwatch", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.AnimationCurve arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawCurveSwatch", typeof(UnityEngine.AnimationCurve), 1);
                        }
                        UnityEditor.SerializedProperty arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawCurveSwatch", typeof(UnityEditor.SerializedProperty), 2);
                        }
                        UnityEngine.Color arg3;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawCurveSwatch", typeof(UnityEngine.Color), 3);
                        }
                        UnityEngine.Color arg4;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawCurveSwatch", typeof(UnityEngine.Color), 4);
                        }
                        UnityEngine.Color arg5;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawCurveSwatch", typeof(UnityEngine.Color), 5);
                        }
                        UnityEngine.Color arg6;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawCurveSwatch", typeof(UnityEngine.Color), 6);
                        }
                        UnityEngine.Rect arg7;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[7], out arg7))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawCurveSwatch", typeof(UnityEngine.Rect), 7);
                        }
                        UnityEditor.EditorGUIUtility.DrawCurveSwatch(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 7)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawCurveSwatch", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.AnimationCurve arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawCurveSwatch", typeof(UnityEngine.AnimationCurve), 1);
                        }
                        UnityEditor.SerializedProperty arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawCurveSwatch", typeof(UnityEditor.SerializedProperty), 2);
                        }
                        UnityEngine.Color arg3;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawCurveSwatch", typeof(UnityEngine.Color), 3);
                        }
                        UnityEngine.Color arg4;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawCurveSwatch", typeof(UnityEngine.Color), 4);
                        }
                        UnityEngine.Color arg5;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawCurveSwatch", typeof(UnityEngine.Color), 5);
                        }
                        UnityEngine.Color arg6;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawCurveSwatch", typeof(UnityEngine.Color), 6);
                        }
                        UnityEditor.EditorGUIUtility.DrawCurveSwatch(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 6)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawCurveSwatch", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.AnimationCurve arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawCurveSwatch", typeof(UnityEngine.AnimationCurve), 1);
                        }
                        UnityEditor.SerializedProperty arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawCurveSwatch", typeof(UnityEditor.SerializedProperty), 2);
                        }
                        UnityEngine.Color arg3;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawCurveSwatch", typeof(UnityEngine.Color), 3);
                        }
                        UnityEngine.Color arg4;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawCurveSwatch", typeof(UnityEngine.Color), 4);
                        }
                        UnityEngine.Rect arg5;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawCurveSwatch", typeof(UnityEngine.Rect), 5);
                        }
                        UnityEditor.EditorGUIUtility.DrawCurveSwatch(arg0, arg1, arg2, arg3, arg4, arg5);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 5)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawCurveSwatch", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.AnimationCurve arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawCurveSwatch", typeof(UnityEngine.AnimationCurve), 1);
                        }
                        UnityEditor.SerializedProperty arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawCurveSwatch", typeof(UnityEditor.SerializedProperty), 2);
                        }
                        UnityEngine.Color arg3;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawCurveSwatch", typeof(UnityEngine.Color), 3);
                        }
                        UnityEngine.Color arg4;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawCurveSwatch", typeof(UnityEngine.Color), 4);
                        }
                        UnityEditor.EditorGUIUtility.DrawCurveSwatch(arg0, arg1, arg2, arg3, arg4);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("DrawCurveSwatch", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawRegionSwatch(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 6)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[2], typeof(UnityEditor.SerializedProperty)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Color)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.Color)) && Values.js_match_type(ctx, argv[5], typeof(UnityEngine.Rect)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawRegionSwatch", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEditor.SerializedProperty arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawRegionSwatch", typeof(UnityEditor.SerializedProperty), 1);
                            }
                            UnityEditor.SerializedProperty arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawRegionSwatch", typeof(UnityEditor.SerializedProperty), 2);
                            }
                            UnityEngine.Color arg3;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawRegionSwatch", typeof(UnityEngine.Color), 3);
                            }
                            UnityEngine.Color arg4;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawRegionSwatch", typeof(UnityEngine.Color), 4);
                            }
                            UnityEngine.Rect arg5;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawRegionSwatch", typeof(UnityEngine.Rect), 5);
                            }
                            UnityEditor.EditorGUIUtility.DrawRegionSwatch(arg0, arg1, arg2, arg3, arg4, arg5);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.AnimationCurve)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.AnimationCurve)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Color)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.Color)) && Values.js_match_type(ctx, argv[5], typeof(UnityEngine.Rect)))
                        {
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawRegionSwatch", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.AnimationCurve arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawRegionSwatch", typeof(UnityEngine.AnimationCurve), 1);
                            }
                            UnityEngine.AnimationCurve arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawRegionSwatch", typeof(UnityEngine.AnimationCurve), 2);
                            }
                            UnityEngine.Color arg3;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawRegionSwatch", typeof(UnityEngine.Color), 3);
                            }
                            UnityEngine.Color arg4;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawRegionSwatch", typeof(UnityEngine.Color), 4);
                            }
                            UnityEngine.Rect arg5;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "DrawRegionSwatch", typeof(UnityEngine.Rect), 5);
                            }
                            UnityEditor.EditorGUIUtility.DrawRegionSwatch(arg0, arg1, arg2, arg3, arg4, arg5);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("DrawRegionSwatch", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_AddCursorRect(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "AddCursorRect", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEditor.MouseCursor arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "AddCursorRect", typeof(UnityEditor.MouseCursor), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "AddCursorRect", typeof(int), 2);
                        }
                        UnityEditor.EditorGUIUtility.AddCursorRect(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "AddCursorRect", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEditor.MouseCursor arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "AddCursorRect", typeof(UnityEditor.MouseCursor), 1);
                        }
                        UnityEditor.EditorGUIUtility.AddCursorRect(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("AddCursorRect", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetObjectPickerObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.EditorGUIUtility.GetObjectPickerObject();
                    return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetObjectPickerObject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetObjectPickerControlID(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.EditorGUIUtility.GetObjectPickerControlID();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetObjectPickerControlID", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_whiteTexture(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorGUIUtility.whiteTexture;
                return Values.js_push_classvalue(ctx, ret);
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
                var ret = UnityEditor.EditorGUIUtility.systemCopyBuffer;
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
                    throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "systemCopyBuffer", typeof(string), 0);
                }
                UnityEditor.EditorGUIUtility.systemCopyBuffer = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_pixelsPerPoint(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorGUIUtility.pixelsPerPoint;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_singleLineHeight(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorGUIUtility.singleLineHeight;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_standardVerticalSpacing(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorGUIUtility.standardVerticalSpacing;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_isProSkin(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorGUIUtility.isProSkin;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_editingTextField(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorGUIUtility.editingTextField;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_editingTextField(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "editingTextField", typeof(bool), 0);
                }
                UnityEditor.EditorGUIUtility.editingTextField = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_textFieldHasSelection(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorGUIUtility.textFieldHasSelection;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_hierarchyMode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorGUIUtility.hierarchyMode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_hierarchyMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "hierarchyMode", typeof(bool), 0);
                }
                UnityEditor.EditorGUIUtility.hierarchyMode = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_wideMode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorGUIUtility.wideMode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_wideMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "wideMode", typeof(bool), 0);
                }
                UnityEditor.EditorGUIUtility.wideMode = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_currentViewWidth(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorGUIUtility.currentViewWidth;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_labelWidth(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorGUIUtility.labelWidth;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_labelWidth(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "labelWidth", typeof(float), 0);
                }
                UnityEditor.EditorGUIUtility.labelWidth = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_fieldWidth(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorGUIUtility.fieldWidth;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_fieldWidth(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorGUIUtility), "fieldWidth", typeof(float), 0);
                }
                UnityEditor.EditorGUIUtility.fieldWidth = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("EditorGUIUtility", typeof(UnityEditor.EditorGUIUtility), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "SerializeMainMenuToString", BindStatic_SerializeMainMenuToString);
            cls.AddMethod(true, "SetMenuLocalizationTestMode", BindStatic_SetMenuLocalizationTestMode);
            cls.AddMethod(true, "SetIconSize", BindStatic_SetIconSize);
            cls.AddMethod(true, "SetWantsMouseJumping", BindStatic_SetWantsMouseJumping);
            cls.AddMethod(true, "IsDisplayReferencedByCameras", BindStatic_IsDisplayReferencedByCameras);
            cls.AddMethod(true, "QueueGameViewInputEvent", BindStatic_QueueGameViewInputEvent);
            cls.AddMethod(true, "SetIconForObject", BindStatic_SetIconForObject);
            cls.AddMethod(true, "GetIconForObject", BindStatic_GetIconForObject);
            cls.AddMethod(true, "GetMainWindowPosition", BindStatic_GetMainWindowPosition);
            cls.AddMethod(true, "SetMainWindowPosition", BindStatic_SetMainWindowPosition);
            cls.AddMethod(true, "PointsToPixels", BindStatic_PointsToPixels);
            cls.AddMethod(true, "PixelsToPoints", BindStatic_PixelsToPoints);
            cls.AddMethod(true, "GetFlowLayoutedRects", BindStatic_GetFlowLayoutedRects);
            cls.AddMethod(true, "FindTexture", BindStatic_FindTexture);
            cls.AddMethod(true, "TrTextContent", BindStatic_TrTextContent);
            cls.AddMethod(true, "TrTextContentWithIcon", BindStatic_TrTextContentWithIcon);
            cls.AddMethod(true, "TrIconContent", BindStatic_TrIconContent);
            cls.AddMethod(true, "TrTempContent", BindStatic_TrTempContent);
            cls.AddMethod(true, "IconContent", BindStatic_IconContent);
            cls.AddMethod(true, "ObjectContent", BindStatic_ObjectContent);
            cls.AddMethod(true, "HasObjectThumbnail", BindStatic_HasObjectThumbnail);
            cls.AddMethod(true, "GetIconSize", BindStatic_GetIconSize);
            cls.AddMethod(true, "GetBuiltinSkin", BindStatic_GetBuiltinSkin);
            cls.AddMethod(true, "LoadRequired", BindStatic_LoadRequired);
            cls.AddMethod(true, "Load", BindStatic_Load);
            cls.AddMethod(true, "PingObject", BindStatic_PingObject);
            cls.AddMethod(true, "CommandEvent", BindStatic_CommandEvent);
            cls.AddMethod(true, "DrawColorSwatch", BindStatic_DrawColorSwatch);
            cls.AddMethod(true, "DrawCurveSwatch", BindStatic_DrawCurveSwatch);
            cls.AddMethod(true, "DrawRegionSwatch", BindStatic_DrawRegionSwatch);
            cls.AddMethod(true, "AddCursorRect", BindStatic_AddCursorRect);
            cls.AddMethod(true, "GetObjectPickerObject", BindStatic_GetObjectPickerObject);
            cls.AddMethod(true, "GetObjectPickerControlID", BindStatic_GetObjectPickerControlID);
            cls.AddProperty(true, "whiteTexture", BindStaticRead_whiteTexture, null);
            cls.AddProperty(true, "systemCopyBuffer", BindStaticRead_systemCopyBuffer, BindStaticWrite_systemCopyBuffer);
            cls.AddProperty(true, "pixelsPerPoint", BindStaticRead_pixelsPerPoint, null);
            cls.AddProperty(true, "singleLineHeight", BindStaticRead_singleLineHeight, null);
            cls.AddProperty(true, "standardVerticalSpacing", BindStaticRead_standardVerticalSpacing, null);
            cls.AddProperty(true, "isProSkin", BindStaticRead_isProSkin, null);
            cls.AddProperty(true, "editingTextField", BindStaticRead_editingTextField, BindStaticWrite_editingTextField);
            cls.AddProperty(true, "textFieldHasSelection", BindStaticRead_textFieldHasSelection, null);
            cls.AddProperty(true, "hierarchyMode", BindStaticRead_hierarchyMode, BindStaticWrite_hierarchyMode);
            cls.AddProperty(true, "wideMode", BindStaticRead_wideMode, BindStaticWrite_wideMode);
            cls.AddProperty(true, "currentViewWidth", BindStaticRead_currentViewWidth, null);
            cls.AddProperty(true, "labelWidth", BindStaticRead_labelWidth, BindStaticWrite_labelWidth);
            cls.AddProperty(true, "fieldWidth", BindStaticRead_fieldWidth, BindStaticWrite_fieldWidth);
            return cls;
        }
    }
}
#endif
#endif
