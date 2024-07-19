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
    // Type: UnityEditor.PrefabUtility
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_PrefabUtility
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetPrefabInstanceHandle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "GetPrefabInstanceHandle", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.PrefabUtility.GetPrefabInstanceHandle(arg0);
                    return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetPrefabInstanceHandle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetPropertyModifications(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "GetPropertyModifications", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.PrefabUtility.GetPropertyModifications(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetPropertyModifications", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetPropertyModifications(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "SetPropertyModifications", typeof(UnityEngine.Object), 0);
                    }
                    UnityEditor.PropertyModification[] arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "SetPropertyModifications", typeof(UnityEditor.PropertyModification[]), 1);
                    }
                    UnityEditor.PrefabUtility.SetPropertyModifications(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetPropertyModifications", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_HasPrefabInstanceAnyOverrides(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "HasPrefabInstanceAnyOverrides", typeof(UnityEngine.GameObject), 0);
                    }
                    bool arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "HasPrefabInstanceAnyOverrides", typeof(bool), 1);
                    }
                    var ret = UnityEditor.PrefabUtility.HasPrefabInstanceAnyOverrides(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("HasPrefabInstanceAnyOverrides", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_InstantiateAttachedAsset(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "InstantiateAttachedAsset", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.PrefabUtility.InstantiateAttachedAsset(arg0);
                    return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("InstantiateAttachedAsset", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RecordPrefabInstancePropertyModifications(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "RecordPrefabInstancePropertyModifications", typeof(UnityEngine.Object), 0);
                    }
                    UnityEditor.PrefabUtility.RecordPrefabInstancePropertyModifications(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RecordPrefabInstancePropertyModifications", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_UnpackPrefabInstanceAndReturnNewOutermostRoots(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "UnpackPrefabInstanceAndReturnNewOutermostRoots", typeof(UnityEngine.GameObject), 0);
                    }
                    UnityEditor.PrefabUnpackMode arg1;
                    if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "UnpackPrefabInstanceAndReturnNewOutermostRoots", typeof(UnityEditor.PrefabUnpackMode), 1);
                    }
                    var ret = UnityEditor.PrefabUtility.UnpackPrefabInstanceAndReturnNewOutermostRoots(arg0, arg1);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("UnpackPrefabInstanceAndReturnNewOutermostRoots", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LoadPrefabContentsIntoPreviewScene(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "LoadPrefabContentsIntoPreviewScene", typeof(string), 0);
                    }
                    UnityEngine.SceneManagement.Scene arg1;
                    if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "LoadPrefabContentsIntoPreviewScene", typeof(UnityEngine.SceneManagement.Scene), 1);
                    }
                    UnityEditor.PrefabUtility.LoadPrefabContentsIntoPreviewScene(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("LoadPrefabContentsIntoPreviewScene", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsAddedComponentOverride(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "IsAddedComponentOverride", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.PrefabUtility.IsAddedComponentOverride(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsAddedComponentOverride", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsPartOfAnyPrefab(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "IsPartOfAnyPrefab", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.PrefabUtility.IsPartOfAnyPrefab(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsPartOfAnyPrefab", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsPartOfPrefabAsset(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "IsPartOfPrefabAsset", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.PrefabUtility.IsPartOfPrefabAsset(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsPartOfPrefabAsset", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsPartOfPrefabInstance(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "IsPartOfPrefabInstance", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.PrefabUtility.IsPartOfPrefabInstance(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsPartOfPrefabInstance", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsPartOfNonAssetPrefabInstance(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "IsPartOfNonAssetPrefabInstance", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.PrefabUtility.IsPartOfNonAssetPrefabInstance(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsPartOfNonAssetPrefabInstance", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsPartOfRegularPrefab(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "IsPartOfRegularPrefab", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.PrefabUtility.IsPartOfRegularPrefab(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsPartOfRegularPrefab", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsPartOfModelPrefab(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "IsPartOfModelPrefab", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.PrefabUtility.IsPartOfModelPrefab(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsPartOfModelPrefab", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsPartOfVariantPrefab(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "IsPartOfVariantPrefab", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.PrefabUtility.IsPartOfVariantPrefab(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsPartOfVariantPrefab", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsPartOfImmutablePrefab(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "IsPartOfImmutablePrefab", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.PrefabUtility.IsPartOfImmutablePrefab(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsPartOfImmutablePrefab", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsDisconnectedFromPrefabAsset(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "IsDisconnectedFromPrefabAsset", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.PrefabUtility.IsDisconnectedFromPrefabAsset(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsDisconnectedFromPrefabAsset", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsPrefabAssetMissing(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "IsPrefabAssetMissing", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.PrefabUtility.IsPrefabAssetMissing(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsPrefabAssetMissing", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetOutermostPrefabInstanceRoot(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "GetOutermostPrefabInstanceRoot", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.PrefabUtility.GetOutermostPrefabInstanceRoot(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetOutermostPrefabInstanceRoot", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetNearestPrefabInstanceRoot(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "GetNearestPrefabInstanceRoot", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.PrefabUtility.GetNearestPrefabInstanceRoot(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetNearestPrefabInstanceRoot", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsDefaultOverride(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.PropertyModification arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "IsDefaultOverride", typeof(UnityEditor.PropertyModification), 0);
                    }
                    var ret = UnityEditor.PrefabUtility.IsDefaultOverride(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsDefaultOverride", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RevertPrefabInstance(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "RevertPrefabInstance", typeof(UnityEngine.GameObject), 0);
                    }
                    UnityEditor.InteractionMode arg1;
                    if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "RevertPrefabInstance", typeof(UnityEditor.InteractionMode), 1);
                    }
                    UnityEditor.PrefabUtility.RevertPrefabInstance(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RevertPrefabInstance", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ApplyPrefabInstance(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "ApplyPrefabInstance", typeof(UnityEngine.GameObject), 0);
                    }
                    UnityEditor.InteractionMode arg1;
                    if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "ApplyPrefabInstance", typeof(UnityEditor.InteractionMode), 1);
                    }
                    UnityEditor.PrefabUtility.ApplyPrefabInstance(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ApplyPrefabInstance", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ApplyPropertyOverride(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEditor.SerializedProperty arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "ApplyPropertyOverride", typeof(UnityEditor.SerializedProperty), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "ApplyPropertyOverride", typeof(string), 1);
                    }
                    UnityEditor.InteractionMode arg2;
                    if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "ApplyPropertyOverride", typeof(UnityEditor.InteractionMode), 2);
                    }
                    UnityEditor.PrefabUtility.ApplyPropertyOverride(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ApplyPropertyOverride", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RevertPropertyOverride(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.SerializedProperty arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "RevertPropertyOverride", typeof(UnityEditor.SerializedProperty), 0);
                    }
                    UnityEditor.InteractionMode arg1;
                    if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "RevertPropertyOverride", typeof(UnityEditor.InteractionMode), 1);
                    }
                    UnityEditor.PrefabUtility.RevertPropertyOverride(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RevertPropertyOverride", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ApplyObjectOverride(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "ApplyObjectOverride", typeof(UnityEngine.Object), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "ApplyObjectOverride", typeof(string), 1);
                    }
                    UnityEditor.InteractionMode arg2;
                    if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "ApplyObjectOverride", typeof(UnityEditor.InteractionMode), 2);
                    }
                    UnityEditor.PrefabUtility.ApplyObjectOverride(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ApplyObjectOverride", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RevertObjectOverride(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "RevertObjectOverride", typeof(UnityEngine.Object), 0);
                    }
                    UnityEditor.InteractionMode arg1;
                    if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "RevertObjectOverride", typeof(UnityEditor.InteractionMode), 1);
                    }
                    UnityEditor.PrefabUtility.RevertObjectOverride(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RevertObjectOverride", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ApplyAddedComponent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Component arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "ApplyAddedComponent", typeof(UnityEngine.Component), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "ApplyAddedComponent", typeof(string), 1);
                    }
                    UnityEditor.InteractionMode arg2;
                    if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "ApplyAddedComponent", typeof(UnityEditor.InteractionMode), 2);
                    }
                    UnityEditor.PrefabUtility.ApplyAddedComponent(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ApplyAddedComponent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RevertAddedComponent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Component arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "RevertAddedComponent", typeof(UnityEngine.Component), 0);
                    }
                    UnityEditor.InteractionMode arg1;
                    if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "RevertAddedComponent", typeof(UnityEditor.InteractionMode), 1);
                    }
                    UnityEditor.PrefabUtility.RevertAddedComponent(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RevertAddedComponent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ApplyRemovedComponent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "ApplyRemovedComponent", typeof(UnityEngine.GameObject), 0);
                    }
                    UnityEngine.Component arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "ApplyRemovedComponent", typeof(UnityEngine.Component), 1);
                    }
                    UnityEditor.InteractionMode arg2;
                    if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "ApplyRemovedComponent", typeof(UnityEditor.InteractionMode), 2);
                    }
                    UnityEditor.PrefabUtility.ApplyRemovedComponent(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ApplyRemovedComponent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RevertRemovedComponent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "RevertRemovedComponent", typeof(UnityEngine.GameObject), 0);
                    }
                    UnityEngine.Component arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "RevertRemovedComponent", typeof(UnityEngine.Component), 1);
                    }
                    UnityEditor.InteractionMode arg2;
                    if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "RevertRemovedComponent", typeof(UnityEditor.InteractionMode), 2);
                    }
                    UnityEditor.PrefabUtility.RevertRemovedComponent(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RevertRemovedComponent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ApplyAddedGameObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "ApplyAddedGameObject", typeof(UnityEngine.GameObject), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "ApplyAddedGameObject", typeof(string), 1);
                    }
                    UnityEditor.InteractionMode arg2;
                    if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "ApplyAddedGameObject", typeof(UnityEditor.InteractionMode), 2);
                    }
                    UnityEditor.PrefabUtility.ApplyAddedGameObject(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ApplyAddedGameObject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RevertAddedGameObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "RevertAddedGameObject", typeof(UnityEngine.GameObject), 0);
                    }
                    UnityEditor.InteractionMode arg1;
                    if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "RevertAddedGameObject", typeof(UnityEditor.InteractionMode), 1);
                    }
                    UnityEditor.PrefabUtility.RevertAddedGameObject(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RevertAddedGameObject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetObjectOverrides(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "GetObjectOverrides", typeof(UnityEngine.GameObject), 0);
                    }
                    bool arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "GetObjectOverrides", typeof(bool), 1);
                    }
                    var ret = UnityEditor.PrefabUtility.GetObjectOverrides(arg0, arg1);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetObjectOverrides", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetAddedComponents(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "GetAddedComponents", typeof(UnityEngine.GameObject), 0);
                    }
                    var ret = UnityEditor.PrefabUtility.GetAddedComponents(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetAddedComponents", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetRemovedComponents(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "GetRemovedComponents", typeof(UnityEngine.GameObject), 0);
                    }
                    var ret = UnityEditor.PrefabUtility.GetRemovedComponents(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetRemovedComponents", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetAddedGameObjects(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "GetAddedGameObjects", typeof(UnityEngine.GameObject), 0);
                    }
                    var ret = UnityEditor.PrefabUtility.GetAddedGameObjects(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetAddedGameObjects", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsAnyPrefabInstanceRoot(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "IsAnyPrefabInstanceRoot", typeof(UnityEngine.GameObject), 0);
                    }
                    var ret = UnityEditor.PrefabUtility.IsAnyPrefabInstanceRoot(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsAnyPrefabInstanceRoot", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsOutermostPrefabInstanceRoot(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "IsOutermostPrefabInstanceRoot", typeof(UnityEngine.GameObject), 0);
                    }
                    var ret = UnityEditor.PrefabUtility.IsOutermostPrefabInstanceRoot(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsOutermostPrefabInstanceRoot", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetPrefabAssetPathOfNearestInstanceRoot(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "GetPrefabAssetPathOfNearestInstanceRoot", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.PrefabUtility.GetPrefabAssetPathOfNearestInstanceRoot(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetPrefabAssetPathOfNearestInstanceRoot", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetIconForGameObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "GetIconForGameObject", typeof(UnityEngine.GameObject), 0);
                    }
                    var ret = UnityEditor.PrefabUtility.GetIconForGameObject(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetIconForGameObject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SavePrefabAsset(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEngine.GameObject arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.PrefabUtility), "SavePrefabAsset", typeof(UnityEngine.GameObject), 0);
                        }
                        bool arg1;
                        var ret = UnityEditor.PrefabUtility.SavePrefabAsset(arg0, out arg1);
                        var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg1);
                        if (JSApi.JS_IsException(out0))
                        {
                            return out0;
                        }
                        var context = ScriptEngine.GetContext(ctx);
                        JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        UnityEngine.GameObject arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.PrefabUtility), "SavePrefabAsset", typeof(UnityEngine.GameObject), 0);
                        }
                        var ret = UnityEditor.PrefabUtility.SavePrefabAsset(arg0);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("SavePrefabAsset", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SaveAsPrefabAsset(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        UnityEngine.GameObject arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.PrefabUtility), "SaveAsPrefabAsset", typeof(UnityEngine.GameObject), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.PrefabUtility), "SaveAsPrefabAsset", typeof(string), 1);
                        }
                        bool arg2;
                        var ret = UnityEditor.PrefabUtility.SaveAsPrefabAsset(arg0, arg1, out arg2);
                        var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg2);
                        if (JSApi.JS_IsException(out0))
                        {
                            return out0;
                        }
                        var context = ScriptEngine.GetContext(ctx);
                        JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out0);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        UnityEngine.GameObject arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.PrefabUtility), "SaveAsPrefabAsset", typeof(UnityEngine.GameObject), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.PrefabUtility), "SaveAsPrefabAsset", typeof(string), 1);
                        }
                        var ret = UnityEditor.PrefabUtility.SaveAsPrefabAsset(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("SaveAsPrefabAsset", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SaveAsPrefabAssetAndConnect(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 4)
                    {
                        UnityEngine.GameObject arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.PrefabUtility), "SaveAsPrefabAssetAndConnect", typeof(UnityEngine.GameObject), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.PrefabUtility), "SaveAsPrefabAssetAndConnect", typeof(string), 1);
                        }
                        UnityEditor.InteractionMode arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.PrefabUtility), "SaveAsPrefabAssetAndConnect", typeof(UnityEditor.InteractionMode), 2);
                        }
                        bool arg3;
                        var ret = UnityEditor.PrefabUtility.SaveAsPrefabAssetAndConnect(arg0, arg1, arg2, out arg3);
                        var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg3);
                        if (JSApi.JS_IsException(out0))
                        {
                            return out0;
                        }
                        var context = ScriptEngine.GetContext(ctx);
                        JSApi.JS_SetProperty(ctx, argv[3], context.GetAtom("value"), out0);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        UnityEngine.GameObject arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.PrefabUtility), "SaveAsPrefabAssetAndConnect", typeof(UnityEngine.GameObject), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.PrefabUtility), "SaveAsPrefabAssetAndConnect", typeof(string), 1);
                        }
                        UnityEditor.InteractionMode arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.PrefabUtility), "SaveAsPrefabAssetAndConnect", typeof(UnityEditor.InteractionMode), 2);
                        }
                        var ret = UnityEditor.PrefabUtility.SaveAsPrefabAssetAndConnect(arg0, arg1, arg2);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("SaveAsPrefabAssetAndConnect", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_InstantiatePrefab(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.SceneManagement.Scene)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PrefabUtility), "InstantiatePrefab", typeof(UnityEngine.Object), 0);
                            }
                            UnityEngine.SceneManagement.Scene arg1;
                            if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PrefabUtility), "InstantiatePrefab", typeof(UnityEngine.SceneManagement.Scene), 1);
                            }
                            var ret = UnityEditor.PrefabUtility.InstantiatePrefab(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Transform)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.PrefabUtility), "InstantiatePrefab", typeof(UnityEngine.Object), 0);
                            }
                            UnityEngine.Transform arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.PrefabUtility), "InstantiatePrefab", typeof(UnityEngine.Transform), 1);
                            }
                            var ret = UnityEditor.PrefabUtility.InstantiatePrefab(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Object arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.PrefabUtility), "InstantiatePrefab", typeof(UnityEngine.Object), 0);
                        }
                        var ret = UnityEditor.PrefabUtility.InstantiatePrefab(arg0);
                        return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("InstantiatePrefab", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsAddedGameObjectOverride(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "IsAddedGameObjectOverride", typeof(UnityEngine.GameObject), 0);
                    }
                    var ret = UnityEditor.PrefabUtility.IsAddedGameObjectOverride(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsAddedGameObjectOverride", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_UnpackPrefabInstance(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "UnpackPrefabInstance", typeof(UnityEngine.GameObject), 0);
                    }
                    UnityEditor.PrefabUnpackMode arg1;
                    if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "UnpackPrefabInstance", typeof(UnityEditor.PrefabUnpackMode), 1);
                    }
                    UnityEditor.InteractionMode arg2;
                    if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "UnpackPrefabInstance", typeof(UnityEditor.InteractionMode), 2);
                    }
                    UnityEditor.PrefabUtility.UnpackPrefabInstance(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("UnpackPrefabInstance", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsPartOfPrefabThatCanBeAppliedTo(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "IsPartOfPrefabThatCanBeAppliedTo", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.PrefabUtility.IsPartOfPrefabThatCanBeAppliedTo(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsPartOfPrefabThatCanBeAppliedTo", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetPrefabInstanceStatus(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "GetPrefabInstanceStatus", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.PrefabUtility.GetPrefabInstanceStatus(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                }
                throw new NoSuitableMethodException("GetPrefabInstanceStatus", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetPrefabAssetType(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "GetPrefabAssetType", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.PrefabUtility.GetPrefabAssetType(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                }
                throw new NoSuitableMethodException("GetPrefabAssetType", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LoadPrefabContents(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "LoadPrefabContents", typeof(string), 0);
                    }
                    var ret = UnityEditor.PrefabUtility.LoadPrefabContents(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("LoadPrefabContents", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_UnloadPrefabContents(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PrefabUtility), "UnloadPrefabContents", typeof(UnityEngine.GameObject), 0);
                    }
                    UnityEditor.PrefabUtility.UnloadPrefabContents(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("UnloadPrefabContents", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticDelegate_prefabInstanceUpdated(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                    {
                        UnityEditor.PrefabUtility.PrefabInstanceUpdated value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.PrefabUtility), "prefabInstanceUpdated", typeof(UnityEditor.PrefabUtility.PrefabInstanceUpdated), 1);
                        }
                        UnityEditor.PrefabUtility.prefabInstanceUpdated += value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_REMOVE:
                    {
                        UnityEditor.PrefabUtility.PrefabInstanceUpdated value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.PrefabUtility), "prefabInstanceUpdated", typeof(UnityEditor.PrefabUtility.PrefabInstanceUpdated), 1);
                        }
                        UnityEditor.PrefabUtility.prefabInstanceUpdated -= value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_SET:
                    {
                        UnityEditor.PrefabUtility.PrefabInstanceUpdated value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.PrefabUtility), "prefabInstanceUpdated", typeof(UnityEditor.PrefabUtility.PrefabInstanceUpdated), 1);
                        }
                        UnityEditor.PrefabUtility.prefabInstanceUpdated = value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_GET:
                    {
                        var ret = UnityEditor.PrefabUtility.prefabInstanceUpdated;
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
            var cls = register.CreateClass("PrefabUtility", typeof(UnityEditor.PrefabUtility), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "GetPrefabInstanceHandle", BindStatic_GetPrefabInstanceHandle);
            cls.AddMethod(true, "GetPropertyModifications", BindStatic_GetPropertyModifications);
            cls.AddMethod(true, "SetPropertyModifications", BindStatic_SetPropertyModifications);
            cls.AddMethod(true, "HasPrefabInstanceAnyOverrides", BindStatic_HasPrefabInstanceAnyOverrides);
            cls.AddMethod(true, "InstantiateAttachedAsset", BindStatic_InstantiateAttachedAsset);
            cls.AddMethod(true, "RecordPrefabInstancePropertyModifications", BindStatic_RecordPrefabInstancePropertyModifications);
            cls.AddMethod(true, "UnpackPrefabInstanceAndReturnNewOutermostRoots", BindStatic_UnpackPrefabInstanceAndReturnNewOutermostRoots);
            cls.AddMethod(true, "LoadPrefabContentsIntoPreviewScene", BindStatic_LoadPrefabContentsIntoPreviewScene);
            cls.AddMethod(true, "IsAddedComponentOverride", BindStatic_IsAddedComponentOverride);
            cls.AddMethod(true, "IsPartOfAnyPrefab", BindStatic_IsPartOfAnyPrefab);
            cls.AddMethod(true, "IsPartOfPrefabAsset", BindStatic_IsPartOfPrefabAsset);
            cls.AddMethod(true, "IsPartOfPrefabInstance", BindStatic_IsPartOfPrefabInstance);
            cls.AddMethod(true, "IsPartOfNonAssetPrefabInstance", BindStatic_IsPartOfNonAssetPrefabInstance);
            cls.AddMethod(true, "IsPartOfRegularPrefab", BindStatic_IsPartOfRegularPrefab);
            cls.AddMethod(true, "IsPartOfModelPrefab", BindStatic_IsPartOfModelPrefab);
            cls.AddMethod(true, "IsPartOfVariantPrefab", BindStatic_IsPartOfVariantPrefab);
            cls.AddMethod(true, "IsPartOfImmutablePrefab", BindStatic_IsPartOfImmutablePrefab);
            cls.AddMethod(true, "IsDisconnectedFromPrefabAsset", BindStatic_IsDisconnectedFromPrefabAsset);
            cls.AddMethod(true, "IsPrefabAssetMissing", BindStatic_IsPrefabAssetMissing);
            cls.AddMethod(true, "GetOutermostPrefabInstanceRoot", BindStatic_GetOutermostPrefabInstanceRoot);
            cls.AddMethod(true, "GetNearestPrefabInstanceRoot", BindStatic_GetNearestPrefabInstanceRoot);
            cls.AddMethod(true, "IsDefaultOverride", BindStatic_IsDefaultOverride);
            cls.AddMethod(true, "RevertPrefabInstance", BindStatic_RevertPrefabInstance);
            cls.AddMethod(true, "ApplyPrefabInstance", BindStatic_ApplyPrefabInstance);
            cls.AddMethod(true, "ApplyPropertyOverride", BindStatic_ApplyPropertyOverride);
            cls.AddMethod(true, "RevertPropertyOverride", BindStatic_RevertPropertyOverride);
            cls.AddMethod(true, "ApplyObjectOverride", BindStatic_ApplyObjectOverride);
            cls.AddMethod(true, "RevertObjectOverride", BindStatic_RevertObjectOverride);
            cls.AddMethod(true, "ApplyAddedComponent", BindStatic_ApplyAddedComponent);
            cls.AddMethod(true, "RevertAddedComponent", BindStatic_RevertAddedComponent);
            cls.AddMethod(true, "ApplyRemovedComponent", BindStatic_ApplyRemovedComponent);
            cls.AddMethod(true, "RevertRemovedComponent", BindStatic_RevertRemovedComponent);
            cls.AddMethod(true, "ApplyAddedGameObject", BindStatic_ApplyAddedGameObject);
            cls.AddMethod(true, "RevertAddedGameObject", BindStatic_RevertAddedGameObject);
            cls.AddMethod(true, "GetObjectOverrides", BindStatic_GetObjectOverrides);
            cls.AddMethod(true, "GetAddedComponents", BindStatic_GetAddedComponents);
            cls.AddMethod(true, "GetRemovedComponents", BindStatic_GetRemovedComponents);
            cls.AddMethod(true, "GetAddedGameObjects", BindStatic_GetAddedGameObjects);
            cls.AddMethod(true, "IsAnyPrefabInstanceRoot", BindStatic_IsAnyPrefabInstanceRoot);
            cls.AddMethod(true, "IsOutermostPrefabInstanceRoot", BindStatic_IsOutermostPrefabInstanceRoot);
            cls.AddMethod(true, "GetPrefabAssetPathOfNearestInstanceRoot", BindStatic_GetPrefabAssetPathOfNearestInstanceRoot);
            cls.AddMethod(true, "GetIconForGameObject", BindStatic_GetIconForGameObject);
            cls.AddMethod(true, "SavePrefabAsset", BindStatic_SavePrefabAsset);
            cls.AddMethod(true, "SaveAsPrefabAsset", BindStatic_SaveAsPrefabAsset);
            cls.AddMethod(true, "SaveAsPrefabAssetAndConnect", BindStatic_SaveAsPrefabAssetAndConnect);
            cls.AddMethod(true, "InstantiatePrefab", BindStatic_InstantiatePrefab);
            cls.AddMethod(true, "IsAddedGameObjectOverride", BindStatic_IsAddedGameObjectOverride);
            cls.AddMethod(true, "UnpackPrefabInstance", BindStatic_UnpackPrefabInstance);
            cls.AddMethod(true, "IsPartOfPrefabThatCanBeAppliedTo", BindStatic_IsPartOfPrefabThatCanBeAppliedTo);
            cls.AddMethod(true, "GetPrefabInstanceStatus", BindStatic_GetPrefabInstanceStatus);
            cls.AddMethod(true, "GetPrefabAssetType", BindStatic_GetPrefabAssetType);
            cls.AddMethod(true, "LoadPrefabContents", BindStatic_LoadPrefabContents);
            cls.AddMethod(true, "UnloadPrefabContents", BindStatic_UnloadPrefabContents);
            cls.AddMethod(true, "prefabInstanceUpdated", BindStaticDelegate_prefabInstanceUpdated);
            return cls;
        }
    }
}
#endif
#endif
