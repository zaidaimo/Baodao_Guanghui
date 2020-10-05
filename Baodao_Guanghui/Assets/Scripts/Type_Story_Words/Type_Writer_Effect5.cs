using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Type_Writer_Effect5 : MonoBehaviour
{
    Text showText;  //接收Text組件
    string showStr;  //設置文字訊息

    public GameObject Next_Page5;
    private void Start()
    {
        showText = GetComponent<Text>(); //偵測想要的文字
        showStr = "「我的夢想終於實現了！」爸爸看上去很開心，他從貨車上搬下梯子並爬了上去。";  //想要的文字

        StartCoroutine(TypeText());  //開啟TypeText()

        Next_Page5.SetActive(true);
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
