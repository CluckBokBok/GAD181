using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{

    [SerializeField] private Button startButton;
    [SerializeField] private GameObject turnOffStartButton;
    [SerializeField] private GameObject turnOffTitleText;
    [SerializeField] private GameObject turnOnPickAGameText;
    [SerializeField] private GameObject turnOnPickAGameButtonOne;
    [SerializeField] private GameObject turnOnPickAGameButtonTwo;
    [SerializeField] private GameObject turnOnPickAGameButtonThree;

    // Start is called before the first frame update
    void Start()
    {
        if (startButton == null)
        {
            Debug.Log("No reference for start button");
        }

        turnOffStartButton.SetActive(true);
        turnOffTitleText.SetActive(true);
        turnOnPickAGameText.SetActive(false);
        turnOnPickAGameButtonOne.SetActive(false);
        turnOnPickAGameButtonTwo.SetActive(false);
        turnOnPickAGameButtonThree.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStartButtonClick()
    {
        Debug.Log("Start button was clicked!");
        turnOffStartButton.SetActive(false);
        turnOffTitleText.SetActive(false);
        turnOnPickAGameText.SetActive(true);
        turnOnPickAGameButtonOne.SetActive(true);
        turnOnPickAGameButtonTwo.SetActive(true);
        turnOnPickAGameButtonThree.SetActive(true);
    }
}
