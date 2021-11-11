using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem FootSmoke;
    private Rigidbody rb;
    private string answerTag = "floor";
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (this.gameObject.CompareTag(answerTag))
        {

            //速度が0.1以上なら
            if (rb.velocity.magnitude > 0.1f)
            {
                //再生
                if (!FootSmoke.isEmitting)
                {
                    FootSmoke.Play();
                }
            }
            else
            {
                //停止
                if (FootSmoke.isEmitting)
                {
                    FootSmoke.Stop();
                }
            }
        }
    }
}
