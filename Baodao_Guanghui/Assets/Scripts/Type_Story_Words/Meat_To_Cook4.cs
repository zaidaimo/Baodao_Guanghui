using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meat_To_Cook4 : MonoBehaviour
{
    Text showText;  //接收Text組件
    string showStr;  //設置文字訊息

    public GameObject Next_Page4;

    private void Start()
    {
        showText = GetComponent<Text>(); //偵測想要的文字
        showStr = "光：爸爸要教我做菜嗎！好啊！";  //想要的文字

        StartCoroutine(TypeText());  //開啟TypeText()

        Next_Page4.SetActive(true);
    }

    private IEnumerator TypeText()
    {
        foreach (var item in showStr.ToCharArray())  //轉為char的類型
        {
            showText.text += item;  //顯示文字
            yield return new WaitForSeconds(0.06f);
        }
    }
}
