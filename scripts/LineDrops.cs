using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDrops : MonoBehaviour
{
    //public GameObject linePrefabs;
    //public float cooldown = 0;
    //private float spawnDelay = .2f;
    [SerializeField]
    bool lengthLine;
    [SerializeField]
    float dropSpeed = 1f;
    float dropSpeedUp = 0.7f;
    //private float yPosition = 4f;
    //private float xPosition = 2.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.y <= 4)
        {
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y + 1 * dropSpeed * Time.deltaTime, 0);
                transform.Translate(Vector3.down * dropSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y - 1 * dropSpeedUp * Time.deltaTime, 0);
                transform.Translate(Vector3.up * dropSpeedUp * Time.deltaTime);
            }
        }
        // Vector3 spawnPos = new Vector3(xPosition, yPosition , 0);
        //if (Input.GetKey(KeyCode.DownArrow) && cooldown <= 0)
        //{
        //  Instantiate(linePrefabs, transform.position, linePrefabs.transform.rotation);
        //  cooldown = 5;
        //}
        //if(cooldown >= 0)
        //{
        //   cooldown -= spawnDelay;
        //}

    }
}
