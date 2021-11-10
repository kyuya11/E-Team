using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartCount : MonoBehaviour
{
    public Text textCountDown;
    private static bool count;

    // Start is called before the first frame update
    void Start()
    {
        count = true;
        if (count == true)
        {
            StartCoroutine(CountFrame());
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    public static bool CountDownStart()
    {
        return count;
    }

    IEnumerator CountFrame()
    {
        textCountDown.gameObject.SetActive(true); //引数で指定されたオブジェクトを表示する

        textCountDown.text = "3";
        yield return new WaitForSeconds(1.0f); // 引数で指定された秒数待つ

        textCountDown.text = "2";
        yield return new WaitForSeconds(1.0f); // 引数で指定された秒数待つ

        textCountDown.text = "1";
        yield return new WaitForSeconds(1.0f); // 引数で指定された秒数待つ

        textCountDown.text = "START!";
        yield return new WaitForSeconds(0.5f); // 引数で指定された秒数待つ

        textCountDown.text = "";
        textCountDown.gameObject.SetActive(false); //引数で指定されたオブジェクトを非表示にする
        count = false;
    }
}