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
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(Rotation, 0, 0), step);
        }else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(-Rotation, 0, 0), step);
        }

            else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, -Rotation), step);
        }else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, Rotation), step);
        }
        
        else 
        {
            Invoke(nameof(neutral),1f);
        }
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(Rotation, 0, -Rotation), step);
        }else if(Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(Rotation, 0,Rotation), step);

        }
        else if(Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(-Rotation, 0, -Rotation), step);

        }
        else if(Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(-Rotation, 0, Rotation), step);

        }

        if (Input.GetKey(KeyCode.UpArrow)||Input.GetKey(KeyCode.DownArrow)||Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.LeftArrow))
        {
            body.WakeUp();
        }
    }
    void neutral()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 0), step);
    }
}
