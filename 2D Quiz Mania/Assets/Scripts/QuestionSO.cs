using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject 
{
    [TextArea(2,6)]
    [SerializeField] string question = "Skriv in din fråga här";

}
