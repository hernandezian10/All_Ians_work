using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOvrFoward : MonoBehaviour
{
    public GameObject projectile;
    private float moveSpeed = 40f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("spikes") || collision.gameObject.CompareTag("portal") || collision.gameObject.CompareTag("Portal2") || collision.gameObject.CompareTag("Portal3") || collision.gameObject.CompareTag("roof"))
        {
            Destroy(projectile);
        }
    }

}