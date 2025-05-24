using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public static int points;
    public static int liveLeft = 3;
    public  GameObject Lose;
        
    public static Transform startPoint;
    GameObject Horse;
    

    private void Start()
    {
         Horse = GameObject.FindGameObjectWithTag("Horse");
         startPoint = GameObject.Find("StartPoint").transform;
        Horse.transform.position = startPoint.position;
    }
    private void Update()
    {
        
        if(points == 3)
        {
            TresureCollect.tresure = true;
        }
        if (Control.liveLeft == 0)
        {
            Lose.SetActive(true);
            Time.timeScale = 0f;
            
            
            
        }
        else
        {
            Lose.SetActive(false);
        }
       

    }
    private void OnGUI()
    {
        GUI.Box(new Rect(30, 70, 150, 30), "Score: " + points.ToString());
        GUI.Box(new Rect(30, 110, 150, 30), "Tresure: " + TresureCollect.tresure.ToString());
        
        
    }
}

