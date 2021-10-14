using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private GameObject Ball;  //ボール情報格納用
    private Vector3 offset; //相対距離取得用

    //Use this for initialization

    // Start is called before the first frame update
    void Start()
    {
        //Ballの情報取得
        this.Ball = GameObject.Find("Ball");

        //MainCamera(自分自身)とボールとの相対距離を求める
        offset = transform.position - Ball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //新しいトランスフォームの値を代入する
        transform.position = Ball.transform.position + offset;
    }
}
