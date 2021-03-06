using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuselect : MonoBehaviour
{
    static int MenuNumber = 0;
    RectTransform rect;

    bool pushFlag = false;
    bool Selectflag;
    bool Resultflag;
    int StageNumber = 0;

    void Start()
    {
        rect = GetComponent<RectTransform>();
    }

    void Update()
    {
        Selectflag = next.GetMenuSelect();
        Resultflag = ResultSE.GetResultSEFlag();
        StageNumber = StageSelect.StageNumber();

        if (Selectflag == true)
        {
            if (Resultflag == false)
            {
                if (Input.GetAxis("Vertical") == -1 || Input.GetAxis("Vertical2") == -1)
                {
                    if (pushFlag == false)
                    {
                        pushFlag = true;
                        if (++MenuNumber > 2) MenuNumber = 0;

                    }
                }
                else if (Input.GetAxis("Vertical") == 1 || Input.GetAxis("Vertical2") == 1)
                {
                    if (pushFlag == false)
                    {
                        pushFlag = true;
                        if (--MenuNumber < 0) MenuNumber = 2;

                    }
                }
                else
                {
                    pushFlag = false;
                }
            }
        }



        switch (MenuNumber)
        {
            case 0:
                rect.localPosition = new Vector3(-204, -101, 0);
                if (Input.GetButton("A"))
                {
                    StartCoroutine(RetryCoroutine());
                }
                //Debug.Log("0");
                break;
            case 1:
                rect.localPosition = new Vector3(-273, -171, 0);
                if (Input.GetButton("A"))
                {
                    StartCoroutine(TitleCoroutine());

                }
                //Debug.Log("1");
                break;
            case 2:
                rect.localPosition = new Vector3(-311, -240, 0);
                if (Input.GetButton("A"))
                {
                    StartCoroutine(EndCoroutine());
                }
                //Debug.Log("2");
                break;

        }
    }
    private IEnumerator RetryCoroutine()
    {
        yield return new WaitForSecondsRealtime(1.5f);  //1.5秒待った後にシーンをロード

        //StageNumber変数に入っている数字でロードするシーンを決める
        if (StageNumber == 0)
        {
            SceneManager.LoadScene("Stage1");
            MenuNumber = 0;
        }
        else if (StageNumber == 1)
        {
            SceneManager.LoadScene("Stage2");
            MenuNumber = 0;
        }
        else if (StageNumber == 2)
        {
            SceneManager.LoadScene("Stage3");
            MenuNumber = 0;
        }
        else if (StageNumber == 3)
        {
            SceneManager.LoadScene("Stage4");
            MenuNumber = 0;
        }
        Time.timeScale = 1;
    }


    private IEnumerator TitleCoroutine()
    {
        yield return new WaitForSecondsRealtime(1.5f);

        SceneManager.LoadScene("Title");
        MenuNumber = 0;
        Time.timeScale = 1;
    }


    private IEnumerator EndCoroutine()
    {
        yield return new WaitForSecondsRealtime(1.5f);
        Application.Quit();

    }
}
