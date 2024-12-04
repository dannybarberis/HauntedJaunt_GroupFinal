using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameTimer : MonoBehaviour

// MAJOR MOD: You add a UI element to the game. 
// It is a timer! John Lemon has to reach the end of the level at a certain time or the game ends.

{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    public GameEnding gameEnding;

    void Start()
    {

    }

    void Update()
    {
        if (remainingTime > 0.05) // 0.05 to give engine enough time to run before timer shows a negative number
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 0.05)
        {
            remainingTime = 0;
            timerText.color = Color.red;
            gameEnding.TimeOut (); // Function call for Script GameEnding

        }
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
