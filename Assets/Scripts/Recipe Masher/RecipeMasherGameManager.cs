using SAE.GAD181.Game3;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeMasherGameManager : MonoBehaviour
{
    public List<GameObject> lives = new List<GameObject>();
    public GameObject liveOne;
    public GameObject liveTwo;
    public GameObject liveThree;
    public GameObject levelFail;
    public GameObject LevelPass; 
    public CheckRecipeSubmission checkRecipeSubmission;
    public Countdown countdown;

    // Start is called before the first frame update
    void Start()
    {
        lives.Add(liveOne);
        lives.Add(liveTwo);
        lives.Add(liveThree);
    }

    // Update is called once per frame
    void Update()
    {
        if (checkRecipeSubmission.playerLives <= 0)
        {
            Debug.Log("Game Over");
            levelFail.SetActive(true);
            countdown.countingDown = false;
        }
        if (checkRecipeSubmission.playerPoints >= 5)
        {
            LevelPass.SetActive(true);
            countdown.countingDown = false;
        }
        
    }
}
