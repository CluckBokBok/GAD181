using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerrespawner : MonoBehaviour
{
    public GameObject respawnPoint;
    public GameObject player;

    // the method for respawning
    public void Respawn()
    {
        // makes the player's coordinates equal the respoint point coordinates
        player.transform.position = respawnPoint.transform.position;
        Physics.SyncTransforms(); //forces unity to update the physic changes
        Debug.Log("The player should be respawned"); // console logs
    }
}
