using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerFirst : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private bool stopTime;
    private bool finished = false;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (finished)
        {
            return;

        }
        
        startTime = 60;
        float t = startTime - Time.time;

        if (t == 0)
        {
            stopTime = false;
        }

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f0");

        timerText.text = minutes + ":" + seconds;
    }



    public void Finnish()
    {
        finished = true;
        timerText.color = Color.red;
    }

}