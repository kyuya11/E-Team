using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Efect : MonoBehaviour
{
    public GameObject particleObject;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            Instantiate(particleObject, this.transform.position, Quaternion.identity);

        }
    }
}
