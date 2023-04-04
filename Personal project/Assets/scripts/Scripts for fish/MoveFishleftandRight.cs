using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFishleftandRight : MonoBehaviour
{
    public float fishSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.right * fishSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * -fishSpeed * Time.deltaTime);
        }
    }
}
