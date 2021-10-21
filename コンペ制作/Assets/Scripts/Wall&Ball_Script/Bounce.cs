using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Rigidbodyがアタッチされていない場合はアタッチする
[RequireComponent(typeof(Rigidbody))]
public class Bounce : MonoBehaviour
{
    [SerializeField]
    [Tooltip("跳ね返す単位ベクトルにかける倍数")]
    private float bounceVectorMultiple = 2f;

    private void OnCollisionEnter(Collision other)
    {
        //当たった相手に"Ball"タグがついている場合
        if(other.gameObject.tag == "Ball")
        {
            //衝突した面の、接触した点における法線ベクトルを取得
            Vector3 normal = other.contacts[0].normal;
            //衝突した速度ベクトルを単位ベクトルにする
            Vector3 velocity = other.rigidbody.velocity.normalized;
            //x,z方向に対して逆向きの法線ベクトルを取得
            velocity += new Vector3(-normal.x * bounceVectorMultiple, 0f, -normal.z * bounceVectorMultiple);
            //取得した法線ベクトルに跳ね返す速さをかけて、跳ね返す
            other.rigidbody.AddForce(velocity, ForceMode.Impulse);
        }
    }
}
