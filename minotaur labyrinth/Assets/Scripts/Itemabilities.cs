using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemabilities : MonoBehaviour
{
    public Inventory inventory;
    public Movement player;
    public MinotaurManager manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0; i<inventory.items.Count; ++i)
        {
            if(inventory.items[i].name=="Green Ring")
            {
                player.movementspeed = 3;
            }
            if (inventory.items[i].name == "Red Ring")
            {
                for (int j = 0; j < 5; j++) {
                
                    manager.transform.GetChild(j).GetComponentInChildren<Transform>(true).GetComponentInChildren<AudioSource>().enabled = true;
                }
            }
            if (inventory.items[i].name == "MagicSapphire")
            {

            }
            if (inventory.items[i].name == "LibramOfWonders")
            {

            }
        }
    }
}
