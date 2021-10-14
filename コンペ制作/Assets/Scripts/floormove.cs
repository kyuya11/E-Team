using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floormove : MonoBehaviour
{

    public float Rotation = 30f;

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        transform.rotation = Quaternion.Euler(z * Rotation, 0, -x * Rotation);


    }
}
