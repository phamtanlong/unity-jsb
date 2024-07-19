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
    // Assembly: UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Users/longpt/Documents/SkyMavis/unity-jsb-2/Library/ScriptAssemblies/UnityEngine.UI.dll
    // Type: UnityEngine.UI.VertexHelper
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_UI_VertexHelper
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                do
                {
                    if (argc == 1)
                    {
                        UnityEngine.Mesh arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), ".ctor", typeof(UnityEngine.Mesh), 0);
                        }
                        var o = new UnityEngine.UI.VertexHelper(arg0);
                        var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                        return val;
                    }
                    if (argc == 0)
                    {
                        var o = new UnityEngine.UI.VertexHelper();
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
        public static JSValue Bind_Dispose(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.UI.VertexHelper self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.Dispose();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Dispose", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Clear(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.UI.VertexHelper self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.Clear();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Clear", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_PopulateUIVertex(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.UI.VertexHelper self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.UIVertex arg0;
                    var refVal0 = Values.js_read_wrap(ctx, argv[0]);
                    if (refVal0.IsException())
                    {
                        return refVal0;
                    }
                    if (!Values.js_get_structvalue(ctx, refVal0, out arg0))
                    {
                        JSApi.JS_FreeValue(ctx, refVal0);
                        throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), "PopulateUIVertex", typeof(UnityEngine.UIVertex), 0);
                    }
                    JSApi.JS_FreeValue(ctx, refVal0);
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), "PopulateUIVertex", typeof(int), 1);
                    }
                    self.PopulateUIVertex(ref arg0, arg1);
                    var out0 = Values.js_push_structvalue(ctx, arg0);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[0], context.GetAtom("value"), out0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("PopulateUIVertex", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetUIVertex(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.UI.VertexHelper self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.UIVertex arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), "SetUIVertex", typeof(UnityEngine.UIVertex), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), "SetUIVertex", typeof(int), 1);
                    }
                    self.SetUIVertex(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetUIVertex", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_FillMesh(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.UI.VertexHelper self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Mesh arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), "FillMesh", typeof(UnityEngine.Mesh), 0);
                    }
                    self.FillMesh(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("FillMesh", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_AddVert(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                do
                {
                    if (argc == 8)
                    {
                        UnityEngine.UI.VertexHelper self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), "AddVert", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Color32 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), "AddVert", typeof(UnityEngine.Color32), 1);
                        }
                        UnityEngine.Vector2 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), "AddVert", typeof(UnityEngine.Vector2), 2);
                        }
                        UnityEngine.Vector2 arg3;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), "AddVert", typeof(UnityEngine.Vector2), 3);
                        }
                        UnityEngine.Vector2 arg4;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), "AddVert", typeof(UnityEngine.Vector2), 4);
                        }
                        UnityEngine.Vector2 arg5;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), "AddVert", typeof(UnityEngine.Vector2), 5);
                        }
                        UnityEngine.Vector3 arg6;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), "AddVert", typeof(UnityEngine.Vector3), 6);
                        }
                        UnityEngine.Vector4 arg7;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[7], out arg7))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), "AddVert", typeof(UnityEngine.Vector4), 7);
                        }
                        self.AddVert(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 6)
                    {
                        UnityEngine.UI.VertexHelper self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), "AddVert", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Color32 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), "AddVert", typeof(UnityEngine.Color32), 1);
                        }
                        UnityEngine.Vector2 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), "AddVert", typeof(UnityEngine.Vector2), 2);
                        }
                        UnityEngine.Vector2 arg3;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), "AddVert", typeof(UnityEngine.Vector2), 3);
                        }
                        UnityEngine.Vector3 arg4;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), "AddVert", typeof(UnityEngine.Vector3), 4);
                        }
                        UnityEngine.Vector4 arg5;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), "AddVert", typeof(UnityEngine.Vector4), 5);
                        }
                        self.AddVert(arg0, arg1, arg2, arg3, arg4, arg5);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 3)
                    {
                        UnityEngine.UI.VertexHelper self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.Vector3 arg0;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), "AddVert", typeof(UnityEngine.Vector3), 0);
                        }
                        UnityEngine.Color32 arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), "AddVert", typeof(UnityEngine.Color32), 1);
                        }
                        UnityEngine.Vector2 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), "AddVert", typeof(UnityEngine.Vector2), 2);
                        }
                        self.AddVert(arg0, arg1, arg2);
                        return JSApi.JS_UNDEFINED;
                    }
                    if (argc == 1)
                    {
                        UnityEngine.UI.VertexHelper self;
                        if (!Values.js_get_classvalue(ctx, this_obj, out self))
                        {
                            throw new ThisBoundException();
                        }
                        UnityEngine.UIVertex arg0;
                        if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), "AddVert", typeof(UnityEngine.UIVertex), 0);
                        }
                        self.AddVert(arg0);
                        return JSApi.JS_UNDEFINED;
                    }
                } while(false);
                throw new NoSuitableMethodException("AddVert", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_AddTriangle(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.UI.VertexHelper self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), "AddTriangle", typeof(int), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), "AddTriangle", typeof(int), 1);
                    }
                    int arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), "AddTriangle", typeof(int), 2);
                    }
                    self.AddTriangle(arg0, arg1, arg2);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("AddTriangle", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_AddUIVertexQuad(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.UI.VertexHelper self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.UIVertex[] arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), "AddUIVertexQuad", typeof(UnityEngine.UIVertex[]), 0);
                    }
                    self.AddUIVertexQuad(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("AddUIVertexQuad", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_AddUIVertexStream(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.UI.VertexHelper self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    System.Collections.Generic.List<UnityEngine.UIVertex> arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), "AddUIVertexStream", typeof(System.Collections.Generic.List<UnityEngine.UIVertex>), 0);
                    }
                    System.Collections.Generic.List<int> arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), "AddUIVertexStream", typeof(System.Collections.Generic.List<int>), 1);
                    }
                    self.AddUIVertexStream(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("AddUIVertexStream", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_AddUIVertexTriangleStream(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.UI.VertexHelper self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    System.Collections.Generic.List<UnityEngine.UIVertex> arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), "AddUIVertexTriangleStream", typeof(System.Collections.Generic.List<UnityEngine.UIVertex>), 0);
                    }
                    self.AddUIVertexTriangleStream(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("AddUIVertexTriangleStream", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetUIVertexStream(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.UI.VertexHelper self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    System.Collections.Generic.List<UnityEngine.UIVertex> arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.UI.VertexHelper), "GetUIVertexStream", typeof(System.Collections.Generic.List<UnityEngine.UIVertex>), 0);
                    }
                    self.GetUIVertexStream(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("GetUIVertexStream", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_currentVertCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.VertexHelper self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.currentVertCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_currentIndexCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.UI.VertexHelper self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.currentIndexCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("VertexHelper", typeof(UnityEngine.UI.VertexHelper), BindConstructor);
            cls.AddMethod(false, "Dispose", Bind_Dispose);
            cls.AddMethod(false, "Clear", Bind_Clear);
            cls.AddMethod(false, "PopulateUIVertex", Bind_PopulateUIVertex);
            cls.AddMethod(false, "SetUIVertex", Bind_SetUIVertex);
            cls.AddMethod(false, "FillMesh", Bind_FillMesh);
            cls.AddMethod(false, "AddVert", Bind_AddVert);
            cls.AddMethod(false, "AddTriangle", Bind_AddTriangle);
            cls.AddMethod(false, "AddUIVertexQuad", Bind_AddUIVertexQuad);
            cls.AddMethod(false, "AddUIVertexStream", Bind_AddUIVertexStream);
            cls.AddMethod(false, "AddUIVertexTriangleStream", Bind_AddUIVertexTriangleStream);
            cls.AddMethod(false, "GetUIVertexStream", Bind_GetUIVertexStream);
            cls.AddProperty(false, "currentVertCount", BindRead_currentVertCount, null);
            cls.AddProperty(false, "currentIndexCount", BindRead_currentIndexCount, null);
            return cls;
        }
    }
}
#endif
