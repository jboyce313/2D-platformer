using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private Text cherriesText;
    [SerializeField] private AudioSource collectSoundEffect;

    private void Start()
    {
        cherriesText.text = "Cherries: " + Score.scoreInt;
        Score.cherriesCollectedOnCurrentLevel = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            Score.cherriesCollectedOnCurrentLevel++;
            Score.scoreInt++;
            cherriesText.text = "Cherries: " + Score.scoreInt;
        }
    }
}
