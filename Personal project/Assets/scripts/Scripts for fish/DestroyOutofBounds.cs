using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x > 50)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < -50)

        if (transform.position.x > 100)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < -100)
        {
            Destroy(gameObject);
        }
    }
}
