using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pressChange : MonoBehaviour
{

    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("8"))
        {
            SceneManager.LoadScene (sceneBuildIndex: 1);
        }

        
    }
}
