using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour
{
    public GameObject myBall;
    private Rigidbody2D myRigidBody;

    public float moveUpSpeed = 300f;
    private bool isTouched = false;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = myBall.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.touchCount > 0)
        {
            Touch touchBall = Input.GetTouch(0);
            Debug.Log("BallPressed");


            switch (touchBall.phase)
            {
                //When a touch has first been detected, change the message and record the starting position
                case TouchPhase.Began:
                    isTouched = true;
                    break;

                case TouchPhase.Ended:
                    // Report that the touch has ended when it ends
                    isTouched = false;
                    break;
            }


        }

        if (isTouched)
        {
            isTouched = false;
            myRigidBody.AddForce(new Vector2(Random.Range(-100f, 100f), moveUpSpeed));
        }
    }


    private void OnMouseDown()
    {

        isTouched = true;
        Debug.Log("MousePressed");
    }


}
