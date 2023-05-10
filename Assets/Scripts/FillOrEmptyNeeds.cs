using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillOrEmptyNeeds : MonoBehaviour
{
    public ManageUserStatistics userStatistics;
    
    public void FillHunger()
    {
        userStatistics.hunger = 100f;
    }

    public void FillThirst()
    {
        userStatistics.thirst = 100f;
    }

    public void FillEnergy()
    {
        userStatistics.energy = 100f;
    }

    public void FillFitness()
    {
        userStatistics.fitness = 100f;
    }

    public void FillSocial()
    {
        userStatistics.social = 100f;
    }

    public void FillComfort()
    {
        userStatistics.comfort = 100f;
    }

    public void EmptyHunger()
    {
        userStatistics.hunger = 0f;
    }

    public void EmptyThirst()
    {
        userStatistics.thirst = 0f;
    }

    public void EmptyEnergy()
    {
        userStatistics.energy = 0f;
    }

    public void EmptyFitness()
    {
        userStatistics.fitness = 0f;
    }

    public void EmptySocial()
    {
        userStatistics.social = 0f;
    }

    public void EmptyComfort()
    {
        userStatistics.comfort = 0f;
    }


}
