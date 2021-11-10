//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class MyRigidbody : MonoBehaviour
//{
//    public Vector3 acceleration;    // 加速度

//    public Vector3 velocity;        // 速度

//    public Vector3 position;        // 位置は速度の時間積分

//    public float mass;  // 質量に相当
//    public Vector3 gravityScale;    // 重力加速度

//    const float dt = 1f / 60f;      // 微笑時間dtに相当する部分

//    public GameObject Floor;
//    void Start()
//    {
//        floor = GameObject.Find("floor");
//    }

//    public void AddForce(Vector3 force)
//    {
//        acceleration += force / mass;      // 慣性質量が働く分、力をmassで割ってから加速度を加える
//    }

//    void FixedUpdate()
//    {
//        acceleration += gravityScale;    /* 運動方程式から、両辺をm(mass)で割った
//                                            値を使う*/

//        velocity += acceleration * Time.fixedDeltaTime;  // 積分に使う微笑時間を、デルタタイムに変更
//        position += velocity * Time.fixedDeltaTime;      // 速度を時間積分

//        // 地面と接触したら、跳ね返る表現
//        //　地面に近いところまで落ちたら速度を反転
//        if(position.y < 0.5f)
//        {
//            velocity = -velocity;
//        }
//        transform.position = position;
//        acceleration = Vector3.zero;    // 加速度をリセット。
//    }

//    void Update()
//    {
//        Vector3 Floorp = Floor.transform.position;
//    }
//}
