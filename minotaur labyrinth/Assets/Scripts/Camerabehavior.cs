using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerabehavior : MonoBehaviour
{
    public Movement Player;
    public float xthreshhold;
    public float ythreshhold;
    public float xscalefactor;
    public float yscalefactor;
    private bool isMoving;
    private int direction;
    private int iterations;
    public float movetimescale;
    // Start is called before the first frame update
    void Start()
    {
        isMoving = false;
        iterations = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.inventory.inventory.HasItem("MagicSapphire") == false) {
            if (isMoving)
            {
                MoveCamera(direction);
            }
            else
            {
                if (Player.GetComponent<Transform>().transform.position.x > transform.position.x + xthreshhold)
                {
                    direction = 1;
                    isMoving = true;
                }
                if (Player.GetComponent<Transform>().transform.position.x < transform.position.x - xthreshhold)
                {
                    direction = 2;
                    isMoving = true;
                }
                if (Player.GetComponent<Transform>().transform.position.y > transform.position.y + ythreshhold)
                {
                    direction = 3;
                    isMoving = true;
                }
                if (Player.GetComponent<Transform>().transform.position.y < transform.position.y - ythreshhold)
                {
                    direction = 4;
                    isMoving = true;
                }
            }
        }
        else
        {
            transform.position = new Vector3 (Player.GetComponent<Transform>().transform.position.x, Player.GetComponent<Transform>().transform.position.y,-10f);
            
        }
        if (Player.inventory.inventory.HasItem("LibramOfWonder"))
        {
            GetComponent<Camera>().orthographicSize = 6;
        }
    }
        void MoveCamera(int direction)
        {
            if (iterations < movetimescale)
            {
                if (direction == 1)
                {
                    GetComponent<Transform>().transform.Translate((xscalefactor), 0f, 0f);
                }
                if (direction == 2)
                {
                    GetComponent<Transform>().transform.Translate(-1 * xscalefactor, 0f, 0f);
                }
                if (direction == 3)
                {
                    GetComponent<Transform>().transform.Translate(0f, yscalefactor, 0f);
                }
                if (direction == 4)
                {
                    GetComponent<Transform>().transform.Translate(0f, (-1 * yscalefactor), 0f);
                }
                ++iterations;
            }
            else
            {
                isMoving = false;
                iterations = 0;
            }
        }
    }

