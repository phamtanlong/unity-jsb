using System;
using System.Reflection;

namespace QuickJS.Utils
{
    public interface IBinder
    {
        void Bind(ScriptRuntime runtime);
    }

    public class StaticBinder : IBinder
    {
        public void Bind(ScriptRuntime runtime)
        {
            var logger = runtime.GetLogger();
            var bindAll = typeof(Binding.Values).GetMethod("BindAll", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
            if (bindAll == null)
            {
                if (logger != null)
                {
                    logger.Write(LogLevel.Error, "generate binding code before run, or turn on ReflectBind");
                }
                return;
            }

            var codeGenVersionField = typeof(Binding.Values).GetField("CodeGenVersion");
            if (codeGenVersionField == null || !codeGenVersionField.IsStatic || !codeGenVersionField.IsLiteral || codeGenVersionField.FieldType != typeof(uint))
            {
                if (logger != null)
                {
                    logger.Write(LogLevel.Error, "binding code version mismatch");
                }
                return;
            }

            var codeGenVersion = (uint)codeGenVersionField.GetValue(null);
            if (codeGenVersion != ScriptEngine.VERSION)
            {
                if (logger != null)
                {
                    logger.Write(LogLevel.Warn, "CodeGenVersion: {0} != {1}", codeGenVersion, ScriptEngine.VERSION);
                }
            }

            bindAll.Invoke(null, new object[] { runtime });
        }
    }

    public class ReflectionBinder : IBinder
    {
        public static IBinder GetBinder(bool useReflectBind)
        {
            return useReflectBind ? (IBinder)new ReflectionBinder() : new StaticBinder();
        }

        public void Bind(ScriptRuntime runtime)
        {
#if JSB_UNITYLESS
            var bm = new Binding.BindingManager(new Binding.Prefs(), new Binding.ReflectBindingCallback(runtime));
            bm.Collect();
            bm.Generate(Binding.TypeBindingFlags.None);
            bm.Report();
#else
            var logger = runtime.GetLogger();
            try
            {
                var UnityHelper = Binding.Values.FindType("QuickJS.Unity.UnityHelper");
                if (UnityHelper != null)
                {
                    var IsReflectBindingSupported = UnityHelper.GetMethod("IsReflectBindingSupported");
                    if (IsReflectBindingSupported != null && (bool)IsReflectBindingSupported.Invoke(null, null))
                    {
                        var bindAll = UnityHelper.GetMethod("InvokeReflectBinding");
                        if (bindAll != null)
                        {
                            bindAll.Invoke(null, new object[] { runtime });
                            return;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }

            if (logger != null)
            {
                logger.Write(LogLevel.Error, "failed to get method: UnityHelper.InvokeReflectBinding");
            }
#endif
        }
    }
}