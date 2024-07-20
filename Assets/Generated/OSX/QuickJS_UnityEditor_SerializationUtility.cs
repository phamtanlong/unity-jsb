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
    // Type: UnityEditor.SerializationUtility
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_SerializationUtility
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new UnityEditor.SerializationUtility();
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
        public static JSValue BindStatic_SetManagedReferenceIdForObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 3)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SerializationUtility), "SetManagedReferenceIdForObject", typeof(UnityEngine.Object), 0);
                    }
                    object arg1;
                    if (!Values.js_get_var(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.SerializationUtility), "SetManagedReferenceIdForObject", typeof(object), 1);
                    }
                    long arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.SerializationUtility), "SetManagedReferenceIdForObject", typeof(long), 2);
                    }
                    var ret = UnityEditor.SerializationUtility.SetManagedReferenceIdForObject(arg0, arg1, arg2);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("SetManagedReferenceIdForObject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetManagedReferenceIdForObject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SerializationUtility), "GetManagedReferenceIdForObject", typeof(UnityEngine.Object), 0);
                    }
                    object arg1;
                    if (!Values.js_get_var(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.SerializationUtility), "GetManagedReferenceIdForObject", typeof(object), 1);
                    }
                    var ret = UnityEditor.SerializationUtility.GetManagedReferenceIdForObject(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetManagedReferenceIdForObject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetManagedReference(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SerializationUtility), "GetManagedReference", typeof(UnityEngine.Object), 0);
                    }
                    long arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.SerializationUtility), "GetManagedReference", typeof(long), 1);
                    }
                    var ret = UnityEditor.SerializationUtility.GetManagedReference(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_object(ctx, ret);
                }
                throw new NoSuitableMethodException("GetManagedReference", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetManagedReferenceIds(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SerializationUtility), "GetManagedReferenceIds", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.SerializationUtility.GetManagedReferenceIds(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetManagedReferenceIds", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_HasManagedReferencesWithMissingTypes(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SerializationUtility), "HasManagedReferencesWithMissingTypes", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.SerializationUtility.HasManagedReferencesWithMissingTypes(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("HasManagedReferencesWithMissingTypes", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetManagedReferencesWithMissingTypes(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SerializationUtility), "GetManagedReferencesWithMissingTypes", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.SerializationUtility.GetManagedReferencesWithMissingTypes(arg0);
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetManagedReferencesWithMissingTypes", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ClearAllManagedReferencesWithMissingTypes(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SerializationUtility), "ClearAllManagedReferencesWithMissingTypes", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.SerializationUtility.ClearAllManagedReferencesWithMissingTypes(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ClearAllManagedReferencesWithMissingTypes", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ClearManagedReferenceWithMissingType(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.SerializationUtility), "ClearManagedReferenceWithMissingType", typeof(UnityEngine.Object), 0);
                    }
                    long arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.SerializationUtility), "ClearManagedReferenceWithMissingType", typeof(long), 1);
                    }
                    var ret = UnityEditor.SerializationUtility.ClearManagedReferenceWithMissingType(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ClearManagedReferenceWithMissingType", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_RefIdUnknown(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.SerializationUtility.RefIdUnknown;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_RefIdNull(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.SerializationUtility.RefIdNull;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("SerializationUtility", typeof(UnityEditor.SerializationUtility), BindConstructor);
            cls.AddMethod(true, "SetManagedReferenceIdForObject", BindStatic_SetManagedReferenceIdForObject);
            cls.AddMethod(true, "GetManagedReferenceIdForObject", BindStatic_GetManagedReferenceIdForObject);
            cls.AddMethod(true, "GetManagedReference", BindStatic_GetManagedReference);
            cls.AddMethod(true, "GetManagedReferenceIds", BindStatic_GetManagedReferenceIds);
            cls.AddMethod(true, "HasManagedReferencesWithMissingTypes", BindStatic_HasManagedReferencesWithMissingTypes);
            cls.AddMethod(true, "GetManagedReferencesWithMissingTypes", BindStatic_GetManagedReferencesWithMissingTypes);
            cls.AddMethod(true, "ClearAllManagedReferencesWithMissingTypes", BindStatic_ClearAllManagedReferencesWithMissingTypes);
            cls.AddMethod(true, "ClearManagedReferenceWithMissingType", BindStatic_ClearManagedReferenceWithMissingType);
            cls.AddField(true, "RefIdUnknown", BindStaticRead_RefIdUnknown, null);
            cls.AddField(true, "RefIdNull", BindStaticRead_RefIdNull, null);
            return cls;
        }
    }
}
#endif
#endif
