using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextButton : MonoBehaviour
{
    [SerializeField] public string nextText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if(nextText == "NEXT->" && Application.loadedLevel == 2)
        {
            SceneManager.LoadScene("Level 2");

        }
        else
        {
            SceneManager.LoadScene("Main Menu");
        }

    
    }
}
