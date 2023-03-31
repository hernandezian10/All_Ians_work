using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHook : MonoBehaviour
{
    //public Transform target;
    float yStop = 4.7f;
    float hookSpeed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < yStop)
        {
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector3.down * hookSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(Vector3.up * hookSpeed * Time.deltaTime);
            }
        }
    }
}
