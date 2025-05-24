using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChanger : MonoBehaviour {

	public void LoadMyScene(string sceneName)
    {

        SceneManager.LoadScene(sceneName);
        Pachinko.bolls = 25;
        Scores.score = 0;
        MasterMind.howManyRight = 0;
        Manager.liveLeft = 3;
        Manager.money = 0;
        Control.liveLeft = 3;


    }
}
