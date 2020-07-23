using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveStars : MonoBehaviour
{
    public Transform starTransform;
    public GameObject starObject;
    private Rigidbody2D myRigidBody;

    [SerializeField] private float starSpeed = 0.03f;

    private bool isCreated = false;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = starObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        myRigidBody.velocity = new Vector2(starSpeed, 0);

        if (starTransform.position.x > 5f)
        {
            Vector3 myCopyBos = new Vector3(-11.5f, 0f, 0f);
            if (!isCreated)
            {
                Instantiate(starTransform, myCopyBos, Quaternion.identity);
                isCreated = true;
            }
        }
        if (starTransform.position.x > 20f)
        {
            Destroy(starObject);
        }
    }
}
