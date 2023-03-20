using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public GameObject player;
    public float myFloat = 0.03f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + new Vector3(3, 0, -10);
        if (transform.position.x < .03)
        {
            transform.position = new Vector3(myFloat, transform.position.y, transform.position.z);
        }
    }
}
