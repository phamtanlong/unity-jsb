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
    // Assembly: UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
    // Location: /Applications/Unity/Hub/Editor/2019.4.40f1/Unity.app/Contents/Managed/UnityEngine/UnityEngine.PhysicsModule.dll
    // Type: UnityEngine.RaycastHit
    [JSBindingAttribute]
    public class QuickJS_UnityEngine_RaycastHit
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                var o = new UnityEngine.RaycastHit();
                var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                return val;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_collider(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.RaycastHit self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.collider;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_point(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.RaycastHit self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.point;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_point(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.RaycastHit self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Vector3 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.RaycastHit), "point", typeof(UnityEngine.Vector3), 0);
                }
                self.point = value;
                Values.js_rebind_this(ctx, this_obj, ref self);
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_normal(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.RaycastHit self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.normal;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_normal(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.RaycastHit self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Vector3 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.RaycastHit), "normal", typeof(UnityEngine.Vector3), 0);
                }
                self.normal = value;
                Values.js_rebind_this(ctx, this_obj, ref self);
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_barycentricCoordinate(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.RaycastHit self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.barycentricCoordinate;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_barycentricCoordinate(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.RaycastHit self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEngine.Vector3 value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.RaycastHit), "barycentricCoordinate", typeof(UnityEngine.Vector3), 0);
                }
                self.barycentricCoordinate = value;
                Values.js_rebind_this(ctx, this_obj, ref self);
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_distance(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.RaycastHit self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.distance;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_distance(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.RaycastHit self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEngine.RaycastHit), "distance", typeof(float), 0);
                }
                self.distance = value;
                Values.js_rebind_this(ctx, this_obj, ref self);
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_triangleIndex(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.RaycastHit self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.triangleIndex;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_textureCoord(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.RaycastHit self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.textureCoord;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_textureCoord2(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.RaycastHit self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.textureCoord2;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_transform(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.RaycastHit self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.transform;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_rigidbody(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.RaycastHit self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.rigidbody;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_lightmapCoord(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEngine.RaycastHit self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.lightmapCoord;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("RaycastHit", typeof(UnityEngine.RaycastHit), BindConstructor);
            cls.AddProperty(false, "collider", BindRead_collider, null);
            cls.AddProperty(false, "point", BindRead_point, BindWrite_point);
            cls.AddProperty(false, "normal", BindRead_normal, BindWrite_normal);
            cls.AddProperty(false, "barycentricCoordinate", BindRead_barycentricCoordinate, BindWrite_barycentricCoordinate);
            cls.AddProperty(false, "distance", BindRead_distance, BindWrite_distance);
            cls.AddProperty(false, "triangleIndex", BindRead_triangleIndex, null);
            cls.AddProperty(false, "textureCoord", BindRead_textureCoord, null);
            cls.AddProperty(false, "textureCoord2", BindRead_textureCoord2, null);
            cls.AddProperty(false, "transform", BindRead_transform, null);
            cls.AddProperty(false, "rigidbody", BindRead_rigidbody, null);
            cls.AddProperty(false, "lightmapCoord", BindRead_lightmapCoord, null);
            return cls;
        }
    }
}
#endif
