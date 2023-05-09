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
    public float comfort; //this relates to the temperature of the environment? Heart rate maybe?

    public Animator animator;


    //public ManageStatisticBars manageStatisticBars;

    void Start()
    {
        LoadUserStats();
        
        animator.SetFloat("Hunger", 100f);
        animator.SetFloat("Thirst", 100f);
        animator.SetFloat("Energy", 100f);
        animator.SetFloat("Fitness", 100f);
        animator.SetFloat("Social", 100f);
        animator.SetFloat("Comfort", 100f);

    }

    void Update()
    {
        //update the values of the user statistics 
        //TODO
        manageComfort();
        manageEnergy();
        manageFitness();
        manageHunger();
        manageSocial();
        manageThirst();

        // animator.SetFloat("Hunger", hunger);
        // animator.SetFloat("Thirst", thirst);
        // animator.SetFloat("Energy", energy);
        // animator.SetFloat("Fitness", fitness);
        // animator.SetFloat("Social", social);
        // animator.SetFloat("Comfort", comfort);

       


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

    public void manageHunger()
    {
        hunger -= .005f;
        //TODO, how should hunger be decreased?
        //Increased/resat by pressing button? 
    }

    public void manageThirst()
    {
        thirst -= .005f;
        //TODO, how should thirst be decreased?
        //Increased/resat by pressing button? Same button as Hunger? 
    }

    public void manageEnergy()
    {
        energy -= .005f;
        //TODO, how should energy be decreased? Decreases slowly over time, but how slow?
        //Increased/resat by pressing button?
    }

    public void manageFitness()
    {
        fitness -= .005f;
        //TODO, how should fitness be decreased? Decreases slowly over time, but how slow?
        //Increased by heart rate sensor, gyroscope, accelerometer, etc?
    }

    public void manageSocial()
    {
        social -= .005f;
        //TODO, how should social be decreased? Decreases slowly over time, but how slow?
        //Can currently be incresed by having someone show their suprised face. Would be nice if there were more emotions :)
        //Sensor to register if you've been hugged?

    }

    public void manageComfort()
    {
        comfort -= .005f;
        //TODO, how should comfort be decreased? Decreases slowly over time, but how slow?
        //Heat sensor, if its too hot or too cold, comfort decreases, if its just right, comfort increases?
        //Heart rate monitor, if you've got a resting heart rate of 60, comfort increases?
        //pressure sensor for when you've been given a hug?
    }

}

