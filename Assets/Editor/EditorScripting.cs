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
    [MenuItem("Window / Test Window")] // This line adds "Test Menu" to the Window menu within Unity
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(EditorScripting)); // Creates the Window, with all inherited functions from base menus.
    }
    private void OnGUI()
    {
        // On GUI Method contents   
    }
}
