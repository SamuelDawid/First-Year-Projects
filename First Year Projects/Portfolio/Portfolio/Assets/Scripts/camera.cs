using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    GameObject Horse;
    // Use this for initialization
    void Start()
    {
        Horse = GameObject.FindGameObjectWithTag("Horse");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Horse.transform.position.x, Horse.transform.position.y, -6f);
    }
}