using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnedIngredientHolder : MonoBehaviour
{

    public List<GameObject> breadHolder;
    public List<GameObject> carrotHolder;
    public List<GameObject> tomatoHolder;
    public List<GameObject> potatoHolder;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClearingIngredientList()
    {
        foreach (GameObject bread in breadHolder)
        {
            Destroy(bread);
        }
        foreach (GameObject carrot in carrotHolder)
        {
            Destroy(carrot);
        }
        foreach (GameObject tomato in tomatoHolder)
        {
            Destroy(tomato);
        }
        foreach (GameObject potato in potatoHolder)
        {
            Destroy(potato);
        }

        breadHolder.Clear();
        carrotHolder.Clear();
        tomatoHolder.Clear();
        potatoHolder.Clear();
    }
}
