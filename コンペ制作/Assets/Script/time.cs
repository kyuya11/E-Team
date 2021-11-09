using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class time : MonoBehaviour
{
	private Text timerText;
	int Timeminute;
	float Timeseconds;
	void Start()
	{
		Timeminute = Timer.minute;
		Timeseconds = Timer.seconds;
		timerText = GetComponentInChildren<Text>();
		timerText.text = " 経過した時間  ： "+Timeminute.ToString("00") + ":" + ((int)Timeseconds).ToString("00");
	}

	void Update()
	{
		
	}
		
}