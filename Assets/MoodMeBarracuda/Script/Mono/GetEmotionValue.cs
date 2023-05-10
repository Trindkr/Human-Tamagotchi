using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MoodMe;
namespace MoodMe
{
    //[RequireComponent(typeof(Slider))]
    public class GetEmotionValue : MonoBehaviour
    {
        public enum EmotionEnum
        {
            Angry, Disgust, Happy, Neutral, Sad, Scared, Surprised, EmotionIndex
        }

        public EmotionEnum Emotion;
        public ManageUserStatistics userStatistics;

        // Update is called once per frame
        void Update()
        {

            //The values range from 0 to 1
            
            if(EmotionsManager.Emotions.sad > 0.45f)
            {
                Debug.Log("Sad");
                Debug.Log(EmotionsManager.Emotions.sad);
                userStatistics.suprised = 0f;  
                if (userStatistics.social > 0)
                    userStatistics.social -= 0.1f; //Social is decreased when sad face is detected
            }
            else if (EmotionsManager.Emotions.neutral > 0.5f)
            {
                Debug.Log("Neutral"); //No change in social value
                Debug.Log(EmotionsManager.Emotions.neutral);
                userStatistics.suprised = 0f;  

            }
            else if(EmotionsManager.Emotions.surprised > 0.5f)
            {
                Debug.Log("Surprised");
                userStatistics.suprised = 100f;
                if(userStatistics.social < 100)
                    userStatistics.social += 0.1f; //Social is increased when surprised face is detected
                    
            }
            else if (EmotionsManager.Emotions.surprised < 0.5f)
            {
                userStatistics.suprised = 0f;  
            }
           

        }
    }
}