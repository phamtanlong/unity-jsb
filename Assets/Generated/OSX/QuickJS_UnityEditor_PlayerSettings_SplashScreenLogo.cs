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
    // Type: UnityEditor.PlayerSettings+SplashScreenLogo
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_PlayerSettings_SplashScreenLogo
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                var o = new UnityEditor.PlayerSettings.SplashScreenLogo();
                var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                return val;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Create(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        float arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.PlayerSettings.SplashScreenLogo), "Create", typeof(float), 0);
                        }
                        UnityEngine.Sprite arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.PlayerSettings.SplashScreenLogo), "Create", typeof(UnityEngine.Sprite), 1);
                        }
                        var ret = UnityEditor.PlayerSettings.SplashScreenLogo.Create(arg0, arg1);
                        return Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        float arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.PlayerSettings.SplashScreenLogo), "Create", typeof(float), 0);
                        }
                        var ret = UnityEditor.PlayerSettings.SplashScreenLogo.Create(arg0);
                        return Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 0)
                    {
                        var ret = UnityEditor.PlayerSettings.SplashScreenLogo.Create();
                        return Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("Create", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CreateWithUnityLogo(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        float arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.PlayerSettings.SplashScreenLogo), "CreateWithUnityLogo", typeof(float), 0);
                        }
                        var ret = UnityEditor.PlayerSettings.SplashScreenLogo.CreateWithUnityLogo(arg0);
                        return Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 0)
                    {
                        var ret = UnityEditor.PlayerSettings.SplashScreenLogo.CreateWithUnityLogo();
                        return Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("CreateWithUnityLogo", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_logo(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.PlayerSettings.SplashScreenLogo self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.logo;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_logo(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.PlayerSettings.SplashScreenLogo self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Sprite value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.SplashScreenLogo), "logo", typeof(UnityEngine.Sprite), 0);
                }
                self.logo = value;
                Values.js_rebind_this(ctx, this_obj, ref self);
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_unityLogo(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PlayerSettings.SplashScreenLogo.unityLogo;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_duration(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.PlayerSettings.SplashScreenLogo self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.duration;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_duration(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.PlayerSettings.SplashScreenLogo self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PlayerSettings.SplashScreenLogo), "duration", typeof(float), 0);
                }
                self.duration = value;
                Values.js_rebind_this(ctx, this_obj, ref self);
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("SplashScreenLogo", typeof(UnityEditor.PlayerSettings.SplashScreenLogo), BindConstructor);
            cls.AddMethod(true, "Create", BindStatic_Create);
            cls.AddMethod(true, "CreateWithUnityLogo", BindStatic_CreateWithUnityLogo);
            cls.AddProperty(false, "logo", BindRead_logo, BindWrite_logo);
            cls.AddProperty(true, "unityLogo", BindStaticRead_unityLogo, null);
            cls.AddProperty(false, "duration", BindRead_duration, BindWrite_duration);
            return cls;
        }
    }
}
#endif
#endif
