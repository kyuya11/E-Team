using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigSE : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip BigSound;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "speed")    //当たった相手のTagがBallだったら
        {
            audioSource.PlayOneShot(BigSound);

        }
    }
}
