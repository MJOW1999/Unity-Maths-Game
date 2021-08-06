using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text2 : MonoBehaviour
{
    List<string> secondChoice = new List<string>() {"2. 6/x", "2. 3x^2", "2. 2019x^2020", "2. 7x^4", "2. 3e^x + 15x"};
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<TextMesh>().text = secondChoice[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (TextControl.randQuestion >= -1)
        {
            GetComponent<TextMesh>().text = secondChoice[TextControl.randQuestion];
        }
    }

    void OnMouseDown()
    {
        TextControl.selectedAnswer = gameObject.name;
        TextControl.choiceSelected = "y";
    }
}
