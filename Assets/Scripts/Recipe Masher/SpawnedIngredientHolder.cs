using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnedIngredientHolder : MonoBehaviour
{

    public List<GameObject> breadHolder;
    public List<GameObject> carrotHolder;
    public List<GameObject> tomatoHolder;
    public List<GameObject> potatoHolder;

    public List<GameObject> flourHolder;
    public List<GameObject> sugarHolder;
    public List<GameObject> pastaHolder;
    public List<GameObject> broccoliHolder;
    public List<GameObject> mushroomHolder;
    public List<GameObject> sausageHolder;
    public List<GameObject> tboneHolder;
    public List<GameObject> baconHolder;
    public List<GameObject> fishHolder;
    public List<GameObject> milkHolder;
    public List<GameObject> eggHolder;
    public List<GameObject> cheeseHolder;

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
        foreach (GameObject flour in flourHolder)
        {
            Destroy(flour);
        }
        foreach (GameObject sugar in sugarHolder)
        {
            Destroy(sugar);
        }
        foreach (GameObject pasta in pastaHolder)
        {
            Destroy(pasta);
        }
        foreach (GameObject broccoli in broccoliHolder)
        {
            Destroy(broccoli);
        }
        foreach (GameObject mushroom in mushroomHolder)
        {
            Destroy(mushroom);
        }
        foreach (GameObject sausage in sausageHolder)
        {
            Destroy(sausage);
        }
        foreach (GameObject tbone in tboneHolder)
        {
            Destroy(tbone);
        }
        foreach (GameObject bacon in baconHolder)
        {
            Destroy(bacon);
        }
        foreach (GameObject fish in fishHolder)
        {
            Destroy(fish);
        }
        foreach (GameObject milk in milkHolder)
        {
            Destroy(milk);
        }
        foreach (GameObject egg in eggHolder)
        {
            Destroy(egg);
        }
        foreach (GameObject cheese in cheeseHolder)
        {
            Destroy(cheese);
        }

        breadHolder.Clear();
        carrotHolder.Clear();
        tomatoHolder.Clear();
        potatoHolder.Clear();
        flourHolder.Clear();
        sugarHolder.Clear();
        pastaHolder.Clear();
        broccoliHolder.Clear();
        mushroomHolder.Clear();
        sausageHolder.Clear();
        tboneHolder.Clear();
        baconHolder.Clear();
        fishHolder.Clear();
        milkHolder.Clear();
        eggHolder.Clear();
        cheeseHolder.Clear();
    }
}
