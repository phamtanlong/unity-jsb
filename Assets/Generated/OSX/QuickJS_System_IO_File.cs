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
    // Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
    // Location: /Applications/Unity/Hub/Editor/2019.4.40f1/Unity.app/Contents/MonoBleedingEdge/lib/mono/unityjit/mscorlib.dll
    // Type: System.IO.File
    [JSBindingAttribute]
    public class QuickJS_System_IO_File
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_AppendAllText(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(System.IO.File), "AppendAllText", typeof(string), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.IO.File), "AppendAllText", typeof(string), 1);
                        }
                        System.Text.Encoding arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(System.IO.File), "AppendAllText", typeof(System.Text.Encoding), 2);
                        }
                        System.IO.File.AppendAllText(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.IO.File), "AppendAllText", typeof(string), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.IO.File), "AppendAllText", typeof(string), 1);
                        }
                        System.IO.File.AppendAllText(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("AppendAllText", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_AppendText(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.IO.File), "AppendText", typeof(string), 0);
                    }
                    var ret = System.IO.File.AppendText(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("AppendText", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Copy(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(System.IO.File), "Copy", typeof(string), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.IO.File), "Copy", typeof(string), 1);
                        }
                        bool arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(System.IO.File), "Copy", typeof(bool), 2);
                        }
                        System.IO.File.Copy(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.IO.File), "Copy", typeof(string), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.IO.File), "Copy", typeof(string), 1);
                        }
                        System.IO.File.Copy(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("Copy", argc);
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
                    if (argc == 3)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.IO.File), "Create", typeof(string), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.IO.File), "Create", typeof(int), 1);
                        }
                        System.IO.FileOptions arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(System.IO.File), "Create", typeof(System.IO.FileOptions), 2);
                        }
                        var ret = System.IO.File.Create(arg0, arg1, arg2);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.IO.File), "Create", typeof(string), 0);
                        }
                        int arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.IO.File), "Create", typeof(int), 1);
                        }
                        var ret = System.IO.File.Create(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.IO.File), "Create", typeof(string), 0);
                        }
                        var ret = System.IO.File.Create(arg0);
                        return Values.js_push_classvalue(ctx, ret);
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
        public static JSValue BindStatic_CreateText(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.IO.File), "CreateText", typeof(string), 0);
                    }
                    var ret = System.IO.File.CreateText(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("CreateText", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Delete(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.IO.File), "Delete", typeof(string), 0);
                    }
                    System.IO.File.Delete(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Delete", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Exists(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.IO.File), "Exists", typeof(string), 0);
                    }
                    var ret = System.IO.File.Exists(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("Exists", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetAttributes(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.IO.File), "GetAttributes", typeof(string), 0);
                    }
                    var ret = System.IO.File.GetAttributes(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                }
                throw new NoSuitableMethodException("GetAttributes", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetCreationTime(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.IO.File), "GetCreationTime", typeof(string), 0);
                    }
                    var ret = System.IO.File.GetCreationTime(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetCreationTime", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetCreationTimeUtc(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.IO.File), "GetCreationTimeUtc", typeof(string), 0);
                    }
                    var ret = System.IO.File.GetCreationTimeUtc(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetCreationTimeUtc", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetLastAccessTime(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.IO.File), "GetLastAccessTime", typeof(string), 0);
                    }
                    var ret = System.IO.File.GetLastAccessTime(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetLastAccessTime", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetLastAccessTimeUtc(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.IO.File), "GetLastAccessTimeUtc", typeof(string), 0);
                    }
                    var ret = System.IO.File.GetLastAccessTimeUtc(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetLastAccessTimeUtc", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetLastWriteTime(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.IO.File), "GetLastWriteTime", typeof(string), 0);
                    }
                    var ret = System.IO.File.GetLastWriteTime(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetLastWriteTime", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetLastWriteTimeUtc(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.IO.File), "GetLastWriteTimeUtc", typeof(string), 0);
                    }
                    var ret = System.IO.File.GetLastWriteTimeUtc(arg0);
                    return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetLastWriteTimeUtc", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Move(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.IO.File), "Move", typeof(string), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(System.IO.File), "Move", typeof(string), 1);
                    }
                    System.IO.File.Move(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Move", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Open(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(System.IO.File), "Open", typeof(string), 0);
                        }
                        System.IO.FileMode arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.IO.File), "Open", typeof(System.IO.FileMode), 1);
                        }
                        System.IO.FileAccess arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(System.IO.File), "Open", typeof(System.IO.FileAccess), 2);
                        }
                        var ret = System.IO.File.Open(arg0, arg1, arg2);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.IO.File), "Open", typeof(string), 0);
                        }
                        System.IO.FileMode arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.IO.File), "Open", typeof(System.IO.FileMode), 1);
                        }
                        var ret = System.IO.File.Open(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("Open", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_OpenRead(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.IO.File), "OpenRead", typeof(string), 0);
                    }
                    var ret = System.IO.File.OpenRead(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("OpenRead", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_OpenText(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.IO.File), "OpenText", typeof(string), 0);
                    }
                    var ret = System.IO.File.OpenText(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("OpenText", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_OpenWrite(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.IO.File), "OpenWrite", typeof(string), 0);
                    }
                    var ret = System.IO.File.OpenWrite(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("OpenWrite", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Replace(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.IO.File), "Replace", typeof(string), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(System.IO.File), "Replace", typeof(string), 1);
                    }
                    string arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(System.IO.File), "Replace", typeof(string), 2);
                    }
                    System.IO.File.Replace(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Replace", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetAttributes(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.IO.File), "SetAttributes", typeof(string), 0);
                    }
                    System.IO.FileAttributes arg1;
                    if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(System.IO.File), "SetAttributes", typeof(System.IO.FileAttributes), 1);
                    }
                    System.IO.File.SetAttributes(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetAttributes", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetCreationTime(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.IO.File), "SetCreationTime", typeof(string), 0);
                    }
                    System.DateTime arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(System.IO.File), "SetCreationTime", typeof(System.DateTime), 1);
                    }
                    System.IO.File.SetCreationTime(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetCreationTime", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetCreationTimeUtc(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.IO.File), "SetCreationTimeUtc", typeof(string), 0);
                    }
                    System.DateTime arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(System.IO.File), "SetCreationTimeUtc", typeof(System.DateTime), 1);
                    }
                    System.IO.File.SetCreationTimeUtc(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetCreationTimeUtc", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetLastAccessTime(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.IO.File), "SetLastAccessTime", typeof(string), 0);
                    }
                    System.DateTime arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(System.IO.File), "SetLastAccessTime", typeof(System.DateTime), 1);
                    }
                    System.IO.File.SetLastAccessTime(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetLastAccessTime", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetLastAccessTimeUtc(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.IO.File), "SetLastAccessTimeUtc", typeof(string), 0);
                    }
                    System.DateTime arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(System.IO.File), "SetLastAccessTimeUtc", typeof(System.DateTime), 1);
                    }
                    System.IO.File.SetLastAccessTimeUtc(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetLastAccessTimeUtc", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetLastWriteTime(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.IO.File), "SetLastWriteTime", typeof(string), 0);
                    }
                    System.DateTime arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(System.IO.File), "SetLastWriteTime", typeof(System.DateTime), 1);
                    }
                    System.IO.File.SetLastWriteTime(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetLastWriteTime", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetLastWriteTimeUtc(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.IO.File), "SetLastWriteTimeUtc", typeof(string), 0);
                    }
                    System.DateTime arg1;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(System.IO.File), "SetLastWriteTimeUtc", typeof(System.DateTime), 1);
                    }
                    System.IO.File.SetLastWriteTimeUtc(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetLastWriteTimeUtc", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ReadAllBytes(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.IO.File), "ReadAllBytes", typeof(string), 0);
                    }
                    var ret = System.IO.File.ReadAllBytes(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("ReadAllBytes", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ReadAllLines(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(System.IO.File), "ReadAllLines", typeof(string), 0);
                        }
                        System.Text.Encoding arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.IO.File), "ReadAllLines", typeof(System.Text.Encoding), 1);
                        }
                        var ret = System.IO.File.ReadAllLines(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.IO.File), "ReadAllLines", typeof(string), 0);
                        }
                        var ret = System.IO.File.ReadAllLines(arg0);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("ReadAllLines", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ReadAllText(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(System.IO.File), "ReadAllText", typeof(string), 0);
                        }
                        System.Text.Encoding arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.IO.File), "ReadAllText", typeof(System.Text.Encoding), 1);
                        }
                        var ret = System.IO.File.ReadAllText(arg0, arg1);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.IO.File), "ReadAllText", typeof(string), 0);
                        }
                        var ret = System.IO.File.ReadAllText(arg0);
                        return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("ReadAllText", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_WriteAllBytes(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.IO.File), "WriteAllBytes", typeof(string), 0);
                    }
                    byte[] arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(System.IO.File), "WriteAllBytes", typeof(byte[]), 1);
                    }
                    System.IO.File.WriteAllBytes(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("WriteAllBytes", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_WriteAllLines(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(string[])) && Values.js_match_type(ctx, argv[2], typeof(System.Text.Encoding)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(System.IO.File), "WriteAllLines", typeof(string), 0);
                            }
                            string[] arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(System.IO.File), "WriteAllLines", typeof(string[]), 1);
                            }
                            System.Text.Encoding arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(System.IO.File), "WriteAllLines", typeof(System.Text.Encoding), 2);
                            }
                            System.IO.File.WriteAllLines(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(System.Collections.Generic.IEnumerable<string>)) && Values.js_match_type(ctx, argv[2], typeof(System.Text.Encoding)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(System.IO.File), "WriteAllLines", typeof(string), 0);
                            }
                            System.Collections.Generic.IEnumerable<string> arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(System.IO.File), "WriteAllLines", typeof(System.Collections.Generic.IEnumerable<string>), 1);
                            }
                            System.Text.Encoding arg2;
                            if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(System.IO.File), "WriteAllLines", typeof(System.Text.Encoding), 2);
                            }
                            System.IO.File.WriteAllLines(arg0, arg1, arg2);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                    if (argc == 2)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(string[])))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(System.IO.File), "WriteAllLines", typeof(string), 0);
                            }
                            string[] arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(System.IO.File), "WriteAllLines", typeof(string[]), 1);
                            }
                            System.IO.File.WriteAllLines(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_type(ctx, argv[1], typeof(System.Collections.Generic.IEnumerable<string>)))
                        {
                            string arg0;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(System.IO.File), "WriteAllLines", typeof(string), 0);
                            }
                            System.Collections.Generic.IEnumerable<string> arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(System.IO.File), "WriteAllLines", typeof(System.Collections.Generic.IEnumerable<string>), 1);
                            }
                            System.IO.File.WriteAllLines(arg0, arg1);
                            return JSApi.JS_UNDEFINED;
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("WriteAllLines", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_WriteAllText(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(System.IO.File), "WriteAllText", typeof(string), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.IO.File), "WriteAllText", typeof(string), 1);
                        }
                        System.Text.Encoding arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(System.IO.File), "WriteAllText", typeof(System.Text.Encoding), 2);
                        }
                        System.IO.File.WriteAllText(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.IO.File), "WriteAllText", typeof(string), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.IO.File), "WriteAllText", typeof(string), 1);
                        }
                        System.IO.File.WriteAllText(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("WriteAllText", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Encrypt(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.IO.File), "Encrypt", typeof(string), 0);
                    }
                    System.IO.File.Encrypt(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Encrypt", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Decrypt(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.IO.File), "Decrypt", typeof(string), 0);
                    }
                    System.IO.File.Decrypt(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Decrypt", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ReadLines(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(System.IO.File), "ReadLines", typeof(string), 0);
                        }
                        System.Text.Encoding arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.IO.File), "ReadLines", typeof(System.Text.Encoding), 1);
                        }
                        var ret = System.IO.File.ReadLines(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.IO.File), "ReadLines", typeof(string), 0);
                        }
                        var ret = System.IO.File.ReadLines(arg0);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("ReadLines", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_AppendAllLines(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
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
                            throw new ParameterException(typeof(System.IO.File), "AppendAllLines", typeof(string), 0);
                        }
                        System.Collections.Generic.IEnumerable<string> arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.IO.File), "AppendAllLines", typeof(System.Collections.Generic.IEnumerable<string>), 1);
                        }
                        System.Text.Encoding arg2;
                        if (!Values.js_get_classvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(System.IO.File), "AppendAllLines", typeof(System.Text.Encoding), 2);
                        }
                        System.IO.File.AppendAllLines(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 2)
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.IO.File), "AppendAllLines", typeof(string), 0);
                        }
                        System.Collections.Generic.IEnumerable<string> arg1;
                        if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.IO.File), "AppendAllLines", typeof(System.Collections.Generic.IEnumerable<string>), 1);
                        }
                        System.IO.File.AppendAllLines(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("AppendAllLines", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("File", typeof(System.IO.File), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "AppendAllText", BindStatic_AppendAllText);
            cls.AddMethod(true, "AppendText", BindStatic_AppendText);
            cls.AddMethod(true, "Copy", BindStatic_Copy);
            cls.AddMethod(true, "Create", BindStatic_Create);
            cls.AddMethod(true, "CreateText", BindStatic_CreateText);
            cls.AddMethod(true, "Delete", BindStatic_Delete);
            cls.AddMethod(true, "Exists", BindStatic_Exists);
            cls.AddMethod(true, "GetAttributes", BindStatic_GetAttributes);
            cls.AddMethod(true, "GetCreationTime", BindStatic_GetCreationTime);
            cls.AddMethod(true, "GetCreationTimeUtc", BindStatic_GetCreationTimeUtc);
            cls.AddMethod(true, "GetLastAccessTime", BindStatic_GetLastAccessTime);
            cls.AddMethod(true, "GetLastAccessTimeUtc", BindStatic_GetLastAccessTimeUtc);
            cls.AddMethod(true, "GetLastWriteTime", BindStatic_GetLastWriteTime);
            cls.AddMethod(true, "GetLastWriteTimeUtc", BindStatic_GetLastWriteTimeUtc);
            cls.AddMethod(true, "Move", BindStatic_Move);
            cls.AddMethod(true, "Open", BindStatic_Open);
            cls.AddMethod(true, "OpenRead", BindStatic_OpenRead);
            cls.AddMethod(true, "OpenText", BindStatic_OpenText);
            cls.AddMethod(true, "OpenWrite", BindStatic_OpenWrite);
            cls.AddMethod(true, "Replace", BindStatic_Replace);
            cls.AddMethod(true, "SetAttributes", BindStatic_SetAttributes);
            cls.AddMethod(true, "SetCreationTime", BindStatic_SetCreationTime);
            cls.AddMethod(true, "SetCreationTimeUtc", BindStatic_SetCreationTimeUtc);
            cls.AddMethod(true, "SetLastAccessTime", BindStatic_SetLastAccessTime);
            cls.AddMethod(true, "SetLastAccessTimeUtc", BindStatic_SetLastAccessTimeUtc);
            cls.AddMethod(true, "SetLastWriteTime", BindStatic_SetLastWriteTime);
            cls.AddMethod(true, "SetLastWriteTimeUtc", BindStatic_SetLastWriteTimeUtc);
            cls.AddMethod(true, "ReadAllBytes", BindStatic_ReadAllBytes);
            cls.AddMethod(true, "ReadAllLines", BindStatic_ReadAllLines);
            cls.AddMethod(true, "ReadAllText", BindStatic_ReadAllText);
            cls.AddMethod(true, "WriteAllBytes", BindStatic_WriteAllBytes);
            cls.AddMethod(true, "WriteAllLines", BindStatic_WriteAllLines);
            cls.AddMethod(true, "WriteAllText", BindStatic_WriteAllText);
            cls.AddMethod(true, "Encrypt", BindStatic_Encrypt);
            cls.AddMethod(true, "Decrypt", BindStatic_Decrypt);
            cls.AddMethod(true, "ReadLines", BindStatic_ReadLines);
            cls.AddMethod(true, "AppendAllLines", BindStatic_AppendAllLines);
            return cls;
        }
    }
}
#endif
