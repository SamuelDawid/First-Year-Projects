using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaet : MonoBehaviour {

    public bool chate = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            moving.maxJumpHeigh = 10;
        }
    }
}
