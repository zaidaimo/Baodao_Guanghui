﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teacher_Guest : MonoBehaviour
{
    public GameObject Teacher_Quiz;

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
        Teacher_Quiz.SetActive(true);
        Destroy(gameObject);
        //Spawn_Guest3.isGame = false;

        Right.SetActive(false);
        Left.SetActive(false);
        Shop.SetActive(false);
        Picture.SetActive(false);
    }
}