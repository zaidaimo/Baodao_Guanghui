﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Type_Writer_Effect7 : MonoBehaviour
{
    Text showText;  //接收Text組件
    string showStr;  //設置文字訊息

    public GameObject Next_Page7;
    private void Start()
    {
        showText = GetComponent<Text>(); //偵測想要的文字
        showStr = "嗯，果然很有他的風格呢，這個店名……";  //想要的文字

        StartCoroutine(TypeText());  //開啟TypeText()

        Next_Page7.SetActive(true);
    }

    private IEnumerator TypeText()
    {
        foreach (var item in showStr.ToCharArray())  //轉為char的類型
        {
            showText.text += item;  //顯示文字
            yield return new WaitForSeconds(0.1f);
        }
    }
}
