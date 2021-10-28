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

    
    //public GameObject itemObject;   //シーンに置いてある拾うアイテムの変数

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ball")    //当たった相手のTagがプレイヤーだったら
        {
            //itemObject.gameObject.SetActive(false);     //シーンに置かれたアイテムを消します
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