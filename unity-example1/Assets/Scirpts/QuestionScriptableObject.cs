using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Question", menuName="Question",order=2)]
public class QuestionScriptableObject : ScriptableObject
{
   [TextArea]
   public string Problem;

   public string Choice1, Choice2, Choice3, Choice4;
}
