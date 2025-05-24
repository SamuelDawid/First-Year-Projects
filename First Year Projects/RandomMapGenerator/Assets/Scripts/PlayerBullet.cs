using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : DamageDealer
{

    
    public Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {

        rb.velocity = transform.right * speed;
        
    }

    // Update is called once per frame
  
   

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Enemie"))
        {
            collision.transform.GetComponent<EnemieStats>().health -= Damage;
            
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == ("Wall"))
        {
            
            Destroy(gameObject);
        }
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }

}
