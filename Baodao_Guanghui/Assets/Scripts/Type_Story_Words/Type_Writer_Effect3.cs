using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Type_Writer_Effect3 : MonoBehaviour
{
    Text showText;  //接收Text組件
    string showStr;  //設置文字訊息

    public GameObject Next_Page3;
    private void Start()
    {
        showText = GetComponent<Text>(); //偵測想要的文字
        showStr = "車子停在了一間店面前，大門的上方有一塊看似招牌的東西掛著一條紅布。「到了。」爸爸說。";  //想要的文字

        StartCoroutine(TypeText());  //開啟TypeText()

        Next_Page3.SetActive(true);
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
