using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Scores : MonoBehaviour {
    public static int score = 0;
    private void OnTriggerEnter(Collider other)
    {
        {
            if (other.gameObject.CompareTag("Boll"))

            {
                score += 100;
            }
            
        }
    }


}
