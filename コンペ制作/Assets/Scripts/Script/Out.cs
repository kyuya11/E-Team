using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Out : MonoBehaviour
{
    public  Transform ball;
    
    void Start()
    {
        ball= GameObject.FindGameObjectWithTag("Ball").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.position.y < -10)
        {
            ball.localPosition = new Vector3(0, 2, 0);
        }
    }
}
