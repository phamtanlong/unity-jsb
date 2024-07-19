#if UNITY_STANDALONE_OSX
// Unity: 2019.4.40f1
using System;
using System.Collections.Generic;

// Special: _QuickJSDelegates
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
    using JSDelegateAttribute = QuickJS.JSDelegateAttribute;
    [UnityEngine.Scripting.Preserve]
    [JSBindingAttribute]
    public class _QuickJSDelegates : Values
    {
        public delegate int _HotfixDelegate0(object _hotfix_this, int x);
        [UnityEngine.Scripting.Preserve]
        [QuickJS.JSDelegateAttribute(typeof(_HotfixDelegate0))]
        public static unsafe int _QuickJSHotfixDelegates0(QuickJS.ScriptDelegate fn, object _hotfix_this, int x)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = QuickJS.Binding.Values.js_push_primitive(ctx, x);
            if (argv[0].IsException())
            {
                throw new Exception(ctx.GetExceptionString());
            }
            var this_obj = hotfix_push_classvalue(ctx, _hotfix_this);
            var rval = fn.Invoke(ctx, this_obj, 1, argv);
            JSApi.JS_FreeValue(ctx, this_obj);
            int ret0;
            var succ = QuickJS.Binding.Values.js_get_primitive(ctx, rval, out ret0);
            JSApi.JS_FreeValue(ctx, argv[0]);
            if (rval.IsException())
            {
                throw new Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            if (succ)
            {
                return ret0;
            }
            else
            {
                throw new Exception("js exception caught");
            }
        }
        public delegate void _HotfixDelegate1(object _hotfix_this, int x);
        [UnityEngine.Scripting.Preserve]
        [QuickJS.JSDelegateAttribute(typeof(_HotfixDelegate1))]
        public static unsafe void _QuickJSHotfixDelegates1(QuickJS.ScriptDelegate fn, object _hotfix_this, int x)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = QuickJS.Binding.Values.js_push_primitive(ctx, x);
            if (argv[0].IsException())
            {
                throw new Exception(ctx.GetExceptionString());
            }
            var this_obj = hotfix_push_classvalue(ctx, _hotfix_this);
            var rval = fn.Invoke(ctx, this_obj, 1, argv);
            JSApi.JS_FreeValue(ctx, this_obj);
            JSApi.JS_FreeValue(ctx, argv[0]);
            if (rval.IsException())
            {
                throw new Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
        }
        public delegate string _HotfixDelegate2(object _hotfix_this, string x);
        [UnityEngine.Scripting.Preserve]
        [QuickJS.JSDelegateAttribute(typeof(_HotfixDelegate2))]
        public static unsafe string _QuickJSHotfixDelegates2(QuickJS.ScriptDelegate fn, object _hotfix_this, string x)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = QuickJS.Binding.Values.js_push_primitive(ctx, x);
            if (argv[0].IsException())
            {
                throw new Exception(ctx.GetExceptionString());
            }
            var this_obj = hotfix_push_classvalue(ctx, _hotfix_this);
            var rval = fn.Invoke(ctx, this_obj, 1, argv);
            JSApi.JS_FreeValue(ctx, this_obj);
            string ret0;
            var succ = QuickJS.Binding.Values.js_get_primitive(ctx, rval, out ret0);
            JSApi.JS_FreeValue(ctx, argv[0]);
            if (rval.IsException())
            {
                throw new Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            if (succ)
            {
                return ret0;
            }
            else
            {
                throw new Exception("js exception caught");
            }
        }
        public delegate void _HotfixDelegate3(object _hotfix_this, string x);
        [UnityEngine.Scripting.Preserve]
        [QuickJS.JSDelegateAttribute(typeof(_HotfixDelegate3))]
        public static unsafe void _QuickJSHotfixDelegates3(QuickJS.ScriptDelegate fn, object _hotfix_this, string x)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = QuickJS.Binding.Values.js_push_primitive(ctx, x);
            if (argv[0].IsException())
            {
                throw new Exception(ctx.GetExceptionString());
            }
            var this_obj = hotfix_push_classvalue(ctx, _hotfix_this);
            var rval = fn.Invoke(ctx, this_obj, 1, argv);
            JSApi.JS_FreeValue(ctx, this_obj);
            JSApi.JS_FreeValue(ctx, argv[0]);
            if (rval.IsException())
            {
                throw new Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
        }
        public delegate void _HotfixDelegate4(Type _hotfix_this);
        [UnityEngine.Scripting.Preserve]
        [QuickJS.JSDelegateAttribute(typeof(_HotfixDelegate4))]
        public static unsafe void _QuickJSHotfixDelegates4(QuickJS.ScriptDelegate fn, Type _hotfix_this)
        {
            var ctx = fn.ctx;
            var this_obj = hotfix_push_classvalue(ctx, _hotfix_this);
            var rval = fn.Invoke(ctx, this_obj);
            JSApi.JS_FreeValue(ctx, this_obj);
            if (rval.IsException())
            {
                throw new Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
        }
        public delegate void _HotfixDelegate5(object _hotfix_this);
        [UnityEngine.Scripting.Preserve]
        [QuickJS.JSDelegateAttribute(typeof(_HotfixDelegate5))]
        public static unsafe void _QuickJSHotfixDelegates5(QuickJS.ScriptDelegate fn, object _hotfix_this)
        {
            var ctx = fn.ctx;
            var this_obj = hotfix_push_classvalue(ctx, _hotfix_this);
            var rval = fn.Invoke(ctx, this_obj);
            JSApi.JS_FreeValue(ctx, this_obj);
            if (rval.IsException())
            {
                throw new Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
        }
        public delegate int _HotfixDelegate6(object _hotfix_this, int x);
        [UnityEngine.Scripting.Preserve]
        [QuickJS.JSDelegateAttribute(typeof(_HotfixDelegate6))]
        public static unsafe int _QuickJSHotfixDelegates6(QuickJS.ScriptDelegate fn, object _hotfix_this, int x)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = QuickJS.Binding.Values.js_push_primitive(ctx, x);
            if (argv[0].IsException())
            {
                throw new Exception(ctx.GetExceptionString());
            }
            var this_obj = hotfix_push_classvalue(ctx, _hotfix_this);
            var rval = fn.Invoke(ctx, this_obj, 1, argv);
            JSApi.JS_FreeValue(ctx, this_obj);
            int ret0;
            var succ = QuickJS.Binding.Values.js_get_primitive(ctx, rval, out ret0);
            JSApi.JS_FreeValue(ctx, argv[0]);
            if (rval.IsException())
            {
                throw new Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            if (succ)
            {
                return ret0;
            }
            else
            {
                throw new Exception("js exception caught");
            }
        }
        public delegate void _HotfixDelegate7(object _hotfix_this);
        [UnityEngine.Scripting.Preserve]
        [QuickJS.JSDelegateAttribute(typeof(_HotfixDelegate7))]
        public static unsafe void _QuickJSHotfixDelegates7(QuickJS.ScriptDelegate fn, object _hotfix_this)
        {
            var ctx = fn.ctx;
            var this_obj = hotfix_push_classvalue(ctx, _hotfix_this);
            var rval = fn.Invoke(ctx, this_obj);
            JSApi.JS_FreeValue(ctx, this_obj);
            if (rval.IsException())
            {
                throw new Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
        }
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.Camera.CameraCallback))]
        public static unsafe void _QuickJSDelegates0(QuickJS.ScriptDelegate fn, UnityEngine.Camera cam)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = Values.js_push_classvalue(ctx, cam);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
        }
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.RectTransform.ReapplyDrivenProperties))]
        public static unsafe void _QuickJSDelegates1(QuickJS.ScriptDelegate fn, UnityEngine.RectTransform driven)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = Values.js_push_classvalue(ctx, driven);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
        }
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.Application.LowMemoryCallback))]
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.Events.UnityAction))]
        [QuickJS.JSDelegateAttribute(typeof(System.Action))]
        public static unsafe void _QuickJSDelegates2(QuickJS.ScriptDelegate fn)
        {
            var ctx = fn.ctx;
            var rval = fn.Invoke(ctx);
            if (rval.IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
        }
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.Application.LogCallback))]
        public static unsafe void _QuickJSDelegates3(QuickJS.ScriptDelegate fn, string condition, string stackTrace, UnityEngine.LogType type)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[3];
            argv[0] = QuickJS.Binding.Values.js_push_primitive(ctx, condition);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = QuickJS.Binding.Values.js_push_primitive(ctx, stackTrace);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[2] = QuickJS.Binding.Values.js_push_primitive(ctx, (int)type);
            if (argv[2].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 3, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                JSApi.JS_FreeValue(ctx, argv[2]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
            JSApi.JS_FreeValue(ctx, argv[2]);
        }
        [QuickJS.JSDelegateAttribute(typeof(System.Action<bool>))]
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.Events.UnityAction<bool>))]
        public static unsafe void _QuickJSDelegates4(QuickJS.ScriptDelegate fn, bool obj)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = QuickJS.Binding.Values.js_push_primitive(ctx, obj);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
        }
        [QuickJS.JSDelegateAttribute(typeof(System.Action<string>))]
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.Events.UnityAction<string>))]
        public static unsafe void _QuickJSDelegates5(QuickJS.ScriptDelegate fn, string obj)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = QuickJS.Binding.Values.js_push_primitive(ctx, obj);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
        }
        [QuickJS.JSDelegateAttribute(typeof(System.Func<bool>))]
        public static unsafe bool _QuickJSDelegates6(QuickJS.ScriptDelegate fn)
        {
            var ctx = fn.ctx;
            var rval = fn.Invoke(ctx);
            if (rval.IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            bool ret0;
            var succ = QuickJS.Binding.Values.js_get_primitive(ctx, rval, out ret0);
            JSApi.JS_FreeValue(ctx, rval);
            if (succ)
            {
                return ret0;
            }
            else
            {
                throw new System.Exception("js exception caught");
            }
        }
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.Application.AdvertisingIdentifierCallback))]
        public static unsafe void _QuickJSDelegates7(QuickJS.ScriptDelegate fn, string advertisingId, bool trackingEnabled, string errorMsg)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[3];
            argv[0] = QuickJS.Binding.Values.js_push_primitive(ctx, advertisingId);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = QuickJS.Binding.Values.js_push_primitive(ctx, trackingEnabled);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[2] = QuickJS.Binding.Values.js_push_primitive(ctx, errorMsg);
            if (argv[2].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 3, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                JSApi.JS_FreeValue(ctx, argv[2]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
            JSApi.JS_FreeValue(ctx, argv[2]);
        }
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.GUI.WindowFunction))]
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.AudioClip.PCMSetPositionCallback))]
        [QuickJS.JSDelegateAttribute(typeof(System.Action<int>))]
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.Events.UnityAction<int>))]
        public static unsafe void _QuickJSDelegates8(QuickJS.ScriptDelegate fn, int id)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = QuickJS.Binding.Values.js_push_primitive(ctx, id);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
        }
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.AudioClip.PCMReaderCallback))]
        public static unsafe void _QuickJSDelegates9(QuickJS.ScriptDelegate fn, float[] data)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = Values.js_push_classvalue(ctx, data);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
        }
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.IMGUI.Controls.SearchField.SearchFieldCallback))]
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.GenericMenu.MenuFunction))]
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.EditorApplication.CallbackFunction))]
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.AssemblyReloadEvents.AssemblyReloadCallback))]
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.Undo.UndoRedoCallback))]
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.Undo.WillFlushUndoRecord))]
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.Hardware.DevDeviceList.OnChangedHandler))]
        public static unsafe void _QuickJSDelegates10(QuickJS.ScriptDelegate fn)
        {
            var ctx = fn.ctx;
            var rval = fn.Invoke(ctx);
            if (rval.IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.GenericMenu.MenuFunction2))]
        public static unsafe void _QuickJSDelegates11(QuickJS.ScriptDelegate fn, object userData)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = QuickJS.Binding.Values.js_push_object(ctx, userData);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
        }
#endif
        [QuickJS.JSDelegateAttribute(typeof(System.Action<UnityEngine.Component>))]
        public static unsafe void _QuickJSDelegates12(QuickJS.ScriptDelegate fn, UnityEngine.Component obj)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = Values.js_push_classvalue(ctx, obj);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
        }
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.Handles.CapFunction))]
        public static unsafe void _QuickJSDelegates13(QuickJS.ScriptDelegate fn, int controlID, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, float size, UnityEngine.EventType eventType)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[5];
            argv[0] = QuickJS.Binding.Values.js_push_primitive(ctx, controlID);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = QuickJS.Binding.Values.js_push_structvalue(ctx, position);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[2] = QuickJS.Binding.Values.js_push_structvalue(ctx, rotation);
            if (argv[2].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[3] = QuickJS.Binding.Values.js_push_primitive(ctx, size);
            if (argv[3].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                JSApi.JS_FreeValue(ctx, argv[2]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[4] = QuickJS.Binding.Values.js_push_primitive(ctx, (int)eventType);
            if (argv[4].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                JSApi.JS_FreeValue(ctx, argv[2]);
                JSApi.JS_FreeValue(ctx, argv[3]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 5, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                JSApi.JS_FreeValue(ctx, argv[2]);
                JSApi.JS_FreeValue(ctx, argv[3]);
                JSApi.JS_FreeValue(ctx, argv[4]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
            JSApi.JS_FreeValue(ctx, argv[2]);
            JSApi.JS_FreeValue(ctx, argv[3]);
            JSApi.JS_FreeValue(ctx, argv[4]);
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(System.Func<UnityEditor.SceneView.CameraMode, bool>))]
        public static unsafe bool _QuickJSDelegates14(QuickJS.ScriptDelegate fn, UnityEditor.SceneView.CameraMode arg)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = Values.js_push_structvalue(ctx, arg);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            bool ret0;
            var succ = QuickJS.Binding.Values.js_get_primitive(ctx, rval, out ret0);
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            if (succ)
            {
                return ret0;
            }
            else
            {
                throw new System.Exception("js exception caught");
            }
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(System.Action<UnityEditor.SceneView.CameraMode>))]
        public static unsafe void _QuickJSDelegates15(QuickJS.ScriptDelegate fn, UnityEditor.SceneView.CameraMode obj)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = Values.js_push_structvalue(ctx, obj);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(System.Action<UnityEditor.SceneView>))]
        public static unsafe void _QuickJSDelegates16(QuickJS.ScriptDelegate fn, UnityEditor.SceneView obj)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = Values.js_push_classvalue(ctx, obj);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.PrefabUtility.PrefabInstanceUpdated))]
        public static unsafe void _QuickJSDelegates17(QuickJS.ScriptDelegate fn, UnityEngine.GameObject instance)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = Values.js_push_classvalue(ctx, instance);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.AssetDatabase.ImportPackageCallback))]
        public static unsafe void _QuickJSDelegates18(QuickJS.ScriptDelegate fn, string packageName)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = QuickJS.Binding.Values.js_push_primitive(ctx, packageName);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.AssetDatabase.ImportPackageFailedCallback))]
        public static unsafe void _QuickJSDelegates19(QuickJS.ScriptDelegate fn, string packageName, string errorMessage)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = QuickJS.Binding.Values.js_push_primitive(ctx, packageName);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = QuickJS.Binding.Values.js_push_primitive(ctx, errorMessage);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.EditorUtility.SelectMenuItemFunction))]
        public static unsafe void _QuickJSDelegates20(QuickJS.ScriptDelegate fn, object userData, string[] options, int selected)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[3];
            argv[0] = QuickJS.Binding.Values.js_push_object(ctx, userData);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = Values.js_push_classvalue(ctx, options);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[2] = QuickJS.Binding.Values.js_push_primitive(ctx, selected);
            if (argv[2].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 3, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                JSApi.JS_FreeValue(ctx, argv[2]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
            JSApi.JS_FreeValue(ctx, argv[2]);
        }
#endif
        [QuickJS.JSDelegateAttribute(typeof(System.Func<int, bool>))]
        public static unsafe bool _QuickJSDelegates21(QuickJS.ScriptDelegate fn, int arg)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = QuickJS.Binding.Values.js_push_primitive(ctx, arg);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            bool ret0;
            var succ = QuickJS.Binding.Values.js_get_primitive(ctx, rval, out ret0);
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            if (succ)
            {
                return ret0;
            }
            else
            {
                throw new System.Exception("js exception caught");
            }
        }
        [QuickJS.JSDelegateAttribute(typeof(System.Func<System.Enum, bool>))]
        public static unsafe bool _QuickJSDelegates22(QuickJS.ScriptDelegate fn, System.Enum arg)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = Values.js_push_classvalue(ctx, arg);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            bool ret0;
            var succ = QuickJS.Binding.Values.js_get_primitive(ctx, rval, out ret0);
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            if (succ)
            {
                return ret0;
            }
            else
            {
                throw new System.Exception("js exception caught");
            }
        }
        [QuickJS.JSDelegateAttribute(typeof(System.Action<UnityEngine.Rect>))]
        public static unsafe void _QuickJSDelegates23(QuickJS.ScriptDelegate fn, UnityEngine.Rect obj)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = QuickJS.Binding.Values.js_push_structvalue(ctx, obj);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
        }
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.EditorApplication.ProjectWindowItemCallback))]
        public static unsafe void _QuickJSDelegates24(QuickJS.ScriptDelegate fn, string guid, UnityEngine.Rect selectionRect)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = QuickJS.Binding.Values.js_push_primitive(ctx, guid);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = QuickJS.Binding.Values.js_push_structvalue(ctx, selectionRect);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.EditorApplication.HierarchyWindowItemCallback))]
        public static unsafe void _QuickJSDelegates25(QuickJS.ScriptDelegate fn, int instanceID, UnityEngine.Rect selectionRect)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = QuickJS.Binding.Values.js_push_primitive(ctx, instanceID);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = QuickJS.Binding.Values.js_push_structvalue(ctx, selectionRect);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.EditorApplication.SerializedPropertyCallbackFunction))]
        public static unsafe void _QuickJSDelegates26(QuickJS.ScriptDelegate fn, UnityEditor.GenericMenu menu, UnityEditor.SerializedProperty property)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = Values.js_push_classvalue(ctx, menu);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = Values.js_push_classvalue(ctx, property);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(System.Action<UnityEditor.PauseState>))]
        public static unsafe void _QuickJSDelegates27(QuickJS.ScriptDelegate fn, UnityEditor.PauseState obj)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = QuickJS.Binding.Values.js_push_primitive(ctx, (int)obj);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(System.Action<UnityEditor.PlayModeStateChange>))]
        public static unsafe void _QuickJSDelegates28(QuickJS.ScriptDelegate fn, UnityEditor.PlayModeStateChange obj)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = QuickJS.Binding.Values.js_push_primitive(ctx, (int)obj);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(System.Action<UnityEditor.Editor>))]
        public static unsafe void _QuickJSDelegates29(QuickJS.ScriptDelegate fn, UnityEditor.Editor obj)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = Values.js_push_classvalue(ctx, obj);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
        }
#endif
        [QuickJS.JSDelegateAttribute(typeof(Example.WithByRefParametersCallback))]
        public static unsafe int _QuickJSDelegates30(QuickJS.ScriptDelegate fn, int b, ref int a, out int v)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[3];
            argv[0] = QuickJS.Binding.Values.js_push_primitive(ctx, b);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = JSApi.JS_NewObject(ctx);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var context = ScriptEngine.GetContext(ctx);
            JSApi.JS_SetProperty(ctx, argv[1], context.GetAtom("value"), QuickJS.Binding.Values.js_push_primitive(ctx, a));
            argv[2] = JSApi.JS_NewObject(ctx);
            if (argv[2].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 3, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                JSApi.JS_FreeValue(ctx, argv[2]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var refVal1 = Values.js_read_wrap(ctx, argv[1]);
            if (refVal1.IsException())
            {
                JSApi.JS_FreeValue(ctx, rval);
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                JSApi.JS_FreeValue(ctx, argv[2]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            if (!QuickJS.Binding.Values.js_get_primitive(ctx, refVal1, out a))
            {
                JSApi.JS_FreeValue(ctx, rval);
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                JSApi.JS_FreeValue(ctx, argv[2]);
                JSApi.JS_FreeValue(ctx, refVal1);
                throw new ParameterException(typeof(_QuickJSDelegates), "_QuickJSDelegates30", typeof(int), 1);
            }
            JSApi.JS_FreeValue(ctx, refVal1);
            var refVal2 = Values.js_read_wrap(ctx, argv[2]);
            if (refVal2.IsException())
            {
                JSApi.JS_FreeValue(ctx, rval);
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                JSApi.JS_FreeValue(ctx, argv[2]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            if (!QuickJS.Binding.Values.js_get_primitive(ctx, refVal2, out v))
            {
                JSApi.JS_FreeValue(ctx, rval);
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                JSApi.JS_FreeValue(ctx, argv[2]);
                JSApi.JS_FreeValue(ctx, refVal2);
                throw new ParameterException(typeof(_QuickJSDelegates), "_QuickJSDelegates30", typeof(int), 2);
            }
            JSApi.JS_FreeValue(ctx, refVal2);
            int ret0;
            var succ = QuickJS.Binding.Values.js_get_primitive(ctx, rval, out ret0);
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
            JSApi.JS_FreeValue(ctx, argv[2]);
            if (succ)
            {
                return ret0;
            }
            else
            {
                throw new System.Exception("js exception caught");
            }
        }
        [QuickJS.JSDelegateAttribute(typeof(Example.WithByRefParametersCallback2))]
        public static unsafe void _QuickJSDelegates31(QuickJS.ScriptDelegate fn, ref UnityEngine.Vector3 v)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = JSApi.JS_NewObject(ctx);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var context = ScriptEngine.GetContext(ctx);
            JSApi.JS_SetProperty(ctx, argv[0], context.GetAtom("value"), QuickJS.Binding.Values.js_push_structvalue(ctx, v));
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var refVal0 = Values.js_read_wrap(ctx, argv[0]);
            if (refVal0.IsException())
            {
                JSApi.JS_FreeValue(ctx, rval);
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, refVal0, out v))
            {
                JSApi.JS_FreeValue(ctx, rval);
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, refVal0);
                throw new ParameterException(typeof(_QuickJSDelegates), "_QuickJSDelegates31", typeof(UnityEngine.Vector3), 0);
            }
            JSApi.JS_FreeValue(ctx, refVal0);
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
        }
        [QuickJS.JSDelegateAttribute(typeof(System.Action<string, float, int>))]
        public static unsafe void _QuickJSDelegates32(QuickJS.ScriptDelegate fn, string arg1, float arg2, int arg3)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[3];
            argv[0] = QuickJS.Binding.Values.js_push_primitive(ctx, arg1);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = QuickJS.Binding.Values.js_push_primitive(ctx, arg2);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[2] = QuickJS.Binding.Values.js_push_primitive(ctx, arg3);
            if (argv[2].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 3, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                JSApi.JS_FreeValue(ctx, argv[2]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
            JSApi.JS_FreeValue(ctx, argv[2]);
        }
        [QuickJS.JSDelegateAttribute(typeof(System.Func<int, int>))]
        public static unsafe int _QuickJSDelegates33(QuickJS.ScriptDelegate fn, int arg)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = QuickJS.Binding.Values.js_push_primitive(ctx, arg);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            int ret0;
            var succ = QuickJS.Binding.Values.js_get_primitive(ctx, rval, out ret0);
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            if (succ)
            {
                return ret0;
            }
            else
            {
                throw new System.Exception("js exception caught");
            }
        }
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(System.Func<UnityEditor.BuildPlayerOptions, UnityEditor.BuildPlayerOptions>))]
        public static unsafe UnityEditor.BuildPlayerOptions _QuickJSDelegates34(QuickJS.ScriptDelegate fn, UnityEditor.BuildPlayerOptions arg)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = Values.js_push_structvalue(ctx, arg);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            UnityEditor.BuildPlayerOptions ret0;
            var succ = Values.js_get_structvalue(ctx, rval, out ret0);
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            if (succ)
            {
                return ret0;
            }
            else
            {
                throw new System.Exception("js exception caught");
            }
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(System.Action<UnityEditor.BuildPlayerOptions>))]
        public static unsafe void _QuickJSDelegates35(QuickJS.ScriptDelegate fn, UnityEditor.BuildPlayerOptions obj)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = Values.js_push_structvalue(ctx, obj);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.MaterialProperty.ApplyPropertyCallback))]
        public static unsafe bool _QuickJSDelegates36(QuickJS.ScriptDelegate fn, UnityEditor.MaterialProperty prop, int changeMask, object previousValue)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[3];
            argv[0] = Values.js_push_classvalue(ctx, prop);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = QuickJS.Binding.Values.js_push_primitive(ctx, changeMask);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[2] = QuickJS.Binding.Values.js_push_object(ctx, previousValue);
            if (argv[2].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 3, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                JSApi.JS_FreeValue(ctx, argv[2]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            bool ret0;
            var succ = QuickJS.Binding.Values.js_get_primitive(ctx, rval, out ret0);
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
            JSApi.JS_FreeValue(ctx, argv[2]);
            if (succ)
            {
                return ret0;
            }
            else
            {
                throw new System.Exception("js exception caught");
            }
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.Undo.PostprocessModifications))]
        public static unsafe UnityEditor.UndoPropertyModification[] _QuickJSDelegates37(QuickJS.ScriptDelegate fn, UnityEditor.UndoPropertyModification[] modifications)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = Values.js_push_classvalue(ctx, modifications);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            UnityEditor.UndoPropertyModification[] ret0;
            var succ = Values.js_get_structvalue(ctx, rval, out ret0);
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            if (succ)
            {
                return ret0;
            }
            else
            {
                throw new System.Exception("js exception caught");
            }
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.AnimationUtility.OnCurveWasModified))]
        public static unsafe void _QuickJSDelegates38(QuickJS.ScriptDelegate fn, UnityEngine.AnimationClip clip, UnityEditor.EditorCurveBinding binding, UnityEditor.AnimationUtility.CurveModifiedType type)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[3];
            argv[0] = Values.js_push_classvalue(ctx, clip);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = Values.js_push_structvalue(ctx, binding);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[2] = QuickJS.Binding.Values.js_push_primitive(ctx, (int)type);
            if (argv[2].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 3, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                JSApi.JS_FreeValue(ctx, argv[2]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
            JSApi.JS_FreeValue(ctx, argv[2]);
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.AudioCurveRendering.AudioCurveEvaluator))]
        public static unsafe float _QuickJSDelegates39(QuickJS.ScriptDelegate fn, float x)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = QuickJS.Binding.Values.js_push_primitive(ctx, x);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            float ret0;
            var succ = QuickJS.Binding.Values.js_get_primitive(ctx, rval, out ret0);
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            if (succ)
            {
                return ret0;
            }
            else
            {
                throw new System.Exception("js exception caught");
            }
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.AudioCurveRendering.AudioCurveAndColorEvaluator))]
        public static unsafe float _QuickJSDelegates40(QuickJS.ScriptDelegate fn, float x, out UnityEngine.Color col)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = QuickJS.Binding.Values.js_push_primitive(ctx, x);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = JSApi.JS_NewObject(ctx);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var refVal1 = Values.js_read_wrap(ctx, argv[1]);
            if (refVal1.IsException())
            {
                JSApi.JS_FreeValue(ctx, rval);
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, refVal1, out col))
            {
                JSApi.JS_FreeValue(ctx, rval);
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                JSApi.JS_FreeValue(ctx, refVal1);
                throw new ParameterException(typeof(_QuickJSDelegates), "_QuickJSDelegates40", typeof(UnityEngine.Color), 1);
            }
            JSApi.JS_FreeValue(ctx, refVal1);
            float ret0;
            var succ = QuickJS.Binding.Values.js_get_primitive(ctx, rval, out ret0);
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
            if (succ)
            {
                return ret0;
            }
            else
            {
                throw new System.Exception("js exception caught");
            }
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.AudioCurveRendering.AudioMinMaxCurveAndColorEvaluator))]
        public static unsafe void _QuickJSDelegates41(QuickJS.ScriptDelegate fn, float x, out UnityEngine.Color col, out float minValue, out float maxValue)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[4];
            argv[0] = QuickJS.Binding.Values.js_push_primitive(ctx, x);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = JSApi.JS_NewObject(ctx);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[2] = JSApi.JS_NewObject(ctx);
            if (argv[2].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[3] = JSApi.JS_NewObject(ctx);
            if (argv[3].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                JSApi.JS_FreeValue(ctx, argv[2]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 4, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                JSApi.JS_FreeValue(ctx, argv[2]);
                JSApi.JS_FreeValue(ctx, argv[3]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var refVal1 = Values.js_read_wrap(ctx, argv[1]);
            if (refVal1.IsException())
            {
                JSApi.JS_FreeValue(ctx, rval);
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                JSApi.JS_FreeValue(ctx, argv[2]);
                JSApi.JS_FreeValue(ctx, argv[3]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            if (!QuickJS.Binding.Values.js_get_structvalue(ctx, refVal1, out col))
            {
                JSApi.JS_FreeValue(ctx, rval);
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                JSApi.JS_FreeValue(ctx, argv[2]);
                JSApi.JS_FreeValue(ctx, argv[3]);
                JSApi.JS_FreeValue(ctx, refVal1);
                throw new ParameterException(typeof(_QuickJSDelegates), "_QuickJSDelegates41", typeof(UnityEngine.Color), 1);
            }
            JSApi.JS_FreeValue(ctx, refVal1);
            var refVal2 = Values.js_read_wrap(ctx, argv[2]);
            if (refVal2.IsException())
            {
                JSApi.JS_FreeValue(ctx, rval);
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                JSApi.JS_FreeValue(ctx, argv[2]);
                JSApi.JS_FreeValue(ctx, argv[3]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            if (!QuickJS.Binding.Values.js_get_primitive(ctx, refVal2, out minValue))
            {
                JSApi.JS_FreeValue(ctx, rval);
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                JSApi.JS_FreeValue(ctx, argv[2]);
                JSApi.JS_FreeValue(ctx, argv[3]);
                JSApi.JS_FreeValue(ctx, refVal2);
                throw new ParameterException(typeof(_QuickJSDelegates), "_QuickJSDelegates41", typeof(float), 2);
            }
            JSApi.JS_FreeValue(ctx, refVal2);
            var refVal3 = Values.js_read_wrap(ctx, argv[3]);
            if (refVal3.IsException())
            {
                JSApi.JS_FreeValue(ctx, rval);
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                JSApi.JS_FreeValue(ctx, argv[2]);
                JSApi.JS_FreeValue(ctx, argv[3]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            if (!QuickJS.Binding.Values.js_get_primitive(ctx, refVal3, out maxValue))
            {
                JSApi.JS_FreeValue(ctx, rval);
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                JSApi.JS_FreeValue(ctx, argv[2]);
                JSApi.JS_FreeValue(ctx, argv[3]);
                JSApi.JS_FreeValue(ctx, refVal3);
                throw new ParameterException(typeof(_QuickJSDelegates), "_QuickJSDelegates41", typeof(float), 3);
            }
            JSApi.JS_FreeValue(ctx, refVal3);
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
            JSApi.JS_FreeValue(ctx, argv[2]);
            JSApi.JS_FreeValue(ctx, argv[3]);
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.CommandHandler))]
        public static unsafe void _QuickJSDelegates42(QuickJS.ScriptDelegate fn, UnityEditor.CommandExecuteContext context)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = Values.js_push_classvalue(ctx, context);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(System.Action<UnityEditor.ModeService.ModeChangedArgs>))]
        public static unsafe void _QuickJSDelegates43(QuickJS.ScriptDelegate fn, UnityEditor.ModeService.ModeChangedArgs obj)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = Values.js_push_structvalue(ctx, obj);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
        }
#endif
        [QuickJS.JSDelegateAttribute(typeof(System.Func<UnityEngine.Object[]>))]
        public static unsafe UnityEngine.Object[] _QuickJSDelegates44(QuickJS.ScriptDelegate fn)
        {
            var ctx = fn.ctx;
            var rval = fn.Invoke(ctx);
            if (rval.IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            UnityEngine.Object[] ret0;
            var succ = Values.js_get_classvalue(ctx, rval, out ret0);
            JSApi.JS_FreeValue(ctx, rval);
            if (succ)
            {
                return ret0;
            }
            else
            {
                throw new System.Exception("js exception caught");
            }
        }
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(System.Func<UnityEditor.LightingExplorerTableColumn[]>))]
        public static unsafe UnityEditor.LightingExplorerTableColumn[] _QuickJSDelegates45(QuickJS.ScriptDelegate fn)
        {
            var ctx = fn.ctx;
            var rval = fn.Invoke(ctx);
            if (rval.IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            UnityEditor.LightingExplorerTableColumn[] ret0;
            var succ = Values.js_get_classvalue(ctx, rval, out ret0);
            JSApi.JS_FreeValue(ctx, rval);
            if (succ)
            {
                return ret0;
            }
            else
            {
                throw new System.Exception("js exception caught");
            }
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.LightingExplorerTableColumn.OnGUIDelegate))]
        public static unsafe void _QuickJSDelegates46(QuickJS.ScriptDelegate fn, UnityEngine.Rect r, UnityEditor.SerializedProperty prop, UnityEditor.SerializedProperty[] dependencies)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[3];
            argv[0] = QuickJS.Binding.Values.js_push_structvalue(ctx, r);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = Values.js_push_classvalue(ctx, prop);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[2] = Values.js_push_classvalue(ctx, dependencies);
            if (argv[2].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 3, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                JSApi.JS_FreeValue(ctx, argv[2]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
            JSApi.JS_FreeValue(ctx, argv[2]);
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.LightingExplorerTableColumn.ComparePropertiesDelegate))]
        public static unsafe int _QuickJSDelegates47(QuickJS.ScriptDelegate fn, UnityEditor.SerializedProperty lhs, UnityEditor.SerializedProperty rhs)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = Values.js_push_classvalue(ctx, lhs);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = Values.js_push_classvalue(ctx, rhs);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            int ret0;
            var succ = QuickJS.Binding.Values.js_get_primitive(ctx, rval, out ret0);
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
            if (succ)
            {
                return ret0;
            }
            else
            {
                throw new System.Exception("js exception caught");
            }
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.LightingExplorerTableColumn.CopyPropertiesDelegate))]
        public static unsafe void _QuickJSDelegates48(QuickJS.ScriptDelegate fn, UnityEditor.SerializedProperty target, UnityEditor.SerializedProperty source)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = Values.js_push_classvalue(ctx, target);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = Values.js_push_classvalue(ctx, source);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
        }
#endif
        [QuickJS.JSDelegateAttribute(typeof(System.Action<string, UnityEngine.UIElements.VisualElement>))]
        public static unsafe void _QuickJSDelegates49(QuickJS.ScriptDelegate fn, string arg1, UnityEngine.UIElements.VisualElement arg2)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = QuickJS.Binding.Values.js_push_primitive(ctx, arg1);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = Values.js_push_classvalue(ctx, arg2);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
        }
        [QuickJS.JSDelegateAttribute(typeof(System.Func<string, bool>))]
        public static unsafe bool _QuickJSDelegates50(QuickJS.ScriptDelegate fn, string arg)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = QuickJS.Binding.Values.js_push_primitive(ctx, arg);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            bool ret0;
            var succ = QuickJS.Binding.Values.js_get_primitive(ctx, rval, out ret0);
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            if (succ)
            {
                return ret0;
            }
            else
            {
                throw new System.Exception("js exception caught");
            }
        }
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(System.Func<UnityEditor.Editor>))]
        public static unsafe UnityEditor.Editor _QuickJSDelegates51(QuickJS.ScriptDelegate fn)
        {
            var ctx = fn.ctx;
            var rval = fn.Invoke(ctx);
            if (rval.IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            UnityEditor.Editor ret0;
            var succ = Values.js_get_classvalue(ctx, rval, out ret0);
            JSApi.JS_FreeValue(ctx, rval);
            if (succ)
            {
                return ret0;
            }
            else
            {
                throw new System.Exception("js exception caught");
            }
        }
#endif
        [QuickJS.JSDelegateAttribute(typeof(System.Func<UnityEngine.Object>))]
        public static unsafe UnityEngine.Object _QuickJSDelegates52(QuickJS.ScriptDelegate fn)
        {
            var ctx = fn.ctx;
            var rval = fn.Invoke(ctx);
            if (rval.IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            UnityEngine.Object ret0;
            var succ = Values.js_get_classvalue(ctx, rval, out ret0);
            JSApi.JS_FreeValue(ctx, rval);
            if (succ)
            {
                return ret0;
            }
            else
            {
                throw new System.Exception("js exception caught");
            }
        }
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.PluginImporter.IncludeInBuildDelegate))]
        public static unsafe bool _QuickJSDelegates53(QuickJS.ScriptDelegate fn, string path)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = QuickJS.Binding.Values.js_push_primitive(ctx, path);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            bool ret0;
            var succ = QuickJS.Binding.Values.js_get_primitive(ctx, rval, out ret0);
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            if (succ)
            {
                return ret0;
            }
            else
            {
                throw new System.Exception("js exception caught");
            }
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.Hardware.Usb.OnDevicesChangedHandler))]
        public static unsafe void _QuickJSDelegates54(QuickJS.ScriptDelegate fn, UnityEditor.Hardware.UsbDevice[] devices)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = Values.js_push_classvalue(ctx, devices);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.Analytics.AnalyticsSettings.RequireInBuildDelegate))]
        public static unsafe bool _QuickJSDelegates55(QuickJS.ScriptDelegate fn)
        {
            var ctx = fn.ctx;
            var rval = fn.Invoke(ctx);
            if (rval.IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            bool ret0;
            var succ = QuickJS.Binding.Values.js_get_primitive(ctx, rval, out ret0);
            JSApi.JS_FreeValue(ctx, rval);
            if (succ)
            {
                return ret0;
            }
            else
            {
                throw new System.Exception("js exception caught");
            }
        }
#endif
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.Events.UnityAction<float>))]
        public static unsafe void _QuickJSDelegates56(QuickJS.ScriptDelegate fn, float arg0)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = QuickJS.Binding.Values.js_push_primitive(ctx, arg0);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
        }
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(System.Action<UnityEditor.Connect.UnityOAuth.AuthCodeResponse>))]
        public static unsafe void _QuickJSDelegates57(QuickJS.ScriptDelegate fn, UnityEditor.Connect.UnityOAuth.AuthCodeResponse obj)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = Values.js_push_structvalue(ctx, obj);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
        }
#endif
        [QuickJS.JSDelegateAttribute(typeof(System.Action<UnityEngine.Playables.PlayableGraph>))]
        public static unsafe void _QuickJSDelegates58(QuickJS.ScriptDelegate fn, UnityEngine.Playables.PlayableGraph obj)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = Values.js_push_structvalue(ctx, obj);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
        }
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.Handles.SizeFunction))]
        public static unsafe float _QuickJSDelegates59(QuickJS.ScriptDelegate fn, UnityEngine.Vector3 position)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = QuickJS.Binding.Values.js_push_structvalue(ctx, position);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            float ret0;
            var succ = QuickJS.Binding.Values.js_get_primitive(ctx, rval, out ret0);
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            if (succ)
            {
                return ret0;
            }
            else
            {
                throw new System.Exception("js exception caught");
            }
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.IMGUI.Controls.MultiColumnHeader.HeaderCallback))]
        public static unsafe void _QuickJSDelegates60(QuickJS.ScriptDelegate fn, UnityEditor.IMGUI.Controls.MultiColumnHeader multiColumnHeader)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = Values.js_push_classvalue(ctx, multiColumnHeader);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
        }
#endif
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>))]
        public static unsafe void _QuickJSDelegates61(QuickJS.ScriptDelegate fn, UnityEngine.SceneManagement.Scene arg0, UnityEngine.SceneManagement.Scene arg1)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = Values.js_push_structvalue(ctx, arg0);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = Values.js_push_structvalue(ctx, arg1);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
        }
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.SceneManagement.EditorSceneManager.NewSceneCreatedCallback))]
        public static unsafe void _QuickJSDelegates62(QuickJS.ScriptDelegate fn, UnityEngine.SceneManagement.Scene scene, UnityEditor.SceneManagement.NewSceneSetup setup, UnityEditor.SceneManagement.NewSceneMode mode)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[3];
            argv[0] = Values.js_push_structvalue(ctx, scene);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = QuickJS.Binding.Values.js_push_primitive(ctx, (int)setup);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[2] = QuickJS.Binding.Values.js_push_primitive(ctx, (int)mode);
            if (argv[2].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 3, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                JSApi.JS_FreeValue(ctx, argv[2]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
            JSApi.JS_FreeValue(ctx, argv[2]);
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.SceneManagement.EditorSceneManager.SceneOpeningCallback))]
        public static unsafe void _QuickJSDelegates63(QuickJS.ScriptDelegate fn, string path, UnityEditor.SceneManagement.OpenSceneMode mode)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = QuickJS.Binding.Values.js_push_primitive(ctx, path);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = QuickJS.Binding.Values.js_push_primitive(ctx, (int)mode);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.SceneManagement.EditorSceneManager.SceneOpenedCallback))]
        public static unsafe void _QuickJSDelegates64(QuickJS.ScriptDelegate fn, UnityEngine.SceneManagement.Scene scene, UnityEditor.SceneManagement.OpenSceneMode mode)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = Values.js_push_structvalue(ctx, scene);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = QuickJS.Binding.Values.js_push_primitive(ctx, (int)mode);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.SceneManagement.EditorSceneManager.SceneClosingCallback))]
        public static unsafe void _QuickJSDelegates65(QuickJS.ScriptDelegate fn, UnityEngine.SceneManagement.Scene scene, bool removingScene)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = Values.js_push_structvalue(ctx, scene);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = QuickJS.Binding.Values.js_push_primitive(ctx, removingScene);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.SceneManagement.EditorSceneManager.SceneClosedCallback))]
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.SceneManagement.EditorSceneManager.SceneSavedCallback))]
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.SceneManagement.EditorSceneManager.SceneDirtiedCallback))]
        public static unsafe void _QuickJSDelegates66(QuickJS.ScriptDelegate fn, UnityEngine.SceneManagement.Scene scene)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = Values.js_push_structvalue(ctx, scene);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(UnityEditor.SceneManagement.EditorSceneManager.SceneSavingCallback))]
        public static unsafe void _QuickJSDelegates67(QuickJS.ScriptDelegate fn, UnityEngine.SceneManagement.Scene scene, string path)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = Values.js_push_structvalue(ctx, scene);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = QuickJS.Binding.Values.js_push_primitive(ctx, path);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
        }
#endif
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>))]
        public static unsafe void _QuickJSDelegates68(QuickJS.ScriptDelegate fn, UnityEngine.SceneManagement.Scene arg0, UnityEngine.SceneManagement.LoadSceneMode arg1)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = Values.js_push_structvalue(ctx, arg0);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = QuickJS.Binding.Values.js_push_primitive(ctx, (int)arg1);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
        }
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>))]
        public static unsafe void _QuickJSDelegates69(QuickJS.ScriptDelegate fn, UnityEngine.SceneManagement.Scene arg0)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = Values.js_push_structvalue(ctx, arg0);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
        }
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(System.Func<UnityEditor.SceneManagement.SceneHierarchyHooks.SubSceneInfo[]>))]
        public static unsafe UnityEditor.SceneManagement.SceneHierarchyHooks.SubSceneInfo[] _QuickJSDelegates70(QuickJS.ScriptDelegate fn)
        {
            var ctx = fn.ctx;
            var rval = fn.Invoke(ctx);
            if (rval.IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            UnityEditor.SceneManagement.SceneHierarchyHooks.SubSceneInfo[] ret0;
            var succ = Values.js_get_structvalue(ctx, rval, out ret0);
            JSApi.JS_FreeValue(ctx, rval);
            if (succ)
            {
                return ret0;
            }
            else
            {
                throw new System.Exception("js exception caught");
            }
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(System.Func<UnityEditor.SceneManagement.SceneHierarchyHooks.SubSceneInfo, string>))]
        public static unsafe string _QuickJSDelegates71(QuickJS.ScriptDelegate fn, UnityEditor.SceneManagement.SceneHierarchyHooks.SubSceneInfo arg)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = Values.js_push_structvalue(ctx, arg);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            string ret0;
            var succ = QuickJS.Binding.Values.js_get_primitive(ctx, rval, out ret0);
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            if (succ)
            {
                return ret0;
            }
            else
            {
                throw new System.Exception("js exception caught");
            }
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(System.Action<UnityEditor.GenericMenu, UnityEngine.GameObject>))]
        public static unsafe void _QuickJSDelegates72(QuickJS.ScriptDelegate fn, UnityEditor.GenericMenu arg1, UnityEngine.GameObject arg2)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = Values.js_push_classvalue(ctx, arg1);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = Values.js_push_classvalue(ctx, arg2);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
        }
#endif
#if UNITY_EDITOR
        [QuickJS.JSDelegateAttribute(typeof(System.Action<UnityEditor.GenericMenu, UnityEngine.SceneManagement.Scene>))]
        public static unsafe void _QuickJSDelegates73(QuickJS.ScriptDelegate fn, UnityEditor.GenericMenu arg1, UnityEngine.SceneManagement.Scene arg2)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = Values.js_push_classvalue(ctx, arg1);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = Values.js_push_structvalue(ctx, arg2);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
        }
#endif
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.UI.InputField.OnValidateInput))]
        public static unsafe char _QuickJSDelegates74(QuickJS.ScriptDelegate fn, string text, int charIndex, char addedChar)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[3];
            argv[0] = QuickJS.Binding.Values.js_push_primitive(ctx, text);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = QuickJS.Binding.Values.js_push_primitive(ctx, charIndex);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[2] = QuickJS.Binding.Values.js_push_primitive(ctx, addedChar);
            if (argv[2].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 3, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                JSApi.JS_FreeValue(ctx, argv[2]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            char ret0;
            var succ = QuickJS.Binding.Values.js_get_primitive(ctx, rval, out ret0);
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
            JSApi.JS_FreeValue(ctx, argv[2]);
            if (succ)
            {
                return ret0;
            }
            else
            {
                throw new System.Exception("js exception caught");
            }
        }
        [QuickJS.JSDelegateAttribute(typeof(System.Func<UnityEngine.UI.ILayoutElement, float>))]
        public static unsafe float _QuickJSDelegates75(QuickJS.ScriptDelegate fn, UnityEngine.UI.ILayoutElement arg)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = Values.js_push_classvalue(ctx, arg);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            float ret0;
            var succ = QuickJS.Binding.Values.js_get_primitive(ctx, rval, out ret0);
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            if (succ)
            {
                return ret0;
            }
            else
            {
                throw new System.Exception("js exception caught");
            }
        }
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler>))]
        public static unsafe void _QuickJSDelegates76(QuickJS.ScriptDelegate fn, UnityEngine.EventSystems.IPointerEnterHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = Values.js_push_classvalue(ctx, handler);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = Values.js_push_classvalue(ctx, eventData);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
        }
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler>))]
        public static unsafe void _QuickJSDelegates77(QuickJS.ScriptDelegate fn, UnityEngine.EventSystems.IPointerExitHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = Values.js_push_classvalue(ctx, handler);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = Values.js_push_classvalue(ctx, eventData);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
        }
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler>))]
        public static unsafe void _QuickJSDelegates78(QuickJS.ScriptDelegate fn, UnityEngine.EventSystems.IPointerDownHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = Values.js_push_classvalue(ctx, handler);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = Values.js_push_classvalue(ctx, eventData);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
        }
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler>))]
        public static unsafe void _QuickJSDelegates79(QuickJS.ScriptDelegate fn, UnityEngine.EventSystems.IPointerUpHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = Values.js_push_classvalue(ctx, handler);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = Values.js_push_classvalue(ctx, eventData);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
        }
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler>))]
        public static unsafe void _QuickJSDelegates80(QuickJS.ScriptDelegate fn, UnityEngine.EventSystems.IPointerClickHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = Values.js_push_classvalue(ctx, handler);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = Values.js_push_classvalue(ctx, eventData);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
        }
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler>))]
        public static unsafe void _QuickJSDelegates81(QuickJS.ScriptDelegate fn, UnityEngine.EventSystems.IInitializePotentialDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = Values.js_push_classvalue(ctx, handler);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = Values.js_push_classvalue(ctx, eventData);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
        }
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler>))]
        public static unsafe void _QuickJSDelegates82(QuickJS.ScriptDelegate fn, UnityEngine.EventSystems.IBeginDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = Values.js_push_classvalue(ctx, handler);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = Values.js_push_classvalue(ctx, eventData);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
        }
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler>))]
        public static unsafe void _QuickJSDelegates83(QuickJS.ScriptDelegate fn, UnityEngine.EventSystems.IDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = Values.js_push_classvalue(ctx, handler);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = Values.js_push_classvalue(ctx, eventData);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
        }
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler>))]
        public static unsafe void _QuickJSDelegates84(QuickJS.ScriptDelegate fn, UnityEngine.EventSystems.IEndDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = Values.js_push_classvalue(ctx, handler);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = Values.js_push_classvalue(ctx, eventData);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
        }
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler>))]
        public static unsafe void _QuickJSDelegates85(QuickJS.ScriptDelegate fn, UnityEngine.EventSystems.IDropHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = Values.js_push_classvalue(ctx, handler);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = Values.js_push_classvalue(ctx, eventData);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
        }
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler>))]
        public static unsafe void _QuickJSDelegates86(QuickJS.ScriptDelegate fn, UnityEngine.EventSystems.IScrollHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = Values.js_push_classvalue(ctx, handler);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = Values.js_push_classvalue(ctx, eventData);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
        }
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler>))]
        public static unsafe void _QuickJSDelegates87(QuickJS.ScriptDelegate fn, UnityEngine.EventSystems.IUpdateSelectedHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = Values.js_push_classvalue(ctx, handler);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = Values.js_push_classvalue(ctx, eventData);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
        }
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler>))]
        public static unsafe void _QuickJSDelegates88(QuickJS.ScriptDelegate fn, UnityEngine.EventSystems.ISelectHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = Values.js_push_classvalue(ctx, handler);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = Values.js_push_classvalue(ctx, eventData);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
        }
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler>))]
        public static unsafe void _QuickJSDelegates89(QuickJS.ScriptDelegate fn, UnityEngine.EventSystems.IDeselectHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = Values.js_push_classvalue(ctx, handler);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = Values.js_push_classvalue(ctx, eventData);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
        }
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler>))]
        public static unsafe void _QuickJSDelegates90(QuickJS.ScriptDelegate fn, UnityEngine.EventSystems.IMoveHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = Values.js_push_classvalue(ctx, handler);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = Values.js_push_classvalue(ctx, eventData);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
        }
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler>))]
        public static unsafe void _QuickJSDelegates91(QuickJS.ScriptDelegate fn, UnityEngine.EventSystems.ISubmitHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = Values.js_push_classvalue(ctx, handler);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = Values.js_push_classvalue(ctx, eventData);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
        }
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler>))]
        public static unsafe void _QuickJSDelegates92(QuickJS.ScriptDelegate fn, UnityEngine.EventSystems.ICancelHandler handler, UnityEngine.EventSystems.BaseEventData eventData)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[2];
            argv[0] = Values.js_push_classvalue(ctx, handler);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            argv[1] = Values.js_push_classvalue(ctx, eventData);
            if (argv[1].IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 2, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                JSApi.JS_FreeValue(ctx, argv[1]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
            JSApi.JS_FreeValue(ctx, argv[1]);
        }
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.Events.UnityAction<UnityEngine.Vector2>))]
        public static unsafe void _QuickJSDelegates93(QuickJS.ScriptDelegate fn, UnityEngine.Vector2 arg0)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = QuickJS.Binding.Values.js_push_structvalue(ctx, arg0);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
        }
        [QuickJS.JSDelegateAttribute(typeof(UnityEngine.Events.UnityAction<UnityEngine.EventSystems.BaseEventData>))]
        public static unsafe void _QuickJSDelegates94(QuickJS.ScriptDelegate fn, UnityEngine.EventSystems.BaseEventData arg0)
        {
            var ctx = fn.ctx;
            var argv = stackalloc JSValue[1];
            argv[0] = Values.js_push_classvalue(ctx, arg0);
            if (argv[0].IsException())
            {
                throw new System.Exception(ctx.GetExceptionString());
            }
            var rval = fn.Invoke(ctx, 1, argv);
            if (rval.IsException())
            {
                JSApi.JS_FreeValue(ctx, argv[0]);
                throw new System.Exception(ctx.GetExceptionString());
            }
            JSApi.JS_FreeValue(ctx, rval);
            JSApi.JS_FreeValue(ctx, argv[0]);
        }
        public static void Bind(QuickJS.ScriptRuntime runtime)
        {
            var type = typeof(_QuickJSDelegates);
            var typeDB = runtime.GetTypeDB();
            var methods = type.GetMethods(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
            for (int i = 0, size = methods.Length; i < size; i++)
            {
                var method = methods[i];
                var attributes = method.GetCustomAttributes(typeof(JSDelegateAttribute), false);
                var attributesLength = attributes.Length;
                if (attributesLength > 0)
                {
                    for (var a = 0; a < attributesLength; a++)
                    {
                        var attribute = attributes[a] as JSDelegateAttribute;
                        typeDB.AddDelegate(attribute.target, method);
                    }
                }
            }
        }
    }
}
#endif
