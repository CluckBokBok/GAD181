using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D Pickedup)
    {

        if (Pickedup.gameObject.tag == "Food") // checks for checks for "food" tag on the collided object
        {                        
            Destroy(Pickedup.gameObject); // destroys the object that came in contact
            Debug.Log("Player picked up a " + Pickedup.gameObject.GetComponent<FoodInfo>().foodName + "!"); // debugs the specific food that has been picked up
        }



        
    }
}
