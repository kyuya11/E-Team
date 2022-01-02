using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleBGM: MonoBehaviour
{
    public AudioClip titleBGM; //タイトルBGM
    

    private bool Titleflg; //現在のシーンがタイトルの時true
    private bool BGMFlg; //BGMを一回だけ鳴らす用
    private bool SEFlg; //SEを一回だけ鳴らす用

    AudioSource audioSource;



    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Titleflg = true;
        BGMFlg = false;
        audioSource.loop = true; //ループ再生ON
        audioSource.clip = titleBGM; //タイトルBGMをアタッチ(インスペクターに表示される)
        audioSource.volume = 0.03f;
    }

    // Update is called once per frame
    void Update()
    {
        if(BGMFlg == false)
        {
            BGMFlg = true;
            audioSource.Play();
        }
        //audioSource.Play();

        
    }
}
