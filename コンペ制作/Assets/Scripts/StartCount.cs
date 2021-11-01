﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartCount : MonoBehaviour
{
    public Text CountDown;
    float countdown = 3f;
    private static int count;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(countdown >= 0)
        {
            countdown -= Time.deltaTime;
            count = (int)countdown;
            CountDown.text = count.ToString();
        }
        if(countdown <= 0)
        {
            CountDown.text = "";
        }
    }

    public static int CountDownStart()
    {
        return count;
    }
}
