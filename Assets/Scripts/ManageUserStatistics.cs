using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageUserStatistics : MonoBehaviour
{
    public float hunger;
    public float thirst;
    public float energy;
    public float fitness;
    public float social;
    public float comfort; //this relates to the temperature of the environment?

    //public ManageStatisticBars manageStatisticBars;

    void Start()
    {
        LoadUserStats();
    
    }

    void Update()
    {
        //update the values of the user statistics 
        //TODO

        if (Input.GetKeyDown(KeyCode.Space))
        {
            hunger -= 10;
            thirst -= 5;
            energy -= 15;
            fitness -= 7;
            social -= 2;
            comfort -= 6;   
            
        }
    }
    

    public void SaveUserStats()
    {
        SaveUserStatistics.SaveUserStats(this);
    }

    public void LoadUserStats()
    {
        UserStatistics loadedStats = SaveUserStatistics.LoadUserStats();
        if (loadedStats != null)
        {
            hunger = loadedStats.hunger;
            thirst = loadedStats.thirst;
            energy = loadedStats.energy;
            fitness = loadedStats.fitness;
            social = loadedStats.social;
            comfort = loadedStats.comfort;
        }
        else
        {
            hunger = 100;
            thirst = 100;
            energy = 100;
            fitness = 100;
            social = 100;
            comfort = 100;
        }
    }
}
