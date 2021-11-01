using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Item : MonoBehaviour
{
    public Text Counttext;
    private static int getItemCount;
    void Start() 
    {
        getItemCount = 0;

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")    //当たった相手のTagがBallだったら
        {
            gameObject.SetActive(false);     //シーンに置かれたアイテムを消します
            getItemCount += 1;
            Counttext.text = string.Format("{0}/12", getItemCount);
        }
    }

    public static int GetItemCount()
    {
        return getItemCount;
    }
}