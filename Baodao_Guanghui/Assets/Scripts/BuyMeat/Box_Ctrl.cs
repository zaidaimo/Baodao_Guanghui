using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Box_Ctrl : MonoBehaviour
{
    public int veg_ScoreValue=0;  //原始分數

    public GameObject Right_Btn;
    public GameObject Left_Btn;

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
        Right_Ctrl();
        Left_Ctrl();
    }

    public void Right_Ctrl()
    {
        if (Input.GetMouseButton(0))
        {
            gameObject.transform.position += new Vector3(0.3f, 0, 0);
        }
    }

    public void Left_Ctrl()
    {
        if (Input.GetMouseButton(0))
        {
            gameObject.transform.position += new Vector3(-0.3f, 0, 0);
        }
    }
}
