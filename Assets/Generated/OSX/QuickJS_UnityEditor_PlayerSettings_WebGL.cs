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
//     // Type: UnityEditor.PlayerSettings+WebGL
//     [JSBindingAttribute]
//     public class QuickJS_UnityEditor_PlayerSettings_WebGL
//     {
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
//         public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
//         {
//             try
//             {
//                 if (argc == 0)
//                 {
//                     var o = new UnityEditor.PlayerSettings.WebGL();
//                     var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
//                     return val;
//                 }
//                 throw new NoSuitableMethodException("constructor", argc);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_memorySize(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.PlayerSettings.WebGL.memorySize;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_memorySize(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 int value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.PlayerSettings.WebGL), "memorySize", typeof(int), 0);
//                 }
//                 UnityEditor.PlayerSettings.WebGL.memorySize = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_exceptionSupport(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.PlayerSettings.WebGL.exceptionSupport;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_exceptionSupport(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 UnityEditor.WebGLExceptionSupport value;
//                 if (!Values.js_get_enumvalue(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.PlayerSettings.WebGL), "exceptionSupport", typeof(UnityEditor.WebGLExceptionSupport), 0);
//                 }
//                 UnityEditor.PlayerSettings.WebGL.exceptionSupport = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_dataCaching(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.PlayerSettings.WebGL.dataCaching;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_dataCaching(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 bool value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.PlayerSettings.WebGL), "dataCaching", typeof(bool), 0);
//                 }
//                 UnityEditor.PlayerSettings.WebGL.dataCaching = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_emscriptenArgs(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.PlayerSettings.WebGL.emscriptenArgs;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_emscriptenArgs(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 string value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.PlayerSettings.WebGL), "emscriptenArgs", typeof(string), 0);
//                 }
//                 UnityEditor.PlayerSettings.WebGL.emscriptenArgs = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_modulesDirectory(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.PlayerSettings.WebGL.modulesDirectory;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_modulesDirectory(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 string value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.PlayerSettings.WebGL), "modulesDirectory", typeof(string), 0);
//                 }
//                 UnityEditor.PlayerSettings.WebGL.modulesDirectory = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_template(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.PlayerSettings.WebGL.template;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_template(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 string value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.PlayerSettings.WebGL), "template", typeof(string), 0);
//                 }
//                 UnityEditor.PlayerSettings.WebGL.template = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_analyzeBuildSize(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.PlayerSettings.WebGL.analyzeBuildSize;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_analyzeBuildSize(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 bool value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.PlayerSettings.WebGL), "analyzeBuildSize", typeof(bool), 0);
//                 }
//                 UnityEditor.PlayerSettings.WebGL.analyzeBuildSize = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_useEmbeddedResources(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.PlayerSettings.WebGL.useEmbeddedResources;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_useEmbeddedResources(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 bool value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.PlayerSettings.WebGL), "useEmbeddedResources", typeof(bool), 0);
//                 }
//                 UnityEditor.PlayerSettings.WebGL.useEmbeddedResources = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_threadsSupport(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.PlayerSettings.WebGL.threadsSupport;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_threadsSupport(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 bool value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.PlayerSettings.WebGL), "threadsSupport", typeof(bool), 0);
//                 }
//                 UnityEditor.PlayerSettings.WebGL.threadsSupport = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_linkerTarget(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.PlayerSettings.WebGL.linkerTarget;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_linkerTarget(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 UnityEditor.WebGLLinkerTarget value;
//                 if (!Values.js_get_enumvalue(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.PlayerSettings.WebGL), "linkerTarget", typeof(UnityEditor.WebGLLinkerTarget), 0);
//                 }
//                 UnityEditor.PlayerSettings.WebGL.linkerTarget = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_compressionFormat(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.PlayerSettings.WebGL.compressionFormat;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_compressionFormat(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 UnityEditor.WebGLCompressionFormat value;
//                 if (!Values.js_get_enumvalue(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.PlayerSettings.WebGL), "compressionFormat", typeof(UnityEditor.WebGLCompressionFormat), 0);
//                 }
//                 UnityEditor.PlayerSettings.WebGL.compressionFormat = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_nameFilesAsHashes(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.PlayerSettings.WebGL.nameFilesAsHashes;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_nameFilesAsHashes(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 bool value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.PlayerSettings.WebGL), "nameFilesAsHashes", typeof(bool), 0);
//                 }
//                 UnityEditor.PlayerSettings.WebGL.nameFilesAsHashes = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_debugSymbols(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.PlayerSettings.WebGL.debugSymbols;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_debugSymbols(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 bool value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.PlayerSettings.WebGL), "debugSymbols", typeof(bool), 0);
//                 }
//                 UnityEditor.PlayerSettings.WebGL.debugSymbols = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_wasmStreaming(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEditor.PlayerSettings.WebGL.wasmStreaming;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_wasmStreaming(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 bool value;
//                 if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEditor.PlayerSettings.WebGL), "wasmStreaming", typeof(bool), 0);
//                 }
//                 UnityEditor.PlayerSettings.WebGL.wasmStreaming = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
//         {
//             var cls = register.CreateClass("WebGL", typeof(UnityEditor.PlayerSettings.WebGL), BindConstructor);
//             cls.AddProperty(true, "memorySize", BindStaticRead_memorySize, BindStaticWrite_memorySize);
//             cls.AddProperty(true, "exceptionSupport", BindStaticRead_exceptionSupport, BindStaticWrite_exceptionSupport);
//             cls.AddProperty(true, "dataCaching", BindStaticRead_dataCaching, BindStaticWrite_dataCaching);
//             cls.AddProperty(true, "emscriptenArgs", BindStaticRead_emscriptenArgs, BindStaticWrite_emscriptenArgs);
//             cls.AddProperty(true, "modulesDirectory", BindStaticRead_modulesDirectory, BindStaticWrite_modulesDirectory);
//             cls.AddProperty(true, "template", BindStaticRead_template, BindStaticWrite_template);
//             cls.AddProperty(true, "analyzeBuildSize", BindStaticRead_analyzeBuildSize, BindStaticWrite_analyzeBuildSize);
//             cls.AddProperty(true, "useEmbeddedResources", BindStaticRead_useEmbeddedResources, BindStaticWrite_useEmbeddedResources);
//             cls.AddProperty(true, "threadsSupport", BindStaticRead_threadsSupport, BindStaticWrite_threadsSupport);
//             cls.AddProperty(true, "linkerTarget", BindStaticRead_linkerTarget, BindStaticWrite_linkerTarget);
//             cls.AddProperty(true, "compressionFormat", BindStaticRead_compressionFormat, BindStaticWrite_compressionFormat);
//             cls.AddProperty(true, "nameFilesAsHashes", BindStaticRead_nameFilesAsHashes, BindStaticWrite_nameFilesAsHashes);
//             cls.AddProperty(true, "debugSymbols", BindStaticRead_debugSymbols, BindStaticWrite_debugSymbols);
//             cls.AddProperty(true, "wasmStreaming", BindStaticRead_wasmStreaming, BindStaticWrite_wasmStreaming);
//             return cls;
//         }
//     }
// }
// #endif
// #endif
