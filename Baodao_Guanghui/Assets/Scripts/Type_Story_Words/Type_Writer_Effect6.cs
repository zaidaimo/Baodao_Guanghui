using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Type_Writer_Effect6 : MonoBehaviour
{
    Text showText;  //接收Text組件
    string showStr;  //設置文字訊息

    public GameObject Next_Page6;
    private void Start()
    {
        showText = GetComponent<Text>(); //偵測想要的文字
        showStr = "拉開紅布「寶島光輝」四個大字出現在眼前「怎麼樣？看起來很有氣勢吧！我們的名字都在上面喔！」";  //想要的文字

        StartCoroutine(TypeText());  //開啟TypeText()

        Next_Page6.SetActive(true);
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
