using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float fanForce = 10f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            rb = collision.gameObject.GetComponent<Rigidbody2D>();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        rb = null;
    }

    private void Update()
    {
        if (rb != null)
        {
            rb.velocity = new Vector2(rb.velocity.x, fanForce);
        }
    }
    
}
