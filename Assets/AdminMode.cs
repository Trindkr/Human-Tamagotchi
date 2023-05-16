using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AdminMode : MonoBehaviour
{
    public bool adminMode = false;

    [SerializeField] 
    public TMP_Text toggleButton;

    void start()
    {
        if(adminMode == false)
        {
            toggleButton.text = "Enable Admin Mode";
        }
        else
        {
            toggleButton.text = "Disable Admin Mode";
        }
    }

    public void ToggleAdminMode()
    {
        adminMode = !adminMode;
        if(adminMode == false)
        {
            toggleButton.text = "Enable Admin Mode";
        }
        else
        {
            toggleButton.text = "Disable Admin Mode";
        }
    }

   
}
