using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Card : MonoBehaviour
{
    public CardScriptableObject cardSO;

    public int CardValue;
    public string CardDescription, CardName;

    public TMP_Text CardValueTXT, CardNameTXT;

    public Sprite CardIcon;
    // Start is called before the first frame update
    void Start()
    {
        SetupCard();
    }

    public void  SetupCard()
    {
        CardValue = cardSO.CardValue;
        CardDescription = cardSO.CardDescription;
        CardName = cardSO.CardName;
        CardIcon = cardSO.CardIcon;

        CardValueTXT.text = CardValue.ToString();
       
        CardNameTXT.text = CardName.ToString();
 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
