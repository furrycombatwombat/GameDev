using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public BoxCollider2D chesthitbox;
    public bool locked;
    public bool open;
    private Controls Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = FindObjectOfType<Controls>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void OnTriggerEnter2D(Collider2D chesthitbox)
    {
        //if (locked == false)
      //  {
            if (Player.inventory.HasItem("Key"))
            {
                GetComponent<Animator>().SetBool("KeyCollected", true);
            }
     //   }
            }
        }
