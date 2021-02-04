using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class UserProfile 
{
   
    public string UserName;
    public DateTime CreatedOn;
    public Color _Color;

    [NonSerialized]
    public Sprite ProfileSprite;
    public string ProfileSpriteName;

}
