using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class result : MonoBehaviour
{
    public Text Counttext;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        score = Item.GetItemCount();

        Counttext.text = string.Format("獲得したコイン  :  {0}/12", score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
