using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colission2 : MonoBehaviour
{
    public float DestroyTime = 3f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Horse")
        {
            Control.liveLeft--;
            

        }
    }
}
