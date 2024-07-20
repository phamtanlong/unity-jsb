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
    // Type: UnityEditor.AssetDatabase
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_AssetDatabase
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CanOpenForEdit(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string[])) && Values.js_match_type(ctx, argv[1], typeof(System.Collections.Generic.List<string>)) && Values.js_match_type(ctx, argv[2], typeof(UnityEditor.StatusQueryOptions)))
                        {
                            string[] arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "CanOpenForEdit", typeof(string[]), 0);
                            }
                            System.Collections.Generic.List<string> arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "CanOpenForEdit", typeof(System.Collections.Generic.List<string>), 1);
                            }
                            UnityEditor.StatusQueryOptions arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "CanOpenForEdit", typeof(UnityEditor.StatusQueryOptions), 2);
                            }
                            UnityEditor.AssetDatabase.CanOpenForEdit(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)) && Values.js_match_type_hint(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEditor.StatusQueryOptions)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "CanOpenForEdit", typeof(UnityEngine.Object), 0);
                            }
                            string arg1;
                            UnityEditor.StatusQueryOptions arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "CanOpenForEdit", typeof(UnityEditor.StatusQueryOptions), 2);
                            }
                            var ret = UnityEditor.AssetDatabase.CanOpenForEdit(arg0, out arg1, arg2);
                            var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg1);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type_hint(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEditor.StatusQueryOptions)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "CanOpenForEdit", typeof(string), 0);
                            }
                            string arg1;
                            UnityEditor.StatusQueryOptions arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "CanOpenForEdit", typeof(UnityEditor.StatusQueryOptions), 2);
                            }
                            var ret = UnityEditor.AssetDatabase.CanOpenForEdit(arg0, out arg1, arg2);
                            var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg1);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.StatusQueryOptions)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "CanOpenForEdit", typeof(UnityEngine.Object), 0);
                            }
                            UnityEditor.StatusQueryOptions arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "CanOpenForEdit", typeof(UnityEditor.StatusQueryOptions), 1);
                            }
                            var ret = UnityEditor.AssetDatabase.CanOpenForEdit(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.StatusQueryOptions)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "CanOpenForEdit", typeof(string), 0);
                            }
                            UnityEditor.StatusQueryOptions arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "CanOpenForEdit", typeof(UnityEditor.StatusQueryOptions), 1);
                            }
                            var ret = UnityEditor.AssetDatabase.CanOpenForEdit(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)) && Values.js_match_type_hint(ctx, argv[1], typeof(string)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "CanOpenForEdit", typeof(UnityEngine.Object), 0);
                            }
                            string arg1;
                            var ret = UnityEditor.AssetDatabase.CanOpenForEdit(arg0, out arg1);
                            var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg1);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type_hint(ctx, argv[1], typeof(string)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "CanOpenForEdit", typeof(string), 0);
                            }
                            string arg1;
                            var ret = UnityEditor.AssetDatabase.CanOpenForEdit(arg0, out arg1);
                            var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg1);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "CanOpenForEdit", typeof(UnityEngine.Object), 0);
                            }
                            var ret = UnityEditor.AssetDatabase.CanOpenForEdit(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "CanOpenForEdit", typeof(string), 0);
                            }
                            var ret = UnityEditor.AssetDatabase.CanOpenForEdit(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("CanOpenForEdit", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsOpenForEdit(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string[])) && Values.js_match_type(ctx, argv[1], typeof(System.Collections.Generic.List<string>)) && Values.js_match_type(ctx, argv[2], typeof(UnityEditor.StatusQueryOptions)))
                        {
                            string[] arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "IsOpenForEdit", typeof(string[]), 0);
                            }
                            System.Collections.Generic.List<string> arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "IsOpenForEdit", typeof(System.Collections.Generic.List<string>), 1);
                            }
                            UnityEditor.StatusQueryOptions arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "IsOpenForEdit", typeof(UnityEditor.StatusQueryOptions), 2);
                            }
                            UnityEditor.AssetDatabase.IsOpenForEdit(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)) && Values.js_match_type_hint(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEditor.StatusQueryOptions)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "IsOpenForEdit", typeof(UnityEngine.Object), 0);
                            }
                            string arg1;
                            UnityEditor.StatusQueryOptions arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "IsOpenForEdit", typeof(UnityEditor.StatusQueryOptions), 2);
                            }
                            var ret = UnityEditor.AssetDatabase.IsOpenForEdit(arg0, out arg1, arg2);
                            var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg1);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type_hint(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEditor.StatusQueryOptions)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "IsOpenForEdit", typeof(string), 0);
                            }
                            string arg1;
                            UnityEditor.StatusQueryOptions arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "IsOpenForEdit", typeof(UnityEditor.StatusQueryOptions), 2);
                            }
                            var ret = UnityEditor.AssetDatabase.IsOpenForEdit(arg0, out arg1, arg2);
                            var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg1);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.StatusQueryOptions)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "IsOpenForEdit", typeof(UnityEngine.Object), 0);
                            }
                            UnityEditor.StatusQueryOptions arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "IsOpenForEdit", typeof(UnityEditor.StatusQueryOptions), 1);
                            }
                            var ret = UnityEditor.AssetDatabase.IsOpenForEdit(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.StatusQueryOptions)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "IsOpenForEdit", typeof(string), 0);
                            }
                            UnityEditor.StatusQueryOptions arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "IsOpenForEdit", typeof(UnityEditor.StatusQueryOptions), 1);
                            }
                            var ret = UnityEditor.AssetDatabase.IsOpenForEdit(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)) && Values.js_match_type_hint(ctx, argv[1], typeof(string)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "IsOpenForEdit", typeof(UnityEngine.Object), 0);
                            }
                            string arg1;
                            var ret = UnityEditor.AssetDatabase.IsOpenForEdit(arg0, out arg1);
                            var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg1);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type_hint(ctx, argv[1], typeof(string)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "IsOpenForEdit", typeof(string), 0);
                            }
                            string arg1;
                            var ret = UnityEditor.AssetDatabase.IsOpenForEdit(arg0, out arg1);
                            var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg1);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "IsOpenForEdit", typeof(UnityEngine.Object), 0);
                            }
                            var ret = UnityEditor.AssetDatabase.IsOpenForEdit(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "IsOpenForEdit", typeof(string), 0);
                            }
                            var ret = UnityEditor.AssetDatabase.IsOpenForEdit(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("IsOpenForEdit", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_MakeEditable(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        string[] arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "MakeEditable", typeof(string[]), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "MakeEditable", typeof(string), 1);
                        }
                        System.Collections.Generic.List<string> arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "MakeEditable", typeof(System.Collections.Generic.List<string>), 2);
                        }
                        var ret = UnityEditor.AssetDatabase.MakeEditable(arg0, arg1, arg2);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "MakeEditable", typeof(string), 0);
                        }
                        var ret = UnityEditor.AssetDatabase.MakeEditable(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("MakeEditable", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_FindAssets(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "FindAssets", typeof(string), 0);
                        }
                        string[] arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "FindAssets", typeof(string[]), 1);
                        }
                        var ret = UnityEditor.AssetDatabase.FindAssets(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "FindAssets", typeof(string), 0);
                        }
                        var ret = UnityEditor.AssetDatabase.FindAssets(arg0);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("FindAssets", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Contains(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "Contains", typeof(UnityEngine.Object), 0);
                            }
                            var ret = UnityEditor.AssetDatabase.Contains(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "Contains", typeof(int), 0);
                            }
                            var ret = UnityEditor.AssetDatabase.Contains(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Contains", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CreateFolder(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "CreateFolder", typeof(string), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "CreateFolder", typeof(string), 1);
                    }
                    var ret = UnityEditor.AssetDatabase.CreateFolder(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("CreateFolder", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsMainAsset(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "IsMainAsset", typeof(UnityEngine.Object), 0);
                            }
                            var ret = UnityEditor.AssetDatabase.IsMainAsset(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "IsMainAsset", typeof(int), 0);
                            }
                            var ret = UnityEditor.AssetDatabase.IsMainAsset(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("IsMainAsset", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsSubAsset(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "IsSubAsset", typeof(UnityEngine.Object), 0);
                            }
                            var ret = UnityEditor.AssetDatabase.IsSubAsset(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "IsSubAsset", typeof(int), 0);
                            }
                            var ret = UnityEditor.AssetDatabase.IsSubAsset(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("IsSubAsset", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsForeignAsset(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "IsForeignAsset", typeof(UnityEngine.Object), 0);
                            }
                            var ret = UnityEditor.AssetDatabase.IsForeignAsset(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "IsForeignAsset", typeof(int), 0);
                            }
                            var ret = UnityEditor.AssetDatabase.IsForeignAsset(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("IsForeignAsset", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsNativeAsset(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "IsNativeAsset", typeof(UnityEngine.Object), 0);
                            }
                            var ret = UnityEditor.AssetDatabase.IsNativeAsset(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "IsNativeAsset", typeof(int), 0);
                            }
                            var ret = UnityEditor.AssetDatabase.IsNativeAsset(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("IsNativeAsset", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetCurrentCacheServerIp(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.AssetDatabase.GetCurrentCacheServerIp();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetCurrentCacheServerIp", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GenerateUniqueAssetPath(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GenerateUniqueAssetPath", typeof(string), 0);
                    }
                    var ret = UnityEditor.AssetDatabase.GenerateUniqueAssetPath(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GenerateUniqueAssetPath", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_StartAssetEditing(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.AssetDatabase.StartAssetEditing();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("StartAssetEditing", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_StopAssetEditing(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.AssetDatabase.StopAssetEditing();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("StopAssetEditing", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ReleaseCachedFileHandles(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.AssetDatabase.ReleaseCachedFileHandles();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ReleaseCachedFileHandles", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ValidateMoveAsset(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "ValidateMoveAsset", typeof(string), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "ValidateMoveAsset", typeof(string), 1);
                    }
                    var ret = UnityEditor.AssetDatabase.ValidateMoveAsset(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ValidateMoveAsset", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_MoveAsset(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "MoveAsset", typeof(string), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "MoveAsset", typeof(string), 1);
                    }
                    var ret = UnityEditor.AssetDatabase.MoveAsset(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("MoveAsset", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ExtractAsset(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "ExtractAsset", typeof(UnityEngine.Object), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "ExtractAsset", typeof(string), 1);
                    }
                    var ret = UnityEditor.AssetDatabase.ExtractAsset(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ExtractAsset", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RenameAsset(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "RenameAsset", typeof(string), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "RenameAsset", typeof(string), 1);
                    }
                    var ret = UnityEditor.AssetDatabase.RenameAsset(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("RenameAsset", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_MoveAssetToTrash(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "MoveAssetToTrash", typeof(string), 0);
                    }
                    var ret = UnityEditor.AssetDatabase.MoveAssetToTrash(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("MoveAssetToTrash", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_MoveAssetsToTrash(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string[] arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "MoveAssetsToTrash", typeof(string[]), 0);
                    }
                    System.Collections.Generic.List<string> arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "MoveAssetsToTrash", typeof(System.Collections.Generic.List<string>), 1);
                    }
                    var ret = UnityEditor.AssetDatabase.MoveAssetsToTrash(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("MoveAssetsToTrash", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DeleteAsset(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "DeleteAsset", typeof(string), 0);
                    }
                    var ret = UnityEditor.AssetDatabase.DeleteAsset(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("DeleteAsset", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DeleteAssets(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string[] arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "DeleteAssets", typeof(string[]), 0);
                    }
                    System.Collections.Generic.List<string> arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "DeleteAssets", typeof(System.Collections.Generic.List<string>), 1);
                    }
                    var ret = UnityEditor.AssetDatabase.DeleteAssets(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("DeleteAssets", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ImportAsset(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "ImportAsset", typeof(string), 0);
                        }
                        UnityEditor.ImportAssetOptions arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "ImportAsset", typeof(UnityEditor.ImportAssetOptions), 1);
                        }
                        UnityEditor.AssetDatabase.ImportAsset(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "ImportAsset", typeof(string), 0);
                        }
                        UnityEditor.AssetDatabase.ImportAsset(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("ImportAsset", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CopyAsset(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "CopyAsset", typeof(string), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "CopyAsset", typeof(string), 1);
                    }
                    var ret = UnityEditor.AssetDatabase.CopyAsset(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("CopyAsset", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_WriteImportSettingsIfDirty(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "WriteImportSettingsIfDirty", typeof(string), 0);
                    }
                    var ret = UnityEditor.AssetDatabase.WriteImportSettingsIfDirty(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("WriteImportSettingsIfDirty", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetSubFolders(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GetSubFolders", typeof(string), 0);
                    }
                    var ret = UnityEditor.AssetDatabase.GetSubFolders(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetSubFolders", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsValidFolder(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "IsValidFolder", typeof(string), 0);
                    }
                    var ret = UnityEditor.AssetDatabase.IsValidFolder(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsValidFolder", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CreateAsset(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "CreateAsset", typeof(UnityEngine.Object), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "CreateAsset", typeof(string), 1);
                    }
                    UnityEditor.AssetDatabase.CreateAsset(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CreateAsset", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_AddObjectToAsset(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[1], typeof(string)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "AddObjectToAsset", typeof(UnityEngine.Object), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "AddObjectToAsset", typeof(string), 1);
                            }
                            UnityEditor.AssetDatabase.AddObjectToAsset(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Object)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "AddObjectToAsset", typeof(UnityEngine.Object), 0);
                            }
                            UnityEngine.Object arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "AddObjectToAsset", typeof(UnityEngine.Object), 1);
                            }
                            UnityEditor.AssetDatabase.AddObjectToAsset(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("AddObjectToAsset", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetMainObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "SetMainObject", typeof(UnityEngine.Object), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "SetMainObject", typeof(string), 1);
                    }
                    UnityEditor.AssetDatabase.SetMainObject(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetMainObject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetAssetPath(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GetAssetPath", typeof(UnityEngine.Object), 0);
                            }
                            var ret = UnityEditor.AssetDatabase.GetAssetPath(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GetAssetPath", typeof(int), 0);
                            }
                            var ret = UnityEditor.AssetDatabase.GetAssetPath(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("GetAssetPath", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetAssetOrScenePath(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GetAssetOrScenePath", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.AssetDatabase.GetAssetOrScenePath(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetAssetOrScenePath", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetTextMetaFilePathFromAssetPath(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GetTextMetaFilePathFromAssetPath", typeof(string), 0);
                    }
                    var ret = UnityEditor.AssetDatabase.GetTextMetaFilePathFromAssetPath(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetTextMetaFilePathFromAssetPath", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetAssetPathFromTextMetaFilePath(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GetAssetPathFromTextMetaFilePath", typeof(string), 0);
                    }
                    var ret = UnityEditor.AssetDatabase.GetAssetPathFromTextMetaFilePath(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetAssetPathFromTextMetaFilePath", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LoadAssetAtPath(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "LoadAssetAtPath", typeof(string), 0);
                    }
                    System.Type arg1;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "LoadAssetAtPath", typeof(System.Type), 1);
                    }
                    var ret = UnityEditor.AssetDatabase.LoadAssetAtPath(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("LoadAssetAtPath", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LoadMainAssetAtPath(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "LoadMainAssetAtPath", typeof(string), 0);
                    }
                    var ret = UnityEditor.AssetDatabase.LoadMainAssetAtPath(arg0);
                    return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("LoadMainAssetAtPath", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetMainAssetTypeAtPath(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GetMainAssetTypeAtPath", typeof(string), 0);
                    }
                    var ret = UnityEditor.AssetDatabase.GetMainAssetTypeAtPath(arg0);
                    return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetMainAssetTypeAtPath", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetTypeFromPathAndFileID(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GetTypeFromPathAndFileID", typeof(string), 0);
                    }
                    long arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GetTypeFromPathAndFileID", typeof(long), 1);
                    }
                    var ret = UnityEditor.AssetDatabase.GetTypeFromPathAndFileID(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetTypeFromPathAndFileID", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsMainAssetAtPathLoaded(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "IsMainAssetAtPathLoaded", typeof(string), 0);
                    }
                    var ret = UnityEditor.AssetDatabase.IsMainAssetAtPathLoaded(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsMainAssetAtPathLoaded", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LoadAllAssetRepresentationsAtPath(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "LoadAllAssetRepresentationsAtPath", typeof(string), 0);
                    }
                    var ret = UnityEditor.AssetDatabase.LoadAllAssetRepresentationsAtPath(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("LoadAllAssetRepresentationsAtPath", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LoadAllAssetsAtPath(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "LoadAllAssetsAtPath", typeof(string), 0);
                    }
                    var ret = UnityEditor.AssetDatabase.LoadAllAssetsAtPath(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("LoadAllAssetsAtPath", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetAllAssetPaths(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.AssetDatabase.GetAllAssetPaths();
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetAllAssetPaths", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Refresh(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        UnityEditor.ImportAssetOptions arg0;
                        if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "Refresh", typeof(UnityEditor.ImportAssetOptions), 0);
                        }
                        UnityEditor.AssetDatabase.Refresh(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 0)
                    {
                        UnityEditor.AssetDatabase.Refresh();
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("Refresh", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CanOpenAssetInEditor(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "CanOpenAssetInEditor", typeof(int), 0);
                    }
                    var ret = UnityEditor.AssetDatabase.CanOpenAssetInEditor(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("CanOpenAssetInEditor", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_OpenAsset(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(int)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "OpenAsset", typeof(int), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "OpenAsset", typeof(int), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "OpenAsset", typeof(int), 2);
                            }
                            var ret = UnityEditor.AssetDatabase.OpenAsset(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[1], typeof(int)) && Values.js_match_type(ctx, argv[2], typeof(int)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "OpenAsset", typeof(UnityEngine.Object), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "OpenAsset", typeof(int), 1);
                            }
                            int arg2;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "OpenAsset", typeof(int), 2);
                            }
                            var ret = UnityEditor.AssetDatabase.OpenAsset(arg0, arg1, arg2);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type(ctx, argv[1], typeof(int)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "OpenAsset", typeof(int), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "OpenAsset", typeof(int), 1);
                            }
                            var ret = UnityEditor.AssetDatabase.OpenAsset(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[1], typeof(int)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "OpenAsset", typeof(UnityEngine.Object), 0);
                            }
                            int arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "OpenAsset", typeof(int), 1);
                            }
                            var ret = UnityEditor.AssetDatabase.OpenAsset(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(int)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "OpenAsset", typeof(int), 0);
                            }
                            var ret = UnityEditor.AssetDatabase.OpenAsset(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "OpenAsset", typeof(UnityEngine.Object), 0);
                            }
                            var ret = UnityEditor.AssetDatabase.OpenAsset(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object[])))
                        {
                            UnityEngine.Object[] arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "OpenAsset", typeof(UnityEngine.Object[]), 0);
                            }
                            var ret = UnityEditor.AssetDatabase.OpenAsset(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("OpenAsset", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GUIDToAssetPath(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GUIDToAssetPath", typeof(string), 0);
                            }
                            var ret = UnityEditor.AssetDatabase.GUIDToAssetPath(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.GUID)))
                        {
                            UnityEditor.GUID arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GUIDToAssetPath", typeof(UnityEditor.GUID), 0);
                            }
                            var ret = UnityEditor.AssetDatabase.GUIDToAssetPath(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("GUIDToAssetPath", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GUIDFromAssetPath(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GUIDFromAssetPath", typeof(string), 0);
                    }
                    var ret = UnityEditor.AssetDatabase.GUIDFromAssetPath(arg0);
                    return Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GUIDFromAssetPath", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_AssetPathToGUID(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "AssetPathToGUID", typeof(string), 0);
                        }
                        UnityEditor.AssetPathToGUIDOptions arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "AssetPathToGUID", typeof(UnityEditor.AssetPathToGUIDOptions), 1);
                        }
                        var ret = UnityEditor.AssetDatabase.AssetPathToGUID(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "AssetPathToGUID", typeof(string), 0);
                        }
                        var ret = UnityEditor.AssetDatabase.AssetPathToGUID(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("AssetPathToGUID", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetAssetDependencyHash(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.GUID)))
                        {
                            UnityEditor.GUID arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GetAssetDependencyHash", typeof(UnityEditor.GUID), 0);
                            }
                            var ret = UnityEditor.AssetDatabase.GetAssetDependencyHash(arg0);
                            return Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GetAssetDependencyHash", typeof(string), 0);
                            }
                            var ret = UnityEditor.AssetDatabase.GetAssetDependencyHash(arg0);
                            return Values.js_push_structvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("GetAssetDependencyHash", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SaveAssets(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.AssetDatabase.SaveAssets();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SaveAssets", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SaveAssetIfDirty(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.GUID)))
                        {
                            UnityEditor.GUID arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "SaveAssetIfDirty", typeof(UnityEditor.GUID), 0);
                            }
                            UnityEditor.AssetDatabase.SaveAssetIfDirty(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "SaveAssetIfDirty", typeof(UnityEngine.Object), 0);
                            }
                            UnityEditor.AssetDatabase.SaveAssetIfDirty(arg0);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("SaveAssetIfDirty", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetCachedIcon(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GetCachedIcon", typeof(string), 0);
                    }
                    var ret = UnityEditor.AssetDatabase.GetCachedIcon(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetCachedIcon", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetLabels(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "SetLabels", typeof(UnityEngine.Object), 0);
                    }
                    string[] arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "SetLabels", typeof(string[]), 1);
                    }
                    UnityEditor.AssetDatabase.SetLabels(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetLabels", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetLabels(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.GUID)))
                        {
                            UnityEditor.GUID arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GetLabels", typeof(UnityEditor.GUID), 0);
                            }
                            var ret = UnityEditor.AssetDatabase.GetLabels(arg0);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GetLabels", typeof(UnityEngine.Object), 0);
                            }
                            var ret = UnityEditor.AssetDatabase.GetLabels(arg0);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("GetLabels", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ClearLabels(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "ClearLabels", typeof(UnityEngine.Object), 0);
                    }
                    UnityEditor.AssetDatabase.ClearLabels(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ClearLabels", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetAllAssetBundleNames(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.AssetDatabase.GetAllAssetBundleNames();
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetAllAssetBundleNames", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetUnusedAssetBundleNames(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.AssetDatabase.GetUnusedAssetBundleNames();
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetUnusedAssetBundleNames", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RemoveAssetBundleName(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "RemoveAssetBundleName", typeof(string), 0);
                    }
                    bool arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "RemoveAssetBundleName", typeof(bool), 1);
                    }
                    var ret = UnityEditor.AssetDatabase.RemoveAssetBundleName(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("RemoveAssetBundleName", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RemoveUnusedAssetBundleNames(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.AssetDatabase.RemoveUnusedAssetBundleNames();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RemoveUnusedAssetBundleNames", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetAssetPathsFromAssetBundle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GetAssetPathsFromAssetBundle", typeof(string), 0);
                    }
                    var ret = UnityEditor.AssetDatabase.GetAssetPathsFromAssetBundle(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetAssetPathsFromAssetBundle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetAssetPathsFromAssetBundleAndAssetName(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GetAssetPathsFromAssetBundleAndAssetName", typeof(string), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GetAssetPathsFromAssetBundleAndAssetName", typeof(string), 1);
                    }
                    var ret = UnityEditor.AssetDatabase.GetAssetPathsFromAssetBundleAndAssetName(arg0, arg1);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetAssetPathsFromAssetBundleAndAssetName", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetImplicitAssetBundleName(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GetImplicitAssetBundleName", typeof(string), 0);
                    }
                    var ret = UnityEditor.AssetDatabase.GetImplicitAssetBundleName(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetImplicitAssetBundleName", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetImplicitAssetBundleVariantName(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GetImplicitAssetBundleVariantName", typeof(string), 0);
                    }
                    var ret = UnityEditor.AssetDatabase.GetImplicitAssetBundleVariantName(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetImplicitAssetBundleVariantName", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetAssetBundleDependencies(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GetAssetBundleDependencies", typeof(string), 0);
                    }
                    bool arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GetAssetBundleDependencies", typeof(bool), 1);
                    }
                    var ret = UnityEditor.AssetDatabase.GetAssetBundleDependencies(arg0, arg1);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetAssetBundleDependencies", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetDependencies(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(bool)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GetDependencies", typeof(string), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GetDependencies", typeof(bool), 1);
                            }
                            var ret = UnityEditor.AssetDatabase.GetDependencies(arg0, arg1);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string[])) && Values.js_match_type(ctx, argv[1], typeof(bool)))
                        {
                            string[] arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GetDependencies", typeof(string[]), 0);
                            }
                            bool arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GetDependencies", typeof(bool), 1);
                            }
                            var ret = UnityEditor.AssetDatabase.GetDependencies(arg0, arg1);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GetDependencies", typeof(string), 0);
                            }
                            var ret = UnityEditor.AssetDatabase.GetDependencies(arg0);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string[])))
                        {
                            string[] arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GetDependencies", typeof(string[]), 0);
                            }
                            var ret = UnityEditor.AssetDatabase.GetDependencies(arg0);
                            return Values.js_push_classvalue(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("GetDependencies", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ExportPackage(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEditor.ExportPackageOptions)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "ExportPackage", typeof(string), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "ExportPackage", typeof(string), 1);
                            }
                            UnityEditor.ExportPackageOptions arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "ExportPackage", typeof(UnityEditor.ExportPackageOptions), 2);
                            }
                            UnityEditor.AssetDatabase.ExportPackage(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string[])) && Values.js_match_type(ctx, argv[1], typeof(string)) && Values.js_match_type(ctx, argv[2], typeof(UnityEditor.ExportPackageOptions)))
                        {
                            string[] arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "ExportPackage", typeof(string[]), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "ExportPackage", typeof(string), 1);
                            }
                            UnityEditor.ExportPackageOptions arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "ExportPackage", typeof(UnityEditor.ExportPackageOptions), 2);
                            }
                            UnityEditor.AssetDatabase.ExportPackage(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(string)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "ExportPackage", typeof(string), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "ExportPackage", typeof(string), 1);
                            }
                            UnityEditor.AssetDatabase.ExportPackage(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string[])) && Values.js_match_type(ctx, argv[1], typeof(string)))
                        {
                            string[] arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "ExportPackage", typeof(string[]), 0);
                            }
                            string arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "ExportPackage", typeof(string), 1);
                            }
                            UnityEditor.AssetDatabase.ExportPackage(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("ExportPackage", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsMetaFileOpenForEdit(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        UnityEngine.Object arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "IsMetaFileOpenForEdit", typeof(UnityEngine.Object), 0);
                        }
                        string arg1;
                        UnityEditor.StatusQueryOptions arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "IsMetaFileOpenForEdit", typeof(UnityEditor.StatusQueryOptions), 2);
                        }
                        var ret = UnityEditor.AssetDatabase.IsMetaFileOpenForEdit(arg0, out arg1, arg2);
                        var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg1);
                        if (JSApi.JS_IsException(out0))
                        {
                            return out0;
                        }
                        var context = ScriptEngine.GetContext(ctx);
                        JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[1], typeof(UnityEditor.StatusQueryOptions)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "IsMetaFileOpenForEdit", typeof(UnityEngine.Object), 0);
                            }
                            UnityEditor.StatusQueryOptions arg1;
                            if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "IsMetaFileOpenForEdit", typeof(UnityEditor.StatusQueryOptions), 1);
                            }
                            var ret = UnityEditor.AssetDatabase.IsMetaFileOpenForEdit(arg0, arg1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)) && Values.js_match_type_hint(ctx, argv[1], typeof(string)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "IsMetaFileOpenForEdit", typeof(UnityEngine.Object), 0);
                            }
                            string arg1;
                            var ret = UnityEditor.AssetDatabase.IsMetaFileOpenForEdit(arg0, out arg1);
                            var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg1);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                    if (argc == 1)
                    {
                        UnityEngine.Object arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "IsMetaFileOpenForEdit", typeof(UnityEngine.Object), 0);
                        }
                        var ret = UnityEditor.AssetDatabase.IsMetaFileOpenForEdit(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("IsMetaFileOpenForEdit", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetBuiltinExtraResource(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    System.Type arg0;
                    if (!QuickJS.Binding.Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GetBuiltinExtraResource", typeof(System.Type), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GetBuiltinExtraResource", typeof(string), 1);
                    }
                    var ret = UnityEditor.AssetDatabase.GetBuiltinExtraResource(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetBuiltinExtraResource", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ForceReserializeAssets(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        System.Collections.Generic.IEnumerable<string> arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "ForceReserializeAssets", typeof(System.Collections.Generic.IEnumerable<string>), 0);
                        }
                        UnityEditor.ForceReserializeAssetsOptions arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "ForceReserializeAssets", typeof(UnityEditor.ForceReserializeAssetsOptions), 1);
                        }
                        UnityEditor.AssetDatabase.ForceReserializeAssets(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 0)
                    {
                        UnityEditor.AssetDatabase.ForceReserializeAssets();
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("ForceReserializeAssets", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_TryGetGUIDAndLocalFileIdentifier(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)) && Values.js_match_type_hint(ctx, argv[1], typeof(string)) && Values.js_match_type_hint(ctx, argv[2], typeof(long)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "TryGetGUIDAndLocalFileIdentifier", typeof(UnityEngine.Object), 0);
                            }
                            string arg1;
                            long arg2;
                            var ret = UnityEditor.AssetDatabase.TryGetGUIDAndLocalFileIdentifier(arg0, out arg1, out arg2);
                            var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg1);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                            var out1 = QuickJS.Binding.Values.js_push_primitive(ctx, arg2);
                            if (JSApi.JS_IsException(out1))
                            {
                                return out1;
                            }
                            JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(int)) && Values.js_match_type_hint(ctx, argv[1], typeof(string)) && Values.js_match_type_hint(ctx, argv[2], typeof(long)))
                        {
                            int arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.AssetDatabase), "TryGetGUIDAndLocalFileIdentifier", typeof(int), 0);
                            }
                            string arg1;
                            long arg2;
                            var ret = UnityEditor.AssetDatabase.TryGetGUIDAndLocalFileIdentifier(arg0, out arg1, out arg2);
                            var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg1);
                            if (JSApi.JS_IsException(out0))
                            {
                                return out0;
                            }
                            var context = ScriptEngine.GetContext(ctx);
                            JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                            var out1 = QuickJS.Binding.Values.js_push_primitive(ctx, arg2);
                            if (JSApi.JS_IsException(out1))
                            {
                                return out1;
                            }
                            JSApi.JS_SetProperty(ctx, argv[2], context.GetAtom("value"), out1);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("TryGetGUIDAndLocalFileIdentifier", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RemoveObjectFromAsset(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "RemoveObjectFromAsset", typeof(UnityEngine.Object), 0);
                    }
                    UnityEditor.AssetDatabase.RemoveObjectFromAsset(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RemoveObjectFromAsset", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ImportPackage(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "ImportPackage", typeof(string), 0);
                    }
                    bool arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "ImportPackage", typeof(bool), 1);
                    }
                    UnityEditor.AssetDatabase.ImportPackage(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ImportPackage", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DisallowAutoRefresh(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.AssetDatabase.DisallowAutoRefresh();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DisallowAutoRefresh", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_AllowAutoRefresh(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.AssetDatabase.AllowAutoRefresh();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("AllowAutoRefresh", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ClearImporterOverride(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "ClearImporterOverride", typeof(string), 0);
                    }
                    UnityEditor.AssetDatabase.ClearImporterOverride(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ClearImporterOverride", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsCacheServerEnabled(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.AssetDatabase.IsCacheServerEnabled();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsCacheServerEnabled", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetImporterOverride(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GetImporterOverride", typeof(string), 0);
                    }
                    var ret = UnityEditor.AssetDatabase.GetImporterOverride(arg0);
                    return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetImporterOverride", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetAvailableImporterTypes(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "GetAvailableImporterTypes", typeof(string), 0);
                    }
                    var ret = UnityEditor.AssetDatabase.GetAvailableImporterTypes(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetAvailableImporterTypes", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CanConnectToCacheServer(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "CanConnectToCacheServer", typeof(string), 0);
                    }
                    ushort arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "CanConnectToCacheServer", typeof(ushort), 1);
                    }
                    var ret = UnityEditor.AssetDatabase.CanConnectToCacheServer(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("CanConnectToCacheServer", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RefreshSettings(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.AssetDatabase.RefreshSettings();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RefreshSettings", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsConnectedToCacheServer(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.AssetDatabase.IsConnectedToCacheServer();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsConnectedToCacheServer", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ResetCacheServerReconnectTimer(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.AssetDatabase.ResetCacheServerReconnectTimer();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ResetCacheServerReconnectTimer", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_CloseCacheServerConnection(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.AssetDatabase.CloseCacheServerConnection();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CloseCacheServerConnection", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetCacheServerAddress(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.AssetDatabase.GetCacheServerAddress();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetCacheServerAddress", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetCacheServerPort(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.AssetDatabase.GetCacheServerPort();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetCacheServerPort", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetCacheServerNamespacePrefix(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.AssetDatabase.GetCacheServerNamespacePrefix();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetCacheServerNamespacePrefix", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetCacheServerEnableDownload(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.AssetDatabase.GetCacheServerEnableDownload();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetCacheServerEnableDownload", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetCacheServerEnableUpload(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.AssetDatabase.GetCacheServerEnableUpload();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetCacheServerEnableUpload", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsDirectoryMonitoringEnabled(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.AssetDatabase.IsDirectoryMonitoringEnabled();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsDirectoryMonitoringEnabled", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RegisterCustomDependency(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "RegisterCustomDependency", typeof(string), 0);
                    }
                    UnityEngine.Hash128 arg1;
                    if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "RegisterCustomDependency", typeof(UnityEngine.Hash128), 1);
                    }
                    UnityEditor.AssetDatabase.RegisterCustomDependency(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RegisterCustomDependency", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_UnregisterCustomDependencyPrefixFilter(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.AssetDatabase), "UnregisterCustomDependencyPrefixFilter", typeof(string), 0);
                    }
                    var ret = UnityEditor.AssetDatabase.UnregisterCustomDependencyPrefixFilter(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("UnregisterCustomDependencyPrefixFilter", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_IsAssetImportWorkerProcess(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.AssetDatabase.IsAssetImportWorkerProcess();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("IsAssetImportWorkerProcess", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ForceToDesiredWorkerCount(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.AssetDatabase.ForceToDesiredWorkerCount();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ForceToDesiredWorkerCount", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_GlobalArtifactDependencyVersion(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.AssetDatabase.GlobalArtifactDependencyVersion;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_GlobalArtifactProcessedVersion(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.AssetDatabase.GlobalArtifactProcessedVersion;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_ActiveRefreshImportMode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.AssetDatabase.ActiveRefreshImportMode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_ActiveRefreshImportMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.AssetDatabase.RefreshImportMode value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.AssetDatabase), "ActiveRefreshImportMode", typeof(UnityEditor.AssetDatabase.RefreshImportMode), 0);
                }
                UnityEditor.AssetDatabase.ActiveRefreshImportMode = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_DesiredWorkerCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.AssetDatabase.DesiredWorkerCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_DesiredWorkerCount(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.AssetDatabase), "DesiredWorkerCount", typeof(int), 0);
                }
                UnityEditor.AssetDatabase.DesiredWorkerCount = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_importPackageStarted(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                UnityEditor.AssetDatabase.ImportPackageCallback value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "importPackageStarted", typeof(UnityEditor.AssetDatabase.ImportPackageCallback), 1);
                        }
                        UnityEditor.AssetDatabase.importPackageStarted += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "importPackageStarted", typeof(UnityEditor.AssetDatabase.ImportPackageCallback), 1);
                        }
                        UnityEditor.AssetDatabase.importPackageStarted -= value;
                        break;
                    default: throw new JSException("invalid event op");
                }
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_importPackageCompleted(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                UnityEditor.AssetDatabase.ImportPackageCallback value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "importPackageCompleted", typeof(UnityEditor.AssetDatabase.ImportPackageCallback), 1);
                        }
                        UnityEditor.AssetDatabase.importPackageCompleted += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "importPackageCompleted", typeof(UnityEditor.AssetDatabase.ImportPackageCallback), 1);
                        }
                        UnityEditor.AssetDatabase.importPackageCompleted -= value;
                        break;
                    default: throw new JSException("invalid event op");
                }
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_importPackageCancelled(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                UnityEditor.AssetDatabase.ImportPackageCallback value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "importPackageCancelled", typeof(UnityEditor.AssetDatabase.ImportPackageCallback), 1);
                        }
                        UnityEditor.AssetDatabase.importPackageCancelled += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "importPackageCancelled", typeof(UnityEditor.AssetDatabase.ImportPackageCallback), 1);
                        }
                        UnityEditor.AssetDatabase.importPackageCancelled -= value;
                        break;
                    default: throw new JSException("invalid event op");
                }
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_importPackageFailed(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                UnityEditor.AssetDatabase.ImportPackageFailedCallback value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "importPackageFailed", typeof(UnityEditor.AssetDatabase.ImportPackageFailedCallback), 1);
                        }
                        UnityEditor.AssetDatabase.importPackageFailed += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "importPackageFailed", typeof(UnityEditor.AssetDatabase.ImportPackageFailedCallback), 1);
                        }
                        UnityEditor.AssetDatabase.importPackageFailed -= value;
                        break;
                    default: throw new JSException("invalid event op");
                }
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_cacheServerConnectionChanged(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                System.Action<UnityEditor.CacheServerConnectionChangedParameters> value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "cacheServerConnectionChanged", typeof(System.Action<UnityEditor.CacheServerConnectionChangedParameters>), 1);
                        }
                        UnityEditor.AssetDatabase.cacheServerConnectionChanged += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "cacheServerConnectionChanged", typeof(System.Action<UnityEditor.CacheServerConnectionChangedParameters>), 1);
                        }
                        UnityEditor.AssetDatabase.cacheServerConnectionChanged -= value;
                        break;
                    default: throw new JSException("invalid event op");
                }
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticDelegate_onImportPackageItemsCompleted(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                    {
                        System.Action<string[]> value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "onImportPackageItemsCompleted", typeof(System.Action<string[]>), 1);
                        }
                        UnityEditor.AssetDatabase.onImportPackageItemsCompleted += value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_REMOVE:
                    {
                        System.Action<string[]> value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "onImportPackageItemsCompleted", typeof(System.Action<string[]>), 1);
                        }
                        UnityEditor.AssetDatabase.onImportPackageItemsCompleted -= value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_SET:
                    {
                        System.Action<string[]> value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.AssetDatabase), "onImportPackageItemsCompleted", typeof(System.Action<string[]>), 1);
                        }
                        UnityEditor.AssetDatabase.onImportPackageItemsCompleted = value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_GET:
                    {
                        var ret = UnityEditor.AssetDatabase.onImportPackageItemsCompleted;
                        return Values.js_push_delegate(ctx, ret);
                    }
                    default: throw new JSException("invalid event op");
                }
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("AssetDatabase", typeof(UnityEditor.AssetDatabase), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "CanOpenForEdit", BindStatic_CanOpenForEdit);
            cls.AddMethod(true, "IsOpenForEdit", BindStatic_IsOpenForEdit);
            cls.AddMethod(true, "MakeEditable", BindStatic_MakeEditable);
            cls.AddMethod(true, "FindAssets", BindStatic_FindAssets);
            cls.AddMethod(true, "Contains", BindStatic_Contains);
            cls.AddMethod(true, "CreateFolder", BindStatic_CreateFolder);
            cls.AddMethod(true, "IsMainAsset", BindStatic_IsMainAsset);
            cls.AddMethod(true, "IsSubAsset", BindStatic_IsSubAsset);
            cls.AddMethod(true, "IsForeignAsset", BindStatic_IsForeignAsset);
            cls.AddMethod(true, "IsNativeAsset", BindStatic_IsNativeAsset);
            cls.AddMethod(true, "GetCurrentCacheServerIp", BindStatic_GetCurrentCacheServerIp);
            cls.AddMethod(true, "GenerateUniqueAssetPath", BindStatic_GenerateUniqueAssetPath);
            cls.AddMethod(true, "StartAssetEditing", BindStatic_StartAssetEditing);
            cls.AddMethod(true, "StopAssetEditing", BindStatic_StopAssetEditing);
            cls.AddMethod(true, "ReleaseCachedFileHandles", BindStatic_ReleaseCachedFileHandles);
            cls.AddMethod(true, "ValidateMoveAsset", BindStatic_ValidateMoveAsset);
            cls.AddMethod(true, "MoveAsset", BindStatic_MoveAsset);
            cls.AddMethod(true, "ExtractAsset", BindStatic_ExtractAsset);
            cls.AddMethod(true, "RenameAsset", BindStatic_RenameAsset);
            cls.AddMethod(true, "MoveAssetToTrash", BindStatic_MoveAssetToTrash);
            cls.AddMethod(true, "MoveAssetsToTrash", BindStatic_MoveAssetsToTrash);
            cls.AddMethod(true, "DeleteAsset", BindStatic_DeleteAsset);
            cls.AddMethod(true, "DeleteAssets", BindStatic_DeleteAssets);
            cls.AddMethod(true, "ImportAsset", BindStatic_ImportAsset);
            cls.AddMethod(true, "CopyAsset", BindStatic_CopyAsset);
            cls.AddMethod(true, "WriteImportSettingsIfDirty", BindStatic_WriteImportSettingsIfDirty);
            cls.AddMethod(true, "GetSubFolders", BindStatic_GetSubFolders);
            cls.AddMethod(true, "IsValidFolder", BindStatic_IsValidFolder);
            cls.AddMethod(true, "CreateAsset", BindStatic_CreateAsset);
            cls.AddMethod(true, "AddObjectToAsset", BindStatic_AddObjectToAsset);
            cls.AddMethod(true, "SetMainObject", BindStatic_SetMainObject);
            cls.AddMethod(true, "GetAssetPath", BindStatic_GetAssetPath);
            cls.AddMethod(true, "GetAssetOrScenePath", BindStatic_GetAssetOrScenePath);
            cls.AddMethod(true, "GetTextMetaFilePathFromAssetPath", BindStatic_GetTextMetaFilePathFromAssetPath);
            cls.AddMethod(true, "GetAssetPathFromTextMetaFilePath", BindStatic_GetAssetPathFromTextMetaFilePath);
            cls.AddMethod(true, "LoadAssetAtPath", BindStatic_LoadAssetAtPath);
            cls.AddMethod(true, "LoadMainAssetAtPath", BindStatic_LoadMainAssetAtPath);
            cls.AddMethod(true, "GetMainAssetTypeAtPath", BindStatic_GetMainAssetTypeAtPath);
            cls.AddMethod(true, "GetTypeFromPathAndFileID", BindStatic_GetTypeFromPathAndFileID);
            cls.AddMethod(true, "IsMainAssetAtPathLoaded", BindStatic_IsMainAssetAtPathLoaded);
            cls.AddMethod(true, "LoadAllAssetRepresentationsAtPath", BindStatic_LoadAllAssetRepresentationsAtPath);
            cls.AddMethod(true, "LoadAllAssetsAtPath", BindStatic_LoadAllAssetsAtPath);
            cls.AddMethod(true, "GetAllAssetPaths", BindStatic_GetAllAssetPaths);
            cls.AddMethod(true, "Refresh", BindStatic_Refresh);
            cls.AddMethod(true, "CanOpenAssetInEditor", BindStatic_CanOpenAssetInEditor);
            cls.AddMethod(true, "OpenAsset", BindStatic_OpenAsset);
            cls.AddMethod(true, "GUIDToAssetPath", BindStatic_GUIDToAssetPath);
            cls.AddMethod(true, "GUIDFromAssetPath", BindStatic_GUIDFromAssetPath);
            cls.AddMethod(true, "AssetPathToGUID", BindStatic_AssetPathToGUID);
            cls.AddMethod(true, "GetAssetDependencyHash", BindStatic_GetAssetDependencyHash);
            cls.AddMethod(true, "SaveAssets", BindStatic_SaveAssets);
            cls.AddMethod(true, "SaveAssetIfDirty", BindStatic_SaveAssetIfDirty);
            cls.AddMethod(true, "GetCachedIcon", BindStatic_GetCachedIcon);
            cls.AddMethod(true, "SetLabels", BindStatic_SetLabels);
            cls.AddMethod(true, "GetLabels", BindStatic_GetLabels);
            cls.AddMethod(true, "ClearLabels", BindStatic_ClearLabels);
            cls.AddMethod(true, "GetAllAssetBundleNames", BindStatic_GetAllAssetBundleNames);
            cls.AddMethod(true, "GetUnusedAssetBundleNames", BindStatic_GetUnusedAssetBundleNames);
            cls.AddMethod(true, "RemoveAssetBundleName", BindStatic_RemoveAssetBundleName);
            cls.AddMethod(true, "RemoveUnusedAssetBundleNames", BindStatic_RemoveUnusedAssetBundleNames);
            cls.AddMethod(true, "GetAssetPathsFromAssetBundle", BindStatic_GetAssetPathsFromAssetBundle);
            cls.AddMethod(true, "GetAssetPathsFromAssetBundleAndAssetName", BindStatic_GetAssetPathsFromAssetBundleAndAssetName);
            cls.AddMethod(true, "GetImplicitAssetBundleName", BindStatic_GetImplicitAssetBundleName);
            cls.AddMethod(true, "GetImplicitAssetBundleVariantName", BindStatic_GetImplicitAssetBundleVariantName);
            cls.AddMethod(true, "GetAssetBundleDependencies", BindStatic_GetAssetBundleDependencies);
            cls.AddMethod(true, "GetDependencies", BindStatic_GetDependencies);
            cls.AddMethod(true, "ExportPackage", BindStatic_ExportPackage);
            cls.AddMethod(true, "IsMetaFileOpenForEdit", BindStatic_IsMetaFileOpenForEdit);
            cls.AddMethod(true, "GetBuiltinExtraResource", BindStatic_GetBuiltinExtraResource);
            cls.AddMethod(true, "ForceReserializeAssets", BindStatic_ForceReserializeAssets);
            cls.AddMethod(true, "TryGetGUIDAndLocalFileIdentifier", BindStatic_TryGetGUIDAndLocalFileIdentifier);
            cls.AddMethod(true, "RemoveObjectFromAsset", BindStatic_RemoveObjectFromAsset);
            cls.AddMethod(true, "ImportPackage", BindStatic_ImportPackage);
            cls.AddMethod(true, "DisallowAutoRefresh", BindStatic_DisallowAutoRefresh);
            cls.AddMethod(true, "AllowAutoRefresh", BindStatic_AllowAutoRefresh);
            cls.AddMethod(true, "ClearImporterOverride", BindStatic_ClearImporterOverride);
            cls.AddMethod(true, "IsCacheServerEnabled", BindStatic_IsCacheServerEnabled);
            cls.AddMethod(true, "GetImporterOverride", BindStatic_GetImporterOverride);
            cls.AddMethod(true, "GetAvailableImporterTypes", BindStatic_GetAvailableImporterTypes);
            cls.AddMethod(true, "CanConnectToCacheServer", BindStatic_CanConnectToCacheServer);
            cls.AddMethod(true, "RefreshSettings", BindStatic_RefreshSettings);
            cls.AddMethod(true, "IsConnectedToCacheServer", BindStatic_IsConnectedToCacheServer);
            cls.AddMethod(true, "ResetCacheServerReconnectTimer", BindStatic_ResetCacheServerReconnectTimer);
            cls.AddMethod(true, "CloseCacheServerConnection", BindStatic_CloseCacheServerConnection);
            cls.AddMethod(true, "GetCacheServerAddress", BindStatic_GetCacheServerAddress);
            cls.AddMethod(true, "GetCacheServerPort", BindStatic_GetCacheServerPort);
            cls.AddMethod(true, "GetCacheServerNamespacePrefix", BindStatic_GetCacheServerNamespacePrefix);
            cls.AddMethod(true, "GetCacheServerEnableDownload", BindStatic_GetCacheServerEnableDownload);
            cls.AddMethod(true, "GetCacheServerEnableUpload", BindStatic_GetCacheServerEnableUpload);
            cls.AddMethod(true, "IsDirectoryMonitoringEnabled", BindStatic_IsDirectoryMonitoringEnabled);
            cls.AddMethod(true, "RegisterCustomDependency", BindStatic_RegisterCustomDependency);
            cls.AddMethod(true, "UnregisterCustomDependencyPrefixFilter", BindStatic_UnregisterCustomDependencyPrefixFilter);
            cls.AddMethod(true, "IsAssetImportWorkerProcess", BindStatic_IsAssetImportWorkerProcess);
            cls.AddMethod(true, "ForceToDesiredWorkerCount", BindStatic_ForceToDesiredWorkerCount);
            cls.AddProperty(true, "GlobalArtifactDependencyVersion", BindStaticRead_GlobalArtifactDependencyVersion, null);
            cls.AddProperty(true, "GlobalArtifactProcessedVersion", BindStaticRead_GlobalArtifactProcessedVersion, null);
            cls.AddProperty(true, "ActiveRefreshImportMode", BindStaticRead_ActiveRefreshImportMode, BindStaticWrite_ActiveRefreshImportMode);
            cls.AddProperty(true, "DesiredWorkerCount", BindStaticRead_DesiredWorkerCount, BindStaticWrite_DesiredWorkerCount);
            cls.AddMethod(true, "importPackageStarted", BindStaticEvent_importPackageStarted);
            cls.AddMethod(true, "importPackageCompleted", BindStaticEvent_importPackageCompleted);
            cls.AddMethod(true, "importPackageCancelled", BindStaticEvent_importPackageCancelled);
            cls.AddMethod(true, "importPackageFailed", BindStaticEvent_importPackageFailed);
            cls.AddMethod(true, "cacheServerConnectionChanged", BindStaticEvent_cacheServerConnectionChanged);
            cls.AddMethod(true, "onImportPackageItemsCompleted", BindStaticDelegate_onImportPackageItemsCompleted);
            return cls;
        }
    }
}
#endif
#endif
