using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mein_Bao_Guest : MonoBehaviour
{
    public GameObject Mein_Bao_Quiz;

    public float DestroyTime;

    public GameObject Right;
    public GameObject Left;
    public GameObject Shop;
    public GameObject Picture;

    public static bool isGame;  //是否正在進行遊戲

    private void Start()
    {
        print("遊戲開始");
        //Destroy(gameObject, DestroyTime);
    }
    private void OnMouseDown()
    {
        Mein_Bao_Quiz.SetActive(true);
        Destroy(gameObject);
        //Spawn_Guest2.isGame = false;

        Right.SetActive(false);
        Left.SetActive(false);
        Shop.SetActive(false);
        Picture.SetActive(false);
    }
}
