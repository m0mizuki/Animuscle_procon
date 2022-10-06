using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class countscore : MonoBehaviour
{
    protected static int score = 0;
    public TextMeshProUGUI scoreText;

    public static void AddScore()
    {
        score++;
    }

    void Update()//スコアを表示
    {
        scoreText.text = "SCORE: " + score.ToString();
    }
    public static int GetScore()
    {
        return score;
    }
}
