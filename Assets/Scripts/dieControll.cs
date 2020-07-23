using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dieControll : MonoBehaviour
{

    public static bool isGameOver = false;
    public static bool ballBounser = false;
    // Start is called before the first frame update

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Ball")
        {

            isGameOver = true;
            ballBounser = true;
        }
    }
}
