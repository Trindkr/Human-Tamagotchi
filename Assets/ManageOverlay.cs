using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageOverlay : MonoBehaviour
{
    public GameObject StatisticsWindow;
    public GameObject SettingsWindow; //idk what to name this man
    
    // Start is called before the first frame update
    void Start()
    {
        StatisticsWindow.SetActive(false);
        SettingsWindow.SetActive(false);
    }


    public void OpenStatisticsWindow()
    {
        StatisticsWindow.SetActive(true);
    }

    public void CloseStatisticsWindow()
    {
        StatisticsWindow.SetActive(false);
    }

    public void OpenSettingsWindow()
    {
        SettingsWindow.SetActive(true);
    }

    public void CloseSettingsWindow()
    {
        SettingsWindow.SetActive(false);
    }

    
}
