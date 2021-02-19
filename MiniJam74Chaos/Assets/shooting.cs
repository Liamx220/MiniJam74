using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{


    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce;
    public float timeBetweenShots = 0.3333f;
    private float timestamp;
    void Update()
    {
        if (Time.time >= timestamp && Input.GetKeyDown("space"))
        {
            Shoot();
        }

        void Shoot()
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
            timestamp = Time.time + timeBetweenShots;
        }
    }

}
