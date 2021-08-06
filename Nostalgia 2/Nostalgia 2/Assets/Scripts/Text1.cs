using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text1 : MonoBehaviour
{
    List<string> firstChoice = new List<string>() {"1. 3/x", "1. 9x^2", "1. 2019x^2019", "1. 7x^4 + 17", "1. 3e^x + 22"};
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<TextMesh>().text = firstChoice[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (TextControl.randQuestion >= -1)
        {
            GetComponent<TextMesh>().text = firstChoice[TextControl.randQuestion];
        }
    }

    void OnMouseDown()
    {
        TextControl.selectedAnswer = gameObject.name;
        TextControl.choiceSelected = "y";
    }
}
