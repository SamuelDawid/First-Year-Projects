using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class time : MonoBehaviour {
    public float DestroyTime = 3f;
	// Use this for initialization
	void Start () {
        Destroy(gameObject, DestroyTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
