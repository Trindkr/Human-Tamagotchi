using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UserStatistics
{
    public int hunger;
    public int thirst;
    public int energy;
    public int fitness;
    public int social;
    public int comfort;

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
