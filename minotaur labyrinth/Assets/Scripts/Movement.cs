using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public float movementspeed;
    public string gameover;
    public List<CircleCollider2D> Minotaurs;
    public UIInventory inventory;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Animator>().SetInteger("Direction", 0);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.right*movementspeed, ForceMode2D.Impulse);
            GetComponent<Animator>().SetInteger("Direction", 2);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.up*movementspeed, ForceMode2D.Impulse);
            GetComponent<Animator>().SetInteger("Direction", 1);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.left*movementspeed, ForceMode2D.Impulse);
            GetComponent<Animator>().SetInteger("Direction", 4);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.down*movementspeed, ForceMode2D.Impulse);
            GetComponent<Animator>().SetInteger("Direction", 3);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        for (int i = 0; i < Minotaurs.Count; i++)
        {
            if (collision == Minotaurs[i])
            {
                GameOver();
            }
        }
    }
    private void GameOver()
    {
        SceneManager.LoadScene(gameover);
        Destroy(inventory);
    }
}
