using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleSE : MonoBehaviour
{
    public AudioClip Sound; //ボタンが押された時の音
    private bool SEFlg; //一回だけ鳴らすよう

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        SEFlg = false;
        audioSource.volume = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (SEFlg == false)
        {
            if (Input.anyKeyDown)
            {
                SEFlg = true;
                audioSource.PlayOneShot(Sound);
            }
            else
            {
                SEFlg = false;
            }
            
        }
        
    }
}
