using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class manager : MonoBehaviour
{

    [Header("Ball")] public GameObject ball;
    [Header("Score UI")] public GameObject player1text;

    private int playerScore;

    // Start is called before the first frame update
    public void Player1Scored()
    {
        playerScore++;
        player1text.GetComponent<TextMeshProUGUI>().text = playerScore.ToString();
        ball.GetComponent<ball>().IncreaseSpeed();
    }

    // Update is called once per frame
    public void Reset()
    {
        playerScore = 0;
        player1text.GetComponent<TextMeshProUGUI>().text = playerScore.ToString();
    }
}
