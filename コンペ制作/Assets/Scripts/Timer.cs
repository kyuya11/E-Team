using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public static int minute;
    public static float seconds;
    private float beforeSeconds;
    
    
    void Start()
    {
        minute = 0;
        seconds = -3.5f;
        beforeSeconds = 0f;
        

    }
    
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
            
            Debug.Log(minute.ToString("00") + ":" + ((int)seconds).ToString("00"));
        }
        beforeSeconds = seconds;
    }
}