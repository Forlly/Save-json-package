using System.IO;
using UnityEngine;

public class SaveJson 
{
    public static void SaveFile<T>(T obj, string path, string fileName)
    {
        string fileJson = JsonUtility.ToJson(obj);
        Debug.Log(fileJson);
        File.WriteAllText($"{path}/{fileName}", fileJson);
    }
    public static T LoadFile<T>(string path, string fileName)
    {
        string fileJson = File.ReadAllText($"{path}/{fileName}");
        return JsonUtility.FromJson<T>(fileJson);
    }
}
