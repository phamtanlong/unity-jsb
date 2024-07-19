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
    // Type: UnityEditor.LightingExplorerTableColumn
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_LightingExplorerTableColumn
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunctionMagic))]
        public static JSValue BindConstructor(JSContext ctx, JSValue new_target, int argc, JSValue[] argv, int magic)
        {
            try
            {
                if (argc == 8)
                {
                    UnityEditor.LightingExplorerTableColumn.DataType arg0;
                    if (!Values.js_get_enumvalue(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.LightingExplorerTableColumn), ".ctor", typeof(UnityEditor.LightingExplorerTableColumn.DataType), 0);
                    }
                    UnityEngine.GUIContent arg1;
                    if (!Values.js_get_classvalue(ctx, argv[1], out arg1))
                    {
                        throw new ParameterException(typeof(UnityEditor.LightingExplorerTableColumn), ".ctor", typeof(UnityEngine.GUIContent), 1);
                    }
                    string arg2;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[2], out arg2))
                    {
                        throw new ParameterException(typeof(UnityEditor.LightingExplorerTableColumn), ".ctor", typeof(string), 2);
                    }
                    int arg3;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[3], out arg3))
                    {
                        throw new ParameterException(typeof(UnityEditor.LightingExplorerTableColumn), ".ctor", typeof(int), 3);
                    }
                    UnityEditor.LightingExplorerTableColumn.OnGUIDelegate arg4;
                    if (!Values.js_get_delegate(ctx, argv[4], out arg4))
                    {
                        throw new ParameterException(typeof(UnityEditor.LightingExplorerTableColumn), ".ctor", typeof(UnityEditor.LightingExplorerTableColumn.OnGUIDelegate), 4);
                    }
                    UnityEditor.LightingExplorerTableColumn.ComparePropertiesDelegate arg5;
                    if (!Values.js_get_delegate(ctx, argv[5], out arg5))
                    {
                        throw new ParameterException(typeof(UnityEditor.LightingExplorerTableColumn), ".ctor", typeof(UnityEditor.LightingExplorerTableColumn.ComparePropertiesDelegate), 5);
                    }
                    UnityEditor.LightingExplorerTableColumn.CopyPropertiesDelegate arg6;
                    if (!Values.js_get_delegate(ctx, argv[6], out arg6))
                    {
                        throw new ParameterException(typeof(UnityEditor.LightingExplorerTableColumn), ".ctor", typeof(UnityEditor.LightingExplorerTableColumn.CopyPropertiesDelegate), 6);
                    }
                    int[] arg7;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[7], out arg7))
                    {
                        throw new ParameterException(typeof(UnityEditor.LightingExplorerTableColumn), ".ctor", typeof(int[]), 7);
                    }
                    var o = new UnityEditor.LightingExplorerTableColumn(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
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
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("LightingExplorerTableColumn", typeof(UnityEditor.LightingExplorerTableColumn), BindConstructor);
            return cls;
        }
    }
}
#endif
#endif
