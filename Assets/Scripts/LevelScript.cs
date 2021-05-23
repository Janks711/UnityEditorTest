using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Random = UnityEngine.Random;

public class LevelScript : MonoBehaviour
{
    [ContextMenuItem("Randomize Level", "RandomLevel"),SerializeField] private int experience;
    
    public int Level => experience / 750;

    // Context menu, adds to the menu of the current level script
    
    // By adding context this way we are adjusting the default context menu for the component
    [ContextMenu("Reset Level")]
    public void ResetLevel()
    {
        experience = 0;
    }

    public void AddExperience(int experienceToAdd)
    {
        experience += experienceToAdd;
    }

    private void RandomLevel()
    {
        experience = Random.Range(0, int.MaxValue);
    }
}
