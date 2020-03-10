using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpriteConversion : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite Keysprite;
    public Sprite Coinsprite;
    public Inventory inventory;

    void Start()
    {
        inventory = FindObjectOfType<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0; i<inventory.items.Count; ++i)
        {
            if (inventory.items[i].name == "Key")
            {
                inventory.items[i].sprite = Keysprite;
            }
            if (inventory.items[i].name == "Coin")
            {
                inventory.items[i].sprite = Coinsprite;
            }
        }
    }
}
