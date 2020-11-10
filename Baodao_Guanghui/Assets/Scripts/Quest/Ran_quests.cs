using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ran_quests : MonoBehaviour
{
    //public GameObject Quest;
    //public float DestroyTime;
    public float spawnTime = 1; //只需花一秒生成

    public Transform[] QuestPoints;  //生成一個座標的陣列
    public GameObject[] Quest;

    public static bool isGame;
    private void Start()
    {
        isGame = true;
        if (isGame == true)
        {
            InvokeRepeating("RanQuestion", spawnTime, 1);  //反覆呼叫 (1秒生成,每300秒生成一次)
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
        InvokeRepeating("RanQuestion", spawnTime, spawnTime);  //反覆呼叫 (1秒生成,每1秒生成一次)

    }

    void RanQuestion()  //隨機位置 生成想要的物件
    {
        if (isGame == true)
        {
            int questIndex = Random.Range(0, QuestPoints.Length);  //擴充陣列時 隨機生成範圍改至與 重生點數量 相同
            int explanationIndex = Random.Range(0, Quest.Length);
            Instantiate(Quest[explanationIndex], QuestPoints[questIndex].position, QuestPoints[questIndex].rotation);
        }

    }
}
