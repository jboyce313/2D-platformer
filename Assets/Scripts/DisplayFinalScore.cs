using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayFinalScore : MonoBehaviour
{
    [SerializeField] private Text finalScoreText;

    void Start()
    {
        finalScoreText.text = "Cherries collected: " + Score.scoreInt;
    }

}
