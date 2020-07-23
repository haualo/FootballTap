using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveClouds : MonoBehaviour
{
    public Transform cloudTransform;
    public GameObject cloudObject;
    private Rigidbody2D myRigidBody;

    [SerializeField] private  float cloudSpeed = 0.03f;

    private bool isCreated = false;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = cloudObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        myRigidBody.velocity = new Vector2(cloudSpeed, 0);


        if(cloudTransform.position.x > 5f)
        {
            Vector3 myCopyBos = new Vector3(-11.5f, 0f, 0f);
            if (!isCreated)
            {
                Instantiate(cloudTransform, myCopyBos, Quaternion.identity);
                isCreated = true;
            }
        }
        if(cloudTransform.position.x > 20f)
        {
            Destroy(cloudObject);
        }
    }
}
