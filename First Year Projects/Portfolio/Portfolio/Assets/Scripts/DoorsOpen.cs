using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsOpen : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Horse" && TresureCollect.tresure == true)
        {
            Destroy(gameObject);
        }
       


    }
}
