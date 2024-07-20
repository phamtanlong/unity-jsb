#if UNITY_EDITOR
#if UNITY_STANDALONE_OSX
// Unity: 2021.3.37f1
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
    // Assembly: UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2021.3.37f1/Unity.app/Contents/Managed/UnityEngine/UnityEditor.CoreModule.dll
    // Type: UnityEditor.ChangeGameObjectParentEventArgs
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_ChangeGameObjectParentEventArgs
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 5)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ChangeGameObjectParentEventArgs), ".ctor", typeof(int), 0);
                    }
                    UnityEngine.SceneManagement.Scene arg1;
                    if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.ChangeGameObjectParentEventArgs), ".ctor", typeof(UnityEngine.SceneManagement.Scene), 1);
                    }
                    int arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.ChangeGameObjectParentEventArgs), ".ctor", typeof(int), 2);
                    }
                    UnityEngine.SceneManagement.Scene arg3;
                    if (!Values.js_get_structvalue(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.ChangeGameObjectParentEventArgs), ".ctor", typeof(UnityEngine.SceneManagement.Scene), 3);
                    }
                    int arg4;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.ChangeGameObjectParentEventArgs), ".ctor", typeof(int), 4);
                    }
                    var o = new UnityEditor.ChangeGameObjectParentEventArgs(arg0, arg1, arg2, arg3, arg4);
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
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_instanceId(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.ChangeGameObjectParentEventArgs self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.instanceId;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_previousParentInstanceId(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.ChangeGameObjectParentEventArgs self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.previousParentInstanceId;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_newParentInstanceId(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.ChangeGameObjectParentEventArgs self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.newParentInstanceId;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_previousScene(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.ChangeGameObjectParentEventArgs self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.previousScene;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_newScene(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.ChangeGameObjectParentEventArgs self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.newScene;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("ChangeGameObjectParentEventArgs", typeof(UnityEditor.ChangeGameObjectParentEventArgs), BindConstructor);
            cls.AddProperty(false, "instanceId", BindRead_instanceId, null);
            cls.AddProperty(false, "previousParentInstanceId", BindRead_previousParentInstanceId, null);
            cls.AddProperty(false, "newParentInstanceId", BindRead_newParentInstanceId, null);
            cls.AddProperty(false, "previousScene", BindRead_previousScene, null);
            cls.AddProperty(false, "newScene", BindRead_newScene, null);
            return cls;
        }
    }
}
#endif
#endif
