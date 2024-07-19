using System;
using System.IO;
using System.Linq;

namespace Example.Editor {
    using UnityEngine;
    using UnityEditor;

    public class MenuItemsBridge {
        [MenuItem("My Examples/TestBuild")]
        public static void ShowMyEditorWindow() {
            UnityEditor.BuildPipeline.BuildPlayer(new string[] {
                    "Assets/Examples/Scenes/SampleScene.unity",
                    "Assets/Plugins/Mobile Console/Assets/LogConsole.unity",
                },
                "Scripts-build.app", BuildTarget.StandaloneOSX, BuildOptions.Development);
        }
    }
}
