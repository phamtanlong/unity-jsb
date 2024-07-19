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
    // Type: UnityEngine.GUIStyle
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_GUIStyle
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        UnityEngine.GUIStyle arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUIStyle), ".ctor", typeof(UnityEngine.GUIStyle), 0);
                        }
                        var o = new UnityEngine.GUIStyle(arg0);
                        var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                        return val;
                    }
                    if (argc == 0)
                    {
                        var o = new UnityEngine.GUIStyle();
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
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Draw(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 6)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(bool)) && Values.js_match_type(ctx, argv[3], typeof(bool)) && Values.js_match_type(ctx, argv[4], typeof(bool)) && Values.js_match_type(ctx, argv[5], typeof(bool)))
                        {
                            UnityEngine.GUIStyle self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(UnityEngine.Rect), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(string), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(bool), 2);
                            }
                            bool arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(bool), 3);
                            }
                            bool arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(bool), 4);
                            }
                            bool arg5;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(bool), 5);
                            }
                            self.Draw(arg0, arg1, arg2, arg3, arg4, arg5);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Texture)) && Values.js_match_type(ctx, argv[2], typeof(bool)) && Values.js_match_type(ctx, argv[3], typeof(bool)) && Values.js_match_type(ctx, argv[4], typeof(bool)) && Values.js_match_type(ctx, argv[5], typeof(bool)))
                        {
                            UnityEngine.GUIStyle self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.Texture arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(UnityEngine.Texture), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(bool), 2);
                            }
                            bool arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(bool), 3);
                            }
                            bool arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(bool), 4);
                            }
                            bool arg5;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(bool), 5);
                            }
                            self.Draw(arg0, arg1, arg2, arg3, arg4, arg5);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(bool)) && Values.js_match_type(ctx, argv[3], typeof(bool)) && Values.js_match_type(ctx, argv[4], typeof(bool)) && Values.js_match_type(ctx, argv[5], typeof(bool)))
                        {
                            UnityEngine.GUIStyle self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(UnityEngine.GUIContent), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(bool), 2);
                            }
                            bool arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(bool), 3);
                            }
                            bool arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(bool), 4);
                            }
                            bool arg5;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(bool), 5);
                            }
                            self.Draw(arg0, arg1, arg2, arg3, arg4, arg5);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(bool)) && Values.js_match_type(ctx, argv[2], typeof(bool)) && Values.js_match_type(ctx, argv[3], typeof(bool)) && Values.js_match_type(ctx, argv[4], typeof(bool)))
                        {
                            UnityEngine.GUIStyle self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(UnityEngine.Rect), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(bool), 1);
                            }
                            bool arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(bool), 2);
                            }
                            bool arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(bool), 3);
                            }
                            bool arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(bool), 4);
                            }
                            self.Draw(arg0, arg1, arg2, arg3, arg4);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Rect)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.GUIContent)) && Values.js_match_type(ctx, argv[2], typeof(int)) && Values.js_match_type(ctx, argv[3], typeof(bool)) && Values.js_match_type(ctx, argv[4], typeof(bool)))
                        {
                            UnityEngine.GUIStyle self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEngine.Rect arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(UnityEngine.Rect), 0);
                            }
                            UnityEngine.GUIContent arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(UnityEngine.GUIContent), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(int), 2);
                            }
                            bool arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(bool), 3);
                            }
                            bool arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(bool), 4);
                            }
                            self.Draw(arg0, arg1, arg2, arg3, arg4);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 4)
                    {
                        UnityEngine.GUIStyle self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.GUIContent arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(UnityEngine.GUIContent), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(int), 2);
                        }
                        bool arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(bool), 3);
                        }
                        self.Draw(arg0, arg1, arg2, arg3);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 3)
                    {
                        UnityEngine.GUIStyle self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.GUIContent arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(UnityEngine.GUIContent), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.GUIStyle), "Draw", typeof(int), 2);
                        }
                        self.Draw(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("Draw", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawCursor(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 4)
                {
                    UnityEngine.GUIStyle self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIStyle), "DrawCursor", typeof(UnityEngine.Rect), 0);
                    }
                    UnityEngine.GUIContent arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIStyle), "DrawCursor", typeof(UnityEngine.GUIContent), 1);
                    }
                    int arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIStyle), "DrawCursor", typeof(int), 2);
                    }
                    int arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIStyle), "DrawCursor", typeof(int), 3);
                    }
                    self.DrawCursor(arg0, arg1, arg2, arg3);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawCursor", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawWithTextSelection(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 5)
                {
                    UnityEngine.GUIStyle self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIStyle), "DrawWithTextSelection", typeof(UnityEngine.Rect), 0);
                    }
                    UnityEngine.GUIContent arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIStyle), "DrawWithTextSelection", typeof(UnityEngine.GUIContent), 1);
                    }
                    int arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIStyle), "DrawWithTextSelection", typeof(int), 2);
                    }
                    int arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIStyle), "DrawWithTextSelection", typeof(int), 3);
                    }
                    int arg4;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIStyle), "DrawWithTextSelection", typeof(int), 4);
                    }
                    self.DrawWithTextSelection(arg0, arg1, arg2, arg3, arg4);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawWithTextSelection", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetCursorPixelPosition(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.GUIStyle self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIStyle), "GetCursorPixelPosition", typeof(UnityEngine.Rect), 0);
                    }
                    UnityEngine.GUIContent arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIStyle), "GetCursorPixelPosition", typeof(UnityEngine.GUIContent), 1);
                    }
                    int arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIStyle), "GetCursorPixelPosition", typeof(int), 2);
                    }
                    var ret = self.GetCursorPixelPosition(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetCursorPixelPosition", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetCursorStringIndex(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.GUIStyle self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIStyle), "GetCursorStringIndex", typeof(UnityEngine.Rect), 0);
                    }
                    UnityEngine.GUIContent arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIStyle), "GetCursorStringIndex", typeof(UnityEngine.GUIContent), 1);
                    }
                    UnityEngine.Vector2 arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIStyle), "GetCursorStringIndex", typeof(UnityEngine.Vector2), 2);
                    }
                    var ret = self.GetCursorStringIndex(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetCursorStringIndex", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_CalcSize(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.GUIStyle self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.GUIContent arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIStyle), "CalcSize", typeof(UnityEngine.GUIContent), 0);
                    }
                    var ret = self.CalcSize(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("CalcSize", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_CalcScreenSize(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.GUIStyle self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Vector2 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIStyle), "CalcScreenSize", typeof(UnityEngine.Vector2), 0);
                    }
                    var ret = self.CalcScreenSize(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("CalcScreenSize", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_CalcHeight(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.GUIStyle self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.GUIContent arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIStyle), "CalcHeight", typeof(UnityEngine.GUIContent), 0);
                    }
                    float arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIStyle), "CalcHeight", typeof(float), 1);
                    }
                    var ret = self.CalcHeight(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("CalcHeight", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_CalcMinMaxWidth(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.GUIStyle self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.GUIContent arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIStyle), "CalcMinMaxWidth", typeof(UnityEngine.GUIContent), 0);
                    }
                    float arg1;
                    float arg2;
                    self.CalcMinMaxWidth(arg0, out arg1, out arg2);
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
                throw new NoSuitableMethodException("CalcMinMaxWidth", argc);
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
                    UnityEngine.GUIStyle self;
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
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_op_Implicit(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.GUIStyle), "op_Implicit", typeof(string), 0);
                    }
                    var ret = (UnityEngine.GUIStyle)arg0;
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("op_Implicit", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_font(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.font;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_font(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Font value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIStyle), "font", typeof(UnityEngine.Font), 0);
                }
                self.font = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_imagePosition(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.imagePosition;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_imagePosition(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.ImagePosition value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIStyle), "imagePosition", typeof(UnityEngine.ImagePosition), 0);
                }
                self.imagePosition = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_alignment(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.alignment;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_alignment(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.TextAnchor value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIStyle), "alignment", typeof(UnityEngine.TextAnchor), 0);
                }
                self.alignment = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_wordWrap(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.wordWrap;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_wordWrap(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIStyle), "wordWrap", typeof(bool), 0);
                }
                self.wordWrap = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_clipping(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.clipping;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_clipping(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.TextClipping value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIStyle), "clipping", typeof(UnityEngine.TextClipping), 0);
                }
                self.clipping = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_contentOffset(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.contentOffset;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_contentOffset(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Vector2 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIStyle), "contentOffset", typeof(UnityEngine.Vector2), 0);
                }
                self.contentOffset = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_fixedWidth(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.fixedWidth;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_fixedWidth(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIStyle), "fixedWidth", typeof(float), 0);
                }
                self.fixedWidth = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_fixedHeight(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.fixedHeight;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_fixedHeight(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIStyle), "fixedHeight", typeof(float), 0);
                }
                self.fixedHeight = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_stretchWidth(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.stretchWidth;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_stretchWidth(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIStyle), "stretchWidth", typeof(bool), 0);
                }
                self.stretchWidth = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_stretchHeight(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.stretchHeight;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_stretchHeight(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIStyle), "stretchHeight", typeof(bool), 0);
                }
                self.stretchHeight = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_fontSize(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.fontSize;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_fontSize(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIStyle), "fontSize", typeof(int), 0);
                }
                self.fontSize = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_fontStyle(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.fontStyle;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_fontStyle(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.FontStyle value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIStyle), "fontStyle", typeof(UnityEngine.FontStyle), 0);
                }
                self.fontStyle = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_richText(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.richText;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_richText(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIStyle), "richText", typeof(bool), 0);
                }
                self.richText = value;
                return JSApi.JS_UNDEFINED;
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
                UnityEngine.GUIStyle self;
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
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIStyle), "name", typeof(string), 0);
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
        public static JSValue BindRead_normal(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.normal;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_normal(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.GUIStyleState value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIStyle), "normal", typeof(UnityEngine.GUIStyleState), 0);
                }
                self.normal = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_hover(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.hover;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_hover(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.GUIStyleState value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIStyle), "hover", typeof(UnityEngine.GUIStyleState), 0);
                }
                self.hover = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_active(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.active;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_active(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.GUIStyleState value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIStyle), "active", typeof(UnityEngine.GUIStyleState), 0);
                }
                self.active = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_onNormal(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.onNormal;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_onNormal(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.GUIStyleState value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIStyle), "onNormal", typeof(UnityEngine.GUIStyleState), 0);
                }
                self.onNormal = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_onHover(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.onHover;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_onHover(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.GUIStyleState value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIStyle), "onHover", typeof(UnityEngine.GUIStyleState), 0);
                }
                self.onHover = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_onActive(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.onActive;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_onActive(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.GUIStyleState value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIStyle), "onActive", typeof(UnityEngine.GUIStyleState), 0);
                }
                self.onActive = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_focused(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.focused;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_focused(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.GUIStyleState value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIStyle), "focused", typeof(UnityEngine.GUIStyleState), 0);
                }
                self.focused = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_onFocused(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.onFocused;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_onFocused(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.GUIStyleState value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIStyle), "onFocused", typeof(UnityEngine.GUIStyleState), 0);
                }
                self.onFocused = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_border(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.border;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_border(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.RectOffset value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIStyle), "border", typeof(UnityEngine.RectOffset), 0);
                }
                self.border = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_margin(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.margin;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_margin(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.RectOffset value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIStyle), "margin", typeof(UnityEngine.RectOffset), 0);
                }
                self.margin = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_padding(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.padding;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_padding(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.RectOffset value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIStyle), "padding", typeof(UnityEngine.RectOffset), 0);
                }
                self.padding = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_overflow(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.overflow;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_overflow(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.RectOffset value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.GUIStyle), "overflow", typeof(UnityEngine.RectOffset), 0);
                }
                self.overflow = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_lineHeight(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.lineHeight;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
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
                var ret = UnityEngine.GUIStyle.none;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_isHeightDependantOnWidth(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.GUIStyle self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.isHeightDependantOnWidth;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("GUIStyle", typeof(UnityEngine.GUIStyle), BindConstructor);
            cls.AddMethod(false, "Draw", Bind_Draw);
            cls.AddMethod(false, "DrawCursor", Bind_DrawCursor);
            cls.AddMethod(false, "DrawWithTextSelection", Bind_DrawWithTextSelection);
            cls.AddMethod(false, "GetCursorPixelPosition", Bind_GetCursorPixelPosition);
            cls.AddMethod(false, "GetCursorStringIndex", Bind_GetCursorStringIndex);
            cls.AddMethod(false, "CalcSize", Bind_CalcSize);
            cls.AddMethod(false, "CalcScreenSize", Bind_CalcScreenSize);
            cls.AddMethod(false, "CalcHeight", Bind_CalcHeight);
            cls.AddMethod(false, "CalcMinMaxWidth", Bind_CalcMinMaxWidth);
            cls.AddMethod(false, "toString", Bind_ToString);
            cls.AddMethod(true, "op_Implicit", BindStatic_op_Implicit);
            cls.AddProperty(false, "font", BindRead_font, BindWrite_font);
            cls.AddProperty(false, "imagePosition", BindRead_imagePosition, BindWrite_imagePosition);
            cls.AddProperty(false, "alignment", BindRead_alignment, BindWrite_alignment);
            cls.AddProperty(false, "wordWrap", BindRead_wordWrap, BindWrite_wordWrap);
            cls.AddProperty(false, "clipping", BindRead_clipping, BindWrite_clipping);
            cls.AddProperty(false, "contentOffset", BindRead_contentOffset, BindWrite_contentOffset);
            cls.AddProperty(false, "fixedWidth", BindRead_fixedWidth, BindWrite_fixedWidth);
            cls.AddProperty(false, "fixedHeight", BindRead_fixedHeight, BindWrite_fixedHeight);
            cls.AddProperty(false, "stretchWidth", BindRead_stretchWidth, BindWrite_stretchWidth);
            cls.AddProperty(false, "stretchHeight", BindRead_stretchHeight, BindWrite_stretchHeight);
            cls.AddProperty(false, "fontSize", BindRead_fontSize, BindWrite_fontSize);
            cls.AddProperty(false, "fontStyle", BindRead_fontStyle, BindWrite_fontStyle);
            cls.AddProperty(false, "richText", BindRead_richText, BindWrite_richText);
            cls.AddProperty(false, "name", BindRead_name, BindWrite_name);
            cls.AddProperty(false, "normal", BindRead_normal, BindWrite_normal);
            cls.AddProperty(false, "hover", BindRead_hover, BindWrite_hover);
            cls.AddProperty(false, "active", BindRead_active, BindWrite_active);
            cls.AddProperty(false, "onNormal", BindRead_onNormal, BindWrite_onNormal);
            cls.AddProperty(false, "onHover", BindRead_onHover, BindWrite_onHover);
            cls.AddProperty(false, "onActive", BindRead_onActive, BindWrite_onActive);
            cls.AddProperty(false, "focused", BindRead_focused, BindWrite_focused);
            cls.AddProperty(false, "onFocused", BindRead_onFocused, BindWrite_onFocused);
            cls.AddProperty(false, "border", BindRead_border, BindWrite_border);
            cls.AddProperty(false, "margin", BindRead_margin, BindWrite_margin);
            cls.AddProperty(false, "padding", BindRead_padding, BindWrite_padding);
            cls.AddProperty(false, "overflow", BindRead_overflow, BindWrite_overflow);
            cls.AddProperty(false, "lineHeight", BindRead_lineHeight, null);
            cls.AddProperty(true, "none", BindStaticRead_none, null);
            cls.AddProperty(false, "isHeightDependantOnWidth", BindRead_isHeightDependantOnWidth, null);
            return cls;
        }
    }
}
#endif
