using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultSE : MonoBehaviour
{
    public AudioClip sound1;
    public AudioClip sound2;
    private static bool getSEflag;
    bool getSE = false;
    bool Selectflag;

    AudioSource audioSource;

    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
        getSEflag = false;
    }

    void Update()
    {
        Selectflag = next.GetMenuSelect();

        if (Selectflag == true) //falseの間操作可能
        {
            if (getSEflag == false)
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
                }
                else if (Input.GetButton("A"))
                {
                    if (getSE == false)
                    {
                        audioSource.PlayOneShot(sound2);
                        getSE = true;
                        getSEflag = true;
                    }
                }
                else
                {
                    getSE = false;
                }
            }
        }
    }

    public static bool GetResultSEFlag()
    {
        return getSEflag;
    }
}