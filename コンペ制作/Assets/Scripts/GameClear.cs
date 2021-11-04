using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameClear : MonoBehaviour
{
    public Text clearText;
    int resultItemCount;

    // Start is called before the first frame update
    void Start()
    {
        clearText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        resultItemCount = Item.GetItemCount();

        if (resultItemCount >= 12)
        {
            clearText.enabled = true;
            Time.timeScale = 0f;
            StartCoroutine("Coroutine");
        }
    }
    private IEnumerator Coroutine()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("result");
    }
}
