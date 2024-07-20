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
    // Type: UnityEditor.PreviewRenderUtility
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_PreviewRenderUtility
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        bool arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), ".ctor", typeof(bool), 0);
                        }
                        bool arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), ".ctor", typeof(bool), 1);
                        }
                        var o = new UnityEditor.PreviewRenderUtility(arg0, arg1);
                        var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                        return val;
                    }
                    if (argc == 1)
                    {
                        bool arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), ".ctor", typeof(bool), 0);
                        }
                        var o = new UnityEditor.PreviewRenderUtility(arg0);
                        var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                        return val;
                    }
                    if (argc == 0)
                    {
                        var o = new UnityEditor.PreviewRenderUtility();
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
        public static JSValue Bind_Cleanup(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.PreviewRenderUtility self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.Cleanup();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Cleanup", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_BeginPreview(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.PreviewRenderUtility self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "BeginPreview", typeof(UnityEngine.Rect), 0);
                    }
                    UnityEngine.GUIStyle arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "BeginPreview", typeof(UnityEngine.GUIStyle), 1);
                    }
                    self.BeginPreview(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("BeginPreview", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_BeginStaticPreview(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.PreviewRenderUtility self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "BeginStaticPreview", typeof(UnityEngine.Rect), 0);
                    }
                    self.BeginStaticPreview(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("BeginStaticPreview", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetScaleFactor(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.PreviewRenderUtility self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    float arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "GetScaleFactor", typeof(float), 0);
                    }
                    float arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "GetScaleFactor", typeof(float), 1);
                    }
                    var ret = self.GetScaleFactor(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetScaleFactor", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_EndPreview(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.PreviewRenderUtility self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.EndPreview();
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("EndPreview", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_EndAndDrawPreview(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.PreviewRenderUtility self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "EndAndDrawPreview", typeof(UnityEngine.Rect), 0);
                    }
                    self.EndAndDrawPreview(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("EndAndDrawPreview", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_EndStaticPreview(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.PreviewRenderUtility self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.EndStaticPreview();
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("EndStaticPreview", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_AddSingleGO(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.PreviewRenderUtility self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "AddSingleGO", typeof(UnityEngine.GameObject), 0);
                    }
                    self.AddSingleGO(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("AddSingleGO", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_InstantiatePrefabInScene(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.PreviewRenderUtility self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "InstantiatePrefabInScene", typeof(UnityEngine.GameObject), 0);
                    }
                    var ret = self.InstantiatePrefabInScene(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("InstantiatePrefabInScene", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawMesh(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 9)
                    {
                        UnityEditor.PreviewRenderUtility self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Mesh arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Mesh), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Vector3 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Vector3), 2);
                        }
                        UnityEngine.Quaternion arg3;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Quaternion), 3);
                        }
                        UnityEngine.Material arg4;
                        if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Material), 4);
                        }
                        int arg5;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(int), 5);
                        }
                        UnityEngine.MaterialPropertyBlock arg6;
                        if (!Values.js_get_classvalue(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.MaterialPropertyBlock), 6);
                        }
                        UnityEngine.Transform arg7;
                        if (!Values.js_get_classvalue(ctx, argv[7], out arg7))
                        {
                            throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Transform), 7);
                        }
                        bool arg8;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[8], out arg8))
                        {
                            throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(bool), 8);
                        }
                        self.DrawMesh(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 8)
                    {
                        UnityEditor.PreviewRenderUtility self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Mesh arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Mesh), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Quaternion arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Quaternion), 2);
                        }
                        UnityEngine.Material arg3;
                        if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Material), 3);
                        }
                        int arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(int), 4);
                        }
                        UnityEngine.MaterialPropertyBlock arg5;
                        if (!Values.js_get_classvalue(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.MaterialPropertyBlock), 5);
                        }
                        UnityEngine.Transform arg6;
                        if (!Values.js_get_classvalue(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Transform), 6);
                        }
                        bool arg7;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[7], out arg7))
                        {
                            throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(bool), 7);
                        }
                        self.DrawMesh(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 7)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Mesh)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Matrix4x4)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Material)) && Values.js_match_type(ctx, argv[3], typeof(int)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.MaterialPropertyBlock)) && Values.js_match_type(ctx, argv[5], typeof(UnityEngine.Transform)) && Values.js_match_type(ctx, argv[6], typeof(bool)))
                        {
                            UnityEditor.PreviewRenderUtility self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEngine.Mesh arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Mesh), 0);
                            }
                            UnityEngine.Matrix4x4 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Matrix4x4), 1);
                            }
                            UnityEngine.Material arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Material), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(int), 3);
                            }
                            UnityEngine.MaterialPropertyBlock arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.MaterialPropertyBlock), 4);
                            }
                            UnityEngine.Transform arg5;
                            if (!Values.js_get_classvalue(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Transform), 5);
                            }
                            bool arg6;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[6], out arg6))
                            {
                                throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(bool), 6);
                            }
                            self.DrawMesh(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Mesh)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Quaternion)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Material)) && Values.js_match_type(ctx, argv[4], typeof(int)) && Values.js_match_type(ctx, argv[5], typeof(UnityEngine.MaterialPropertyBlock)) && Values.js_match_type(ctx, argv[6], typeof(UnityEngine.Transform)))
                        {
                            UnityEditor.PreviewRenderUtility self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEngine.Mesh arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Mesh), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Vector3), 1);
                            }
                            UnityEngine.Quaternion arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Quaternion), 2);
                            }
                            UnityEngine.Material arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Material), 3);
                            }
                            int arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(int), 4);
                            }
                            UnityEngine.MaterialPropertyBlock arg5;
                            if (!Values.js_get_classvalue(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.MaterialPropertyBlock), 5);
                            }
                            UnityEngine.Transform arg6;
                            if (!Values.js_get_classvalue(ctx, argv[6], out arg6))
                            {
                                throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Transform), 6);
                            }
                            self.DrawMesh(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 6)
                    {
                        UnityEditor.PreviewRenderUtility self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Mesh arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Mesh), 0);
                        }
                        UnityEngine.Vector3 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Vector3), 1);
                        }
                        UnityEngine.Quaternion arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Quaternion), 2);
                        }
                        UnityEngine.Material arg3;
                        if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Material), 3);
                        }
                        int arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(int), 4);
                        }
                        UnityEngine.MaterialPropertyBlock arg5;
                        if (!Values.js_get_classvalue(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.MaterialPropertyBlock), 5);
                        }
                        self.DrawMesh(arg0, arg1, arg2, arg3, arg4, arg5);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Mesh)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Matrix4x4)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Material)) && Values.js_match_type(ctx, argv[3], typeof(int)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.MaterialPropertyBlock)))
                        {
                            UnityEditor.PreviewRenderUtility self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEngine.Mesh arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Mesh), 0);
                            }
                            UnityEngine.Matrix4x4 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Matrix4x4), 1);
                            }
                            UnityEngine.Material arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Material), 2);
                            }
                            int arg3;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(int), 3);
                            }
                            UnityEngine.MaterialPropertyBlock arg4;
                            if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.MaterialPropertyBlock), 4);
                            }
                            self.DrawMesh(arg0, arg1, arg2, arg3, arg4);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Mesh)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Vector3)) && Values.js_match_type(ctx, argv[2], typeof(UnityEngine.Quaternion)) && Values.js_match_type(ctx, argv[3], typeof(UnityEngine.Material)) && Values.js_match_type(ctx, argv[4], typeof(int)))
                        {
                            UnityEditor.PreviewRenderUtility self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEngine.Mesh arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Mesh), 0);
                            }
                            UnityEngine.Vector3 arg1;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Vector3), 1);
                            }
                            UnityEngine.Quaternion arg2;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Quaternion), 2);
                            }
                            UnityEngine.Material arg3;
                            if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Material), 3);
                            }
                            int arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(int), 4);
                            }
                            self.DrawMesh(arg0, arg1, arg2, arg3, arg4);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 4)
                    {
                        UnityEditor.PreviewRenderUtility self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Mesh arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Mesh), 0);
                        }
                        UnityEngine.Matrix4x4 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Matrix4x4), 1);
                        }
                        UnityEngine.Material arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(UnityEngine.Material), 2);
                        }
                        int arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "DrawMesh", typeof(int), 3);
                        }
                        self.DrawMesh(arg0, arg1, arg2, arg3);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("DrawMesh", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Render(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.PreviewRenderUtility self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    bool arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "Render", typeof(bool), 0);
                    }
                    bool arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "Render", typeof(bool), 1);
                    }
                    self.Render(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Render", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_camera(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.PreviewRenderUtility self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.camera;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_cameraFieldOfView(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.PreviewRenderUtility self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.cameraFieldOfView;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_cameraFieldOfView(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.PreviewRenderUtility self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "cameraFieldOfView", typeof(float), 0);
                }
                self.cameraFieldOfView = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_ambientColor(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.PreviewRenderUtility self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.ambientColor;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_ambientColor(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.PreviewRenderUtility self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Color value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PreviewRenderUtility), "ambientColor", typeof(UnityEngine.Color), 0);
                }
                self.ambientColor = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_lights(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.PreviewRenderUtility self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.lights;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("PreviewRenderUtility", typeof(UnityEditor.PreviewRenderUtility), BindConstructor);
            cls.AddMethod(false, "Cleanup", Bind_Cleanup);
            cls.AddMethod(false, "BeginPreview", Bind_BeginPreview);
            cls.AddMethod(false, "BeginStaticPreview", Bind_BeginStaticPreview);
            cls.AddMethod(false, "GetScaleFactor", Bind_GetScaleFactor);
            cls.AddMethod(false, "EndPreview", Bind_EndPreview);
            cls.AddMethod(false, "EndAndDrawPreview", Bind_EndAndDrawPreview);
            cls.AddMethod(false, "EndStaticPreview", Bind_EndStaticPreview);
            cls.AddMethod(false, "AddSingleGO", Bind_AddSingleGO);
            cls.AddMethod(false, "InstantiatePrefabInScene", Bind_InstantiatePrefabInScene);
            cls.AddMethod(false, "DrawMesh", Bind_DrawMesh);
            cls.AddMethod(false, "Render", Bind_Render);
            cls.AddProperty(false, "camera", BindRead_camera, null);
            cls.AddProperty(false, "cameraFieldOfView", BindRead_cameraFieldOfView, BindWrite_cameraFieldOfView);
            cls.AddProperty(false, "ambientColor", BindRead_ambientColor, BindWrite_ambientColor);
            cls.AddProperty(false, "lights", BindRead_lights, null);
            return cls;
        }
    }
}
#endif
#endif
