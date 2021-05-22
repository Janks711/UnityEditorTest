using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LevelScript))] // This will adjust the inspector for the script LevelScript
public class LevelScriptEditor : Editor
{
    public override void OnInspectorGUI()
    {
        LevelScript myLevelScript = (LevelScript)target;
        EditorGUILayout.HelpBox("This will help see the level of the character", MessageType.Info);
        DrawDefaultInspector();
        EditorGUILayout.LabelField("Level", myLevelScript.Level.ToString());
        EditorGUILayout.HelpBox("This will reset the experience to 0", MessageType.Warning);
        if (GUILayout.Button("Reset Level"))
        {
            myLevelScript.ResetLevel();
        }
    }
    
}
