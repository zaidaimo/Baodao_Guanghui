using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public int PocketMoney=0;
    public Text PocketMoney_T;
    public int Meat_Total_Score;
    
    // Start is called before the first frame update
    void Start()
    {
        //重新上船不要管這行
        Buy_Meat_Money();
    }
    private void Update()
    {
        
    }
    void Buy_Meat_Money()  //接完肉 要增加的零用錢
    {
        Meat_Total_Score = Meat_Total_Score + Player.Meat_Total_Score;
        PocketMoney = PocketMoney + Meat_Total_Score;
        PocketMoney_T.text = PocketMoney.ToString();
    }
}