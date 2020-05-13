using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Pickup : MonoBehaviour
{
    public Inventory inventory;
    public Sprite sprite;
    public string itemname;
    public string itemdescription;
    public BoxCollider2D player;
    public MinotaurManager manager;
    public TilemapCollider2D Lava;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>().sprite;
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D hitbox)
    {
        if (hitbox == player)
        {
            Destroy(gameObject);
            inventory.items.Add(new InventoryItem(itemname, itemdescription, sprite));
            if (itemname != "FireResistancePotion")
            {
                manager.AddMinotaur();
            }
            else
            {
                Destroy(Lava);
            }
        }
    }
}

