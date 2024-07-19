using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MobileConsole
{
    public class PrefKeys
    {
        public const string PRETEND_PRODUCTION = "gg_PretendProductionMode";
    }

#if DebugLog
    [ExecutableCommand(name = "System/Hide Debug Console, ANDT & FPS")]
    public class HideConsoleCommand : Command
    {
        public bool _permanent = false;
        public bool _clearData = false;

        public override void Execute()
        {
            LogConsole.HideAll();

            if (_clearData)
            {
                DirectoryInfo dir = new DirectoryInfo(Application.persistentDataPath);
                foreach (var file in dir.GetFiles())
                {
                    file.Delete();
                }

                foreach (var directory in dir.GetDirectories())
                {
                    directory.Delete(true);
                }

                PlayerPrefs.DeleteAll();
            }

            if (_permanent)
            {
                PlayerPrefs.SetInt(LogInitializeOnLoad.KEY_PREVENT_AUTO_STARTUP, 1);
                PlayerPrefs.Save();
            }


            if (_clearData)
            {
                Application.Quit();
            }
        }

#if UNITY_EDITOR
        [UnityEditor.MenuItem("Tools/Mobile Console/Show Mobile Console & ANDT", false, 51)]
        public static void EnableMobileConsole()
        {
            PlayerPrefs.SetInt(LogInitializeOnLoad.KEY_PREVENT_AUTO_STARTUP, 0);
            PlayerPrefs.Save();
        }
#endif
    }

    [ExecutableCommand(name = "System/Pretend production environment mode")]
    public class PretendProductionEnvironmentCommand : Command
    {
        // public bool _permanent = false;
        public bool _clearData = false;

        public override void Execute()
        {
            LogConsole.HideAll();

            if (_clearData)
            {
                DirectoryInfo dir = new DirectoryInfo(Application.persistentDataPath);
                foreach (var file in dir.GetFiles())
                {
                    file.Delete();
                }

                foreach (var directory in dir.GetDirectories())
                {
                    directory.Delete(true);
                }

                PlayerPrefs.DeleteAll();
            }

            
            // if (_permanent)
            {
                PlayerPrefs.SetInt(LogInitializeOnLoad.KEY_PREVENT_AUTO_STARTUP, 1);
                PlayerPrefs.SetInt(PrefKeys.PRETEND_PRODUCTION, 1);
                PlayerPrefs.Save();
            }


            if (_clearData)
            {
                Application.Quit();
            }
        }

#if UNITY_EDITOR
        [UnityEditor.MenuItem("Tools/Mobile Console/Restore Debug Environment", false, 51)]
        public static void RestoreDebugEnvironment()
        {
            PlayerPrefs.SetInt(LogInitializeOnLoad.KEY_PREVENT_AUTO_STARTUP, 0);
            PlayerPrefs.SetInt(PrefKeys.PRETEND_PRODUCTION, 0);
            PlayerPrefs.Save();
        }
#endif
    }

#endif
}