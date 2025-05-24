using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBalls : MonoBehaviour {
    [SerializeField] Transform leftBallSpawnPoint, rightBallSpawnPoint;
    [SerializeField] GameObject ball;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            NewMethod();
        }
        if (Input.GetKeyDown(KeyCode.RightAlt))
        {
            OtherMetgod();
        }
        
    }

    private void NewMethod()
    {
        Instantiate(ball, leftBallSpawnPoint.position, Quaternion.identity);
    }
    private void OtherMetgod()
    { 
        Instantiate(ball, rightBallSpawnPoint.position, Quaternion.identity);

    }
}
