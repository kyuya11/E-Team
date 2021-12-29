using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{

    GameObject StageIMG;
    public static int MenuNumber = 0;
    RectTransform rect;

    bool pushFlag = false;
    bool Resultflag;

    void Start()
    {

        rect = GetComponent<RectTransform>();
        StageIMG = GameObject.Find("StageIMG");
        StageIMG.GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Stage1");
    }

    void Update()
    {



        Resultflag = StageSelectSE.GetResultSEFlag();
        if (Resultflag == false)
        {
            if (Input.GetAxis("Vertical") == -1 || Input.GetAxis("Vertical2") == -1)
            {
                if (pushFlag == false)
                {
                    pushFlag = true;
                    if (++MenuNumber > 3) MenuNumber = 0;   //Stage4より下に入力したらStage1にカーソルが戻る（多分）

                }
            }
            else if (Input.GetAxis("Vertical") == 1 || Input.GetAxis("Vertical2") == 1)
            {
                if (pushFlag == false)
                {
                    pushFlag = true;
                    if (--MenuNumber < 0) MenuNumber = 3;   //Stage1より上に入力したらStage4にカーソルが移動する(多分）

                }
            }
            else
            {
                pushFlag = false;
            }

        }



        switch (MenuNumber)
        {
            case 0: //ステージ１

                rect.localPosition = new Vector3(-384, -61, 0); //Stage1のTextのポジション
                StageIMG.GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Stage1");    //多分Stage1の右側の画像

                if (Input.GetButton("A"))   //Aボタンを押したらコルーチン開始
                {
                    StartCoroutine(RetryCoroutine());
                }
                //Debug.Log("0");
                break;
            case 1: //ステージ２

                rect.localPosition = new Vector3(-384, -115, 0);    //Stage2のTextのポジション
                StageIMG.GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Stage2");    //多分Stage2の右側の画像

                if (Input.GetButton("A"))   //Aボタンを押したらコルーチン開始
                {
                    StartCoroutine(TitleCoroutine());
                }
                //Debug.Log("1");
                break;
            case 2: //ステージ3

                rect.localPosition = new Vector3(-384, -169, 0);    //Stage3のTextのポジション
                StageIMG.GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Stage3");    //多分Stage3の右側の画像(予定）

                if (Input.GetButton("A"))   //Aボタンを押したらコルーチン開始
                {
                    StartCoroutine(Stage3Coroutine());
                }
                break;
            case 3: //ステージ4

                rect.localPosition = new Vector3(-384, -223, 0);    //Stage4のTextのポジション
                StageIMG.GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Stage4");    //多分Stage4の右側の画像(予定)

                if (Input.GetButton("A"))   //Aボタンを押したらコルーチン開始
                {
                    StartCoroutine(Stage4Coroutine());
                }
                break;
        }
    }

    //ステージ１をロードするコルーチン
    private IEnumerator RetryCoroutine()
    {
        yield return new WaitForSecondsRealtime(1.5f);  //1.5秒待った後にシーンをロード

        SceneManager.LoadScene("Stage1");
        Time.timeScale = 1;
    }

    //ステージ２をロードするコルーチン
    private IEnumerator TitleCoroutine()
    {
        yield return new WaitForSecondsRealtime(1.5f);  //1.5秒待った後にシーンをロード

        SceneManager.LoadScene("Stage2");
        Time.timeScale = 1;
    }

    //ステージ３をロードするコルーチン
    private IEnumerator Stage3Coroutine()
    {
        yield return new WaitForSecondsRealtime(1.5f);  //1.5秒待った後にシーンをロード

        SceneManager.LoadScene("Stage3");
        Time.timeScale = 1;
    }

    //ステージ４をロードするコルーチン
    private IEnumerator Stage4Coroutine()
    {
        yield return new WaitForSecondsRealtime(1.5f);  //1.5秒待った後にシーンをロード

        SceneManager.LoadScene("Stage4");
        Time.timeScale = 1;
    }


    //他のスクリプトでも使えるようにpublic static で管理
    public static int StageNumber()
    {
        return MenuNumber;
    }
}
