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
    // Type: UnityEditor.PhysicsVisualizationSettings
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_PhysicsVisualizationSettings
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Reset(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.PhysicsVisualizationSettings.Reset();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Reset", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetShowStaticColliders(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.PhysicsVisualizationSettings.GetShowStaticColliders();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetShowStaticColliders", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetShowStaticColliders(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    bool arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "SetShowStaticColliders", typeof(bool), 0);
                    }
                    UnityEditor.PhysicsVisualizationSettings.SetShowStaticColliders(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetShowStaticColliders", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetShowTriggers(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.PhysicsVisualizationSettings.GetShowTriggers();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetShowTriggers", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetShowTriggers(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    bool arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "SetShowTriggers", typeof(bool), 0);
                    }
                    UnityEditor.PhysicsVisualizationSettings.SetShowTriggers(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetShowTriggers", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetShowRigidbodies(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.PhysicsVisualizationSettings.GetShowRigidbodies();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetShowRigidbodies", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetShowRigidbodies(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    bool arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "SetShowRigidbodies", typeof(bool), 0);
                    }
                    UnityEditor.PhysicsVisualizationSettings.SetShowRigidbodies(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetShowRigidbodies", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetShowKinematicBodies(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.PhysicsVisualizationSettings.GetShowKinematicBodies();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetShowKinematicBodies", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetShowKinematicBodies(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    bool arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "SetShowKinematicBodies", typeof(bool), 0);
                    }
                    UnityEditor.PhysicsVisualizationSettings.SetShowKinematicBodies(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetShowKinematicBodies", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetShowSleepingBodies(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.PhysicsVisualizationSettings.GetShowSleepingBodies();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetShowSleepingBodies", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetShowSleepingBodies(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    bool arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "SetShowSleepingBodies", typeof(bool), 0);
                    }
                    UnityEditor.PhysicsVisualizationSettings.SetShowSleepingBodies(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetShowSleepingBodies", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetShowCollisionLayer(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "GetShowCollisionLayer", typeof(int), 0);
                    }
                    var ret = UnityEditor.PhysicsVisualizationSettings.GetShowCollisionLayer(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetShowCollisionLayer", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetShowCollisionLayer(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "SetShowCollisionLayer", typeof(int), 0);
                    }
                    bool arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "SetShowCollisionLayer", typeof(bool), 1);
                    }
                    UnityEditor.PhysicsVisualizationSettings.SetShowCollisionLayer(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetShowCollisionLayer", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetShowCollisionLayerMask(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.PhysicsVisualizationSettings.GetShowCollisionLayerMask();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetShowCollisionLayerMask", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetShowCollisionLayerMask(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "SetShowCollisionLayerMask", typeof(int), 0);
                    }
                    UnityEditor.PhysicsVisualizationSettings.SetShowCollisionLayerMask(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetShowCollisionLayerMask", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetShowBoxColliders(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.PhysicsVisualizationSettings.GetShowBoxColliders();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetShowBoxColliders", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetShowBoxColliders(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    bool arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "SetShowBoxColliders", typeof(bool), 0);
                    }
                    UnityEditor.PhysicsVisualizationSettings.SetShowBoxColliders(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetShowBoxColliders", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetShowSphereColliders(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.PhysicsVisualizationSettings.GetShowSphereColliders();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetShowSphereColliders", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetShowSphereColliders(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    bool arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "SetShowSphereColliders", typeof(bool), 0);
                    }
                    UnityEditor.PhysicsVisualizationSettings.SetShowSphereColliders(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetShowSphereColliders", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetShowCapsuleColliders(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.PhysicsVisualizationSettings.GetShowCapsuleColliders();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetShowCapsuleColliders", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetShowCapsuleColliders(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    bool arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "SetShowCapsuleColliders", typeof(bool), 0);
                    }
                    UnityEditor.PhysicsVisualizationSettings.SetShowCapsuleColliders(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetShowCapsuleColliders", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetShowMeshColliders(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.PhysicsVisualizationSettings.MeshColliderType arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "GetShowMeshColliders", typeof(UnityEditor.PhysicsVisualizationSettings.MeshColliderType), 0);
                    }
                    var ret = UnityEditor.PhysicsVisualizationSettings.GetShowMeshColliders(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetShowMeshColliders", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetShowMeshColliders(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.PhysicsVisualizationSettings.MeshColliderType arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "SetShowMeshColliders", typeof(UnityEditor.PhysicsVisualizationSettings.MeshColliderType), 0);
                    }
                    bool arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "SetShowMeshColliders", typeof(bool), 1);
                    }
                    UnityEditor.PhysicsVisualizationSettings.SetShowMeshColliders(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetShowMeshColliders", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetShowTerrainColliders(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.PhysicsVisualizationSettings.GetShowTerrainColliders();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetShowTerrainColliders", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetShowTerrainColliders(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    bool arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "SetShowTerrainColliders", typeof(bool), 0);
                    }
                    UnityEditor.PhysicsVisualizationSettings.SetShowTerrainColliders(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetShowTerrainColliders", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetShowPhysicsSceneMask(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.PhysicsVisualizationSettings.GetShowPhysicsSceneMask();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetShowPhysicsSceneMask", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetShowPhysicsSceneMask(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "SetShowPhysicsSceneMask", typeof(int), 0);
                    }
                    UnityEditor.PhysicsVisualizationSettings.SetShowPhysicsSceneMask(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetShowPhysicsSceneMask", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_InitDebugDraw(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.PhysicsVisualizationSettings.InitDebugDraw();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("InitDebugDraw", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DeinitDebugDraw(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.PhysicsVisualizationSettings.DeinitDebugDraw();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DeinitDebugDraw", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ClearMouseHighlight(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.PhysicsVisualizationSettings.ClearMouseHighlight();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ClearMouseHighlight", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_HasMouseHighlight(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.PhysicsVisualizationSettings.HasMouseHighlight();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("HasMouseHighlight", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_UpdateMouseHighlight(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Vector2 arg0;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "UpdateMouseHighlight", typeof(UnityEngine.Vector2), 0);
                    }
                    UnityEditor.PhysicsVisualizationSettings.UpdateMouseHighlight(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("UpdateMouseHighlight", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_PickClosestGameObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 6)
                {
                    UnityEngine.Camera arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "PickClosestGameObject", typeof(UnityEngine.Camera), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "PickClosestGameObject", typeof(int), 1);
                    }
                    UnityEngine.Vector2 arg2;
                    if (!QuickJS.Binding.Values.js_get_structvalue(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "PickClosestGameObject", typeof(UnityEngine.Vector2), 2);
                    }
                    UnityEngine.GameObject[] arg3;
                    if (!Values.js_get_classvalue(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "PickClosestGameObject", typeof(UnityEngine.GameObject[]), 3);
                    }
                    UnityEngine.GameObject[] arg4;
                    if (!Values.js_get_classvalue(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "PickClosestGameObject", typeof(UnityEngine.GameObject[]), 4);
                    }
                    int arg5;
                    var ret = UnityEditor.PhysicsVisualizationSettings.PickClosestGameObject(arg0, arg1, arg2, arg3, arg4, out arg5);
                    var out0 = QuickJS.Binding.Values.js_push_primitive(ctx, arg5);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[5], context.GetAtom("value"), out0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("PickClosestGameObject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetShowForAllFilters(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    bool arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "SetShowForAllFilters", typeof(bool), 0);
                    }
                    UnityEditor.PhysicsVisualizationSettings.SetShowForAllFilters(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetShowForAllFilters", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_devOptions(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PhysicsVisualizationSettings.devOptions;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_devOptions(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "devOptions", typeof(bool), 0);
                }
                UnityEditor.PhysicsVisualizationSettings.devOptions = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_dirtyCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PhysicsVisualizationSettings.dirtyCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_showCollisionGeometry(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PhysicsVisualizationSettings.showCollisionGeometry;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_showCollisionGeometry(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "showCollisionGeometry", typeof(bool), 0);
                }
                UnityEditor.PhysicsVisualizationSettings.showCollisionGeometry = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_enableMouseSelect(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PhysicsVisualizationSettings.enableMouseSelect;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_enableMouseSelect(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "enableMouseSelect", typeof(bool), 0);
                }
                UnityEditor.PhysicsVisualizationSettings.enableMouseSelect = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_useSceneCam(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PhysicsVisualizationSettings.useSceneCam;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_useSceneCam(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "useSceneCam", typeof(bool), 0);
                }
                UnityEditor.PhysicsVisualizationSettings.useSceneCam = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_viewDistance(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PhysicsVisualizationSettings.viewDistance;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_viewDistance(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "viewDistance", typeof(float), 0);
                }
                UnityEditor.PhysicsVisualizationSettings.viewDistance = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_terrainTilesMax(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PhysicsVisualizationSettings.terrainTilesMax;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_terrainTilesMax(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "terrainTilesMax", typeof(int), 0);
                }
                UnityEditor.PhysicsVisualizationSettings.terrainTilesMax = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_forceOverdraw(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PhysicsVisualizationSettings.forceOverdraw;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_forceOverdraw(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "forceOverdraw", typeof(bool), 0);
                }
                UnityEditor.PhysicsVisualizationSettings.forceOverdraw = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_staticColor(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PhysicsVisualizationSettings.staticColor;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_staticColor(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Color value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "staticColor", typeof(UnityEngine.Color), 0);
                }
                UnityEditor.PhysicsVisualizationSettings.staticColor = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_rigidbodyColor(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PhysicsVisualizationSettings.rigidbodyColor;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_rigidbodyColor(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Color value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "rigidbodyColor", typeof(UnityEngine.Color), 0);
                }
                UnityEditor.PhysicsVisualizationSettings.rigidbodyColor = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_kinematicColor(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PhysicsVisualizationSettings.kinematicColor;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_kinematicColor(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Color value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "kinematicColor", typeof(UnityEngine.Color), 0);
                }
                UnityEditor.PhysicsVisualizationSettings.kinematicColor = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_triggerColor(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PhysicsVisualizationSettings.triggerColor;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_triggerColor(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Color value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "triggerColor", typeof(UnityEngine.Color), 0);
                }
                UnityEditor.PhysicsVisualizationSettings.triggerColor = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_sleepingBodyColor(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PhysicsVisualizationSettings.sleepingBodyColor;
                return QuickJS.Binding.Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_sleepingBodyColor(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEngine.Color value;
                if (!QuickJS.Binding.Values.js_get_structvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "sleepingBodyColor", typeof(UnityEngine.Color), 0);
                }
                UnityEditor.PhysicsVisualizationSettings.sleepingBodyColor = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_baseAlpha(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PhysicsVisualizationSettings.baseAlpha;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_baseAlpha(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "baseAlpha", typeof(float), 0);
                }
                UnityEditor.PhysicsVisualizationSettings.baseAlpha = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_colorVariance(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PhysicsVisualizationSettings.colorVariance;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_colorVariance(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "colorVariance", typeof(float), 0);
                }
                UnityEditor.PhysicsVisualizationSettings.colorVariance = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_dotAlpha(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PhysicsVisualizationSettings.dotAlpha;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_dotAlpha(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                float value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "dotAlpha", typeof(float), 0);
                }
                UnityEditor.PhysicsVisualizationSettings.dotAlpha = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_forceDot(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.PhysicsVisualizationSettings.forceDot;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_forceDot(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.PhysicsVisualizationSettings), "forceDot", typeof(bool), 0);
                }
                UnityEditor.PhysicsVisualizationSettings.forceDot = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("PhysicsVisualizationSettings", typeof(UnityEditor.PhysicsVisualizationSettings), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "Reset", BindStatic_Reset);
            cls.AddMethod(true, "GetShowStaticColliders", BindStatic_GetShowStaticColliders);
            cls.AddMethod(true, "SetShowStaticColliders", BindStatic_SetShowStaticColliders);
            cls.AddMethod(true, "GetShowTriggers", BindStatic_GetShowTriggers);
            cls.AddMethod(true, "SetShowTriggers", BindStatic_SetShowTriggers);
            cls.AddMethod(true, "GetShowRigidbodies", BindStatic_GetShowRigidbodies);
            cls.AddMethod(true, "SetShowRigidbodies", BindStatic_SetShowRigidbodies);
            cls.AddMethod(true, "GetShowKinematicBodies", BindStatic_GetShowKinematicBodies);
            cls.AddMethod(true, "SetShowKinematicBodies", BindStatic_SetShowKinematicBodies);
            cls.AddMethod(true, "GetShowSleepingBodies", BindStatic_GetShowSleepingBodies);
            cls.AddMethod(true, "SetShowSleepingBodies", BindStatic_SetShowSleepingBodies);
            cls.AddMethod(true, "GetShowCollisionLayer", BindStatic_GetShowCollisionLayer);
            cls.AddMethod(true, "SetShowCollisionLayer", BindStatic_SetShowCollisionLayer);
            cls.AddMethod(true, "GetShowCollisionLayerMask", BindStatic_GetShowCollisionLayerMask);
            cls.AddMethod(true, "SetShowCollisionLayerMask", BindStatic_SetShowCollisionLayerMask);
            cls.AddMethod(true, "GetShowBoxColliders", BindStatic_GetShowBoxColliders);
            cls.AddMethod(true, "SetShowBoxColliders", BindStatic_SetShowBoxColliders);
            cls.AddMethod(true, "GetShowSphereColliders", BindStatic_GetShowSphereColliders);
            cls.AddMethod(true, "SetShowSphereColliders", BindStatic_SetShowSphereColliders);
            cls.AddMethod(true, "GetShowCapsuleColliders", BindStatic_GetShowCapsuleColliders);
            cls.AddMethod(true, "SetShowCapsuleColliders", BindStatic_SetShowCapsuleColliders);
            cls.AddMethod(true, "GetShowMeshColliders", BindStatic_GetShowMeshColliders);
            cls.AddMethod(true, "SetShowMeshColliders", BindStatic_SetShowMeshColliders);
            cls.AddMethod(true, "GetShowTerrainColliders", BindStatic_GetShowTerrainColliders);
            cls.AddMethod(true, "SetShowTerrainColliders", BindStatic_SetShowTerrainColliders);
            cls.AddMethod(true, "GetShowPhysicsSceneMask", BindStatic_GetShowPhysicsSceneMask);
            cls.AddMethod(true, "SetShowPhysicsSceneMask", BindStatic_SetShowPhysicsSceneMask);
            cls.AddMethod(true, "InitDebugDraw", BindStatic_InitDebugDraw);
            cls.AddMethod(true, "DeinitDebugDraw", BindStatic_DeinitDebugDraw);
            cls.AddMethod(true, "ClearMouseHighlight", BindStatic_ClearMouseHighlight);
            cls.AddMethod(true, "HasMouseHighlight", BindStatic_HasMouseHighlight);
            cls.AddMethod(true, "UpdateMouseHighlight", BindStatic_UpdateMouseHighlight);
            cls.AddMethod(true, "PickClosestGameObject", BindStatic_PickClosestGameObject);
            cls.AddMethod(true, "SetShowForAllFilters", BindStatic_SetShowForAllFilters);
            cls.AddProperty(true, "devOptions", BindStaticRead_devOptions, BindStaticWrite_devOptions);
            cls.AddProperty(true, "dirtyCount", BindStaticRead_dirtyCount, null);
            cls.AddProperty(true, "showCollisionGeometry", BindStaticRead_showCollisionGeometry, BindStaticWrite_showCollisionGeometry);
            cls.AddProperty(true, "enableMouseSelect", BindStaticRead_enableMouseSelect, BindStaticWrite_enableMouseSelect);
            cls.AddProperty(true, "useSceneCam", BindStaticRead_useSceneCam, BindStaticWrite_useSceneCam);
            cls.AddProperty(true, "viewDistance", BindStaticRead_viewDistance, BindStaticWrite_viewDistance);
            cls.AddProperty(true, "terrainTilesMax", BindStaticRead_terrainTilesMax, BindStaticWrite_terrainTilesMax);
            cls.AddProperty(true, "forceOverdraw", BindStaticRead_forceOverdraw, BindStaticWrite_forceOverdraw);
            cls.AddProperty(true, "staticColor", BindStaticRead_staticColor, BindStaticWrite_staticColor);
            cls.AddProperty(true, "rigidbodyColor", BindStaticRead_rigidbodyColor, BindStaticWrite_rigidbodyColor);
            cls.AddProperty(true, "kinematicColor", BindStaticRead_kinematicColor, BindStaticWrite_kinematicColor);
            cls.AddProperty(true, "triggerColor", BindStaticRead_triggerColor, BindStaticWrite_triggerColor);
            cls.AddProperty(true, "sleepingBodyColor", BindStaticRead_sleepingBodyColor, BindStaticWrite_sleepingBodyColor);
            cls.AddProperty(true, "baseAlpha", BindStaticRead_baseAlpha, BindStaticWrite_baseAlpha);
            cls.AddProperty(true, "colorVariance", BindStaticRead_colorVariance, BindStaticWrite_colorVariance);
            cls.AddProperty(true, "dotAlpha", BindStaticRead_dotAlpha, BindStaticWrite_dotAlpha);
            cls.AddProperty(true, "forceDot", BindStaticRead_forceDot, BindStaticWrite_forceDot);
            return cls;
        }
    }
}
#endif
#endif
