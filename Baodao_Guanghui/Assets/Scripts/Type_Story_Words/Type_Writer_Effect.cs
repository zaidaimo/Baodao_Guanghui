using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Type_Writer_Effect : MonoBehaviour
{
    Text showText;  //接收Text組件
    string showStr;  //設置文字訊息

    public GameObject Next_Page;

    private void Start()
    {
        showText = GetComponent<Text>(); //偵測想要的文字
        showStr = "我是小光，今年16歲。因為爸爸他一直想在故鄉開一間熱炒店，所以現在正在搬家的路上。";  //想要的文字

        StartCoroutine(TypeText());  //開啟TypeText()

        Next_Page.SetActive(true);
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
