using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Controls Playerscript;
    public float rotationAngle = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (Playerscript.IsrunningLeft)
            {
                transform.Rotate(0f,0f,-1*rotationAngle);
            }
            if (Playerscript.IsrunningRight)
            {
                transform.Rotate(0f,0f,rotationAngle);
            }
        }
    }
