using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerGrabber : MonoBehaviour
{
    public FoodInfo FoodInfo;
    [SerializeField] private int playerScore;

    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0;
        FoodInfo = FindAnyObjectByType<FoodInfo>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerScore >= 100)
        {
            LoadNextScene(0);
        }
    }

    private void OnTriggerEnter2D(Collider2D touched)
    {
        if (touched.gameObject.CompareTag("GFood"))
        {
            Debug.Log("You picked up " + touched.GetComponent<FoodInfo>().foodName + "!");
            playerScore += 1;

            DestroyFood(); // used to destroy

            void DestroyFood()
            {
                // Debug.Log("DestroyFood");
                Destroy(touched.gameObject);
            }
        }
    }

    public void LoadNextScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
