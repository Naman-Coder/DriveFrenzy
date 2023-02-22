using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private bool hasPackage;
    Timer timer;
    public int noOfPackage = 0;

    void Start() {
    timer = FindObjectOfType<Timer>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Package") {
            noOfPackage+=1;
            Debug.Log("Package picked up!");
            hasPackage = true;
            Destroy(other.gameObject, 0.2f);
        }
        if(other.tag == "Finish" && hasPackage == true) {
            Debug.Log("Package delivered!");
            hasPackage = false;
            timer.isOver = true;
            Time.timeScale = 0;
        }
    }
}



