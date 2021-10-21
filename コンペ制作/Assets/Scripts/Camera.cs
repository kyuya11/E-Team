using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private GameObject Ball;  //ボール情報格納用
    //private Vector3 offset; //相対距離取得用

    private float ballX = 0.0f;
    private float ballZ = 0.0f;
    private Vector3 BallStartPos;
    private Vector3 BallposKeep;
    private float cameraY = 0.0f;
    private float cameraZ = 0.0f;
    private float offsetX = 0.0f;
    private float offsetZ = 0.0f;

    private Vector3[] Goalstate = new[] { new Vector3(0f, 0f, 0f), new Vector3(0f, 0f, 0f) };
    private Vector3 Goal;
    private Vector3[] BallState = new[] { new Vector3(0f, 0f, 0f), new Vector3(0f, 0f, 0f) };
    //private Vector3[] Ballstate = new[] { new Vector3(0f, 0f, 0f), new Vector3(0f, 0f, 0f) };
    private float N = 0.0f; //ボールの移動量を求める
    private int count = 0;
    private int T = 0;
    private float length = 0.0f; //ボールの移動前/移動後距離
    private float length2 = 0.0f;
    bool flg = false; //カメラの初期化をしたかしていないか

    //Use this for initialization

    // Start is called before the first frame update
    void Start()
    {
        //Ballの情報取得
        this.Ball = GameObject.Find("Ball");

        BallStartPos = Ball.transform.position;

        offsetX = transform.position.x - Ball.transform.position.x;
        offsetZ = transform.position.z - Ball.transform.position.z;

        //カメラの軸は操作しないので初期位置を取得
        cameraY = transform.position.y;

        ballX = Ball.transform.position.x;
        ballZ = Ball.transform.position.z;


        //Goalstate[0] = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        //Goalstate[1] = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    // Update is called once per frame

    void Update()
    {

        length = Vector3.Distance(Goalstate[0], Goalstate[1]);
        //length = Vector3.Distance(BallState, Ball.transform.position);
        //length = Vector3.Distance(BallState[0], BallState[1]);

        //Debug.Log(length);

        //if(BallState != Ball.transform.position)
        //{
        //    Debug.Log("ボールが停止しています");
        //}

        //if (Ball.GetComponent<Rigidbody>().IsSleeping())
        //{
        //    Debug.Log("length値が0.0fになりました");

        //    //Debug.Log(Goalstate[0]);
        //    //Debug.Log(Goalstate[1]);

        //    N = 0;
        //    Debug.Log("Nが初期化されました");
        //    BallStartPos = Ball.transform.position; //新しいStartposに変更
        //    Debug.Log("BallStartPosを変更しました");
        //}

        //**************************if文の条件がlength0.0f.ver*************************
        //if (count >= 1)　//ボールの移動前と移動後の距離が重なった場合
        //{
        //    if(length > 0.0f)
        //    {
        //        Debug.Log("length値が0.0fになりました");

        //        //Debug.Log(Goalstate[0]);
        //        //Debug.Log(Goalstate[1]);

        //        N = 0;
        //        Debug.Log("Nが初期化されました");
        //        BallStartPos = Ball.transform.position; //新しいStartposに変更
        //        Debug.Log("BallStartPosを変更しました");
        //    }
            

        //}
        //**************************if文の条件がlength0.0f.ver*************************

        //if (BallState == Ball.transform.position)
        //{
        //    Debug.Log("length値が0.0fになりました");

        //    //Debug.Log(Goalstate[0]);
        //    //Debug.Log(Goalstate[1]);

        //    N = 0;
        //    Debug.Log("Nが初期化されました");
        //    BallStartPos = Ball.transform.position; //新しいStartposに変更
        //    Debug.Log("BallStartPosを変更しました");
        //}

            count++;
            if (count > 1)
            {
                count = 0;
            }
        

        
        BallState[count] = Ball.transform.position;

        //Debug.Log(Goalstate[0]);
        //Debug.Log(Goalstate[1]);

        //Debug.Log("BallState1の値" + BallState[1]);
        //Debug.Log("BallState0の値" + BallState[0]);

        N = Mathf.Abs(Vector3.Distance(Ball.transform.position, BallStartPos));
        //Debug.Log(N);
    }

    void LateUpdate()
    {

        

        if (ballX != Ball.transform.position.x || ballZ != Ball.transform.position.z)
        {
            Goalstate[count] = new Vector3(ballX + offsetX, cameraY, ballZ + offsetZ);

            ballX = Ball.transform.position.x;
            ballZ = Ball.transform.position.z;


            //Debug.Log(length);

            //**************************if文の条件がlength0.0f.ver*************************
            //if (length < 0.0f) //ボールの移動前と移動後の距離が重なった場合
            //{
            //    Debug.Log("length値が0.0fになりました");

            //    //Debug.Log(Goalstate[0]);
            //    //Debug.Log(Goalstate[1]);

            //    N = 0;
            //    Debug.Log("Nが初期化されました");
            //    BallStartPos = Ball.transform.position; //新しいStartposに変更
            //    Debug.Log("BallStartPosを変更しました");

            //}
            //**************************if文の条件がlength0.0f.ver*************************

            ////**************************if文の条件がlength0.01f.ver * ************************
            if (length < 0.01f) //カメラの移動前と移動後の距離lengthが0.01f未満になってきた場合
            {
                Debug.Log("length値が0.01以下になりました");
                if (flg == false)
                {
                    N = 0;
                    Debug.Log("Nが初期化されました");
                    flg = true; //一度初期化しました
                    BallStartPos = Ball.transform.position; //新しいStartposに変更
                    Debug.Log("BallStartPosを変更しました");
                    //Debug.Log(Ball.transform.position);
                }
                else
                {
                    if (N >= 5)
                    {
                        //Debug.Log(Vector3.Distance(BallStartPos, Ball.transform.position));
                        if (Vector3.Distance(BallStartPos, Ball.transform.position) < 0.01f) //前の値と今の値の変化量が0.01fより小さい場合
                        //if (length < 0.01f) //前の値と今の値の変化量が0.01fより小さい場合
                        {
                            ;
                        }
                        else
                        {

                            Debug.Log("フラグを戻します");
                            flg = false; //初期化しても良い状態に戻す
                        }
                        //Debug.Log("N");
                        //flg = false; //初期化しても良い状態に戻す
                    }
                }
            }
            //    //**************************if文の条件がlength0.01f.ver * ************************



            Goal = new Vector3(ballX + offsetX, cameraY, ballZ + offsetZ);

        }
        //else if(ballX == Ball.transform.position.x && ballZ == Ball.transform.position.z)
        //{
        //    N = 0;
        //    Debug.Log("Nが初期化されました");
        //    BallStartPos = Ball.transform.position; //新しいStartposに変更
        //    //Debug.Log("BallStartPosを変更しました");
        //}

        if (N >= 1.5f)
        {
            transform.position = Vector3.Lerp(transform.position, Goal, 6.0f * Time.deltaTime);
        }
        //transform.position = new Vector3(ballX + offsetX, cameraY, ballZ + offsetZ);


        ////新しいトランスフォームの値を代入する
        //transform.position = Ball.transform.position + offset;

    }
}

