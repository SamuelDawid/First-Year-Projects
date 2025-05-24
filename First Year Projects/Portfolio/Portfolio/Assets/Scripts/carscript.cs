using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carscript : MonoBehaviour {

    public Image[] lifes;

    public void Update()
    {
        if (Manager.liveLeft == 2)
        {
            lifes[0].gameObject.SetActive(false);
        }
        if (Manager.liveLeft == 1)
        {
            lifes[1].gameObject.SetActive(false);
        }
        if (Manager.liveLeft == 0)
        {
            lifes[2].gameObject.SetActive(false);

        }
    }
}

