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
                
                rect.localPosition = new Vector3(-384, -61, 0);
                StageIMG.GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Stage1");

                if (Input.GetButton("A"))
                {
                    StartCoroutine(RetryCoroutine());
                }
                //Debug.Log("0");
                break;
            case 1:
                
                rect.localPosition = new Vector3(-384, -115, 0);
                StageIMG.GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Stage2");

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
