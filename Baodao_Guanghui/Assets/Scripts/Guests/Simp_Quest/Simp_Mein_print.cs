using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simp_Mein_print : MonoBehaviour
{
    public float DestroyTime=5;
    public GameObject Mein_Take_Dish;
    private void Start()
    {
        //Destroy(gameObject, DestroyTime);
    }


    private void OnMouseDown()
    {
        //PressGetMoney();
        Destroy(gameObject);
        Mein_Take_Dish.SetActive(true);
    }
    
}
