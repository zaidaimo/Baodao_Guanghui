using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest01 : MonoBehaviour
{
    public bool isAnswer = false;
    public static int Add_Quiz_Score=100;

    private void OnMouseDown()
    {
        if (isAnswer)//選正確答案
        {
            //gameObject.Find("Answer").GetComponent<TextMesh>().text="正確";
            //Add_Quiz_Score;
        }
        else //選錯誤答案
        {

        }
    }
}
