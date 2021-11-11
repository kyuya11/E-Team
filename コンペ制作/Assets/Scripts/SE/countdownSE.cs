using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countdownSE : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;
    bool AudioFlg;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        AudioFlg = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (AudioFlg == false)
        {
            audioSource.PlayOneShot(sound1);
            AudioFlg = true;
        }
    }
}
