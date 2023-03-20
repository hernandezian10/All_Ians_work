using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firstcircle : MonoBehaviour
{
    SpriteRenderer SD;
    // Start is called before the first frame update
    void Start()
    {
        SD = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
           
            SD.color = Color.blue;
        }
            
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {

            SD.color = Color.green;
        }

    }
}
