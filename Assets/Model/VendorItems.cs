using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
[CreateAssetMenu(fileName = "VendorItems", menuName = "Items/VendorList")]
public class VendorItems : ScriptableObject
{
    public List<InvetoryData> Items = new List<InvetoryData>();
}
