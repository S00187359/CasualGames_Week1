using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public ItemList AllItems;

    public static GameManager Instance;
    void Awake()
    {
        if (GameManager.Instance == null)
        {
            GameManager.Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public InvetoryDisplay vendorUIPrefab;
    public Transform rootCanvas;
    public void ShowvendorUI(VendorInvetory vendorInvetory)
    {
        InvetoryDisplay dis = Instantiate(vendorUIPrefab, rootCanvas);
        dis.UpdateDisplay(vendorInvetory);
    }
}
