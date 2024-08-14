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
        if (ingredient.CompareTag("Flour"))
        {
            Debug.Log("Flour is hovered over the plate zone");
        }
        if (ingredient.CompareTag("Sugar"))
        {
            Debug.Log("Sugar is hovered over the plate zone");
        }
        if (ingredient.CompareTag("Pasta"))
        {
            Debug.Log("Pasta is hovered over the plate zone");
        }
        if (ingredient.CompareTag("Broccoli"))
        {
            Debug.Log("Broccoli is hovered over the plate zone");
        }
        if (ingredient.CompareTag("Mushroom"))
        {
            Debug.Log("Mushroom is hovered over the plate zone");
        }
        if (ingredient.CompareTag("Sausage"))
        {
            Debug.Log("Sausage is hovered over the plate zone");
        }
        if (ingredient.CompareTag("Tbone"))
        {
            Debug.Log("Tbone is hovered over the plate zone");
        }
        if (ingredient.CompareTag("Bacon"))
        {
            Debug.Log("Bacon is hovered over the plate zone");
        }
        if (ingredient.CompareTag("Fish"))
        {
            Debug.Log("Fish is hovered over the plate zone");
        }
        if (ingredient.CompareTag("Milk"))
        {
            Debug.Log("Milk is hovered over the plate zone");
        }
        if (ingredient.CompareTag("Egg"))
        {
            Debug.Log("Egg is hovered over the plate zone");
        }
        if (ingredient.CompareTag("Cheese"))
        {
            Debug.Log("Cheese is hovered over the plate zone");
        }
    }
}
