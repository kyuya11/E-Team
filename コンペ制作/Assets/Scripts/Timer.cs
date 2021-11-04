using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private int minute;
    private float seconds;
    private float beforeSeconds;
    //private Text timerText;
    // Use this for initialization
    void Start()
    {
        minute = 0;
        seconds = -3.5f;
        beforeSeconds = 0f;
        //timerText = GetComponentInChildren<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime ;
        if (seconds >= 60f)
        {
            minute++;
            seconds = seconds - 60;
        }
        //　値が変わった時テキストを更新
        if ((int)seconds != (int)beforeSeconds)
        {
            //timerText.text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
            Debug.Log(minute.ToString("00") + ":" + ((int)seconds).ToString("00"));
        }
        beforeSeconds = seconds;
    }
}