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
        filePath = "C:/Users/maria/Desktop/test.txt";
        //filePath = "C:/Users/JPA99/Documents/GitHub/Human-Tamagotchi/PythonSerialRead/testfile.txt";


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
        string button = inputArray[0];
        Debug.Log("Input array: " + inputArray[0]);

        if(button.Equals("{Button 1}"))
        {
            userStatistics.hunger = 100f;
        }
        if(button.Equals("{Button 2}"))
        {
            userStatistics.thirst = 100f;
        }
        if(button.Equals("{Button 3}"))
        {
            userStatistics.fitness = 100f;
            userStatistics.comfort = 100f;
            userStatistics.hunger = 100f;
            userStatistics.thirst = 100f;
            userStatistics.social = 100f;
            userStatistics.energy = 100f;
        }

        //If input array has second value, set heart rate to that value
        if (inputArray.Length > 1)
        {  
            userStatistics.heartRate = float.Parse(inputArray[1]);
        }
        //If input array has third value, set temperature to that value
        if (inputArray.Length > 2)
        {
            userStatistics.temperature = float.Parse(inputArray[2]);
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
