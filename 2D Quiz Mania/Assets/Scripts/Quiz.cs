using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] QuestionSO question;
    [SerializeField] GameObject[] answerButtons;
    int correctAnswerIndex;
    [SerializeField] Sprite defaultAnswerSprite;
    [SerializeField] Sprite correctAnswerSprite;
    [SerializeField] Sprite wrongAnswerSprite;


    void Start()
    {
        questionText.text = question.GetQuestion();

        for(int i = 0; i < answerButtons.Length; i++)
        {
          TextMeshProUGUI buttonText = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
          buttonText.text = question.GetAnswer(i);
        }



    }
            public void OnAnswerSelected(int index)
        {
          if(index == question.GetCorrectAnswerIndex())
          {
            questionText.text = "Rätt svar!";
            Image buttonImage = answerButtons[index].GetComponent<Image>();
            buttonImage.sprite = correctAnswerSprite;
          }

        }


}
