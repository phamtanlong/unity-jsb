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
    // Type: UnityEditor.Handles+DrawingScope
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_Handles_DrawingScope
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                do
                {
                    if (argc == 2)
                    {
                        UnityEngine.Color arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles.DrawingScope), ".ctor", typeof(UnityEngine.Color), 0);
                        }
                        UnityEngine.Matrix4x4 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEditor.Handles.DrawingScope), ".ctor", typeof(UnityEngine.Matrix4x4), 1);
                        }
                        var o = new UnityEditor.Handles.DrawingScope(arg0, arg1);
                        var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                        return val;
                    }
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Color)))
                        {
                            UnityEngine.Color arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles.DrawingScope), ".ctor", typeof(UnityEngine.Color), 0);
                            }
                            var o = new UnityEditor.Handles.DrawingScope(arg0);
                            var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                            return val;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Matrix4x4)))
                        {
                            UnityEngine.Matrix4x4 arg0;
                            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.Handles.DrawingScope), ".ctor", typeof(UnityEngine.Matrix4x4), 0);
                            }
                            var o = new UnityEditor.Handles.DrawingScope(arg0);
                            var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                            return val;
                        }
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
        public static JSValue Bind_Dispose(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.Handles.DrawingScope self;
                    if (!Values.js_get_structvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.Dispose();
                    Values.js_rebind_this(ctx, this_obj, ref self);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Dispose", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_originalColor(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.Handles.DrawingScope self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.originalColor;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_originalMatrix(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.Handles.DrawingScope self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.originalMatrix;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("DrawingScope", typeof(UnityEditor.Handles.DrawingScope), BindConstructor);
            cls.AddMethod(false, "Dispose", Bind_Dispose);
            cls.AddProperty(false, "originalColor", BindRead_originalColor, null);
            cls.AddProperty(false, "originalMatrix", BindRead_originalMatrix, null);
            return cls;
        }
    }
}
#endif
#endif
