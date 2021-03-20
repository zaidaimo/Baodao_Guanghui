using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class simp_ : MonoBehaviour
{
    public static int Simple_Guest_Total_Score;
    public float DestroyTime;
    private void Start()
    { 
        Destroy(gameObject, DestroyTime);
    }

    
    private void OnMouseDown()
    {
        PressGetMoney();
        Destroy(gameObject);
    }

    private void PressGetMoney()
    {
        Money.PocketMoney = Money.PocketMoney + 100;
        //GetComponent<Text>().text = Money.PocketMoney.ToString();
    }

}
