using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TresureAudio : MonoBehaviour {

    public AudioClip amyclip;
    AudioSource audioSource;
    public float destroytime = 2f;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Horse")
        {
            audioSource.PlayOneShot(amyclip);
            Destroy(gameObject,destroytime);
        }
    }
}
