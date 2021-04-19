using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simp_Teacher_print : MonoBehaviour
{
    public float DestroyTime=5;
    public GameObject Teacher_Take_Dish;
    public GameObject Money4;
    private void Start()
    {
        //Destroy(gameObject, DestroyTime);
    }


    private void OnMouseDown()
    {
        //PressGetMoney();
        Destroy(gameObject);
        Teacher_Take_Dish.SetActive(true);
        Money4.SetActive(true);
    }
    
}
