using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class ItemSpriteConversion : MonoBehaviour
{ 
    // Start is called before the first frame update
    public List<Sprite> itemsprites;
    public Inventory inventory;
    public List<string> itemnames;
    public SpriteAtlas atlas;

    void Start()
    {
        inventory = FindObjectOfType<Inventory>();
            for(int i=0; i<180; ++i)
        {
            itemsprites.Add(atlas.GetSprite("roguelikeitems_" + i));
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < inventory.items.Count; ++i)
        {
            for (int j = 0; j < itemsprites.Count; ++j)
            {
                if (inventory.items[i].name == itemnames[j])
                {
                    inventory.items[i].sprite = itemsprites[j];
                }
            }
        }
    }
}
