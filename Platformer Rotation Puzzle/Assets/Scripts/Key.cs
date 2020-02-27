using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public Chest associatedChest;
    public bool collected;
    public BoxCollider2D hitbox;
    public bool active;
    // Start is called before the first frame update
    void Start()
    {
        
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
                associatedChest.locked = false;
                Destroy(gameObject);
                Debug.Log("Key Destroyed");
                collected = true;
            }
        }
    }
}
