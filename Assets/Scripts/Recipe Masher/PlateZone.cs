using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D ingredient)
    {
        if (ingredient.CompareTag("Bread"))
        {
            Debug.Log("Bread is hovered over the plate zone");
        }
        if (ingredient.CompareTag("Tomato"))
        {
            Debug.Log("Tomato is hovered over the plate zone");
        }
        if (ingredient.CompareTag("Potato"))
        {
            Debug.Log("Potato is hovered over the plate zone");
        }
        if (ingredient.CompareTag("Carrot"))
        {
            Debug.Log("Carrot is hovered over the plate zone");
        }
    }
}
