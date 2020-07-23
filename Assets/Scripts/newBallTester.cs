using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newBallTester : MonoBehaviour
{

    public GameObject myNewBall = null;
    // Start is called before the first frame update
    void Start()
    {

        Instantiate(myNewBall, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
