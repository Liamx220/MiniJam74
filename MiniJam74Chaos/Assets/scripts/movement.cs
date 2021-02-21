using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement : MonoBehaviour
{
    public float speed = 1;
    public GameObject gameOverScreen;
    public Text Scr;
    public Text HighScr;

    
    void Start()
    {
        HighScr.text = "Highscore: " + PlayerPrefs.GetFloat("HighScore", 0).ToString("0.0");
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

            Destroy(gameObject);
            Time.timeScale = 0f;
            gameOverScreen.SetActive(true);
            Scr.text = "Score: " + timer.currentTime.ToString("0.0");

            if (timer.currentTime > PlayerPrefs.GetFloat("HighScore", 0))
            {
                PlayerPrefs.SetFloat("HighScore", timer.currentTime);
                HighScr.text = "Highscore: " + timer.currentTime.ToString("0.0");
            }
            
            
            
            
        

   
    }
}
