using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simp_Gpai_print : MonoBehaviour
{
    public float DestroyTime;
    public GameObject Gpai_Take_Dish;
    private void Start()
    {
        Destroy(gameObject, DestroyTime);
    }


    private void OnMouseDown()
    {
        PressGetMoney();
        Destroy(gameObject);
        //Gpai_Take_Dish.SetActive(true);
    }

    private void PressGetMoney()
    {
        Money.PocketMoney = Money.PocketMoney + 100;
        //GetComponent<Text>().text = Money.PocketMoney.ToString();
    }
}
