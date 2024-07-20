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
    // Type: UnityEditor.ObjectChangeEventStream+Builder
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_ObjectChangeEventStream_Builder
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 1)
                {
                    Unity.Collections.Allocator arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ObjectChangeEventStream.Builder), ".ctor", typeof(Unity.Collections.Allocator), 0);
                    }
                    var o = new UnityEditor.ObjectChangeEventStream.Builder(arg0);
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
        public static JSValue Bind_ToStream(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.ObjectChangeEventStream.Builder self;
                    if (!Values.js_get_structvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    Unity.Collections.Allocator arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ObjectChangeEventStream.Builder), "ToStream", typeof(Unity.Collections.Allocator), 0);
                    }
                    var ret = self.ToStream(arg0);
                    return Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("ToStream", argc);
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
                    UnityEditor.ObjectChangeEventStream.Builder self;
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
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_PushChangeSceneEvent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.ObjectChangeEventStream.Builder self;
                    if (!Values.js_get_structvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEditor.ChangeSceneEventArgs arg0;
                    var refVal0 = Values.js_read_wrap(ctx, argv[0]);
                    if (refVal0.IsException())
                    {
                        return refVal0;
                    }
                    if (!Values.js_get_structvalue(ctx, refVal0, out arg0))
                    {
                        JSApi.JS_FreeValue(ctx, refVal0);
                        throw new ParameterException(typeof(UnityEditor.ObjectChangeEventStream.Builder), "PushChangeSceneEvent", typeof(UnityEditor.ChangeSceneEventArgs), 0);
                    }
                    JSApi.JS_FreeValue(ctx, refVal0);
                    self.PushChangeSceneEvent(ref arg0);
                    var out0 = Values.js_push_structvalue(ctx, arg0);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[0], context.GetAtom("value"), out0);
                    Values.js_rebind_this(ctx, this_obj, ref self);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("PushChangeSceneEvent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_PushCreateGameObjectHierarchyEvent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.ObjectChangeEventStream.Builder self;
                    if (!Values.js_get_structvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEditor.CreateGameObjectHierarchyEventArgs arg0;
                    var refVal0 = Values.js_read_wrap(ctx, argv[0]);
                    if (refVal0.IsException())
                    {
                        return refVal0;
                    }
                    if (!Values.js_get_structvalue(ctx, refVal0, out arg0))
                    {
                        JSApi.JS_FreeValue(ctx, refVal0);
                        throw new ParameterException(typeof(UnityEditor.ObjectChangeEventStream.Builder), "PushCreateGameObjectHierarchyEvent", typeof(UnityEditor.CreateGameObjectHierarchyEventArgs), 0);
                    }
                    JSApi.JS_FreeValue(ctx, refVal0);
                    self.PushCreateGameObjectHierarchyEvent(ref arg0);
                    var out0 = Values.js_push_structvalue(ctx, arg0);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[0], context.GetAtom("value"), out0);
                    Values.js_rebind_this(ctx, this_obj, ref self);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("PushCreateGameObjectHierarchyEvent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_PushDestroyGameObjectHierarchyEvent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.ObjectChangeEventStream.Builder self;
                    if (!Values.js_get_structvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEditor.DestroyGameObjectHierarchyEventArgs arg0;
                    var refVal0 = Values.js_read_wrap(ctx, argv[0]);
                    if (refVal0.IsException())
                    {
                        return refVal0;
                    }
                    if (!Values.js_get_structvalue(ctx, refVal0, out arg0))
                    {
                        JSApi.JS_FreeValue(ctx, refVal0);
                        throw new ParameterException(typeof(UnityEditor.ObjectChangeEventStream.Builder), "PushDestroyGameObjectHierarchyEvent", typeof(UnityEditor.DestroyGameObjectHierarchyEventArgs), 0);
                    }
                    JSApi.JS_FreeValue(ctx, refVal0);
                    self.PushDestroyGameObjectHierarchyEvent(ref arg0);
                    var out0 = Values.js_push_structvalue(ctx, arg0);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[0], context.GetAtom("value"), out0);
                    Values.js_rebind_this(ctx, this_obj, ref self);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("PushDestroyGameObjectHierarchyEvent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_PushChangeGameObjectStructureHierarchyEvent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.ObjectChangeEventStream.Builder self;
                    if (!Values.js_get_structvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEditor.ChangeGameObjectStructureHierarchyEventArgs arg0;
                    var refVal0 = Values.js_read_wrap(ctx, argv[0]);
                    if (refVal0.IsException())
                    {
                        return refVal0;
                    }
                    if (!Values.js_get_structvalue(ctx, refVal0, out arg0))
                    {
                        JSApi.JS_FreeValue(ctx, refVal0);
                        throw new ParameterException(typeof(UnityEditor.ObjectChangeEventStream.Builder), "PushChangeGameObjectStructureHierarchyEvent", typeof(UnityEditor.ChangeGameObjectStructureHierarchyEventArgs), 0);
                    }
                    JSApi.JS_FreeValue(ctx, refVal0);
                    self.PushChangeGameObjectStructureHierarchyEvent(ref arg0);
                    var out0 = Values.js_push_structvalue(ctx, arg0);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[0], context.GetAtom("value"), out0);
                    Values.js_rebind_this(ctx, this_obj, ref self);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("PushChangeGameObjectStructureHierarchyEvent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_PushChangeGameObjectStructureEvent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.ObjectChangeEventStream.Builder self;
                    if (!Values.js_get_structvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEditor.ChangeGameObjectStructureEventArgs arg0;
                    var refVal0 = Values.js_read_wrap(ctx, argv[0]);
                    if (refVal0.IsException())
                    {
                        return refVal0;
                    }
                    if (!Values.js_get_structvalue(ctx, refVal0, out arg0))
                    {
                        JSApi.JS_FreeValue(ctx, refVal0);
                        throw new ParameterException(typeof(UnityEditor.ObjectChangeEventStream.Builder), "PushChangeGameObjectStructureEvent", typeof(UnityEditor.ChangeGameObjectStructureEventArgs), 0);
                    }
                    JSApi.JS_FreeValue(ctx, refVal0);
                    self.PushChangeGameObjectStructureEvent(ref arg0);
                    var out0 = Values.js_push_structvalue(ctx, arg0);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[0], context.GetAtom("value"), out0);
                    Values.js_rebind_this(ctx, this_obj, ref self);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("PushChangeGameObjectStructureEvent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_PushChangeGameObjectParentEvent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.ObjectChangeEventStream.Builder self;
                    if (!Values.js_get_structvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEditor.ChangeGameObjectParentEventArgs arg0;
                    var refVal0 = Values.js_read_wrap(ctx, argv[0]);
                    if (refVal0.IsException())
                    {
                        return refVal0;
                    }
                    if (!Values.js_get_structvalue(ctx, refVal0, out arg0))
                    {
                        JSApi.JS_FreeValue(ctx, refVal0);
                        throw new ParameterException(typeof(UnityEditor.ObjectChangeEventStream.Builder), "PushChangeGameObjectParentEvent", typeof(UnityEditor.ChangeGameObjectParentEventArgs), 0);
                    }
                    JSApi.JS_FreeValue(ctx, refVal0);
                    self.PushChangeGameObjectParentEvent(ref arg0);
                    var out0 = Values.js_push_structvalue(ctx, arg0);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[0], context.GetAtom("value"), out0);
                    Values.js_rebind_this(ctx, this_obj, ref self);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("PushChangeGameObjectParentEvent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_PushChangeGameObjectOrComponentPropertiesEvent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.ObjectChangeEventStream.Builder self;
                    if (!Values.js_get_structvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEditor.ChangeGameObjectOrComponentPropertiesEventArgs arg0;
                    var refVal0 = Values.js_read_wrap(ctx, argv[0]);
                    if (refVal0.IsException())
                    {
                        return refVal0;
                    }
                    if (!Values.js_get_structvalue(ctx, refVal0, out arg0))
                    {
                        JSApi.JS_FreeValue(ctx, refVal0);
                        throw new ParameterException(typeof(UnityEditor.ObjectChangeEventStream.Builder), "PushChangeGameObjectOrComponentPropertiesEvent", typeof(UnityEditor.ChangeGameObjectOrComponentPropertiesEventArgs), 0);
                    }
                    JSApi.JS_FreeValue(ctx, refVal0);
                    self.PushChangeGameObjectOrComponentPropertiesEvent(ref arg0);
                    var out0 = Values.js_push_structvalue(ctx, arg0);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[0], context.GetAtom("value"), out0);
                    Values.js_rebind_this(ctx, this_obj, ref self);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("PushChangeGameObjectOrComponentPropertiesEvent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_PushCreateAssetObjectEvent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.ObjectChangeEventStream.Builder self;
                    if (!Values.js_get_structvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEditor.CreateAssetObjectEventArgs arg0;
                    var refVal0 = Values.js_read_wrap(ctx, argv[0]);
                    if (refVal0.IsException())
                    {
                        return refVal0;
                    }
                    if (!Values.js_get_structvalue(ctx, refVal0, out arg0))
                    {
                        JSApi.JS_FreeValue(ctx, refVal0);
                        throw new ParameterException(typeof(UnityEditor.ObjectChangeEventStream.Builder), "PushCreateAssetObjectEvent", typeof(UnityEditor.CreateAssetObjectEventArgs), 0);
                    }
                    JSApi.JS_FreeValue(ctx, refVal0);
                    self.PushCreateAssetObjectEvent(ref arg0);
                    var out0 = Values.js_push_structvalue(ctx, arg0);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[0], context.GetAtom("value"), out0);
                    Values.js_rebind_this(ctx, this_obj, ref self);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("PushCreateAssetObjectEvent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_PushDestroyAssetObjectEvent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.ObjectChangeEventStream.Builder self;
                    if (!Values.js_get_structvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEditor.DestroyAssetObjectEventArgs arg0;
                    var refVal0 = Values.js_read_wrap(ctx, argv[0]);
                    if (refVal0.IsException())
                    {
                        return refVal0;
                    }
                    if (!Values.js_get_structvalue(ctx, refVal0, out arg0))
                    {
                        JSApi.JS_FreeValue(ctx, refVal0);
                        throw new ParameterException(typeof(UnityEditor.ObjectChangeEventStream.Builder), "PushDestroyAssetObjectEvent", typeof(UnityEditor.DestroyAssetObjectEventArgs), 0);
                    }
                    JSApi.JS_FreeValue(ctx, refVal0);
                    self.PushDestroyAssetObjectEvent(ref arg0);
                    var out0 = Values.js_push_structvalue(ctx, arg0);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[0], context.GetAtom("value"), out0);
                    Values.js_rebind_this(ctx, this_obj, ref self);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("PushDestroyAssetObjectEvent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_PushChangeAssetObjectPropertiesEvent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.ObjectChangeEventStream.Builder self;
                    if (!Values.js_get_structvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEditor.ChangeAssetObjectPropertiesEventArgs arg0;
                    var refVal0 = Values.js_read_wrap(ctx, argv[0]);
                    if (refVal0.IsException())
                    {
                        return refVal0;
                    }
                    if (!Values.js_get_structvalue(ctx, refVal0, out arg0))
                    {
                        JSApi.JS_FreeValue(ctx, refVal0);
                        throw new ParameterException(typeof(UnityEditor.ObjectChangeEventStream.Builder), "PushChangeAssetObjectPropertiesEvent", typeof(UnityEditor.ChangeAssetObjectPropertiesEventArgs), 0);
                    }
                    JSApi.JS_FreeValue(ctx, refVal0);
                    self.PushChangeAssetObjectPropertiesEvent(ref arg0);
                    var out0 = Values.js_push_structvalue(ctx, arg0);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[0], context.GetAtom("value"), out0);
                    Values.js_rebind_this(ctx, this_obj, ref self);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("PushChangeAssetObjectPropertiesEvent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_PushUpdatePrefabInstancesEvent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.ObjectChangeEventStream.Builder self;
                    if (!Values.js_get_structvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEditor.UpdatePrefabInstancesEventArgs arg0;
                    var refVal0 = Values.js_read_wrap(ctx, argv[0]);
                    if (refVal0.IsException())
                    {
                        return refVal0;
                    }
                    if (!Values.js_get_structvalue(ctx, refVal0, out arg0))
                    {
                        JSApi.JS_FreeValue(ctx, refVal0);
                        throw new ParameterException(typeof(UnityEditor.ObjectChangeEventStream.Builder), "PushUpdatePrefabInstancesEvent", typeof(UnityEditor.UpdatePrefabInstancesEventArgs), 0);
                    }
                    JSApi.JS_FreeValue(ctx, refVal0);
                    self.PushUpdatePrefabInstancesEvent(ref arg0);
                    var out0 = Values.js_push_structvalue(ctx, arg0);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[0], context.GetAtom("value"), out0);
                    Values.js_rebind_this(ctx, this_obj, ref self);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("PushUpdatePrefabInstancesEvent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_eventCount(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.ObjectChangeEventStream.Builder self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.eventCount;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("Builder", typeof(UnityEditor.ObjectChangeEventStream.Builder), BindConstructor);
            cls.AddMethod(false, "ToStream", Bind_ToStream);
            cls.AddMethod(false, "Dispose", Bind_Dispose);
            cls.AddMethod(false, "PushChangeSceneEvent", Bind_PushChangeSceneEvent);
            cls.AddMethod(false, "PushCreateGameObjectHierarchyEvent", Bind_PushCreateGameObjectHierarchyEvent);
            cls.AddMethod(false, "PushDestroyGameObjectHierarchyEvent", Bind_PushDestroyGameObjectHierarchyEvent);
            cls.AddMethod(false, "PushChangeGameObjectStructureHierarchyEvent", Bind_PushChangeGameObjectStructureHierarchyEvent);
            cls.AddMethod(false, "PushChangeGameObjectStructureEvent", Bind_PushChangeGameObjectStructureEvent);
            cls.AddMethod(false, "PushChangeGameObjectParentEvent", Bind_PushChangeGameObjectParentEvent);
            cls.AddMethod(false, "PushChangeGameObjectOrComponentPropertiesEvent", Bind_PushChangeGameObjectOrComponentPropertiesEvent);
            cls.AddMethod(false, "PushCreateAssetObjectEvent", Bind_PushCreateAssetObjectEvent);
            cls.AddMethod(false, "PushDestroyAssetObjectEvent", Bind_PushDestroyAssetObjectEvent);
            cls.AddMethod(false, "PushChangeAssetObjectPropertiesEvent", Bind_PushChangeAssetObjectPropertiesEvent);
            cls.AddMethod(false, "PushUpdatePrefabInstancesEvent", Bind_PushUpdatePrefabInstancesEvent);
            cls.AddProperty(false, "eventCount", BindRead_eventCount, null);
            return cls;
        }
    }
}
#endif
#endif
