using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateProfileController : MonoBehaviour
{

    public InputField txtUsername;
    Color defaultColor = Color.red;

    public void SetProfileColor(Button clickedButton)
    {
        if (clickedButton != null)
        {
           defaultColor = clickedButton.GetComponent<Image>().color;

          
        }
    }

    public void CreateProfile()
    {
        if(!string.IsNullOrEmpty(txtUsername.text))
        {
            string username = txtUsername.text;

            UserProfile profile = new UserProfile()
            {
                UserName = username,
                CreatedOn = DateTime.UtcNow,
                _Color = defaultColor
            };

            AddProfileToList(profile);

          
        }
    }

    public ProfileButtonControl ProfileButtonPrefab;
    public GameObject lstProfileContent;

    public void AddProfileToList(UserProfile profile)
    {
        if (profile != null)
        {
            ProfileButtonControl profileButton = Instantiate<ProfileButtonControl>(ProfileButtonPrefab, lstProfileContent.transform);
            profileButton.UpdateButton(profile);
        }
    }


}
