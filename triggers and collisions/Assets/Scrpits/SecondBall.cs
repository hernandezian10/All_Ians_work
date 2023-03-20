using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondBall : MonoBehaviour
{
    SpriteRenderer SP;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        SP = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Floor") 
        {
            SP.color = Color.red;
            rb.gravityScale = 10;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            SP.color = Color.green;
            rb.gravityScale = 1;
        }
    }
   
}
