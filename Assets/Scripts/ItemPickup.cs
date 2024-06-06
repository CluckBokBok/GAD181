using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SearchService;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public int playerLives; // default players lives should be set to 3
    public int playerScore; // should be 0 at the start
    public int scoreRequiredToWin; // score needed to win

    // Start is called before the first frame update
    void Start()
    {
       
        playerLives = 3; // current players lives
        scoreRequiredToWin = 5; // NOT USED YET ---------
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D Pickedup)
    {

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
            if (playerScore == 0)
            {
                Debug.Log("Are you sure your a rat?");
            }

        }

        if (Pickedup.gameObject.tag == "LifeLost") // checks for "LifeLost" tag on the collided object
        {
            Destroy(Pickedup.gameObject); // nick (this code is repeated but is required to function as of now)
            playerLives += -1; // removes one life from the player
            playerScore += -1; // removes one score from the players
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
}
