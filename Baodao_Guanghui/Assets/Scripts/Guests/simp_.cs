using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class simp_ : MonoBehaviour
{
    public static int Simple_Guest_Total_Score;
    public float DestroyTime;
    private void Start()
    {
        print("遊戲開始");
        Destroy(gameObject, DestroyTime);
    }

    
    private void OnMouseDown()
    {
        Money.PocketMoney = Money.PocketMoney + 100;
        Destroy(gameObject);
    }
}
