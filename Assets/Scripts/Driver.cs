using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    float steerSpeed = 200.0f;
    float moveSpeed = 20.0f;
    Timer timer;
    AICar1 aicar1; 
    AICar2 aicar2; 
    AICar3 aicar3;
    public bool isCollided; 
    
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "AICar"){
            timer.isOver = true;
            Time.timeScale = 0;
            isCollided = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "SlowZone"){
            moveSpeed = 10f;
        }
        if(other.name == "Trigger1"){
            aicar1.gameObject.SetActive(true);
        }
        if(other.name == "Trigger2"){
            aicar2.gameObject.SetActive(true);
        }
        if(other.name == "Trigger3"){
            aicar3.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.tag == "SlowZone"){
            moveSpeed = 20f;
        }
    }

    void Start()
    {
        timer = FindObjectOfType<Timer>();
        aicar1 = FindObjectOfType<AICar1>();
        aicar2 = FindObjectOfType<AICar2>();
        aicar3 = FindObjectOfType<AICar3>();
    }

    
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
