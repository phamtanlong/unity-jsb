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
    // Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2019.4.40f1/Unity.app/Contents/Managed/UnityEngine/UnityEngine.CoreModule.dll
    // Type: UnityEngine.Sprite
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_Sprite
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetPhysicsShapeCount(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Sprite self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.GetPhysicsShapeCount();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetPhysicsShapeCount", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetPhysicsShapePointCount(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Sprite self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Sprite), "GetPhysicsShapePointCount", typeof(int), 0);
                    }
                    var ret = self.GetPhysicsShapePointCount(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetPhysicsShapePointCount", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetPhysicsShape(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Sprite self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Sprite), "GetPhysicsShape", typeof(int), 0);
                    }
                    System.Collections.Generic.List<UnityEngine.Vector2> arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Sprite), "GetPhysicsShape", typeof(System.Collections.Generic.List<UnityEngine.Vector2>), 1);
                    }
                    var ret = self.GetPhysicsShape(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetPhysicsShape", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_OverridePhysicsShape(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Sprite self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    System.Collections.Generic.IList<UnityEngine.Vector2[]> arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Sprite), "OverridePhysicsShape", typeof(System.Collections.Generic.IList<UnityEngine.Vector2[]>), 0);
                    }
                    self.OverridePhysicsShape(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("OverridePhysicsShape", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_OverrideGeometry(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Sprite self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Vector2[] arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.Sprite), "OverrideGeometry", typeof(UnityEngine.Vector2[]), 0);
                    }
                    ushort[] arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEngine.Sprite), "OverrideGeometry", typeof(ushort[]), 1);
                    }
                    self.OverrideGeometry(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("OverrideGeometry", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetBones(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Sprite self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = UnityEngine.U2D.SpriteDataAccessExtensions.GetBones(self);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetBones", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetBones(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Sprite self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.U2D.SpriteBone[] arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.U2D.SpriteDataAccessExtensions), "SetBones", typeof(UnityEngine.U2D.SpriteBone[]), 0);
                    }
                    UnityEngine.U2D.SpriteDataAccessExtensions.SetBones(self, arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetBones", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_HasVertexAttribute(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Sprite self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEngine.Rendering.VertexAttribute arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.U2D.SpriteDataAccessExtensions), "HasVertexAttribute", typeof(UnityEngine.Rendering.VertexAttribute), 0);
                    }
                    var ret = UnityEngine.U2D.SpriteDataAccessExtensions.HasVertexAttribute(self, arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("HasVertexAttribute", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetVertexCount(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Sprite self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEngine.U2D.SpriteDataAccessExtensions), "SetVertexCount", typeof(int), 0);
                    }
                    UnityEngine.U2D.SpriteDataAccessExtensions.SetVertexCount(self, arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetVertexCount", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetVertexCount(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEngine.Sprite self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = UnityEngine.U2D.SpriteDataAccessExtensions.GetVertexCount(self);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetVertexCount", argc);
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
                    if (argc == 8)
                    {
                        UnityEngine.Texture2D arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(UnityEngine.Texture2D), 0);
                        }
                        UnityEngine.Rect arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(UnityEngine.Rect), 1);
                        }
                        UnityEngine.Vector2 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(UnityEngine.Vector2), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(float), 3);
                        }
                        uint arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(uint), 4);
                        }
                        UnityEngine.SpriteMeshType arg5;
                        if (!Values.js_get_enumvalue(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(UnityEngine.SpriteMeshType), 5);
                        }
                        UnityEngine.Vector4 arg6;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(UnityEngine.Vector4), 6);
                        }
                        bool arg7;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[7], out arg7))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(bool), 7);
                        }
                        var ret = UnityEngine.Sprite.Create(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 7)
                    {
                        UnityEngine.Texture2D arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(UnityEngine.Texture2D), 0);
                        }
                        UnityEngine.Rect arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(UnityEngine.Rect), 1);
                        }
                        UnityEngine.Vector2 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(UnityEngine.Vector2), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(float), 3);
                        }
                        uint arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(uint), 4);
                        }
                        UnityEngine.SpriteMeshType arg5;
                        if (!Values.js_get_enumvalue(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(UnityEngine.SpriteMeshType), 5);
                        }
                        UnityEngine.Vector4 arg6;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[6], out arg6))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(UnityEngine.Vector4), 6);
                        }
                        var ret = UnityEngine.Sprite.Create(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 6)
                    {
                        UnityEngine.Texture2D arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(UnityEngine.Texture2D), 0);
                        }
                        UnityEngine.Rect arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(UnityEngine.Rect), 1);
                        }
                        UnityEngine.Vector2 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(UnityEngine.Vector2), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(float), 3);
                        }
                        uint arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(uint), 4);
                        }
                        UnityEngine.SpriteMeshType arg5;
                        if (!Values.js_get_enumvalue(ctx, argv[5], out arg5))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(UnityEngine.SpriteMeshType), 5);
                        }
                        var ret = UnityEngine.Sprite.Create(arg0, arg1, arg2, arg3, arg4, arg5);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 5)
                    {
                        UnityEngine.Texture2D arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(UnityEngine.Texture2D), 0);
                        }
                        UnityEngine.Rect arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(UnityEngine.Rect), 1);
                        }
                        UnityEngine.Vector2 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(UnityEngine.Vector2), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(float), 3);
                        }
                        uint arg4;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[4], out arg4))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(uint), 4);
                        }
                        var ret = UnityEngine.Sprite.Create(arg0, arg1, arg2, arg3, arg4);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 4)
                    {
                        UnityEngine.Texture2D arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(UnityEngine.Texture2D), 0);
                        }
                        UnityEngine.Rect arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(UnityEngine.Rect), 1);
                        }
                        UnityEngine.Vector2 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(UnityEngine.Vector2), 2);
                        }
                        float arg3;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(float), 3);
                        }
                        var ret = UnityEngine.Sprite.Create(arg0, arg1, arg2, arg3);
                        return Values.js_push_classvalue(ctx, ret);
                    }
                    if (argc == 3)
                    {
                        UnityEngine.Texture2D arg0;
                        if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(UnityEngine.Texture2D), 0);
                        }
                        UnityEngine.Rect arg1;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[1], out arg1))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(UnityEngine.Rect), 1);
                        }
                        UnityEngine.Vector2 arg2;
                        if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                        {
                            throw new ParameterException(typeof(UnityEngine.Sprite), "Create", typeof(UnityEngine.Vector2), 2);
                        }
                        var ret = UnityEngine.Sprite.Create(arg0, arg1, arg2);
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
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_bounds(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Sprite self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.bounds;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_rect(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Sprite self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.rect;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_border(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Sprite self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.border;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_texture(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Sprite self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.texture;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_pixelsPerUnit(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Sprite self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.pixelsPerUnit;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_spriteAtlasTextureScale(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Sprite self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.spriteAtlasTextureScale;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_associatedAlphaSplitTexture(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Sprite self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.associatedAlphaSplitTexture;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_pivot(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Sprite self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.pivot;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_packed(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Sprite self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.packed;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_packingMode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Sprite self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.packingMode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_packingRotation(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Sprite self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.packingRotation;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_textureRect(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Sprite self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.textureRect;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_textureRectOffset(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Sprite self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.textureRectOffset;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_vertices(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Sprite self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.vertices;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_triangles(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Sprite self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.triangles;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_uv(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.Sprite self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.uv;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("Sprite", typeof(UnityEngine.Sprite), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(false, "GetPhysicsShapeCount", Bind_GetPhysicsShapeCount);
            cls.AddMethod(false, "GetPhysicsShapePointCount", Bind_GetPhysicsShapePointCount);
            cls.AddMethod(false, "GetPhysicsShape", Bind_GetPhysicsShape);
            cls.AddMethod(false, "OverridePhysicsShape", Bind_OverridePhysicsShape);
            cls.AddMethod(false, "OverrideGeometry", Bind_OverrideGeometry);
            cls.AddMethod(false, "GetBones", Bind_GetBones);
            cls.AddMethod(false, "SetBones", Bind_SetBones);
            cls.AddMethod(false, "HasVertexAttribute", Bind_HasVertexAttribute);
            cls.AddMethod(false, "SetVertexCount", Bind_SetVertexCount);
            cls.AddMethod(false, "GetVertexCount", Bind_GetVertexCount);
            cls.AddMethod(true, "Create", BindStatic_Create);
            cls.AddProperty(false, "bounds", BindRead_bounds, null);
            cls.AddProperty(false, "rect", BindRead_rect, null);
            cls.AddProperty(false, "border", BindRead_border, null);
            cls.AddProperty(false, "texture", BindRead_texture, null);
            cls.AddProperty(false, "pixelsPerUnit", BindRead_pixelsPerUnit, null);
            cls.AddProperty(false, "spriteAtlasTextureScale", BindRead_spriteAtlasTextureScale, null);
            cls.AddProperty(false, "associatedAlphaSplitTexture", BindRead_associatedAlphaSplitTexture, null);
            cls.AddProperty(false, "pivot", BindRead_pivot, null);
            cls.AddProperty(false, "packed", BindRead_packed, null);
            cls.AddProperty(false, "packingMode", BindRead_packingMode, null);
            cls.AddProperty(false, "packingRotation", BindRead_packingRotation, null);
            cls.AddProperty(false, "textureRect", BindRead_textureRect, null);
            cls.AddProperty(false, "textureRectOffset", BindRead_textureRectOffset, null);
            cls.AddProperty(false, "vertices", BindRead_vertices, null);
            cls.AddProperty(false, "triangles", BindRead_triangles, null);
            cls.AddProperty(false, "uv", BindRead_uv, null);
            return cls;
        }
    }
}
#endif
