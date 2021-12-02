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
            StartCoroutine(Dragcoroutine1());
        }
        if (other.gameObject.tag == "Ojama2")
        {
            var time = Time.time;
            rb.drag = 2;
            StartCoroutine(Dragcoroutine2());
        }
    }
    private IEnumerator Dragcoroutine1() {
        yield return new WaitForSeconds(2);
        rb.drag = 0;
    }
    private IEnumerator Dragcoroutine2()
    {
        yield return new WaitForSeconds(2);
        rb.drag = 0;
    }


}