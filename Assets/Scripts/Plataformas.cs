using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataformas : MonoBehaviour
{
    public bool isOnGround = true;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ground 2");
        if (collision.transform.tag == "Ground") 
        {    
            isOnGround = true;
        }
    }
}
