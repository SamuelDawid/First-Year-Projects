﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TresureCollect : MonoBehaviour
{
    public static bool tresure = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Horse")
        {
            Control.points++;
            Destroy(gameObject);
        }
        
    }
    
    











}
