using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box_Ctrl : MonoBehaviour
{
    public int veg_ScoreValue=0;  //原始分數
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void AddScore(int add)  //加分機制
    {
        veg_ScoreValue += add;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += new Vector3(-50, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += new Vector3(50, 0, 0) * Time.deltaTime;
        }
    }
}
