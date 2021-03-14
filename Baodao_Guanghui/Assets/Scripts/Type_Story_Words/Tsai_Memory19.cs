using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tsai_Memory19 : MonoBehaviour
{
    Text showText;  //接收Text組件
    string showStr;  //設置文字訊息

    public GameObject Next_Page19;

    private void Start()
    {
        showText = GetComponent<Text>(); //偵測想要的文字
        showStr = "輝：當然啊！妳爸爸是誰？寶島光輝的大廚餒，怎麼可能失敗？";  //想要的文字

        StartCoroutine(TypeText());  //開啟TypeText()

        Next_Page19.SetActive(true);
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
