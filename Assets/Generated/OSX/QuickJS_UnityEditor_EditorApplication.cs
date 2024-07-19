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
    // Type: UnityEditor.EditorApplication
    [JSBindingAttribute]
    public class QuickJS_UnityEditor_EditorApplication
    {
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_OpenProject(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc >= 1)
                {
                    if (Values.js_match_type(ctx, argv[0], typeof(string)) && Values.js_match_param_types(ctx, 1, argv, typeof(string)))
                    {
                        string arg0;
                        if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "OpenProject", typeof(string), 0);
                        }
                        string[] arg1 = null;
                        if (argc - 1 > 0)
                        {
                            arg1 = new string[argc - 1];
                            for (var i = 1; i < argc; i++)
                            {
                                QuickJS.Binding.Values.js_get_primitive(ctx, argv[i], out arg1[i - 1]);
                            }
                        }
                        UnityEditor.EditorApplication.OpenProject(arg0, arg1);
                        return JSApi.JS_UNDEFINED;
                    }
                }
                throw new NoSuitableMethodException("OpenProject", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_EnterPlaymode(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorApplication.EnterPlaymode();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("EnterPlaymode", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ExitPlaymode(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorApplication.ExitPlaymode();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("ExitPlaymode", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Step(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorApplication.Step();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Step", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_LockReloadAssemblies(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorApplication.LockReloadAssemblies();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("LockReloadAssemblies", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_UnlockReloadAssemblies(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorApplication.UnlockReloadAssemblies();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("UnlockReloadAssemblies", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_ExecuteMenuItem(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorApplication), "ExecuteMenuItem", typeof(string), 0);
                    }
                    var ret = UnityEditor.EditorApplication.ExecuteMenuItem(arg0);
                    return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
                }
                throw new NoSuitableMethodException("ExecuteMenuItem", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_SetTemporaryProjectKeepPath(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    string arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorApplication), "SetTemporaryProjectKeepPath", typeof(string), 0);
                    }
                    UnityEditor.EditorApplication.SetTemporaryProjectKeepPath(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("SetTemporaryProjectKeepPath", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Exit(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 1)
                {
                    int arg0;
                    if (!QuickJS.Binding.Values.js_get_primitive(ctx, argv[0], out arg0))
                    {
                        throw new ParameterException(typeof(UnityEditor.EditorApplication), "Exit", typeof(int), 0);
                    }
                    UnityEditor.EditorApplication.Exit(arg0);
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Exit", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_QueuePlayerLoopUpdate(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorApplication.QueuePlayerLoopUpdate();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("QueuePlayerLoopUpdate", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_Beep(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorApplication.Beep();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("Beep", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RepaintProjectWindow(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorApplication.RepaintProjectWindow();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RepaintProjectWindow", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RepaintAnimationWindow(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorApplication.RepaintAnimationWindow();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RepaintAnimationWindow", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_RepaintHierarchyWindow(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorApplication.RepaintHierarchyWindow();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("RepaintHierarchyWindow", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStatic_DirtyHierarchyWindowSorting(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                if (argc == 0)
                {
                    UnityEditor.EditorApplication.DirtyHierarchyWindowSorting();
                    return JSApi.JS_UNDEFINED;
                }
                throw new NoSuitableMethodException("DirtyHierarchyWindowSorting", argc);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_isPlaying(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorApplication.isPlaying;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_isPlaying(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorApplication), "isPlaying", typeof(bool), 0);
                }
                UnityEditor.EditorApplication.isPlaying = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_isPlayingOrWillChangePlaymode(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorApplication.isPlayingOrWillChangePlaymode;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_isPaused(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorApplication.isPaused;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSSetterCFunction))]
        public static JSValue BindStaticWrite_isPaused(JSContext ctx, JSValue this_obj, JSValue arg_val)
        {
            try
            {
                bool value;
                if (!QuickJS.Binding.Values.js_get_primitive(ctx, arg_val, out value))
                {
                    throw new ParameterException(typeof(UnityEditor.EditorApplication), "isPaused", typeof(bool), 0);
                }
                UnityEditor.EditorApplication.isPaused = value;
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_isCompiling(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorApplication.isCompiling;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_isUpdating(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorApplication.isUpdating;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_isRemoteConnected(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorApplication.isRemoteConnected;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_applicationContentsPath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorApplication.applicationContentsPath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_applicationPath(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorApplication.applicationPath;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_isTemporaryProject(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorApplication.isTemporaryProject;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSGetterCFunction))]
        public static JSValue BindStaticRead_timeSinceStartup(JSContext ctx, JSValue this_obj)
        {
            try
            {
                var ret = UnityEditor.EditorApplication.timeSinceStartup;
                return QuickJS.Binding.Values.js_push_primitive(ctx, ret);
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_wantsToQuit(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                System.Func<bool> value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "wantsToQuit", typeof(System.Func<bool>), 1);
                        }
                        UnityEditor.EditorApplication.wantsToQuit += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "wantsToQuit", typeof(System.Func<bool>), 1);
                        }
                        UnityEditor.EditorApplication.wantsToQuit -= value;
                        break;
                    default: throw new JSException("invalid event op");
                }
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_quitting(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                System.Action value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "quitting", typeof(System.Action), 1);
                        }
                        UnityEditor.EditorApplication.quitting += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "quitting", typeof(System.Action), 1);
                        }
                        UnityEditor.EditorApplication.quitting -= value;
                        break;
                    default: throw new JSException("invalid event op");
                }
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_hierarchyChanged(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                System.Action value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "hierarchyChanged", typeof(System.Action), 1);
                        }
                        UnityEditor.EditorApplication.hierarchyChanged += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "hierarchyChanged", typeof(System.Action), 1);
                        }
                        UnityEditor.EditorApplication.hierarchyChanged -= value;
                        break;
                    default: throw new JSException("invalid event op");
                }
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_projectChanged(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                System.Action value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "projectChanged", typeof(System.Action), 1);
                        }
                        UnityEditor.EditorApplication.projectChanged += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "projectChanged", typeof(System.Action), 1);
                        }
                        UnityEditor.EditorApplication.projectChanged -= value;
                        break;
                    default: throw new JSException("invalid event op");
                }
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_pauseStateChanged(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                System.Action<UnityEditor.PauseState> value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "pauseStateChanged", typeof(System.Action<UnityEditor.PauseState>), 1);
                        }
                        UnityEditor.EditorApplication.pauseStateChanged += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "pauseStateChanged", typeof(System.Action<UnityEditor.PauseState>), 1);
                        }
                        UnityEditor.EditorApplication.pauseStateChanged -= value;
                        break;
                    default: throw new JSException("invalid event op");
                }
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticEvent_playModeStateChanged(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                System.Action<UnityEditor.PlayModeStateChange> value;
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "playModeStateChanged", typeof(System.Action<UnityEditor.PlayModeStateChange>), 1);
                        }
                        UnityEditor.EditorApplication.playModeStateChanged += value;
                        break;
                    case Values.EVT_OP_REMOVE:
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "playModeStateChanged", typeof(System.Action<UnityEditor.PlayModeStateChange>), 1);
                        }
                        UnityEditor.EditorApplication.playModeStateChanged -= value;
                        break;
                    default: throw new JSException("invalid event op");
                }
                return JSApi.JS_UNDEFINED;
            }
            catch (Exception exception)
            {
                return JSNative.ThrowException(ctx, exception);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(QuickJS.Native.JSCFunction))]
        public static JSValue BindStaticDelegate_projectWindowItemOnGUI(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                    {
                        UnityEditor.EditorApplication.ProjectWindowItemCallback value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "projectWindowItemOnGUI", typeof(UnityEditor.EditorApplication.ProjectWindowItemCallback), 1);
                        }
                        UnityEditor.EditorApplication.projectWindowItemOnGUI += value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_REMOVE:
                    {
                        UnityEditor.EditorApplication.ProjectWindowItemCallback value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "projectWindowItemOnGUI", typeof(UnityEditor.EditorApplication.ProjectWindowItemCallback), 1);
                        }
                        UnityEditor.EditorApplication.projectWindowItemOnGUI -= value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_SET:
                    {
                        UnityEditor.EditorApplication.ProjectWindowItemCallback value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "projectWindowItemOnGUI", typeof(UnityEditor.EditorApplication.ProjectWindowItemCallback), 1);
                        }
                        UnityEditor.EditorApplication.projectWindowItemOnGUI = value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_GET:
                    {
                        var ret = UnityEditor.EditorApplication.projectWindowItemOnGUI;
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
        public static JSValue BindStaticDelegate_hierarchyWindowItemOnGUI(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                    {
                        UnityEditor.EditorApplication.HierarchyWindowItemCallback value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "hierarchyWindowItemOnGUI", typeof(UnityEditor.EditorApplication.HierarchyWindowItemCallback), 1);
                        }
                        UnityEditor.EditorApplication.hierarchyWindowItemOnGUI += value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_REMOVE:
                    {
                        UnityEditor.EditorApplication.HierarchyWindowItemCallback value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "hierarchyWindowItemOnGUI", typeof(UnityEditor.EditorApplication.HierarchyWindowItemCallback), 1);
                        }
                        UnityEditor.EditorApplication.hierarchyWindowItemOnGUI -= value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_SET:
                    {
                        UnityEditor.EditorApplication.HierarchyWindowItemCallback value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "hierarchyWindowItemOnGUI", typeof(UnityEditor.EditorApplication.HierarchyWindowItemCallback), 1);
                        }
                        UnityEditor.EditorApplication.hierarchyWindowItemOnGUI = value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_GET:
                    {
                        var ret = UnityEditor.EditorApplication.hierarchyWindowItemOnGUI;
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
        public static JSValue BindStaticDelegate_update(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                    {
                        UnityEditor.EditorApplication.CallbackFunction value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "update", typeof(UnityEditor.EditorApplication.CallbackFunction), 1);
                        }
                        UnityEditor.EditorApplication.update += value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_REMOVE:
                    {
                        UnityEditor.EditorApplication.CallbackFunction value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "update", typeof(UnityEditor.EditorApplication.CallbackFunction), 1);
                        }
                        UnityEditor.EditorApplication.update -= value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_SET:
                    {
                        UnityEditor.EditorApplication.CallbackFunction value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "update", typeof(UnityEditor.EditorApplication.CallbackFunction), 1);
                        }
                        UnityEditor.EditorApplication.update = value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_GET:
                    {
                        var ret = UnityEditor.EditorApplication.update;
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
        public static JSValue BindStaticDelegate_delayCall(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                    {
                        UnityEditor.EditorApplication.CallbackFunction value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "delayCall", typeof(UnityEditor.EditorApplication.CallbackFunction), 1);
                        }
                        UnityEditor.EditorApplication.delayCall += value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_REMOVE:
                    {
                        UnityEditor.EditorApplication.CallbackFunction value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "delayCall", typeof(UnityEditor.EditorApplication.CallbackFunction), 1);
                        }
                        UnityEditor.EditorApplication.delayCall -= value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_SET:
                    {
                        UnityEditor.EditorApplication.CallbackFunction value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "delayCall", typeof(UnityEditor.EditorApplication.CallbackFunction), 1);
                        }
                        UnityEditor.EditorApplication.delayCall = value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_GET:
                    {
                        var ret = UnityEditor.EditorApplication.delayCall;
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
        public static JSValue BindStaticDelegate_searchChanged(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                    {
                        UnityEditor.EditorApplication.CallbackFunction value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "searchChanged", typeof(UnityEditor.EditorApplication.CallbackFunction), 1);
                        }
                        UnityEditor.EditorApplication.searchChanged += value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_REMOVE:
                    {
                        UnityEditor.EditorApplication.CallbackFunction value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "searchChanged", typeof(UnityEditor.EditorApplication.CallbackFunction), 1);
                        }
                        UnityEditor.EditorApplication.searchChanged -= value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_SET:
                    {
                        UnityEditor.EditorApplication.CallbackFunction value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "searchChanged", typeof(UnityEditor.EditorApplication.CallbackFunction), 1);
                        }
                        UnityEditor.EditorApplication.searchChanged = value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_GET:
                    {
                        var ret = UnityEditor.EditorApplication.searchChanged;
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
        public static JSValue BindStaticDelegate_modifierKeysChanged(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                    {
                        UnityEditor.EditorApplication.CallbackFunction value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "modifierKeysChanged", typeof(UnityEditor.EditorApplication.CallbackFunction), 1);
                        }
                        UnityEditor.EditorApplication.modifierKeysChanged += value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_REMOVE:
                    {
                        UnityEditor.EditorApplication.CallbackFunction value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "modifierKeysChanged", typeof(UnityEditor.EditorApplication.CallbackFunction), 1);
                        }
                        UnityEditor.EditorApplication.modifierKeysChanged -= value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_SET:
                    {
                        UnityEditor.EditorApplication.CallbackFunction value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "modifierKeysChanged", typeof(UnityEditor.EditorApplication.CallbackFunction), 1);
                        }
                        UnityEditor.EditorApplication.modifierKeysChanged = value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_GET:
                    {
                        var ret = UnityEditor.EditorApplication.modifierKeysChanged;
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
        public static JSValue BindStaticDelegate_contextualPropertyMenu(JSContext ctx, JSValue this_obj, int argc, JSValue[] argv)
        {
            try
            {
                var op = Values.js_parse_event_op(ctx, argv[0]);
                switch(op)
                {
                    case Values.EVT_OP_ADD:
                    {
                        UnityEditor.EditorApplication.SerializedPropertyCallbackFunction value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "contextualPropertyMenu", typeof(UnityEditor.EditorApplication.SerializedPropertyCallbackFunction), 1);
                        }
                        UnityEditor.EditorApplication.contextualPropertyMenu += value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_REMOVE:
                    {
                        UnityEditor.EditorApplication.SerializedPropertyCallbackFunction value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "contextualPropertyMenu", typeof(UnityEditor.EditorApplication.SerializedPropertyCallbackFunction), 1);
                        }
                        UnityEditor.EditorApplication.contextualPropertyMenu -= value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_SET:
                    {
                        UnityEditor.EditorApplication.SerializedPropertyCallbackFunction value;
                        if (!Values.js_get_delegate(ctx, argv[1], out value))
                        {
                            throw new ParameterException(typeof(UnityEditor.EditorApplication), "contextualPropertyMenu", typeof(UnityEditor.EditorApplication.SerializedPropertyCallbackFunction), 1);
                        }
                        UnityEditor.EditorApplication.contextualPropertyMenu = value;
                        return JSApi.JS_UNDEFINED;
                    }
                    case Values.EVT_OP_GET:
                    {
                        var ret = UnityEditor.EditorApplication.contextualPropertyMenu;
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
            var cls = register.CreateClass("EditorApplication", typeof(UnityEditor.EditorApplication), QuickJS.JSNative.class_private_ctor);
            cls.AddMethod(true, "OpenProject", BindStatic_OpenProject);
            cls.AddMethod(true, "EnterPlaymode", BindStatic_EnterPlaymode);
            cls.AddMethod(true, "ExitPlaymode", BindStatic_ExitPlaymode);
            cls.AddMethod(true, "Step", BindStatic_Step);
            cls.AddMethod(true, "LockReloadAssemblies", BindStatic_LockReloadAssemblies);
            cls.AddMethod(true, "UnlockReloadAssemblies", BindStatic_UnlockReloadAssemblies);
            cls.AddMethod(true, "ExecuteMenuItem", BindStatic_ExecuteMenuItem);
            cls.AddMethod(true, "SetTemporaryProjectKeepPath", BindStatic_SetTemporaryProjectKeepPath);
            cls.AddMethod(true, "Exit", BindStatic_Exit);
            cls.AddMethod(true, "QueuePlayerLoopUpdate", BindStatic_QueuePlayerLoopUpdate);
            cls.AddMethod(true, "Beep", BindStatic_Beep);
            cls.AddMethod(true, "RepaintProjectWindow", BindStatic_RepaintProjectWindow);
            cls.AddMethod(true, "RepaintAnimationWindow", BindStatic_RepaintAnimationWindow);
            cls.AddMethod(true, "RepaintHierarchyWindow", BindStatic_RepaintHierarchyWindow);
            cls.AddMethod(true, "DirtyHierarchyWindowSorting", BindStatic_DirtyHierarchyWindowSorting);
            cls.AddProperty(true, "isPlaying", BindStaticRead_isPlaying, BindStaticWrite_isPlaying);
            cls.AddProperty(true, "isPlayingOrWillChangePlaymode", BindStaticRead_isPlayingOrWillChangePlaymode, null);
            cls.AddProperty(true, "isPaused", BindStaticRead_isPaused, BindStaticWrite_isPaused);
            cls.AddProperty(true, "isCompiling", BindStaticRead_isCompiling, null);
            cls.AddProperty(true, "isUpdating", BindStaticRead_isUpdating, null);
            cls.AddProperty(true, "isRemoteConnected", BindStaticRead_isRemoteConnected, null);
            cls.AddProperty(true, "applicationContentsPath", BindStaticRead_applicationContentsPath, null);
            cls.AddProperty(true, "applicationPath", BindStaticRead_applicationPath, null);
            cls.AddProperty(true, "isTemporaryProject", BindStaticRead_isTemporaryProject, null);
            cls.AddProperty(true, "timeSinceStartup", BindStaticRead_timeSinceStartup, null);
            cls.AddMethod(true, "wantsToQuit", BindStaticEvent_wantsToQuit);
            cls.AddMethod(true, "quitting", BindStaticEvent_quitting);
            cls.AddMethod(true, "hierarchyChanged", BindStaticEvent_hierarchyChanged);
            cls.AddMethod(true, "projectChanged", BindStaticEvent_projectChanged);
            cls.AddMethod(true, "pauseStateChanged", BindStaticEvent_pauseStateChanged);
            cls.AddMethod(true, "playModeStateChanged", BindStaticEvent_playModeStateChanged);
            cls.AddMethod(true, "projectWindowItemOnGUI", BindStaticDelegate_projectWindowItemOnGUI);
            cls.AddMethod(true, "hierarchyWindowItemOnGUI", BindStaticDelegate_hierarchyWindowItemOnGUI);
            cls.AddMethod(true, "update", BindStaticDelegate_update);
            cls.AddMethod(true, "delayCall", BindStaticDelegate_delayCall);
            cls.AddMethod(true, "searchChanged", BindStaticDelegate_searchChanged);
            cls.AddMethod(true, "modifierKeysChanged", BindStaticDelegate_modifierKeysChanged);
            cls.AddMethod(true, "contextualPropertyMenu", BindStaticDelegate_contextualPropertyMenu);
            return cls;
        }
    }
}
#endif
#endif
