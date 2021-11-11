using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    private GameObject Ball;  //ボール情報格納用

    private float ballX = 0.0f;
    private float ballZ = 0.0f;
    private float ballY = 0.0f;

    private float offsetX = 0.0f;
    private float offsetY = 0.0f;
    private float offsetZ = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.Ball = GameObject.Find("Ball");

        offsetX = transform.position.x - Ball.transform.position.x;
        offsetY = transform.position.y - Ball.transform.position.y;
        offsetZ = transform.position.z - Ball.transform.position.z;

        ballX = Ball.transform.position.x;
        ballY = Ball.transform.position.y;
        ballZ = Ball.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        ballX = Ball.transform.position.x;
        ballY = Ball.transform.position.y;
        ballZ = Ball.transform.position.z;

        transform.position = new Vector3(ballX + offsetX, ballY + offsetY, ballZ + offsetZ);
    }
}
