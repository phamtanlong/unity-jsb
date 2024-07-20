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
    // Type: UnityEditor.SceneManagement.SceneCullingMasks
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_SceneManagement_SceneCullingMasks
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_DefaultSceneCullingMask(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.SceneManagement.SceneCullingMasks.DefaultSceneCullingMask;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_GameViewObjects(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.SceneManagement.SceneCullingMasks.GameViewObjects;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_MainStageSceneViewObjects(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.SceneManagement.SceneCullingMasks.MainStageSceneViewObjects;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("SceneCullingMasks", typeof(UnityEditor.SceneManagement.SceneCullingMasks), QuickJS.JSNative.class_private_ctor);
            cls.AddField(true, "DefaultSceneCullingMask", BindStaticRead_DefaultSceneCullingMask, null);
            cls.AddField(true, "GameViewObjects", BindStaticRead_GameViewObjects, null);
            cls.AddField(true, "MainStageSceneViewObjects", BindStaticRead_MainStageSceneViewObjects, null);
            return cls;
        }
    }
}
#endif
#endif
