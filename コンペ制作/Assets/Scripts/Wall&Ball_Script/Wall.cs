/*
 * PhysicMaterialで管理しているので今は使わないかも
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Ball")
        {
            Vector3 norm = other.contacts[0].normal;
            Vector3 vel = other.rigidbody.velocity.normalized;
            vel += new Vector3(-norm.x * 2, 0f, -norm.z * 2);
            other.rigidbody.AddForce(vel, ForceMode.Impulse);
        }
    }
}
