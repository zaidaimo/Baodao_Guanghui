using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meat_Base : MonoBehaviour
{
    public Rigidbody2D Meat_rig = null;  //給肉鋼體
    public float DestroyTime;
     
    public Player script;
    public bool isGame;  //是否正在進行遊戲

    private void Start()
    {
        print("遊戲開始");
        Destroy(gameObject, DestroyTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Box" && isGame == true)  //如果肉碰到的物件是箱子 && isGame == true
        {
            
            Destroy(gameObject);
            Debug.Log("肉銷毀");

        }
    }

   

}
