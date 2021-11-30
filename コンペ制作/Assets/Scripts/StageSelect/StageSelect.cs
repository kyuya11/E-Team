using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{
    GameObject Subcam;
    GameObject CamPos1;
    GameObject CamPos2;
    public static int MenuNumber = 0;
    RectTransform rect;

    bool pushFlag = false;
    bool Resultflag;

    void Start()
    {
        Subcam = GameObject.Find("Camera2");
        CamPos1 = GameObject.Find("Campos1");
        CamPos2 = GameObject.Find("Campos2");
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
                Subcam.transform.position = CamPos1.transform.position;
                rect.localPosition = new Vector3(-384, -61, 0); 
                
                if (Input.GetButton("A"))
                {
                    StartCoroutine(RetryCoroutine());
                }
                //Debug.Log("0");
                break;
            case 1:
                Subcam.transform.position = CamPos2.transform.position;
                rect.localPosition = new Vector3(-384, -115, 0);

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
