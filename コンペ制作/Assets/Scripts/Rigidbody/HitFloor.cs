using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitFloor : MonoBehaviour
{
    GameObject ver1; //頂点1
    GameObject ver2; //頂点2
    GameObject cen; //中央

    GameObject Ball;
    private Vector3 ballP; //Ballの床につく点

    private Vector3 Normal;
    private float Angle;
    // Start is called before the first frame update
    void Start()
    {
        ver1 = GameObject.Find("Vertex1");
        ver2 = GameObject.Find("Vertex2");
        cen = GameObject.Find("Center");

        Ball = GameObject.Find("Ball");
        ballP = new Vector3(Ball.transform.position.x, Ball.transform.position.y - 1.0f, Ball.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        var Side1 = ver1.transform.position - cen.transform.position;
        var Side2 = ver2.transform.position - cen.transform.position;

        var perp = Vector3.Cross(Side1, Side2); //perp:perpendicularの略 意味:垂直

        Debug.Log(perp);

        ballP = new Vector3(Ball.transform.position.x, Ball.transform.position.y - 1.0f, Ball.transform.position.z);

        Angle = Vector3.Angle(perp, ballP);
        Debug.Log(Angle);
        if(Angle >= 90)
        {
            //Debug.Log("床の上です");
        }
    }
}
