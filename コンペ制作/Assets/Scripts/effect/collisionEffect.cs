using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionEffect : MonoBehaviour
{
    public GameObject particleObject;
    //private const string EFFECT_PATH = "Assets/Scripts/effect/CFX_Hit_C White";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            //Instantiate(particleObject, this.transform.position, Quaternion. identity);
            foreach (ContactPoint point in collision.contacts)
            {
                GameObject effect = Instantiate(particleObject) as GameObject;
                effect.transform.position = (Vector3)point.point;
            }
        }
    }
}
