using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guest_base : MonoBehaviour
{
    public Rigidbody2D Guest_rig = null;  //給肉鋼體
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
        if (isGame == true)  //如果肉碰到的物件是箱子 && isGame == true
        {

            Destroy(gameObject);
            Debug.Log("客人離開");

        }
    }
}
