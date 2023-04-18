using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageStatisticBars : MonoBehaviour
{
    public Slider hungerBar;
    public Slider thirstBar;
    public Slider energyBar;
    public Slider fitnessBar;
    public Slider socialBar;
    public Slider comfortBar;

    public ManageUserStatistics manageUserStatistics;

    public void Start()
    {
        
        setMaxValue();
        setHunger(manageUserStatistics.hunger);
        setThirst(manageUserStatistics.thirst);
        setEnergy(manageUserStatistics.energy);
        setFitness(manageUserStatistics.fitness);
        setSocial(manageUserStatistics.social);
        setComfort(manageUserStatistics.comfort);
    }

    public void Update()
    {
        setHunger(manageUserStatistics.hunger);
        setThirst(manageUserStatistics.thirst);
        setEnergy(manageUserStatistics.energy);
        setFitness(manageUserStatistics.fitness);
        setSocial(manageUserStatistics.social);
        setComfort(manageUserStatistics.comfort);
    }

    public void setMaxValue()
    {
        hungerBar.maxValue = 100.0f;
        thirstBar.maxValue = 100.0f;
        energyBar.maxValue = 100.0f;
        fitnessBar.maxValue = 100.0f;
        socialBar.maxValue = 100.0f;
        comfortBar.maxValue = 100.0f;
    }

    public void setHunger(float hunger){
        hungerBar.value = hunger;
    }

    public void setThirst(float thirst){
        thirstBar.value = thirst;
    }

    public void setEnergy(float energy){
        energyBar.value = energy;
    }

    public void setFitness(float fitness){
        fitnessBar.value = fitness;
    }

    public void setSocial(float social){
        socialBar.value = social;
    }

    public void setComfort(float comfort){
        comfortBar.value = comfort;
    }

}
