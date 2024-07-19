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
    // Type: QuickJS.Utils.TSConfig+CompilerOptions
    [JSBindingAttribute]
    public class QuickJS_QuickJS_Utils_TSConfig_CompilerOptions
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_module(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Utils.TSConfig.CompilerOptions self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.module;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_module(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Utils.TSConfig.CompilerOptions self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Utils.TSConfig.CompilerOptions), "module", typeof(string), 0);
                }
                self.module = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_target(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Utils.TSConfig.CompilerOptions self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.target;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_target(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Utils.TSConfig.CompilerOptions self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Utils.TSConfig.CompilerOptions), "target", typeof(string), 0);
                }
                self.target = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_sourceRoot(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Utils.TSConfig.CompilerOptions self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.sourceRoot;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_sourceRoot(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Utils.TSConfig.CompilerOptions self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Utils.TSConfig.CompilerOptions), "sourceRoot", typeof(string), 0);
                }
                self.sourceRoot = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_outDir(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Utils.TSConfig.CompilerOptions self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.outDir;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_outDir(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Utils.TSConfig.CompilerOptions self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Utils.TSConfig.CompilerOptions), "outDir", typeof(string), 0);
                }
                self.outDir = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_outFile(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Utils.TSConfig.CompilerOptions self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.outFile;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_outFile(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Utils.TSConfig.CompilerOptions self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Utils.TSConfig.CompilerOptions), "outFile", typeof(string), 0);
                }
                self.outFile = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_typeRoots(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Utils.TSConfig.CompilerOptions self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.typeRoots;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_typeRoots(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Utils.TSConfig.CompilerOptions self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string[] value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Utils.TSConfig.CompilerOptions), "typeRoots", typeof(string[]), 0);
                }
                self.typeRoots = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_moduleResolution(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Utils.TSConfig.CompilerOptions self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.moduleResolution;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_moduleResolution(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Utils.TSConfig.CompilerOptions self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Utils.TSConfig.CompilerOptions), "moduleResolution", typeof(string), 0);
                }
                self.moduleResolution = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_types(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Utils.TSConfig.CompilerOptions self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.types;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_types(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Utils.TSConfig.CompilerOptions self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string[] value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Utils.TSConfig.CompilerOptions), "types", typeof(string[]), 0);
                }
                self.types = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_listEmittedFiles(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Utils.TSConfig.CompilerOptions self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.listEmittedFiles;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_listEmittedFiles(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Utils.TSConfig.CompilerOptions self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Utils.TSConfig.CompilerOptions), "listEmittedFiles", typeof(bool), 0);
                }
                self.listEmittedFiles = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_experimentalDecorators(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Utils.TSConfig.CompilerOptions self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.experimentalDecorators;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_experimentalDecorators(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Utils.TSConfig.CompilerOptions self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Utils.TSConfig.CompilerOptions), "experimentalDecorators", typeof(bool), 0);
                }
                self.experimentalDecorators = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_noImplicitAny(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Utils.TSConfig.CompilerOptions self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.noImplicitAny;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_noImplicitAny(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Utils.TSConfig.CompilerOptions self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Utils.TSConfig.CompilerOptions), "noImplicitAny", typeof(bool), 0);
                }
                self.noImplicitAny = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_allowJs(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Utils.TSConfig.CompilerOptions self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.allowJs;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_allowJs(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Utils.TSConfig.CompilerOptions self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Utils.TSConfig.CompilerOptions), "allowJs", typeof(bool), 0);
                }
                self.allowJs = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_inlineSourceMap(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Utils.TSConfig.CompilerOptions self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.inlineSourceMap;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_inlineSourceMap(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Utils.TSConfig.CompilerOptions self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Utils.TSConfig.CompilerOptions), "inlineSourceMap", typeof(bool), 0);
                }
                self.inlineSourceMap = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_sourceMap(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Utils.TSConfig.CompilerOptions self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.sourceMap;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_sourceMap(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Utils.TSConfig.CompilerOptions self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Utils.TSConfig.CompilerOptions), "sourceMap", typeof(bool), 0);
                }
                self.sourceMap = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("CompilerOptions", typeof(QuickJS.Utils.TSConfig.CompilerOptions), QuickJS.JSNative.class_private_ctor);
            cls.AddField(false, "module_", BindRead_module, BindWrite_module);
            cls.AddField(false, "target", BindRead_target, BindWrite_target);
            cls.AddField(false, "sourceRoot", BindRead_sourceRoot, BindWrite_sourceRoot);
            cls.AddField(false, "outDir", BindRead_outDir, BindWrite_outDir);
            cls.AddField(false, "outFile", BindRead_outFile, BindWrite_outFile);
            cls.AddField(false, "typeRoots", BindRead_typeRoots, BindWrite_typeRoots);
            cls.AddField(false, "moduleResolution", BindRead_moduleResolution, BindWrite_moduleResolution);
            cls.AddField(false, "types", BindRead_types, BindWrite_types);
            cls.AddField(false, "listEmittedFiles", BindRead_listEmittedFiles, BindWrite_listEmittedFiles);
            cls.AddField(false, "experimentalDecorators", BindRead_experimentalDecorators, BindWrite_experimentalDecorators);
            cls.AddField(false, "noImplicitAny", BindRead_noImplicitAny, BindWrite_noImplicitAny);
            cls.AddField(false, "allowJs", BindRead_allowJs, BindWrite_allowJs);
            cls.AddField(false, "inlineSourceMap", BindRead_inlineSourceMap, BindWrite_inlineSourceMap);
            cls.AddField(false, "sourceMap", BindRead_sourceMap, BindWrite_sourceMap);
            return cls;
        }
    }
}
#endif
#endif
