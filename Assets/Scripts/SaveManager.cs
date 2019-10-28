using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveManager
{
    public static void SaveScore(SaveNLoad SD)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        //name/path of file
        string path = Application.persistentDataPath + "/Highscore"+"/"+SD.Player+Random.Range(0,1000000000)+".Asteroid";
        if (!File.Exists(path))
        {
            FileStream stream = new FileStream(path, FileMode.Create);
            SaveVariables SaveData = new SaveVariables(SD);
            formatter.Serialize(stream, SaveData);
            stream.Close();
        } else { Debug.Log("FILE ALREADY EXISTS"); }
    }


    public static SaveVariables LoadScore(string EPath)
    {
        string path = Application.persistentDataPath + "/Highscore"+"/"+EPath;
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SaveVariables data = formatter.Deserialize(stream) as SaveVariables;
            stream.Close();
            return data;
        } else
        {
            Debug.LogError("NO FILE FOUND AT: " + path);
            return null;
        }
    }

    public static List<string> GetFileNames()
    {
        string path = Application.persistentDataPath + "/Highscore";
        List<string> filenames = new List<string>();
        DirectoryInfo dir = new DirectoryInfo(path);
        FileInfo[] info = dir.GetFiles("*.*");

        foreach (FileInfo f in info)
        {
            filenames.Add(f.Name);
        }

        return filenames;
    }

    public static void MakeDirectory()
    {
        if (!Directory.Exists(Application.persistentDataPath + "/Highscore"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/Highscore");
        }
    }
}
