import { Editor, EditorGUILayout, MessageType } from "UnityEditor";
import { GUILayout, Object } from "UnityEngine";
import { RotateBehaviour } from "../../example_monobehaviour";

export class RotateBehaviourInspector extends Editor {
    Awake() {
        console.log("my class inspector class awake");
    }

    OnInspectorGUI() {
        let p = <RotateBehaviour>this.target;

        EditorGUILayout.ObjectField("Object", p.gameObject, Object, true);
        p.rotationSpeed = EditorGUILayout.FloatField("Rotation Speed", p.rotationSpeed);
        if (GUILayout.Button("Reset")) {
            p.Reset();
        }
    }
}