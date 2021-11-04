using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsScript : MonoBehaviour
{
    public float mass = 1.0f; //質量
    public float v = 1.0f; //速度
    public float StaticFriction = 1.0f; //静止摩擦
    public float DynamicFriction = 1.0f;  //動摩擦
    public float Rotation = 1.0f; //回転
    public float acceleration = 1.0f; //加速度
    public float Bounciness = 1.0f; //反発率
    public float Gravity = 9.80665f; //重力加速度

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
