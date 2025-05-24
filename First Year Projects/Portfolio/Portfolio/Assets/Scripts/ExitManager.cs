using UnityEngine.SceneManagement;
using UnityEngine;

public class ExitManager : MonoBehaviour {
    GameObject menuObject;
    bool paused = false;
    // Use this for initialization
    void Start()
    {
        menuObject = GameObject.FindGameObjectWithTag("MenuOption");
        menuObject.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!paused)
            {
                PausedGame();
            }
            else
            {
                ResumeGame();
            }

        }
    }
    public void PausedGame()
    {
        menuObject.SetActive(true);
        paused = true;
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void ResumeGame()
    {
        menuObject.SetActive(false);
        paused = false;
        Time.timeScale = 1; ;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
   
   

    public void BackToMain()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
