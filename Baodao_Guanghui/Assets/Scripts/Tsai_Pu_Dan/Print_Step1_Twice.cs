using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Print_Step1_Twice : MonoBehaviour
{
    public int Print_Step1;
    public GameObject step_words1;
   
    // Update is called once per frame
    void Update()
    {
        if (Print_Step1 == 1)//�ͩղĤ@����
        {
            step_words1.SetActive(false);
        }
        else if (Print_Step1 == 2)//�ͩղĤG����
        {
            step_words1.SetActive(true);
        }
    }

    public void OnMouseDown()
    {
        Print_Step1++;

    }
}
