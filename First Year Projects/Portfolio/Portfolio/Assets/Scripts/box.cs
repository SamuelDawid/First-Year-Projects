﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{

    public GameObject Text;
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.tag == "Horse")
        {
            Text.SetActive(!Text.activeSelf);
        }
    }
}


