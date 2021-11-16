using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static int minute;
    public static float seconds;
    public static float oldSeconds;
    private Text timerText;
    // Use this for initialization
    void Start()
    {
        minute = 0;
        seconds = 0f;
        oldSeconds = 0f;
        timerText = GetComponentInChildren<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        StartCoroutine(TimerCoroutine());
    }
    private IEnumerator TimerCoroutine()
    {
        if (Time.timeScale == 1)
        {
            yield return new WaitForSeconds(3);
            seconds += Time.deltaTime;
            if (seconds >= 60f)
            {
                minute++;
                seconds = seconds - 60;
            }
            //　値が変わった時テキストを更新
            if ((int)seconds != (int)oldSeconds)
            {
                timerText.text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
                //Debug.Log(minute.ToString("00") + ":" + ((int)seconds).ToString("00"));
            }
            oldSeconds = seconds;
        }
    }
}