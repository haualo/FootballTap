using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxLeftControl : MonoBehaviour
{
    public static bool ballHitWallLeft = false;
    // Start is called before the first frame update

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            ballHitWallLeft = true;
        }
    }
}
