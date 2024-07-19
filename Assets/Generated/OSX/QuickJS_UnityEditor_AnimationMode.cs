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
    // Type: UnityEditor.AnimationMode
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_AnimationMode
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new UnityEditor.AnimationMode();
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
        public static JSValue BindStatic_IsPropertyAnimated(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationMode), "IsPropertyAnimated", typeof(UnityEngine.Object), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationMode), "IsPropertyAnimated", typeof(string), 1);
                    }
                    var ret = UnityEditor.AnimationMode.IsPropertyAnimated(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsPropertyAnimated", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_StopAnimationMode(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.AnimationMode.StopAnimationMode();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("StopAnimationMode", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_InAnimationMode(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.AnimationMode.InAnimationMode();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("InAnimationMode", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_StartAnimationMode(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.AnimationMode.StartAnimationMode();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("StartAnimationMode", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_BeginSampling(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.AnimationMode.BeginSampling();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("BeginSampling", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_EndSampling(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.AnimationMode.EndSampling();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("EndSampling", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SampleAnimationClip(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationMode), "SampleAnimationClip", typeof(UnityEngine.GameObject), 0);
                    }
                    UnityEngine.AnimationClip arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationMode), "SampleAnimationClip", typeof(UnityEngine.AnimationClip), 1);
                    }
                    float arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationMode), "SampleAnimationClip", typeof(float), 2);
                    }
                    UnityEditor.AnimationMode.SampleAnimationClip(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SampleAnimationClip", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_AddPropertyModification(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEditor.EditorCurveBinding arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationMode), "AddPropertyModification", typeof(UnityEditor.EditorCurveBinding), 0);
                    }
                    UnityEditor.PropertyModification arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationMode), "AddPropertyModification", typeof(UnityEditor.PropertyModification), 1);
                    }
                    bool arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationMode), "AddPropertyModification", typeof(bool), 2);
                    }
                    UnityEditor.AnimationMode.AddPropertyModification(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("AddPropertyModification", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_AddEditorCurveBinding(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationMode), "AddEditorCurveBinding", typeof(UnityEngine.GameObject), 0);
                    }
                    UnityEditor.EditorCurveBinding arg1;
                    if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AnimationMode), "AddEditorCurveBinding", typeof(UnityEditor.EditorCurveBinding), 1);
                    }
                    UnityEditor.AnimationMode.AddEditorCurveBinding(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("AddEditorCurveBinding", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_animatedPropertyColor(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.AnimationMode.animatedPropertyColor;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_recordedPropertyColor(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.AnimationMode.recordedPropertyColor;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_candidatePropertyColor(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.AnimationMode.candidatePropertyColor;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("AnimationMode", typeof(UnityEditor.AnimationMode), BindConstructor);
            cls.AddMethod(true, "IsPropertyAnimated", BindStatic_IsPropertyAnimated);
            cls.AddMethod(true, "StopAnimationMode", BindStatic_StopAnimationMode);
            cls.AddMethod(true, "InAnimationMode", BindStatic_InAnimationMode);
            cls.AddMethod(true, "StartAnimationMode", BindStatic_StartAnimationMode);
            cls.AddMethod(true, "BeginSampling", BindStatic_BeginSampling);
            cls.AddMethod(true, "EndSampling", BindStatic_EndSampling);
            cls.AddMethod(true, "SampleAnimationClip", BindStatic_SampleAnimationClip);
            cls.AddMethod(true, "AddPropertyModification", BindStatic_AddPropertyModification);
            cls.AddMethod(true, "AddEditorCurveBinding", BindStatic_AddEditorCurveBinding);
            cls.AddProperty(true, "animatedPropertyColor", BindStaticRead_animatedPropertyColor, null);
            cls.AddProperty(true, "recordedPropertyColor", BindStaticRead_recordedPropertyColor, null);
            cls.AddProperty(true, "candidatePropertyColor", BindStaticRead_candidatePropertyColor, null);
            return cls;
        }
    }
}
#endif
#endif
