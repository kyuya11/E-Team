using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next : MonoBehaviour
{
    GameObject Result;
    GameObject Retry;
    // Start is called before the first frame update
    void Start()
    {
        Retry.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("X")|| Input.GetButton("B"))
        {
            Result.SetActive(false);
            Retry.SetActive(true);
        }
    }
}
