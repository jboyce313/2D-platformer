using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float fanForce = 10f;
    [SerializeField] private AudioSource fanSoundEffect;

    [SerializeField] private float waitTime = .2f;
    private float timer = 0f;

    private void Start()
    {
            fanSoundEffect.Play();
    }

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
        //PlayFanSoundEffect();
        if (rb != null)
        {
            rb.velocity = new Vector2(rb.velocity.x, fanForce);
        }
    }

    private void PlayFanSoundEffect()
    {
        timer += Time.deltaTime;
        if (timer > waitTime)
        {
            fanSoundEffect.Play();
            timer = 0f;

        }
    }
    
}
