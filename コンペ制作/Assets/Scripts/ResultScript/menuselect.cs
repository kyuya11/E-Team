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
    void Start()
    {
        rect = GetComponent<RectTransform>();
    }

    void Update()
    {
        if (Input.GetAxis("Vertical") == -1|| Input.GetAxis("Vertical2") == -1)
        {
            if (pushFlag == false)
            {
                pushFlag = true;
                if (++MenuNumber > 2) MenuNumber = 0;

            }
        }
        else if (Input.GetAxis("Vertical") == 1|| Input.GetAxis("Vertical2") == 1)
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


        switch (MenuNumber)
        {
            case 0:
                rect.localPosition = new Vector3(-154, -36, 0);
                if (Input.GetButton("A"))
                {
                    Time.timeScale = 1;
                    SceneManager.LoadScene("SampleScene");
                }
                //Debug.Log("0");
                break;
            case 1:
                rect.localPosition = new Vector3(-188, -91, 0);
                if (Input.GetButton("A"))
                {
                    Time.timeScale = 1;
                    SceneManager.LoadScene("Title");

                }
                //Debug.Log("1");
                break;
            case 2:
                rect.localPosition = new Vector3(-206, -145, 0);
                if (Input.GetButton("A"))
                {
                    Application.Quit();

                }
                //Debug.Log("2");
                break;

        }
    }
}