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
    public float comfort; 

    //Input from nerual network
    public float suprised;

    //Input from sensors
    public float accelerationMagnitude;
    public float gyroMagnitude;
    public float temperature;
 
    public float activityThreshold = 1.0f;

    public Animator animator;

    void Start()
    {
        LoadUserStats();
    }

    void Update()
    {
        //update the values of the user statistics 
        //TODO
        decreaseComfort();
        decreaseEnergy();
        decreaseFitness();
        decreaseHunger();
        decreaseSocial();
        decreaseThirst();

        animator.SetFloat("Hunger", hunger);
        animator.SetFloat("Thirst", thirst);
        animator.SetFloat("Energy", energy);
        animator.SetFloat("Fitness", fitness);
        animator.SetFloat("Social", social);
        animator.SetFloat("Comfort", comfort);
        animator.SetFloat("Suprised", suprised);
       
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

    public void decreaseHunger()
    {
        if(hunger > 0)
        {
            hunger -= .0006f;
        }
            
        //TODO, how should hunger be decreased?
        //Increased/resat by pressing button? 
    }

    public void decreaseThirst()
    {
        if(thirst > 0)
        {
            thirst -= .0008f;
        }
        //TODO, how should thirst be decreased?
        //Increased/resat by pressing button? Same button as Hunger? 
    }

    public void decreaseEnergy()
    {
        if(energy > 0)
        {
            if(accelerationMagnitude > activityThreshold || gyroMagnitude > activityThreshold)
            {
                energy -= .0005f;
            }
            else 
            {
                energy -= .0002f;
            }
           
        }
        
        //TODO, how should energy be decreased? Decreases slowly over time, but how slow?
        //Increased/resat by pressing button?
    }

    public void decreaseFitness()
    {
        if(fitness > 0)
        {
            if(accelerationMagnitude > activityThreshold || gyroMagnitude > activityThreshold)
            {
                fitness += .005f;
            }
            else 
            {
                fitness -= .0005f;
            }

            
        }
        
        //TODO, how should fitness be decreased? Decreases slowly over time, but how slow?
        //Increased by heart rate sensor, gyroscope, accelerometer, etc?
    }

    public void decreaseSocial()
    {
        if(social > 0)
        {
            social -= .0006f;
        }
        //TODO, how should social be decreased? Decreases slowly over time, but how slow?
        //Can currently be incresed by having someone show their suprised face. Would be nice if there were more emotions :)
        //Sensor to register if you've been hugged?

    }

    public void decreaseComfort()
    {
        if(comfort > 0 && comfort < 100)
        {
            if(temperature > 30 || temperature < 15)
            {
                comfort -= .005f;
            }
            else 
            {
                comfort += .0005f;
            }
            
        }
        //TODO, how should comfort be decreased? Decreases slowly over time, but how slow?
        //Heat sensor, if its too hot or too cold, comfort decreases, if its just right, comfort increases?
        //Heart rate monitor, if you've got a resting heart rate of 60, comfort increases?
        //pressure sensor for when you've been given a hug?
    }

}

