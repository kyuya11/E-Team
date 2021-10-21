using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floormove : MonoBehaviour
{
    Transform target;
    float speed = 1.2f;
    float step;
    public float Rotation = 30f;

    void Start()
    {
        target = GameObject.Find("floor").transform;
    }
    // Update is called once per frame
    void FixedUpdate()
    {


        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        //transform.rotation = Quaternion.Euler(z * Rotation, 0, -x * Rotation);

        var body = GameObject.Find("Ball").GetComponent<Rigidbody>();
        Rigidbody rigidbody = GameObject.Find("floor").GetComponent<Rigidbody>();

        step = speed * Time.deltaTime;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(z * Rotation, 0, -x * Rotation), step);
    }
}
