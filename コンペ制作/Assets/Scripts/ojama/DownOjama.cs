using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownOjama : MonoBehaviour
{
    Rigidbody rb;
    Collider m_ObjectCollider;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        m_ObjectCollider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "floor")
        {
            //rb.isKinematic = true;
            m_ObjectCollider.isTrigger = true;
        }
    }


}
