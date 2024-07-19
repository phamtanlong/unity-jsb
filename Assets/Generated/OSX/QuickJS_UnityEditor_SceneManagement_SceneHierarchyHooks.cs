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
    // Type: UnityEditor.SceneManagement.SceneHierarchyHooks
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_SceneManagement_SceneHierarchyHooks
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ReloadAllSceneHierarchies(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.SceneManagement.SceneHierarchyHooks.ReloadAllSceneHierarchies();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ReloadAllSceneHierarchies", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CanSetNewParent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Transform arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SceneManagement.SceneHierarchyHooks), "CanSetNewParent", typeof(UnityEngine.Transform), 0);
                    }
                    UnityEngine.Transform arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.SceneManagement.SceneHierarchyHooks), "CanSetNewParent", typeof(UnityEngine.Transform), 1);
                    }
                    var ret = UnityEditor.SceneManagement.SceneHierarchyHooks.CanSetNewParent(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("CanSetNewParent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CanMoveTransformToScene(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Transform arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SceneManagement.SceneHierarchyHooks), "CanMoveTransformToScene", typeof(UnityEngine.Transform), 0);
                    }
                    UnityEngine.SceneManagement.Scene arg1;
                    if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.SceneManagement.SceneHierarchyHooks), "CanMoveTransformToScene", typeof(UnityEngine.SceneManagement.Scene), 1);
                    }
                    var ret = UnityEditor.SceneManagement.SceneHierarchyHooks.CanMoveTransformToScene(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("CanMoveTransformToScene", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_addItemsToGameObjectContextMenu(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                System.Action<UnityEditor.GenericMenu, UnityEngine.GameObject> value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.SceneHierarchyHooks), "addItemsToGameObjectContextMenu", typeof(System.Action<UnityEditor.GenericMenu, UnityEngine.GameObject>), 1);
                        }
                        UnityEditor.SceneManagement.SceneHierarchyHooks.addItemsToGameObjectContextMenu += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.SceneHierarchyHooks), "addItemsToGameObjectContextMenu", typeof(System.Action<UnityEditor.GenericMenu, UnityEngine.GameObject>), 1);
                        }
                        UnityEditor.SceneManagement.SceneHierarchyHooks.addItemsToGameObjectContextMenu -= value;
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
        public static JSValue BindStaticEvent_addItemsToSceneHeaderContextMenu(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                System.Action<UnityEditor.GenericMenu, UnityEngine.SceneManagement.Scene> value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.SceneHierarchyHooks), "addItemsToSceneHeaderContextMenu", typeof(System.Action<UnityEditor.GenericMenu, UnityEngine.SceneManagement.Scene>), 1);
                        }
                        UnityEditor.SceneManagement.SceneHierarchyHooks.addItemsToSceneHeaderContextMenu += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.SceneHierarchyHooks), "addItemsToSceneHeaderContextMenu", typeof(System.Action<UnityEditor.GenericMenu, UnityEngine.SceneManagement.Scene>), 1);
                        }
                        UnityEditor.SceneManagement.SceneHierarchyHooks.addItemsToSceneHeaderContextMenu -= value;
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
        public static JSValue BindStaticDelegate_provideSubScenes(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                    {
                        System.Func<UnityEditor.SceneManagement.SceneHierarchyHooks.SubSceneInfo[]> value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.SceneHierarchyHooks), "provideSubScenes", typeof(System.Func<UnityEditor.SceneManagement.SceneHierarchyHooks.SubSceneInfo[]>), 1);
                        }
                        UnityEditor.SceneManagement.SceneHierarchyHooks.provideSubScenes += value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_REMOVE:
                    {
                        System.Func<UnityEditor.SceneManagement.SceneHierarchyHooks.SubSceneInfo[]> value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.SceneHierarchyHooks), "provideSubScenes", typeof(System.Func<UnityEditor.SceneManagement.SceneHierarchyHooks.SubSceneInfo[]>), 1);
                        }
                        UnityEditor.SceneManagement.SceneHierarchyHooks.provideSubScenes -= value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_SET:
                    {
                        System.Func<UnityEditor.SceneManagement.SceneHierarchyHooks.SubSceneInfo[]> value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.SceneHierarchyHooks), "provideSubScenes", typeof(System.Func<UnityEditor.SceneManagement.SceneHierarchyHooks.SubSceneInfo[]>), 1);
                        }
                        UnityEditor.SceneManagement.SceneHierarchyHooks.provideSubScenes = value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_GET:
                    {
                        var ret = UnityEditor.SceneManagement.SceneHierarchyHooks.provideSubScenes;
                        return Values.js_push_delegate(ctx, ret);
                    }
                    default: throw new JSException("invalid event op");
                }
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticDelegate_provideSubSceneName(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                    {
                        System.Func<UnityEditor.SceneManagement.SceneHierarchyHooks.SubSceneInfo, string> value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.SceneHierarchyHooks), "provideSubSceneName", typeof(System.Func<UnityEditor.SceneManagement.SceneHierarchyHooks.SubSceneInfo, string>), 1);
                        }
                        UnityEditor.SceneManagement.SceneHierarchyHooks.provideSubSceneName += value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_REMOVE:
                    {
                        System.Func<UnityEditor.SceneManagement.SceneHierarchyHooks.SubSceneInfo, string> value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.SceneHierarchyHooks), "provideSubSceneName", typeof(System.Func<UnityEditor.SceneManagement.SceneHierarchyHooks.SubSceneInfo, string>), 1);
                        }
                        UnityEditor.SceneManagement.SceneHierarchyHooks.provideSubSceneName -= value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_SET:
                    {
                        System.Func<UnityEditor.SceneManagement.SceneHierarchyHooks.SubSceneInfo, string> value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.SceneHierarchyHooks), "provideSubSceneName", typeof(System.Func<UnityEditor.SceneManagement.SceneHierarchyHooks.SubSceneInfo, string>), 1);
                        }
                        UnityEditor.SceneManagement.SceneHierarchyHooks.provideSubSceneName = value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_GET:
                    {
                        var ret = UnityEditor.SceneManagement.SceneHierarchyHooks.provideSubSceneName;
                        return Values.js_push_delegate(ctx, ret);
                    }
                    default: throw new JSException("invalid event op");
                }
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("SceneHierarchyHooks", typeof(UnityEditor.SceneManagement.SceneHierarchyHooks), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "ReloadAllSceneHierarchies", BindStatic_ReloadAllSceneHierarchies);
            cls.AddMethod(true, "CanSetNewParent", BindStatic_CanSetNewParent);
            cls.AddMethod(true, "CanMoveTransformToScene", BindStatic_CanMoveTransformToScene);
            cls.AddMethod(true, "addItemsToGameObjectContextMenu", BindStaticEvent_addItemsToGameObjectContextMenu);
            cls.AddMethod(true, "addItemsToSceneHeaderContextMenu", BindStaticEvent_addItemsToSceneHeaderContextMenu);
            cls.AddMethod(true, "provideSubScenes", BindStaticDelegate_provideSubScenes);
            cls.AddMethod(true, "provideSubSceneName", BindStaticDelegate_provideSubSceneName);
            return cls;
        }
    }
}
#endif
#endif
