// #if UNITY_EDITOR
// #if UNITY_STANDALONE_OSX
// // Unity: 2019.4.40f1
// using System;
// using System.Collections.Generic;
//
// namespace jsb {
//     using QuickJS.Errors;
//     using JSValue = QuickJS.Native.JSValue;
//     using JSApi = QuickJS.Native.JSApi;
//     using JSNative = QuickJS.JSNative;
//     using JSContext = QuickJS.Native.JSContext;
//     using Values = QuickJS.Binding.Values;
//     using ScriptEngine = QuickJS.ScriptEngine;
//     using JSBindingAttribute = QuickJS.JSBindingAttribute;
//     using MonoPInvokeCallbackAttribute = QuickJS.MonoPInvokeCallbackAttribute;
//     // Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
//     // Location: /Applications/Unity/Hub/Editor/2019.4.40f1/Unity.app/Contents/Managed/UnityEditor.dll
//     // Type: UnityEditor.EditorSettings
//     [JSBindingAttribute]
//     public class QuickJS_UnityEditor_EditorSettings
//     {
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_unityRemoteDevice(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.unityRemoteDevice;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_unityRemoteDevice(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 string value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.EditorSettings), "unityRemoteDevice", typeof(string), 0);
//                 }
//                 UnityEditor.EditorSettings.unityRemoteDevice = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_unityRemoteCompression(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.unityRemoteCompression;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_unityRemoteCompression(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 string value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.EditorSettings), "unityRemoteCompression", typeof(string), 0);
//                 }
//                 UnityEditor.EditorSettings.unityRemoteCompression = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_unityRemoteResolution(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.unityRemoteResolution;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_unityRemoteResolution(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 string value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.EditorSettings), "unityRemoteResolution", typeof(string), 0);
//                 }
//                 UnityEditor.EditorSettings.unityRemoteResolution = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_unityRemoteJoystickSource(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.unityRemoteJoystickSource;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_unityRemoteJoystickSource(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 string value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.EditorSettings), "unityRemoteJoystickSource", typeof(string), 0);
//                 }
//                 UnityEditor.EditorSettings.unityRemoteJoystickSource = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_externalVersionControl(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.externalVersionControl;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_externalVersionControl(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 string value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.EditorSettings), "externalVersionControl", typeof(string), 0);
//                 }
//                 UnityEditor.EditorSettings.externalVersionControl = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_serializationMode(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.serializationMode;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_serializationMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 UnityEditor.SerializationMode value;
//                 if (!Values.js_get_enumvalue(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.EditorSettings), "serializationMode", typeof(UnityEditor.SerializationMode), 0);
//                 }
//                 UnityEditor.EditorSettings.serializationMode = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_lineEndingsForNewScripts(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.lineEndingsForNewScripts;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_lineEndingsForNewScripts(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 UnityEditor.LineEndingsMode value;
//                 if (!Values.js_get_enumvalue(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.EditorSettings), "lineEndingsForNewScripts", typeof(UnityEditor.LineEndingsMode), 0);
//                 }
//                 UnityEditor.EditorSettings.lineEndingsForNewScripts = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_defaultBehaviorMode(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.defaultBehaviorMode;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_defaultBehaviorMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 UnityEditor.EditorBehaviorMode value;
//                 if (!Values.js_get_enumvalue(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.EditorSettings), "defaultBehaviorMode", typeof(UnityEditor.EditorBehaviorMode), 0);
//                 }
//                 UnityEditor.EditorSettings.defaultBehaviorMode = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_prefabRegularEnvironment(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.prefabRegularEnvironment;
//                 return Values.js_push_classvalue(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_prefabRegularEnvironment(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 UnityEditor.SceneAsset value;
//                 if (!Values.js_get_classvalue(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.EditorSettings), "prefabRegularEnvironment", typeof(UnityEditor.SceneAsset), 0);
//                 }
//                 UnityEditor.EditorSettings.prefabRegularEnvironment = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_prefabUIEnvironment(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.prefabUIEnvironment;
//                 return Values.js_push_classvalue(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_prefabUIEnvironment(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 UnityEditor.SceneAsset value;
//                 if (!Values.js_get_classvalue(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.EditorSettings), "prefabUIEnvironment", typeof(UnityEditor.SceneAsset), 0);
//                 }
//                 UnityEditor.EditorSettings.prefabUIEnvironment = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_spritePackerMode(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.spritePackerMode;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_spritePackerMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 UnityEditor.SpritePackerMode value;
//                 if (!Values.js_get_enumvalue(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.EditorSettings), "spritePackerMode", typeof(UnityEditor.SpritePackerMode), 0);
//                 }
//                 UnityEditor.EditorSettings.spritePackerMode = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_spritePackerPaddingPower(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.spritePackerPaddingPower;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_spritePackerPaddingPower(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 int value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.EditorSettings), "spritePackerPaddingPower", typeof(int), 0);
//                 }
//                 UnityEditor.EditorSettings.spritePackerPaddingPower = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_etcTextureCompressorBehavior(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.etcTextureCompressorBehavior;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_etcTextureCompressorBehavior(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 int value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.EditorSettings), "etcTextureCompressorBehavior", typeof(int), 0);
//                 }
//                 UnityEditor.EditorSettings.etcTextureCompressorBehavior = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_etcTextureFastCompressor(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.etcTextureFastCompressor;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_etcTextureFastCompressor(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 int value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.EditorSettings), "etcTextureFastCompressor", typeof(int), 0);
//                 }
//                 UnityEditor.EditorSettings.etcTextureFastCompressor = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_etcTextureNormalCompressor(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.etcTextureNormalCompressor;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_etcTextureNormalCompressor(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 int value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.EditorSettings), "etcTextureNormalCompressor", typeof(int), 0);
//                 }
//                 UnityEditor.EditorSettings.etcTextureNormalCompressor = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_etcTextureBestCompressor(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.etcTextureBestCompressor;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_etcTextureBestCompressor(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 int value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.EditorSettings), "etcTextureBestCompressor", typeof(int), 0);
//                 }
//                 UnityEditor.EditorSettings.etcTextureBestCompressor = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_enableTextureStreamingInEditMode(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.enableTextureStreamingInEditMode;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_enableTextureStreamingInEditMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 bool value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.EditorSettings), "enableTextureStreamingInEditMode", typeof(bool), 0);
//                 }
//                 UnityEditor.EditorSettings.enableTextureStreamingInEditMode = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_enableTextureStreamingInPlayMode(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.enableTextureStreamingInPlayMode;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_enableTextureStreamingInPlayMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 bool value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.EditorSettings), "enableTextureStreamingInPlayMode", typeof(bool), 0);
//                 }
//                 UnityEditor.EditorSettings.enableTextureStreamingInPlayMode = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_asyncShaderCompilation(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.asyncShaderCompilation;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_asyncShaderCompilation(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 bool value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.EditorSettings), "asyncShaderCompilation", typeof(bool), 0);
//                 }
//                 UnityEditor.EditorSettings.asyncShaderCompilation = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_projectGenerationUserExtensions(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.projectGenerationUserExtensions;
//                 return Values.js_push_classvalue(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_projectGenerationUserExtensions(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 string[] value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.EditorSettings), "projectGenerationUserExtensions", typeof(string[]), 0);
//                 }
//                 UnityEditor.EditorSettings.projectGenerationUserExtensions = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_projectGenerationBuiltinExtensions(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.projectGenerationBuiltinExtensions;
//                 return Values.js_push_classvalue(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_projectGenerationRootNamespace(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.projectGenerationRootNamespace;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_projectGenerationRootNamespace(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 string value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.EditorSettings), "projectGenerationRootNamespace", typeof(string), 0);
//                 }
//                 UnityEditor.EditorSettings.projectGenerationRootNamespace = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_useLegacyProbeSampleCount(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.useLegacyProbeSampleCount;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_useLegacyProbeSampleCount(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 bool value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.EditorSettings), "useLegacyProbeSampleCount", typeof(bool), 0);
//                 }
//                 UnityEditor.EditorSettings.useLegacyProbeSampleCount = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_enterPlayModeOptionsEnabled(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.enterPlayModeOptionsEnabled;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_enterPlayModeOptionsEnabled(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 bool value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.EditorSettings), "enterPlayModeOptionsEnabled", typeof(bool), 0);
//                 }
//                 UnityEditor.EditorSettings.enterPlayModeOptionsEnabled = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_enterPlayModeOptions(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.enterPlayModeOptions;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_enterPlayModeOptions(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 UnityEditor.EnterPlayModeOptions value;
//                 if (!Values.js_get_enumvalue(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.EditorSettings), "enterPlayModeOptions", typeof(UnityEditor.EnterPlayModeOptions), 0);
//                 }
//                 UnityEditor.EditorSettings.enterPlayModeOptions = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_assetPipelineMode(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.assetPipelineMode;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_assetPipelineMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 UnityEditor.AssetPipelineMode value;
//                 if (!Values.js_get_enumvalue(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.EditorSettings), "assetPipelineMode", typeof(UnityEditor.AssetPipelineMode), 0);
//                 }
//                 UnityEditor.EditorSettings.assetPipelineMode = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_cacheServerMode(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.cacheServerMode;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_cacheServerMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 UnityEditor.CacheServerMode value;
//                 if (!Values.js_get_enumvalue(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.EditorSettings), "cacheServerMode", typeof(UnityEditor.CacheServerMode), 0);
//                 }
//                 UnityEditor.EditorSettings.cacheServerMode = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_cacheServerEndpoint(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.cacheServerEndpoint;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_cacheServerEndpoint(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 string value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.EditorSettings), "cacheServerEndpoint", typeof(string), 0);
//                 }
//                 UnityEditor.EditorSettings.cacheServerEndpoint = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_cacheServerNamespacePrefix(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.cacheServerNamespacePrefix;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_cacheServerNamespacePrefix(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 string value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.EditorSettings), "cacheServerNamespacePrefix", typeof(string), 0);
//                 }
//                 UnityEditor.EditorSettings.cacheServerNamespacePrefix = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_cacheServerEnableDownload(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.cacheServerEnableDownload;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_cacheServerEnableDownload(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 bool value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.EditorSettings), "cacheServerEnableDownload", typeof(bool), 0);
//                 }
//                 UnityEditor.EditorSettings.cacheServerEnableDownload = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_cacheServerEnableUpload(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.cacheServerEnableUpload;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_cacheServerEnableUpload(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 bool value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.EditorSettings), "cacheServerEnableUpload", typeof(bool), 0);
//                 }
//                 UnityEditor.EditorSettings.cacheServerEnableUpload = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_cacheServerValidationMode(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.EditorSettings.cacheServerValidationMode;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_cacheServerValidationMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 UnityEditor.CacheServerValidationMode value;
//                 if (!Values.js_get_enumvalue(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.EditorSettings), "cacheServerValidationMode", typeof(UnityEditor.CacheServerValidationMode), 0);
//                 }
//                 UnityEditor.EditorSettings.cacheServerValidationMode = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
//         {
//             var cls = register.CreateClass("EditorSettings", typeof(UnityEditor.EditorSettings), QuickJS.JSNative.class_private_ctor);
//             cls.AddProperty(true, "unityRemoteDevice", BindStaticRead_unityRemoteDevice, BindStaticWrite_unityRemoteDevice);
//             cls.AddProperty(true, "unityRemoteCompression", BindStaticRead_unityRemoteCompression, BindStaticWrite_unityRemoteCompression);
//             cls.AddProperty(true, "unityRemoteResolution", BindStaticRead_unityRemoteResolution, BindStaticWrite_unityRemoteResolution);
//             cls.AddProperty(true, "unityRemoteJoystickSource", BindStaticRead_unityRemoteJoystickSource, BindStaticWrite_unityRemoteJoystickSource);
//             cls.AddProperty(true, "externalVersionControl", BindStaticRead_externalVersionControl, BindStaticWrite_externalVersionControl);
//             cls.AddProperty(true, "serializationMode", BindStaticRead_serializationMode, BindStaticWrite_serializationMode);
//             cls.AddProperty(true, "lineEndingsForNewScripts", BindStaticRead_lineEndingsForNewScripts, BindStaticWrite_lineEndingsForNewScripts);
//             cls.AddProperty(true, "defaultBehaviorMode", BindStaticRead_defaultBehaviorMode, BindStaticWrite_defaultBehaviorMode);
//             cls.AddProperty(true, "prefabRegularEnvironment", BindStaticRead_prefabRegularEnvironment, BindStaticWrite_prefabRegularEnvironment);
//             cls.AddProperty(true, "prefabUIEnvironment", BindStaticRead_prefabUIEnvironment, BindStaticWrite_prefabUIEnvironment);
//             cls.AddProperty(true, "spritePackerMode", BindStaticRead_spritePackerMode, BindStaticWrite_spritePackerMode);
//             cls.AddProperty(true, "spritePackerPaddingPower", BindStaticRead_spritePackerPaddingPower, BindStaticWrite_spritePackerPaddingPower);
//             cls.AddProperty(true, "etcTextureCompressorBehavior", BindStaticRead_etcTextureCompressorBehavior, BindStaticWrite_etcTextureCompressorBehavior);
//             cls.AddProperty(true, "etcTextureFastCompressor", BindStaticRead_etcTextureFastCompressor, BindStaticWrite_etcTextureFastCompressor);
//             cls.AddProperty(true, "etcTextureNormalCompressor", BindStaticRead_etcTextureNormalCompressor, BindStaticWrite_etcTextureNormalCompressor);
//             cls.AddProperty(true, "etcTextureBestCompressor", BindStaticRead_etcTextureBestCompressor, BindStaticWrite_etcTextureBestCompressor);
//             cls.AddProperty(true, "enableTextureStreamingInEditMode", BindStaticRead_enableTextureStreamingInEditMode, BindStaticWrite_enableTextureStreamingInEditMode);
//             cls.AddProperty(true, "enableTextureStreamingInPlayMode", BindStaticRead_enableTextureStreamingInPlayMode, BindStaticWrite_enableTextureStreamingInPlayMode);
//             cls.AddProperty(true, "asyncShaderCompilation", BindStaticRead_asyncShaderCompilation, BindStaticWrite_asyncShaderCompilation);
//             cls.AddProperty(true, "projectGenerationUserExtensions", BindStaticRead_projectGenerationUserExtensions, BindStaticWrite_projectGenerationUserExtensions);
//             cls.AddProperty(true, "projectGenerationBuiltinExtensions", BindStaticRead_projectGenerationBuiltinExtensions, null);
//             cls.AddProperty(true, "projectGenerationRootNamespace", BindStaticRead_projectGenerationRootNamespace, BindStaticWrite_projectGenerationRootNamespace);
//             cls.AddProperty(true, "useLegacyProbeSampleCount", BindStaticRead_useLegacyProbeSampleCount, BindStaticWrite_useLegacyProbeSampleCount);
//             cls.AddProperty(true, "enterPlayModeOptionsEnabled", BindStaticRead_enterPlayModeOptionsEnabled, BindStaticWrite_enterPlayModeOptionsEnabled);
//             cls.AddProperty(true, "enterPlayModeOptions", BindStaticRead_enterPlayModeOptions, BindStaticWrite_enterPlayModeOptions);
//             cls.AddProperty(true, "assetPipelineMode", BindStaticRead_assetPipelineMode, BindStaticWrite_assetPipelineMode);
//             cls.AddProperty(true, "cacheServerMode", BindStaticRead_cacheServerMode, BindStaticWrite_cacheServerMode);
//             cls.AddProperty(true, "cacheServerEndpoint", BindStaticRead_cacheServerEndpoint, BindStaticWrite_cacheServerEndpoint);
//             cls.AddProperty(true, "cacheServerNamespacePrefix", BindStaticRead_cacheServerNamespacePrefix, BindStaticWrite_cacheServerNamespacePrefix);
//             cls.AddProperty(true, "cacheServerEnableDownload", BindStaticRead_cacheServerEnableDownload, BindStaticWrite_cacheServerEnableDownload);
//             cls.AddProperty(true, "cacheServerEnableUpload", BindStaticRead_cacheServerEnableUpload, BindStaticWrite_cacheServerEnableUpload);
//             cls.AddProperty(true, "cacheServerValidationMode", BindStaticRead_cacheServerValidationMode, BindStaticWrite_cacheServerValidationMode);
//             return cls;
//         }
//     }
// }
// #endif
// #endif
