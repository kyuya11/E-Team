using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ojamascript : MonoBehaviour
{
    public Rigidbody rb;
    float seconds;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Ojama1")
        {
            var time = Time.time;
            rb.drag = 2;
            StartCoroutine(Dragcoroutine());
        }
        if (other.gameObject.tag == "Ojama2")
        {
            var time = Time.time;
            rb.drag = 2;
            StartCoroutine(Dragcoroutine());
        }
    }
    private IEnumerator Dragcoroutine() {
        yield return new WaitForSeconds(2);
        rb.drag = 0;
    }

    
}