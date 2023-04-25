using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float timeRemaining = 10.0f;    
    

    public void StartTimer() 
    {
        StartCoroutine(CountDown());
    }

    IEnumerator CountDown() 
    {
        while (timeRemaining > 0)
        {
            yield return new WaitForSeconds(1);
            timeRemaining--;
        }

        //Lose
    }
}
