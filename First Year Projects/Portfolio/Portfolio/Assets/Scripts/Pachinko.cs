using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pachinko : MonoBehaviour
{
    
    public static int bolls = 25;
    public static float youlose;
    public GameObject Win;
    public GameObject loose;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftAlt) || Input.GetKeyDown(KeyCode.RightAlt))
        {
            bolls--;
        }

        if (Scores.score == 1500)
        {
            Win.SetActive(true);
            Time.timeScale = 0f;
        }
        
        if (bolls <= -1)
        {
            loose.SetActive(true);
            Time.timeScale = 0f;

        }

    }




    private void OnGUI()
    {
        GUI.Box(new Rect(30, 10, 200, 40), "Balls Left: " + bolls.ToString());
        GUI.Box(new Rect(30, 40, 200, 40), "Score:" + Scores.score.ToString());
    }
}
