using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    public Sprite Keysprite;
    public Inventory inventory;
    // Start is called before the first frame update
    void Start()
    {
        inventory = FindObjectOfType<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < inventory.items.Count; ++i)
        {
            if (inventory.items[i].name == "Key")
            {
                transform.GetChild(i).GetComponent<>();
            }
        }
    }
}
