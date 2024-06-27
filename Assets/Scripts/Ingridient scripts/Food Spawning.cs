using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawning : MonoBehaviour
{
    [SerializeField] private GameObject[] foodItems = new GameObject[7];

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Instantiate(foodItems[Random.Range(0, foodItems.Length)], new Vector2(Random.Range(-8.3f, 8.5f), 6f), Quaternion.identity);

    }
}
