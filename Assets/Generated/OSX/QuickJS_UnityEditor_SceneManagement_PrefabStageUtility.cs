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
    // Type: UnityEditor.SceneManagement.PrefabStageUtility
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_SceneManagement_PrefabStageUtility
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_OpenPrefab(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.PrefabStageUtility), "OpenPrefab", typeof(string), 0);
                        }
                        UnityEngine.GameObject arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.PrefabStageUtility), "OpenPrefab", typeof(UnityEngine.GameObject), 1);
                        }
                        UnityEditor.SceneManagement.PrefabStage.Mode arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.PrefabStageUtility), "OpenPrefab", typeof(UnityEditor.SceneManagement.PrefabStage.Mode), 2);
                        }
                        var ret = UnityEditor.SceneManagement.PrefabStageUtility.OpenPrefab(arg0, arg1, arg2);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.PrefabStageUtility), "OpenPrefab", typeof(string), 0);
                        }
                        UnityEngine.GameObject arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.PrefabStageUtility), "OpenPrefab", typeof(UnityEngine.GameObject), 1);
                        }
                        var ret = UnityEditor.SceneManagement.PrefabStageUtility.OpenPrefab(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.SceneManagement.PrefabStageUtility), "OpenPrefab", typeof(string), 0);
                        }
                        var ret = UnityEditor.SceneManagement.PrefabStageUtility.OpenPrefab(arg0);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("OpenPrefab", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetCurrentPrefabStage(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.SceneManagement.PrefabStageUtility.GetCurrentPrefabStage();
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetCurrentPrefabStage", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetPrefabStage(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SceneManagement.PrefabStageUtility), "GetPrefabStage", typeof(UnityEngine.GameObject), 0);
                    }
                    var ret = UnityEditor.SceneManagement.PrefabStageUtility.GetPrefabStage(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetPrefabStage", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("PrefabStageUtility", typeof(UnityEditor.SceneManagement.PrefabStageUtility), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "OpenPrefab", BindStatic_OpenPrefab);
            cls.AddMethod(true, "GetCurrentPrefabStage", BindStatic_GetCurrentPrefabStage);
            cls.AddMethod(true, "GetPrefabStage", BindStatic_GetPrefabStage);
            return cls;
        }
    }
}
#endif
#endif
