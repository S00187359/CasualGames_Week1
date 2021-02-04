using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfilepicButtonControl : MonoBehaviour
{
    [HideInInspector]
    public string ID;
    [HideInInspector]
    public Button btnProfilePicture;

    public void UpdateButton(ProfilePictureData data)
    {
        if (data != null)
        {
            ID = data.ID;
           GetComponent<Image>().sprite = data.ProfileSprite;
        }
    }
}
