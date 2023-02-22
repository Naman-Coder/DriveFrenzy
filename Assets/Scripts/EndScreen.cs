using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    Timer timer;
    [SerializeField] TextMeshProUGUI endScreenText;
    [SerializeField] TextMeshProUGUI highScore;
    Delivery delivery;
    Driver driver;
    
    void Start()
    {
        timer = FindObjectOfType<Timer>();
        delivery = FindObjectOfType<Delivery>();
        driver = FindObjectOfType<Driver>();
    }

    void Update()
    {
        int totalScore = (Mathf.FloorToInt(timer.timeValue)) * delivery.noOfPackage;
        int currentHighScore = PlayerPrefs.GetInt("HighScore", 0);
        // PlayerPrefs.DeleteKey("HighScore");
        // PlayerPrefs.Save();
        if (totalScore > currentHighScore) {
            PlayerPrefs.SetInt("HighScore", totalScore);
            PlayerPrefs.Save();
        }

        if(driver.isCollided == true) {
            endScreenText.text = "Game Over\nYou Crashed";
        }
        else {
            endScreenText.text = "Game Over\nYou finished with " + Mathf.FloorToInt(timer.timeValue) + " seconds left\n" + 
            "The number of packages collected was: " + delivery.noOfPackage + "\nYour Total Score is: " + totalScore;
            highScore.text = "Your High Score is: " + currentHighScore.ToString();
        }
    }

}
