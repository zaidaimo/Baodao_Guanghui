using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simp_Dohua_print : MonoBehaviour
{
    public float DestroyTime=5;
    public GameObject Do_Take_Dish;
    public GameObject Money5;
    private void Start()
    {
        //Destroy(gameObject, DestroyTime);
    }


    private void OnMouseDown()
    {
        //PressGetMoney();
        Destroy(gameObject);
        Do_Take_Dish.SetActive(true);
        Money5.SetActive(true);
    }
    
}
