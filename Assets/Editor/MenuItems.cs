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

    [MenuItem("OrderedMenu/Option1", false, 1)]
    public static void Option1()
    {
        Debug.Log("You pressed option 1");
    }

    [MenuItem("OrderedMenu/Option2", false, 2)]
    public static void Option2()
    {
        Debug.Log("You pressed option 2");
    }

    // Menus group by 50, so this creates a new group in the menu
    [MenuItem("OrderedMenu/Option3", false, 51)]
    public static void Option3()
    {
        Debug.Log("You pressed option 3");
    }

    [MenuItem("OrderedMenu/Option4", false, 52)]
    public static void Option4()
    {
        Debug.Log("You pressed option 4");
    }

    // This creates a third group
    [MenuItem("OrderedMenu/Option5", false, 101)]
    public static void Option5()
    {
        Debug.Log("You pressed option 5");
    }
}
