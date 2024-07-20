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
    // Type: UnityEditor.ShaderData+Pass
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_ShaderData_Pass
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_FindTagValue(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.ShaderData.Pass self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Rendering.ShaderTagId arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "FindTagValue", typeof(UnityEngine.Rendering.ShaderTagId), 0);
                    }
                    var ret = self.FindTagValue(arg0);
                    return Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("FindTagValue", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_HasShaderStage(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.ShaderData.Pass self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEditor.Rendering.ShaderType arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "HasShaderStage", typeof(UnityEditor.Rendering.ShaderType), 0);
                    }
                    var ret = self.HasShaderStage(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("HasShaderStage", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_CompileVariant(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 7)
                    {
                        UnityEditor.ShaderData.Pass self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEditor.Rendering.ShaderType arg0;
                        if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEditor.Rendering.ShaderType), 0);
                        }
                        string[] arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(string[]), 1);
                        }
                        UnityEditor.Rendering.ShaderCompilerPlatform arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEditor.Rendering.ShaderCompilerPlatform), 2);
                        }
                        UnityEditor.BuildTarget arg3;
                        if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEditor.BuildTarget), 3);
                        }
                        UnityEngine.Rendering.BuiltinShaderDefine[] arg4;
                        if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEngine.Rendering.BuiltinShaderDefine[]), 4);
                        }
                        UnityEngine.Rendering.GraphicsTier arg5;
                        if (!Values.js_get_enumvalue(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEngine.Rendering.GraphicsTier), 5);
                        }
                        bool arg6;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(bool), 6);
                        }
                        var ret = self.CompileVariant(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                        return Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 6)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Rendering.ShaderType)) && Values.js_match_type(ctx, argv[1], typeof(string[])) && Values.js_match_type(ctx, argv[2], typeof(UnityEditor.Rendering.ShaderCompilerPlatform)) && Values.js_match_type(ctx, argv[3], typeof(UnityEditor.BuildTarget)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.Rendering.GraphicsTier)) && Values.js_match_type(ctx, argv[5], typeof(bool)))
                        {
                            UnityEditor.ShaderData.Pass self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEditor.Rendering.ShaderType arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEditor.Rendering.ShaderType), 0);
                            }
                            string[] arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(string[]), 1);
                            }
                            UnityEditor.Rendering.ShaderCompilerPlatform arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEditor.Rendering.ShaderCompilerPlatform), 2);
                            }
                            UnityEditor.BuildTarget arg3;
                            if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEditor.BuildTarget), 3);
                            }
                            UnityEngine.Rendering.GraphicsTier arg4;
                            if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEngine.Rendering.GraphicsTier), 4);
                            }
                            bool arg5;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(bool), 5);
                            }
                            var ret = self.CompileVariant(arg0, arg1, arg2, arg3, arg4, arg5);
                            return Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Rendering.ShaderType)) && Values.js_match_type(ctx, argv[1], typeof(string[])) && Values.js_match_type(ctx, argv[2], typeof(UnityEditor.Rendering.ShaderCompilerPlatform)) && Values.js_match_type(ctx, argv[3], typeof(UnityEditor.BuildTarget)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.Rendering.BuiltinShaderDefine[])) && Values.js_match_type(ctx, argv[5], typeof(bool)))
                        {
                            UnityEditor.ShaderData.Pass self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEditor.Rendering.ShaderType arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEditor.Rendering.ShaderType), 0);
                            }
                            string[] arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(string[]), 1);
                            }
                            UnityEditor.Rendering.ShaderCompilerPlatform arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEditor.Rendering.ShaderCompilerPlatform), 2);
                            }
                            UnityEditor.BuildTarget arg3;
                            if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEditor.BuildTarget), 3);
                            }
                            UnityEngine.Rendering.BuiltinShaderDefine[] arg4;
                            if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEngine.Rendering.BuiltinShaderDefine[]), 4);
                            }
                            bool arg5;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(bool), 5);
                            }
                            var ret = self.CompileVariant(arg0, arg1, arg2, arg3, arg4, arg5);
                            return Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Rendering.ShaderType)) && Values.js_match_type(ctx, argv[1], typeof(string[])) && Values.js_match_type(ctx, argv[2], typeof(UnityEditor.Rendering.ShaderCompilerPlatform)) && Values.js_match_type(ctx, argv[3], typeof(UnityEditor.BuildTarget)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.Rendering.BuiltinShaderDefine[])) && Values.js_match_type(ctx, argv[5], typeof(UnityEngine.Rendering.GraphicsTier)))
                        {
                            UnityEditor.ShaderData.Pass self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEditor.Rendering.ShaderType arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEditor.Rendering.ShaderType), 0);
                            }
                            string[] arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(string[]), 1);
                            }
                            UnityEditor.Rendering.ShaderCompilerPlatform arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEditor.Rendering.ShaderCompilerPlatform), 2);
                            }
                            UnityEditor.BuildTarget arg3;
                            if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEditor.BuildTarget), 3);
                            }
                            UnityEngine.Rendering.BuiltinShaderDefine[] arg4;
                            if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEngine.Rendering.BuiltinShaderDefine[]), 4);
                            }
                            UnityEngine.Rendering.GraphicsTier arg5;
                            if (!Values.js_get_enumvalue(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEngine.Rendering.GraphicsTier), 5);
                            }
                            var ret = self.CompileVariant(arg0, arg1, arg2, arg3, arg4, arg5);
                            return Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc == 5)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Rendering.ShaderType)) && Values.js_match_type(ctx, argv[1], typeof(string[])) && Values.js_match_type(ctx, argv[2], typeof(UnityEditor.Rendering.ShaderCompilerPlatform)) && Values.js_match_type(ctx, argv[3], typeof(UnityEditor.BuildTarget)) && Values.js_match_type(ctx, argv[4], typeof(bool)))
                        {
                            UnityEditor.ShaderData.Pass self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEditor.Rendering.ShaderType arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEditor.Rendering.ShaderType), 0);
                            }
                            string[] arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(string[]), 1);
                            }
                            UnityEditor.Rendering.ShaderCompilerPlatform arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEditor.Rendering.ShaderCompilerPlatform), 2);
                            }
                            UnityEditor.BuildTarget arg3;
                            if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEditor.BuildTarget), 3);
                            }
                            bool arg4;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(bool), 4);
                            }
                            var ret = self.CompileVariant(arg0, arg1, arg2, arg3, arg4);
                            return Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Rendering.ShaderType)) && Values.js_match_type(ctx, argv[1], typeof(string[])) && Values.js_match_type(ctx, argv[2], typeof(UnityEditor.Rendering.ShaderCompilerPlatform)) && Values.js_match_type(ctx, argv[3], typeof(UnityEditor.BuildTarget)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.Rendering.GraphicsTier)))
                        {
                            UnityEditor.ShaderData.Pass self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEditor.Rendering.ShaderType arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEditor.Rendering.ShaderType), 0);
                            }
                            string[] arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(string[]), 1);
                            }
                            UnityEditor.Rendering.ShaderCompilerPlatform arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEditor.Rendering.ShaderCompilerPlatform), 2);
                            }
                            UnityEditor.BuildTarget arg3;
                            if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEditor.BuildTarget), 3);
                            }
                            UnityEngine.Rendering.GraphicsTier arg4;
                            if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEngine.Rendering.GraphicsTier), 4);
                            }
                            var ret = self.CompileVariant(arg0, arg1, arg2, arg3, arg4);
                            return Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Rendering.ShaderType)) && Values.js_match_type(ctx, argv[1], typeof(string[])) && Values.js_match_type(ctx, argv[2], typeof(UnityEditor.Rendering.ShaderCompilerPlatform)) && Values.js_match_type(ctx, argv[3], typeof(UnityEditor.BuildTarget)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.Rendering.BuiltinShaderDefine[])))
                        {
                            UnityEditor.ShaderData.Pass self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEditor.Rendering.ShaderType arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEditor.Rendering.ShaderType), 0);
                            }
                            string[] arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(string[]), 1);
                            }
                            UnityEditor.Rendering.ShaderCompilerPlatform arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEditor.Rendering.ShaderCompilerPlatform), 2);
                            }
                            UnityEditor.BuildTarget arg3;
                            if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEditor.BuildTarget), 3);
                            }
                            UnityEngine.Rendering.BuiltinShaderDefine[] arg4;
                            if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEngine.Rendering.BuiltinShaderDefine[]), 4);
                            }
                            var ret = self.CompileVariant(arg0, arg1, arg2, arg3, arg4);
                            return Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc == 4)
                    {
                        UnityEditor.ShaderData.Pass self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEditor.Rendering.ShaderType arg0;
                        if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEditor.Rendering.ShaderType), 0);
                        }
                        string[] arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(string[]), 1);
                        }
                        UnityEditor.Rendering.ShaderCompilerPlatform arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEditor.Rendering.ShaderCompilerPlatform), 2);
                        }
                        UnityEditor.BuildTarget arg3;
                        if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "CompileVariant", typeof(UnityEditor.BuildTarget), 3);
                        }
                        var ret = self.CompileVariant(arg0, arg1, arg2, arg3);
                        return Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("CompileVariant", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_PreprocessVariant(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 7)
                    {
                        UnityEditor.ShaderData.Pass self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEditor.Rendering.ShaderType arg0;
                        if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "PreprocessVariant", typeof(UnityEditor.Rendering.ShaderType), 0);
                        }
                        string[] arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "PreprocessVariant", typeof(string[]), 1);
                        }
                        UnityEditor.Rendering.ShaderCompilerPlatform arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "PreprocessVariant", typeof(UnityEditor.Rendering.ShaderCompilerPlatform), 2);
                        }
                        UnityEditor.BuildTarget arg3;
                        if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "PreprocessVariant", typeof(UnityEditor.BuildTarget), 3);
                        }
                        UnityEngine.Rendering.BuiltinShaderDefine[] arg4;
                        if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "PreprocessVariant", typeof(UnityEngine.Rendering.BuiltinShaderDefine[]), 4);
                        }
                        UnityEngine.Rendering.GraphicsTier arg5;
                        if (!Values.js_get_enumvalue(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "PreprocessVariant", typeof(UnityEngine.Rendering.GraphicsTier), 5);
                        }
                        bool arg6;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "PreprocessVariant", typeof(bool), 6);
                        }
                        var ret = self.PreprocessVariant(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                        return Values.js_push_structvalue(ctx, ret);
                    }
                    if (argc == 6)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Rendering.ShaderType)) && Values.js_match_type(ctx, argv[1], typeof(string[])) && Values.js_match_type(ctx, argv[2], typeof(UnityEditor.Rendering.ShaderCompilerPlatform)) && Values.js_match_type(ctx, argv[3], typeof(UnityEditor.BuildTarget)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.Rendering.GraphicsTier)) && Values.js_match_type(ctx, argv[5], typeof(bool)))
                        {
                            UnityEditor.ShaderData.Pass self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEditor.Rendering.ShaderType arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "PreprocessVariant", typeof(UnityEditor.Rendering.ShaderType), 0);
                            }
                            string[] arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "PreprocessVariant", typeof(string[]), 1);
                            }
                            UnityEditor.Rendering.ShaderCompilerPlatform arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "PreprocessVariant", typeof(UnityEditor.Rendering.ShaderCompilerPlatform), 2);
                            }
                            UnityEditor.BuildTarget arg3;
                            if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "PreprocessVariant", typeof(UnityEditor.BuildTarget), 3);
                            }
                            UnityEngine.Rendering.GraphicsTier arg4;
                            if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "PreprocessVariant", typeof(UnityEngine.Rendering.GraphicsTier), 4);
                            }
                            bool arg5;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "PreprocessVariant", typeof(bool), 5);
                            }
                            var ret = self.PreprocessVariant(arg0, arg1, arg2, arg3, arg4, arg5);
                            return Values.js_push_structvalue(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.Rendering.ShaderType)) && Values.js_match_type(ctx, argv[1], typeof(string[])) && Values.js_match_type(ctx, argv[2], typeof(UnityEditor.Rendering.ShaderCompilerPlatform)) && Values.js_match_type(ctx, argv[3], typeof(UnityEditor.BuildTarget)) && Values.js_match_type(ctx, argv[4], typeof(UnityEngine.Rendering.BuiltinShaderDefine[])) && Values.js_match_type(ctx, argv[5], typeof(bool)))
                        {
                            UnityEditor.ShaderData.Pass self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEditor.Rendering.ShaderType arg0;
                            if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "PreprocessVariant", typeof(UnityEditor.Rendering.ShaderType), 0);
                            }
                            string[] arg1;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "PreprocessVariant", typeof(string[]), 1);
                            }
                            UnityEditor.Rendering.ShaderCompilerPlatform arg2;
                            if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "PreprocessVariant", typeof(UnityEditor.Rendering.ShaderCompilerPlatform), 2);
                            }
                            UnityEditor.BuildTarget arg3;
                            if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "PreprocessVariant", typeof(UnityEditor.BuildTarget), 3);
                            }
                            UnityEngine.Rendering.BuiltinShaderDefine[] arg4;
                            if (!Values.js_get_enumvalue(ctx, argv[4], out arg4))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "PreprocessVariant", typeof(UnityEngine.Rendering.BuiltinShaderDefine[]), 4);
                            }
                            bool arg5;
                            if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[5], out arg5))
                            {
                                throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "PreprocessVariant", typeof(bool), 5);
                            }
                            var ret = self.PreprocessVariant(arg0, arg1, arg2, arg3, arg4, arg5);
                            return Values.js_push_structvalue(ctx, ret);
                        }
                    }
                    if (argc == 5)
                    {
                        UnityEditor.ShaderData.Pass self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEditor.Rendering.ShaderType arg0;
                        if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "PreprocessVariant", typeof(UnityEditor.Rendering.ShaderType), 0);
                        }
                        string[] arg1;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "PreprocessVariant", typeof(string[]), 1);
                        }
                        UnityEditor.Rendering.ShaderCompilerPlatform arg2;
                        if (!Values.js_get_enumvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "PreprocessVariant", typeof(UnityEditor.Rendering.ShaderCompilerPlatform), 2);
                        }
                        UnityEditor.BuildTarget arg3;
                        if (!Values.js_get_enumvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "PreprocessVariant", typeof(UnityEditor.BuildTarget), 3);
                        }
                        bool arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEditor.ShaderData.Pass), "PreprocessVariant", typeof(bool), 4);
                        }
                        var ret = self.PreprocessVariant(arg0, arg1, arg2, arg3, arg4);
                        return Values.js_push_structvalue(ctx, ret);
                    }
                } while(false);
                throw new NoSuitableMethodException("PreprocessVariant", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_SourceCode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.ShaderData.Pass self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.SourceCode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
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
                UnityEditor.ShaderData.Pass self;
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
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("Pass", typeof(UnityEditor.ShaderData.Pass), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(false, "FindTagValue", Bind_FindTagValue);
            cls.AddMethod(false, "HasShaderStage", Bind_HasShaderStage);
            cls.AddMethod(false, "CompileVariant", Bind_CompileVariant);
            cls.AddMethod(false, "PreprocessVariant", Bind_PreprocessVariant);
            cls.AddProperty(false, "SourceCode", BindRead_SourceCode, null);
            cls.AddProperty(false, "Name", BindRead_Name, null);
            return cls;
        }
    }
}
#endif
#endif
