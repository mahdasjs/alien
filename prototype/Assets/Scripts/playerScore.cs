using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerScore : MonoBehaviour
{
    private Text scoreText;
    private int score = 0;

    void Awake()
    {
        scoreText = GameObject.Find("score").GetComponent<Text>();
        scoreText.text = "0";
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "coin")
        {
            score++;
            scoreText.text = score.ToString();
            target.gameObject.SetActive(false);
        }
        if (target.tag == "rocket")
        {
            target.gameObject.SetActive(false);
        }
    }
}
