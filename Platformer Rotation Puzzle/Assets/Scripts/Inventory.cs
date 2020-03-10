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

    public InventoryItem(string name, string description)
    {
        this.name = name;
        this.description = description;
    }
}

public class Inventory : MonoBehaviour
{
    public List<InventoryItem> items;
    public Sprite blank;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        Debug.Log("Start");
        //   items.Add(new InventoryItem("Gem", "So fancy"));
        for (int i = 0; i < 8; ++i)
        {
            items.Add(new InventoryItem("", ""));
            items[i].sprite = blank;
        }
     
    }

    void Update()
    {
        if (items.Count > 8)
        {
            Debug.Log("removed extra item");
            for (int i = 0; i < items.Count - 1; ++i)
            {
                items[i].sprite = blank;
                items[i] = items[i + 1];
            }
            items.RemoveAt(8);
        }
  //    for (int i = 0; i < items.Count; ++i)
 //     {
  //        if (items[i].name == "") 
  //        {
  //            items.RemoveAt(i);
  //        }
   //   }
   //   for (int i = items.Count; i < 8; ++i)
   //   {
    //      items.Add(new InventoryItem("", ""));
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

