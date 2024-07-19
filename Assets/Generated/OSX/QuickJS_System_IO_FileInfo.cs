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
    // Type: System.IO.FileInfo
    [JSBindingAttribute]
    public class QuickJS_System_IO_FileInfo
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.IO.FileInfo), ".ctor", typeof(string), 0);
                    }
                    var o = new System.IO.FileInfo(arg0);
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
        public static JSValue Bind_OpenText(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    System.IO.FileInfo self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.OpenText();
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
        public static JSValue Bind_CreateText(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    System.IO.FileInfo self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.CreateText();
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
        public static JSValue Bind_AppendText(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    System.IO.FileInfo self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.AppendText();
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
        public static JSValue Bind_CopyTo(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        System.IO.FileInfo self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.IO.FileInfo), "CopyTo", typeof(string), 0);
                        }
                        bool arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.IO.FileInfo), "CopyTo", typeof(bool), 1);
                        }
                        var ret = self.CopyTo(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        System.IO.FileInfo self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.IO.FileInfo), "CopyTo", typeof(string), 0);
                        }
                        var ret = self.CopyTo(arg0);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("CopyTo", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Create(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    System.IO.FileInfo self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.Create();
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("Create", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Delete(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    System.IO.FileInfo self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.Delete();
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
        public static JSValue Bind_Decrypt(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    System.IO.FileInfo self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.Decrypt();
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
        public static JSValue Bind_Encrypt(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    System.IO.FileInfo self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.Encrypt();
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
        public static JSValue Bind_Open(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        System.IO.FileInfo self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        System.IO.FileMode arg0;
                        if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.IO.FileInfo), "Open", typeof(System.IO.FileMode), 0);
                        }
                        System.IO.FileAccess arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.IO.FileInfo), "Open", typeof(System.IO.FileAccess), 1);
                        }
                        System.IO.FileShare arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(System.IO.FileInfo), "Open", typeof(System.IO.FileShare), 2);
                        }
                        var ret = self.Open(arg0, arg1, arg2);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        System.IO.FileInfo self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        System.IO.FileMode arg0;
                        if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.IO.FileInfo), "Open", typeof(System.IO.FileMode), 0);
                        }
                        System.IO.FileAccess arg1;
                        if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.IO.FileInfo), "Open", typeof(System.IO.FileAccess), 1);
                        }
                        var ret = self.Open(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 1)
                    {
                        System.IO.FileInfo self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        System.IO.FileMode arg0;
                        if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.IO.FileInfo), "Open", typeof(System.IO.FileMode), 0);
                        }
                        var ret = self.Open(arg0);
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
        public static JSValue Bind_OpenRead(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    System.IO.FileInfo self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.OpenRead();
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
        public static JSValue Bind_OpenWrite(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    System.IO.FileInfo self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.OpenWrite();
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
        public static JSValue Bind_MoveTo(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    System.IO.FileInfo self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(System.IO.FileInfo), "MoveTo", typeof(string), 0);
                    }
                    self.MoveTo(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("MoveTo", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Replace(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 3)
                    {
                        System.IO.FileInfo self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.IO.FileInfo), "Replace", typeof(string), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.IO.FileInfo), "Replace", typeof(string), 1);
                        }
                        bool arg2;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(System.IO.FileInfo), "Replace", typeof(bool), 2);
                        }
                        var ret = self.Replace(arg0, arg1, arg2);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 2)
                    {
                        System.IO.FileInfo self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(System.IO.FileInfo), "Replace", typeof(string), 0);
                        }
                        string arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(System.IO.FileInfo), "Replace", typeof(string), 1);
                        }
                        var ret = self.Replace(arg0, arg1);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("Replace", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ToString(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    System.IO.FileInfo self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.ToString();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("toString", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_Name(JSContext ctx, JSValue this_obj)
        {
            try
            {
                System.IO.FileInfo self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.Name;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_Length(JSContext ctx, JSValue this_obj)
        {
            try
            {
                System.IO.FileInfo self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.Length;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_DirectoryName(JSContext ctx, JSValue this_obj)
        {
            try
            {
                System.IO.FileInfo self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.DirectoryName;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_Directory(JSContext ctx, JSValue this_obj)
        {
            try
            {
                System.IO.FileInfo self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.Directory;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_IsReadOnly(JSContext ctx, JSValue this_obj)
        {
            try
            {
                System.IO.FileInfo self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.IsReadOnly;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_IsReadOnly(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                System.IO.FileInfo self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(System.IO.FileInfo), "IsReadOnly", typeof(bool), 0);
                }
                self.IsReadOnly = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_Exists(JSContext ctx, JSValue this_obj)
        {
            try
            {
                System.IO.FileInfo self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.Exists;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("FileInfo", typeof(System.IO.FileInfo), BindConstructor);
            cls.AddMethod(false, "OpenText", Bind_OpenText);
            cls.AddMethod(false, "CreateText", Bind_CreateText);
            cls.AddMethod(false, "AppendText", Bind_AppendText);
            cls.AddMethod(false, "CopyTo", Bind_CopyTo);
            cls.AddMethod(false, "Create", Bind_Create);
            cls.AddMethod(false, "Delete", Bind_Delete);
            cls.AddMethod(false, "Decrypt", Bind_Decrypt);
            cls.AddMethod(false, "Encrypt", Bind_Encrypt);
            cls.AddMethod(false, "Open", Bind_Open);
            cls.AddMethod(false, "OpenRead", Bind_OpenRead);
            cls.AddMethod(false, "OpenWrite", Bind_OpenWrite);
            cls.AddMethod(false, "MoveTo", Bind_MoveTo);
            cls.AddMethod(false, "Replace", Bind_Replace);
            cls.AddMethod(false, "toString", Bind_ToString);
            cls.AddProperty(false, "Name", BindRead_Name, null);
            cls.AddProperty(false, "Length", BindRead_Length, null);
            cls.AddProperty(false, "DirectoryName", BindRead_DirectoryName, null);
            cls.AddProperty(false, "Directory", BindRead_Directory, null);
            cls.AddProperty(false, "IsReadOnly", BindRead_IsReadOnly, BindWrite_IsReadOnly);
            cls.AddProperty(false, "Exists", BindRead_Exists, null);
            return cls;
        }
    }
}
#endif
