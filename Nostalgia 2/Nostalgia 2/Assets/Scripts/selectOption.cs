using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selectOption : MonoBehaviour
{
    public static string gameOption;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    void OnMouseDown()
    {
        gameOption = gameObject.name;
        if (gameOption == "Play")
        {
            SceneManager.LoadScene("Level 1");

        }
        if (gameOption == "Quit")
        {
            QuitGame();
        }
        
    }
}
