using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InvetoryDisplay : MonoBehaviour
{
    VendorInvetory vendorInvetory;
    public Button itemPrefab;
    public Transform lstItems;


    public void UpdateDisplay(VendorInvetory invetory)
    {
        vendorInvetory = invetory;

        foreach (InvetoryData item in vendorInvetory.VendorItems.Items)
        {
            //using the ID of an item, get the actual item from the game manager (Name, Icon, Prefab, Cost etc.)
            Item foundItem = GameManager.Instance.AllItems.GetItem(item.ID);
       

            //Instantiate item prefab (button)
            Button inst = Instantiate(itemPrefab, lstItems);
            //Set button name to ID
            inst.gameObject.name = foundItem.ID;
            //Set button image to icon
            inst.image.sprite = foundItem.Icon;

        }
    }

    public void Close()
    {
        Destroy(gameObject);
    }
}
