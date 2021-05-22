using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MenuItems
{
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
    
    // [MenuItem("CONTEXT/LevelScript/ResetLevel")]
    // public static void ResetLevel()
    // {
    //     Debug.Log("Reset Level");
    // }
}
