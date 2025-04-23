using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataformas : MonoBehaviour
{
    public float jumpForce = 10;
    public bool isOnGround = true;
    public bool gameOver = false;
    private Rigidbody2D playerRb;
    public float speed = 3.0f;
    private float horizontal;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            playerRb.AddForce(Vector3.up*jumpForce, ForceMode2D.Impulse);
            

            //playerAnim.SetTrigger("Jump_trig");
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ground 1");
        if (collision.transform.tag == "Ground") 
        {    
            isOnGround = true;
        }
    }
}
