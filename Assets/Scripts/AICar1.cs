using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICar1 : MonoBehaviour
{
    float speed = 20.0f;

    void Update()
    {
        float moveAmount = speed * Time.deltaTime;
        transform.Translate(0, moveAmount, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if we have collided with another car
        if (collision.gameObject.tag == "MainCar")
        {
            // Stop the car for a moment
            speed = 0;
            //Invoke("ResumeDriving", 2.0f);
        }
    }

    void ResumeDriving()
    {
        // Resume driving after a short delay
        speed = 10.0f;
    }
}
