using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startTime = 45f;

    [SerializeField] Text countdownText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
       currentTime -= 1 * Time.deltaTime;
       countdownText.text = currentTime.ToString("0");

       countdownText.color = Color.black;
       

        if (currentTime <= 0){
            currentTime = 0;

        }   
        
    
       if(currentTime <= 5){
           countdownText.color = Color.red;
       }
    }
    public void TimerOff(int starsRemaining)
    {
        if(currentTime <= 0 && starsRemaining > 0){
           //currentTime = 0;
           Time.timeScale = 0;
           SceneManager.LoadScene("Main Menu"); 
           //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
           //Debug.Log("Game Over!");

        }
        if (starsRemaining == 0 && currentTime >= 0)
        {
            currentTime = 0;
            Time.timeScale = 0;

        }
    }   
    
}
