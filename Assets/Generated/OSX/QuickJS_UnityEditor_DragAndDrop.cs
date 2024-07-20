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
    // Type: UnityEditor.DragAndDrop
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_DragAndDrop
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new UnityEditor.DragAndDrop();
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
        public static JSValue BindStatic_PrepareStartDrag(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.DragAndDrop.PrepareStartDrag();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("PrepareStartDrag", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_StartDrag(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.DragAndDrop), "StartDrag", typeof(string), 0);
                    }
                    UnityEditor.DragAndDrop.StartDrag(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("StartDrag", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetGenericData(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.DragAndDrop), "GetGenericData", typeof(string), 0);
                    }
                    var ret = UnityEditor.DragAndDrop.GetGenericData(arg0);
                    return QuickJS.Binding.Values.js_push_object(ctx, ret);
                }
                throw new NoSuitableMethodException("GetGenericData", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetGenericData(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.DragAndDrop), "SetGenericData", typeof(string), 0);
                    }
                    object arg1;
                    if (!Values.js_get_var(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.DragAndDrop), "SetGenericData", typeof(object), 1);
                    }
                    UnityEditor.DragAndDrop.SetGenericData(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetGenericData", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_AcceptDrag(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.DragAndDrop.AcceptDrag();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("AcceptDrag", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_HasHandler(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.DragAndDrop), "HasHandler", typeof(int), 0);
                    }
                    System.Delegate arg1;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.DragAndDrop), "HasHandler", typeof(System.Delegate), 1);
                    }
                    var ret = UnityEditor.DragAndDrop.HasHandler(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("HasHandler", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_AddDropHandler(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.DragAndDrop.ProjectBrowserDropHandler)))
                        {
                            UnityEditor.DragAndDrop.ProjectBrowserDropHandler arg0;
                            if (!Values.js_get_delegate(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.DragAndDrop), "AddDropHandler", typeof(UnityEditor.DragAndDrop.ProjectBrowserDropHandler), 0);
                            }
                            UnityEditor.DragAndDrop.AddDropHandler(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.DragAndDrop.SceneDropHandler)))
                        {
                            UnityEditor.DragAndDrop.SceneDropHandler arg0;
                            if (!Values.js_get_delegate(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.DragAndDrop), "AddDropHandler", typeof(UnityEditor.DragAndDrop.SceneDropHandler), 0);
                            }
                            UnityEditor.DragAndDrop.AddDropHandler(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.DragAndDrop.HierarchyDropHandler)))
                        {
                            UnityEditor.DragAndDrop.HierarchyDropHandler arg0;
                            if (!Values.js_get_delegate(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.DragAndDrop), "AddDropHandler", typeof(UnityEditor.DragAndDrop.HierarchyDropHandler), 0);
                            }
                            UnityEditor.DragAndDrop.AddDropHandler(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.DragAndDrop.InspectorDropHandler)))
                        {
                            UnityEditor.DragAndDrop.InspectorDropHandler arg0;
                            if (!Values.js_get_delegate(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.DragAndDrop), "AddDropHandler", typeof(UnityEditor.DragAndDrop.InspectorDropHandler), 0);
                            }
                            UnityEditor.DragAndDrop.AddDropHandler(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("AddDropHandler", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RemoveDropHandler(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.DragAndDrop.ProjectBrowserDropHandler)))
                        {
                            UnityEditor.DragAndDrop.ProjectBrowserDropHandler arg0;
                            if (!Values.js_get_delegate(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.DragAndDrop), "RemoveDropHandler", typeof(UnityEditor.DragAndDrop.ProjectBrowserDropHandler), 0);
                            }
                            UnityEditor.DragAndDrop.RemoveDropHandler(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.DragAndDrop.SceneDropHandler)))
                        {
                            UnityEditor.DragAndDrop.SceneDropHandler arg0;
                            if (!Values.js_get_delegate(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.DragAndDrop), "RemoveDropHandler", typeof(UnityEditor.DragAndDrop.SceneDropHandler), 0);
                            }
                            UnityEditor.DragAndDrop.RemoveDropHandler(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.DragAndDrop.HierarchyDropHandler)))
                        {
                            UnityEditor.DragAndDrop.HierarchyDropHandler arg0;
                            if (!Values.js_get_delegate(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.DragAndDrop), "RemoveDropHandler", typeof(UnityEditor.DragAndDrop.HierarchyDropHandler), 0);
                            }
                            UnityEditor.DragAndDrop.RemoveDropHandler(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.DragAndDrop.InspectorDropHandler)))
                        {
                            UnityEditor.DragAndDrop.InspectorDropHandler arg0;
                            if (!Values.js_get_delegate(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.DragAndDrop), "RemoveDropHandler", typeof(UnityEditor.DragAndDrop.InspectorDropHandler), 0);
                            }
                            UnityEditor.DragAndDrop.RemoveDropHandler(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("RemoveDropHandler", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_objectReferences(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.DragAndDrop.objectReferences;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_objectReferences(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Object[] value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.DragAndDrop), "objectReferences", typeof(UnityEngine.Object[]), 0);
                }
                UnityEditor.DragAndDrop.objectReferences = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_paths(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.DragAndDrop.paths;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_paths(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                string[] value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.DragAndDrop), "paths", typeof(string[]), 0);
                }
                UnityEditor.DragAndDrop.paths = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_activeControlID(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.DragAndDrop.activeControlID;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_activeControlID(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.DragAndDrop), "activeControlID", typeof(int), 0);
                }
                UnityEditor.DragAndDrop.activeControlID = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_visualMode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.DragAndDrop.visualMode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_visualMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.DragAndDropVisualMode value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.DragAndDrop), "visualMode", typeof(UnityEditor.DragAndDropVisualMode), 0);
                }
                UnityEditor.DragAndDrop.visualMode = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("DragAndDrop", typeof(UnityEditor.DragAndDrop), BindConstructor);
            cls.AddMethod(true, "PrepareStartDrag", BindStatic_PrepareStartDrag);
            cls.AddMethod(true, "StartDrag", BindStatic_StartDrag);
            cls.AddMethod(true, "GetGenericData", BindStatic_GetGenericData);
            cls.AddMethod(true, "SetGenericData", BindStatic_SetGenericData);
            cls.AddMethod(true, "AcceptDrag", BindStatic_AcceptDrag);
            cls.AddMethod(true, "HasHandler", BindStatic_HasHandler);
            cls.AddMethod(true, "AddDropHandler", BindStatic_AddDropHandler);
            cls.AddMethod(true, "RemoveDropHandler", BindStatic_RemoveDropHandler);
            cls.AddProperty(true, "objectReferences", BindStaticRead_objectReferences, BindStaticWrite_objectReferences);
            cls.AddProperty(true, "paths", BindStaticRead_paths, BindStaticWrite_paths);
            cls.AddProperty(true, "activeControlID", BindStaticRead_activeControlID, BindStaticWrite_activeControlID);
            cls.AddProperty(true, "visualMode", BindStaticRead_visualMode, BindStaticWrite_visualMode);
            return cls;
        }
    }
}
#endif
#endif
