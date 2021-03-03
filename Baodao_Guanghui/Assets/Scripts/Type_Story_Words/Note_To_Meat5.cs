using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note_To_Meat5 : MonoBehaviour
{
    Text showText;  //接收Text組件
    string showStr;  //設置文字訊息

    public GameObject Next_Page5;

    private void Start()
    {
        showText = GetComponent<Text>(); //偵測想要的文字
        showStr = "輝：爸爸我啊，剛剛在倉庫點貨的時候發現肉好像快不夠用了所以可以拜託小光妳去市場幫我跑一趟補點貨進來嗎？多的錢給妳當零用錢！？";  //想要的文字

        StartCoroutine(TypeText());  //開啟TypeText()

        Next_Page5.SetActive(true);
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
