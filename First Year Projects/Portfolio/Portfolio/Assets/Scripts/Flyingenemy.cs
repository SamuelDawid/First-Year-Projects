using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flyingenemy : MonoBehaviour
{
    [SerializeField] GameObject Enemy;
    public static Transform startPoint;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask groundMask;
    RaycastHit2D groundCast;
    Rigidbody2D rb;
    [SerializeField] float speed;
    Transform startpoint;
    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        startpoint = GameObject.Find("EnemySpawn").transform;
        Enemy.transform.position = startpoint.position;
    }
    void Update()
    {
        rb.velocity = transform.up * speed;
        groundCast = Physics2D.CircleCast(groundCheck.position, 0.1f, Vector2.down, 0.1f, groundMask);


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Control" || collision.gameObject.tag == "Horse")
        {
            Enemy.transform.position = startpoint.position;
        }
        
        if (collision.gameObject.tag == "Horse")
        {
            Control.liveLeft--;
        }
        
    }

}

