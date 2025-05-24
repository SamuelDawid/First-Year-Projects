using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulet : MonoBehaviour {

    [SerializeField] float bulletSpeed;
    Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = transform.up * bulletSpeed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Horse")
        {
            Control.liveLeft--;
            Destroy(gameObject);
        }

        Destroy(gameObject);
    }


}
