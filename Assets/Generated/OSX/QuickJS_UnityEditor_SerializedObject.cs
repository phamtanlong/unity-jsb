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
    // Type: UnityEditor.SerializedObject
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_SerializedObject
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
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Object)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.SerializedObject), ".ctor", typeof(UnityEngine.Object), 0);
                            }
                            UnityEngine.Object arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.SerializedObject), ".ctor", typeof(UnityEngine.Object), 1);
                            }
                            var o = new UnityEditor.SerializedObject(arg0, arg1);
                            var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                            return val;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object[])) && Values.js_match_type(ctx, argv[1], typeof(UnityEngine.Object)))
                        {
                            UnityEngine.Object[] arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.SerializedObject), ".ctor", typeof(UnityEngine.Object[]), 0);
                            }
                            UnityEngine.Object arg1;
                            if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                            {
                                throw new ParameterException(typeof(UnityEditor.SerializedObject), ".ctor", typeof(UnityEngine.Object), 1);
                            }
                            var o = new UnityEditor.SerializedObject(arg0, arg1);
                            var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                            return val;
                        }
                    }
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object)))
                        {
                            UnityEngine.Object arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.SerializedObject), ".ctor", typeof(UnityEngine.Object), 0);
                            }
                            var o = new UnityEditor.SerializedObject(arg0);
                            var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                            return val;
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEngine.Object[])))
                        {
                            UnityEngine.Object[] arg0;
                            if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.SerializedObject), ".ctor", typeof(UnityEngine.Object[]), 0);
                            }
                            var o = new UnityEditor.SerializedObject(arg0);
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
                    UnityEditor.SerializedObject self;
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
        public static JSValue Bind_GetIterator(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.SerializedObject self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.GetIterator();
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetIterator", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_FindProperty(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.SerializedObject self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SerializedObject), "FindProperty", typeof(string), 0);
                    }
                    var ret = self.FindProperty(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("FindProperty", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ApplyModifiedProperties(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.SerializedObject self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.ApplyModifiedProperties();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ApplyModifiedProperties", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_SetIsDifferentCacheDirty(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.SerializedObject self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.SetIsDifferentCacheDirty();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetIsDifferentCacheDirty", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_Update(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.SerializedObject self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    self.Update();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Update", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_UpdateIfRequiredOrScript(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.SerializedObject self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.UpdateIfRequiredOrScript();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("UpdateIfRequiredOrScript", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ApplyModifiedPropertiesWithoutUndo(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.SerializedObject self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.ApplyModifiedPropertiesWithoutUndo();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ApplyModifiedPropertiesWithoutUndo", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_CopyFromSerializedProperty(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.SerializedObject self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEditor.SerializedProperty arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SerializedObject), "CopyFromSerializedProperty", typeof(UnityEditor.SerializedProperty), 0);
                    }
                    self.CopyFromSerializedProperty(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("CopyFromSerializedProperty", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_CopyFromSerializedPropertyIfDifferent(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.SerializedObject self;
                    if (!Values.js_get_classvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    UnityEditor.SerializedProperty arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SerializedObject), "CopyFromSerializedPropertyIfDifferent", typeof(UnityEditor.SerializedProperty), 0);
                    }
                    var ret = self.CopyFromSerializedPropertyIfDifferent(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("CopyFromSerializedPropertyIfDifferent", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_targetObject(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.SerializedObject self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.targetObject;
                return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_targetObjects(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.SerializedObject self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.targetObjects;
                return Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_context(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.SerializedObject self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.context;
                return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_hasModifiedProperties(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.SerializedObject self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.hasModifiedProperties;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_isEditingMultipleObjects(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.SerializedObject self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.isEditingMultipleObjects;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_maxArraySizeForMultiEditing(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.SerializedObject self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.maxArraySizeForMultiEditing;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindWrite_maxArraySizeForMultiEditing(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                UnityEditor.SerializedObject self;
                if (!Values.js_get_classvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                int value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.SerializedObject), "maxArraySizeForMultiEditing", typeof(int), 0);
                }
                self.maxArraySizeForMultiEditing = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("SerializedObject", typeof(UnityEditor.SerializedObject), BindConstructor);
            cls.AddMethod(false, "Dispose", Bind_Dispose);
            cls.AddMethod(false, "GetIterator", Bind_GetIterator);
            cls.AddMethod(false, "FindProperty", Bind_FindProperty);
            cls.AddMethod(false, "ApplyModifiedProperties", Bind_ApplyModifiedProperties);
            cls.AddMethod(false, "SetIsDifferentCacheDirty", Bind_SetIsDifferentCacheDirty);
            cls.AddMethod(false, "Update", Bind_Update);
            cls.AddMethod(false, "UpdateIfRequiredOrScript", Bind_UpdateIfRequiredOrScript);
            cls.AddMethod(false, "ApplyModifiedPropertiesWithoutUndo", Bind_ApplyModifiedPropertiesWithoutUndo);
            cls.AddMethod(false, "CopyFromSerializedProperty", Bind_CopyFromSerializedProperty);
            cls.AddMethod(false, "CopyFromSerializedPropertyIfDifferent", Bind_CopyFromSerializedPropertyIfDifferent);
            cls.AddProperty(false, "targetObject", BindRead_targetObject, null);
            cls.AddProperty(false, "targetObjects", BindRead_targetObjects, null);
            cls.AddProperty(false, "context", BindRead_context, null);
            cls.AddProperty(false, "hasModifiedProperties", BindRead_hasModifiedProperties, null);
            cls.AddProperty(false, "isEditingMultipleObjects", BindRead_isEditingMultipleObjects, null);
            cls.AddProperty(false, "maxArraySizeForMultiEditing", BindRead_maxArraySizeForMultiEditing, BindWrite_maxArraySizeForMultiEditing);
            return cls;
        }
    }
}
#endif
#endif
