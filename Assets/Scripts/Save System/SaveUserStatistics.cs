using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveUserStatistics
{
    public static void SaveUserStats(ManageUserStatistics userStats)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/userStats.bn";
        FileStream stream = new FileStream(path, FileMode.Create);

        UserStatistics data = new UserStatistics(userStats);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static UserStatistics LoadUserStats()
    {
        string path = Application.persistentDataPath + "/userStats.bn";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            UserStatistics data = formatter.Deserialize(stream) as UserStatistics;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
