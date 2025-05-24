using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheat : MonoBehaviour {

    public float cheat;
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            Manager.blueCard = true;
            Manager.redCard = true;
            Manager.YellowCard = true;
            Manager.money += 50000;

        }
    }
}
