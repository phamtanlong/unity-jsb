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
    // Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2019.4.40f1/Unity.app/Contents/Managed/UnityEngine/UnityEngine.CoreModule.dll
    // Type: UnityEngine.Resources
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_Resources
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Load(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(UnityEngine.Resources), "Load", typeof(string), 0);
                        }
                        System.Type arg1;
                        if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Resources), "Load", typeof(System.Type), 1);
                        }
                        var ret = UnityEngine.Resources.Load(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Resources), "Load", typeof(string), 0);
                        }
                        var ret = UnityEngine.Resources.Load(arg0);
                        return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("Load", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LoadAsync(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(UnityEngine.Resources), "LoadAsync", typeof(string), 0);
                        }
                        System.Type arg1;
                        if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Resources), "LoadAsync", typeof(System.Type), 1);
                        }
                        var ret = UnityEngine.Resources.LoadAsync(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Resources), "LoadAsync", typeof(string), 0);
                        }
                        var ret = UnityEngine.Resources.LoadAsync(arg0);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("LoadAsync", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LoadAll(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(UnityEngine.Resources), "LoadAll", typeof(string), 0);
                        }
                        System.Type arg1;
                        if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Resources), "LoadAll", typeof(System.Type), 1);
                        }
                        var ret = UnityEngine.Resources.LoadAll(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Resources), "LoadAll", typeof(string), 0);
                        }
                        var ret = UnityEngine.Resources.LoadAll(arg0);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("LoadAll", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetBuiltinResource(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    System.Type arg0;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Resources), "GetBuiltinResource", typeof(System.Type), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Resources), "GetBuiltinResource", typeof(string), 1);
                    }
                    var ret = UnityEngine.Resources.GetBuiltinResource(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetBuiltinResource", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_UnloadAsset(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Resources), "UnloadAsset", typeof(UnityEngine.Object), 0);
                    }
                    UnityEngine.Resources.UnloadAsset(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("UnloadAsset", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_UnloadUnusedAssets(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEngine.Resources.UnloadUnusedAssets();
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("UnloadUnusedAssets", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("Resources", typeof(UnityEngine.Resources), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "FindObjectsOfTypeAll", QuickJS.Unity.ResourcesFix.BindStatic_FindObjectsOfTypeAll);
            cls.AddMethod(true, "Load", BindStatic_Load);
            cls.AddMethod(true, "LoadAsync", BindStatic_LoadAsync);
            cls.AddMethod(true, "LoadAll", BindStatic_LoadAll);
            cls.AddMethod(true, "GetBuiltinResource", BindStatic_GetBuiltinResource);
            cls.AddMethod(true, "UnloadAsset", BindStatic_UnloadAsset);
            cls.AddMethod(true, "UnloadUnusedAssets", BindStatic_UnloadUnusedAssets);
            return cls;
        }
    }
}
#endif
