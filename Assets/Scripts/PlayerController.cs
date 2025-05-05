using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Character Variables
    public float jumpForce = 10;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver = false;
    public float speed = 3.0f;
    private Rigidbody2D playerRb;
    private float horizontal;
    public Animator animator;

    //private SpriteRenderer SpriteRenderer;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal=Input.GetAxis("Horizontal");
        animator.SetFloat("Horizontal",horizontal);
        Debug.Log("Horizontal: " + horizontal);

        /*if (horizontal <0) 
        {
            gameObject.SpriteRenderer.flipX=true;
        }
        else if (horizontal >0)
        {
            gameObject.SpriteRenderer.flipX=false;
        }*/

        transform.Translate(Vector3.right * horizontal * Time.deltaTime * speed);
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            playerRb.AddForce(Vector3.up*jumpForce, ForceMode2D.Impulse);
            isOnGround = false;
            //animator.SetFloat("NimboJump");
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
