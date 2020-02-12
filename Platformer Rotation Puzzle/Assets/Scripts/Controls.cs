using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public bool IsrunningRight = false;
    public bool IsrunningLeft = false;
    public float jumpHeight = 0;
    public bool airborne = false;
    public float maxVelocity = 5;
    public float currentVelocity = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Animator>().SetBool("Is Airborne", airborne);
        GetComponent<Animator>().SetBool("IsRunningRight", IsrunningRight);
        GetComponent<Animator>().SetBool("IsRunningLeft", IsrunningLeft);
        GetComponent<Animator>().SetBool("IsIdle", (IsrunningRight==false && IsrunningLeft== false && airborne== false));
        if (airborne) {
            if (currentVelocity < maxVelocity)
            {
                if (IsrunningRight) {
                    GetComponent<Transform>().Translate(currentVelocity, 0f, 0f);
                }
                if (IsrunningLeft)
                {
                    GetComponent<Transform>().Translate(-1*currentVelocity, 0f, 0f);
                }
            }
            else
            {
                if (IsrunningRight)
                {
                    GetComponent<Transform>().Translate(maxVelocity, 0f, 0f);
                }
                if (IsrunningLeft)
                {
                    GetComponent<Transform>().Translate(-1 * maxVelocity, 0f, 0f);
                }
            }
                }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if(IsrunningRight== false)
            {
                currentVelocity = 0;
            }
            if (airborne == false)
            {
                IsrunningRight = true;
                IsrunningLeft = false;
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (IsrunningLeft == false)
            {
                currentVelocity = 0;
            }
            if (airborne == false)
            {
                IsrunningRight = false;
                IsrunningLeft = true;
            }
        }
        if (Input.GetKey(KeyCode.RightArrow) == false && Input.GetKey(KeyCode.LeftArrow) == false)
        {
            if (airborne == false)
            {
                IsrunningRight = false;
                IsrunningLeft = false;
            }
        }
        if (IsrunningRight && airborne == false)
        {
            if (currentVelocity < maxVelocity)
            {
                GetComponent<Rigidbody2D>().AddForce((Vector3.right), ForceMode2D.Impulse);
                currentVelocity += 0.05f;
            }
            GetComponent<Transform>().Translate(maxVelocity,0f,0f);
        }
        if (IsrunningLeft && airborne == false)
        {
            if (currentVelocity < maxVelocity)
            {
                GetComponent<Rigidbody2D>().AddForce((Vector3.left), ForceMode2D.Impulse);
                currentVelocity += 0.05f;
            }
            else
            {
                GetComponent<Transform>().Translate(-1*maxVelocity, 0f, 0f);
            }
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (airborne == false)
            {
                GetComponent<Rigidbody2D>().AddForce((Vector3.up * jumpHeight), ForceMode2D.Impulse);
                airborne = true;
                
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        airborne = false;
    }
}
