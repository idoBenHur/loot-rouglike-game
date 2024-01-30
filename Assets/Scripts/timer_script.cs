using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class timer_script : MonoBehaviour
{
    public float totalTime = 60f; // Total time in seconds
    private float currentTime;    // Current time left
    private bool isGameOver = false;

    public TextMeshProUGUI timerText;
    public TextMeshProUGUI youloseText;
    

    void Start()
    {
        currentTime = totalTime;
        UpdateTimerDisplay();
    }

    void Update()
    {
        if (!isGameOver)
        {
            // Update the timer
            currentTime -= Time.deltaTime;

            // Check if the timer has reached zero
            if (currentTime <= 0f)
            {
                currentTime = 0f;
                isGameOver = true;
                ShowGameOverScreen();
            }

            // Update the display
            UpdateTimerDisplay();
        }
    }

    void UpdateTimerDisplay()
    {
        // Format the time as minutes and seconds
        int minutes = Mathf.FloorToInt(currentTime / 60f);
        int seconds = Mathf.FloorToInt(currentTime % 60f);

        // Update the TextMeshProUGUI text
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void ShowGameOverScreen()
    {
        // Activate the "Game Over" screen or perform any other game over actions
        youloseText.gameObject.SetActive(true);
    }
}
