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
    // Type: UnityEditor.Unsupported
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_Unsupported
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CaptureScreenshotImmediate(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 5)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "CaptureScreenshotImmediate", typeof(string), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "CaptureScreenshotImmediate", typeof(int), 1);
                    }
                    int arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "CaptureScreenshotImmediate", typeof(int), 2);
                    }
                    int arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "CaptureScreenshotImmediate", typeof(int), 3);
                    }
                    int arg4;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "CaptureScreenshotImmediate", typeof(int), 4);
                    }
                    UnityEditor.Unsupported.CaptureScreenshotImmediate(arg0, arg1, arg2, arg3, arg4);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CaptureScreenshotImmediate", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetSubmenusCommands(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "GetSubmenusCommands", typeof(string), 0);
                    }
                    var ret = UnityEditor.Unsupported.GetSubmenusCommands(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetSubmenusCommands", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetTypeFromFullName(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "GetTypeFromFullName", typeof(string), 0);
                    }
                    var ret = UnityEditor.Unsupported.GetTypeFromFullName(arg0);
                    return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetTypeFromFullName", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetSubmenus(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "GetSubmenus", typeof(string), 0);
                    }
                    var ret = UnityEditor.Unsupported.GetSubmenus(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetSubmenus", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetSubmenusIncludingSeparators(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "GetSubmenusIncludingSeparators", typeof(string), 0);
                    }
                    var ret = UnityEditor.Unsupported.GetSubmenusIncludingSeparators(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetSubmenusIncludingSeparators", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_PrepareObjectContextMenu(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "PrepareObjectContextMenu", typeof(UnityEngine.Object), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "PrepareObjectContextMenu", typeof(int), 1);
                    }
                    UnityEditor.Unsupported.PrepareObjectContextMenu(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("PrepareObjectContextMenu", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsDeveloperBuild(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.Unsupported.IsDeveloperBuild();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsDeveloperBuild", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsDeveloperMode(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.Unsupported.IsDeveloperMode();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsDeveloperMode", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsSourceBuild(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.Unsupported.IsSourceBuild();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsSourceBuild", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsBleedingEdgeBuild(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.Unsupported.IsBleedingEdgeBuild();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsBleedingEdgeBuild", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsDestroyScriptableObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.ScriptableObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "IsDestroyScriptableObject", typeof(UnityEngine.ScriptableObject), 0);
                    }
                    var ret = UnityEditor.Unsupported.IsDestroyScriptableObject(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsDestroyScriptableObject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsNativeCodeBuiltInReleaseMode(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.Unsupported.IsNativeCodeBuiltInReleaseMode();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsNativeCodeBuiltInReleaseMode", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetBaseUnityDeveloperFolder(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.Unsupported.GetBaseUnityDeveloperFolder();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetBaseUnityDeveloperFolder", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_StopPlayingImmediately(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.Unsupported.StopPlayingImmediately();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("StopPlayingImmediately", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SceneTrackerFlushDirty(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.Unsupported.SceneTrackerFlushDirty();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SceneTrackerFlushDirty", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetAllowCursorHide(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    bool arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "SetAllowCursorHide", typeof(bool), 0);
                    }
                    UnityEditor.Unsupported.SetAllowCursorHide(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetAllowCursorHide", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetOverrideLightingSettings(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.SceneManagement.Scene arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "SetOverrideLightingSettings", typeof(UnityEngine.SceneManagement.Scene), 0);
                    }
                    var ret = UnityEditor.Unsupported.SetOverrideLightingSettings(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("SetOverrideLightingSettings", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RestoreOverrideLightingSettings(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.Unsupported.RestoreOverrideLightingSettings();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RestoreOverrideLightingSettings", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetRenderSettingsUseFogNoDirty(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    bool arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "SetRenderSettingsUseFogNoDirty", typeof(bool), 0);
                    }
                    UnityEditor.Unsupported.SetRenderSettingsUseFogNoDirty(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetRenderSettingsUseFogNoDirty", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetSceneViewDebugModeExposureNoDirty(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    float arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "SetSceneViewDebugModeExposureNoDirty", typeof(float), 0);
                    }
                    UnityEditor.Unsupported.SetSceneViewDebugModeExposureNoDirty(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetSceneViewDebugModeExposureNoDirty", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetQualitySettingsShadowDistanceTemporarily(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    float arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "SetQualitySettingsShadowDistanceTemporarily", typeof(float), 0);
                    }
                    UnityEditor.Unsupported.SetQualitySettingsShadowDistanceTemporarily(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetQualitySettingsShadowDistanceTemporarily", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DeleteGameObjectSelection(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.Unsupported.DeleteGameObjectSelection();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DeleteGameObjectSelection", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CopyGameObjectsToPasteboard(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.Unsupported.CopyGameObjectsToPasteboard();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CopyGameObjectsToPasteboard", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_PasteGameObjectsFromPasteboard(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.Unsupported.PasteGameObjectsFromPasteboard();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("PasteGameObjectsFromPasteboard", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetSerializedAssetInterfaceSingleton(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "GetSerializedAssetInterfaceSingleton", typeof(string), 0);
                    }
                    var ret = UnityEditor.Unsupported.GetSerializedAssetInterfaceSingleton(arg0);
                    return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetSerializedAssetInterfaceSingleton", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DuplicateGameObjectsUsingPasteboard(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.Unsupported.DuplicateGameObjectsUsingPasteboard();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DuplicateGameObjectsUsingPasteboard", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CopyComponentToPasteboard(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Component arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "CopyComponentToPasteboard", typeof(UnityEngine.Component), 0);
                    }
                    var ret = UnityEditor.Unsupported.CopyComponentToPasteboard(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("CopyComponentToPasteboard", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_PasteComponentFromPasteboard(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "PasteComponentFromPasteboard", typeof(UnityEngine.GameObject), 0);
                    }
                    var ret = UnityEditor.Unsupported.PasteComponentFromPasteboard(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("PasteComponentFromPasteboard", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_PasteComponentValuesFromPasteboard(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Component arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "PasteComponentValuesFromPasteboard", typeof(UnityEngine.Component), 0);
                    }
                    var ret = UnityEditor.Unsupported.PasteComponentValuesFromPasteboard(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("PasteComponentValuesFromPasteboard", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_HasStateMachineTransitionDataInPasteboard(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.Unsupported.HasStateMachineTransitionDataInPasteboard();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("HasStateMachineTransitionDataInPasteboard", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_AreAllParametersInDestination(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "AreAllParametersInDestination", typeof(UnityEngine.Object), 0);
                    }
                    UnityEditor.Animations.AnimatorController arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "AreAllParametersInDestination", typeof(UnityEditor.Animations.AnimatorController), 1);
                    }
                    System.Collections.Generic.List<string> arg2;
                    if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "AreAllParametersInDestination", typeof(System.Collections.Generic.List<string>), 2);
                    }
                    var ret = UnityEditor.Unsupported.AreAllParametersInDestination(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("AreAllParametersInDestination", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DestinationHasCompatibleParameterTypes(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "DestinationHasCompatibleParameterTypes", typeof(UnityEngine.Object), 0);
                    }
                    UnityEditor.Animations.AnimatorController arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "DestinationHasCompatibleParameterTypes", typeof(UnityEditor.Animations.AnimatorController), 1);
                    }
                    System.Collections.Generic.List<string> arg2;
                    if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "DestinationHasCompatibleParameterTypes", typeof(System.Collections.Generic.List<string>), 2);
                    }
                    var ret = UnityEditor.Unsupported.DestinationHasCompatibleParameterTypes(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("DestinationHasCompatibleParameterTypes", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CanPasteParametersToTransition(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "CanPasteParametersToTransition", typeof(UnityEngine.Object), 0);
                    }
                    UnityEditor.Animations.AnimatorController arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "CanPasteParametersToTransition", typeof(UnityEditor.Animations.AnimatorController), 1);
                    }
                    var ret = UnityEditor.Unsupported.CanPasteParametersToTransition(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("CanPasteParametersToTransition", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CopyStateMachineTransitionParametersToPasteboard(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "CopyStateMachineTransitionParametersToPasteboard", typeof(UnityEngine.Object), 0);
                    }
                    UnityEditor.Animations.AnimatorController arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "CopyStateMachineTransitionParametersToPasteboard", typeof(UnityEditor.Animations.AnimatorController), 1);
                    }
                    UnityEditor.Unsupported.CopyStateMachineTransitionParametersToPasteboard(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CopyStateMachineTransitionParametersToPasteboard", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_PasteToStateMachineTransitionParametersFromPasteboard(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 4)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "PasteToStateMachineTransitionParametersFromPasteboard", typeof(UnityEngine.Object), 0);
                    }
                    UnityEditor.Animations.AnimatorController arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "PasteToStateMachineTransitionParametersFromPasteboard", typeof(UnityEditor.Animations.AnimatorController), 1);
                    }
                    bool arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "PasteToStateMachineTransitionParametersFromPasteboard", typeof(bool), 2);
                    }
                    bool arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "PasteToStateMachineTransitionParametersFromPasteboard", typeof(bool), 3);
                    }
                    UnityEditor.Unsupported.PasteToStateMachineTransitionParametersFromPasteboard(arg0, arg1, arg2, arg3);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("PasteToStateMachineTransitionParametersFromPasteboard", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CopyStateMachineDataToPasteboard(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "CopyStateMachineDataToPasteboard", typeof(UnityEngine.Object), 0);
                    }
                    UnityEditor.Animations.AnimatorController arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "CopyStateMachineDataToPasteboard", typeof(UnityEditor.Animations.AnimatorController), 1);
                    }
                    int arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "CopyStateMachineDataToPasteboard", typeof(int), 2);
                    }
                    UnityEditor.Unsupported.CopyStateMachineDataToPasteboard(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CopyStateMachineDataToPasteboard", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_PasteToStateMachineFromPasteboard(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 4)
                {
                    UnityEditor.Animations.AnimatorStateMachine arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "PasteToStateMachineFromPasteboard", typeof(UnityEditor.Animations.AnimatorStateMachine), 0);
                    }
                    UnityEditor.Animations.AnimatorController arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "PasteToStateMachineFromPasteboard", typeof(UnityEditor.Animations.AnimatorController), 1);
                    }
                    int arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "PasteToStateMachineFromPasteboard", typeof(int), 2);
                    }
                    UnityEngine.Vector3 arg3;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "PasteToStateMachineFromPasteboard", typeof(UnityEngine.Vector3), 3);
                    }
                    UnityEditor.Unsupported.PasteToStateMachineFromPasteboard(arg0, arg1, arg2, arg3);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("PasteToStateMachineFromPasteboard", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_HasStateMachineDataInPasteboard(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.Unsupported.HasStateMachineDataInPasteboard();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("HasStateMachineDataInPasteboard", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SmartReset(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "SmartReset", typeof(UnityEngine.Object), 0);
                    }
                    UnityEditor.Unsupported.SmartReset(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SmartReset", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ResolveSymlinks(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "ResolveSymlinks", typeof(string), 0);
                    }
                    var ret = UnityEditor.Unsupported.ResolveSymlinks(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ResolveSymlinks", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ResolveRedirectedPath(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "ResolveRedirectedPath", typeof(string), 0);
                    }
                    var ret = UnityEditor.Unsupported.ResolveRedirectedPath(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ResolveRedirectedPath", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetApplicationSettingCompressAssetsOnImport(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    bool arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "SetApplicationSettingCompressAssetsOnImport", typeof(bool), 0);
                    }
                    UnityEditor.Unsupported.SetApplicationSettingCompressAssetsOnImport(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetApplicationSettingCompressAssetsOnImport", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetApplicationSettingCompressAssetsOnImport(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.Unsupported.GetApplicationSettingCompressAssetsOnImport();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetApplicationSettingCompressAssetsOnImport", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetLocalIdentifierInFileForPersistentObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "GetLocalIdentifierInFileForPersistentObject", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.Unsupported.GetLocalIdentifierInFileForPersistentObject(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetLocalIdentifierInFileForPersistentObject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsHiddenFile(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.Unsupported), "IsHiddenFile", typeof(string), 0);
                    }
                    var ret = UnityEditor.Unsupported.IsHiddenFile(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsHiddenFile", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ClearSkinCache(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.Unsupported.ClearSkinCache();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ClearSkinCache", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_useScriptableRenderPipeline(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.Unsupported.useScriptableRenderPipeline;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_useScriptableRenderPipeline(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.Unsupported), "useScriptableRenderPipeline", typeof(bool), 0);
                }
                UnityEditor.Unsupported.useScriptableRenderPipeline = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("Unsupported", typeof(UnityEditor.Unsupported), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "CaptureScreenshotImmediate", BindStatic_CaptureScreenshotImmediate);
            cls.AddMethod(true, "GetSubmenusCommands", BindStatic_GetSubmenusCommands);
            cls.AddMethod(true, "GetTypeFromFullName", BindStatic_GetTypeFromFullName);
            cls.AddMethod(true, "GetSubmenus", BindStatic_GetSubmenus);
            cls.AddMethod(true, "GetSubmenusIncludingSeparators", BindStatic_GetSubmenusIncludingSeparators);
            cls.AddMethod(true, "PrepareObjectContextMenu", BindStatic_PrepareObjectContextMenu);
            cls.AddMethod(true, "IsDeveloperBuild", BindStatic_IsDeveloperBuild);
            cls.AddMethod(true, "IsDeveloperMode", BindStatic_IsDeveloperMode);
            cls.AddMethod(true, "IsSourceBuild", BindStatic_IsSourceBuild);
            cls.AddMethod(true, "IsBleedingEdgeBuild", BindStatic_IsBleedingEdgeBuild);
            cls.AddMethod(true, "IsDestroyScriptableObject", BindStatic_IsDestroyScriptableObject);
            cls.AddMethod(true, "IsNativeCodeBuiltInReleaseMode", BindStatic_IsNativeCodeBuiltInReleaseMode);
            cls.AddMethod(true, "GetBaseUnityDeveloperFolder", BindStatic_GetBaseUnityDeveloperFolder);
            cls.AddMethod(true, "StopPlayingImmediately", BindStatic_StopPlayingImmediately);
            cls.AddMethod(true, "SceneTrackerFlushDirty", BindStatic_SceneTrackerFlushDirty);
            cls.AddMethod(true, "SetAllowCursorHide", BindStatic_SetAllowCursorHide);
            cls.AddMethod(true, "SetOverrideLightingSettings", BindStatic_SetOverrideLightingSettings);
            cls.AddMethod(true, "RestoreOverrideLightingSettings", BindStatic_RestoreOverrideLightingSettings);
            cls.AddMethod(true, "SetRenderSettingsUseFogNoDirty", BindStatic_SetRenderSettingsUseFogNoDirty);
            cls.AddMethod(true, "SetSceneViewDebugModeExposureNoDirty", BindStatic_SetSceneViewDebugModeExposureNoDirty);
            cls.AddMethod(true, "SetQualitySettingsShadowDistanceTemporarily", BindStatic_SetQualitySettingsShadowDistanceTemporarily);
            cls.AddMethod(true, "DeleteGameObjectSelection", BindStatic_DeleteGameObjectSelection);
            cls.AddMethod(true, "CopyGameObjectsToPasteboard", BindStatic_CopyGameObjectsToPasteboard);
            cls.AddMethod(true, "PasteGameObjectsFromPasteboard", BindStatic_PasteGameObjectsFromPasteboard);
            cls.AddMethod(true, "GetSerializedAssetInterfaceSingleton", BindStatic_GetSerializedAssetInterfaceSingleton);
            cls.AddMethod(true, "DuplicateGameObjectsUsingPasteboard", BindStatic_DuplicateGameObjectsUsingPasteboard);
            cls.AddMethod(true, "CopyComponentToPasteboard", BindStatic_CopyComponentToPasteboard);
            cls.AddMethod(true, "PasteComponentFromPasteboard", BindStatic_PasteComponentFromPasteboard);
            cls.AddMethod(true, "PasteComponentValuesFromPasteboard", BindStatic_PasteComponentValuesFromPasteboard);
            cls.AddMethod(true, "HasStateMachineTransitionDataInPasteboard", BindStatic_HasStateMachineTransitionDataInPasteboard);
            cls.AddMethod(true, "AreAllParametersInDestination", BindStatic_AreAllParametersInDestination);
            cls.AddMethod(true, "DestinationHasCompatibleParameterTypes", BindStatic_DestinationHasCompatibleParameterTypes);
            cls.AddMethod(true, "CanPasteParametersToTransition", BindStatic_CanPasteParametersToTransition);
            cls.AddMethod(true, "CopyStateMachineTransitionParametersToPasteboard", BindStatic_CopyStateMachineTransitionParametersToPasteboard);
            cls.AddMethod(true, "PasteToStateMachineTransitionParametersFromPasteboard", BindStatic_PasteToStateMachineTransitionParametersFromPasteboard);
            cls.AddMethod(true, "CopyStateMachineDataToPasteboard", BindStatic_CopyStateMachineDataToPasteboard);
            cls.AddMethod(true, "PasteToStateMachineFromPasteboard", BindStatic_PasteToStateMachineFromPasteboard);
            cls.AddMethod(true, "HasStateMachineDataInPasteboard", BindStatic_HasStateMachineDataInPasteboard);
            cls.AddMethod(true, "SmartReset", BindStatic_SmartReset);
            cls.AddMethod(true, "ResolveSymlinks", BindStatic_ResolveSymlinks);
            cls.AddMethod(true, "ResolveRedirectedPath", BindStatic_ResolveRedirectedPath);
            cls.AddMethod(true, "SetApplicationSettingCompressAssetsOnImport", BindStatic_SetApplicationSettingCompressAssetsOnImport);
            cls.AddMethod(true, "GetApplicationSettingCompressAssetsOnImport", BindStatic_GetApplicationSettingCompressAssetsOnImport);
            cls.AddMethod(true, "GetLocalIdentifierInFileForPersistentObject", BindStatic_GetLocalIdentifierInFileForPersistentObject);
            cls.AddMethod(true, "IsHiddenFile", BindStatic_IsHiddenFile);
            cls.AddMethod(true, "ClearSkinCache", BindStatic_ClearSkinCache);
            cls.AddProperty(true, "useScriptableRenderPipeline", BindStaticRead_useScriptableRenderPipeline, BindStaticWrite_useScriptableRenderPipeline);
            return cls;
        }
    }
}
#endif
#endif
