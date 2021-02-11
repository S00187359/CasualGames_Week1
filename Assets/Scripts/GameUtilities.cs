using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameUtilities
{
    public static void SaveUserProfile(UserProfile profile)
    {
        string json = JsonUtility.ToJson(profile, true);

        if (!Directory.Exists("ProFiles"))
        {
            Directory.CreateDirectory("Profiles");
        }
        SaveObject("Profiles/" + profile.UserName + ".json", profile);
    }

    public static List<UserProfile> LoadUserProfiles()
    {
        string[] profiles = Directory.GetFiles("Profiles", "*.json");

        List<UserProfile> LoadedProfiles = new List<UserProfile>();

        foreach (string path in profiles)
        {
           
            UserProfile Up = LoadObject<UserProfile>(path);

            LoadedProfiles.Add(Up);
        }

        return LoadedProfiles;
    }

    public static void SaveObject(string path, object objectToSave)
    {
        if (objectToSave != null)
        {
            string json = JsonUtility.ToJson(objectToSave);
            File.WriteAllText(path, json);
        }
    }

    public static T LoadObject<T>(string path)
    {
        if (File.Exists(path))
        {
            return JsonUtility.FromJson<T>(path);
        }
        else
        {
            return default(T);
        }
       
    }

    public static void SaveInvetory(SavableInvetory invetory)
    {
        SaveObject("Invetories/" + invetory.OwnerID + ".inv", invetory);
    }

    public static SavableInvetory LoadInvetory(string ownerID)
    {
        return LoadObject<SavableInvetory>("Invetories/" + ownerID + ".inv");
    }
}
