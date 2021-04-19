using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simp_Tsai_print : MonoBehaviour
{
    public float DestroyTime=5;
    public GameObject Tsai_Take_Dish;
    public GameObject Money1;
    private void Start()
    {
        //Destroy(gameObject, DestroyTime);
    }


    private void OnMouseDown()
    {
        //PressGetMoney();
        Destroy(gameObject);
        Tsai_Take_Dish.SetActive(true);
        Money1.SetActive(true);
    }
    
}
