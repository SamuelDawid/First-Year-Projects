using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static int money;
    public GameObject Lose;
    float timePassed;
    public static int liveLeft = 3;
    public static bool redCard, blueCard, YellowCard; //red =1, blue =2, yellow =3;
    public static Transform startPoint;
    GameObject Car;
    // Use this for initialization
    void Start()
    {
        Car = GameObject.FindGameObjectWithTag("Player");
        startPoint = GameObject.Find("StartPoint").transform;
        Car.transform.position = startPoint.position;
    }

    // Update is called once per frame
    void Update()
        
    {
        if (liveLeft == 0)
        {
            Lose.SetActive(true);
            Time.timeScale = 0;

        }
        else
        {
            Lose.SetActive(false);
        }
            timePassed += Time.deltaTime;
        //print(money.ToString());
    }
    private void OnGUI()
    {
        GUI.Box(new Rect(30, 70, 150, 30), "Score" + money.ToString());
        GUI.Box(new Rect(30, 100, 150, 30), "Yellow" + YellowCard.ToString());
        GUI.Box(new Rect(30, 130, 150, 30), "Blue" + blueCard.ToString());
        GUI.Box(new Rect(30, 160, 150, 30), "Red" + redCard.ToString());
        
    }
}
