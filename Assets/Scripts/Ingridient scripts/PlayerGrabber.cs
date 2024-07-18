using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerGrabber : MonoBehaviour
{
    public FoodInfo FoodInfo;
    public Countdown ingredientTimer;
    public ScoreHolder scoreHolder;
    [SerializeField] private bool foodPicked;
    [SerializeField] private int timeAdd;
    [SerializeField] private int timeRemove;

    // Start is called before the first frame update
    void Start()
    {
        FoodInfo = FindAnyObjectByType<FoodInfo>();
        ingredientTimer = FindAnyObjectByType<Countdown>();
        timeAdd = 15;
        timeRemove = -20;
        Time.timeScale = 1f; // game speed
    }

    // Update is called once per frame
    void Update()
    {
        if (ingredientTimer.GetComponent<Countdown>().timeCountdown <= 0)
        {
            LoadNextScene(0);
        }
    }

    private void OnTriggerEnter2D(Collider2D touched) // Gfood collision
    {
        void DestroyFood()
        {
            // Debug.Log("DestroyFood");
            Destroy(touched.gameObject);
        }

        if (touched.gameObject.CompareTag("Bad Timer"))
        {
            ingredientTimer.GetComponent<Countdown>().timeCountdown += timeRemove;

            DestroyFood();
        }

        else if (touched.gameObject.CompareTag("Good Timer"))
        {
            ingredientTimer.GetComponent<Countdown>().timeCountdown += timeAdd;

            DestroyFood();
        }

        else if (touched.gameObject.CompareTag("GFood"))
        {
            Debug.Log("You picked up " + touched.GetComponent<FoodInfo>().foodName + "!");
            scoreHolder.playerScore += 1; 

            // ingredientTimer.GetComponent<Countdown>().timeCountdown += timeRemove;



            DestroyFood(); // used to destroy
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }

    public void LoadNextScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

}
