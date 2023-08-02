using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text scoreText;
    public ScoreManager scoreManager;
    private void Update()
    {
        scoreText.text = "Score: " + scoreManager.GetScore();
    }
    public void ResetScore()
    {
        scoreManager.score = 0;
    }
}
