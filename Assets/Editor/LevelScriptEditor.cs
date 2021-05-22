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

        myLevelScript.Experience = EditorGUILayout.IntField("Experience", myLevelScript.Experience);
        EditorGUILayout.LabelField("Level", myLevelScript.Level.ToString());
    }
    
}
