using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class quit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("b"))
        {
            Application.Quit();
            print("quit");
        }
        if (Input.GetKeyDown("8"))
        {
            SceneManager.LoadScene (sceneBuildIndex: 0);
        }
        
    }
}
