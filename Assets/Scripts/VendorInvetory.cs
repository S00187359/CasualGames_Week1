using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VendorInvetory : MonoBehaviour
{
    public VendorItems VendorItems;
    void Start()
    {
        GameManager.Instance.ShowvendorUI(this);
    }
 
}
