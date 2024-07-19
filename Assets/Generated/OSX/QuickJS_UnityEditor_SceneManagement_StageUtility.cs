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
    // Type: UnityEditor.SceneManagement.StageUtility
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_SceneManagement_StageUtility
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsGameObjectRenderedByCamera(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SceneManagement.StageUtility), "IsGameObjectRenderedByCamera", typeof(UnityEngine.GameObject), 0);
                    }
                    UnityEngine.Camera arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.SceneManagement.StageUtility), "IsGameObjectRenderedByCamera", typeof(UnityEngine.Camera), 1);
                    }
                    var ret = UnityEditor.SceneManagement.StageUtility.IsGameObjectRenderedByCamera(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsGameObjectRenderedByCamera", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetCurrentStageHandle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.SceneManagement.StageUtility.GetCurrentStageHandle();
                    return Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetCurrentStageHandle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetMainStageHandle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.SceneManagement.StageUtility.GetMainStageHandle();
                    return Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetMainStageHandle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetStageHandle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.GameObject)))
                        {
                            UnityEngine.GameObject arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.SceneManagement.StageUtility), "GetStageHandle", typeof(UnityEngine.GameObject), 0);
                            }
                            var ret = UnityEditor.SceneManagement.StageUtility.GetStageHandle(arg0);
                            return Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.SceneManagement.Scene)))
                        {
                            UnityEngine.SceneManagement.Scene arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.SceneManagement.StageUtility), "GetStageHandle", typeof(UnityEngine.SceneManagement.Scene), 0);
                            }
                            var ret = UnityEditor.SceneManagement.StageUtility.GetStageHandle(arg0);
                            return Values.js_push_structvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("GetStageHandle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GoToMainStage(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.SceneManagement.StageUtility.GoToMainStage();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("GoToMainStage", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GoBackToPreviousStage(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.SceneManagement.StageUtility.GoBackToPreviousStage();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("GoBackToPreviousStage", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_PlaceGameObjectInCurrentStage(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SceneManagement.StageUtility), "PlaceGameObjectInCurrentStage", typeof(UnityEngine.GameObject), 0);
                    }
                    UnityEditor.SceneManagement.StageUtility.PlaceGameObjectInCurrentStage(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("PlaceGameObjectInCurrentStage", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("StageUtility", typeof(UnityEditor.SceneManagement.StageUtility), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "IsGameObjectRenderedByCamera", BindStatic_IsGameObjectRenderedByCamera);
            cls.AddMethod(true, "GetCurrentStageHandle", BindStatic_GetCurrentStageHandle);
            cls.AddMethod(true, "GetMainStageHandle", BindStatic_GetMainStageHandle);
            cls.AddMethod(true, "GetStageHandle", BindStatic_GetStageHandle);
            cls.AddMethod(true, "GoToMainStage", BindStatic_GoToMainStage);
            cls.AddMethod(true, "GoBackToPreviousStage", BindStatic_GoBackToPreviousStage);
            cls.AddMethod(true, "PlaceGameObjectInCurrentStage", BindStatic_PlaceGameObjectInCurrentStage);
            return cls;
        }
    }
}
#endif
#endif
