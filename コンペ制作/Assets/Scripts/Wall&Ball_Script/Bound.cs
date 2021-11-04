/*
 * PhysicMaterialで管理しているので今は使わないかも
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bound : MonoBehaviour
{
    //ボールが当たった物体の法線ベクトル
    private Vector3 objNomalVector = Vector3.zero;

    //ボールのrigidbody
    private Rigidbody rb;

    //跳ね返った後のverocity
    [HideInInspector] public Vector3 afterReflectVero = Vector3.zero;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    //private void FixedUpdate()
    //{
    //    rb.velocity *= 0.99f;
    //}


    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            //当たった物体の法線ベクトルを取得
            objNomalVector = other.contacts[0].normal;
            Vector3 reflectVec = Vector3.Reflect(afterReflectVero, objNomalVector);
            rb.velocity = reflectVec;
            //計算した反射ベクトルを保存
            afterReflectVero = rb.velocity;
            //Debug.Log("nomal:" + afterReflectVero);
        }
    }
}