using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    PlayerMovement playerMovement;
    public int coinCount;
    public int currentHealth;
    public int maxHealth;
    private float xLocal = -4.56f;
    private float yLocal = -19.87f;
    private float xLocal2 = -6.9f;
    private float yLocal2 = -51.1f;
    private float xLocal3 = -3.18f;
    private float yLocal3 = -68.07f;

    public bool portal1 = false;
    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();

        
    }
    private void Update()
    {
        if (currentHealth == 0)
        {
            PauseGame();
        }
    }
    public bool Pickupitem(GameObject obj)
    {

        
        

        switch (obj.tag)
        {
            case "Currency":
                coinCount++;
                return true;
            case "speed plus":
                return true;
            default:
                return false;
        }
        

              
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.CompareTag("portal"))
        {
            transform.position = new Vector2(xLocal, yLocal);
            portal1 = true;
        }
        if(collision.gameObject.CompareTag("Portal2"))
        {
            transform.position = new Vector2(xLocal2, yLocal2);
        }
        if (collision.gameObject.CompareTag("Portal3"))
        {
            transform.position = new Vector2(xLocal3, yLocal3);
        }


    }
    public void TakeDamage()
    {
        currentHealth -= 1;
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
