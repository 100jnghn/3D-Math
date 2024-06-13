using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class QuizAnswer : MonoBehaviour
{
    public float answer = 10;
    public TMP_InputField answerInputField;

    public void checkAnswer()
    {
        if (Convert.ToSingle(answerInputField.text) == answer)
        {
            answerInputField.text = "Answer!";
        }
        else
        {
            answerInputField.text = "Wrong!";
        }
    }
}
