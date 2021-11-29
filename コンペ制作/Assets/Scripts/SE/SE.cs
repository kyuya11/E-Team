using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE : MonoBehaviour
{
    private AudioSource audio;

    public AudioClip WallSE;
    public AudioClip ItemSE;
    public AudioClip ojamaSE;
    public AudioClip BigBollSE;

    bool SEFlg = false;

    private void Start()
    {
        audio = gameObject.AddComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Wall")
        {
            var time = Time.time;
            audio.PlayOneShot(WallSE);
            if (Time.time - time > 0.2f)
            {
                audio.Stop();
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            //Debug.Log("アイテムを取得しました");
            var time = Time.time;
            audio.PlayOneShot(ItemSE, 0.2f);
            if (Time.time - time > 0.2f)
            {
                audio.Stop();
            }
        }


        if (other.gameObject.tag == "Ojama")
        {
            //Debug.Log("お邪魔アイテムを取得しました");
            var time = Time.time;
            audio.PlayOneShot(ojamaSE, 0.2f);
            if (Time.time - time > 0.2f)
            {
                audio.Stop();
            }
        }
        if (other.gameObject.tag == "speed")    //当たった相手のTagがBallだったら
        {
            var time = Time.time;
            audio.PlayOneShot(BigBollSE, 0.2f);
            if (Time.time - time > 0.2f)
            {
                audio.Stop();
            }

        }
    }
}
