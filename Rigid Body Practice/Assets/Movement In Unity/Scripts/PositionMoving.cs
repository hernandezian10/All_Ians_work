using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionMoving : MonoBehaviour
{
    public float forceMulti = 200;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime;
    }
}
