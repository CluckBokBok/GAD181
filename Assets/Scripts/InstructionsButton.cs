using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsButton : MonoBehaviour
{

    public GameObject InstructionsPanel;
    public bool InstructionsPanelActive = false; 


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
      


    }

    public void CloseButtonPress()
    {
       
            InstructionsPanel.SetActive(false);
       
    }



}
