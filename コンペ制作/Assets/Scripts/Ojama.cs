using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ojama : MonoBehaviour
{
    public Material[] _material;
    private int i; //配列の要素番号
    GameObject SpeedDown;
    GameObject Poison;
    bool Flg;
    bool TimeFlg; //Timekeep専用
    private float Timekeep;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        Flg = false;
        Timekeep = 0.0f;
        SpeedDown = GameObject.Find("PoisonSmoke");
        Poison = GameObject.Find("Poison");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Flg == true)
        {
            Poison.SetActive(false);
            if (TimeFlg == false)
            {
                Timekeep = Time.time;
                TimeFlg = true;
            }
            
            i = 1;
            this.GetComponent<Renderer>().material = _material[i];
            SpeedDown.transform.position = transform.position;


            //Debug.Log(Flg);
            //Debug.Log(Time.time - Timekeep);

            if (Time.time - Timekeep >= 2.0f)
            {
                Flg = false;
                i = 0;
                TimeFlg = false;
                SpeedDown.SetActive(false);
                this.GetComponent<Renderer>().material = _material[i];
            }
        }
        

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ojama")
        {
            Flg = true;

        }
    }
}
