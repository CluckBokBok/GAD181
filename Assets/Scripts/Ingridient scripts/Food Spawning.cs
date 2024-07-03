using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawning : MonoBehaviour
{
    [SerializeField] private GameObject[] mainFoodItems = new GameObject[7]; // drag items in the inspector
    [SerializeField] private bool gameActive;
    [SerializeField] private float fruitSpawnPerSecond; // delay between fruit spawns (seconds)


    // Start is called before the first frame update
    void Start()
    {
        fruitSpawnPerSecond = 1.5f;
        gameActive = true;
        StartCoroutine(SpawnFruit()); // main food spawn
        StartCoroutine(FixedFruit()); // fixed food spawn
    }

    
    void FixedUpdate() // cosmetic
    {
        

    }

    IEnumerator FixedFruit() // fixed food spawns
    {
        //Debug.Log("spawning fixed food."); 
        yield return new WaitForSeconds(10f); // fixed time rate between spawns
        Instantiate(mainFoodItems[Random.Range(0, mainFoodItems.Length)], new Vector2(Random.Range(-8.3f, 8.5f), 6f), Quaternion.identity); // under the timer to prevent 2 food spawns at the start

        StartCoroutine(FixedFruit()); // loop for this coroutine
    }

    IEnumerator SpawnFruit() // MAIN food spawn loop
    {
        if (gameActive == true)
        {
            // Debug.Log("spawning main food.");
            Instantiate(mainFoodItems[Random.Range(0, mainFoodItems.Length)], new Vector2(Random.Range(-8.3f, 8.5f), 6f), Quaternion.identity);

            yield return new WaitForSeconds(fruitSpawnPerSecond);

            DifficultyLoop(); // difficulty progression (probably move out of this)
        }
 

        if (gameActive == true)
        {
            
            StartCoroutine(SpawnFruit()); // loop for this coroutine while game is active
        }
        
    }

    public void DifficultyLoop() // difficulty loop 
    {
        if (fruitSpawnPerSecond > 1f) // value = max speed of spawn rate e.g. every 1s
        {
            fruitSpawnPerSecond -= 0.025f; // reduces cooldown on spawnrate
        }
        

    }

}
