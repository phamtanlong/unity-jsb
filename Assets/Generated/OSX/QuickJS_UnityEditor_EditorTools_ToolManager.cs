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
    // Type: UnityEditor.EditorTools.ToolManager
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_EditorTools_ToolManager
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetActiveContext(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    System.Type arg0;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorTools.ToolManager), "SetActiveContext", typeof(System.Type), 0);
                    }
                    UnityEditor.EditorTools.ToolManager.SetActiveContext(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetActiveContext", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetActiveTool(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(System.Type)))
                        {
                            System.Type arg0;
                            if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorTools.ToolManager), "SetActiveTool", typeof(System.Type), 0);
                            }
                            UnityEditor.EditorTools.ToolManager.SetActiveTool(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.EditorTools.EditorTool)))
                        {
                            UnityEditor.EditorTools.EditorTool arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorTools.ToolManager), "SetActiveTool", typeof(UnityEditor.EditorTools.EditorTool), 0);
                            }
                            UnityEditor.EditorTools.ToolManager.SetActiveTool(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("SetActiveTool", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RestorePreviousTool(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorTools.ToolManager.RestorePreviousTool();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RestorePreviousTool", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RestorePreviousPersistentTool(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorTools.ToolManager.RestorePreviousPersistentTool();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RestorePreviousPersistentTool", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsActiveTool(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.EditorTools.EditorTool arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorTools.ToolManager), "IsActiveTool", typeof(UnityEditor.EditorTools.EditorTool), 0);
                    }
                    var ret = UnityEditor.EditorTools.ToolManager.IsActiveTool(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsActiveTool", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsActiveContext(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.EditorTools.EditorToolContext arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorTools.ToolManager), "IsActiveContext", typeof(UnityEditor.EditorTools.EditorToolContext), 0);
                    }
                    var ret = UnityEditor.EditorTools.ToolManager.IsActiveContext(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsActiveContext", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_activeContextType(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorTools.ToolManager.activeContextType;
                return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_activeToolType(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorTools.ToolManager.activeToolType;
                return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_activeToolChanging(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                System.Action value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorTools.ToolManager), "activeToolChanging", typeof(System.Action), 1);
                        }
                        UnityEditor.EditorTools.ToolManager.activeToolChanging += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorTools.ToolManager), "activeToolChanging", typeof(System.Action), 1);
                        }
                        UnityEditor.EditorTools.ToolManager.activeToolChanging -= value;
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
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_activeToolChanged(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                System.Action value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorTools.ToolManager), "activeToolChanged", typeof(System.Action), 1);
                        }
                        UnityEditor.EditorTools.ToolManager.activeToolChanged += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorTools.ToolManager), "activeToolChanged", typeof(System.Action), 1);
                        }
                        UnityEditor.EditorTools.ToolManager.activeToolChanged -= value;
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
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_activeContextChanging(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                System.Action value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorTools.ToolManager), "activeContextChanging", typeof(System.Action), 1);
                        }
                        UnityEditor.EditorTools.ToolManager.activeContextChanging += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorTools.ToolManager), "activeContextChanging", typeof(System.Action), 1);
                        }
                        UnityEditor.EditorTools.ToolManager.activeContextChanging -= value;
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
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_activeContextChanged(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                System.Action value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorTools.ToolManager), "activeContextChanged", typeof(System.Action), 1);
                        }
                        UnityEditor.EditorTools.ToolManager.activeContextChanged += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorTools.ToolManager), "activeContextChanged", typeof(System.Action), 1);
                        }
                        UnityEditor.EditorTools.ToolManager.activeContextChanged -= value;
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
            var cls = register.CreateClass("ToolManager", typeof(UnityEditor.EditorTools.ToolManager), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "SetActiveContext", BindStatic_SetActiveContext);
            cls.AddMethod(true, "SetActiveTool", BindStatic_SetActiveTool);
            cls.AddMethod(true, "RestorePreviousTool", BindStatic_RestorePreviousTool);
            cls.AddMethod(true, "RestorePreviousPersistentTool", BindStatic_RestorePreviousPersistentTool);
            cls.AddMethod(true, "IsActiveTool", BindStatic_IsActiveTool);
            cls.AddMethod(true, "IsActiveContext", BindStatic_IsActiveContext);
            cls.AddProperty(true, "activeContextType", BindStaticRead_activeContextType, null);
            cls.AddProperty(true, "activeToolType", BindStaticRead_activeToolType, null);
            cls.AddMethod(true, "activeToolChanging", BindStaticEvent_activeToolChanging);
            cls.AddMethod(true, "activeToolChanged", BindStaticEvent_activeToolChanged);
            cls.AddMethod(true, "activeContextChanging", BindStaticEvent_activeContextChanging);
            cls.AddMethod(true, "activeContextChanged", BindStaticEvent_activeContextChanged);
            return cls;
        }
    }
}
#endif
#endif