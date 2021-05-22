using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScript : MonoBehaviour
{
    [SerializeField] private int experience;
    
    public int Level => experience / 750;

    public void ResetLevel()
    {
        experience = 0;
    }
}
