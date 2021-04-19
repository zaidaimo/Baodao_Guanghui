using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simp_Part_print : MonoBehaviour
{
    public float DestroyTime=5;
    public GameObject Part_Take_Dish;
    public GameObject Money3;
    private void Start()
    {
        //Destroy(gameObject, DestroyTime);
    }


    private void OnMouseDown()
    {
        //PressGetMoney();
        Destroy(gameObject);
        Part_Take_Dish.SetActive(true);
        Money3.SetActive(true);
    }

    
}
