using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private GameObject Ball;  //ボール情報格納用
    //private Vector3 offset; //相対距離取得用

    private float ballX = 0.0f;
    private float ballZ = 0.0f;
    private float cameraY = 0.0f;
    private float cameraZ = 0.0f;
    private float offsetX = 0.0f;
    private float offsetZ = 0.0f;

    //Use this for initialization

    // Start is called before the first frame update
    void Start()
    {
        //Ballの情報取得
        this.Ball = GameObject.Find("Ball");

        offsetX = transform.position.x - Ball.transform.position.x;
        offsetZ = transform.position.z - Ball.transform.position.z;

        //カメラの軸は操作しないので初期位置を取得
        cameraY = transform.position.y;

        ballX = Ball.transform.position.x;
        ballZ = Ball.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if(ballX != Ball.transform.position.x || ballZ != Ball.transform.position.z)
        {
            ballX = Ball.transform.position.x;
            ballZ = Ball.transform.position.z;
        }
        transform.position = new Vector3(ballX + offsetX, cameraY, ballZ + offsetZ);
        
        ////新しいトランスフォームの値を代入する
        //transform.position = Ball.transform.position + offset;
    }
}
