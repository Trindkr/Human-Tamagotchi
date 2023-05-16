using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillOrEmptyNeeds : MonoBehaviour
{
    public ManageUserStatistics userStatistics;

    public AdminMode adminMode;
    

    public GameObject hungerFill;
    public GameObject hungerEmpty;

    public GameObject thirstFill;
    public GameObject thirstEmpty;

    public GameObject energyFill;
    public GameObject energyEmpty;

    public GameObject fitnessFill;
    public GameObject fitnessEmpty;

    public GameObject socialFill;
    public GameObject socialEmpty;

    public GameObject comfortFill;
    public GameObject comfortEmpty;

    void Start()
    {
       manageFillAndEmptyButtons();
    }

    public void manageFillAndEmptyButtons()
    {
        if (adminMode.adminMode == true)
        {
            hungerFill.SetActive(true);
            hungerEmpty.SetActive(true);
            thirstFill.SetActive(true);
            thirstEmpty.SetActive(true);
            energyFill.SetActive(true);
            energyEmpty.SetActive(true);
            fitnessFill.SetActive(true);
            fitnessEmpty.SetActive(true);
            socialFill.SetActive(true);
            socialEmpty.SetActive(true);
            comfortFill.SetActive(true);
            comfortEmpty.SetActive(true);
        }
        else
        {
            hungerFill.SetActive(false);
            hungerEmpty.SetActive(false);
            thirstFill.SetActive(false);
            thirstEmpty.SetActive(false);
            energyFill.SetActive(false);
            energyEmpty.SetActive(false);
            fitnessFill.SetActive(false);
            fitnessEmpty.SetActive(false);
            socialFill.SetActive(false);
            socialEmpty.SetActive(false);
            comfortFill.SetActive(false);
            comfortEmpty.SetActive(false);
        }
    }

    void OnEnable()
    {
        manageFillAndEmptyButtons();
    }
    
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
