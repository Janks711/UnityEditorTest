using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/// <summary>
/// This is a script following the unity Tutorial for basic editor scripting
/// URL - https://learn.unity.com/tutorial/introduction-to-editor-scripting#
/// </summary>

public class EditorScripting : EditorWindow
{
    // Test variables
    private string custString = "String Here";
    private bool groupEnabled;
    private bool optionalSettings = true;
    private float jumpMod = 0.1f;
    private float impactMod = 0.5f;
    
    [MenuItem("Window / Test Window")] // This line adds "Test Menu" to the Window menu within Unity
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(EditorScripting)); // Creates the Window, with all inherited functions from base menus.
    }
    private void OnGUI()
    {
        // On GUI Method contents
        GUILayout.Label("Base Settings", EditorStyles.boldLabel);
        custString = EditorGUILayout.TextField("Text Field", custString);

        groupEnabled = EditorGUILayout.BeginToggleGroup("Optional Settings", groupEnabled);
        optionalSettings = EditorGUILayout.Toggle("Double Jump Enabled", optionalSettings);
        jumpMod = EditorGUILayout.Slider("Jump Modifier", jumpMod, -5, 5);
        impactMod = EditorGUILayout.Slider("Impact Modifier", impactMod, -5, 5);
        EditorGUILayout.EndToggleGroup();
        
        GUI.backgroundColor = Color.red;
        
        GUILayout.FlexibleSpace();
        EditorGUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();
        if (GUILayout.Button("Reset", GUILayout.Width(100), GUILayout.Height(30)))
        {
            custString = "String Here";
            optionalSettings = true;
            jumpMod = 0.1f;
            impactMod = 0.5f;
        }
        EditorGUILayout.EndHorizontal();
    }
}
