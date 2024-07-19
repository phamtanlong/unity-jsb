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
//     // Type: UnityEditor.Build.IIl2CppProcessor
//     [JSBindingAttribute]
//     public class QuickJS_UnityEditor_Build_IIl2CppProcessor
//     {
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
//         public static JSValue Bind_OnBeforeConvertRun(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
//         {
//             try
//             {
//                 if (argc == 2)
//                 {
//                     UnityEditor.Build.IIl2CppProcessor self;
//                     if (!Values.js_get_classvalue(ctx, this_obj, out self))
//                     {
//                         throw new ThisBoundException();
//                     }
//                     UnityEditor.Build.Reporting.BuildReport arg0;
//                     if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
//                     {
//                         throw new ParameterException(typeof(UnityEditor.Build.IIl2CppProcessor), "OnBeforeConvertRun", typeof(UnityEditor.Build.Reporting.BuildReport), 0);
//                     }
//                     UnityEditor.Il2Cpp.Il2CppBuildPipelineData arg1;
//                     if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
//                     {
//                         throw new ParameterException(typeof(UnityEditor.Build.IIl2CppProcessor), "OnBeforeConvertRun", typeof(UnityEditor.Il2Cpp.Il2CppBuildPipelineData), 1);
//                     }
//                     self.OnBeforeConvertRun(arg0, arg1);
//                     return JSApi.JS_UNDEFINED;
//                 }
//                 throw new NoSuitableMethodException("OnBeforeConvertRun", argc);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
//         {
//             var cls = register.CreateClass("IIl2CppProcessor", typeof(UnityEditor.Build.IIl2CppProcessor), QuickJS.JSNative.class_private_ctor);
//             cls.AddMethod(false, "OnBeforeConvertRun", Bind_OnBeforeConvertRun);
//             return cls;
//         }
//     }
// }
// #endif
// #endif
