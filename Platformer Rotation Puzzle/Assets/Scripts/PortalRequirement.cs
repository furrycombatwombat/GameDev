using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalRequirement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<ToNextLevel>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (GetComponent<Chest>().locked == false)
        {
            GetComponent<ToNextLevel>().enabled = true;
        }
    }
}
