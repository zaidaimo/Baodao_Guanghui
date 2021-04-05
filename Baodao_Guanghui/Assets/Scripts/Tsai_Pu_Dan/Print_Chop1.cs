using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Print_Chop1 : MonoBehaviour
{
    public int Blend;//攪拌次數
    public GameObject Blending1;//攪拌圖一
    public GameObject Blending2;//攪拌圖二
    public GameObject Blending3;//攪拌圖三
    public GameObject Blend_Zoom;//詹版特寫區(1)
    public GameObject step6;
    public GameObject step6_5;

    public void Update()
    {
        Debug.Log("點了第" + (Blend + 1) + "下");
        if (Blend == 1)//攪拌第一次時
        {
            Blending1.SetActive(true);
        }
        else if (Blend == 2)//攪拌第二次時
        {
            Blending2.SetActive(true);
        }
        else if (Blend == 3)//攪拌第三次時
        {
            Blending3.SetActive(true);
            Blend_Zoom.SetActive(true);
            step6.SetActive(false);
            step6_5.SetActive(true);
        }
    }
    public void OnMouseDown()
    {
        Blend++;
        
    }
    
}
