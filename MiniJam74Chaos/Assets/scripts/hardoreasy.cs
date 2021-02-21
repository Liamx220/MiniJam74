using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class hardoreasy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene (sceneBuildIndex: 1);
        } 
        if (Input.GetKeyDown("8"))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene (sceneBuildIndex: 3);
        } 
        
    }
}
