using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateProfileController : MonoBehaviour
{

    public InputField txtUsername;
    Color defaultColor = Color.red;

    public ProfilePicList AvailableProfilePictures;
    ProfilePictureData pictureData;

    public GameObject lstPicturesContent;
    List<UserProfile> availableProfiles = new List<UserProfile>();

    private void Start()
    {
        availableProfiles = GameUtilities.LoadUserProfiles();

        foreach (UserProfile profile in availableProfiles)
        {
            AddProfileToList(profile);
        }

        FillListWithProfilePictures();
    }
    void FillListWithProfilePictures()
    {
        foreach (ProfilePictureData pic in AvailableProfilePictures.Pictures)
        {
         
            GameObject button = Instantiate(
                AvailableProfilePictures.ProfileButtonPrefab,
                lstPicturesContent.transform);

            button.GetComponent<ProfilepicButtonControl>().UpdateButton(pic);

            Button testBtn = button.GetComponent<Button>();
            testBtn.onClick.AddListener(() => SetProfilePicture(testBtn));

        }
    }
    public void SetProfilePicture(Button clickedButton) 
    {
        if (clickedButton != null)
        {
            string id = clickedButton.GetComponent<ProfilepicButtonControl>().ID;

           pictureData = AvailableProfilePictures.GetData(id);

           
        }
    }
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
                _Color = defaultColor,
                ProfileSprite = pictureData.ProfileSprite,
                ProfileSpriteName = pictureData.ID
            };

            AddProfileToList(profile);

            GameUtilities.SaveUserProfile(profile);

          
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
