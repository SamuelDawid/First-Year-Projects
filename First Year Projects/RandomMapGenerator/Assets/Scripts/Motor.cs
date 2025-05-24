using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor : MonoBehaviour {
    public float movementspeed;
    public float rotateSpeed;
    private void FixedUpdate()
    {
        float moveVector = Input.GetAxis("Vertical");
        float rotateVector = Input.GetAxis("Horizontal");

        this.transform.Translate(0f, moveVector * movementspeed * Time.deltaTime, 0f);
        this.transform.Rotate(0f, 0f, rotateVector * (rotateSpeed * 10) * Time.deltaTime);
    }
}
