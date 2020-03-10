using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public BoxCollider2D chesthitbox;
    public bool locked;
    public bool open;
    private Controls Player;
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
    private void OnTriggerEnter2D(Collider2D chesthitbox)
    {
        //if (locked == false)
      //  {
            if (inventory.HasItem("Key"))
            {
                GetComponent<Animator>().SetBool("KeyCollected", true);
            inventory.RemoveItem("Key");
            }
     //   }
            }
        }
