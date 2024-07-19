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
    // Type: UnityEditor.SceneManagement.EditorSceneManager
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_SceneManagement_EditorSceneManager
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new UnityEditor.SceneManagement.EditorSceneManager();
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
        public static JSValue BindStatic_OpenScene(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "OpenScene", typeof(string), 0);
                        }
                        UnityEditor.SceneManagement.OpenSceneMode arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "OpenScene", typeof(UnityEditor.SceneManagement.OpenSceneMode), 1);
                        }
                        var ret = UnityEditor.SceneManagement.EditorSceneManager.OpenScene(arg0, arg1);
                        return Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "OpenScene", typeof(string), 0);
                        }
                        var ret = UnityEditor.SceneManagement.EditorSceneManager.OpenScene(arg0);
                        return Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("OpenScene", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_NewScene(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEditor.SceneManagement.NewSceneSetup arg0;
                        if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "NewScene", typeof(UnityEditor.SceneManagement.NewSceneSetup), 0);
                        }
                        UnityEditor.SceneManagement.NewSceneMode arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "NewScene", typeof(UnityEditor.SceneManagement.NewSceneMode), 1);
                        }
                        var ret = UnityEditor.SceneManagement.EditorSceneManager.NewScene(arg0, arg1);
                        return Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        UnityEditor.SceneManagement.NewSceneSetup arg0;
                        if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "NewScene", typeof(UnityEditor.SceneManagement.NewSceneSetup), 0);
                        }
                        var ret = UnityEditor.SceneManagement.EditorSceneManager.NewScene(arg0);
                        return Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("NewScene", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_NewPreviewScene(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.SceneManagement.EditorSceneManager.NewPreviewScene();
                    return Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("NewPreviewScene", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CloseScene(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.SceneManagement.Scene arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "CloseScene", typeof(UnityEngine.SceneManagement.Scene), 0);
                    }
                    bool arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "CloseScene", typeof(bool), 1);
                    }
                    var ret = UnityEditor.SceneManagement.EditorSceneManager.CloseScene(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("CloseScene", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ClosePreviewScene(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.SceneManagement.Scene arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "ClosePreviewScene", typeof(UnityEngine.SceneManagement.Scene), 0);
                    }
                    var ret = UnityEditor.SceneManagement.EditorSceneManager.ClosePreviewScene(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ClosePreviewScene", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsPreviewScene(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.SceneManagement.Scene arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "IsPreviewScene", typeof(UnityEngine.SceneManagement.Scene), 0);
                    }
                    var ret = UnityEditor.SceneManagement.EditorSceneManager.IsPreviewScene(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsPreviewScene", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsPreviewSceneObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "IsPreviewSceneObject", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.SceneManagement.EditorSceneManager.IsPreviewSceneObject(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsPreviewSceneObject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_MoveSceneBefore(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.SceneManagement.Scene arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "MoveSceneBefore", typeof(UnityEngine.SceneManagement.Scene), 0);
                    }
                    UnityEngine.SceneManagement.Scene arg1;
                    if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "MoveSceneBefore", typeof(UnityEngine.SceneManagement.Scene), 1);
                    }
                    UnityEditor.SceneManagement.EditorSceneManager.MoveSceneBefore(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("MoveSceneBefore", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_MoveSceneAfter(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.SceneManagement.Scene arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "MoveSceneAfter", typeof(UnityEngine.SceneManagement.Scene), 0);
                    }
                    UnityEngine.SceneManagement.Scene arg1;
                    if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "MoveSceneAfter", typeof(UnityEngine.SceneManagement.Scene), 1);
                    }
                    UnityEditor.SceneManagement.EditorSceneManager.MoveSceneAfter(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("MoveSceneAfter", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SaveOpenScenes(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.SceneManagement.EditorSceneManager.SaveOpenScenes();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("SaveOpenScenes", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SaveScenes(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.SceneManagement.Scene[] arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "SaveScenes", typeof(UnityEngine.SceneManagement.Scene[]), 0);
                    }
                    var ret = UnityEditor.SceneManagement.EditorSceneManager.SaveScenes(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("SaveScenes", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SaveCurrentModifiedScenesIfUserWantsTo(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.SceneManagement.EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("SaveCurrentModifiedScenesIfUserWantsTo", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SaveModifiedScenesIfUserWantsTo(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.SceneManagement.Scene[] arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "SaveModifiedScenesIfUserWantsTo", typeof(UnityEngine.SceneManagement.Scene[]), 0);
                    }
                    var ret = UnityEditor.SceneManagement.EditorSceneManager.SaveModifiedScenesIfUserWantsTo(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("SaveModifiedScenesIfUserWantsTo", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_EnsureUntitledSceneHasBeenSaved(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "EnsureUntitledSceneHasBeenSaved", typeof(string), 0);
                    }
                    var ret = UnityEditor.SceneManagement.EditorSceneManager.EnsureUntitledSceneHasBeenSaved(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("EnsureUntitledSceneHasBeenSaved", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_MarkSceneDirty(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.SceneManagement.Scene arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "MarkSceneDirty", typeof(UnityEngine.SceneManagement.Scene), 0);
                    }
                    var ret = UnityEditor.SceneManagement.EditorSceneManager.MarkSceneDirty(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("MarkSceneDirty", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_MarkAllScenesDirty(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.SceneManagement.EditorSceneManager.MarkAllScenesDirty();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("MarkAllScenesDirty", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetSceneManagerSetup(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.SceneManagement.EditorSceneManager.GetSceneManagerSetup();
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetSceneManagerSetup", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RestoreSceneManagerSetup(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.SceneManagement.SceneSetup[] arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "RestoreSceneManagerSetup", typeof(UnityEditor.SceneManagement.SceneSetup[]), 0);
                    }
                    UnityEditor.SceneManagement.EditorSceneManager.RestoreSceneManagerSetup(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RestoreSceneManagerSetup", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DetectCrossSceneReferences(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.SceneManagement.Scene arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "DetectCrossSceneReferences", typeof(UnityEngine.SceneManagement.Scene), 0);
                    }
                    var ret = UnityEditor.SceneManagement.EditorSceneManager.DetectCrossSceneReferences(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("DetectCrossSceneReferences", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetSceneCullingMask(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.SceneManagement.Scene arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "GetSceneCullingMask", typeof(UnityEngine.SceneManagement.Scene), 0);
                    }
                    var ret = UnityEditor.SceneManagement.EditorSceneManager.GetSceneCullingMask(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetSceneCullingMask", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetSceneCullingMask(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.SceneManagement.Scene arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "SetSceneCullingMask", typeof(UnityEngine.SceneManagement.Scene), 0);
                    }
                    ulong arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "SetSceneCullingMask", typeof(ulong), 1);
                    }
                    UnityEditor.SceneManagement.EditorSceneManager.SetSceneCullingMask(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetSceneCullingMask", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CalculateAvailableSceneCullingMask(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.SceneManagement.EditorSceneManager.CalculateAvailableSceneCullingMask();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("CalculateAvailableSceneCullingMask", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SaveScene(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        UnityEngine.SceneManagement.Scene arg0;
                        if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "SaveScene", typeof(UnityEngine.SceneManagement.Scene), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "SaveScene", typeof(string), 1);
                        }
                        bool arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "SaveScene", typeof(bool), 2);
                        }
                        var ret = UnityEditor.SceneManagement.EditorSceneManager.SaveScene(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        UnityEngine.SceneManagement.Scene arg0;
                        if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "SaveScene", typeof(UnityEngine.SceneManagement.Scene), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "SaveScene", typeof(string), 1);
                        }
                        var ret = UnityEditor.SceneManagement.EditorSceneManager.SaveScene(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        UnityEngine.SceneManagement.Scene arg0;
                        if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "SaveScene", typeof(UnityEngine.SceneManagement.Scene), 0);
                        }
                        var ret = UnityEditor.SceneManagement.EditorSceneManager.SaveScene(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("SaveScene", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LoadSceneInPlayMode(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "LoadSceneInPlayMode", typeof(string), 0);
                    }
                    UnityEngine.SceneManagement.LoadSceneParameters arg1;
                    if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "LoadSceneInPlayMode", typeof(UnityEngine.SceneManagement.LoadSceneParameters), 1);
                    }
                    var ret = UnityEditor.SceneManagement.EditorSceneManager.LoadSceneInPlayMode(arg0, arg1);
                    return Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("LoadSceneInPlayMode", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LoadSceneAsyncInPlayMode(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "LoadSceneAsyncInPlayMode", typeof(string), 0);
                    }
                    UnityEngine.SceneManagement.LoadSceneParameters arg1;
                    if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "LoadSceneAsyncInPlayMode", typeof(UnityEngine.SceneManagement.LoadSceneParameters), 1);
                    }
                    var ret = UnityEditor.SceneManagement.EditorSceneManager.LoadSceneAsyncInPlayMode(arg0, arg1);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("LoadSceneAsyncInPlayMode", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_loadedSceneCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.SceneManagement.EditorSceneManager.loadedSceneCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_previewSceneCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.SceneManagement.EditorSceneManager.previewSceneCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_preventCrossSceneReferences(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.SceneManagement.EditorSceneManager.preventCrossSceneReferences;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_preventCrossSceneReferences(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "preventCrossSceneReferences", typeof(bool), 0);
                }
                UnityEditor.SceneManagement.EditorSceneManager.preventCrossSceneReferences = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_playModeStartScene(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.SceneManagement.EditorSceneManager.playModeStartScene;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_playModeStartScene(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.SceneAsset value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "playModeStartScene", typeof(UnityEditor.SceneAsset), 0);
                }
                UnityEditor.SceneManagement.EditorSceneManager.playModeStartScene = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_DefaultSceneCullingMask(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.SceneManagement.EditorSceneManager.DefaultSceneCullingMask;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_activeSceneChangedInEditMode(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "activeSceneChangedInEditMode", typeof(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>), 1);
                        }
                        UnityEditor.SceneManagement.EditorSceneManager.activeSceneChangedInEditMode += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "activeSceneChangedInEditMode", typeof(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>), 1);
                        }
                        UnityEditor.SceneManagement.EditorSceneManager.activeSceneChangedInEditMode -= value;
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
        public static JSValue BindStaticEvent_newSceneCreated(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                UnityEditor.SceneManagement.EditorSceneManager.NewSceneCreatedCallback value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "newSceneCreated", typeof(UnityEditor.SceneManagement.EditorSceneManager.NewSceneCreatedCallback), 1);
                        }
                        UnityEditor.SceneManagement.EditorSceneManager.newSceneCreated += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "newSceneCreated", typeof(UnityEditor.SceneManagement.EditorSceneManager.NewSceneCreatedCallback), 1);
                        }
                        UnityEditor.SceneManagement.EditorSceneManager.newSceneCreated -= value;
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
        public static JSValue BindStaticEvent_sceneOpening(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                UnityEditor.SceneManagement.EditorSceneManager.SceneOpeningCallback value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "sceneOpening", typeof(UnityEditor.SceneManagement.EditorSceneManager.SceneOpeningCallback), 1);
                        }
                        UnityEditor.SceneManagement.EditorSceneManager.sceneOpening += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "sceneOpening", typeof(UnityEditor.SceneManagement.EditorSceneManager.SceneOpeningCallback), 1);
                        }
                        UnityEditor.SceneManagement.EditorSceneManager.sceneOpening -= value;
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
        public static JSValue BindStaticEvent_sceneOpened(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                UnityEditor.SceneManagement.EditorSceneManager.SceneOpenedCallback value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "sceneOpened", typeof(UnityEditor.SceneManagement.EditorSceneManager.SceneOpenedCallback), 1);
                        }
                        UnityEditor.SceneManagement.EditorSceneManager.sceneOpened += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "sceneOpened", typeof(UnityEditor.SceneManagement.EditorSceneManager.SceneOpenedCallback), 1);
                        }
                        UnityEditor.SceneManagement.EditorSceneManager.sceneOpened -= value;
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
        public static JSValue BindStaticEvent_sceneClosing(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                UnityEditor.SceneManagement.EditorSceneManager.SceneClosingCallback value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "sceneClosing", typeof(UnityEditor.SceneManagement.EditorSceneManager.SceneClosingCallback), 1);
                        }
                        UnityEditor.SceneManagement.EditorSceneManager.sceneClosing += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "sceneClosing", typeof(UnityEditor.SceneManagement.EditorSceneManager.SceneClosingCallback), 1);
                        }
                        UnityEditor.SceneManagement.EditorSceneManager.sceneClosing -= value;
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
        public static JSValue BindStaticEvent_sceneClosed(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                UnityEditor.SceneManagement.EditorSceneManager.SceneClosedCallback value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "sceneClosed", typeof(UnityEditor.SceneManagement.EditorSceneManager.SceneClosedCallback), 1);
                        }
                        UnityEditor.SceneManagement.EditorSceneManager.sceneClosed += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "sceneClosed", typeof(UnityEditor.SceneManagement.EditorSceneManager.SceneClosedCallback), 1);
                        }
                        UnityEditor.SceneManagement.EditorSceneManager.sceneClosed -= value;
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
        public static JSValue BindStaticEvent_sceneSaving(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                UnityEditor.SceneManagement.EditorSceneManager.SceneSavingCallback value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "sceneSaving", typeof(UnityEditor.SceneManagement.EditorSceneManager.SceneSavingCallback), 1);
                        }
                        UnityEditor.SceneManagement.EditorSceneManager.sceneSaving += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "sceneSaving", typeof(UnityEditor.SceneManagement.EditorSceneManager.SceneSavingCallback), 1);
                        }
                        UnityEditor.SceneManagement.EditorSceneManager.sceneSaving -= value;
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
        public static JSValue BindStaticEvent_sceneSaved(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                UnityEditor.SceneManagement.EditorSceneManager.SceneSavedCallback value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "sceneSaved", typeof(UnityEditor.SceneManagement.EditorSceneManager.SceneSavedCallback), 1);
                        }
                        UnityEditor.SceneManagement.EditorSceneManager.sceneSaved += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "sceneSaved", typeof(UnityEditor.SceneManagement.EditorSceneManager.SceneSavedCallback), 1);
                        }
                        UnityEditor.SceneManagement.EditorSceneManager.sceneSaved -= value;
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
        public static JSValue BindStaticEvent_sceneDirtied(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                UnityEditor.SceneManagement.EditorSceneManager.SceneDirtiedCallback value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "sceneDirtied", typeof(UnityEditor.SceneManagement.EditorSceneManager.SceneDirtiedCallback), 1);
                        }
                        UnityEditor.SceneManagement.EditorSceneManager.sceneDirtied += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.EditorSceneManager), "sceneDirtied", typeof(UnityEditor.SceneManagement.EditorSceneManager.SceneDirtiedCallback), 1);
                        }
                        UnityEditor.SceneManagement.EditorSceneManager.sceneDirtied -= value;
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
            var cls = register.CreateClass("EditorSceneManager", typeof(UnityEditor.SceneManagement.EditorSceneManager), BindConstructor);
            cls.AddMethod(true, "OpenScene", BindStatic_OpenScene);
            cls.AddMethod(true, "NewScene", BindStatic_NewScene);
            cls.AddMethod(true, "NewPreviewScene", BindStatic_NewPreviewScene);
            cls.AddMethod(true, "CloseScene", BindStatic_CloseScene);
            cls.AddMethod(true, "ClosePreviewScene", BindStatic_ClosePreviewScene);
            cls.AddMethod(true, "IsPreviewScene", BindStatic_IsPreviewScene);
            cls.AddMethod(true, "IsPreviewSceneObject", BindStatic_IsPreviewSceneObject);
            cls.AddMethod(true, "MoveSceneBefore", BindStatic_MoveSceneBefore);
            cls.AddMethod(true, "MoveSceneAfter", BindStatic_MoveSceneAfter);
            cls.AddMethod(true, "SaveOpenScenes", BindStatic_SaveOpenScenes);
            cls.AddMethod(true, "SaveScenes", BindStatic_SaveScenes);
            cls.AddMethod(true, "SaveCurrentModifiedScenesIfUserWantsTo", BindStatic_SaveCurrentModifiedScenesIfUserWantsTo);
            cls.AddMethod(true, "SaveModifiedScenesIfUserWantsTo", BindStatic_SaveModifiedScenesIfUserWantsTo);
            cls.AddMethod(true, "EnsureUntitledSceneHasBeenSaved", BindStatic_EnsureUntitledSceneHasBeenSaved);
            cls.AddMethod(true, "MarkSceneDirty", BindStatic_MarkSceneDirty);
            cls.AddMethod(true, "MarkAllScenesDirty", BindStatic_MarkAllScenesDirty);
            cls.AddMethod(true, "GetSceneManagerSetup", BindStatic_GetSceneManagerSetup);
            cls.AddMethod(true, "RestoreSceneManagerSetup", BindStatic_RestoreSceneManagerSetup);
            cls.AddMethod(true, "DetectCrossSceneReferences", BindStatic_DetectCrossSceneReferences);
            cls.AddMethod(true, "GetSceneCullingMask", BindStatic_GetSceneCullingMask);
            cls.AddMethod(true, "SetSceneCullingMask", BindStatic_SetSceneCullingMask);
            cls.AddMethod(true, "CalculateAvailableSceneCullingMask", BindStatic_CalculateAvailableSceneCullingMask);
            cls.AddMethod(true, "SaveScene", BindStatic_SaveScene);
            cls.AddMethod(true, "LoadSceneInPlayMode", BindStatic_LoadSceneInPlayMode);
            cls.AddMethod(true, "LoadSceneAsyncInPlayMode", BindStatic_LoadSceneAsyncInPlayMode);
            cls.AddProperty(true, "loadedSceneCount", BindStaticRead_loadedSceneCount, null);
            cls.AddProperty(true, "previewSceneCount", BindStaticRead_previewSceneCount, null);
            cls.AddProperty(true, "preventCrossSceneReferences", BindStaticRead_preventCrossSceneReferences, BindStaticWrite_preventCrossSceneReferences);
            cls.AddProperty(true, "playModeStartScene", BindStaticRead_playModeStartScene, BindStaticWrite_playModeStartScene);
            cls.AddField(true, "DefaultSceneCullingMask", BindStaticRead_DefaultSceneCullingMask, null);
            cls.AddMethod(true, "activeSceneChangedInEditMode", BindStaticEvent_activeSceneChangedInEditMode);
            cls.AddMethod(true, "newSceneCreated", BindStaticEvent_newSceneCreated);
            cls.AddMethod(true, "sceneOpening", BindStaticEvent_sceneOpening);
            cls.AddMethod(true, "sceneOpened", BindStaticEvent_sceneOpened);
            cls.AddMethod(true, "sceneClosing", BindStaticEvent_sceneClosing);
            cls.AddMethod(true, "sceneClosed", BindStaticEvent_sceneClosed);
            cls.AddMethod(true, "sceneSaving", BindStaticEvent_sceneSaving);
            cls.AddMethod(true, "sceneSaved", BindStaticEvent_sceneSaved);
            cls.AddMethod(true, "sceneDirtied", BindStaticEvent_sceneDirtied);
            return cls;
        }
    }
}
#endif
#endif
