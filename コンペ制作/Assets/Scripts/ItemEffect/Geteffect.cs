using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Geteffect : MonoBehaviour
{
    [SerializeField]
    [Tooltip("GetEffect")]
    private ParticleSystem particle;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            ParticleSystem newParticle = Instantiate(particle);
            newParticle.transform.position = this.transform.position;
            newParticle.Play();
            Destroy(newParticle.gameObject, 1.0f);
        }
    }

}