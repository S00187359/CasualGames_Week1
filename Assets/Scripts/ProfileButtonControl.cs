using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfileButtonControl : MonoBehaviour
{
 
  public Image ButtonBackground; 
  public Text txtUserName ;

    public void UpdateButton(UserProfile profile)
    {
        txtUserName.text = profile.UserName;
        ButtonBackground.color = profile._Color;
    }

}
