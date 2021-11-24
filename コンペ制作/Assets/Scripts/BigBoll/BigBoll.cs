using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBoll : MonoBehaviour
{
    public Rigidbody rb;
    public float thrust = 1.0f;
    float x = 0f;
    float z = 0f;
    bool getcountdown;

    Vector3 kero = new Vector3(2, 2, 2);
    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "speed")
        {
            kero.x = 4;
            kero.y = 4;
            kero.z = 4;
            gameObject.transform.localScale = kero;
            StartCoroutine(SpeedCoroutine());
        }

    }
    private IEnumerator SpeedCoroutine()
    {

        yield return new WaitForSeconds(4.5f);
        kero.x = 2;
        kero.y = 2;
        kero.z = 2;
        gameObject.transform.localScale = kero;
    }

}
