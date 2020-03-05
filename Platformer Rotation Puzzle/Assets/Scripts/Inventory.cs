using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public class InventoryItem
{
    public string name;
    public string description;

    public InventoryItem(string name, string description)
    {
        this.name = name;
        this.description = description;
    }
}

public class Inventory : MonoBehaviour
{
    public List<InventoryItem> items;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        items.Add(new InventoryItem("Gem", "So fancy"));
    }

    void Update()
    {

    }
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
}
