using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc2_zoom : MonoBehaviour
{
    Vector2 targetScale = new Vector2(0.51f, 0.51f);   // 目標位置
    Vector2 currentVelocity = Vector2.zero;     // 當前速度，這個值由你每次呼叫這個函式時被修改
    float maxSpeed = 10f;    // 選擇允許你限制的最大速度
    float smoothTime = 2f;      // 達到目標大約花費的時間。 一個較小的值將更快達到目標。

    void Update()
    {
        transform.localScale = Vector2.SmoothDamp(transform.localScale, targetScale, ref currentVelocity, smoothTime, maxSpeed);
    }
}
