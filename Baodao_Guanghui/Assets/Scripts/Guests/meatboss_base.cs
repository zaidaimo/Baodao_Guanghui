using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meatboss_base : MonoBehaviour
{
    public Rigidbody2D Guest_rig = null;  //給肉鋼體
    public float DestroyTime;

    public GameObject meatboss_say;
    //public Player script;
    public bool isGame;  //是否正在進行遊戲

    private void Start()
    {
        print("遊戲開始");
        Destroy(gameObject, DestroyTime);
    }

    private void OnMouseDown()
    {
        meatboss_say.SetActive(true);

        
    }
}
