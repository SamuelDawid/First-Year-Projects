using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolldestoroyer : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        {
            if (other.gameObject.CompareTag("Boll"))

            {
                Destroy(gameObject);
            }

        }
    }
}
