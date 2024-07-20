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
    // Type: UnityEditor.SceneManagement.PrefabStage
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_SceneManagement_PrefabStage
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetCombinedSceneCullingMaskForCamera(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.SceneManagement.PrefabStage self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.GetCombinedSceneCullingMaskForCamera();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetCombinedSceneCullingMaskForCamera", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_IsPartOfPrefabContents(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.SceneManagement.PrefabStage self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SceneManagement.PrefabStage), "IsPartOfPrefabContents", typeof(UnityEngine.GameObject), 0);
                    }
                    var ret = self.IsPartOfPrefabContents(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsPartOfPrefabContents", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ClearDirtiness(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.SceneManagement.PrefabStage self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.ClearDirtiness();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ClearDirtiness", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_prefabContentsRoot(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.SceneManagement.PrefabStage self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.prefabContentsRoot;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_openedFromInstanceRoot(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.SceneManagement.PrefabStage self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.openedFromInstanceRoot;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_openedFromInstanceObject(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.SceneManagement.PrefabStage self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.openedFromInstanceObject;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_mode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.SceneManagement.PrefabStage self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.mode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_assetPath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.SceneManagement.PrefabStage self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.assetPath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_prefabStageOpened(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                System.Action<UnityEditor.SceneManagement.PrefabStage> value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.PrefabStage), "prefabStageOpened", typeof(System.Action<UnityEditor.SceneManagement.PrefabStage>), 1);
                        }
                        UnityEditor.SceneManagement.PrefabStage.prefabStageOpened += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.PrefabStage), "prefabStageOpened", typeof(System.Action<UnityEditor.SceneManagement.PrefabStage>), 1);
                        }
                        UnityEditor.SceneManagement.PrefabStage.prefabStageOpened -= value;
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
        public static JSValue BindStaticEvent_prefabStageClosing(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                System.Action<UnityEditor.SceneManagement.PrefabStage> value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.PrefabStage), "prefabStageClosing", typeof(System.Action<UnityEditor.SceneManagement.PrefabStage>), 1);
                        }
                        UnityEditor.SceneManagement.PrefabStage.prefabStageClosing += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.PrefabStage), "prefabStageClosing", typeof(System.Action<UnityEditor.SceneManagement.PrefabStage>), 1);
                        }
                        UnityEditor.SceneManagement.PrefabStage.prefabStageClosing -= value;
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
        public static JSValue BindStaticEvent_prefabStageDirtied(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                System.Action<UnityEditor.SceneManagement.PrefabStage> value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.PrefabStage), "prefabStageDirtied", typeof(System.Action<UnityEditor.SceneManagement.PrefabStage>), 1);
                        }
                        UnityEditor.SceneManagement.PrefabStage.prefabStageDirtied += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.PrefabStage), "prefabStageDirtied", typeof(System.Action<UnityEditor.SceneManagement.PrefabStage>), 1);
                        }
                        UnityEditor.SceneManagement.PrefabStage.prefabStageDirtied -= value;
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
        public static JSValue BindStaticEvent_prefabSaving(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                System.Action<UnityEngine.GameObject> value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.PrefabStage), "prefabSaving", typeof(System.Action<UnityEngine.GameObject>), 1);
                        }
                        UnityEditor.SceneManagement.PrefabStage.prefabSaving += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.PrefabStage), "prefabSaving", typeof(System.Action<UnityEngine.GameObject>), 1);
                        }
                        UnityEditor.SceneManagement.PrefabStage.prefabSaving -= value;
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
        public static JSValue BindStaticEvent_prefabSaved(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                System.Action<UnityEngine.GameObject> value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.PrefabStage), "prefabSaved", typeof(System.Action<UnityEngine.GameObject>), 1);
                        }
                        UnityEditor.SceneManagement.PrefabStage.prefabSaved += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.PrefabStage), "prefabSaved", typeof(System.Action<UnityEngine.GameObject>), 1);
                        }
                        UnityEditor.SceneManagement.PrefabStage.prefabSaved -= value;
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
            var cls = register.CreateClass("PrefabStage", typeof(UnityEditor.SceneManagement.PrefabStage), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(false, "GetCombinedSceneCullingMaskForCamera", Bind_GetCombinedSceneCullingMaskForCamera);
            cls.AddMethod(false, "IsPartOfPrefabContents", Bind_IsPartOfPrefabContents);
            cls.AddMethod(false, "ClearDirtiness", Bind_ClearDirtiness);
            cls.AddProperty(false, "prefabContentsRoot", BindRead_prefabContentsRoot, null);
            cls.AddProperty(false, "openedFromInstanceRoot", BindRead_openedFromInstanceRoot, null);
            cls.AddProperty(false, "openedFromInstanceObject", BindRead_openedFromInstanceObject, null);
            cls.AddProperty(false, "mode", BindRead_mode, null);
            cls.AddProperty(false, "assetPath", BindRead_assetPath, null);
            cls.AddMethod(true, "prefabStageOpened", BindStaticEvent_prefabStageOpened);
            cls.AddMethod(true, "prefabStageClosing", BindStaticEvent_prefabStageClosing);
            cls.AddMethod(true, "prefabStageDirtied", BindStaticEvent_prefabStageDirtied);
            cls.AddMethod(true, "prefabSaving", BindStaticEvent_prefabSaving);
            cls.AddMethod(true, "prefabSaved", BindStaticEvent_prefabSaved);
            return cls;
        }
    }
}
#endif
#endif
