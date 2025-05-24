using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : PlayerStats
{
    // fields


    private Vector2 moveVelocity;

    public Transform firepoint;
    public GameObject bulletPrefab;

    private float timeBtwAttack;
    public float startTimeBtwAttack;
    public Transform attackPos;
    public LayerMask whatIsEnemies;
    public float attackRange;




    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
        else if (hp <= 0)
        {
            Die();
        }
    }

        
         void Shoot()
        {
            Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        }

         void Die()
        {

            FindObjectOfType<MenuScript>().EndGame();
            Destroy(gameObject);

        }
         public float ReturnHP()
        {
            return hp;
        }


    }

// }
// meleattack
//private void FixedUpdate()
//{
//    if(timeBtwAttack <= 0)
//    {
//     if(Input.GetKey(KeyCode.Space))
//        {
//            Collider2D[] enmiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
//            for (int i = 0; i < enmiesToDamage.Length; i++)
//            {
//                enmiesToDamage[i].GetComponent<Enemies>().health -= damage;
//            }
//        }
//        timeBtwAttack = startTimeBtwAttack;
//    }
//    else
//    {
//        timeBtwAttack -= Time.deltaTime;
//    }
//    if(hp <= 0)
//    {
//        Die();
//    }
//}
//    void OnDrawGizmosSelected()
//{
//    Gizmos.color = Color.red;
//    Gizmos.DrawWireSphere(attackPos.position, attackRange);
//}

// shoot



