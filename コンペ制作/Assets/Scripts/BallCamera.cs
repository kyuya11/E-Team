using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCamera : MonoBehaviour
{
    private GameObject Ball;  //ボール情報格納用

    private float ballX = 0.0f;
    private float ballZ = 0.0f;
    private float cameraY = 0.0f;
    private float offsetX = 0.0f;
    private float offsetZ = 0.0f;
    private Vector3 Goal;
    public float N = 0.0f; //移動量を格納する変数

    private Vector3 _prevPosition;
    private float velocity;
    public float vel =0.0f;
    private double velCam = 0.0f;
    //Use this for initialization

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = transform.position;
        //Ballの情報取得
        this.Ball = GameObject.Find("Ball");
        _prevPosition = Ball.transform.position;

        offsetX = transform.position.x - Ball.transform.position.x;
        offsetZ = transform.position.z - Ball.transform.position.z;

        //カメラの軸は操作しないので初期位置を取得
        cameraY = transform.position.y;

        ballX = Ball.transform.position.x;
        ballZ = Ball.transform.position.z;

        Goal = new Vector3(ballX + offsetX, cameraY, ballZ + offsetZ);
    }

    // Update is called once per frame

    void Update()
    {
        if (Mathf.Approximately(Time.deltaTime, 0))
            return;
        var position = Ball.transform.position;
        var velocity = (Vector3.Distance(position, _prevPosition) / Time.deltaTime);
        vel = velocity; //他のスクリプトで使う用
        
        //Debug.Log(velocity);
        velCam = velocity * 0.75;
        _prevPosition = Ball.transform.position;
        //Debug.Log(velocity);

        if (ballX != Ball.transform.position.x || ballZ != Ball.transform.position.z)
        {

            ballX = Ball.transform.position.x;
            ballZ = Ball.transform.position.z;

            Goal = new Vector3(ballX + offsetX, cameraY, ballZ + offsetZ);

        }

        N = Mathf.Abs(Vector3.Distance(transform.position, Goal)); //カメラのスタート位置とカメラの目標地点の距離

        //if (N >= 1.5f)
        //{
        //    transform.position = Vector3.Lerp(transform.position, Goal, (float)velCam * Time.deltaTime);
        //}


        //Debug.Log(N);
    }
    private void LateUpdate()
    {
        if (N >= 1.5f)
        {
            transform.position = Vector3.Lerp(transform.position, Goal, (float)velCam * Time.deltaTime);
        }
    }

}

