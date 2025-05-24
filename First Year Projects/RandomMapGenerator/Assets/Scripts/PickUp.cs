using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {
    private float addCoin;
    private void Start()
    {
        addCoin = ExtraScore.extraPoints;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            ScoreDisplay.scoreValue += addCoin;
            Destroy(gameObject);
        }

    }
}
