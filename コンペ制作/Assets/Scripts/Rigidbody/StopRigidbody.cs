using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopRigidbody : MonoBehaviour
{
    Rigidbody rb;
    bool pushflg = false;
    bool stopFlg = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Y") || Input.GetKey(KeyCode.Space))
        {
            if(pushflg == false)
            {
                pushflg = true;
                if(stopFlg == false)
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
            rb.velocity = Vector3.zero;
            rb.isKinematic = true;
        }
        else
        {
            rb.isKinematic = false;
        }
    }
}
