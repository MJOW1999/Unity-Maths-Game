using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text3 : MonoBehaviour
{
    List<string> thirdChoice = new List<string>() {"3. 3 / x^2", "3. 9x^3", "3. 2020x^2019", "3. 35x^5", "3. 3e^x + 15"};
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<TextMesh>().text = thirdChoice[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (TextControl.randQuestion >= -1)
        {
            GetComponent<TextMesh>().text = thirdChoice[TextControl.randQuestion];
        }
    }

    void OnMouseDown()
    {
        TextControl.selectedAnswer = gameObject.name;
        TextControl.choiceSelected = "y";
    }
}
