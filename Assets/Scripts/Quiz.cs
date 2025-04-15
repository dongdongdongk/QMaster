using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] QuestionSo questions;
    [SerializeField] GameObject[] answerButtons;
    int correctAnswerIndex;
    [SerializeField] Sprite defaltAnswerButtonSprite;
    [SerializeField] Sprite correctAnswerButtonSprite;
    void Start()
    {
        questionText.text = questions.GetQuestion();

        for (int i = 0; i < answerButtons.Length; i++)
        {
            TextMeshProUGUI buttonText = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = questions.GetAnswer(i);
        }

    }

    public void OnAnswerSelected(int index)
    {
        Image buttonImage;
        if (index == questions.GetCorrectAnswerIndex())
        {
            questionText.text = "정답입니다!";
            buttonImage = answerButtons[index].GetComponent<Image>();
            buttonImage.sprite = correctAnswerButtonSprite;
        }
        else
        {
            correctAnswerIndex = questions.GetCorrectAnswerIndex();
            string correctAnser = questions.GetAnswer(correctAnswerIndex);
            questionText.text = "오답입니다! 정답은 " + correctAnser + "입니다.";
            buttonImage = answerButtons[correctAnswerIndex].GetComponent<Image>();
            buttonImage.sprite = correctAnswerButtonSprite;
            
        }
    }

}
