using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScript : MonoBehaviour
{
    [SerializeField] private int experience;

    public int Experience
    {
        get => experience;
        set => SetExperience(value);
    }
    public int Level => experience / 750;

    private void SetExperience(int experienceToAdd)
    {
        if (experienceToAdd >= 0)
        {
            experience = experienceToAdd;
        }
    }
}
