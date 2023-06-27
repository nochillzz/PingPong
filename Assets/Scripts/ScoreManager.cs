using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int Score { get; private set; }
    public Text scoreText;

    private void Start()
    {
        Score = 0;
        UpdateScore();
    }

    public void IncrementScore()
    {
        Score++;
        UpdateScore();
    }

    private void UpdateScore()
    {
        scoreText.text = "Score: " + Score.ToString();
    }
}
