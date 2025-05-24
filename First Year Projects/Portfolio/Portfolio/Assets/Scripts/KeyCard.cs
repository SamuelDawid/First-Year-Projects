using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCard : MonoBehaviour {
    [SerializeField] static int keyCardVal = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            switch (keyCardVal)
            {
                case 1:
                    Manager.redCard = true;
                    break;
                case 2:
                    Manager.blueCard = true;
                    break;
                case 3:
                    Manager.YellowCard = true;
                    break;
            }
            Destroy(gameObject);
        }
    }
}