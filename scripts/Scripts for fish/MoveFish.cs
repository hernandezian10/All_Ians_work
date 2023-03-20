using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFish : MonoBehaviour
{

    public int randomDirection;
    public int randomNumber;
    public bool fishHits = false;
    private float ySpeed = 10f;
    private float yPositionForFish = 3f;
    
    
   
    //private float turnSpeed = -50;

    // Start is called before the first frame update
    void Start()
    {
         randomNumber = Random.Range(0,100);
    }

    // Update is called once per frame
    void Update()
    {
      

        if (randomNumber <= 50)
        {
            randomDirection = -1;
        }
        else if (randomNumber >= 51)
        {
            randomDirection = 1;
        }
        transform.Translate(Vector3.right * randomDirection * Time.deltaTime);

        //stop fish when the hook hits
        if (fishHits == true)
        {
            if (randomNumber <= 50)
            {
                randomDirection = 1;
            }
            else if (randomNumber >= 51)
            {
                randomDirection = -1;
            }
            transform.Translate(Vector3.right * randomDirection * Time.deltaTime);
            if (Input.GetKey(KeyCode.UpArrow))
            {
               transform.Translate(Vector3.up * ySpeed * Time.deltaTime);
            }
            if (transform.position.y > yPositionForFish)
            {
               transform.position = new Vector3(transform.position.x, yPositionForFish, transform.position.z);
            }

            
                
        }
    }
    private void OnCollisionEnter(Collision collison)
    {
        fishHits = true;
    }
}
