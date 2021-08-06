using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextControl : MonoBehaviour
{
    List<string> questions = new List<string>() {"Let y = 3ln(x^2). Find dy/dx", "Let y = 3x^3 + 39. Find dy/dx", "Let y = x^2020. Find dy/dx", "Let y = 7x^5 + 17. Find dy/dx", "Let y = 3e^x + 15x + 7. Find dy/dx", "Let y = 2x^2 * e^x. Find dy/dx","Let y = 2x^2 * e^x. Find dy/dx","Let y = 2x^2 * e^x. Find dy/dx","Let y = 2x^2 * e^x. Find dy/dx","Let y = 2x^2 * e^x. Find dy/dx" };

    List<string> correctAnswer = new List<string>() {"2","1","3","4","3", "1","1","1","1","1",};

    public Transform resultObj;

    public Transform nextButton;

    public static string selectedAnswer;

    public static string choiceSelected = "n";

    public static int randQuestion = -1;

    public int questionChange = 0;
    // Start is called before the first frame update
    void Start()
    {
        questionChange = 5;
        //GetComponent<TextMesh>().text = questions[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Application.loadedLevel == 2)
        {
            if (randQuestion == -1)
            {
                randQuestion = Random.Range(0,5);
            }
            if (randQuestion >= -1)
            {
                GetComponent<TextMesh>().text = questions[randQuestion];
            }
        }
        if (Application.loadedLevel == 4)
        {
            if (randQuestion == -1)
            {
                randQuestion = Random.Range(0+questionChange,5+questionChange);
            }
            if (randQuestion >= -1)
            {
                GetComponent<TextMesh>().text = questions[randQuestion];
            }
        }
        //GetComponent<TextMesh>().text = questions[randQuestion];
        //Debug.Log(questions[randQuestion]);
        if(choiceSelected == "y"){
            //choiceSelected = "n";

            if(correctAnswer[randQuestion] == selectedAnswer)
            {
                resultObj.GetComponent<TextMesh>().text = "Correct!! Click next to continue!!";
                nextButton.GetComponent<TextMesh>().text = "NEXT->";
            }
            else
            {
                resultObj.GetComponent<TextMesh>().text = "Incorrect!! The correct answer is: "+ correctAnswer[randQuestion];
                nextButton.GetComponent<TextMesh>().text = "TRY AGAIN->";
            }
            


        }

    }
}
