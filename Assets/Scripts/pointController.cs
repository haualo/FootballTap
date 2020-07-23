using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointController : MonoBehaviour
{

    public static int scorePoint;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        if (GameOverMenu.continueIsPressed)
        {
            scorePoint = PlayerPrefs.GetInt("SCOREIN");
            GameOverMenu.continueIsPressed = false;
        }
        else
        {
            scorePoint = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (ball.isTouched)
        {
            scorePoint += 1;
        }
        scoreText.text = scorePoint.ToString();
        PlayerPrefs.SetInt("SCOREIN", scorePoint);
    }
}
