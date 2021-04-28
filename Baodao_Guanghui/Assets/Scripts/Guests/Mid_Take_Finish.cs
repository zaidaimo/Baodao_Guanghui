using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mid_Take_Finish : MonoBehaviour
{
    //public float DestroyTime;
    int time_int = 2;//宣告倒數的時間 (time_int )為整數( int) 5。
    
    
    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject, DestroyTime);
        InvokeRepeating("timer", 1, 1);
        //一秒後，每秒重複呼叫timer函式。(開始倒數計時)。
        //InokeRepeating 重複呼叫(“函式名”，第一次間隔幾秒呼叫，每幾秒呼叫一次)。
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void timer()
    {
        time_int -= 1;//每次呼叫倒數的時間就扣1。

        if (time_int == 0)//如果倒數時間為0 (也就是時間到!)
        {
            CancelInvoke("timer");
            //取消重複呼叫timer函式。(停止倒數計時)
            //CancelInvoke取消重複呼叫(“函式名”)。
            gameObject.SetActive(false);
        }
    }
}
