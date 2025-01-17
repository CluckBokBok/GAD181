using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public int playerLives; // default players lives should be set to 3
    public int playerScore; // should be 0 at the start
    public int scoreRequiredToWin; // score needed to win
    public bool excessScore;
    public GameObject LevelPass;
    public GameObject LevelFail;
    public GameObject WinObject;
    public GameObject CountdownText;
    public GameObject LivesThree;
    public GameObject LivesTwo;
    public GameObject LivesOne;

    // Start is called before the first frame update
    void Start()
    {
        excessScore = true;
        playerLives = 3; // current players lives
        scoreRequiredToWin = 7; 
    }

    // Update is called once per frame
    void Update()
    {
        if (playerLives <= 0)
        {
            LevelFail.SetActive(true);
        }

        PlayerHealthBar(); 
    }

    private void OnTriggerEnter2D(Collider2D Pickedup)
    {
        if (playerScore >= scoreRequiredToWin && excessScore == true)
        {
            Debug.Log("potato");
            Instantiate(WinObject, new Vector3(-8.43f, 0.47f, -0.067f), Quaternion.Euler(0, 0, 0));
            excessScore = false;

        }

        if (Pickedup.gameObject.tag == "Food") // checks for "food" tag on the collided object
        {                        
            Destroy(Pickedup.gameObject); // destroys the object that came in contact
            playerScore += 1; // adds one score to the player
            Debug.Log("Player picked up a " + Pickedup.gameObject.GetComponent<FoodInfo>().foodName + "!"); // debugs the specific food that has been picked up
        }

        if (Pickedup.gameObject.tag == "EndPoint") // checks for "EndPoint" tag on the collided object
        {
            Destroy(Pickedup.gameObject);
            Debug.Log("Player picked up end point object.");

            if (playerScore >= scoreRequiredToWin)
            {
                LevelPass.SetActive(true);
                CountdownText.gameObject.GetComponent<Countdown>().timerText.gameObject.SetActive(false);


            }


        }

        if (Pickedup.gameObject.tag == "LifeLost") // checks for "LifeLost" tag on the collided object
        {
            Destroy(Pickedup.gameObject); // nick (this code is repeated but is required to function as of now)
            playerLives += -1; // removes one life from the player
            if (playerLives > 0)
            {
                Debug.Log("Player has lost 1 life.");
            }

            else
            {
                Debug.Log("Player has died... You Lose!");
                // the death related stuff will need to be added into this later
            }
            
        }



        
        // IGNORE
        //else if (Pickedup.gameObject.tag == "Meat")
        //{
        //    Destroy(Pickedup.gameObject); // destroys the object that came in contact
        //    Debug.Log("Player picked up a " + Pickedup.gameObject.GetComponent<FoodInfo>().foodName + "!"); // debugs the specific food that has been picked 
        //    Scene.lo
        //}



    }

    public void PlayerHealthBar()
    {
        if (playerLives >= 3)
        {
            LivesThree.SetActive(true);
        }
        if (playerLives == 2)
        {
            LivesThree.SetActive(false);
            LivesTwo.SetActive(true);
        }
        if (playerLives == 1)
        {
            LivesTwo.SetActive(false);
            LivesOne.SetActive(true);
        }
        if (playerLives <= 0)
        {
            LivesOne.SetActive(false);
        }
    }
}
