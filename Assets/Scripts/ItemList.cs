using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
[CreateAssetMenu(fileName ="ItemList", menuName ="Items/List")]
public class ItemList : ScriptableObject
{
    public List<Item> Items;

    public Item GetItem(string id)
    {
        return Items.Find(item => item.ID == id);
    }
}
