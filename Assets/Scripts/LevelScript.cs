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

    public void SetExperience(int experience)
    {
        if (experience >= 0)
        {
            this.experience = experience;
        }
    }
}
