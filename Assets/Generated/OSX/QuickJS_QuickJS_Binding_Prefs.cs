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
    // Assembly: jsb.editor.binding, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Users/longpt/Documents/SkyMavis/unity-jsb-2/Library/ScriptAssemblies/jsb.editor.binding.dll
    // Type: QuickJS.Binding.Prefs
    [JSBindingAttribute]
    public class QuickJS_QuickJS_Binding_Prefs
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetModuleStyle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    QuickJS.Binding.Prefs self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.GetModuleStyle();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                }
                throw new NoSuitableMethodException("GetModuleStyle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_newline(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.newline;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_filePath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.filePath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_filePath(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "filePath", typeof(string), 0);
                }
                self.filePath = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_logPath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.logPath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_logPath(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "logPath", typeof(string), 0);
                }
                self.logPath = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_sourceDir(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.sourceDir;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_sourceDir(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "sourceDir", typeof(string), 0);
                }
                self.sourceDir = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_javascriptDir(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.javascriptDir;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_javascriptDir(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "javascriptDir", typeof(string), 0);
                }
                self.javascriptDir = value;
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
                QuickJS.Binding.Prefs self;
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
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "outDir", typeof(string), 0);
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
        public static JSValue BindRead_typescriptDir(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.typescriptDir;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_typescriptDir(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "typescriptDir", typeof(string), 0);
                }
                self.typescriptDir = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_typescriptExt(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.typescriptExt;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_typescriptExt(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "typescriptExt", typeof(string), 0);
                }
                self.typescriptExt = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_xmlDocDir(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.xmlDocDir;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_xmlDocDir(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "xmlDocDir", typeof(string), 0);
                }
                self.xmlDocDir = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_vendor(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.vendor;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_vendor(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "vendor", typeof(string), 0);
                }
                self.vendor = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_jsModulePackInfoPath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.jsModulePackInfoPath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_jsModulePackInfoPath(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "jsModulePackInfoPath", typeof(string), 0);
                }
                self.jsModulePackInfoPath = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_genTypescriptDoc(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.genTypescriptDoc;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_genTypescriptDoc(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "genTypescriptDoc", typeof(bool), 0);
                }
                self.genTypescriptDoc = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_editorScripting(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.editorScripting;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_editorScripting(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "editorScripting", typeof(bool), 0);
                }
                self.editorScripting = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_preferredBindingMethod(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.preferredBindingMethod;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_preferredBindingMethod(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "preferredBindingMethod", typeof(string), 0);
                }
                self.preferredBindingMethod = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_enableOperatorOverloading(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.enableOperatorOverloading;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_enableOperatorOverloading(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "enableOperatorOverloading", typeof(bool), 0);
                }
                self.enableOperatorOverloading = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_alwaysEmitOperatorMethod(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.alwaysEmitOperatorMethod;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_alwaysEmitOperatorMethod(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "alwaysEmitOperatorMethod", typeof(bool), 0);
                }
                self.alwaysEmitOperatorMethod = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_enableTypeProxy(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.enableTypeProxy;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_enableTypeProxy(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "enableTypeProxy", typeof(bool), 0);
                }
                self.enableTypeProxy = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_excludeObsoleteItems(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.excludeObsoleteItems;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_excludeObsoleteItems(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "excludeObsoleteItems", typeof(bool), 0);
                }
                self.excludeObsoleteItems = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_editorEntryPoint(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.editorEntryPoint;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_editorEntryPoint(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "editorEntryPoint", typeof(string), 0);
                }
                self.editorEntryPoint = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_assetPostProcessors(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.assetPostProcessors;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_assetPostProcessors(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                System.Collections.Generic.List<string> value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "assetPostProcessors", typeof(System.Collections.Generic.List<string>), 0);
                }
                self.assetPostProcessors = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_editorRequires(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.editorRequires;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_editorRequires(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                System.Collections.Generic.List<string> value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "editorRequires", typeof(System.Collections.Generic.List<string>), 0);
                }
                self.editorRequires = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_editorDecoratorScript(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.editorDecoratorScript;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_editorDecoratorScript(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "editorDecoratorScript", typeof(string), 0);
                }
                self.editorDecoratorScript = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_debugCodegen(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.debugCodegen;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_debugCodegen(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "debugCodegen", typeof(bool), 0);
                }
                self.debugCodegen = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_skipDelegateWithByRefParams(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.skipDelegateWithByRefParams;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_skipDelegateWithByRefParams(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "skipDelegateWithByRefParams", typeof(bool), 0);
                }
                self.skipDelegateWithByRefParams = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_verboseLog(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.verboseLog;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_verboseLog(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "verboseLog", typeof(bool), 0);
                }
                self.verboseLog = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_optToString(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.optToString;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_optToString(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "optToString", typeof(bool), 0);
                }
                self.optToString = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_tsdSizeThreshold(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.tsdSizeThreshold;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_tsdSizeThreshold(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "tsdSizeThreshold", typeof(int), 0);
                }
                self.tsdSizeThreshold = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_alwaysCheckArgType(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.alwaysCheckArgType;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_alwaysCheckArgType(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "alwaysCheckArgType", typeof(bool), 0);
                }
                self.alwaysCheckArgType = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_alwaysCheckArgc(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.alwaysCheckArgc;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_alwaysCheckArgc(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "alwaysCheckArgc", typeof(bool), 0);
                }
                self.alwaysCheckArgc = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_randomizedBindingCode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.randomizedBindingCode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_randomizedBindingCode(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "randomizedBindingCode", typeof(bool), 0);
                }
                self.randomizedBindingCode = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_typeBindingPrefix(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.typeBindingPrefix;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_typeBindingPrefix(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "typeBindingPrefix", typeof(string), 0);
                }
                self.typeBindingPrefix = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_ns(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.ns;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_ns(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "ns", typeof(string), 0);
                }
                self.ns = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_defaultJSModule(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.defaultJSModule;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_defaultJSModule(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "defaultJSModule", typeof(string), 0);
                }
                self.defaultJSModule = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_moduleStyle(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.moduleStyle;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_moduleStyle(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "moduleStyle", typeof(string), 0);
                }
                self.moduleStyle = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_singularModuleName(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.singularModuleName;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_singularModuleName(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "singularModuleName", typeof(string), 0);
                }
                self.singularModuleName = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_extraExtForTypescript(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.extraExtForTypescript;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_extraExtForTypescript(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "extraExtForTypescript", typeof(string), 0);
                }
                self.extraExtForTypescript = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_newLineStyle(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.newLineStyle;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_newLineStyle(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "newLineStyle", typeof(string), 0);
                }
                self.newLineStyle = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_tab(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.tab;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_tab(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                string value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "tab", typeof(string), 0);
                }
                self.tab = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_skipBinding(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.skipBinding;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_skipBinding(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                System.Collections.Generic.List<string> value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "skipBinding", typeof(System.Collections.Generic.List<string>), 0);
                }
                self.skipBinding = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_cleanupDir(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.cleanupDir;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_cleanupDir(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                System.Collections.Generic.List<string> value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "cleanupDir", typeof(System.Collections.Generic.List<string>), 0);
                }
                self.cleanupDir = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_explicitAssemblies(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.explicitAssemblies;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_explicitAssemblies(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                System.Collections.Generic.List<string> value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "explicitAssemblies", typeof(System.Collections.Generic.List<string>), 0);
                }
                self.explicitAssemblies = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_implicitAssemblies(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.implicitAssemblies;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_implicitAssemblies(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                System.Collections.Generic.List<string> value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "implicitAssemblies", typeof(System.Collections.Generic.List<string>), 0);
                }
                self.implicitAssemblies = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_typeFullNameBlacklist(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.typeFullNameBlacklist;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_typeFullNameBlacklist(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                System.Collections.Generic.List<string> value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "typeFullNameBlacklist", typeof(System.Collections.Generic.List<string>), 0);
                }
                self.typeFullNameBlacklist = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_namespaceBlacklist(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.namespaceBlacklist;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_namespaceBlacklist(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                System.Collections.Generic.List<string> value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "namespaceBlacklist", typeof(System.Collections.Generic.List<string>), 0);
                }
                self.namespaceBlacklist = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_assemblyBlacklist(JSContext ctx, JSValue this_obj)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.assemblyBlacklist;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_assemblyBlacklist(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                QuickJS.Binding.Prefs self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                System.Collections.Generic.List<string> value;
                if (!Values.js_get_classvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(QuickJS.Binding.Prefs), "assemblyBlacklist", typeof(System.Collections.Generic.List<string>), 0);
                }
                self.assemblyBlacklist = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("Prefs", typeof(QuickJS.Binding.Prefs), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(false, "GetModuleStyle", Bind_GetModuleStyle);
            cls.AddProperty(false, "newline", BindRead_newline, null);
            cls.AddConstValue("PATH", "js-bridge.json");
            cls.AddField(false, "filePath", BindRead_filePath, BindWrite_filePath);
            cls.AddField(false, "logPath", BindRead_logPath, BindWrite_logPath);
            cls.AddField(false, "sourceDir", BindRead_sourceDir, BindWrite_sourceDir);
            cls.AddField(false, "javascriptDir", BindRead_javascriptDir, BindWrite_javascriptDir);
            cls.AddField(false, "outDir", BindRead_outDir, BindWrite_outDir);
            cls.AddField(false, "typescriptDir", BindRead_typescriptDir, BindWrite_typescriptDir);
            cls.AddField(false, "typescriptExt", BindRead_typescriptExt, BindWrite_typescriptExt);
            cls.AddField(false, "xmlDocDir", BindRead_xmlDocDir, BindWrite_xmlDocDir);
            cls.AddField(false, "vendor", BindRead_vendor, BindWrite_vendor);
            cls.AddField(false, "jsModulePackInfoPath", BindRead_jsModulePackInfoPath, BindWrite_jsModulePackInfoPath);
            cls.AddField(false, "genTypescriptDoc", BindRead_genTypescriptDoc, BindWrite_genTypescriptDoc);
            cls.AddField(false, "editorScripting", BindRead_editorScripting, BindWrite_editorScripting);
            cls.AddField(false, "preferredBindingMethod", BindRead_preferredBindingMethod, BindWrite_preferredBindingMethod);
            cls.AddField(false, "enableOperatorOverloading", BindRead_enableOperatorOverloading, BindWrite_enableOperatorOverloading);
            cls.AddField(false, "alwaysEmitOperatorMethod", BindRead_alwaysEmitOperatorMethod, BindWrite_alwaysEmitOperatorMethod);
            cls.AddField(false, "enableTypeProxy", BindRead_enableTypeProxy, BindWrite_enableTypeProxy);
            cls.AddField(false, "excludeObsoleteItems", BindRead_excludeObsoleteItems, BindWrite_excludeObsoleteItems);
            cls.AddField(false, "editorEntryPoint", BindRead_editorEntryPoint, BindWrite_editorEntryPoint);
            cls.AddField(false, "assetPostProcessors", BindRead_assetPostProcessors, BindWrite_assetPostProcessors);
            cls.AddField(false, "editorRequires", BindRead_editorRequires, BindWrite_editorRequires);
            cls.AddField(false, "editorDecoratorScript", BindRead_editorDecoratorScript, BindWrite_editorDecoratorScript);
            cls.AddField(false, "debugCodegen", BindRead_debugCodegen, BindWrite_debugCodegen);
            cls.AddField(false, "skipDelegateWithByRefParams", BindRead_skipDelegateWithByRefParams, BindWrite_skipDelegateWithByRefParams);
            cls.AddField(false, "verboseLog", BindRead_verboseLog, BindWrite_verboseLog);
            cls.AddField(false, "optToString", BindRead_optToString, BindWrite_optToString);
            cls.AddField(false, "tsdSizeThreshold", BindRead_tsdSizeThreshold, BindWrite_tsdSizeThreshold);
            cls.AddField(false, "alwaysCheckArgType", BindRead_alwaysCheckArgType, BindWrite_alwaysCheckArgType);
            cls.AddField(false, "alwaysCheckArgc", BindRead_alwaysCheckArgc, BindWrite_alwaysCheckArgc);
            cls.AddField(false, "randomizedBindingCode", BindRead_randomizedBindingCode, BindWrite_randomizedBindingCode);
            cls.AddField(false, "typeBindingPrefix", BindRead_typeBindingPrefix, BindWrite_typeBindingPrefix);
            cls.AddField(false, "ns", BindRead_ns, BindWrite_ns);
            cls.AddField(false, "defaultJSModule", BindRead_defaultJSModule, BindWrite_defaultJSModule);
            cls.AddField(false, "moduleStyle", BindRead_moduleStyle, BindWrite_moduleStyle);
            cls.AddField(false, "singularModuleName", BindRead_singularModuleName, BindWrite_singularModuleName);
            cls.AddField(false, "extraExtForTypescript", BindRead_extraExtForTypescript, BindWrite_extraExtForTypescript);
            cls.AddField(false, "newLineStyle", BindRead_newLineStyle, BindWrite_newLineStyle);
            cls.AddField(false, "tab", BindRead_tab, BindWrite_tab);
            cls.AddField(false, "skipBinding", BindRead_skipBinding, BindWrite_skipBinding);
            cls.AddField(false, "cleanupDir", BindRead_cleanupDir, BindWrite_cleanupDir);
            cls.AddField(false, "explicitAssemblies", BindRead_explicitAssemblies, BindWrite_explicitAssemblies);
            cls.AddField(false, "implicitAssemblies", BindRead_implicitAssemblies, BindWrite_implicitAssemblies);
            cls.AddField(false, "typeFullNameBlacklist", BindRead_typeFullNameBlacklist, BindWrite_typeFullNameBlacklist);
            cls.AddField(false, "namespaceBlacklist", BindRead_namespaceBlacklist, BindWrite_namespaceBlacklist);
            cls.AddField(false, "assemblyBlacklist", BindRead_assemblyBlacklist, BindWrite_assemblyBlacklist);
            return cls;
        }
    }
}
#endif
#endif
