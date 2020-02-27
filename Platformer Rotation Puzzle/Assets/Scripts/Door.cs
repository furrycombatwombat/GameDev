using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool open;
    public Key associatedKey;
    public Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        open = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (associatedKey.collected)
        {
            if (open == false)
            {
                {
                    GetComponent<Transform>().Translate(movement);
                }
            }
            open = true;
        }
    }
}
