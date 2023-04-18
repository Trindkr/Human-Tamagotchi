using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UserStatistics
{
    public float hunger;
    public float thirst;
    public float energy;
    public float fitness;
    public float social;
    public float comfort;

    public UserStatistics(ManageUserStatistics userStats)
    {
        this.hunger = userStats.hunger;
        this.thirst = userStats.thirst;
        this.energy = userStats.energy;
        this.fitness = userStats.fitness;
        this.social = userStats.social;
        this.comfort = userStats.comfort;
    }

}
