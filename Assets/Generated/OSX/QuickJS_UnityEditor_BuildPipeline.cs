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
    // Type: UnityEditor.BuildPipeline
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_BuildPipeline
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetBuildTargetGroup(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.BuildTarget arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.BuildPipeline), "GetBuildTargetGroup", typeof(UnityEditor.BuildTarget), 0);
                    }
                    var ret = UnityEditor.BuildPipeline.GetBuildTargetGroup(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                }
                throw new NoSuitableMethodException("GetBuildTargetGroup", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetBuildTargetName(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.BuildTarget arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.BuildPipeline), "GetBuildTargetName", typeof(UnityEditor.BuildTarget), 0);
                    }
                    var ret = UnityEditor.BuildPipeline.GetBuildTargetName(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetBuildTargetName", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BuildCanBeAppended(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.BuildTarget arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.BuildPipeline), "BuildCanBeAppended", typeof(UnityEditor.BuildTarget), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.BuildPipeline), "BuildCanBeAppended", typeof(string), 1);
                    }
                    var ret = UnityEditor.BuildPipeline.BuildCanBeAppended(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                }
                throw new NoSuitableMethodException("BuildCanBeAppended", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BuildPlayer(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.EditorBuildSettingsScene[])) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEditor.BuildTarget)) && Values.js_match_type(ctx, argv[3], typeof(UnityEditor.BuildOptions)))
                        {
                            UnityEditor.EditorBuildSettingsScene[] arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.BuildPipeline), "BuildPlayer", typeof(UnityEditor.EditorBuildSettingsScene[]), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.BuildPipeline), "BuildPlayer", typeof(string), 1);
                            }
                            UnityEditor.BuildTarget arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.BuildPipeline), "BuildPlayer", typeof(UnityEditor.BuildTarget), 2);
                            }
                            UnityEditor.BuildOptions arg3;
                            if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.BuildPipeline), "BuildPlayer", typeof(UnityEditor.BuildOptions), 3);
                            }
                            var ret = UnityEditor.BuildPipeline.BuildPlayer(arg0, arg1, arg2, arg3);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string[])) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEditor.BuildTarget)) && Values.js_match_type(ctx, argv[3], typeof(UnityEditor.BuildOptions)))
                        {
                            string[] arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.BuildPipeline), "BuildPlayer", typeof(string[]), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.BuildPipeline), "BuildPlayer", typeof(string), 1);
                            }
                            UnityEditor.BuildTarget arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.BuildPipeline), "BuildPlayer", typeof(UnityEditor.BuildTarget), 2);
                            }
                            UnityEditor.BuildOptions arg3;
                            if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.BuildPipeline), "BuildPlayer", typeof(UnityEditor.BuildOptions), 3);
                            }
                            var ret = UnityEditor.BuildPipeline.BuildPlayer(arg0, arg1, arg2, arg3);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc == 1)
                    {
                        UnityEditor.BuildPlayerOptions arg0;
                        if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.BuildPipeline), "BuildPlayer", typeof(UnityEditor.BuildPlayerOptions), 0);
                        }
                        var ret = UnityEditor.BuildPipeline.BuildPlayer(arg0);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("BuildPlayer", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BuildAssetBundles(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.BuildPipeline), "BuildAssetBundles", typeof(string), 0);
                        }
                        UnityEditor.AssetBundleBuild[] arg1;
                        if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.BuildPipeline), "BuildAssetBundles", typeof(UnityEditor.AssetBundleBuild[]), 1);
                        }
                        UnityEditor.BuildAssetBundleOptions arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.BuildPipeline), "BuildAssetBundles", typeof(UnityEditor.BuildAssetBundleOptions), 2);
                        }
                        UnityEditor.BuildTarget arg3;
                        if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.BuildPipeline), "BuildAssetBundles", typeof(UnityEditor.BuildTarget), 3);
                        }
                        var ret = UnityEditor.BuildPipeline.BuildAssetBundles(arg0, arg1, arg2, arg3);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.BuildPipeline), "BuildAssetBundles", typeof(string), 0);
                        }
                        UnityEditor.BuildAssetBundleOptions arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.BuildPipeline), "BuildAssetBundles", typeof(UnityEditor.BuildAssetBundleOptions), 1);
                        }
                        UnityEditor.BuildTarget arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.BuildPipeline), "BuildAssetBundles", typeof(UnityEditor.BuildTarget), 2);
                        }
                        var ret = UnityEditor.BuildPipeline.BuildAssetBundles(arg0, arg1, arg2);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("BuildAssetBundles", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetCRCForAssetBundle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.BuildPipeline), "GetCRCForAssetBundle", typeof(string), 0);
                    }
                    uint arg1;
                    var ret = UnityEditor.BuildPipeline.GetCRCForAssetBundle(arg0, out arg1);
                    var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg1);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetCRCForAssetBundle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetHashForAssetBundle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.BuildPipeline), "GetHashForAssetBundle", typeof(string), 0);
                    }
                    UnityEngine.Hash128 arg1;
                    var ret = UnityEditor.BuildPipeline.GetHashForAssetBundle(arg0, out arg1);
                    var out0 = Values.js_push_structvalue(ctx, arg1);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetHashForAssetBundle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsBuildTargetSupported(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.BuildTargetGroup arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.BuildPipeline), "IsBuildTargetSupported", typeof(UnityEditor.BuildTargetGroup), 0);
                    }
                    UnityEditor.BuildTarget arg1;
                    if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.BuildPipeline), "IsBuildTargetSupported", typeof(UnityEditor.BuildTarget), 1);
                    }
                    var ret = UnityEditor.BuildPipeline.IsBuildTargetSupported(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsBuildTargetSupported", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetPlaybackEngineDirectory(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        UnityEditor.BuildTargetGroup arg0;
                        if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.BuildPipeline), "GetPlaybackEngineDirectory", typeof(UnityEditor.BuildTargetGroup), 0);
                        }
                        UnityEditor.BuildTarget arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.BuildPipeline), "GetPlaybackEngineDirectory", typeof(UnityEditor.BuildTarget), 1);
                        }
                        UnityEditor.BuildOptions arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.BuildPipeline), "GetPlaybackEngineDirectory", typeof(UnityEditor.BuildOptions), 2);
                        }
                        var ret = UnityEditor.BuildPipeline.GetPlaybackEngineDirectory(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        UnityEditor.BuildTarget arg0;
                        if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.BuildPipeline), "GetPlaybackEngineDirectory", typeof(UnityEditor.BuildTarget), 0);
                        }
                        UnityEditor.BuildOptions arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.BuildPipeline), "GetPlaybackEngineDirectory", typeof(UnityEditor.BuildOptions), 1);
                        }
                        var ret = UnityEditor.BuildPipeline.GetPlaybackEngineDirectory(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("GetPlaybackEngineDirectory", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_isBuildingPlayer(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.BuildPipeline.isBuildingPlayer;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("BuildPipeline", typeof(UnityEditor.BuildPipeline), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "GetBuildTargetGroup", BindStatic_GetBuildTargetGroup);
            cls.AddMethod(true, "GetBuildTargetName", BindStatic_GetBuildTargetName);
            cls.AddMethod(true, "BuildCanBeAppended", BindStatic_BuildCanBeAppended);
            cls.AddMethod(true, "BuildPlayer", BindStatic_BuildPlayer);
            cls.AddMethod(true, "BuildAssetBundles", BindStatic_BuildAssetBundles);
            cls.AddMethod(true, "GetCRCForAssetBundle", BindStatic_GetCRCForAssetBundle);
            cls.AddMethod(true, "GetHashForAssetBundle", BindStatic_GetHashForAssetBundle);
            cls.AddMethod(true, "IsBuildTargetSupported", BindStatic_IsBuildTargetSupported);
            cls.AddMethod(true, "GetPlaybackEngineDirectory", BindStatic_GetPlaybackEngineDirectory);
            cls.AddProperty(true, "isBuildingPlayer", BindStaticRead_isBuildingPlayer, null);
            return cls;
        }
    }
}
#endif
#endif
