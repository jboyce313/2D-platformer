using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;

    [SerializeField] private AudioSource deathSoundEffect;
    [SerializeField] private Text livesText;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        livesText.text = "Lives: " + Score.lives;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
        }
    }

    private void Die()
    {
        Score.scoreInt -= Score.cherriesCollectedOnCurrentLevel;
        Score.cherriesCollectedOnCurrentLevel = 0;
        deathSoundEffect.Play();
        Score.lives--;
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
    }

    private void RestartLevel()
    {
        if (Score.lives < 0)
        {
            SceneManager.LoadScene("End Screen");
        } else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
