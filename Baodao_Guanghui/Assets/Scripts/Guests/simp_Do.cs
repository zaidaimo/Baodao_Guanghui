using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class simp_Do : MonoBehaviour
{
    public static int Simple_Guest_Total_Score;
    public float DestroyTime;
    public GameObject Do_Take_Dish;
    private void Start()
    { 
        Destroy(gameObject, DestroyTime);
    }

    
    private void OnMouseDown()
    {
        //PressGetMoney();
        Destroy(gameObject);
        Do_Take_Dish.SetActive(true);
    }

    private void PressGetMoney()
    {
        Money.PocketMoney = Money.PocketMoney + 100;
        //GetComponent<Text>().text = Money.PocketMoney.ToString();
    }

}
