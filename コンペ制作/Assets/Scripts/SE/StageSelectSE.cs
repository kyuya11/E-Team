using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSelectSE : MonoBehaviour
{
    public AudioClip sound1;
    public AudioClip sound2;
    private static bool getSEflag;
    bool getSE = false;

    AudioSource audioSource;

    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
        getSEflag = false;
    }

    void Update()
    {


            if (getSEflag == false)
            {
                if ((!Input.GetButton("A") && Input.GetAxis("Vertical") == -1) || (!Input.GetButton("A") && Input.GetAxis("Vertical2") == -1))
                {
                    if (getSE == false)
                    {
                        audioSource.PlayOneShot(sound1);
                        getSE = true;
                    }
                }
                else if ((!Input.GetButton("A") && Input.GetAxis("Vertical") == 1) || (!Input.GetButton("A") && Input.GetAxis("Vertical2") == 1))
                {
                    if (getSE == false)
                    {
                        audioSource.PlayOneShot(sound1);
                        getSE = true;
                    }
                }
            else
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
        
    }

    public static bool GetResultSEFlag()
    {
        return getSEflag;
    }
}