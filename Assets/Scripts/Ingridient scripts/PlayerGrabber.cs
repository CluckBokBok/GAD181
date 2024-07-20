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
        if (ingredientTimer.GetComponent<Countdown>().timeCountdown <= 0) // when counter reaches 0 or less
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

        if (touched.gameObject.CompareTag("Bad Timer")) // when picking up bad time
        {
            ingredientTimer.GetComponent<Countdown>().timeCountdown += timeRemove; // removes time from countdown

            DestroyFood();
        }

        else if (touched.gameObject.CompareTag("Good Timer")) // when picking up good time 
        {
            ingredientTimer.GetComponent<Countdown>().timeCountdown += timeAdd; // adds time to countdown

            DestroyFood();
        }

        else if (touched.gameObject.CompareTag("GFood")) // when picking up basic food
        {
            Debug.Log("You picked up " + touched.GetComponent<FoodInfo>().foodName + "!"); // debug food grabbed
            scoreHolder.playerScore += 1; // adds score to the player's score

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
