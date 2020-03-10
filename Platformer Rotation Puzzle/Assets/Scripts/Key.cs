using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public Chest associatedChest;
    public bool collected;
    public BoxCollider2D hitbox;
    public bool active;
    public Controls Player;
    public Inventory inventory;
    
    // Start is called before the first frame update
    void Start()
    {
        Player = FindObjectOfType<Controls>();
        inventory = FindObjectOfType<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D hitbox)
    {
        {
            if (active)
            {
                if (inventory.items[0].sprite == inventory.blank)
                {
                    Debug.Log("8th sprite isnt blank");
                    associatedChest.locked = false;
                    Destroy(gameObject);
                    Debug.Log("Key Destroyed");
                    collected = true;
                    inventory.items.Add(new InventoryItem("Key", "Opens Locked Stuff"));
                    active = false;
                }
            }
        }
    }
}
