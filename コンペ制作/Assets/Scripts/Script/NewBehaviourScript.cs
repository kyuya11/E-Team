using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    static int MenuNumber = 0;
    RectTransform rect;

    bool pushFlag = false;
    bool SEflag = false;
    int StageNumber = 0;

    void Start()
    {
        rect = GetComponent<RectTransform>();
    }

    void Update()
    {
        SEflag = Seselect.GetSEFlag();
        StageNumber = StageSelect.StageNumber();

        if (SEflag == false)
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

        switch (MenuNumber)
        {
            case 0:
                rect.localPosition = new Vector3(-420, 40, 0);
                if (Input.GetButton("A"))
                {
                    StartCoroutine(RetryCoroutine());
                }
                //Debug.Log("0");
                break;
            case 1:
                rect.localPosition = new Vector3(-420, -80, 0);
                if (Input.GetButton("A"))
                {
                    StartCoroutine(TitleCoroutine());
                }
                //Debug.Log("1");
                break;
            case 2:
                rect.localPosition = new Vector3(-420, -200, 0);
                if (Input.GetButton("A") || Input.GetButton("A") && Input.GetAxis("Vertical") == 1 || Input.GetAxis("Vertical2") == 1)
                {
                    StartCoroutine(EndCoroutine());
                }
                //Debug.Log("2");
                break;

        }
    }
    private IEnumerator RetryCoroutine()
    {
        yield return new WaitForSecondsRealtime(1.5f);

        if (StageNumber == 0)
        {
            SceneManager.LoadScene("Stage1");
        }
        else if (StageNumber == 1)
        {
            SceneManager.LoadScene("Stage2");
        }
        Time.timeScale = 1;
    }
    private IEnumerator TitleCoroutine()
    {
        yield return new WaitForSecondsRealtime(1.5f);

        SceneManager.LoadScene("Title");
        Time.timeScale = 1;
    }
    private IEnumerator EndCoroutine()
    {
        yield return new WaitForSecondsRealtime(1.5f);
        Application.Quit();

    }
}