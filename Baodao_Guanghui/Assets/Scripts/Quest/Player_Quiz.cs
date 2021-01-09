using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Quiz : MonoBehaviour
{
    public static int Quiz_Total_Score;
    //public Text Quiz_Total_Score_T;

    public void Right_Quiz()
    {
        Money.PocketMoney = Money.PocketMoney + 100;
        //GetComponent<Text>().text = Money.PocketMoney.ToString();
    }
}
