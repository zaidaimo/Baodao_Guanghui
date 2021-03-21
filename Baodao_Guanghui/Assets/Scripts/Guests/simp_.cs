using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class simp_ : MonoBehaviour
{
    public static int Simple_Guest_Total_Score;
    public float DestroyTime=5;
    private void Start()
    { 
        Destroy(gameObject, DestroyTime);
    }

    
    public void OnMouseDown()
    {
        PressGetMoney();
        Destroy(gameObject);
    }

    public void PressGetMoney()
    {
        Money.PocketMoney = Money.PocketMoney + 100;
        //GetComponent<Text>().text = Money.PocketMoney.ToString();
    }

}
