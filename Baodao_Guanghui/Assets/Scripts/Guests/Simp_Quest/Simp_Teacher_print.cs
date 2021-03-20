using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simp_Teacher_print : MonoBehaviour
{
    public float DestroyTime;
    public GameObject Teacher_Take_Dish;
    private void Start()
    {
        Destroy(gameObject, DestroyTime);
    }


    private void OnMouseDown()
    {
        PressGetMoney();
        Destroy(gameObject);
        //Teacher_Take_Dish.SetActive(true);
    }
    private void PressGetMoney()
    {
        Money.PocketMoney = Money.PocketMoney + 100;
        //GetComponent<Text>().text = Money.PocketMoney.ToString();
    }
}
