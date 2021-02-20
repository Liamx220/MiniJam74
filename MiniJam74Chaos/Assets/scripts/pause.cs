using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public GameObject PauseMenu;
    private bool Paused = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p") && Paused == false)
        {
            Time.timeScale = 0f;
            PauseMenu.SetActive(true);
            Paused = true;

        }
        else if (Input.GetKeyDown("p") && Paused == true)
        {
            Time.timeScale = 1f;
            PauseMenu.SetActive(false);
            Paused = false;

        }
        
    }
}
