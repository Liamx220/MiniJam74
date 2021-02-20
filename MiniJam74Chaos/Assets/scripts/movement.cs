using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 1;
    public GameObject gameOverScreen;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            transform.Rotate(new Vector3(0, 0, 20 * speed * Time.deltaTime));
        }
        if (Input.GetKey("x"))
        {
            transform.Rotate(new Vector3(0, 0, -20 * speed * Time.deltaTime));
        }
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        //if (col.gameObject.tag == "enemy")
        //{
        Destroy(gameObject);
        Time.timeScale = 0f;
        gameOverScreen.SetActive(true);
        //}
    }
}
