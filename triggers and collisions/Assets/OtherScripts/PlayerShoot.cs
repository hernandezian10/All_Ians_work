using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public bool shooter = false;
    public GameObject shotPrefab;
    public GameObject shotPrefab2;

     PlayerMovement playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(shooter)
        {
            if(Input.GetKeyDown(KeyCode.Space) && playerMovement.facingRight)
             {
                Instantiate(shotPrefab, transform.position, shotPrefab.transform.rotation);
                
             }
            if (Input.GetKeyDown(KeyCode.Space) && !playerMovement.facingRight)
            {
                Instantiate(shotPrefab2, transform.position, shotPrefab2.transform.rotation);

            }

        }
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Power Up"))
        {
            shooter = true;
        }
    }
}
