using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class enemyMove : MonoBehaviour
{
    public int health;
    public int speed;
    public Transform target;
    private Rigidbody2D rb;

    public Text in_Game_score;
    //public Animator explosion;
    public GameObject explosionPrefab;
    

    void Start()
    {
        

        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 direction = target.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        transform.position = Vector3.MoveTowards(transform.position, target.position, Random.Range(2f, 5f) * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        
        
        if (col.gameObject.tag == "bullet")
        {
            health -= 1;
            
            Destroy(col.gameObject);
            if (health == 0)
            {
                //in_Game_score.text = score.Score.ToString();
                
                Instantiate(explosionPrefab, transform.position, transform.rotation = Quaternion.identity);
                
                Destroy(gameObject);
            }
            
            
        }
    }
}
