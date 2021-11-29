using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollSound : MonoBehaviour
{
    GameObject camera;
    private AudioSource audio;
    private float BallX;
    private float BallZ;
    bool SEFlg;
    bool getpushFlag;
    public AudioClip BallSE;
    BallCamera cam;

    private Rigidbody ballRb;
    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.Find("Main Camera");
        cam = camera.GetComponent<BallCamera>();
        audio = gameObject.AddComponent<AudioSource>();
        audio.loop = true;
        audio.clip = BallSE;
        audio.time = 0.5f;
        BallX = transform.position.x;
        BallZ = transform.position.z;


        audio.volume = 1.0f;
        //SEFlg = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        getpushFlag = Pause.GetPushFlag();

        audio.volume = cam.vel / 7;
        //yield return new WaitForSeconds(1);
        if (getpushFlag == false)
        {
            SEFlg = false;
            if (BallX != transform.position.x || BallZ != transform.position.z)
            {
                if (SEFlg == false)
                {
                    audio.loop = true;
                    audio.time = 0.5f;
                    audio.Play();
                    //SEFlg = true;
                }
            }
        }
        else
        {
            SEFlg = true;
        }


        //audio.volume = 0.5f;
        BallX = transform.position.x;
        BallZ = transform.position.z;
        //Debug.Log("ボールが動いています");
    }
}
