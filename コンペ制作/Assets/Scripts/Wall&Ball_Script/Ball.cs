using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //private Bound bound;
    //private Rigidbody rb;

    //void Start()
    //{
    //    rb = this.GetComponent<Rigidbody>();
    //    bound = this.GetComponent<Bound>();
    //}


    void Update()
    {
        /*ボールが止まらないように*/
        var body = GameObject.Find("Ball").GetComponent<Rigidbody>();
        body.WakeUp();

        //bound.afterReflectVero = rb.velocity;
    }
}
