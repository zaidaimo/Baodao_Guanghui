using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Print_Step0_Twice : MonoBehaviour
{
    public int Print_Step0;
    public GameObject step_words0;
   
    // Update is called once per frame
    void Update()
    {
        if (Print_Step0 == 1)//�ͩղĤ@����
        {
            step_words0.SetActive(false);
        }
        else if (Print_Step0 == 2)//�ͩղĤG����
        {
            step_words0.SetActive(true);
        }
    }

    public void OnMouseDown()
    {
        Print_Step0++;

    }
}
