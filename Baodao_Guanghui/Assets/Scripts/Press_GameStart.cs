using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //使用Unity UI程式庫。

public class Press_GameStart : MonoBehaviour
{
    public Text Showtext;

    // Start is called before the first frame update
    void Start()
    {
        //InokeRepeating 重複呼叫(“函式名”，第一次間隔幾秒呼叫，每幾秒呼叫一次)。
        InvokeRepeating("showHide", 0, 0.5f);
    }

    void showHide()
    {
        if (Showtext.text == "") //如果 mytext內容是空的
        {
            Showtext.text = "點擊螢幕開始遊戲"; //將 mytext內容改變
        }
        else
        {
            Showtext.text = ""; //將 mytext內容改成空的
        }

    }
}
