using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Countdown : MonoBehaviour
{
    
    public Text countdownDisplay;

    public int countdownTimer;

    public GameObject CountDownUI;

    
    


    public void Start()
    {
        StartCoroutine(CountdowntoStart());
        
    }
    IEnumerator CountdowntoStart()
    {
        while (countdownTimer >0)
        {
            countdownDisplay.text = countdownTimer.ToString();

            yield return new WaitForSecondsRealtime(1f);

            countdownTimer--;
        }
         

        CountDownUI.SetActive(false);

        Time.timeScale = 1f;


    }

}
