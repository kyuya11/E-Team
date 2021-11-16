using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRetry : MonoBehaviour
{
    public static bool SE;

    public GameObject resultpanel;
    public GameObject Confetti;
    // Start is called before the first frame update
    void Start()
    {
        Confetti.SetActive(true);
        resultpanel.SetActive(true);
        SE = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("X") || Input.GetButton("B"))
        {
            Confetti.SetActive(false);
            resultpanel.SetActive(false);
            SE = false;
        }
    }

    public static bool GetSE()
    {
        return SE;
    }
}
