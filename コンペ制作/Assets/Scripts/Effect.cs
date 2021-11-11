﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem footSmoke;
    private Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //速度が0.1以上なら
        if(rb.velocity.magnitude > 0.1f)
        {
            //再生
            if (!footSmoke.isEmitting)
            {
                footSmoke.Play();
            }
        }
        else
        {
            //停止
            if (footSmoke.isEmitting)
            {
                footSmoke.Stop();
            }
        }
    }
}
