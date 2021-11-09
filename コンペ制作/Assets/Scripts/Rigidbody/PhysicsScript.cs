using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsScript : MonoBehaviour
{
    GameObject floor;
    public float mass = 1.0f; //質量
    public float v = 1.0f; //速度
    public float StaticFriction = 1.0f; //静止摩擦
    public float DynamicFriction = 1.0f;  //動摩擦
    public float Rotsation = 1.0f; //回転
    public float acceleration = 1.0f; //加速度
    public float Bounciness = 1.0f; //反発率
    public float Gravity = 9.80665f; //重力加速度
    private float mg;

    private float Fx;
    private float Fy;
    private float Fz;


    bool pushflg = false;
    bool stopFlg = false;

    // Start is called before the first frame update
    void Start()
    {
        this.floor = GameObject.Find("GameObject");
        mg = mass * Gravity;
    }

    // Update is called once per frame
    void Update()
    {
        var angleX = transform.rotation.x;
        var angleY = transform.rotation.y;
        var angleZ = transform.rotation.z;

        var sin = Mathf.Sin(angleX * (Mathf.PI / 180));
        Fx = mg * sin;

        if (Input.GetButton("Y") || Input.GetKey(KeyCode.Space))
        {
            if (pushflg == false)
            {
                pushflg = true;
                if (stopFlg == false)
                {
                    stopFlg = true;
                }
                else
                {
                    stopFlg = false;
                }
            }


        }
        else
        {
            pushflg = false;
        }
        if (stopFlg == true)
        {
            //transform.position = new Vector3(transform.position.x, transform.position.y + (-mg), transform.position.z);
        }
        
        
    }
    private void OnCollisionStay(Collision collision)
    {
        if (stopFlg == true)
            transform.position = new Vector3(transform.position.x, transform.position.y + (-mg + mg), transform.position.z);
    }
}
