using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScipt : MonoBehaviour {
    [SerializeField] GameObject win;
    [SerializeField] GameObject loose;

    public void Update()
    {
        if(MasterMind.howManyRight == 4)
        {
            win.SetActive(!win.activeSelf);
            
        }
        if(MasterMind.howManyRight <= 3)
        {
            loose.SetActive(!loose.activeSelf);
        }
    }
}
