using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundEffect : MonoBehaviour
{
    public AudioSource stomachGrowl;
    public AudioSource yawn;
    public AudioSource sad;
    public AudioSource uncomfortable;


    public ManageUserStatistics userStatistics;
    // Start is called before the first frame update
   
   public void ToggleSoundEffect()
   {
        if(userStatistics.thirst > 30f && userStatistics.comfort > 30f)
        {
            if(userStatistics.hunger < 30f)
            {
                stomachGrowl.Play();
                return;
            }
            else if(userStatistics.energy < 30f)
            {
                yawn.Play();
                return;
            }
            else if (userStatistics.social < 30f || userStatistics.fitness < 30f)
             {
                sad.Play();
                return;
            }
            return;
        }
        else
        {
            uncomfortable.Play();
            return;
        }
   }

}
