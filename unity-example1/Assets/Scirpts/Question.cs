using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Question : MonoBehaviour
{
    [TextArea]
    public string Problem;
    public string  Choice1, Choice2, Choice3, Choice4;

    public TMP_Text QuestionTXT, Choice1TXT, Choice2TXT, Choice3TXT, Choice4TXT;

    

    // Start is called before the first frame update
    void Start()
    {
        QuestionTXT.text = Problem;
        Choice1TXT.text = Choice1;
        Choice2TXT.text = Choice2;
        Choice3TXT.text = Choice3;
        Choice4TXT.text = Choice4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
