using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    //public Animator sceneAnimation;
    void Start()
    {

        //SceneManager.LoadScene (sceneBuildIndex: 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
           
            SceneManager.LoadScene (sceneBuildIndex: 1);
        } 
    }


        //sceneAnimation.SetTrigger("end");
        //yield return new WaitForSeconds(1.5f);
     
    
}
