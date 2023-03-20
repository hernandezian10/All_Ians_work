using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHook : MonoBehaviour
{
    //public Transform target;
    [SerializeField]
    float hookSpeed = 1.7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * hookSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * hookSpeed * Time.deltaTime);
        }
    }
}
