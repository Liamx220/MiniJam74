using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{


    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce;
    //public float timeBetweenShots = 0.1f;
    //Time.time >= timestamp &&
    private float timestamp;
    public AudioSource sounds;
    //public AudioSource music;

    private void Start()
    {
        sounds = GetComponent<AudioSource>();
        //music = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Shoot();
        }

        void Shoot()
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
            sounds.Play();
            
        }
    }


}
