using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ojama : MonoBehaviour
{
    public Material[] _material;
    private int i; //配列の要素番号
    GameObject SpeedDown1;
    GameObject SpeedDown2;
    GameObject Poison1;
    GameObject Poison2;
    bool Flg1;
    bool Flg2;
    bool TimeFlg; //Timekeep専用
    private float Timekeep;
    private int StageNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        Flg1 = false;
        Flg2 = false;
        Timekeep = 0.0f;
        SpeedDown1 = GameObject.Find("PoisonSmoke1");
        SpeedDown2 = GameObject.Find("PoisonSmoke2");
        Poison1 = GameObject.Find("Poison1");
        Poison2 = GameObject.Find("Poison2");
    }

    // Update is called once per frame
    void Update()
    {
        StageNumber = StageSelect.StageNumber();

        if (Flg1 == true || Flg2 == true)
        {
            if (Flg1 == true)
            {
                Poison1.SetActive(false);
            }
            if (Flg2 == true)
            {
                Poison2.SetActive(false);
            }
            if (TimeFlg == false)
            {
                Timekeep = Time.time;
                TimeFlg = true;
            }
            
            i = 1;
            this.GetComponent<Renderer>().material = _material[i];
            if (Flg1 == true)
            {
                SpeedDown1.transform.position = transform.position;
            }
            if (Flg2 == true)
            {
                SpeedDown2.transform.position = transform.position;
            }

            //Debug.Log(Flg);
            //Debug.Log(Time.time - Timekeep);

            if (Time.time - Timekeep >= 2.0f)
            {
                if (Flg1 == true)
                {
                    Flg1 = false;
                }
                if(Flg2 == true)
                {
                    Flg2 = false;
                }
                
                i = 0;
                TimeFlg = false;
                if (Poison1.activeSelf) //posion1のアクティブ状態がtrueのとき
                {
                }
                else
                {
                    SpeedDown1.SetActive(false);
                    this.GetComponent<Renderer>().material = _material[i];
                }
                //if (Poison2.activeSelf)
                //{
                //}
                //else
                //{
                //    SpeedDown2.SetActive(false);
                //    this.GetComponent<Renderer>().material = _material[i];
                //}
                if (StageNumber == 1)
                {
                    if (Poison2.activeSelf)
                    {
                    }
                    else
                    {
                        SpeedDown2.SetActive(false);
                        this.GetComponent<Renderer>().material = _material[i];
                    }
                }

                //this.GetComponent<Renderer>().material = _material[i];
            }
        }
        

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ojama1")
        {
            Flg1 = true;

        }
        if (other.gameObject.tag == "Ojama2")
        {
            Flg2 = true;

        }
    }
}
