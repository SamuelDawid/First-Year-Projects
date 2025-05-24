using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {



    [SerializeField] float rotateSpeed;
    [SerializeField] GameObject BulletPrefab;
    [SerializeField] float bulletFrequency;
    Transform spawnPoint;
    float timeSinceLastBullet;
    // Use this for initialization
    void Start()
    {
        spawnPoint = gameObject.transform.Find("SpawnPoint").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, rotateSpeed * Time.deltaTime));
        timeSinceLastBullet += Time.deltaTime;
        if (timeSinceLastBullet > bulletFrequency)
        {
            Instantiate(BulletPrefab, spawnPoint.position, spawnPoint.rotation);
            timeSinceLastBullet = 0f;
        }
    }
}
