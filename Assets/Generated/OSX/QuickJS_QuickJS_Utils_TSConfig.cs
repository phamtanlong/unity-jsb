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
    // Assembly: jsb.core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Users/longpt/Documents/SkyMavis/unity-jsb-2/Library/ScriptAssemblies/jsb.core.dll
    // Type: QuickJS.Utils.TSConfig
    [JSBindingAttribute]
    public class QuickJS_QuickJS_Utils_TSConfig
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_compilerOptions(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Utils.TSConfig self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.compilerOptions;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_compilerOptions(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Utils.TSConfig self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                QuickJS.Utils.TSConfig.CompilerOptions value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Utils.TSConfig), "compilerOptions", typeof(QuickJS.Utils.TSConfig.CompilerOptions), 0);
                }
                self.compilerOptions = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_compileOnSave(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Utils.TSConfig self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.compileOnSave;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_compileOnSave(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Utils.TSConfig self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Utils.TSConfig), "compileOnSave", typeof(bool), 0);
                }
                self.compileOnSave = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_include(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Utils.TSConfig self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.include;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_include(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Utils.TSConfig self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string[] value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Utils.TSConfig), "include", typeof(string[]), 0);
                }
                self.include = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_exclude(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Utils.TSConfig self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.exclude;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_exclude(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Utils.TSConfig self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string[] value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Utils.TSConfig), "exclude", typeof(string[]), 0);
                }
                self.exclude = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("TSConfig", typeof(QuickJS.Utils.TSConfig), QuickJS.JSNative.class_private_ctor);
            cls.AddField(false, "compilerOptions", BindRead_compilerOptions, BindWrite_compilerOptions);
            cls.AddField(false, "compileOnSave", BindRead_compileOnSave, BindWrite_compileOnSave);
            cls.AddField(false, "include", BindRead_include, BindWrite_include);
            cls.AddField(false, "exclude", BindRead_exclude, BindWrite_exclude);
            return cls;
        }
    }
}
#endif
#endif
