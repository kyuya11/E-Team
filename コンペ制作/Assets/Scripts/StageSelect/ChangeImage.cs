using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Resources.Load<Texture2D>("Stage1");
        GetComponent<RawImage>().texture = Resources.Load<Texture2D>("Stage1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
