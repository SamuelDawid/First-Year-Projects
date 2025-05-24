using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapAudio : MonoBehaviour {

    public AudioClip amyclip;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag =="Horse")
        {
            audioSource.PlayOneShot(amyclip);
           
        }
    }
}

