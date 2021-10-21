using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class Pause : MonoBehaviour
    {

        [SerializeField]
        GameObject pausePanel;

    private void Start()
    {
        pausePanel.SetActive(false);
    }
    void Update()
        {
            if (Input.GetKeyDown(KeyCode.P)|| Input.GetButton("joystick button 9"))
            {
                if (Time.timeScale == 1)
                {
                    Time.timeScale = 0;
                    pausePanel.SetActive(true);
                }
                else
                {
                    Time.timeScale = 1;
                    pausePanel.SetActive(false);
                }
            }
        }

    }