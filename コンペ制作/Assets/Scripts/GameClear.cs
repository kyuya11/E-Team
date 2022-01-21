using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameClear : MonoBehaviour
{
    public Text clearText;
    int resultItemCount;
    float next = 0;
    bool flg = false;
    private static bool GameClearFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        clearText.enabled = false;
    }
    void Update()
    {
        if (resultItemCount >= 12)
        {
            if (Time.unscaledTime - next >= 1.0f)
            {
                SceneManager.LoadScene("result");
                Time.timeScale = 1f;
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        resultItemCount = Item.GetItemCount();
        //Debug.Log(Time.unscaledTime - next);
        if (resultItemCount >= 12)
        {
            clearText.enabled = true;
            if (flg == false)
            {
                GameClearFlag = true;
                next = Time.unscaledTime;
                flg = true;
            }
            

            Time.timeScale = 0f;

            
        }
        else
        {
            flg = false;
            GameClearFlag = false;
        }
    }
    public static bool ClearText()
    {
        return GameClearFlag;
    }
}
