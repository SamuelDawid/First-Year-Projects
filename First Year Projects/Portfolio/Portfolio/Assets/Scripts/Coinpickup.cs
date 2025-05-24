using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinpickup : MonoBehaviour
{
    [SerializeField] int coinValue;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Manager.money += coinValue;
            Destroy(gameObject);
        }
    }
}
