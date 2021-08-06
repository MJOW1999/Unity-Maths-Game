using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitConfirmation : MonoBehaviour
{
    public CanvasGroup uiCanvasGroup;
    public CanvasGroup confirmQuitCanvasGroup;

    //private void Awake()
    //{
    //    ConfirmQuitNo();
    //}

    public void ConfirmQuitNo()
    {
        Debug.Log("Back to game");

        uiCanvasGroup.alpha = 1;
        uiCanvasGroup.interactable = true;
        uiCanvasGroup.blocksRaycasts = true;

        confirmQuitCanvasGroup.alpha = 0;
        confirmQuitCanvasGroup.interactable = false;
        confirmQuitCanvasGroup.blocksRaycasts = false;
    }

    public void ConfirmQuitYes()
    {
        Debug.Log("Until next time!!");
        Application.Quit();
    }

    public void DoQuit()
    {
        Debug.Log("Check form quit confirmation");
        uiCanvasGroup.alpha = 0.5f;
        uiCanvasGroup.interactable = false;
        uiCanvasGroup.blocksRaycasts = false;

        confirmQuitCanvasGroup.alpha = 1;
        confirmQuitCanvasGroup.interactable = true;
        confirmQuitCanvasGroup.blocksRaycasts = true;
    }

    public void DoNewGame()
    {
        Debug.Log("Launch a new game");
    }

}
