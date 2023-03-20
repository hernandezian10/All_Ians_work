using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    //private variables
    private float speed = 20.0f;
    private float turnSpeed = 10.0f;
    private float horizontalInput;
    private float fowardInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get player inputs
        horizontalInput = Input.GetAxis("Horizontal");
        fowardInput = Input.GetAxis("Vertical");
        //we're going to make the car move foward
        transform.Translate(Vector3.forward*Time.deltaTime* speed* fowardInput);
        //we turn the vehicle
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed* horizontalInput * speed);


    }
}
