using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public BoxCollider2D hitbox;
    public Controls Player;
    private bool active;
    public Inventory inventory;
    // Start is called before the first frame update
    void Start()
    {
        Player = FindObjectOfType<Controls>();
        inventory = FindObjectOfType<Inventory>();
        active = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D hitbox)
    {
        if (active)
        {
            if (inventory.items[0].sprite == inventory.blank)
            {
                Destroy(gameObject);
                inventory.items.Add(new InventoryItem("Coin", "Shiny"));
                active = false;
            }
        }
    }
}
