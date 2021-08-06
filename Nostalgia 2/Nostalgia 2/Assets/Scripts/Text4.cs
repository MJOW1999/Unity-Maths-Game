using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text4 : MonoBehaviour
{
    List<string> fourthChoice = new List<string>() {"4. 6/ x^2", "4. 9x^2 + 39", "4. x^2019", "4. 35x^4", "4. 3e^x + 7"};
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<TextMesh>().text = fourthChoice[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (TextControl.randQuestion >= -1)
        {
            GetComponent<TextMesh>().text = fourthChoice[TextControl.randQuestion];
        }
    }

    void OnMouseDown()
    {
        TextControl.selectedAnswer = gameObject.name;
        TextControl.choiceSelected = "y";
    }
}
