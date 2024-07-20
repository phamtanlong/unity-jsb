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
    // Type: UnityEditorInternal.Profiling.NetworkingOperationsProfilerOverrides
    [JSBindingAttribute]
    public class QuickJS_UnityEditorInternal_Profiling_NetworkingOperationsProfilerOverrides
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticDelegate_drawDetailsViewOverride(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                    {
                        System.Action<UnityEngine.Rect, int> value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditorInternal.Profiling.NetworkingOperationsProfilerOverrides), "drawDetailsViewOverride", typeof(System.Action<UnityEngine.Rect, int>), 1);
                        }
                        UnityEditorInternal.Profiling.NetworkingOperationsProfilerOverrides.drawDetailsViewOverride += value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_REMOVE:
                    {
                        System.Action<UnityEngine.Rect, int> value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditorInternal.Profiling.NetworkingOperationsProfilerOverrides), "drawDetailsViewOverride", typeof(System.Action<UnityEngine.Rect, int>), 1);
                        }
                        UnityEditorInternal.Profiling.NetworkingOperationsProfilerOverrides.drawDetailsViewOverride -= value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_SET:
                    {
                        System.Action<UnityEngine.Rect, int> value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditorInternal.Profiling.NetworkingOperationsProfilerOverrides), "drawDetailsViewOverride", typeof(System.Action<UnityEngine.Rect, int>), 1);
                        }
                        UnityEditorInternal.Profiling.NetworkingOperationsProfilerOverrides.drawDetailsViewOverride = value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_GET:
                    {
                        var ret = UnityEditorInternal.Profiling.NetworkingOperationsProfilerOverrides.drawDetailsViewOverride;
                        return Values.js_push_delegate(ctx, ret);
                    }
                    default: throw new JSException("invalid event op");
                }
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticDelegate_getCustomChartCounters(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                    {
                        System.Func<System.Collections.Generic.List<UnityEditorInternal.Profiling.NetworkCounterData>> value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditorInternal.Profiling.NetworkingOperationsProfilerOverrides), "getCustomChartCounters", typeof(System.Func<System.Collections.Generic.List<UnityEditorInternal.Profiling.NetworkCounterData>>), 1);
                        }
                        UnityEditorInternal.Profiling.NetworkingOperationsProfilerOverrides.getCustomChartCounters += value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_REMOVE:
                    {
                        System.Func<System.Collections.Generic.List<UnityEditorInternal.Profiling.NetworkCounterData>> value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditorInternal.Profiling.NetworkingOperationsProfilerOverrides), "getCustomChartCounters", typeof(System.Func<System.Collections.Generic.List<UnityEditorInternal.Profiling.NetworkCounterData>>), 1);
                        }
                        UnityEditorInternal.Profiling.NetworkingOperationsProfilerOverrides.getCustomChartCounters -= value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_SET:
                    {
                        System.Func<System.Collections.Generic.List<UnityEditorInternal.Profiling.NetworkCounterData>> value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditorInternal.Profiling.NetworkingOperationsProfilerOverrides), "getCustomChartCounters", typeof(System.Func<System.Collections.Generic.List<UnityEditorInternal.Profiling.NetworkCounterData>>), 1);
                        }
                        UnityEditorInternal.Profiling.NetworkingOperationsProfilerOverrides.getCustomChartCounters = value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_GET:
                    {
                        var ret = UnityEditorInternal.Profiling.NetworkingOperationsProfilerOverrides.getCustomChartCounters;
                        return Values.js_push_delegate(ctx, ret);
                    }
                    default: throw new JSException("invalid event op");
                }
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        public static QuickJS.Binding.ClassDecl Bind(QuickJS.Binding.TypeRegister register)
        {
            var cls = register.CreateClass("NetworkingOperationsProfilerOverrides", typeof(UnityEditorInternal.Profiling.NetworkingOperationsProfilerOverrides), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "drawDetailsViewOverride", BindStaticDelegate_drawDetailsViewOverride);
            cls.AddMethod(true, "getCustomChartCounters", BindStaticDelegate_getCustomChartCounters);
            return cls;
        }
    }
}
#endif
#endif
