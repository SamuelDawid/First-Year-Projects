using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HellScript : MonoBehaviour
{
    GameObject Horse;
    public Transform startPoint;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Horse = GameObject.FindGameObjectWithTag("Horse");
        startPoint = GameObject.Find("StartPoint").transform;
        Horse.transform.position = startPoint.position;
        Control.liveLeft--;
    }
}
