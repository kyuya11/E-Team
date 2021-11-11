using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRetry : MonoBehaviour
{
    public static bool SE;

    public GameObject resultpanel;
    // Start is called before the first frame update
    void Start()
    {
        resultpanel.SetActive(true);
        SE = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("X") || Input.GetButton("B"))
        {
            resultpanel.SetActive(false);
            SE = false;
        }
    }

    public static bool GetSE()
    {
        return SE;
    }
}
