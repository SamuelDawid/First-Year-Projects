using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {
    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void LoadGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Dungeon");
    }
    public void LoadStartMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
    public void Quit()
    {
        Application.Quit();   
    }
    public void EndGame()
    {
        SceneManager.LoadScene("EndGame");
        Time.timeScale = 0;
    }
}
