using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour
{
    private Vector3 targetpos;
    void Start()
    {
        //壁のポジションを取得
        targetpos = transform.position;
    }

    void Update()
    {
        /*Time.timeはゲームを開始してからの経過時間
         * Math.Sin()にTime.timeを渡すことで、「-1」～「1」の値を取得する
         * そのままだと動く範囲が狭いので「10.0f」を掛ける
         * それをＸ軸に足すことで、左右に自動で動く
         * 移動させる方向を変えたい場合は、
         * Sin関数の位置をX,Y,Zの移動させたい方向にする
         */
        transform.position = new Vector3(Mathf.Sin(Time.time) * 8.5f + targetpos.x, targetpos.y, targetpos.z);

    }
}
