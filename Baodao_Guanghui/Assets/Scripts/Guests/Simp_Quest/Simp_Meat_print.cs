﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simp_Meat_print : MonoBehaviour
{
    public float DestroyTime=5;
    public GameObject Meat_Take_Dish;
    private void Start()
    {
        //Destroy(gameObject, DestroyTime);
    }


    private void OnMouseDown()
    {
        //PressGetMoney();
        Destroy(gameObject);
        Meat_Take_Dish.SetActive(true);
    }
    
}