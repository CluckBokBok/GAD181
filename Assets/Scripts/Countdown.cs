using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Countdown : MonoBehaviour
{
    public int timeCountdown;
    public bool countingDown;
    public TextMeshProUGUI timerText; // timer UI
    public GameObject LevelFail; // fail UI
    public int timeToCountdown; // change in inspector for timer duration
    

    // Start is called before the first frame update
    void Start()
    {
       
        timeCountdown = timeToCountdown;
        countingDown = true;
        StartCoroutine(timerStart()); // starts timer

        if (LevelFail == null) // checks for level fail UI
        {
            Debug.Log("Cannot find Level Fail. (Countdown.cs)");
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator timerStart() // the timer
    {

        countingDown = true;
        while (timeCountdown > 0 && countingDown == true)
        {
            timerText.text = timeCountdown.ToString();
            yield return new WaitForSeconds(1f);
            timeCountdown--;
        }

        if (timeCountdown <= 0) 
        {
            yield return new WaitForSeconds(1f);
            timerText.gameObject.SetActive(false);

            if (LevelFail != null)
            {
                LevelFail.SetActive(true);
            }



        }
        

    }

    public void resumeTimer() // set countingdown false and use this function to resume timer
    {
        StartCoroutine(timerStart());
        Debug.Log("resumed timer");
    }
        
}
