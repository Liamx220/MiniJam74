using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public static float currentTime = 0f;
    public static float startingTime = 0f;
    [SerializeField] private Text timerText;
    void Start()
    {
        currentTime = startingTime;
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += 1 * Time.deltaTime;
        timerText.text = currentTime.ToString("0.0");
    }
}
