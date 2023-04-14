using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageScenes : MonoBehaviour
{
    public void MainScene()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitProgram()
    {
        Application.Quit(); 
    }

    public void StatisicsScene()
    {
        SceneManager.LoadScene(2);
    }
}
