using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Countdown : MonoBehaviour
{
    public int timeCountdown;
    public bool countingDown;
    public TextMeshProUGUI timerText;
    public GameObject LevelFail;
    public int timeToCountdown;
    

    // Start is called before the first frame update
    void Start()
    {
        timeToCountdown = 45;
        timeCountdown = timeToCountdown;
        countingDown = true;
        StartCoroutine(timerStart());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator timerStart()
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
            LevelFail.SetActive(true);
        }
        

    }

    public void resumeTimer()
    {
        StartCoroutine(timerStart());
        Debug.Log("resumed timer");
    }
        
}
