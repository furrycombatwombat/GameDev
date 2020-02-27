using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyrequirement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Key>().enabled = false;
        GetComponent<Key>().active = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (GetComponent<Chest>().locked == false)
        {
            GetComponent<Key>().enabled = true;
            GetComponent<Key>().active = true;
        }
    }
}
