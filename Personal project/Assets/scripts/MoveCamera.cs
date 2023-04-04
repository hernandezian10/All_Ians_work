using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    float dropSpeed = 20f;
    float stopYPos = 4.8f;
    public bool camStart = true;
    public bool camEnd = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down  * dropSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * dropSpeed * Time.deltaTime);
        }
        if (transform.position.y > stopYPos)
        {


            transform.position = new Vector3(transform.position.x, stopYPos, transform.position.z);

        }
        if(transform.position.y < 1)
        {
            camStart = false;
        }
        if(transform.position.y > 4.8)
        {
            camEnd = false; 
        }
        if (camEnd == false && camStart == false)
        {
            transform.position = new Vector3 (transform.position.x, stopYPos, transform.position.z);
        }
    }
}
