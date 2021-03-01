using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tsai_Pu_Dan_Zoom7 : MonoBehaviour
{
    // 抖動目標的transform(若未添加引用，怎默認為當前物體的transform)
    public Transform sc7;

    //持續抖動的時長
    public float shake = 1f;

    // 抖動幅度（振幅）
    //振幅越大抖動越厲害
    public float shakeAmount = 0.7f;
    public float decreaseFactor = 2.0f;

    Vector3 originalPos;

    void Awake()
    {
        if (sc7 == null)
        {
            sc7 = GetComponent(typeof(Transform)) as Transform;
        }
    }

    void OnEnable()
    {
        originalPos =sc7.localPosition;
    }

    void Update()
    {
        if (shake > 0)
        {
           sc7.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;

            shake -= Time.deltaTime * decreaseFactor;
        }
        else
        {
            shake = 0f;
            sc7.localPosition = originalPos;
        }
    }
}

