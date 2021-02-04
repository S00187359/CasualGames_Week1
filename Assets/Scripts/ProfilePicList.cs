using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "ProfilePictureList", menuName ="Profiles/Pictures")]
public class ProfilePicList : ScriptableObject
{
    public GameObject ProfileButtonPrefab;
    public List<ProfilePictureData> Pictures = new List<ProfilePictureData>();

    public ProfilePictureData GetData(string id)
    {
        return Pictures.Find(pic => pic.ID == id);
    }
}

[Serializable]
public class ProfilePictureData
{
    public string ID;
    public Sprite ProfileSprite;
}