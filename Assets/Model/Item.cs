using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Item 
{

    public string ID;
    public string Name;
    public string Description;
    public float Value;
    public float Amount;
    public Sprite Icon;
    public Rarity Rarity;

    public GameObject Prefab;
   
}

[Serializable]
public enum Rarity
{
    Common,
    Uncommon,
    Rare,
    Legendary,
    Exotic
}
