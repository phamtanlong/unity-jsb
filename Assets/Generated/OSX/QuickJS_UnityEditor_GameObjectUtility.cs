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
    // Type: UnityEditor.GameObjectUtility
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_GameObjectUtility
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 0)
                {
                    var o = new UnityEditor.GameObjectUtility();
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
        public static JSValue BindStatic_GetStaticEditorFlags(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.GameObjectUtility), "GetStaticEditorFlags", typeof(UnityEngine.GameObject), 0);
                    }
                    var ret = UnityEditor.GameObjectUtility.GetStaticEditorFlags(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, (int)ret);
                }
                throw new NoSuitableMethodException("GetStaticEditorFlags", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetStaticEditorFlags(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.GameObjectUtility), "SetStaticEditorFlags", typeof(UnityEngine.GameObject), 0);
                    }
                    UnityEditor.StaticEditorFlags arg1;
                    if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.GameObjectUtility), "SetStaticEditorFlags", typeof(UnityEditor.StaticEditorFlags), 1);
                    }
                    UnityEditor.GameObjectUtility.SetStaticEditorFlags(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetStaticEditorFlags", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_AreStaticEditorFlagsSet(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.GameObjectUtility), "AreStaticEditorFlagsSet", typeof(UnityEngine.GameObject), 0);
                    }
                    UnityEditor.StaticEditorFlags arg1;
                    if (!Values.js_get_enumvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.GameObjectUtility), "AreStaticEditorFlagsSet", typeof(UnityEditor.StaticEditorFlags), 1);
                    }
                    var ret = UnityEditor.GameObjectUtility.AreStaticEditorFlagsSet(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("AreStaticEditorFlagsSet", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetNavMeshArea(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.GameObjectUtility), "GetNavMeshArea", typeof(UnityEngine.GameObject), 0);
                    }
                    var ret = UnityEditor.GameObjectUtility.GetNavMeshArea(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetNavMeshArea", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetNavMeshArea(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.GameObjectUtility), "SetNavMeshArea", typeof(UnityEngine.GameObject), 0);
                    }
                    int arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.GameObjectUtility), "SetNavMeshArea", typeof(int), 1);
                    }
                    UnityEditor.GameObjectUtility.SetNavMeshArea(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetNavMeshArea", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetNavMeshAreaFromName(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.GameObjectUtility), "GetNavMeshAreaFromName", typeof(string), 0);
                    }
                    var ret = UnityEditor.GameObjectUtility.GetNavMeshAreaFromName(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetNavMeshAreaFromName", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetNavMeshAreaNames(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    var ret = UnityEditor.GameObjectUtility.GetNavMeshAreaNames();
                    return Values.js_push_classvalue(ctx, ret);
                }
                throw new NoSuitableMethodException("GetNavMeshAreaNames", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetUniqueNameForSibling(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.Transform arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.GameObjectUtility), "GetUniqueNameForSibling", typeof(UnityEngine.Transform), 0);
                    }
                    string arg1;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.GameObjectUtility), "GetUniqueNameForSibling", typeof(string), 1);
                    }
                    var ret = UnityEditor.GameObjectUtility.GetUniqueNameForSibling(arg0, arg1);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetUniqueNameForSibling", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_EnsureUniqueNameForSibling(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.GameObjectUtility), "EnsureUniqueNameForSibling", typeof(UnityEngine.GameObject), 0);
                    }
                    UnityEditor.GameObjectUtility.EnsureUniqueNameForSibling(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("EnsureUniqueNameForSibling", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetParentAndAlign(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 2)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.GameObjectUtility), "SetParentAndAlign", typeof(UnityEngine.GameObject), 0);
                    }
                    UnityEngine.GameObject arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.GameObjectUtility), "SetParentAndAlign", typeof(UnityEngine.GameObject), 1);
                    }
                    UnityEditor.GameObjectUtility.SetParentAndAlign(arg0, arg1);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetParentAndAlign", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_GetMonoBehavioursWithMissingScriptCount(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.GameObjectUtility), "GetMonoBehavioursWithMissingScriptCount", typeof(UnityEngine.GameObject), 0);
                    }
                    var ret = UnityEditor.GameObjectUtility.GetMonoBehavioursWithMissingScriptCount(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("GetMonoBehavioursWithMissingScriptCount", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RemoveMonoBehavioursWithMissingScript(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    UnityEngine.GameObject arg0;
                    if (!Values.js_get_classvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.GameObjectUtility), "RemoveMonoBehavioursWithMissingScript", typeof(UnityEngine.GameObject), 0);
                    }
                    var ret = UnityEditor.GameObjectUtility.RemoveMonoBehavioursWithMissingScript(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("RemoveMonoBehavioursWithMissingScript", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("GameObjectUtility", typeof(UnityEditor.GameObjectUtility), BindConstructor);
            cls.AddMethod(true, "GetStaticEditorFlags", BindStatic_GetStaticEditorFlags);
            cls.AddMethod(true, "SetStaticEditorFlags", BindStatic_SetStaticEditorFlags);
            cls.AddMethod(true, "AreStaticEditorFlagsSet", BindStatic_AreStaticEditorFlagsSet);
            cls.AddMethod(true, "GetNavMeshArea", BindStatic_GetNavMeshArea);
            cls.AddMethod(true, "SetNavMeshArea", BindStatic_SetNavMeshArea);
            cls.AddMethod(true, "GetNavMeshAreaFromName", BindStatic_GetNavMeshAreaFromName);
            cls.AddMethod(true, "GetNavMeshAreaNames", BindStatic_GetNavMeshAreaNames);
            cls.AddMethod(true, "GetUniqueNameForSibling", BindStatic_GetUniqueNameForSibling);
            cls.AddMethod(true, "EnsureUniqueNameForSibling", BindStatic_EnsureUniqueNameForSibling);
            cls.AddMethod(true, "SetParentAndAlign", BindStatic_SetParentAndAlign);
            cls.AddMethod(true, "GetMonoBehavioursWithMissingScriptCount", BindStatic_GetMonoBehavioursWithMissingScriptCount);
            cls.AddMethod(true, "RemoveMonoBehavioursWithMissingScript", BindStatic_RemoveMonoBehavioursWithMissingScript);
            return cls;
        }
    }
}
#endif
#endif
