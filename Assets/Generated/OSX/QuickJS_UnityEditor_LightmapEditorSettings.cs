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
//     // Type: UnityEditor.LightmapEditorSettings
//     [JSBindingAttribute]
//     public class QuickJS_UnityEditor_LightmapEditorSettings
//     {
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_lightmapper(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.lightmapper;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_lightmapper(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 UnityEditor.LightmapEditorSettings.Lightmapper value;
//                 if (!Values.js_get_enumvalue(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "lightmapper", typeof(UnityEditor.LightmapEditorSettings.Lightmapper), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.lightmapper = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_lightmapsMode(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.lightmapsMode;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_lightmapsMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 UnityEngine.LightmapsMode value;
//                 if (!Values.js_get_enumvalue(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "lightmapsMode", typeof(UnityEngine.LightmapsMode), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.lightmapsMode = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_mixedBakeMode(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.mixedBakeMode;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_mixedBakeMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 UnityEngine.MixedLightingMode value;
//                 if (!Values.js_get_enumvalue(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "mixedBakeMode", typeof(UnityEngine.MixedLightingMode), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.mixedBakeMode = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_sampling(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.sampling;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_sampling(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 UnityEditor.LightmapEditorSettings.Sampling value;
//                 if (!Values.js_get_enumvalue(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "sampling", typeof(UnityEditor.LightmapEditorSettings.Sampling), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.sampling = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_directSampleCount(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.directSampleCount;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_directSampleCount(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 int value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "directSampleCount", typeof(int), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.directSampleCount = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_indirectSampleCount(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.indirectSampleCount;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_indirectSampleCount(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 int value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "indirectSampleCount", typeof(int), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.indirectSampleCount = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_bounces(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.bounces;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_bounces(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 int value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "bounces", typeof(int), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.bounces = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_prioritizeView(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.prioritizeView;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_prioritizeView(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 bool value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "prioritizeView", typeof(bool), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.prioritizeView = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_filteringMode(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.filteringMode;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_filteringMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 UnityEditor.LightmapEditorSettings.FilterMode value;
//                 if (!Values.js_get_enumvalue(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "filteringMode", typeof(UnityEditor.LightmapEditorSettings.FilterMode), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.filteringMode = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_denoiserTypeDirect(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.denoiserTypeDirect;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_denoiserTypeDirect(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 UnityEditor.LightmapEditorSettings.DenoiserType value;
//                 if (!Values.js_get_enumvalue(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "denoiserTypeDirect", typeof(UnityEditor.LightmapEditorSettings.DenoiserType), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.denoiserTypeDirect = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_denoiserTypeIndirect(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.denoiserTypeIndirect;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_denoiserTypeIndirect(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 UnityEditor.LightmapEditorSettings.DenoiserType value;
//                 if (!Values.js_get_enumvalue(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "denoiserTypeIndirect", typeof(UnityEditor.LightmapEditorSettings.DenoiserType), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.denoiserTypeIndirect = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_denoiserTypeAO(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.denoiserTypeAO;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_denoiserTypeAO(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 UnityEditor.LightmapEditorSettings.DenoiserType value;
//                 if (!Values.js_get_enumvalue(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "denoiserTypeAO", typeof(UnityEditor.LightmapEditorSettings.DenoiserType), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.denoiserTypeAO = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_filterTypeDirect(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.filterTypeDirect;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_filterTypeDirect(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 UnityEditor.LightmapEditorSettings.FilterType value;
//                 if (!Values.js_get_enumvalue(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "filterTypeDirect", typeof(UnityEditor.LightmapEditorSettings.FilterType), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.filterTypeDirect = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_filterTypeIndirect(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.filterTypeIndirect;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_filterTypeIndirect(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 UnityEditor.LightmapEditorSettings.FilterType value;
//                 if (!Values.js_get_enumvalue(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "filterTypeIndirect", typeof(UnityEditor.LightmapEditorSettings.FilterType), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.filterTypeIndirect = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_filterTypeAO(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.filterTypeAO;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_filterTypeAO(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 UnityEditor.LightmapEditorSettings.FilterType value;
//                 if (!Values.js_get_enumvalue(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "filterTypeAO", typeof(UnityEditor.LightmapEditorSettings.FilterType), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.filterTypeAO = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_filteringGaussRadiusDirect(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.filteringGaussRadiusDirect;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_filteringGaussRadiusDirect(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 int value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "filteringGaussRadiusDirect", typeof(int), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.filteringGaussRadiusDirect = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_filteringGaussRadiusIndirect(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.filteringGaussRadiusIndirect;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_filteringGaussRadiusIndirect(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 int value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "filteringGaussRadiusIndirect", typeof(int), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.filteringGaussRadiusIndirect = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_filteringGaussRadiusAO(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.filteringGaussRadiusAO;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_filteringGaussRadiusAO(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 int value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "filteringGaussRadiusAO", typeof(int), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.filteringGaussRadiusAO = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_filteringAtrousPositionSigmaDirect(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.filteringAtrousPositionSigmaDirect;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_filteringAtrousPositionSigmaDirect(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 float value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "filteringAtrousPositionSigmaDirect", typeof(float), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.filteringAtrousPositionSigmaDirect = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_filteringAtrousPositionSigmaIndirect(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.filteringAtrousPositionSigmaIndirect;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_filteringAtrousPositionSigmaIndirect(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 float value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "filteringAtrousPositionSigmaIndirect", typeof(float), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.filteringAtrousPositionSigmaIndirect = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_filteringAtrousPositionSigmaAO(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.filteringAtrousPositionSigmaAO;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_filteringAtrousPositionSigmaAO(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 float value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "filteringAtrousPositionSigmaAO", typeof(float), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.filteringAtrousPositionSigmaAO = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_environmentSampleCount(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.environmentSampleCount;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_environmentSampleCount(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 int value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "environmentSampleCount", typeof(int), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.environmentSampleCount = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_lightProbeSampleCountMultiplier(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.lightProbeSampleCountMultiplier;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_lightProbeSampleCountMultiplier(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 float value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "lightProbeSampleCountMultiplier", typeof(float), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.lightProbeSampleCountMultiplier = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_maxAtlasSize(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.maxAtlasSize;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_maxAtlasSize(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 int value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "maxAtlasSize", typeof(int), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.maxAtlasSize = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_realtimeResolution(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.realtimeResolution;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_realtimeResolution(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 float value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "realtimeResolution", typeof(float), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.realtimeResolution = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_bakeResolution(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.bakeResolution;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_bakeResolution(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 float value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "bakeResolution", typeof(float), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.bakeResolution = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_textureCompression(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.textureCompression;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_textureCompression(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 bool value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "textureCompression", typeof(bool), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.textureCompression = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_reflectionCubemapCompression(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.reflectionCubemapCompression;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_reflectionCubemapCompression(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 UnityEngine.Rendering.ReflectionCubemapCompression value;
//                 if (!Values.js_get_enumvalue(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "reflectionCubemapCompression", typeof(UnityEngine.Rendering.ReflectionCubemapCompression), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.reflectionCubemapCompression = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_enableAmbientOcclusion(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.enableAmbientOcclusion;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_enableAmbientOcclusion(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 bool value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "enableAmbientOcclusion", typeof(bool), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.enableAmbientOcclusion = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_aoMaxDistance(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.aoMaxDistance;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_aoMaxDistance(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 float value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "aoMaxDistance", typeof(float), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.aoMaxDistance = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_aoExponentIndirect(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.aoExponentIndirect;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_aoExponentIndirect(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 float value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "aoExponentIndirect", typeof(float), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.aoExponentIndirect = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_aoExponentDirect(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.aoExponentDirect;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_aoExponentDirect(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 float value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "aoExponentDirect", typeof(float), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.aoExponentDirect = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_padding(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.padding;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_padding(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 int value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "padding", typeof(int), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.padding = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_exportTrainingData(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.exportTrainingData;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_exportTrainingData(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 bool value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "exportTrainingData", typeof(bool), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.exportTrainingData = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_trainingDataDestination(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.LightmapEditorSettings.trainingDataDestination;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_trainingDataDestination(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 string value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.LightmapEditorSettings), "trainingDataDestination", typeof(string), 0);
//                 }
//                 UnityEditor.LightmapEditorSettings.trainingDataDestination = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
//         {
//             var cls = register.CreateClass("LightmapEditorSettings", typeof(UnityEditor.LightmapEditorSettings), QuickJS.JSNative.class_private_ctor);
//             cls.AddProperty(true, "lightmapper", BindStaticRead_lightmapper, BindStaticWrite_lightmapper);
//             cls.AddProperty(true, "lightmapsMode", BindStaticRead_lightmapsMode, BindStaticWrite_lightmapsMode);
//             cls.AddProperty(true, "mixedBakeMode", BindStaticRead_mixedBakeMode, BindStaticWrite_mixedBakeMode);
//             cls.AddProperty(true, "sampling", BindStaticRead_sampling, BindStaticWrite_sampling);
//             cls.AddProperty(true, "directSampleCount", BindStaticRead_directSampleCount, BindStaticWrite_directSampleCount);
//             cls.AddProperty(true, "indirectSampleCount", BindStaticRead_indirectSampleCount, BindStaticWrite_indirectSampleCount);
//             cls.AddProperty(true, "bounces", BindStaticRead_bounces, BindStaticWrite_bounces);
//             cls.AddProperty(true, "prioritizeView", BindStaticRead_prioritizeView, BindStaticWrite_prioritizeView);
//             cls.AddProperty(true, "filteringMode", BindStaticRead_filteringMode, BindStaticWrite_filteringMode);
//             cls.AddProperty(true, "denoiserTypeDirect", BindStaticRead_denoiserTypeDirect, BindStaticWrite_denoiserTypeDirect);
//             cls.AddProperty(true, "denoiserTypeIndirect", BindStaticRead_denoiserTypeIndirect, BindStaticWrite_denoiserTypeIndirect);
//             cls.AddProperty(true, "denoiserTypeAO", BindStaticRead_denoiserTypeAO, BindStaticWrite_denoiserTypeAO);
//             cls.AddProperty(true, "filterTypeDirect", BindStaticRead_filterTypeDirect, BindStaticWrite_filterTypeDirect);
//             cls.AddProperty(true, "filterTypeIndirect", BindStaticRead_filterTypeIndirect, BindStaticWrite_filterTypeIndirect);
//             cls.AddProperty(true, "filterTypeAO", BindStaticRead_filterTypeAO, BindStaticWrite_filterTypeAO);
//             cls.AddProperty(true, "filteringGaussRadiusDirect", BindStaticRead_filteringGaussRadiusDirect, BindStaticWrite_filteringGaussRadiusDirect);
//             cls.AddProperty(true, "filteringGaussRadiusIndirect", BindStaticRead_filteringGaussRadiusIndirect, BindStaticWrite_filteringGaussRadiusIndirect);
//             cls.AddProperty(true, "filteringGaussRadiusAO", BindStaticRead_filteringGaussRadiusAO, BindStaticWrite_filteringGaussRadiusAO);
//             cls.AddProperty(true, "filteringAtrousPositionSigmaDirect", BindStaticRead_filteringAtrousPositionSigmaDirect, BindStaticWrite_filteringAtrousPositionSigmaDirect);
//             cls.AddProperty(true, "filteringAtrousPositionSigmaIndirect", BindStaticRead_filteringAtrousPositionSigmaIndirect, BindStaticWrite_filteringAtrousPositionSigmaIndirect);
//             cls.AddProperty(true, "filteringAtrousPositionSigmaAO", BindStaticRead_filteringAtrousPositionSigmaAO, BindStaticWrite_filteringAtrousPositionSigmaAO);
//             cls.AddProperty(true, "environmentSampleCount", BindStaticRead_environmentSampleCount, BindStaticWrite_environmentSampleCount);
//             cls.AddProperty(true, "lightProbeSampleCountMultiplier", BindStaticRead_lightProbeSampleCountMultiplier, BindStaticWrite_lightProbeSampleCountMultiplier);
//             cls.AddProperty(true, "maxAtlasSize", BindStaticRead_maxAtlasSize, BindStaticWrite_maxAtlasSize);
//             cls.AddProperty(true, "realtimeResolution", BindStaticRead_realtimeResolution, BindStaticWrite_realtimeResolution);
//             cls.AddProperty(true, "bakeResolution", BindStaticRead_bakeResolution, BindStaticWrite_bakeResolution);
//             cls.AddProperty(true, "textureCompression", BindStaticRead_textureCompression, BindStaticWrite_textureCompression);
//             cls.AddProperty(true, "reflectionCubemapCompression", BindStaticRead_reflectionCubemapCompression, BindStaticWrite_reflectionCubemapCompression);
//             cls.AddProperty(true, "enableAmbientOcclusion", BindStaticRead_enableAmbientOcclusion, BindStaticWrite_enableAmbientOcclusion);
//             cls.AddProperty(true, "aoMaxDistance", BindStaticRead_aoMaxDistance, BindStaticWrite_aoMaxDistance);
//             cls.AddProperty(true, "aoExponentIndirect", BindStaticRead_aoExponentIndirect, BindStaticWrite_aoExponentIndirect);
//             cls.AddProperty(true, "aoExponentDirect", BindStaticRead_aoExponentDirect, BindStaticWrite_aoExponentDirect);
//             cls.AddProperty(true, "padding", BindStaticRead_padding, BindStaticWrite_padding);
//             cls.AddProperty(true, "exportTrainingData", BindStaticRead_exportTrainingData, BindStaticWrite_exportTrainingData);
//             cls.AddProperty(true, "trainingDataDestination", BindStaticRead_trainingDataDestination, BindStaticWrite_trainingDataDestination);
//             return cls;
//         }
//     }
// }
// #endif
// #endif
