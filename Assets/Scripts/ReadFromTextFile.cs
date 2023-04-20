using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

public class ReadFromTextFile : MonoBehaviour
{

    void Start() 
    {
        var watch = new FileSystemWatcher();
        //watch.Path = Application.persistentDataPath;
        watch.Path = "C:\\Users\\maria\\Desktop\\Unity Projects\\Human-Tamagotchi\\Assets";
        watch.Filter = "\\test.txt";
        watch.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite; //more options
        watch.Changed += new FileSystemEventHandler(OnChanged);
        watch.EnableRaisingEvents = true;
    }

    /// Functions:
    static void OnChanged(object source, FileSystemEventArgs e)
    {
        if(e.FullPath == "C:\\Users\\maria\\Deskto  p\\Unity Projects\\Human-Tamagotchi\\Assets\\test.txt")
        {
            string line1 = File.ReadLines("C:\\Users\\maria\\Desktop\\Unity Projects\\Human-Tamagotchi\\Assets\\test.txt").First();
            Debug.Log(line1);
        }
    }
}
