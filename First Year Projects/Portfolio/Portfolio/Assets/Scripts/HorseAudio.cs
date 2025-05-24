using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseAudio : MonoBehaviour {

    public AudioClip amyclip;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            {
            audioSource.PlayOneShot(amyclip);
        }
    }



}

