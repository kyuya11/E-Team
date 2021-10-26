using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floormove : MonoBehaviour
{
    Transform target;
    float speed = 1.3f;
    float step;
    public float Rotation = 30f;
    float x = 0f;
    float z = 0f;

    void Start()
    {
        target = GameObject.Find("floor").transform;
    }
    // Update is called once per frame
    void FixedUpdate()
    {

        x = Input.GetAxisRaw("Horizontal");
        z = Input.GetAxisRaw("Vertical");
        //transform.rotation = Quaternion.Euler(z * Rotation, 0, -x * Rotation);

        var body = GameObject.Find("Ball").GetComponent<Rigidbody>();
        Rigidbody rigidbody = GameObject.Find("floor").GetComponent<Rigidbody>();

        step = speed * Time.deltaTime;
        if (x > 0f)
        {
            x = 1f;
        }
        else if (x < 0f)
        {
            x = -1f;

        }
        else 
        {
            x = 0f;
        }
        if (z > 0f)
        {
            z = 1f;

        }
        else if (z < 0f)
        {
            z = -1f;

        }
        else
        {
            z = 0f;
        }
        
        

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(z * Rotation, 0, -x * Rotation), step);
        
    }
    
}
