using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public class InventoryItem
{
    public string name;
    public string description;
    public Sprite sprite;
    private int count;

    public InventoryItem(string Name, string Description)
    {
        name = Name;
        description = Description;
    }
    public InventoryItem(string Name, string Description, Sprite Sprite)
    {
        name = Name;
        description = Description;
        sprite = Sprite;
    }
}
public class Inventory : MonoBehaviour
{
    public List<InventoryItem> items;
    public Sprite blank;
    public GameObject potion;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        Debug.Log("Start");
        //   items.Add(new InventoryItem("Gem", "So fancy"));
     
    }

    void Update()
    {
        if (items.Count == 4)
        {
            potion.SetActive(true);
        }
    }
   //
    public bool HasItem(string name)
    {
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].name == name)
            {
                return true;
            }
        }
        return false;
    }
    public void RemoveItem(string itemName)
    {
        for(int i=0; i < items.Count; ++i)
        {
            if (items[i].name == itemName)
            {
                items[i].name = "";
                items[i].description = "";
                items[i].sprite = blank;
                Debug.Log("Item Removed");
                break;
            }
        }
    }
    }

