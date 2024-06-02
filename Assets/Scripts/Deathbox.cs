using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathbox : MonoBehaviour
{
    public Playerrespawner respawnPlayer;


    public bool inside = false;

    // Update is called once per frame
    void Update()
    {
        //checks the inside condition
        if (inside == true)
        {
            // respawns player
            respawnPlayer.Respawn();

            // makes the bool false
            inside = false;
        }
    }

    // trigger enter 
    private void OnTriggerEnter2D(Collider2D deathBox)
    {
        //checks if the thing that entered the trigger is tagged with player
        if (deathBox.gameObject.CompareTag("Player"))
        {
            // console logs to see if it worked
            Debug.Log("The player is inside the death box");

            //changes bool to true
            inside = true;

        }

    }

    //triggers when something exits
    private void OnTriggerExit2D(Collider2D deathBox)
    {
        // checks if player has left, this is to confirm it
        Debug.Log("Player has left the death box");

        //makes bool inside falseS
        inside = false;
    }
}
