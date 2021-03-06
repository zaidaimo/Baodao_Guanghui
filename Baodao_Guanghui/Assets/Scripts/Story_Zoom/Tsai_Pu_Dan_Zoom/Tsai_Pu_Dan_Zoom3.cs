﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tsai_Pu_Dan_Zoom3 : MonoBehaviour
{
    Vector2 targetPosition = new Vector2(250,290);   // 目標位置
    Vector2 currentVelocity = Vector2.zero;     // 當前速度，這個值由你每次呼叫這個函式時被修改
    float maxSpeed = 300f;    // 選擇允許你限制的最大速度
    float smoothTime = 0.3f;      // 達到目標大約花費的時間。 一個較小的值將更快達到目標。

    void Update()
    {
        transform.position = Vector2.SmoothDamp(transform.position, targetPosition, ref currentVelocity, smoothTime, maxSpeed);

    }
}