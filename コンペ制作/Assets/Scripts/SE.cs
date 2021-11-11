using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE : MonoBehaviour
{
    private AudioSource audio;

    public AudioClip sound1;

    private void Start()
    {
        audio = gameObject.AddComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Wall")
        {
            audio.PlayOneShot(sound1);
        }
    }
}
