using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Type_Writer_Effect2 : MonoBehaviour
{
    Text showText;  //接收Text組件
    string showStr;  //設置文字訊息

    public GameObject Next_Page2;
    private void Start()
    {
        showText = GetComponent<Text>(); //偵測想要的文字
        showStr = "開店的東西好像都準備得差不多了，但這是我第一次跟爸爸回去，所以也不太清楚會是個什麼樣的地方。";  //想要的文字

        StartCoroutine(TypeText());  //開啟TypeText()

        Next_Page2.SetActive(true);
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
