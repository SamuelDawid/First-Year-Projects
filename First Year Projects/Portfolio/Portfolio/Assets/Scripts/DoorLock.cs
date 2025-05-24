using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLock : MonoBehaviour {

    [SerializeField] int doorColour;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            switch (doorColour)
            {
                case 1:
                    if (Manager.redCard)
                    {
                        Destroy(gameObject);
                    }
                    break;
                case 2:
                    if (Manager.blueCard)
                    {
                        Destroy(gameObject);
                    }
                    break;
                case 3:
                    if (Manager.YellowCard)
                    {
                        Destroy(gameObject);
                    }
                    break;
            }
        }
    }
        }