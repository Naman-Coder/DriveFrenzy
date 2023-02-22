using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Timer gameScreen;
    EndScreen endScreen;
    AICar1 aicar1; 
    AICar2 aicar2; 
    AICar3 aicar3;
    
    
    void Start()
    {
        gameScreen = FindObjectOfType<Timer>();
        endScreen = FindObjectOfType<EndScreen>();
        aicar1 = FindObjectOfType<AICar1>();
        aicar2 = FindObjectOfType<AICar2>();
        aicar3 = FindObjectOfType<AICar3>();
        
        gameScreen.gameObject.SetActive(true);
        if(endScreen.gameObject.activeSelf){
            endScreen.gameObject.SetActive(false);
        }

        aicar1.gameObject.SetActive(false);
        aicar2.gameObject.SetActive(false);
        aicar3.gameObject.SetActive(false);
        
    }
    

    void Update()
    {
        if(gameScreen.isOver == true)
            endScreen.gameObject.SetActive(true);
        
    }
}
