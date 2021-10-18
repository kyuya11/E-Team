using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private GameObject Ball;
    //private Vector3 offset;

    private Vector3 ballstartpos;
    private Vector3 ball;
    private float ballX = 0.0f;
    private float ballZ = 0.0f;
    private float cameraY = 0.0f;
    private float cameraZ = 0.0f;
    private Vector3 CamStart;
    private Vector3 CamEnd;

    private float eTime; //経過時間

    private float offsetX = 0.0f;
    private float offsetZ = 0.0f;

    private float N; //移動距離
    private float Nx;
    private float Nz;
    private float T;
    bool flg = false;


    // Movement speed in units/sec. 1秒当たり
    public float speed = 0.0f;

    // Time when the movement started.
    private float startTime;

    // Total distance between the markers.　aとbの間の距離
    private float journeyLength;

    // Use this for initialization
    void Start()
    {
        // Keep a note of the time the movement started.
        startTime = Time.time;
        
       

        CamStart = transform.position; //カメラの初期位置を代入
        CamEnd = transform.position; //初期化

        Ball = GameObject.Find("Ball");

        ballstartpos = Ball.transform.position;

        //offset = transform.position - Ball.transform.position;

        offsetX = transform.position.x - Ball.transform.position.x;
        offsetZ = transform.position.z - Ball.transform.position.z;

        //カメラの軸は操作しないので初期位置を取得
        cameraY = transform.position.y;

        ballX = Ball.transform.position.x;
        ballZ = Ball.transform.position.z;
    }

    void Update()
    {
        if (ballX != Ball.transform.position.x || ballZ != Ball.transform.position.z)
        {
            Debug.Log(Nx);
            //Debug.Log(N);

            speed = ((Ball.transform.position - ballstartpos) / Time.deltaTime).magnitude;
            ballstartpos = Ball.transform.position;
            //speed = Ball.velocity.magnitude;

            eTime = Time.time - startTime;
            // Distance moved = time * speed. 最初の位置の時間から現在の時間までの長さを取得
            float distCovered = eTime * speed;　//移動距離
            //float distCovered = Time.deltaTime * speed;


            //N = Vector3.Distance(Ball.transform.position,ballstartpos);
            Nx = (Ball.transform.position.x) - (ballX);
            Nz = (Ball.transform.position.z) - (ballZ);
            
            //移動距離が15cm以上になったら
            if (Nx >= 1.5f)
            {
                
                flg = true;
                if(speed == 0)
                {
                    flg = false;
                    ballX = Ball.transform.position.x;
                    ballZ = Ball.transform.position.z;
                }

                //transform.position = new Vector3(MoveX, cameraY, ballZ + offsetZ);
                CamEnd = new Vector3(Ball.transform.position.x + offsetX, cameraY, Ball.transform.position.z + offsetZ);

                // Calculate the journey length.　A地点からB地点までの距離を渡す
                journeyLength = Vector3.Distance(CamStart, CamEnd);

                // Fraction of journey completed = current distance divided by total distance.
                //float fracJourney = distCovered / journeyLength;　//達成率
                //if(T != journeyLength)
                //{
                //    for(T=0;T < journeyLength; T += (journeyLength / eTime / 60))
                //    {
                //        transform.position = Vector3.Lerp(CamStart, CamEnd, T);
                //    }
                //}

                //transform.position = Vector3.Lerp(CamStart, CamEnd,T);

                

            }
            if(flg == true)
            {
                
                Debug.Log("15cm以上動いています");
               
            }
            transform.position = new Vector3(ballX + offsetX, cameraY, ballZ + offsetZ);
        }

        //transform.position = new Vector3();
        //transform.position = Vector3.Lerp(transform.position, Ball.transform.position + offset, 6.0f * Time.deltaTime);
    }
}
