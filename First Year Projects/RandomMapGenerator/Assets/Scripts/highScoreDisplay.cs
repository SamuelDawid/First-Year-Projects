using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class highScoreDisplay : MonoBehaviour {
    TextMeshProUGUI highscore;
	// Use this for initialization
	void Start () {
        highscore = GetComponent<TextMeshProUGUI>();
	}
	
	// Update is called once per frame
	void Update () {
        highscore.text = ("" + PlayerPrefs.GetFloat("HighScore", 0));
	}
}
