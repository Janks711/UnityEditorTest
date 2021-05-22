using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LevelScript : MonoBehaviour
{
    [SerializeField] private int experience;
    
    public int Level => experience / 750;
    
    [ContextMenu("Reset Level")]
    public void ResetLevel()
    {
        experience = 0;
    }
}
