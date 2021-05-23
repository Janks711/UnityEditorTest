using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public class MenuItems
{
    // Hot key commands you can assign to menu items
    // % - Ctrl
    // # - Shift
    // & - Alt
    // LEFT/RIGHT/UP/DOWN - Arrow Keys
    // F1...F12 - F Keys
    // HOME, END, PGUP, PGDN
    
    [MenuItem("Tools/PlayerPrefs/ClearPlayerPrefs %#C")]
    private static void ClearPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }

    [MenuItem("Tools/PlayerPrefs/SavePlayerPrefs %#S")]
    private static void SavePlayerPrefs()
    {
        PlayerPrefs.Save();
    }

    // Add a new menu item that is accessed by right clicking an object in project view
    
    [MenuItem("Assets/Load Additive Scene")]
    public static void LoadAdditiveScene()
    {
        var selected = Selection.activeObject;
        EditorSceneManager.OpenScene(AssetDatabase.GetAssetPath(selected), OpenSceneMode.Additive);
    }
    
    // Adding a new menu item under assets create
    [MenuItem("Assets/Create/Add Config")]
    public static void AddConfiguration()
    {
        // Create new scriptable object for storing config
    }

    // Add a new component that is accessed by right-clicking the Level Script Component
    [MenuItem("CONTEXT/LevelScript/Add Level Config")]
    public static void ResetLevel()
    {
        Debug.Log("Add level");
    }
    
    // Adding a menu item with validation
    [MenuItem("Assets/Process Texture")]
    public static void DoSomethingWithTextures()
    {
        Debug.Log("You broke it");
    }

    // Note we pass the same path, but with an added true argument
    [MenuItem("Assets/Process Texture", true)]
    public static bool ProcessTextureMenuValidation()
    {
        // Returns true if selected object is a texture, otherwise will be greyed out
        return Selection.activeObject is Texture2D;
    }
}
