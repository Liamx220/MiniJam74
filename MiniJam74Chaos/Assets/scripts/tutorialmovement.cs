using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialmovement : MonoBehaviour
{
    public float speed = 1;
    
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
}
