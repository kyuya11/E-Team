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

    }

    void Update()
    {
        getSE = ChangeRetry.GetSE();

        if (getSE == false)
        {
            if (Input.GetAxis("Vertical") == 1)
            {
                StartCoroutine(SoundPlay());
            }
            else if (Input.GetAxis("Vertical") == -1)
            {
                StartCoroutine(SoundPlay());
            }
        }

        // 右
        if (getSE == false)
        {
            if (Input.GetButton("A"))
            {
                StartCoroutine(SoundPlay2());
            }
        }
    }

    IEnumerator SoundPlay()
    {
        audioSource.PlayOneShot(sound1);

        yield return new WaitForSeconds(0.32f); // 引数で指定された秒数待つ
    }

    IEnumerator SoundPlay2()
    {
        audioSource.PlayOneShot(sound2);

        yield return new WaitForSeconds(0.5f); // 引数で指定された秒数待つ
    }
}
