using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish_Tsai_Add_Money : MonoBehaviour
{
    public static int Finish_Tsai_Score;
    //public Text Quiz_Total_Score_T;

    public void Finish_Tsai()
    {
        Money.PocketMoney = Money.PocketMoney + 30000;
        //GetComponent<Text>().text = Money.PocketMoney.ToString();
    }
}
