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
    // Type: UnityEditor.Editor
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_Editor
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawDefaultInspector(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.Editor self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.DrawDefaultInspector();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("DrawDefaultInspector", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Repaint(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.Editor self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.Repaint();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Repaint", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_OnInspectorGUI(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.Editor self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.OnInspectorGUI();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("OnInspectorGUI", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_CreateInspectorGUI(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.Editor self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.CreateInspectorGUI();
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("CreateInspectorGUI", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_RequiresConstantRepaint(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.Editor self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.RequiresConstantRepaint();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("RequiresConstantRepaint", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawHeader(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.Editor self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.DrawHeader();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawHeader", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_HasPreviewGUI(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.Editor self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.HasPreviewGUI();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("HasPreviewGUI", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetPreviewTitle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.Editor self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.GetPreviewTitle();
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetPreviewTitle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_RenderStaticPreview(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 4)
                {
                    UnityEditor.Editor self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Editor), "RenderStaticPreview", typeof(string), 0);
                    }
                    UnityEngine.Object[] arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Editor), "RenderStaticPreview", typeof(UnityEngine.Object[]), 1);
                    }
                    int arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Editor), "RenderStaticPreview", typeof(int), 2);
                    }
                    int arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.Editor), "RenderStaticPreview", typeof(int), 3);
                    }
                    var ret = self.RenderStaticPreview(arg0, arg1, arg2, arg3);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("RenderStaticPreview", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_OnPreviewGUI(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.Editor self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Editor), "OnPreviewGUI", typeof(UnityEngine.Rect), 0);
                    }
                    UnityEngine.GUIStyle arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Editor), "OnPreviewGUI", typeof(UnityEngine.GUIStyle), 1);
                    }
                    self.OnPreviewGUI(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("OnPreviewGUI", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_OnInteractivePreviewGUI(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.Editor self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Editor), "OnInteractivePreviewGUI", typeof(UnityEngine.Rect), 0);
                    }
                    UnityEngine.GUIStyle arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Editor), "OnInteractivePreviewGUI", typeof(UnityEngine.GUIStyle), 1);
                    }
                    self.OnInteractivePreviewGUI(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("OnInteractivePreviewGUI", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_OnPreviewSettings(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.Editor self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.OnPreviewSettings();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("OnPreviewSettings", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetInfoString(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.Editor self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.GetInfoString();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetInfoString", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_DrawPreview(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.Editor self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Editor), "DrawPreview", typeof(UnityEngine.Rect), 0);
                    }
                    self.DrawPreview(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawPreview", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ReloadPreviewInstances(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.Editor self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.ReloadPreviewInstances();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ReloadPreviewInstances", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_UseDefaultMargins(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.Editor self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.UseDefaultMargins();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("UseDefaultMargins", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Initialize(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.Editor self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Object[] arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Editor), "Initialize", typeof(UnityEngine.Object[]), 0);
                    }
                    self.Initialize(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Initialize", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_MoveNextTarget(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.Editor self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.MoveNextTarget();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("MoveNextTarget", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ResetTarget(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.Editor self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.ResetTarget();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ResetTarget", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CreateEditorWithContext(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        UnityEngine.Object[] arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Editor), "CreateEditorWithContext", typeof(UnityEngine.Object[]), 0);
                        }
                        UnityEngine.Object arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.Editor), "CreateEditorWithContext", typeof(UnityEngine.Object), 1);
                        }
                        System.Type arg2;
                        if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.Editor), "CreateEditorWithContext", typeof(System.Type), 2);
                        }
                        var ret = UnityEditor.Editor.CreateEditorWithContext(arg0, arg1, arg2);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        UnityEngine.Object[] arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Editor), "CreateEditorWithContext", typeof(UnityEngine.Object[]), 0);
                        }
                        UnityEngine.Object arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.Editor), "CreateEditorWithContext", typeof(UnityEngine.Object), 1);
                        }
                        var ret = UnityEditor.Editor.CreateEditorWithContext(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("CreateEditorWithContext", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CreateCachedEditorWithContext(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[2], typeof(System.Type)) && Values.js_match_type_hint(ctx, argv[3], typeof(UnityEditor.Editor)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Editor), "CreateCachedEditorWithContext", typeof(UnityEngine.Object), 0);
                            }
                            UnityEngine.Object arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Editor), "CreateCachedEditorWithContext", typeof(UnityEngine.Object), 1);
                            }
                            System.Type arg2;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.Editor), "CreateCachedEditorWithContext", typeof(System.Type), 2);
                            }
                            UnityEditor.Editor arg3;
                            var refVal3 = Values.js_read_wrap(ctx, argv[3]);
                            if (refVal3.IsException())
                            {
                                return refVal3;
                            }
                            if (!Values.js_get_classvalue(ctx, refVal3, out arg3))
                            {
                                JSApi.JS_FreeValue(ctx, refVal3);
                                throw new ParameterException(typeof(UnityEditor.Editor), "CreateCachedEditorWithContext", typeof(UnityEditor.Editor), 3);
                            }
                            JSApi.JS_FreeValue(ctx, refVal3);
                            UnityEditor.Editor.CreateCachedEditorWithContext(arg0, arg1, arg2, ref arg3);
                            var out0 = Values.js_push_classvalue(ctx, arg3);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[3], context.GetAtom("value"), out0);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object[])) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[2], typeof(System.Type)) && Values.js_match_type_hint(ctx, argv[3], typeof(UnityEditor.Editor)))
                        {
                            UnityEngine.Object[] arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Editor), "CreateCachedEditorWithContext", typeof(UnityEngine.Object[]), 0);
                            }
                            UnityEngine.Object arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Editor), "CreateCachedEditorWithContext", typeof(UnityEngine.Object), 1);
                            }
                            System.Type arg2;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.Editor), "CreateCachedEditorWithContext", typeof(System.Type), 2);
                            }
                            UnityEditor.Editor arg3;
                            var refVal3 = Values.js_read_wrap(ctx, argv[3]);
                            if (refVal3.IsException())
                            {
                                return refVal3;
                            }
                            if (!Values.js_get_classvalue(ctx, refVal3, out arg3))
                            {
                                JSApi.JS_FreeValue(ctx, refVal3);
                                throw new ParameterException(typeof(UnityEditor.Editor), "CreateCachedEditorWithContext", typeof(UnityEditor.Editor), 3);
                            }
                            JSApi.JS_FreeValue(ctx, refVal3);
                            UnityEditor.Editor.CreateCachedEditorWithContext(arg0, arg1, arg2, ref arg3);
                            var out0 = Values.js_push_classvalue(ctx, arg3);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[3], context.GetAtom("value"), out0);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("CreateCachedEditorWithContext", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CreateCachedEditor(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[1], typeof(System.Type)) && Values.js_match_type_hint(ctx, argv[2], typeof(UnityEditor.Editor)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Editor), "CreateCachedEditor", typeof(UnityEngine.Object), 0);
                            }
                            System.Type arg1;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Editor), "CreateCachedEditor", typeof(System.Type), 1);
                            }
                            UnityEditor.Editor arg2;
                            var refVal2 = Values.js_read_wrap(ctx, argv[2]);
                            if (refVal2.IsException())
                            {
                                return refVal2;
                            }
                            if (!Values.js_get_classvalue(ctx, refVal2, out arg2))
                            {
                                JSApi.JS_FreeValue(ctx, refVal2);
                                throw new ParameterException(typeof(UnityEditor.Editor), "CreateCachedEditor", typeof(UnityEditor.Editor), 2);
                            }
                            JSApi.JS_FreeValue(ctx, refVal2);
                            UnityEditor.Editor.CreateCachedEditor(arg0, arg1, ref arg2);
                            var out0 = Values.js_push_classvalue(ctx, arg2);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out0);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object[])) && Values.js_match_type(ctx, argv[1], typeof(System.Type)) && Values.js_match_type_hint(ctx, argv[2], typeof(UnityEditor.Editor)))
                        {
                            UnityEngine.Object[] arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Editor), "CreateCachedEditor", typeof(UnityEngine.Object[]), 0);
                            }
                            System.Type arg1;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Editor), "CreateCachedEditor", typeof(System.Type), 1);
                            }
                            UnityEditor.Editor arg2;
                            var refVal2 = Values.js_read_wrap(ctx, argv[2]);
                            if (refVal2.IsException())
                            {
                                return refVal2;
                            }
                            if (!Values.js_get_classvalue(ctx, refVal2, out arg2))
                            {
                                JSApi.JS_FreeValue(ctx, refVal2);
                                throw new ParameterException(typeof(UnityEditor.Editor), "CreateCachedEditor", typeof(UnityEditor.Editor), 2);
                            }
                            JSApi.JS_FreeValue(ctx, refVal2);
                            UnityEditor.Editor.CreateCachedEditor(arg0, arg1, ref arg2);
                            var out0 = Values.js_push_classvalue(ctx, arg2);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out0);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("CreateCachedEditor", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CreateEditor(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[1], typeof(System.Type)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Editor), "CreateEditor", typeof(UnityEngine.Object), 0);
                            }
                            System.Type arg1;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Editor), "CreateEditor", typeof(System.Type), 1);
                            }
                            var ret = UnityEditor.Editor.CreateEditor(arg0, arg1);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object[])) && Values.js_match_type(ctx, argv[1], typeof(System.Type)))
                        {
                            UnityEngine.Object[] arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Editor), "CreateEditor", typeof(UnityEngine.Object[]), 0);
                            }
                            System.Type arg1;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.Editor), "CreateEditor", typeof(System.Type), 1);
                            }
                            var ret = UnityEditor.Editor.CreateEditor(arg0, arg1);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Editor), "CreateEditor", typeof(UnityEngine.Object), 0);
                            }
                            var ret = UnityEditor.Editor.CreateEditor(arg0);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object[])))
                        {
                            UnityEngine.Object[] arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Editor), "CreateEditor", typeof(UnityEngine.Object[]), 0);
                            }
                            var ret = UnityEditor.Editor.CreateEditor(arg0);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("CreateEditor", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DrawFoldoutInspector(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Editor), "DrawFoldoutInspector", typeof(UnityEngine.Object), 0);
                    }
                    UnityEditor.Editor arg1;
                    var refVal1 = Values.js_read_wrap(ctx, argv[1]);
                    if (refVal1.IsException())
                    {
                        return refVal1;
                    }
                    if (!Values.js_get_classvalue(ctx, refVal1, out arg1))
                    {
                        JSApi.JS_FreeValue(ctx, refVal1);
                        throw new ParameterException(typeof(UnityEditor.Editor), "DrawFoldoutInspector", typeof(UnityEditor.Editor), 1);
                    }
                    JSApi.JS_FreeValue(ctx, refVal1);
                    UnityEditor.Editor.DrawFoldoutInspector(arg0, ref arg1);
                    var out0 = Values.js_push_classvalue(ctx, arg1);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DrawFoldoutInspector", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_target(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.Editor self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.target;
                return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_target(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.Editor self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Object value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.Editor), "target", typeof(UnityEngine.Object), 0);
                }
                self.target = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_targets(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.Editor self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.targets;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_serializedObject(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.Editor self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.serializedObject;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_finishedDefaultHeaderGUI(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                System.Action<UnityEditor.Editor> value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.Editor), "finishedDefaultHeaderGUI", typeof(System.Action<UnityEditor.Editor>), 1);
                        }
                        UnityEditor.Editor.finishedDefaultHeaderGUI += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.Editor), "finishedDefaultHeaderGUI", typeof(System.Action<UnityEditor.Editor>), 1);
                        }
                        UnityEditor.Editor.finishedDefaultHeaderGUI -= value;
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
            var cls = register.CreateClass("Editor", typeof(UnityEditor.Editor), QuickJS.Binding.CommonFix.CrossBindConstructor);
            cls.AddMethod(false, "DrawDefaultInspector", Bind_DrawDefaultInspector);
            cls.AddMethod(false, "Repaint", Bind_Repaint);
            cls.AddMethod(false, "OnInspectorGUI", Bind_OnInspectorGUI);
            cls.AddMethod(false, "CreateInspectorGUI", Bind_CreateInspectorGUI);
            cls.AddMethod(false, "RequiresConstantRepaint", Bind_RequiresConstantRepaint);
            cls.AddMethod(false, "DrawHeader", Bind_DrawHeader);
            cls.AddMethod(false, "HasPreviewGUI", Bind_HasPreviewGUI);
            cls.AddMethod(false, "GetPreviewTitle", Bind_GetPreviewTitle);
            cls.AddMethod(false, "RenderStaticPreview", Bind_RenderStaticPreview);
            cls.AddMethod(false, "OnPreviewGUI", Bind_OnPreviewGUI);
            cls.AddMethod(false, "OnInteractivePreviewGUI", Bind_OnInteractivePreviewGUI);
            cls.AddMethod(false, "OnPreviewSettings", Bind_OnPreviewSettings);
            cls.AddMethod(false, "GetInfoString", Bind_GetInfoString);
            cls.AddMethod(false, "DrawPreview", Bind_DrawPreview);
            cls.AddMethod(false, "ReloadPreviewInstances", Bind_ReloadPreviewInstances);
            cls.AddMethod(false, "UseDefaultMargins", Bind_UseDefaultMargins);
            cls.AddMethod(false, "Initialize", Bind_Initialize);
            cls.AddMethod(false, "MoveNextTarget", Bind_MoveNextTarget);
            cls.AddMethod(false, "ResetTarget", Bind_ResetTarget);
            cls.AddMethod(true, "CreateEditorWithContext", BindStatic_CreateEditorWithContext);
            cls.AddMethod(true, "CreateCachedEditorWithContext", BindStatic_CreateCachedEditorWithContext);
            cls.AddMethod(true, "CreateCachedEditor", BindStatic_CreateCachedEditor);
            cls.AddMethod(true, "CreateEditor", BindStatic_CreateEditor);
            cls.AddMethod(true, "DrawFoldoutInspector", BindStatic_DrawFoldoutInspector);
            cls.AddProperty(false, "target", BindRead_target, BindWrite_target);
            cls.AddProperty(false, "targets", BindRead_targets, null);
            cls.AddProperty(false, "serializedObject", BindRead_serializedObject, null);
            cls.AddMethod(true, "finishedDefaultHeaderGUI", BindStaticEvent_finishedDefaultHeaderGUI);
            return cls;
        }
    }
}
#endif
#endif
