using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Card", menuName="Card",order=1)]
public class CardScriptableObject : ScriptableObject
{
   public string CardName;
   [TextArea]
   public string CardDescription;

   public int CardValue;

   public Sprite CardIcon;
}
