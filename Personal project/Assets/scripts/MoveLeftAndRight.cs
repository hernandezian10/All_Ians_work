using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftAndRight : MonoBehaviour
{
    public float xRange = 10;
    public float xSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
     
            transform.Translate(Vector3.right * Time.deltaTime * -xSpeed);

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            transform.Translate(Vector3.left * Time.deltaTime * -xSpeed);

        }
    }
}
