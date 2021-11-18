using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitFloor : MonoBehaviour
{
    GameObject ver1; //頂点1
    GameObject ver2; //頂点2
    GameObject cen; //中央
    GameObject PerpPos; //垂直の法線の位置
    GameObject Ball;
    GameObject BallP;

    private Vector3 ballP; //Ballの床につく点

    private float offsetX;
    private float offsetY;
    private float offsetZ;


    private Vector3 Normal;
    private float Angle;
    private int CstAngle;
    // Start is called before the first frame update
    void Start()
    {
        Angle = 0.0f;
        ver1 = GameObject.Find("Vertex1");
        ver2 = GameObject.Find("Vertex2");
        cen = GameObject.Find("Center");
        PerpPos = GameObject.Find("perp");
        Ball = GameObject.Find("Ball");
        BallP = GameObject.Find("ballP");

        //ballP = new Vector3(Ball.transform.position.x, Ball.transform.position.y - 1.0f, Ball.transform.position.z);

        offsetX = Ball.transform.position.x - BallP.transform.position.x;
        offsetY = Ball.transform.position.y - BallP.transform.position.y;
        offsetZ = Ball.transform.position.z - BallP.transform.position.z;

        
    }

    // Update is called once per frame
    void Update()
    {
        var Side1 = cen.transform.position + ver1.transform.position;
        var Side2 = cen.transform.position + ver2.transform.position;

        var perp = Vector3.Cross(Side1, Side2); //perp:perpendicularの略 意味:垂直

        PerpPos.transform.position = perp;

        BallP.transform.position = new Vector3(Ball.transform.position.x - offsetX, Ball.transform.position.y - offsetY, Ball.transform.position.z - offsetZ);

        Debug.Log(perp);
        //Debug.Log(cen.transform.position);

        ballP = new Vector3(Ball.transform.position.x, Ball.transform.position.y - 1.5f, Ball.transform.position.z);

        Angle = Vector3.Angle(perp, ballP);
        CstAngle = (int)Angle;
        Debug.Log(Angle);
        Debug.Log(CstAngle);

        if (Angle >= 90)
        {
            //Debug.Log("床の上です");
        }
    }
}
