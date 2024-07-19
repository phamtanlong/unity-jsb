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
    // Assembly: jsb.editor.unity, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Users/longpt/Documents/SkyMavis/unity-jsb-2/Library/ScriptAssemblies/jsb.editor.unity.dll
    // Type: QuickJS.Unity.UnityHelper
    [JSBindingAttribute]
    public class QuickJS_QuickJS_Unity_UnityHelper
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetIcon(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(QuickJS.Unity.UnityHelper), "GetIcon", typeof(string), 0);
                    }
                    var ret = QuickJS.Unity.UnityHelper.GetIcon(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetIcon", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsApplicationActive(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = QuickJS.Unity.UnityHelper.IsApplicationActive();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsApplicationActive", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GenerateBindingsAndTypeDefinition(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    QuickJS.Unity.UnityHelper.GenerateBindingsAndTypeDefinition();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("GenerateBindingsAndTypeDefinition", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GenerateTypeDefinition(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    QuickJS.Unity.UnityHelper.GenerateTypeDefinition();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("GenerateTypeDefinition", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetMonoScript(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    System.Type arg0;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(QuickJS.Unity.UnityHelper), "GetMonoScript", typeof(System.Type), 0);
                    }
                    var ret = QuickJS.Unity.UnityHelper.GetMonoScript(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetMonoScript", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetDefineSymbol(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(QuickJS.Unity.UnityHelper), "SetDefineSymbol", typeof(string), 0);
                    }
                    bool arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(QuickJS.Unity.UnityHelper), "SetDefineSymbol", typeof(bool), 1);
                    }
                    QuickJS.Unity.UnityHelper.SetDefineSymbol(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetDefineSymbol", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsReflectBindingSupported(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = QuickJS.Unity.UnityHelper.IsReflectBindingSupported();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsReflectBindingSupported", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Time(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(QuickJS.Unity.UnityHelper), "Time", typeof(string), 0);
                    }
                    System.Action arg1;
                    if (!Values.js_get_delegate(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(QuickJS.Unity.UnityHelper), "Time", typeof(System.Action), 1);
                    }
                    QuickJS.Unity.UnityHelper.Time(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Time", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_InvokeReflectBinding(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    QuickJS.ScriptRuntime arg0;
                    arg0 = ScriptEngine.GetRuntime(ctx);
                    QuickJS.Unity.UnityHelper.InvokeReflectBinding(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("InvokeReflectBinding", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsInMemoryBindingSupported(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = QuickJS.Unity.UnityHelper.IsInMemoryBindingSupported();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsInMemoryBindingSupported", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_InvokeInMemoryBinding(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    QuickJS.ScriptRuntime arg0;
                    arg0 = ScriptEngine.GetRuntime(ctx);
                    QuickJS.Unity.UnityHelper.InvokeInMemoryBinding(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("InvokeInMemoryBinding", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CompileScripts(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    QuickJS.Unity.UnityHelper.CompileScripts();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CompileScripts", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ClearBindings(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    QuickJS.Unity.UnityHelper.ClearBindings();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ClearBindings", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_OpenPrefsEditor(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    QuickJS.Unity.UnityHelper.OpenPrefsEditor();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("OpenPrefsEditor", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ShowJSConsole(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    QuickJS.Unity.UnityHelper.ShowJSConsole();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ShowJSConsole", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ShowJSModuleView(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    QuickJS.Unity.UnityHelper.ShowJSModuleView();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ShowJSModuleView", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ShowScriptEditorWindowLauncher(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    QuickJS.Unity.UnityHelper.ShowScriptEditorWindowLauncher();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ShowScriptEditorWindowLauncher", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetPlatform(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = QuickJS.Unity.UnityHelper.GetPlatform();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetPlatform", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsExplicitEditorType(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    System.Type arg0;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(QuickJS.Unity.UnityHelper), "IsExplicitEditorType", typeof(System.Type), 0);
                    }
                    var ret = QuickJS.Unity.UnityHelper.IsExplicitEditorType(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsExplicitEditorType", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsExplicitEditorDomain(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    System.Reflection.Assembly arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(QuickJS.Unity.UnityHelper), "IsExplicitEditorDomain", typeof(System.Reflection.Assembly), 0);
                    }
                    var ret = QuickJS.Unity.UnityHelper.IsExplicitEditorDomain(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsExplicitEditorDomain", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ReplacePathVars(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(QuickJS.Unity.UnityHelper), "ReplacePathVars", typeof(string), 0);
                    }
                    var ret = QuickJS.Unity.UnityHelper.ReplacePathVars(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ReplacePathVars", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CompileBytecode(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(QuickJS.Unity.UnityHelper), "CompileBytecode", typeof(string), 0);
                        }
                        System.Collections.Generic.IList<string> arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(QuickJS.Unity.UnityHelper), "CompileBytecode", typeof(System.Collections.Generic.IList<string>), 1);
                        }
                        QuickJS.Unity.UnityHelper.CompileBytecode(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        System.Collections.Generic.IList<string> arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(QuickJS.Unity.UnityHelper), "CompileBytecode", typeof(System.Collections.Generic.IList<string>), 0);
                        }
                        QuickJS.Unity.UnityHelper.CompileBytecode(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("CompileBytecode", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_NormalizePathString(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(QuickJS.Unity.UnityHelper), "NormalizePathString", typeof(string), 0);
                    }
                    var ret = QuickJS.Unity.UnityHelper.NormalizePathString(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("NormalizePathString", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ResolveScriptRef(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 5)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(QuickJS.Unity.UnityHelper), "ResolveScriptRef", typeof(string), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(QuickJS.Unity.UnityHelper), "ResolveScriptRef", typeof(string), 1);
                    }
                    string arg2;
                    string arg3;
                    System.Collections.Generic.List<QuickJS.Unity.JSScriptClassPathHint> arg4;
                    if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(QuickJS.Unity.UnityHelper), "ResolveScriptRef", typeof(System.Collections.Generic.List<QuickJS.Unity.JSScriptClassPathHint>), 4);
                    }
                    var ret = QuickJS.Unity.UnityHelper.ResolveScriptRef(arg0, arg1, out arg2, out arg3, arg4);
                    var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg2);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out0);
                    var out1 = QuickJS.Binding.Values.js_push_primitive(ctx, arg3);
                    if (JSApi.JS_IsException(out1))
                    {
                        return out1;
                    }
                    JSApi.JS_SetProperty(ctx, argv[3], context.GetAtom("value"), out1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ResolveScriptRef", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_RowColor(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = QuickJS.Unity.UnityHelper.RowColor;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_RowColor(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Color value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Unity.UnityHelper), "RowColor", typeof(UnityEngine.Color), 0);
                }
                QuickJS.Unity.UnityHelper.RowColor = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_SelectRowColor(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = QuickJS.Unity.UnityHelper.SelectRowColor;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_SelectRowColor(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Color value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Unity.UnityHelper), "SelectRowColor", typeof(UnityEngine.Color), 0);
                }
                QuickJS.Unity.UnityHelper.SelectRowColor = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_JSBehaviourClassNameRegex(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = QuickJS.Unity.UnityHelper.JSBehaviourClassNameRegex;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_JSBehaviourClassNameRegex(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                System.Text.RegularExpressions.Regex value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Unity.UnityHelper), "JSBehaviourClassNameRegex", typeof(System.Text.RegularExpressions.Regex), 0);
                }
                QuickJS.Unity.UnityHelper.JSBehaviourClassNameRegex = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_JSAssetClassNameRegex(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = QuickJS.Unity.UnityHelper.JSAssetClassNameRegex;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_JSAssetClassNameRegex(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                System.Text.RegularExpressions.Regex value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Unity.UnityHelper), "JSAssetClassNameRegex", typeof(System.Text.RegularExpressions.Regex), 0);
                }
                QuickJS.Unity.UnityHelper.JSAssetClassNameRegex = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_JSCustomEditorClassNameRegex(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = QuickJS.Unity.UnityHelper.JSCustomEditorClassNameRegex;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_JSCustomEditorClassNameRegex(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                System.Text.RegularExpressions.Regex value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Unity.UnityHelper), "JSCustomEditorClassNameRegex", typeof(System.Text.RegularExpressions.Regex), 0);
                }
                QuickJS.Unity.UnityHelper.JSCustomEditorClassNameRegex = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_JSEditorWindowClassNameRegex(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = QuickJS.Unity.UnityHelper.JSEditorWindowClassNameRegex;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_JSEditorWindowClassNameRegex(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                System.Text.RegularExpressions.Regex value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Unity.UnityHelper), "JSEditorWindowClassNameRegex", typeof(System.Text.RegularExpressions.Regex), 0);
                }
                QuickJS.Unity.UnityHelper.JSEditorWindowClassNameRegex = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("UnityHelper", typeof(QuickJS.Unity.UnityHelper), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "GetIcon", BindStatic_GetIcon);
            cls.AddMethod(true, "IsApplicationActive", BindStatic_IsApplicationActive);
            cls.AddMethod(true, "GenerateBindingsAndTypeDefinition", BindStatic_GenerateBindingsAndTypeDefinition);
            cls.AddMethod(true, "GenerateTypeDefinition", BindStatic_GenerateTypeDefinition);
            cls.AddMethod(true, "GetMonoScript", BindStatic_GetMonoScript);
            cls.AddMethod(true, "SetDefineSymbol", BindStatic_SetDefineSymbol);
            cls.AddMethod(true, "IsReflectBindingSupported", BindStatic_IsReflectBindingSupported);
            cls.AddMethod(true, "Time", BindStatic_Time);
            cls.AddMethod(true, "InvokeReflectBinding", BindStatic_InvokeReflectBinding);
            cls.AddMethod(true, "IsInMemoryBindingSupported", BindStatic_IsInMemoryBindingSupported);
            cls.AddMethod(true, "InvokeInMemoryBinding", BindStatic_InvokeInMemoryBinding);
            cls.AddMethod(true, "CompileScripts", BindStatic_CompileScripts);
            cls.AddMethod(true, "ClearBindings", BindStatic_ClearBindings);
            cls.AddMethod(true, "OpenPrefsEditor", BindStatic_OpenPrefsEditor);
            cls.AddMethod(true, "ShowJSConsole", BindStatic_ShowJSConsole);
            cls.AddMethod(true, "ShowJSModuleView", BindStatic_ShowJSModuleView);
            cls.AddMethod(true, "ShowScriptEditorWindowLauncher", BindStatic_ShowScriptEditorWindowLauncher);
            cls.AddMethod(true, "GetPlatform", BindStatic_GetPlatform);
            cls.AddMethod(true, "IsExplicitEditorType", BindStatic_IsExplicitEditorType);
            cls.AddMethod(true, "IsExplicitEditorDomain", BindStatic_IsExplicitEditorDomain);
            cls.AddMethod(true, "ReplacePathVars", BindStatic_ReplacePathVars);
            cls.AddMethod(true, "CompileBytecode", BindStatic_CompileBytecode);
            cls.AddMethod(true, "NormalizePathString", BindStatic_NormalizePathString);
            cls.AddMethod(true, "ResolveScriptRef", BindStatic_ResolveScriptRef);
            cls.AddField(true, "RowColor", BindStaticRead_RowColor, BindStaticWrite_RowColor);
            cls.AddField(true, "SelectRowColor", BindStaticRead_SelectRowColor, BindStaticWrite_SelectRowColor);
            cls.AddField(true, "JSBehaviourClassNameRegex", BindStaticRead_JSBehaviourClassNameRegex, BindStaticWrite_JSBehaviourClassNameRegex);
            cls.AddField(true, "JSAssetClassNameRegex", BindStaticRead_JSAssetClassNameRegex, BindStaticWrite_JSAssetClassNameRegex);
            cls.AddField(true, "JSCustomEditorClassNameRegex", BindStaticRead_JSCustomEditorClassNameRegex, BindStaticWrite_JSCustomEditorClassNameRegex);
            cls.AddField(true, "JSEditorWindowClassNameRegex", BindStaticRead_JSEditorWindowClassNameRegex, BindStaticWrite_JSEditorWindowClassNameRegex);
            return cls;
        }
    }
}
#endif
#endif
