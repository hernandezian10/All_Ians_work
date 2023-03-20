using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookGetsFish : MonoBehaviour
{
    private float stopFishX = -10f;
    
    public bool fishHits = false;
    public float xRange = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(fishHits == true)
        {
            //stops fish when the hooks hits it but the sceen stills moves
            if (transform.position.x < -xRange)
            {
                transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            }

            if (transform.position.x > xRange)
            {
                transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {

                transform.Translate(Vector3.right * Time.deltaTime * -stopFishX);

            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {

                transform.Translate(Vector3.left * Time.deltaTime * -stopFishX);

            }
        }
    }
    private void OnCollisionEnter(Collision collison)
    {
        fishHits = true;
    }
    
}
