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
    // Type: UnityEditor.ActiveEditorTracker
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_ActiveEditorTracker
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new UnityEditor.ActiveEditorTracker();
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
        public static JSValue Bind_Equals(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.ActiveEditorTracker self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    object arg0;
                    if (!Values.js_get_var(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ActiveEditorTracker), "Equals", typeof(object), 0);
                    }
                    var ret = self.Equals(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("Equals", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetHashCode(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.ActiveEditorTracker self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.GetHashCode();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetHashCode", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Destroy(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.ActiveEditorTracker self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.Destroy();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Destroy", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_GetVisible(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.ActiveEditorTracker self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ActiveEditorTracker), "GetVisible", typeof(int), 0);
                    }
                    var ret = self.GetVisible(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetVisible", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetVisible(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.ActiveEditorTracker self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ActiveEditorTracker), "SetVisible", typeof(int), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.ActiveEditorTracker), "SetVisible", typeof(int), 1);
                    }
                    self.SetVisible(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetVisible", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ClearDirty(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.ActiveEditorTracker self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.ClearDirty();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ClearDirty", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_RebuildIfNecessary(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.ActiveEditorTracker self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.RebuildIfNecessary();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RebuildIfNecessary", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ForceRebuild(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.ActiveEditorTracker self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.ForceRebuild();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ForceRebuild", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_VerifyModifiedMonoBehaviours(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.ActiveEditorTracker self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.VerifyModifiedMonoBehaviours();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("VerifyModifiedMonoBehaviours", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_HasCustomEditor(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.ActiveEditorTracker), "HasCustomEditor", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.ActiveEditorTracker.HasCustomEditor(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("HasCustomEditor", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_activeEditors(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.ActiveEditorTracker self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.activeEditors;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_isDirty(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.ActiveEditorTracker self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.isDirty;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_isLocked(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.ActiveEditorTracker self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.isLocked;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_isLocked(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.ActiveEditorTracker self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.ActiveEditorTracker), "isLocked", typeof(bool), 0);
                }
                self.isLocked = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_inspectorMode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.ActiveEditorTracker self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.inspectorMode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_inspectorMode(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.ActiveEditorTracker self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                UnityEditor.InspectorMode value;
                if (!Values.js_get_enumvalue(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.ActiveEditorTracker), "inspectorMode", typeof(UnityEditor.InspectorMode), 0);
                }
                self.inspectorMode = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_hasComponentsWhichCannotBeMultiEdited(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.ActiveEditorTracker self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.hasComponentsWhichCannotBeMultiEdited;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_sharedTracker(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.ActiveEditorTracker.sharedTracker;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("ActiveEditorTracker", typeof(UnityEditor.ActiveEditorTracker), BindConstructor);
            cls.AddMethod(false, "Equals", Bind_Equals);
            cls.AddMethod(false, "GetHashCode", Bind_GetHashCode);
            cls.AddMethod(false, "Destroy", Bind_Destroy);
            cls.AddMethod(false, "GetVisible", Bind_GetVisible);
            cls.AddMethod(false, "SetVisible", Bind_SetVisible);
            cls.AddMethod(false, "ClearDirty", Bind_ClearDirty);
            cls.AddMethod(false, "RebuildIfNecessary", Bind_RebuildIfNecessary);
            cls.AddMethod(false, "ForceRebuild", Bind_ForceRebuild);
            cls.AddMethod(false, "VerifyModifiedMonoBehaviours", Bind_VerifyModifiedMonoBehaviours);
            cls.AddMethod(true, "HasCustomEditor", BindStatic_HasCustomEditor);
            cls.AddProperty(false, "activeEditors", BindRead_activeEditors, null);
            cls.AddProperty(false, "isDirty", BindRead_isDirty, null);
            cls.AddProperty(false, "isLocked", BindRead_isLocked, BindWrite_isLocked);
            cls.AddProperty(false, "inspectorMode", BindRead_inspectorMode, BindWrite_inspectorMode);
            cls.AddProperty(false, "hasComponentsWhichCannotBeMultiEdited", BindRead_hasComponentsWhichCannotBeMultiEdited, null);
            cls.AddProperty(true, "sharedTracker", BindStaticRead_sharedTracker, null);
            return cls;
        }
    }
}
#endif
#endif
