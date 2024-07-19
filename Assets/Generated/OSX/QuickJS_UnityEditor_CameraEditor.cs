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
    // Type: UnityEditor.CameraEditor
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_CameraEditor
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new UnityEditor.CameraEditor();
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
        public static JSValue Bind_OnEnable(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.CameraEditor self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.OnEnable();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("OnEnable", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_OnDestroy(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.CameraEditor self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.OnDestroy();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("OnDestroy", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_OnInspectorGUI(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.CameraEditor self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.OnInspectorGUI();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("OnInspectorGUI", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_OnOverlayGUI(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.CameraEditor self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.CameraEditor), "OnOverlayGUI", typeof(UnityEngine.Object), 0);
                    }
                    UnityEditor.SceneView arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.CameraEditor), "OnOverlayGUI", typeof(UnityEditor.SceneView), 1);
                    }
                    self.OnOverlayGUI(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("OnOverlayGUI", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_OnSceneGUI(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.CameraEditor self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.OnSceneGUI();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("OnSceneGUI", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("CameraEditor", typeof(UnityEditor.CameraEditor), BindConstructor);
            cls.AddMethod(false, "OnEnable", Bind_OnEnable);
            cls.AddMethod(false, "OnDestroy", Bind_OnDestroy);
            cls.AddMethod(false, "OnInspectorGUI", Bind_OnInspectorGUI);
            cls.AddMethod(false, "OnOverlayGUI", Bind_OnOverlayGUI);
            cls.AddMethod(false, "OnSceneGUI", Bind_OnSceneGUI);
            return cls;
        }
    }
}
#endif
#endif
