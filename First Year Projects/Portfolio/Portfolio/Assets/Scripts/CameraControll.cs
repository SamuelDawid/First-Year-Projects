using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour {
    GameObject car;
	// Use this for initialization
	void Start () {
        car = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(car.transform.position.x, car.transform.position.y, -12f);
	}
}
