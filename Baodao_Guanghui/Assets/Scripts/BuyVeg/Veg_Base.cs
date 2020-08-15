using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Veg_Base : MonoBehaviour
{
    public Rigidbody2D Veg_rig = null;  //給肉鋼體
    
    public bool isGame;

    private void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Box")  //如果肉碰到的物件是箱子
        {
            Destroy(gameObject);
            Debug.Log("菜銷毀");

        }
    }
}
