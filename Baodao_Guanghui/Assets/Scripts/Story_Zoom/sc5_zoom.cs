using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc5_zoom : MonoBehaviour
{
    // 抖動目標的transform(若未添加引用，怎默認為當前物體的transform)
    public Transform sc5;

    //持續抖動的時長
    public float shake = 0f;

    // 抖動幅度（振幅）
    //振幅越大抖動越厲害
    public float shakeAmount = 0.7f;
    public float decreaseFactor = 1.0f;

    Vector3 originalPos;

    void Awake()
    {
        if (sc5 == null)
        {
            sc5 = GetComponent(typeof(Transform)) as Transform;
        }
    }

    void OnEnable()
    {
        originalPos =sc5.localPosition;
    }

    void Update()
    {
        if (shake > 0)
        {
           sc5.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;

            shake -= Time.deltaTime * decreaseFactor;
        }
        else
        {
            shake = 0f;
            sc5.localPosition = originalPos;
        }
    }
}

