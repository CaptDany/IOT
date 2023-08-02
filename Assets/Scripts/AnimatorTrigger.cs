using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorTrigger : MonoBehaviour
{
    public Animator animator;
    public ScoreManager scoreManager;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        int score = scoreManager.GetScore();
        animator.SetInteger("score", score);
    }
}
