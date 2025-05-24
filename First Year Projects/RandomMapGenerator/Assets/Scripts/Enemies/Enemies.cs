using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : EnemieStats {
   
    private Vector2 playerTarget;
    public Player target;

    public GameObject bullet;
    public float timeBetweenShot;
    public float shotDistance;

    public enum State
    {
        MoveTorwords,
        MoveAway,
        Stop,
        none
    }

    public State CurrentState = State.MoveTorwords;


    public void Stop()
    {
        transform.position = this.transform.position;
        Shot();
    }
    

    public void MovePlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed*Time.deltaTime);
        Shot();
    }

    public void RunAway()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, -speed * Time.deltaTime);
        Shot();
    }
    public void Death()
    {
        if(health <= 0)
        {
            ScoreDisplay.scoreValue += 150;
            Destroy(gameObject);
        }
        
    }

    public void Shot()
    {
        timeBetweenShot += Time.deltaTime;
        if (Vector2.Distance(transform.position, target.transform.position) < shotDistance)
        {
            if (timeBetweenShot > 1)
            {

                GameObject Bullet = GameObject.Instantiate(bullet, transform.position, Quaternion.identity);

                timeBetweenShot = 0;
            }
        }
    }
}
