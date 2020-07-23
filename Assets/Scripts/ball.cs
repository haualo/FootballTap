using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    public GameObject myBall;
    private Rigidbody2D myRigidBody;
    public GameObject goTextLabel;


    public float moveUpSpeed = 300f;
    public static bool isTouched = false;
    public static bool goTextGone = false;
    void Start()
    {
        myRigidBody = myBall.GetComponent<Rigidbody2D>();
    }

    public void onClick()
    {
        isTouched = true;
    }

    // Update is called once per frame
    void Update()
    {



        if (isTouched)
        {
            if (pointController.scorePoint > 10)
            {
                moveUpSpeed = Random.Range(100, 600);
            }
            goTextLabel.SetActive(false);
            isTouched = false;
            goTextGone = true;
            myRigidBody.AddForce(new Vector2(Random.Range(-100f, 100f), moveUpSpeed));
        }
        BounceWhenDead();

    }
    
    private void BounceWhenDead()
    {
        if (dieControll.ballBounser)
        {
            myRigidBody.AddForce(new Vector2(myRigidBody.velocity.x + 20, Random.Range(300f, 500f)));
            dieControll.ballBounser = false;
        
        }

        if (boxLeftControl.ballHitWallLeft)
        {
            boxLeftControl.ballHitWallLeft = false;
            myRigidBody.AddForce(new Vector3(150, myRigidBody.velocity.y, 399));
        }

        if (boxRightControl.ballHitWallRight)
        {
            boxRightControl.ballHitWallRight = false;
            myRigidBody.AddForce(new Vector3(-150, myRigidBody.velocity.y, - 399));
        }

    }
}
