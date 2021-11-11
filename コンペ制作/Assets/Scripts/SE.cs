using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE : MonoBehaviour
{
    private AudioSource audio;

    public AudioClip WallSE;
    public AudioClip ItemSE;
    public AudioClip BallSE;

    private Vector3 Balltrans;
    private float BallX;
    private float BallZ;

    bool SEFlg = false;

    private void Start()
    {
        audio = gameObject.AddComponent<AudioSource>();
        BallX = transform.position.x;
        BallZ = transform.position.z;
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
            Debug.Log("アイテムを取得しました");
            var time = Time.time;
            audio.PlayOneShot(ItemSE,0.5f);
            if (Time.time - time > 0.2f)
            {
                audio.Stop();
            }
        }
    }
    private void Update()
    {
        if(BallX != transform.position.x || BallZ != transform.position.z)
        {
            if(SEFlg == false)
            {
                audio.PlayOneShot(BallSE);
                SEFlg = true;
            }
            
            BallX = transform.position.x;
            BallZ = transform.position.z;
            Debug.Log("ボールが動いています");
            
        }
    }
}
