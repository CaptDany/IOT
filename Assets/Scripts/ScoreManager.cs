using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ball")
        {
            IncrementScore();
        }
    }
    
    public void IncrementScore()
    {
        score++;
    }
    public int GetScore()
    {
        return score;
    }
}
