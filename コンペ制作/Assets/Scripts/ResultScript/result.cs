using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class result : MonoBehaviour
{
    public Text Counttext;
    //public Text Timertext;
    int score;
    //int Time;
    // Start is called before the first frame update
    void Start()
    {
        score = Item.GetItemCount();
        //Time = Timer.TimerCoroutine();

        Counttext.text = string.Format("獲得したコイン  :  {0}/12", score);
        //Timertext.text = string.Format("経過した時間  :  {0}", Time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
