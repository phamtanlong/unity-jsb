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
    // Type: UnityEditor.AssetSettingsProvider
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_AssetSettingsProvider
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetSettingsProvider), ".ctor", typeof(string), 0);
                        }
                        System.Func<UnityEditor.Editor> arg1;
                        if (!Values.js_get_delegate(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetSettingsProvider), ".ctor", typeof(System.Func<UnityEditor.Editor>), 1);
                        }
                        System.Collections.Generic.IEnumerable<string> arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetSettingsProvider), ".ctor", typeof(System.Collections.Generic.IEnumerable<string>), 2);
                        }
                        var o = new UnityEditor.AssetSettingsProvider(arg0, arg1, arg2);
                        var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                        return val;
                    }
                    if (argc == 2)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetSettingsProvider), ".ctor", typeof(string), 0);
                        }
                        System.Func<UnityEngine.Object> arg1;
                        if (!Values.js_get_delegate(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetSettingsProvider), ".ctor", typeof(System.Func<UnityEngine.Object>), 1);
                        }
                        var o = new UnityEditor.AssetSettingsProvider(arg0, arg1);
                        var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                        return val;
                    }
                } while(false);
                throw new NoSuitableMethodException("constructor", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_OnActivate(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.AssetSettingsProvider self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetSettingsProvider), "OnActivate", typeof(string), 0);
                    }
                    UnityEngine.UIElements.VisualElement arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetSettingsProvider), "OnActivate", typeof(UnityEngine.UIElements.VisualElement), 1);
                    }
                    self.OnActivate(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("OnActivate", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_OnDeactivate(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.AssetSettingsProvider self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.OnDeactivate();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("OnDeactivate", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_OnGUI(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.AssetSettingsProvider self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetSettingsProvider), "OnGUI", typeof(string), 0);
                    }
                    self.OnGUI(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("OnGUI", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_OnTitleBarGUI(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.AssetSettingsProvider self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.OnTitleBarGUI();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("OnTitleBarGUI", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_OnFooterBarGUI(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.AssetSettingsProvider self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.OnFooterBarGUI();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("OnFooterBarGUI", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CreateProviderFromAssetPath(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetSettingsProvider), "CreateProviderFromAssetPath", typeof(string), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetSettingsProvider), "CreateProviderFromAssetPath", typeof(string), 1);
                    }
                    System.Collections.Generic.IEnumerable<string> arg2;
                    if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetSettingsProvider), "CreateProviderFromAssetPath", typeof(System.Collections.Generic.IEnumerable<string>), 2);
                    }
                    var ret = UnityEditor.AssetSettingsProvider.CreateProviderFromAssetPath(arg0, arg1, arg2);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("CreateProviderFromAssetPath", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CreateProviderFromObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetSettingsProvider), "CreateProviderFromObject", typeof(string), 0);
                    }
                    UnityEngine.Object arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetSettingsProvider), "CreateProviderFromObject", typeof(UnityEngine.Object), 1);
                    }
                    System.Collections.Generic.IEnumerable<string> arg2;
                    if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetSettingsProvider), "CreateProviderFromObject", typeof(System.Collections.Generic.IEnumerable<string>), 2);
                    }
                    var ret = UnityEditor.AssetSettingsProvider.CreateProviderFromObject(arg0, arg1, arg2);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("CreateProviderFromObject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CreateProviderFromResourcePath(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetSettingsProvider), "CreateProviderFromResourcePath", typeof(string), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetSettingsProvider), "CreateProviderFromResourcePath", typeof(string), 1);
                    }
                    System.Collections.Generic.IEnumerable<string> arg2;
                    if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetSettingsProvider), "CreateProviderFromResourcePath", typeof(System.Collections.Generic.IEnumerable<string>), 2);
                    }
                    var ret = UnityEditor.AssetSettingsProvider.CreateProviderFromResourcePath(arg0, arg1, arg2);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("CreateProviderFromResourcePath", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_settingsEditor(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.AssetSettingsProvider self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.settingsEditor;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("AssetSettingsProvider", typeof(UnityEditor.AssetSettingsProvider), BindConstructor);
            cls.AddMethod(false, "OnActivate", Bind_OnActivate);
            cls.AddMethod(false, "OnDeactivate", Bind_OnDeactivate);
            cls.AddMethod(false, "OnGUI", Bind_OnGUI);
            cls.AddMethod(false, "OnTitleBarGUI", Bind_OnTitleBarGUI);
            cls.AddMethod(false, "OnFooterBarGUI", Bind_OnFooterBarGUI);
            cls.AddMethod(true, "CreateProviderFromAssetPath", BindStatic_CreateProviderFromAssetPath);
            cls.AddMethod(true, "CreateProviderFromObject", BindStatic_CreateProviderFromObject);
            cls.AddMethod(true, "CreateProviderFromResourcePath", BindStatic_CreateProviderFromResourcePath);
            cls.AddProperty(false, "settingsEditor", BindRead_settingsEditor, null);
            return cls;
        }
    }
}
#endif
#endif
