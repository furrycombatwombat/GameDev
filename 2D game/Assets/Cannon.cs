using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public float rotationSpeed = 3;
    public Transform cannonBallPrefab;
    public Vector3 Dinitial = new Vector3(30f, 40f, 0f);
    public float ballStartDist = 2;
    public float verticaloffset = 0;
    public bool Facingright = true;
    public float speed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(0, 0, -1 * rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var ballStartPos = transform.TransformPoint(new Vector3(ballStartDist, verticaloffset, 0f));
            Transform cbt = Instantiate(cannonBallPrefab, ballStartPos, transform.rotation);
            cbt.GetComponent<Rigidbody2D>().AddForce(transform.rotation * Dinitial, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (Facingright)
            {
                transform.Translate(speed, 0, 0);
            }
            else
            {
                Facingright = true;
                transform.Rotate(0f, 180f, 0f);
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (Facingright==false)
            {
                transform.Translate(speed, 0, 0);
            }
            else
            {
                Facingright = false;
                transform.Rotate(0f, 180f, 0f);
            }
        }
    }
}
