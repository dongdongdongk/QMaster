using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Quiz : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] QuestionSo questions;
    void Start()
    {
        questionText.text = questions.GetQuestion();
    }

}
