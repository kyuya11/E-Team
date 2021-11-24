using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{
    public static int MenuNumber = 0;
    RectTransform rect;

    bool pushFlag = false;
    bool Resultflag;

    void Start()
    {
        rect = GetComponent<RectTransform>();
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
                    if (++MenuNumber > 1) MenuNumber = 0;

                }
            }
            else if (Input.GetAxis("Vertical") == 1 || Input.GetAxis("Vertical2") == 1)
            {
                if (pushFlag == false)
                {
                    pushFlag = true;
                    if (--MenuNumber < 0) MenuNumber = 1;

                }
            }
            else
            {
                pushFlag = false;
            }

        }



        switch (MenuNumber)
        {
            case 0:
                rect.localPosition = new Vector3(-700,80, 0);
                if (Input.GetButton("A"))
                {
                    StartCoroutine(RetryCoroutine());
                }
                //Debug.Log("0");
                break;
            case 1:
                rect.localPosition = new Vector3(-700, 25, 0);
                if (Input.GetButton("A"))
                {
                    StartCoroutine(TitleCoroutine());

                }
                //Debug.Log("1");
                break;
        }
    }
    private IEnumerator RetryCoroutine()
    {
        yield return new WaitForSecondsRealtime(1.5f);

        SceneManager.LoadScene("Stage1");
        Time.timeScale = 1;
    }
    private IEnumerator TitleCoroutine()
    {
        yield return new WaitForSecondsRealtime(1.5f);

        SceneManager.LoadScene("Stage2");
        Time.timeScale = 1;
    }
    public static int StageNumber()
    {
        return MenuNumber;
    }
}
