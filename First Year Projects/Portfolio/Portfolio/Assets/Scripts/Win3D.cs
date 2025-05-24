using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win3D : MonoBehaviour {

    private void Update()
    {
        if(Scores.score == 2500)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
