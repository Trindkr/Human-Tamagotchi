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

    // Start is called before the first frame update
    void Start()
    {
        // Set the file path to the desired text file
        filePath = "C:/Users/maria/Desktop/test.txt";
       

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

        // Only update currentContent if the new content is different
        if (newContent != currentContent)
        {
            currentContent = newContent;
            Debug.Log("New content: " + currentContent);
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
