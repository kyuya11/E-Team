using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seselect : MonoBehaviour
{
    public AudioClip sound1;
    public AudioClip sound2;
    bool getSE;

    AudioSource audioSource;

    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
        getSE = false;
    }

    void Update()
    {

        if (Input.GetAxis("Vertical") == -1 || Input.GetAxis("Vertical2") == -1)
        {
            if (getSE == false)
            {
                audioSource.PlayOneShot(sound1);
                getSE = true;
            }
        }
        else if (Input.GetAxis("Vertical") == 1 || Input.GetAxis("Vertical2") == 1)
        {
            if (getSE == false)
            {
                audioSource.PlayOneShot(sound1);
                getSE = true;
            }
        }else if(Input.GetButton("A"))
        {
            if (getSE == false)
            {
                audioSource.PlayOneShot(sound2);
                getSE = true;
            }
        }
        else
        {
            getSE = false;
        }

        //if (getSE == false)
        //{
        //    if (Input.GetAxisRaw("Vertical") == 1)
        //    {
        //        StartCoroutine(SoundPlay());
        //    }
        //    else if (Input.GetAxisRaw("Vertical") == -1)
        //    {
        //        StartCoroutine(SoundPlay());
        //    }
        //}

        //// 右
        //if (getSE == false)
        //{
        //    if (Input.GetButtonDown("A"))
        //    {
        //        StartCoroutine(SoundPlay2());
        //    }
        //}
    }
}