using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    [SerializeField]
    GameObject RetryPanel;

    private void Start()
    {
        RetryPanel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O) || Input.GetButton("B"))
        {
            RetryPanel.SetActive(true);
        }
    }
}