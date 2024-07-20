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
    // Type: UnityEditor.EditorUtility
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_EditorUtility
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_OpenFilePanel(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "OpenFilePanel", typeof(string), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "OpenFilePanel", typeof(string), 1);
                    }
                    string arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "OpenFilePanel", typeof(string), 2);
                    }
                    var ret = UnityEditor.EditorUtility.OpenFilePanel(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("OpenFilePanel", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_OpenFilePanelWithFilters(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "OpenFilePanelWithFilters", typeof(string), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "OpenFilePanelWithFilters", typeof(string), 1);
                    }
                    string[] arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "OpenFilePanelWithFilters", typeof(string[]), 2);
                    }
                    var ret = UnityEditor.EditorUtility.OpenFilePanelWithFilters(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("OpenFilePanelWithFilters", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RevealInFinder(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "RevealInFinder", typeof(string), 0);
                    }
                    UnityEditor.EditorUtility.RevealInFinder(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RevealInFinder", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DisplayDialog(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 6)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayDialog", typeof(string), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayDialog", typeof(string), 1);
                        }
                        string arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayDialog", typeof(string), 2);
                        }
                        string arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayDialog", typeof(string), 3);
                        }
                        UnityEditor.DialogOptOutDecisionType arg4;
                        if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayDialog", typeof(UnityEditor.DialogOptOutDecisionType), 4);
                        }
                        string arg5;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayDialog", typeof(string), 5);
                        }
                        var ret = UnityEditor.EditorUtility.DisplayDialog(arg0, arg1, arg2, arg3, arg4, arg5);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 5)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayDialog", typeof(string), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayDialog", typeof(string), 1);
                        }
                        string arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayDialog", typeof(string), 2);
                        }
                        UnityEditor.DialogOptOutDecisionType arg3;
                        if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayDialog", typeof(UnityEditor.DialogOptOutDecisionType), 3);
                        }
                        string arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayDialog", typeof(string), 4);
                        }
                        var ret = UnityEditor.EditorUtility.DisplayDialog(arg0, arg1, arg2, arg3, arg4);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 4)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayDialog", typeof(string), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayDialog", typeof(string), 1);
                        }
                        string arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayDialog", typeof(string), 2);
                        }
                        string arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayDialog", typeof(string), 3);
                        }
                        var ret = UnityEditor.EditorUtility.DisplayDialog(arg0, arg1, arg2, arg3);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayDialog", typeof(string), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayDialog", typeof(string), 1);
                        }
                        string arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayDialog", typeof(string), 2);
                        }
                        var ret = UnityEditor.EditorUtility.DisplayDialog(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("DisplayDialog", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DisplayDialogComplex(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 5)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayDialogComplex", typeof(string), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayDialogComplex", typeof(string), 1);
                    }
                    string arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayDialogComplex", typeof(string), 2);
                    }
                    string arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayDialogComplex", typeof(string), 3);
                    }
                    string arg4;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayDialogComplex", typeof(string), 4);
                    }
                    var ret = UnityEditor.EditorUtility.DisplayDialogComplex(arg0, arg1, arg2, arg3, arg4);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("DisplayDialogComplex", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_OpenFolderPanel(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "OpenFolderPanel", typeof(string), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "OpenFolderPanel", typeof(string), 1);
                    }
                    string arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "OpenFolderPanel", typeof(string), 2);
                    }
                    var ret = UnityEditor.EditorUtility.OpenFolderPanel(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("OpenFolderPanel", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SaveFolderPanel(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "SaveFolderPanel", typeof(string), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "SaveFolderPanel", typeof(string), 1);
                    }
                    string arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "SaveFolderPanel", typeof(string), 2);
                    }
                    var ret = UnityEditor.EditorUtility.SaveFolderPanel(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("SaveFolderPanel", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_WarnPrefab(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 4)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "WarnPrefab", typeof(UnityEngine.Object), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "WarnPrefab", typeof(string), 1);
                    }
                    string arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "WarnPrefab", typeof(string), 2);
                    }
                    string arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "WarnPrefab", typeof(string), 3);
                    }
                    var ret = UnityEditor.EditorUtility.WarnPrefab(arg0, arg1, arg2, arg3);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("WarnPrefab", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsPersistent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "IsPersistent", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.EditorUtility.IsPersistent(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsPersistent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SaveFilePanel(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 4)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "SaveFilePanel", typeof(string), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "SaveFilePanel", typeof(string), 1);
                    }
                    string arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "SaveFilePanel", typeof(string), 2);
                    }
                    string arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "SaveFilePanel", typeof(string), 3);
                    }
                    var ret = UnityEditor.EditorUtility.SaveFilePanel(arg0, arg1, arg2, arg3);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("SaveFilePanel", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_NaturalCompare(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "NaturalCompare", typeof(string), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "NaturalCompare", typeof(string), 1);
                    }
                    var ret = UnityEditor.EditorUtility.NaturalCompare(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("NaturalCompare", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_InstanceIDToObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "InstanceIDToObject", typeof(int), 0);
                    }
                    var ret = UnityEditor.EditorUtility.InstanceIDToObject(arg0);
                    return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("InstanceIDToObject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CompressTexture(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Texture2D)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.TextureFormat)) && Values.js_match_type(ctx, argv[2], typeof(int)))
                        {
                            UnityEngine.Texture2D arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorUtility), "CompressTexture", typeof(UnityEngine.Texture2D), 0);
                            }
                            UnityEngine.TextureFormat arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorUtility), "CompressTexture", typeof(UnityEngine.TextureFormat), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorUtility), "CompressTexture", typeof(int), 2);
                            }
                            UnityEditor.EditorUtility.CompressTexture(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Texture2D)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.TextureFormat)) && Values.js_match_type(ctx, argv[2], typeof(UnityEditor.TextureCompressionQuality)))
                        {
                            UnityEngine.Texture2D arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorUtility), "CompressTexture", typeof(UnityEngine.Texture2D), 0);
                            }
                            UnityEngine.TextureFormat arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorUtility), "CompressTexture", typeof(UnityEngine.TextureFormat), 1);
                            }
                            UnityEditor.TextureCompressionQuality arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorUtility), "CompressTexture", typeof(UnityEditor.TextureCompressionQuality), 2);
                            }
                            UnityEditor.EditorUtility.CompressTexture(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("CompressTexture", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CompressCubemapTexture(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Cubemap)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.TextureFormat)) && Values.js_match_type(ctx, argv[2], typeof(int)))
                        {
                            UnityEngine.Cubemap arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorUtility), "CompressCubemapTexture", typeof(UnityEngine.Cubemap), 0);
                            }
                            UnityEngine.TextureFormat arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorUtility), "CompressCubemapTexture", typeof(UnityEngine.TextureFormat), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorUtility), "CompressCubemapTexture", typeof(int), 2);
                            }
                            UnityEditor.EditorUtility.CompressCubemapTexture(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Cubemap)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.TextureFormat)) && Values.js_match_type(ctx, argv[2], typeof(UnityEditor.TextureCompressionQuality)))
                        {
                            UnityEngine.Cubemap arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorUtility), "CompressCubemapTexture", typeof(UnityEngine.Cubemap), 0);
                            }
                            UnityEngine.TextureFormat arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorUtility), "CompressCubemapTexture", typeof(UnityEngine.TextureFormat), 1);
                            }
                            UnityEditor.TextureCompressionQuality arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorUtility), "CompressCubemapTexture", typeof(UnityEditor.TextureCompressionQuality), 2);
                            }
                            UnityEditor.EditorUtility.CompressCubemapTexture(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("CompressCubemapTexture", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetDirty(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "SetDirty", typeof(UnityEngine.Object), 0);
                    }
                    UnityEditor.EditorUtility.SetDirty(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetDirty", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ClearDirty(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "ClearDirty", typeof(UnityEngine.Object), 0);
                    }
                    UnityEditor.EditorUtility.ClearDirty(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ClearDirty", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_InvokeDiffTool(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 6)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "InvokeDiffTool", typeof(string), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "InvokeDiffTool", typeof(string), 1);
                    }
                    string arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "InvokeDiffTool", typeof(string), 2);
                    }
                    string arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "InvokeDiffTool", typeof(string), 3);
                    }
                    string arg4;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "InvokeDiffTool", typeof(string), 4);
                    }
                    string arg5;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "InvokeDiffTool", typeof(string), 5);
                    }
                    var ret = UnityEditor.EditorUtility.InvokeDiffTool(arg0, arg1, arg2, arg3, arg4, arg5);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("InvokeDiffTool", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CopySerialized(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "CopySerialized", typeof(UnityEngine.Object), 0);
                    }
                    UnityEngine.Object arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "CopySerialized", typeof(UnityEngine.Object), 1);
                    }
                    UnityEditor.EditorUtility.CopySerialized(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CopySerialized", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CopySerializedManagedFieldsOnly(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    object arg0;
                    if (!Values.js_get_var(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "CopySerializedManagedFieldsOnly", typeof(object), 0);
                    }
                    object arg1;
                    if (!Values.js_get_var(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "CopySerializedManagedFieldsOnly", typeof(object), 1);
                    }
                    UnityEditor.EditorUtility.CopySerializedManagedFieldsOnly(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CopySerializedManagedFieldsOnly", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CollectDependencies(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object[] arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "CollectDependencies", typeof(UnityEngine.Object[]), 0);
                    }
                    var ret = UnityEditor.EditorUtility.CollectDependencies(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("CollectDependencies", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CollectDeepHierarchy(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object[] arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "CollectDeepHierarchy", typeof(UnityEngine.Object[]), 0);
                    }
                    var ret = UnityEditor.EditorUtility.CollectDeepHierarchy(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("CollectDeepHierarchy", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_FormatBytes(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(long)))
                        {
                            long arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorUtility), "FormatBytes", typeof(long), 0);
                            }
                            var ret = UnityEditor.EditorUtility.FormatBytes(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorUtility), "FormatBytes", typeof(int), 0);
                            }
                            var ret = UnityEditor.EditorUtility.FormatBytes(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("FormatBytes", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DisplayProgressBar(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayProgressBar", typeof(string), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayProgressBar", typeof(string), 1);
                    }
                    float arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayProgressBar", typeof(float), 2);
                    }
                    UnityEditor.EditorUtility.DisplayProgressBar(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DisplayProgressBar", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DisplayCancelableProgressBar(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayCancelableProgressBar", typeof(string), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayCancelableProgressBar", typeof(string), 1);
                    }
                    float arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayCancelableProgressBar", typeof(float), 2);
                    }
                    var ret = UnityEditor.EditorUtility.DisplayCancelableProgressBar(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("DisplayCancelableProgressBar", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ClearProgressBar(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorUtility.ClearProgressBar();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ClearProgressBar", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetObjectEnabled(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "GetObjectEnabled", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.EditorUtility.GetObjectEnabled(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetObjectEnabled", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetObjectEnabled(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "SetObjectEnabled", typeof(UnityEngine.Object), 0);
                    }
                    bool arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "SetObjectEnabled", typeof(bool), 1);
                    }
                    UnityEditor.EditorUtility.SetObjectEnabled(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetObjectEnabled", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetSelectedRenderState(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Renderer arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "SetSelectedRenderState", typeof(UnityEngine.Renderer), 0);
                    }
                    UnityEditor.EditorSelectedRenderState arg1;
                    if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "SetSelectedRenderState", typeof(UnityEditor.EditorSelectedRenderState), 1);
                    }
                    UnityEditor.EditorUtility.SetSelectedRenderState(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetSelectedRenderState", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_OpenWithDefaultApp(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "OpenWithDefaultApp", typeof(string), 0);
                    }
                    UnityEditor.EditorUtility.OpenWithDefaultApp(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("OpenWithDefaultApp", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetCameraAnimateMaterials(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Camera arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "SetCameraAnimateMaterials", typeof(UnityEngine.Camera), 0);
                    }
                    bool arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "SetCameraAnimateMaterials", typeof(bool), 1);
                    }
                    UnityEditor.EditorUtility.SetCameraAnimateMaterials(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetCameraAnimateMaterials", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetCameraAnimateMaterialsTime(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Camera arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "SetCameraAnimateMaterialsTime", typeof(UnityEngine.Camera), 0);
                    }
                    float arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "SetCameraAnimateMaterialsTime", typeof(float), 1);
                    }
                    UnityEditor.EditorUtility.SetCameraAnimateMaterialsTime(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetCameraAnimateMaterialsTime", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_UpdateGlobalShaderProperties(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    float arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "UpdateGlobalShaderProperties", typeof(float), 0);
                    }
                    UnityEditor.EditorUtility.UpdateGlobalShaderProperties(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("UpdateGlobalShaderProperties", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetDirtyCount(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorUtility), "GetDirtyCount", typeof(int), 0);
                            }
                            var ret = UnityEditor.EditorUtility.GetDirtyCount(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorUtility), "GetDirtyCount", typeof(UnityEngine.Object), 0);
                            }
                            var ret = UnityEditor.EditorUtility.GetDirtyCount(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("GetDirtyCount", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsDirty(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorUtility), "IsDirty", typeof(int), 0);
                            }
                            var ret = UnityEditor.EditorUtility.IsDirty(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.EditorUtility), "IsDirty", typeof(UnityEngine.Object), 0);
                            }
                            var ret = UnityEditor.EditorUtility.IsDirty(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("IsDirty", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_FocusProjectWindow(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorUtility.FocusProjectWindow();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("FocusProjectWindow", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RequestScriptReload(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorUtility.RequestScriptReload();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RequestScriptReload", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsRunningUnderCPUEmulation(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.EditorUtility.IsRunningUnderCPUEmulation();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsRunningUnderCPUEmulation", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LoadWindowLayout(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "LoadWindowLayout", typeof(string), 0);
                    }
                    var ret = UnityEditor.EditorUtility.LoadWindowLayout(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("LoadWindowLayout", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SaveFilePanelInProject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 5)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "SaveFilePanelInProject", typeof(string), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "SaveFilePanelInProject", typeof(string), 1);
                        }
                        string arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "SaveFilePanelInProject", typeof(string), 2);
                        }
                        string arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "SaveFilePanelInProject", typeof(string), 3);
                        }
                        string arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "SaveFilePanelInProject", typeof(string), 4);
                        }
                        var ret = UnityEditor.EditorUtility.SaveFilePanelInProject(arg0, arg1, arg2, arg3, arg4);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 4)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "SaveFilePanelInProject", typeof(string), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "SaveFilePanelInProject", typeof(string), 1);
                        }
                        string arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "SaveFilePanelInProject", typeof(string), 2);
                        }
                        string arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "SaveFilePanelInProject", typeof(string), 3);
                        }
                        var ret = UnityEditor.EditorUtility.SaveFilePanelInProject(arg0, arg1, arg2, arg3);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("SaveFilePanelInProject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CopySerializedIfDifferent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "CopySerializedIfDifferent", typeof(UnityEngine.Object), 0);
                    }
                    UnityEngine.Object arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "CopySerializedIfDifferent", typeof(UnityEngine.Object), 1);
                    }
                    UnityEditor.EditorUtility.CopySerializedIfDifferent(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CopySerializedIfDifferent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_UnloadUnusedAssetsImmediate(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        bool arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "UnloadUnusedAssetsImmediate", typeof(bool), 0);
                        }
                        UnityEditor.EditorUtility.UnloadUnusedAssetsImmediate(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 0)
                    {
                        UnityEditor.EditorUtility.UnloadUnusedAssetsImmediate();
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("UnloadUnusedAssetsImmediate", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetDialogOptOutDecision(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.DialogOptOutDecisionType arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "GetDialogOptOutDecision", typeof(UnityEditor.DialogOptOutDecisionType), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "GetDialogOptOutDecision", typeof(string), 1);
                    }
                    var ret = UnityEditor.EditorUtility.GetDialogOptOutDecision(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetDialogOptOutDecision", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetDialogOptOutDecision(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEditor.DialogOptOutDecisionType arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "SetDialogOptOutDecision", typeof(UnityEditor.DialogOptOutDecisionType), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "SetDialogOptOutDecision", typeof(string), 1);
                    }
                    bool arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "SetDialogOptOutDecision", typeof(bool), 2);
                    }
                    UnityEditor.EditorUtility.SetDialogOptOutDecision(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetDialogOptOutDecision", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DisplayPopupMenu(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayPopupMenu", typeof(UnityEngine.Rect), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayPopupMenu", typeof(string), 1);
                    }
                    UnityEditor.MenuCommand arg2;
                    if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayPopupMenu", typeof(UnityEditor.MenuCommand), 2);
                    }
                    UnityEditor.EditorUtility.DisplayPopupMenu(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DisplayPopupMenu", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DisplayCustomMenu(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 7)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayCustomMenu", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.GUIContent[] arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayCustomMenu", typeof(UnityEngine.GUIContent[]), 1);
                        }
                        System.Func<int, bool> arg2;
                        if (!Values.js_get_delegate(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayCustomMenu", typeof(System.Func<int, bool>), 2);
                        }
                        int arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayCustomMenu", typeof(int), 3);
                        }
                        UnityEditor.EditorUtility.SelectMenuItemFunction arg4;
                        if (!Values.js_get_delegate(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayCustomMenu", typeof(UnityEditor.EditorUtility.SelectMenuItemFunction), 4);
                        }
                        object arg5;
                        if (!Values.js_get_var(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayCustomMenu", typeof(object), 5);
                        }
                        bool arg6;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayCustomMenu", typeof(bool), 6);
                        }
                        UnityEditor.EditorUtility.DisplayCustomMenu(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 6)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayCustomMenu", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.GUIContent[] arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayCustomMenu", typeof(UnityEngine.GUIContent[]), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayCustomMenu", typeof(int), 2);
                        }
                        UnityEditor.EditorUtility.SelectMenuItemFunction arg3;
                        if (!Values.js_get_delegate(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayCustomMenu", typeof(UnityEditor.EditorUtility.SelectMenuItemFunction), 3);
                        }
                        object arg4;
                        if (!Values.js_get_var(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayCustomMenu", typeof(object), 4);
                        }
                        bool arg5;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayCustomMenu", typeof(bool), 5);
                        }
                        UnityEditor.EditorUtility.DisplayCustomMenu(arg0, arg1, arg2, arg3, arg4, arg5);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 5)
                    {
                        UnityEngine.Rect arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayCustomMenu", typeof(UnityEngine.Rect), 0);
                        }
                        UnityEngine.GUIContent[] arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayCustomMenu", typeof(UnityEngine.GUIContent[]), 1);
                        }
                        int arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayCustomMenu", typeof(int), 2);
                        }
                        UnityEditor.EditorUtility.SelectMenuItemFunction arg3;
                        if (!Values.js_get_delegate(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayCustomMenu", typeof(UnityEditor.EditorUtility.SelectMenuItemFunction), 3);
                        }
                        object arg4;
                        if (!Values.js_get_var(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayCustomMenu", typeof(object), 4);
                        }
                        UnityEditor.EditorUtility.DisplayCustomMenu(arg0, arg1, arg2, arg3, arg4);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("DisplayCustomMenu", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CreateGameObjectWithHideFlags(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc >= 2)
                {
                    if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.HideFlags)) && Values.js_match_param_types(ctx, 2, argv, typeof(System.Type)))
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "CreateGameObjectWithHideFlags", typeof(string), 0);
                        }
                        UnityEngine.HideFlags arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "CreateGameObjectWithHideFlags", typeof(UnityEngine.HideFlags), 1);
                        }
                        System.Type[] arg2 = null;
                        if (argc - 2 > 0)
                        {
                            arg2 = new System.Type[argc - 2];
                            for (var i = 2; i < argc; i++)
                            {
                                QuickJS.Binding.Values.js_get_classvalue(ctx, argv[i], out arg2[i - 2]);
                            }
                        }
                        var ret = UnityEditor.EditorUtility.CreateGameObjectWithHideFlags(arg0, arg1, arg2);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                }
                throw new NoSuitableMethodException("CreateGameObjectWithHideFlags", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DisplayCustomMenuWithSeparators(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 7)
                {
                    UnityEngine.Rect arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayCustomMenuWithSeparators", typeof(UnityEngine.Rect), 0);
                    }
                    string[] arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayCustomMenuWithSeparators", typeof(string[]), 1);
                    }
                    bool[] arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayCustomMenuWithSeparators", typeof(bool[]), 2);
                    }
                    bool[] arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayCustomMenuWithSeparators", typeof(bool[]), 3);
                    }
                    int[] arg4;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayCustomMenuWithSeparators", typeof(int[]), 4);
                    }
                    UnityEditor.EditorUtility.SelectMenuItemFunction arg5;
                    if (!Values.js_get_delegate(ctx, argv[5], out arg5))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayCustomMenuWithSeparators", typeof(UnityEditor.EditorUtility.SelectMenuItemFunction), 5);
                    }
                    object arg6;
                    if (!Values.js_get_var(ctx, argv[6], out arg6))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "DisplayCustomMenuWithSeparators", typeof(object), 6);
                    }
                    UnityEditor.EditorUtility.DisplayCustomMenuWithSeparators(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DisplayCustomMenuWithSeparators", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetCustomDiffTool(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 5)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "SetCustomDiffTool", typeof(string), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "SetCustomDiffTool", typeof(string), 1);
                    }
                    string arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "SetCustomDiffTool", typeof(string), 2);
                    }
                    string arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "SetCustomDiffTool", typeof(string), 3);
                    }
                    bool arg4;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "SetCustomDiffTool", typeof(bool), 4);
                    }
                    UnityEditor.EditorUtility.SetCustomDiffTool(arg0, arg1, arg2, arg3, arg4);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetCustomDiffTool", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetDefaultParentObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "SetDefaultParentObject", typeof(UnityEngine.GameObject), 0);
                    }
                    UnityEditor.EditorUtility.SetDefaultParentObject(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetDefaultParentObject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ClearDefaultParentObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        UnityEngine.SceneManagement.Scene arg0;
                        if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorUtility), "ClearDefaultParentObject", typeof(UnityEngine.SceneManagement.Scene), 0);
                        }
                        UnityEditor.EditorUtility.ClearDefaultParentObject(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 0)
                    {
                        UnityEditor.EditorUtility.ClearDefaultParentObject();
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("ClearDefaultParentObject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_OpenPropertyEditor(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorUtility), "OpenPropertyEditor", typeof(UnityEngine.Object), 0);
                    }
                    UnityEditor.EditorUtility.OpenPropertyEditor(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("OpenPropertyEditor", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_audioMasterMute(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUtility.audioMasterMute;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_audioMasterMute(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorUtility), "audioMasterMute", typeof(bool), 0);
                }
                UnityEditor.EditorUtility.audioMasterMute = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_scriptCompilationFailed(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorUtility.scriptCompilationFailed;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("EditorUtility", typeof(UnityEditor.EditorUtility), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "OpenFilePanel", BindStatic_OpenFilePanel);
            cls.AddMethod(true, "OpenFilePanelWithFilters", BindStatic_OpenFilePanelWithFilters);
            cls.AddMethod(true, "RevealInFinder", BindStatic_RevealInFinder);
            cls.AddMethod(true, "DisplayDialog", BindStatic_DisplayDialog);
            cls.AddMethod(true, "DisplayDialogComplex", BindStatic_DisplayDialogComplex);
            cls.AddMethod(true, "OpenFolderPanel", BindStatic_OpenFolderPanel);
            cls.AddMethod(true, "SaveFolderPanel", BindStatic_SaveFolderPanel);
            cls.AddMethod(true, "WarnPrefab", BindStatic_WarnPrefab);
            cls.AddMethod(true, "IsPersistent", BindStatic_IsPersistent);
            cls.AddMethod(true, "SaveFilePanel", BindStatic_SaveFilePanel);
            cls.AddMethod(true, "NaturalCompare", BindStatic_NaturalCompare);
            cls.AddMethod(true, "InstanceIDToObject", BindStatic_InstanceIDToObject);
            cls.AddMethod(true, "CompressTexture", BindStatic_CompressTexture);
            cls.AddMethod(true, "CompressCubemapTexture", BindStatic_CompressCubemapTexture);
            cls.AddMethod(true, "SetDirty", BindStatic_SetDirty);
            cls.AddMethod(true, "ClearDirty", BindStatic_ClearDirty);
            cls.AddMethod(true, "InvokeDiffTool", BindStatic_InvokeDiffTool);
            cls.AddMethod(true, "CopySerialized", BindStatic_CopySerialized);
            cls.AddMethod(true, "CopySerializedManagedFieldsOnly", BindStatic_CopySerializedManagedFieldsOnly);
            cls.AddMethod(true, "CollectDependencies", BindStatic_CollectDependencies);
            cls.AddMethod(true, "CollectDeepHierarchy", BindStatic_CollectDeepHierarchy);
            cls.AddMethod(true, "FormatBytes", BindStatic_FormatBytes);
            cls.AddMethod(true, "DisplayProgressBar", BindStatic_DisplayProgressBar);
            cls.AddMethod(true, "DisplayCancelableProgressBar", BindStatic_DisplayCancelableProgressBar);
            cls.AddMethod(true, "ClearProgressBar", BindStatic_ClearProgressBar);
            cls.AddMethod(true, "GetObjectEnabled", BindStatic_GetObjectEnabled);
            cls.AddMethod(true, "SetObjectEnabled", BindStatic_SetObjectEnabled);
            cls.AddMethod(true, "SetSelectedRenderState", BindStatic_SetSelectedRenderState);
            cls.AddMethod(true, "OpenWithDefaultApp", BindStatic_OpenWithDefaultApp);
            cls.AddMethod(true, "SetCameraAnimateMaterials", BindStatic_SetCameraAnimateMaterials);
            cls.AddMethod(true, "SetCameraAnimateMaterialsTime", BindStatic_SetCameraAnimateMaterialsTime);
            cls.AddMethod(true, "UpdateGlobalShaderProperties", BindStatic_UpdateGlobalShaderProperties);
            cls.AddMethod(true, "GetDirtyCount", BindStatic_GetDirtyCount);
            cls.AddMethod(true, "IsDirty", BindStatic_IsDirty);
            cls.AddMethod(true, "FocusProjectWindow", BindStatic_FocusProjectWindow);
            cls.AddMethod(true, "RequestScriptReload", BindStatic_RequestScriptReload);
            cls.AddMethod(true, "IsRunningUnderCPUEmulation", BindStatic_IsRunningUnderCPUEmulation);
            cls.AddMethod(true, "LoadWindowLayout", BindStatic_LoadWindowLayout);
            cls.AddMethod(true, "SaveFilePanelInProject", BindStatic_SaveFilePanelInProject);
            cls.AddMethod(true, "CopySerializedIfDifferent", BindStatic_CopySerializedIfDifferent);
            cls.AddMethod(true, "UnloadUnusedAssetsImmediate", BindStatic_UnloadUnusedAssetsImmediate);
            cls.AddMethod(true, "GetDialogOptOutDecision", BindStatic_GetDialogOptOutDecision);
            cls.AddMethod(true, "SetDialogOptOutDecision", BindStatic_SetDialogOptOutDecision);
            cls.AddMethod(true, "DisplayPopupMenu", BindStatic_DisplayPopupMenu);
            cls.AddMethod(true, "DisplayCustomMenu", BindStatic_DisplayCustomMenu);
            cls.AddMethod(true, "CreateGameObjectWithHideFlags", BindStatic_CreateGameObjectWithHideFlags);
            cls.AddMethod(true, "DisplayCustomMenuWithSeparators", BindStatic_DisplayCustomMenuWithSeparators);
            cls.AddMethod(true, "SetCustomDiffTool", BindStatic_SetCustomDiffTool);
            cls.AddMethod(true, "SetDefaultParentObject", BindStatic_SetDefaultParentObject);
            cls.AddMethod(true, "ClearDefaultParentObject", BindStatic_ClearDefaultParentObject);
            cls.AddMethod(true, "OpenPropertyEditor", BindStatic_OpenPropertyEditor);
            cls.AddProperty(true, "audioMasterMute", BindStaticRead_audioMasterMute, BindStaticWrite_audioMasterMute);
            cls.AddProperty(true, "scriptCompilationFailed", BindStaticRead_scriptCompilationFailed, null);
            return cls;
        }
    }
}
#endif
#endif
