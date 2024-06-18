using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class QuizHintController : MonoBehaviour
{
    public Button nextButton;
    public TextMeshProUGUI hintText;
    public int index;

    string[] hint = new string[] { 
        "Create dot A(0,0,0)",
        "Create dot B(1,0,0)",
        "Create dot C(1,0,3)",
        "Create dot D(0,0,3)",
        "Create dot E(0,2,0)",
        "Create dot F(1,2,0)",
        "Create dot G(1,2,3)",
        "Create dot H(0,2,3)",
        "Create vector DF",
        "Create vector HF",
        "Get F-G",
        "Get F-H",
        "Get DF * HF"
    };

    void Start()
    {
        index = 0;
        hintText.text = hint[index];
    }

    void Update()
    {
        
    }

    public void onClickNextButton()
    {
        index++;
        index %= hint.Length;
        hintText.text = hint[index];
    }
}
