using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seselect : MonoBehaviour
{
    public AudioClip sound1;
    public AudioClip sound2;
    bool getSE;
    private static bool getSEflag;   //選択した後に操作できないようにするためのフラグ

    AudioSource audioSource;

    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
        getSEflag = false;
    }

    void Update()
    {
        Debug.Log(getSEflag);
        if (getSEflag == false){  //falseの間操作可能
            if ((!Input.GetButton("A") && Input.GetAxis("Vertical") == -1) || (!Input.GetButton("A") && Input.GetAxis("Vertical2") == -1)) //下が押された場合
            {
                if (getSE == false)
                {
                    audioSource.PlayOneShot(sound1);
                    getSE = true;
                }
            }
            else if ((!Input.GetButton("A") && Input.GetAxis("Vertical") == 1) || (!Input.GetButton("A") && Input.GetAxis("Vertical2") == 1))//上が押された場合
            {
                if (getSE == false)
                {
                    audioSource.PlayOneShot(sound1);
                    getSE = true;
                }
            }
            else //何も押されていないとき
            {
                getSE = false;
            }
            if ((Input.GetAxis("Vertical") != 1 && Input.GetAxis("Vertical") != -1 && Input.GetAxis("Vertical2") != 1 && Input.GetAxis("Vertical2") != -1 && Input.GetButton("A")) || (Input.GetButton("A") && Input.GetAxis("Vertical") == 1) || (Input.GetButton("A") && Input.GetAxis("Vertical2") == 1) || (Input.GetButton("A") && Input.GetAxis("Vertical") == -1) || (Input.GetButton("A") && Input.GetAxis("Vertical2") == -1))
            {
                if (getSE == false)
                {
                    audioSource.PlayOneShot(sound2);
                    getSE = true;
                    getSEflag = true;
                }
            }
            
        }

        if (getSEflag == true) //もしポーズ画面開いていないときにフラグがtrueならfalseになる
        {
            getSEflag = false;
        }
    }

    public static bool GetSEFlag()
    {
        return getSEflag;
    }
}