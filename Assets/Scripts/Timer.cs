using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public bool isOver;
    public TMP_Text timer;
    public float timeValue = 60;
    void Start()
    {
        timer = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        if (timeValue > 0) {
            timeValue -= Time.deltaTime;
            timer.text = "Timer: " + Mathf.FloorToInt(timeValue);
        }

        else {
            timeValue = 0;
            timer.text = "Timer: " + timeValue;
            isOver = true;
            Time.timeScale = 0;
        }
    }
}
