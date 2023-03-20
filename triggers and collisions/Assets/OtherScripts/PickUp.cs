using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
     
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //this creates a loction abd referce for our player manager script
            PlayerManager manager = collision.GetComponent<PlayerManager>();
            if (manager)
            {
                bool pickedup = manager.Pickupitem(gameObject);
                if (pickedup)
                {
                    Destroy(gameObject);
                }
            }
            
        }
    }


}
