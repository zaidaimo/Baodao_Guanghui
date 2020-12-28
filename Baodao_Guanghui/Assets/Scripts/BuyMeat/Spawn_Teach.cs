using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Teach : MonoBehaviour
{
    //public Rigidbody2D Teach_rig = null;  //給肉鋼體
    public float DestroyTime;

    public GameObject HowToPlay;
    public GameObject Shop;
    public GameObject Picture;

    public GameObject Right1;

    //public Player script;
    //public bool isGame;  //是否正在進行遊戲

    private void Start()
    {
        print("遊戲開始");
        Destroy(gameObject, DestroyTime);
    }

    private void OnMouseDown()
    {
        HowToPlay.SetActive(true);
        Shop.SetActive(false);
        Picture.SetActive(false);

        Right1.SetActive(false);

    }
}
