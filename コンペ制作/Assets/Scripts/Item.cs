using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //public GameObject itemObject;   //シーンに置いてある拾うアイテムの変数

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ball")    //当たった相手のTagがプレイヤーだったら
        {
            //itemObject.gameObject.SetActive(false);     //シーンに置かれたアイテムを消します
            gameObject.SetActive(false);     //シーンに置かれたアイテムを消します

        }
    }
}