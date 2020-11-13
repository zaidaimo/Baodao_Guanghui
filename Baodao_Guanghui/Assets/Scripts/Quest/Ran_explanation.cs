using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ran_explanation : MonoBehaviour
{
    //public GameObject Quest;
    //public float DestroyTime;
    public float spawnTime = 1; //只需花10秒生成

    public Transform[] explanationPoints;  //生成一個座標的陣列
    public GameObject[] explanation;
    public GameObject gintanhow;

    public static bool isGame;
    private void Start()
    {
        isGame = true;
        if (isGame == true)
        {
            InvokeRepeating("RanExplanation", spawnTime, 100);  //反覆呼叫 (1秒生成,每300秒生成一次)
        }
    }

    private void Update()
    {
        if (isGame == false)
        {
            CancelInvoke();
        }
    }
    public void StartCount()
    {
        InvokeRepeating("RanExplanation", spawnTime, 100);  //反覆呼叫 (1秒生成,每1秒生成一次)

    }

    void RanExplanation()  //隨機位置 生成想要的物件
    {
        if (isGame == true)
        {
            int questIndex = Random.Range(0, explanationPoints.Length);  //擴充陣列時 隨機生成範圍改至與 重生點數量 相同
            int explanationIndex = Random.Range(0, explanation.Length);
            Instantiate(explanation[explanationIndex], explanationPoints[questIndex].position, explanationPoints[questIndex].rotation);
        }

    }
}
