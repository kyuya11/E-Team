using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    float lastTimeArrowKeyDown_ = 0f;
    [SerializeField]
    GameObject pausePanel;
    private bool pausegame;
    private bool Panel;

    private void Start()
    {
        pausePanel.SetActive(false);
        pausegame = false;
        Panel = false;
    }
    void Update()
    {
        if (Time.time - lastTimeArrowKeyDown_ > 0.25f)
        {
            pausegame = false;
        }

        if (pausegame == false)
        {

            {
                if (/*Input.GetKeyDown(KeyCode.P) || */Input.GetButton("Start"))
                {
                    lastTimeArrowKeyDown_ = Time.time;

                    pausegame = !pausegame;
                    if (pausegame == true)
                    {
                        Time.timeScale = 0;
                        pausePanel.SetActive(true);
                    }
                    else if(Panel == true)
                    {
                        Time.timeScale = 1;
                        pausePanel.SetActive(false);
                    }
                }
            }
        }
    }
}