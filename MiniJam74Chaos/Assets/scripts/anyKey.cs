using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class anyKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            score.Score = 0;
            Time.timeScale = 1f;
            SceneManager.LoadScene("SampleScene");
            //Time.timeScale = 1f;
        }
        
    }

}
