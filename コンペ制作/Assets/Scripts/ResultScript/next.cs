using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next : MonoBehaviour
{
    public GameObject Result;
    public GameObject Retry;
    private static bool MenuSelect;   //選択した後に操作できないようにするためのフラグ


    // Start is called before the first frame update
    void Start()
    {
        Retry.SetActive(false);
        MenuSelect = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("X")|| Input.GetButton("B"))
        {
            Result.SetActive(false);
            Retry.SetActive(true);
            MenuSelect = true;
        }
    }

    public static bool GetMenuSelect()
    {
        return MenuSelect;
    }
}
