using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int correctAnswers = 0;
    int questionsSeen = 0;

    public int GetCorrectAnswers()
    {
        return correctAnswers;
    }

    public void IncrementCorrectAnswers()
    {
        correctAnswers++;
        Debug.Log("정답 수 증가: " + correctAnswers);
    }

    public int GetQuestionsSeen()
    {
        return questionsSeen;
    }
    public void IncrementQuestionsSeen()
    {
        questionsSeen++;
        Debug.Log("문제 수 증가: " + questionsSeen);
    }

    public float CalculateScore()
    {
        if (questionsSeen == 0)
        {
            return 0; // 혹은 적절한 기본값
        }
        return Mathf.Round(correctAnswers / (float)questionsSeen * 100f);
    }
}
