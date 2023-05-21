using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

public class ReadFromTextFile : MonoBehaviour
{
    private FileSystemWatcher watcher;
    private string filePath;
    private string currentContent;


    public ManageUserStatistics userStatistics;

    // Start is called before the first frame update
    void Start()
    {
        // Set the file path to the desired text file
        //filePath = "C:/Users/maria/Desktop/test.txt";
        filePath = "C:/Users/JPA99/Documents/GitHub/Human-Tamagotchi/PythonSerialRead/testfile.txt";


        // Create a new FileSystemWatcher and set its properties
        watcher = new FileSystemWatcher();
        watcher.Path = Path.GetDirectoryName(filePath);
        watcher.Filter = Path.GetFileName(filePath);
        watcher.NotifyFilter = NotifyFilters.LastWrite;

        // Add event handlers for the Changed and Error events
        watcher.Changed += OnChanged;
        watcher.Error += OnError;

        // Start watching the file
        watcher.EnableRaisingEvents = true;

        // Read the initial contents of the file
        currentContent = File.ReadAllText(filePath);
        Debug.Log("Initial content: " + currentContent);
    }

    // Event handler for the Changed event
    private void OnChanged(object source, FileSystemEventArgs e)
    {
        // Read the newest entry from the file
        string newContent = File.ReadLines(filePath).Last();

        //Split input string into array of strings by commas
        string[] inputArray = newContent.Split(',');
        string input = inputArray[0];
        Debug.Log("Input array: " + inputArray[0]);

        if(input.Equals("Button_1"))
        {
            userStatistics.hunger = 100f;
        }
        if(input.Equals("Button_2"))
        {
            userStatistics.thirst = 100f;
        }
        if(input.Equals("Button_3"))
        if(input.Equals("Button_1"))
        {
            userStatistics.hunger = 100f;
        }
        if(input.Equals("Button_2"))
        {
            userStatistics.thirst = 100f;
        }
        if(input.Equals("Button_3"))
        {
            userStatistics.energy = 100f;
        }
        if(input.Equals("Sensor"))
        {
            float accelerationX = float.Parse(inputArray[1]);
            float accelerationY = float.Parse(inputArray[2]);
            float accelerationZ = float.Parse(inputArray[3]);

            float gyroX = float.Parse(inputArray[4]);
            float gyroY = float.Parse(inputArray[5]);
            float gyroZ = float.Parse(inputArray[6]);

            userStatistics.accelerationMagnitude = Mathf.Sqrt(accelerationX * accelerationX + accelerationY * accelerationY + accelerationZ * accelerationZ);
            userStatistics.gyroMagnitude = Mathf.Sqrt(gyroX * gyroX + gyroY * gyroY + gyroZ * gyroZ);
            userStatistics.temperature = float.Parse(inputArray[7]);

            Debug.Log("Acceleration: " + userStatistics.accelerationMagnitude);
            Debug.Log("Gyro: " + userStatistics.gyroMagnitude);
            Debug.Log("Temperature: " + userStatistics.temperature);


        }

    }

    // Event handler for the Error event
    private void OnError(object source, ErrorEventArgs e)
    {
        Debug.LogError("FileSystemWatcher error: " + e.GetException().Message);
    }

    // Stop watching the file when the script is destroyed
    private void OnDestroy()
    {
        watcher.EnableRaisingEvents = false;
        watcher.Dispose();
    }

}
