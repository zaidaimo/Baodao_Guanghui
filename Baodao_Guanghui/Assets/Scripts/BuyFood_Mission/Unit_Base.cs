using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unit_Base : MonoBehaviour
{
    public Rigidbody2D Vegetable_rig = null;  //給蔬菜鋼體
    //public int veg_ScoreBase = 10;  //分數的基礎值
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Box")  //如果蔬菜碰到的物件是箱子
        {
            Destroy(gameObject);
            Debug.Log("銷毀");
           
        }
    }
   

}
