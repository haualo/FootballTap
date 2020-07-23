using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainScoreLabel : pointController
{

    // Update is called once per frame
    void Update()
    {
        Debug.Log(ball.isTouched);
        if (ball.isTouched)
        {
            scorePoint++;
            Debug.Log("GET SCORE");
        }
        scoreText.text = scorePoint.ToString();
    }

}
