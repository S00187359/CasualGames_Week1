using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

[Serializable]
public class SavableInvetory 
{
    public string OwnerID;
    public List<InvetoryData> Invetory = new List<InvetoryData>();

    public void AddItem(string itemID, int amount)
    {
        if (Invetory.Any(item => item.ID == itemID))
        {
           int index =  Invetory.FindIndex(item => item.ID == itemID);
            Invetory[index].Count += amount;
        }
        else
        {
            Invetory.Add(new InvetoryData()
            {
                ID = itemID,
                Count = amount
            });
        }

    }

    public void TakeItem(string itemID, int amount)
    {
        if (Invetory.Any(item => item.ID == itemID))
        {
            int index = Invetory.FindIndex(item => item.ID == itemID);
            Invetory[index].Count -= amount;
        }
    }

    public void Save()
    {
        GameUtilities.SaveInvetory(this);
    }
    public void Load()
    {
       Invetory = GameUtilities.LoadInvetory(OwnerID).Invetory;
    }
}

[Serializable]
public class InvetoryData 
{
    public string ID;
    public int Count;
}


