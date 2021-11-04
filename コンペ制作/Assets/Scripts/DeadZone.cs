using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    private GameObject Camera;
    private GameObject Ball;  //ボール情報格納用

    private float ballY = 0.0f;

    private float DeadZoneY = 0.0f;
    private float offsetX = 0.0f;
    private float offsetZ = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.Camera = GameObject.Find("Main Camera");
        this.Ball = GameObject.Find("Ball");



        ballY = Ball.transform.position.y;



        offsetX = transform.position.x - Camera.transform.position.x;
        offsetZ = transform.position.z - Camera.transform.position.z;

    }

    // Update is called once per frame
    void Update()
    {
        ballY = Ball.transform.position.y;
        DeadZoneY = ballY;
        //Goal = new Vector3(ballX + offsetX, cameraY, ballZ + offsetZ);
        transform.position = new Vector3(Camera.transform.position.x + offsetX, DeadZoneY, Camera.transform.position.z + offsetZ);
    }
}

