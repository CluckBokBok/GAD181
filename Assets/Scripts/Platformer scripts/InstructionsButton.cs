using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InstructionsButton : MonoBehaviour
{

    public GameObject InstructionsPanel;
    public bool InstructionsPanelActive = false;
    public Countdown countDown;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    public void MenuButtonPress()
    {
       
            InstructionsPanel.SetActive(true);

        Time.timeScale = 0; // pauses game // 0 = pause, 1 = default speed, 2 = double speed

            // countDown.countingDown = false;
            Debug.Log("time stopped"); 

    }

    public void CloseButtonPress()
    {
        InstructionsPanel.SetActive(false);

        Time.timeScale = 1; // resumes game

        //countDown.GetComponent<Countdown>().resumeTimer();


        Debug.Log("Panel Closed");
    }

 

}
