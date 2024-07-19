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
    // Type: UnityEditor.BuildPlayerWindow
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_BuildPlayerWindow
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new UnityEditor.BuildPlayerWindow();
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
        public static JSValue BindStatic_ShowBuildPlayerWindow(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.BuildPlayerWindow.ShowBuildPlayerWindow();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ShowBuildPlayerWindow", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetPlaybackEngineDownloadURL(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.BuildPlayerWindow), "GetPlaybackEngineDownloadURL", typeof(string), 0);
                    }
                    var ret = UnityEditor.BuildPlayerWindow.GetPlaybackEngineDownloadURL(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetPlaybackEngineDownloadURL", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RegisterGetBuildPlayerOptionsHandler(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    System.Func<UnityEditor.BuildPlayerOptions, UnityEditor.BuildPlayerOptions> arg0;
                    if (!Values.js_get_delegate(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.BuildPlayerWindow), "RegisterGetBuildPlayerOptionsHandler", typeof(System.Func<UnityEditor.BuildPlayerOptions, UnityEditor.BuildPlayerOptions>), 0);
                    }
                    UnityEditor.BuildPlayerWindow.RegisterGetBuildPlayerOptionsHandler(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RegisterGetBuildPlayerOptionsHandler", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RegisterBuildPlayerHandler(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    System.Action<UnityEditor.BuildPlayerOptions> arg0;
                    if (!Values.js_get_delegate(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.BuildPlayerWindow), "RegisterBuildPlayerHandler", typeof(System.Action<UnityEditor.BuildPlayerOptions>), 0);
                    }
                    UnityEditor.BuildPlayerWindow.RegisterBuildPlayerHandler(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RegisterBuildPlayerHandler", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("BuildPlayerWindow", typeof(UnityEditor.BuildPlayerWindow), BindConstructor);
            cls.AddMethod(true, "ShowBuildPlayerWindow", BindStatic_ShowBuildPlayerWindow);
            cls.AddMethod(true, "GetPlaybackEngineDownloadURL", BindStatic_GetPlaybackEngineDownloadURL);
            cls.AddMethod(true, "RegisterGetBuildPlayerOptionsHandler", BindStatic_RegisterGetBuildPlayerOptionsHandler);
            cls.AddMethod(true, "RegisterBuildPlayerHandler", BindStatic_RegisterBuildPlayerHandler);
            return cls;
        }
    }
}
#endif
#endif
