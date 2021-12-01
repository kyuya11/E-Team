using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    [SerializeField]
    GameObject pausePanel;
    bool pushFlag = false;
    bool getcountdown;
    bool pushscene;

    private void Start()
    {
        pausePanel.SetActive(false);
    }

    void Update()
    {
        getcountdown = StartCount.CountDownStart();
        pushscene = NewBehaviourScript.PushLoadScene();

        
            if (getcountdown == false)
            {
            if (pushscene == false)
            {
                if (Input.GetKeyDown(KeyCode.P) || Input.GetButton("Start"))
                {

                    if (pushFlag == false)
                    {
                        pushFlag = true;
                        if (Time.timeScale == 1)
                        {
                            Time.timeScale = 0;
                            pausePanel.SetActive(true);
                        }
                        else
                        {
                            pushFlag = true;
                            Time.timeScale = 1;
                            pausePanel.SetActive(false);
                        }
                    }

                }
                else
                {
                    pushFlag = false;
                }
                //Debug.Log(pushFlag);
            }
        }
    }
}