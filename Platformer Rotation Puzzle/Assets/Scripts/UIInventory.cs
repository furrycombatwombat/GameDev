using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    
    public Inventory inventory;
    public Sprite blank;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        inventory = FindObjectOfType<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
     
        for (int i = 0; i < 8; ++i)
        {
            transform.GetChild(i).GetComponent<Image>().sprite = blank;
            Debug.Log("Sprites Reset");
            //     if (inventory.items[i].name == "Key")
            //      {
            transform.GetChild(i).GetComponent<Image>().sprite = inventory.items[i].sprite;
       //     }
        }
    }
}
