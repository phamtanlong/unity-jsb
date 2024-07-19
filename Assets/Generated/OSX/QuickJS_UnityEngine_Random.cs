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
//     // Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
//     // Location: /Applications/Unity/Hub/Editor/2019.4.40f1/Unity.app/Contents/Managed/UnityEngine/UnityEngine.CoreModule.dll
//     // Type: UnityEngine.Random
//     [JSBindingAttribute]
//     public class QuickJS_UnityEngine_Random
//     {
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
//         public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
//         {
//             try
//             {
//                 if (argc == 0)
//                 {
//                     var o = new UnityEngine.Random();
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
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
//         public static JSValue BindStatic_InitState(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
//         {
//             try
//             {
//                 if (argc == 1)
//                 {
//                     int arg0;
//                     if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
//                     {
//                         throw new ParameterException(typeof(UnityEngine.Random), "InitState", typeof(int), 0);
//                     }
//                     UnityEngine.Random.InitState(arg0);
//                     return JSApi.JS_UNDEFINED;
//                 }
//                 throw new NoSuitableMethodException("InitState", argc);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
//         public static JSValue BindStatic_Range(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
//         {
//             try
//             {
//                 do
//                 {
//                     if (argc == 2)
//                     {
//                         if (Values.js_match_type(ctx, argv[0], typeof(float)) && Values.js_match_type(ctx, argv[1], typeof(float)))
//                         {
//                             float arg0;
//                             if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
//                             {
//                                 throw new ParameterException(typeof(UnityEngine.Random), "Range", typeof(float), 0);
//                             }
//                             float arg1;
//                             if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
//                             {
//                                 throw new ParameterException(typeof(UnityEngine.Random), "Range", typeof(float), 1);
//                             }
//                             var ret = UnityEngine.Random.Range(arg0, arg1);
//                             return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//                         }
//                         if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(int)))
//                         {
//                             int arg0;
//                             if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
//                             {
//                                 throw new ParameterException(typeof(UnityEngine.Random), "Range", typeof(int), 0);
//                             }
//                             int arg1;
//                             if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
//                             {
//                                 throw new ParameterException(typeof(UnityEngine.Random), "Range", typeof(int), 1);
//                             }
//                             var ret = UnityEngine.Random.Range(arg0, arg1);
//                             return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//                         }
//                     }
//                 } while(false);
//                 throw new NoSuitableMethodException("Range", argc);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
//         public static JSValue BindStatic_ColorHSV(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
//         {
//             try
//             {
//                 do
//                 {
//                     if (argc == 8)
//                     {
//                         float arg0;
//                         if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
//                         {
//                             throw new ParameterException(typeof(UnityEngine.Random), "ColorHSV", typeof(float), 0);
//                         }
//                         float arg1;
//                         if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
//                         {
//                             throw new ParameterException(typeof(UnityEngine.Random), "ColorHSV", typeof(float), 1);
//                         }
//                         float arg2;
//                         if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
//                         {
//                             throw new ParameterException(typeof(UnityEngine.Random), "ColorHSV", typeof(float), 2);
//                         }
//                         float arg3;
//                         if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
//                         {
//                             throw new ParameterException(typeof(UnityEngine.Random), "ColorHSV", typeof(float), 3);
//                         }
//                         float arg4;
//                         if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
//                         {
//                             throw new ParameterException(typeof(UnityEngine.Random), "ColorHSV", typeof(float), 4);
//                         }
//                         float arg5;
//                         if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
//                         {
//                             throw new ParameterException(typeof(UnityEngine.Random), "ColorHSV", typeof(float), 5);
//                         }
//                         float arg6;
//                         if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[6], out arg6))
//                         {
//                             throw new ParameterException(typeof(UnityEngine.Random), "ColorHSV", typeof(float), 6);
//                         }
//                         float arg7;
//                         if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[7], out arg7))
//                         {
//                             throw new ParameterException(typeof(UnityEngine.Random), "ColorHSV", typeof(float), 7);
//                         }
//                         var ret = UnityEngine.Random.ColorHSV(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
//                         return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
//                     }
//                     if (argc == 6)
//                     {
//                         float arg0;
//                         if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
//                         {
//                             throw new ParameterException(typeof(UnityEngine.Random), "ColorHSV", typeof(float), 0);
//                         }
//                         float arg1;
//                         if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
//                         {
//                             throw new ParameterException(typeof(UnityEngine.Random), "ColorHSV", typeof(float), 1);
//                         }
//                         float arg2;
//                         if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
//                         {
//                             throw new ParameterException(typeof(UnityEngine.Random), "ColorHSV", typeof(float), 2);
//                         }
//                         float arg3;
//                         if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
//                         {
//                             throw new ParameterException(typeof(UnityEngine.Random), "ColorHSV", typeof(float), 3);
//                         }
//                         float arg4;
//                         if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
//                         {
//                             throw new ParameterException(typeof(UnityEngine.Random), "ColorHSV", typeof(float), 4);
//                         }
//                         float arg5;
//                         if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
//                         {
//                             throw new ParameterException(typeof(UnityEngine.Random), "ColorHSV", typeof(float), 5);
//                         }
//                         var ret = UnityEngine.Random.ColorHSV(arg0, arg1, arg2, arg3, arg4, arg5);
//                         return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
//                     }
//                     if (argc == 4)
//                     {
//                         float arg0;
//                         if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
//                         {
//                             throw new ParameterException(typeof(UnityEngine.Random), "ColorHSV", typeof(float), 0);
//                         }
//                         float arg1;
//                         if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
//                         {
//                             throw new ParameterException(typeof(UnityEngine.Random), "ColorHSV", typeof(float), 1);
//                         }
//                         float arg2;
//                         if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
//                         {
//                             throw new ParameterException(typeof(UnityEngine.Random), "ColorHSV", typeof(float), 2);
//                         }
//                         float arg3;
//                         if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
//                         {
//                             throw new ParameterException(typeof(UnityEngine.Random), "ColorHSV", typeof(float), 3);
//                         }
//                         var ret = UnityEngine.Random.ColorHSV(arg0, arg1, arg2, arg3);
//                         return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
//                     }
//                     if (argc == 2)
//                     {
//                         float arg0;
//                         if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
//                         {
//                             throw new ParameterException(typeof(UnityEngine.Random), "ColorHSV", typeof(float), 0);
//                         }
//                         float arg1;
//                         if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
//                         {
//                             throw new ParameterException(typeof(UnityEngine.Random), "ColorHSV", typeof(float), 1);
//                         }
//                         var ret = UnityEngine.Random.ColorHSV(arg0, arg1);
//                         return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
//                     }
//                     if (argc == 0)
//                     {
//                         var ret = UnityEngine.Random.ColorHSV();
//                         return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
//                     }
//                 } while(false);
//                 throw new NoSuitableMethodException("ColorHSV", argc);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_state(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEngine.Random.state;
//                 return Values.js_push_structvalue(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
//         public static JSValue BindStaticWrite_state(JSContext ctx, JSValue this_obj, JSValue arg_val)
//         {
//             try
//             {
//                 UnityEngine.Random.State value;
//                 if (!Values.js_get_structvalue(ctx, arg_val, out value))
//                 {
//                     throw new ParameterException(typeof(UnityEngine.Random), "state", typeof(UnityEngine.Random.State), 0);
//                 }
//                 UnityEngine.Random.state = value;
//                 return JSApi.JS_UNDEFINED;
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_value(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEngine.Random.value;
//                 return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_insideUnitSphere(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEngine.Random.insideUnitSphere;
//                 return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_insideUnitCircle(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEngine.Random.insideUnitCircle;
//                 return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_onUnitSphere(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEngine.Random.onUnitSphere;
//                 return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_rotation(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEngine.Random.rotation;
//                 return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
//         public static JSValue BindStaticRead_rotationUniform(JSContext ctx, JSValue this_obj)
//         {
//             try
//             {
//                 var ret = UnityEngine.Random.rotationUniform;
//                 return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
//             }
//             catch (Exception exception)
//             {
//                 return JSNative.ThrowException(ctx, exception);
//             }
//         }
//         public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
//         {
//             var cls = register.CreateClass("Random", typeof(UnityEngine.Random), BindConstructor);
//             cls.AddMethod(true, "InitState", BindStatic_InitState);
//             cls.AddMethod(true, "Range", BindStatic_Range);
//             cls.AddMethod(true, "ColorHSV", BindStatic_ColorHSV);
//             cls.AddProperty(true, "state", BindStaticRead_state, BindStaticWrite_state);
//             cls.AddProperty(true, "value", BindStaticRead_value, null);
//             cls.AddProperty(true, "insideUnitSphere", BindStaticRead_insideUnitSphere, null);
//             cls.AddProperty(true, "insideUnitCircle", BindStaticRead_insideUnitCircle, null);
//             cls.AddProperty(true, "onUnitSphere", BindStaticRead_onUnitSphere, null);
//             cls.AddProperty(true, "rotation", BindStaticRead_rotation, null);
//             cls.AddProperty(true, "rotationUniform", BindStaticRead_rotationUniform, null);
//             return cls;
//         }
//     }
// }
// #endif
