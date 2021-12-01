using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timeresult : MonoBehaviour
{
    int resultminute;
    float resultseconds;
    float resultoldseconds;
    private Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        resultminute = Timer.minute;
        resultseconds = Timer.seconds;
        resultoldseconds = Timer.oldSeconds;
        timerText = GetComponentInChildren<Text>();
        timerText.text = "経過した時間 　  :  " + resultminute.ToString("00") + ":" + ((int)resultseconds).ToString("00");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
