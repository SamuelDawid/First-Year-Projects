using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour {

    public static float scoreValue = 0;
    public static float highscore;
    public float scores;
    TextMeshProUGUI score;
    private void Start()
    {
        score = GetComponent<TextMeshProUGUI>();
    }
    private void Awake()
    {
        highscore = PlayerPrefs.GetFloat("HighScore", 0);
        print("HighScore" + highscore);
    }
    private void Update()
    {
        score.text = "Score" + scoreValue;
        
        
    }
    public float ReturnScore()
    {
        return scores;
    }
    public void AddToScoreValue(float scoreValue)
    {
        scores = scoreValue;
        if(scores > highscore)
        {
            highscore = scores;
            PlayerPrefs.SetFloat("HighScore", highscore);
        }
    }
    
}
