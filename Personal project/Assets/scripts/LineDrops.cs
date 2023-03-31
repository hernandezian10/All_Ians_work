using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDrops : MonoBehaviour
{
    
    [SerializeField]
    bool lengthLine;
    
    float dropSpeed = 10f;
    float dropSpeedUp = 10f;
    Renderer SP;
    Material Silver;
    
    void Start()
    {
        SP = GetComponent<Renderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        SP.material.SetColor("Color", Color.grey);
        if (transform.localScale.y >= 0)
        {
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y + 1    * dropSpeed * Time.deltaTime, 0);
                transform.Translate(Vector3.down * dropSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y - 1 * dropSpeedUp * Time.deltaTime, 0);
                transform.Translate(Vector3.up * dropSpeedUp * Time.deltaTime);
            }

        }
      

    }
}
