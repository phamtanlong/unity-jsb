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
    // Type: UnityEditor.GlobalObjectId
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_GlobalObjectId
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                var o = new UnityEditor.GlobalObjectId();
                var val = Values.NewBridgeClassObject(ctx, new_target, o, magic, false);
                return val;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue Bind_ToString(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.GlobalObjectId self;
                    if (!Values.js_get_structvalue(ctx, this_obj, out self))
                    {
                        throw new ThisBoundException();
                    }
                    var ret = self.ToString();
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("toString", argc);
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
                do
                {
                    if (argc == 1)
                    {
                        if (Values.js_match_type(ctx, argv[0], typeof(UnityEditor.GlobalObjectId)))
                        {
                            UnityEditor.GlobalObjectId self;
                            if (!Values.js_get_structvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            UnityEditor.GlobalObjectId arg0;
                            if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(UnityEditor.GlobalObjectId), "Equals", typeof(UnityEditor.GlobalObjectId), 0);
                            }
                            var ret = self.Equals(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                        if (Values.js_match_type(ctx, argv[0], typeof(object)))
                        {
                            System.ValueType self;
                            if (!Values.js_get_classvalue(ctx, this_obj, out self))
                            {
                                throw new ThisBoundException();
                            }
                            object arg0;
                            if (!Values.js_get_var(ctx, argv[0], out arg0))
                            {
                                throw new ParameterException(typeof(System.ValueType), "Equals", typeof(object), 0);
                            }
                            var ret = self.Equals(arg0);
                            return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                        }
                    }
                } while(false);
                throw new NoSuitableMethodException("Equals", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetGlobalObjectIdSlow(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.Object arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.GlobalObjectId), "GetGlobalObjectIdSlow", typeof(UnityEngine.Object), 0);
                    }
                    var ret = UnityEditor.GlobalObjectId.GetGlobalObjectIdSlow(arg0);
                    return Values.js_push_structvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetGlobalObjectIdSlow", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetGlobalObjectIdsSlow(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Object[] arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.GlobalObjectId), "GetGlobalObjectIdsSlow", typeof(UnityEngine.Object[]), 0);
                    }
                    UnityEditor.GlobalObjectId[] arg1;
                    if (!Values.js_get_structvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.GlobalObjectId), "GetGlobalObjectIdsSlow", typeof(UnityEditor.GlobalObjectId[]), 1);
                    }
                    UnityEditor.GlobalObjectId.GetGlobalObjectIdsSlow(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("GetGlobalObjectIdsSlow", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_TryParse(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.GlobalObjectId), "TryParse", typeof(string), 0);
                    }
                    UnityEditor.GlobalObjectId arg1;
                    var ret = UnityEditor.GlobalObjectId.TryParse(arg0, out arg1);
                    var out0 = Values.js_push_structvalue(ctx, arg1);
                    if (JSApi.JS_IsException(out0))
                    {
                        return out0;
                    }
                    var context = ScriptEngine.GetContext(ctx);
                    JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), out0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("TryParse", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GlobalObjectIdentifierToObjectSlow(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEditor.GlobalObjectId arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.GlobalObjectId), "GlobalObjectIdentifierToObjectSlow", typeof(UnityEditor.GlobalObjectId), 0);
                    }
                    var ret = UnityEditor.GlobalObjectId.GlobalObjectIdentifierToObjectSlow(arg0);
                    return QuickJS.Binding.Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GlobalObjectIdentifierToObjectSlow", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GlobalObjectIdentifiersToObjectsSlow(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEditor.GlobalObjectId[] arg0;
                    if (!Values.js_get_structvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.GlobalObjectId), "GlobalObjectIdentifiersToObjectsSlow", typeof(UnityEditor.GlobalObjectId[]), 0);
                    }
                    UnityEngine.Object[] arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.GlobalObjectId), "GlobalObjectIdentifiersToObjectsSlow", typeof(UnityEngine.Object[]), 1);
                    }
                    UnityEditor.GlobalObjectId.GlobalObjectIdentifiersToObjectsSlow(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("GlobalObjectIdentifiersToObjectsSlow", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_targetObjectId(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.GlobalObjectId self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.targetObjectId;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_targetPrefabId(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.GlobalObjectId self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.targetPrefabId;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_assetGUID(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.GlobalObjectId self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.assetGUID;
                return Values.js_push_structvalue(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindRead_identifierType(JSContext ctx, JSValue this_obj)
        {
            try
            {
                UnityEditor.GlobalObjectId self;
                if (!Values.js_get_structvalue(ctx, this_obj, out self))
                {
                    throw new ThisBoundException();
                }
                var ret = self.identifierType;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("GlobalObjectId", typeof(UnityEditor.GlobalObjectId), BindConstructor);
            cls.AddMethod(false, "toString", Bind_ToString);
            cls.AddMethod(false, "Equals", Bind_Equals);
            cls.AddMethod(true, "GetGlobalObjectIdSlow", BindStatic_GetGlobalObjectIdSlow);
            cls.AddMethod(true, "GetGlobalObjectIdsSlow", BindStatic_GetGlobalObjectIdsSlow);
            cls.AddMethod(true, "TryParse", BindStatic_TryParse);
            cls.AddMethod(true, "GlobalObjectIdentifierToObjectSlow", BindStatic_GlobalObjectIdentifierToObjectSlow);
            cls.AddMethod(true, "GlobalObjectIdentifiersToObjectsSlow", BindStatic_GlobalObjectIdentifiersToObjectsSlow);
            cls.AddProperty(false, "targetObjectId", BindRead_targetObjectId, null);
            cls.AddProperty(false, "targetPrefabId", BindRead_targetPrefabId, null);
            cls.AddProperty(false, "assetGUID", BindRead_assetGUID, null);
            cls.AddProperty(false, "identifierType", BindRead_identifierType, null);
            return cls;
        }
    }
}
#endif
#endif
