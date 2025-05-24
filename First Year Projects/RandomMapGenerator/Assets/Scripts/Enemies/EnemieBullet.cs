using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieBullet : DamageDealer {

    
    private Transform player;
    private Vector2 targer;
    
    
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        targer = new Vector2(player.position.x, player.position.y);
	}
	
	// Update is called once per frame
	void Update () {

        ShootTarget();

    }
    public void ShootTarget()
    {
        transform.position = Vector2.MoveTowards(transform.position, targer, speed * Time.deltaTime);

        if (transform.position.x == targer.x && transform.position.y == targer.y)
        {
            DestroyProjectile();
        }
    }
   
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            collision.transform.GetComponent<Player>().hp -= Damage;
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
