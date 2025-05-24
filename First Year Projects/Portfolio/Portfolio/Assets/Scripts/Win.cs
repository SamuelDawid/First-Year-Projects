using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour {
    public GameObject WinText;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            WinText.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            WinText.SetActive(false);
        }
    }
}
