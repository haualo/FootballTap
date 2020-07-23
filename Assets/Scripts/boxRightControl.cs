using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxRightControl : MonoBehaviour
{
    public static bool ballHitWallRight = false;
    // Start is called before the first frame update

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            ballHitWallRight = true;
        }
    }
}
