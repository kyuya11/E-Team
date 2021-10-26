using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ball")    //当たった相手のTagがプレイヤーだったら
        {
            gameObject.SetActive(false);     //シーンに置かれたアイテムを消します
        }
    }
}