using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreHolder : MonoBehaviour
{
    [SerializeField] private PlayerGrabber playerGrabberScript;
    public int playerScore;
    [SerializeField] private TextMeshProUGUI playerScoreText;


    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerScore > 0)
        {
            playerScoreText.text = playerScore.ToString();
        }
    }
}
