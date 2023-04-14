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


    public void setMaxValue(int setMaxValue)
    {
        hungerBar.maxValue = setMaxValue;
        thirstBar.maxValue = setMaxValue;
        energyBar.maxValue = setMaxValue;
        fitnessBar.maxValue = setMaxValue;
        socialBar.maxValue = setMaxValue;
        comfortBar.maxValue = setMaxValue;
    }

    public void setHunger(int hunger){
        hungerBar.value = hunger;
    }

    public void setThirst(int thirst){
        thirstBar.value = thirst;
    }

    public void setEnergy(int energy){
        energyBar.value = energy;
    }

    public void setFitness(int fitness){
        fitnessBar.value = fitness;
    }

    public void setSocial(int social){
        socialBar.value = social;
    }

    public void setComfort(int comfort){
        comfortBar.value = comfort;
    }

}
