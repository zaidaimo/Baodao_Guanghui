using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ro_Tan_Guest : MonoBehaviour
{
    public GameObject Ro_Tan_Quiz;

    public float DestroyTime;

    public GameObject Right;
    public GameObject Left;
    public GameObject Shop;
    public GameObject Picture;

    public static bool isGame;  //是否正在進行遊戲

    private void OnMouseDown()
    {
        Ro_Tan_Quiz.SetActive(true);
        Destroy(gameObject);
        //Spawn_Guest1.isGame = false;

        Right.SetActive(false);
        Left.SetActive(false);
        Shop.SetActive(false);
        Picture.SetActive(false);
    }
}
