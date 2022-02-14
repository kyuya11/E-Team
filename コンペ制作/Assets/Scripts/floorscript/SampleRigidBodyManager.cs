//using System.Collections;
//using System.Collections.Generic;
//using Unity.Mathematics;
//using UnityEngine;
//using Random = Unity.Mathematics.Random;

//public class SampleRigidBodyManager : MonoBehaviour
//{
//    [SerializeField] private SampleRigidBody rigidBodyPrefab;
//    private readonly List<SampleRigidBody> _rigidBodies = new List<SampleRigidBody>();
//    private Random _random;



//    // Start is called before the first frame update
//    void Start()
//    {
//        //_random = new Random(1);
//        //for (var i = 0; i < 20; ++i)
//        //{
//        //    var rigidBody = Instantiate(rigidBodyPrefab);
//        //    rigidBody.transform.position = _random.NextFloat3(-1.5f, 1.5f);
//        //    _rigidBodies.Add(rigidBody);
//        //}

//        //var rigidBody = Instantiate(rigidBodyPrefab);
//        //Instantiate(rigidBodyPrefab, new Vector3(0.0f, 1.5f, 0.0f), Quaternion.identity);
//        //_rigidBodies.Add(rigidBody);
//        var rigidBody = Instantiate(rigidBodyPrefab);
//        rigidBody.transform.position = new Vector3(0.0f, 1.5f, 0.0f);
//        _rigidBodies.Add(rigidBody);
//    }

//    // Update is called once per frame
//    void FixedUpdate()
//    {
//        foreach(var rigidbody in _rigidBodies)
//        {
//            var position = rigidbody.transform.position;
//            var velocity = (position - rigidbody.PrevPosition) / Time.deltaTime;

//            velocity += Physics.gravity * Time.deltaTime;

//            rigidbody.PrevPosition = position;
//            position += velocity * Time.deltaTime;

//            rigidbody.transform.position = position;
//        }
//        for(var i = 0; i < _rigidBodies.Count - 1; ++i)
//        {
//            for(var j = i; j < _rigidBodies.Count; ++j)
//            {
//                var rigidBody1 = _rigidBodies[i];
//                var rigidBody2 = _rigidBodies[j];
//                if(rigidBody1 == rigidBody2)
//                {
//                    continue;
//                }
//                var a = rigidBody1.transform.position;
//                var b = rigidBody2.transform.position;

//                var ab = b - a;

//                var abMagnitude = ab.magnitude;
//                var abDirection = ab.normalized;
//                if (abDirection == Vector3.zero) abDirection = Vector3.up;

//                if(abMagnitude < 1)
//                {
//                    a -= (1 - abMagnitude) * abDirection / 2;
//                    b += (1 - abMagnitude) * abDirection / 2;
//                }

//                //a = math.clamp(a, -2, 2);
//                //b = math.clamp(b, -2, 2);

//                rigidBody1.transform.position = a;
//                rigidBody2.transform.position = b;
//            }
//        }
//    }
//}
