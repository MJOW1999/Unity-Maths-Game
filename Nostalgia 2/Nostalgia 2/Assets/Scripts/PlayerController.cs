using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public CountdownTimer ct;
    public float speed;
    public Text starsText;
    public Text starsComplete;
    int starsRemaining;
    public static int nextLevelIndex;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        starsRemaining = GameObject.FindGameObjectsWithTag("Star").Length;
        starsComplete.text = "";
        SetStarsText();
        //ct = GetComponent<CountdownTimer>();
        //ct.enabled = false;
    }

    void Awake()
    {
        ct = GameObject.FindObjectOfType<CountdownTimer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput * speed;
    }

    void FixedUpdate(){

        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Star"))
        {
            Destroy(other.gameObject);
            starsRemaining--;
            SetStarsText();
        }

    }

    void SetStarsText()
    {
        starsText.text = "Stars Remaining: " + starsRemaining.ToString();
        if (starsRemaining <= 0)
        {
            starsRemaining = 0;
            ct.TimerOff(starsRemaining);
            starsComplete.text = "Well Done! You collected all of the stars!";
            //starsComplete.text
            //Time.timeScale = 0;
            nextLevelIndex = Application.loadedLevel + 1;
            SceneManager.LoadScene(nextLevelIndex);
            //SceneManager.LoadScene("Question 1");
        }

    }
}
