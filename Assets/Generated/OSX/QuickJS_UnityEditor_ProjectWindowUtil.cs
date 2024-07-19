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
    // Type: UnityEditor.ProjectWindowUtil
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_ProjectWindowUtil
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new UnityEditor.ProjectWindowUtil();
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
        public static JSValue BindStatic_CreateNewGUISkin(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.ProjectWindowUtil.CreateNewGUISkin();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CreateNewGUISkin", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CreateAsset(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ProjectWindowUtil), "CreateAsset", typeof(UnityEngine.Object), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.ProjectWindowUtil), "CreateAsset", typeof(string), 1);
                    }
                    UnityEditor.ProjectWindowUtil.CreateAsset(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CreateAsset", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CreateFolder(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.ProjectWindowUtil.CreateFolder();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CreateFolder", argc);
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
                if (argc == 0)
                {
                    UnityEditor.ProjectWindowUtil.CreateScene();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CreateScene", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CreateAssetWithContent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ProjectWindowUtil), "CreateAssetWithContent", typeof(string), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.ProjectWindowUtil), "CreateAssetWithContent", typeof(string), 1);
                    }
                    UnityEngine.Texture2D arg2;
                    if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.ProjectWindowUtil), "CreateAssetWithContent", typeof(UnityEngine.Texture2D), 2);
                    }
                    UnityEditor.ProjectWindowUtil.CreateAssetWithContent(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CreateAssetWithContent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CreateScriptAssetFromTemplateFile(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ProjectWindowUtil), "CreateScriptAssetFromTemplateFile", typeof(string), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.ProjectWindowUtil), "CreateScriptAssetFromTemplateFile", typeof(string), 1);
                    }
                    UnityEditor.ProjectWindowUtil.CreateScriptAssetFromTemplateFile(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CreateScriptAssetFromTemplateFile", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ShowCreatedAsset(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ProjectWindowUtil), "ShowCreatedAsset", typeof(UnityEngine.Object), 0);
                    }
                    UnityEditor.ProjectWindowUtil.ShowCreatedAsset(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ShowCreatedAsset", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_StartNameEditingIfProjectWindowExists(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 5)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ProjectWindowUtil), "StartNameEditingIfProjectWindowExists", typeof(int), 0);
                    }
                    UnityEditor.ProjectWindowCallback.EndNameEditAction arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.ProjectWindowUtil), "StartNameEditingIfProjectWindowExists", typeof(UnityEditor.ProjectWindowCallback.EndNameEditAction), 1);
                    }
                    string arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.ProjectWindowUtil), "StartNameEditingIfProjectWindowExists", typeof(string), 2);
                    }
                    UnityEngine.Texture2D arg3;
                    if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.ProjectWindowUtil), "StartNameEditingIfProjectWindowExists", typeof(UnityEngine.Texture2D), 3);
                    }
                    string arg4;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.ProjectWindowUtil), "StartNameEditingIfProjectWindowExists", typeof(string), 4);
                    }
                    UnityEditor.ProjectWindowUtil.StartNameEditingIfProjectWindowExists(arg0, arg1, arg2, arg3, arg4);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("StartNameEditingIfProjectWindowExists", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetAncestors(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ProjectWindowUtil), "GetAncestors", typeof(int), 0);
                    }
                    var ret = UnityEditor.ProjectWindowUtil.GetAncestors(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetAncestors", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsFolder(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ProjectWindowUtil), "IsFolder", typeof(int), 0);
                    }
                    var ret = UnityEditor.ProjectWindowUtil.IsFolder(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsFolder", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetContainingFolder(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ProjectWindowUtil), "GetContainingFolder", typeof(string), 0);
                    }
                    var ret = UnityEditor.ProjectWindowUtil.GetContainingFolder(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetContainingFolder", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetBaseFolders(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string[] arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ProjectWindowUtil), "GetBaseFolders", typeof(string[]), 0);
                    }
                    var ret = UnityEditor.ProjectWindowUtil.GetBaseFolders(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetBaseFolders", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("ProjectWindowUtil", typeof(UnityEditor.ProjectWindowUtil), BindConstructor);
            cls.AddMethod(true, "CreateNewGUISkin", BindStatic_CreateNewGUISkin);
            cls.AddMethod(true, "CreateAsset", BindStatic_CreateAsset);
            cls.AddMethod(true, "CreateFolder", BindStatic_CreateFolder);
            cls.AddMethod(true, "CreateScene", BindStatic_CreateScene);
            cls.AddMethod(true, "CreateAssetWithContent", BindStatic_CreateAssetWithContent);
            cls.AddMethod(true, "CreateScriptAssetFromTemplateFile", BindStatic_CreateScriptAssetFromTemplateFile);
            cls.AddMethod(true, "ShowCreatedAsset", BindStatic_ShowCreatedAsset);
            cls.AddMethod(true, "StartNameEditingIfProjectWindowExists", BindStatic_StartNameEditingIfProjectWindowExists);
            cls.AddMethod(true, "GetAncestors", BindStatic_GetAncestors);
            cls.AddMethod(true, "IsFolder", BindStatic_IsFolder);
            cls.AddMethod(true, "GetContainingFolder", BindStatic_GetContainingFolder);
            cls.AddMethod(true, "GetBaseFolders", BindStatic_GetBaseFolders);
            return cls;
        }
    }
}
#endif
#endif
