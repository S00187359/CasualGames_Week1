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
        File.WriteAllText("Profiles/" + profile.UserName + ".json" , json);
    }

    public static List<UserProfile> LoadUserProfiles()
    {
        string[] profiles = Directory.GetFiles("Profiles", "*.json");

        List<UserProfile> LoadedProfiles = new List<UserProfile>();

        foreach (string path in profiles)
        {
            string json = File.ReadAllText(path);
            UserProfile Up = JsonUtility.FromJson<UserProfile>(json);

            LoadedProfiles.Add(Up);
        }

        return LoadedProfiles;
    }
}
