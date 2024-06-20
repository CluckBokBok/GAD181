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
            countDown.countingDown = false;
            Debug.Log("time stopped"); 

    }

    public void CloseButtonPress()
    {
        InstructionsPanel.SetActive(false);
        countDown.GetComponent<Countdown>().resumeTimer();


        Debug.Log("Panel Closed");
    }

 

}
