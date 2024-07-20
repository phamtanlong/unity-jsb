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
    // Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2021.3.37f1/Unity.app/Contents/Managed/UnityEngine/UnityEngine.CoreModule.dll
    // Type: UnityEngine.SceneManagement.SceneManager
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_SceneManagement_SceneManager
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new UnityEngine.SceneManagement.SceneManager();
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
        public static JSValue BindStatic_GetActiveScene(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
                    return Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetActiveScene", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetActiveScene(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.SceneManagement.Scene arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "SetActiveScene", typeof(UnityEngine.SceneManagement.Scene), 0);
                    }
                    var ret = UnityEngine.SceneManagement.SceneManager.SetActiveScene(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("SetActiveScene", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetSceneByPath(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "GetSceneByPath", typeof(string), 0);
                    }
                    var ret = UnityEngine.SceneManagement.SceneManager.GetSceneByPath(arg0);
                    return Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetSceneByPath", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetSceneByName(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "GetSceneByName", typeof(string), 0);
                    }
                    var ret = UnityEngine.SceneManagement.SceneManager.GetSceneByName(arg0);
                    return Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetSceneByName", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetSceneByBuildIndex(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "GetSceneByBuildIndex", typeof(int), 0);
                    }
                    var ret = UnityEngine.SceneManagement.SceneManager.GetSceneByBuildIndex(arg0);
                    return Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetSceneByBuildIndex", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetSceneAt(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "GetSceneAt", typeof(int), 0);
                    }
                    var ret = UnityEngine.SceneManagement.SceneManager.GetSceneAt(arg0);
                    return Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetSceneAt", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CreateScene(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "CreateScene", typeof(string), 0);
                        }
                        UnityEngine.SceneManagement.CreateSceneParameters arg1;
                        if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "CreateScene", typeof(UnityEngine.SceneManagement.CreateSceneParameters), 1);
                        }
                        var ret = UnityEngine.SceneManagement.SceneManager.CreateScene(arg0, arg1);
                        return Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "CreateScene", typeof(string), 0);
                        }
                        var ret = UnityEngine.SceneManagement.SceneManager.CreateScene(arg0);
                        return Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("CreateScene", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_MergeScenes(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.SceneManagement.Scene arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "MergeScenes", typeof(UnityEngine.SceneManagement.Scene), 0);
                    }
                    UnityEngine.SceneManagement.Scene arg1;
                    if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "MergeScenes", typeof(UnityEngine.SceneManagement.Scene), 1);
                    }
                    UnityEngine.SceneManagement.SceneManager.MergeScenes(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("MergeScenes", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_MoveGameObjectToScene(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "MoveGameObjectToScene", typeof(UnityEngine.GameObject), 0);
                    }
                    UnityEngine.SceneManagement.Scene arg1;
                    if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "MoveGameObjectToScene", typeof(UnityEngine.SceneManagement.Scene), 1);
                    }
                    UnityEngine.SceneManagement.SceneManager.MoveGameObjectToScene(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("MoveGameObjectToScene", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LoadScene(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.SceneManagement.LoadSceneMode)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "LoadScene", typeof(string), 0);
                            }
                            UnityEngine.SceneManagement.LoadSceneMode arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "LoadScene", typeof(UnityEngine.SceneManagement.LoadSceneMode), 1);
                            }
                            UnityEngine.SceneManagement.SceneManager.LoadScene(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.SceneManagement.LoadSceneParameters)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "LoadScene", typeof(string), 0);
                            }
                            UnityEngine.SceneManagement.LoadSceneParameters arg1;
                            if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "LoadScene", typeof(UnityEngine.SceneManagement.LoadSceneParameters), 1);
                            }
                            var ret = UnityEngine.SceneManagement.SceneManager.LoadScene(arg0, arg1);
                            return Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.SceneManagement.LoadSceneMode)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "LoadScene", typeof(int), 0);
                            }
                            UnityEngine.SceneManagement.LoadSceneMode arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "LoadScene", typeof(UnityEngine.SceneManagement.LoadSceneMode), 1);
                            }
                            UnityEngine.SceneManagement.SceneManager.LoadScene(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.SceneManagement.LoadSceneParameters)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "LoadScene", typeof(int), 0);
                            }
                            UnityEngine.SceneManagement.LoadSceneParameters arg1;
                            if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "LoadScene", typeof(UnityEngine.SceneManagement.LoadSceneParameters), 1);
                            }
                            var ret = UnityEngine.SceneManagement.SceneManager.LoadScene(arg0, arg1);
                            return Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "LoadScene", typeof(string), 0);
                            }
                            UnityEngine.SceneManagement.SceneManager.LoadScene(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "LoadScene", typeof(int), 0);
                            }
                            UnityEngine.SceneManagement.SceneManager.LoadScene(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("LoadScene", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LoadSceneAsync(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.SceneManagement.LoadSceneMode)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "LoadSceneAsync", typeof(int), 0);
                            }
                            UnityEngine.SceneManagement.LoadSceneMode arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "LoadSceneAsync", typeof(UnityEngine.SceneManagement.LoadSceneMode), 1);
                            }
                            var ret = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(arg0, arg1);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.SceneManagement.LoadSceneParameters)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "LoadSceneAsync", typeof(int), 0);
                            }
                            UnityEngine.SceneManagement.LoadSceneParameters arg1;
                            if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "LoadSceneAsync", typeof(UnityEngine.SceneManagement.LoadSceneParameters), 1);
                            }
                            var ret = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(arg0, arg1);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.SceneManagement.LoadSceneMode)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "LoadSceneAsync", typeof(string), 0);
                            }
                            UnityEngine.SceneManagement.LoadSceneMode arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "LoadSceneAsync", typeof(UnityEngine.SceneManagement.LoadSceneMode), 1);
                            }
                            var ret = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(arg0, arg1);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.SceneManagement.LoadSceneParameters)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "LoadSceneAsync", typeof(string), 0);
                            }
                            UnityEngine.SceneManagement.LoadSceneParameters arg1;
                            if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "LoadSceneAsync", typeof(UnityEngine.SceneManagement.LoadSceneParameters), 1);
                            }
                            var ret = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(arg0, arg1);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "LoadSceneAsync", typeof(int), 0);
                            }
                            var ret = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(arg0);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "LoadSceneAsync", typeof(string), 0);
                            }
                            var ret = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(arg0);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("LoadSceneAsync", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_UnloadSceneAsync(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.SceneManagement.UnloadSceneOptions)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "UnloadSceneAsync", typeof(int), 0);
                            }
                            UnityEngine.SceneManagement.UnloadSceneOptions arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "UnloadSceneAsync", typeof(UnityEngine.SceneManagement.UnloadSceneOptions), 1);
                            }
                            var ret = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(arg0, arg1);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.SceneManagement.UnloadSceneOptions)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "UnloadSceneAsync", typeof(string), 0);
                            }
                            UnityEngine.SceneManagement.UnloadSceneOptions arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "UnloadSceneAsync", typeof(UnityEngine.SceneManagement.UnloadSceneOptions), 1);
                            }
                            var ret = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(arg0, arg1);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.SceneManagement.Scene)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.SceneManagement.UnloadSceneOptions)))
                        {
                            UnityEngine.SceneManagement.Scene arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "UnloadSceneAsync", typeof(UnityEngine.SceneManagement.Scene), 0);
                            }
                            UnityEngine.SceneManagement.UnloadSceneOptions arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "UnloadSceneAsync", typeof(UnityEngine.SceneManagement.UnloadSceneOptions), 1);
                            }
                            var ret = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(arg0, arg1);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "UnloadSceneAsync", typeof(int), 0);
                            }
                            var ret = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(arg0);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "UnloadSceneAsync", typeof(string), 0);
                            }
                            var ret = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(arg0);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.SceneManagement.Scene)))
                        {
                            UnityEngine.SceneManagement.Scene arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "UnloadSceneAsync", typeof(UnityEngine.SceneManagement.Scene), 0);
                            }
                            var ret = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(arg0);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("UnloadSceneAsync", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_sceneCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.SceneManagement.SceneManager.sceneCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_sceneCountInBuildSettings(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_sceneLoaded(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "sceneLoaded", typeof(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>), 1);
                        }
                        UnityEngine.SceneManagement.SceneManager.sceneLoaded += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "sceneLoaded", typeof(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>), 1);
                        }
                        UnityEngine.SceneManagement.SceneManager.sceneLoaded -= value;
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
        public static JSValue BindStaticEvent_sceneUnloaded(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "sceneUnloaded", typeof(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>), 1);
                        }
                        UnityEngine.SceneManagement.SceneManager.sceneUnloaded += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "sceneUnloaded", typeof(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>), 1);
                        }
                        UnityEngine.SceneManagement.SceneManager.sceneUnloaded -= value;
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
        public static JSValue BindStaticEvent_activeSceneChanged(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "activeSceneChanged", typeof(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>), 1);
                        }
                        UnityEngine.SceneManagement.SceneManager.activeSceneChanged += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEngine.SceneManagement.SceneManager), "activeSceneChanged", typeof(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>), 1);
                        }
                        UnityEngine.SceneManagement.SceneManager.activeSceneChanged -= value;
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
            var cls = register.CreateClass("SceneManager", typeof(UnityEngine.SceneManagement.SceneManager), BindConstructor);
            cls.AddMethod(true, "GetActiveScene", BindStatic_GetActiveScene);
            cls.AddMethod(true, "SetActiveScene", BindStatic_SetActiveScene);
            cls.AddMethod(true, "GetSceneByPath", BindStatic_GetSceneByPath);
            cls.AddMethod(true, "GetSceneByName", BindStatic_GetSceneByName);
            cls.AddMethod(true, "GetSceneByBuildIndex", BindStatic_GetSceneByBuildIndex);
            cls.AddMethod(true, "GetSceneAt", BindStatic_GetSceneAt);
            cls.AddMethod(true, "CreateScene", BindStatic_CreateScene);
            cls.AddMethod(true, "MergeScenes", BindStatic_MergeScenes);
            cls.AddMethod(true, "MoveGameObjectToScene", BindStatic_MoveGameObjectToScene);
            cls.AddMethod(true, "LoadScene", BindStatic_LoadScene);
            cls.AddMethod(true, "LoadSceneAsync", BindStatic_LoadSceneAsync);
            cls.AddMethod(true, "UnloadSceneAsync", BindStatic_UnloadSceneAsync);
            cls.AddProperty(true, "sceneCount", BindStaticRead_sceneCount, null);
            cls.AddProperty(true, "sceneCountInBuildSettings", BindStaticRead_sceneCountInBuildSettings, null);
            cls.AddMethod(true, "sceneLoaded", BindStaticEvent_sceneLoaded);
            cls.AddMethod(true, "sceneUnloaded", BindStaticEvent_sceneUnloaded);
            cls.AddMethod(true, "activeSceneChanged", BindStaticEvent_activeSceneChanged);
            return cls;
        }
    }
}
#endif
