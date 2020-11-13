using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ran_quest : MonoBehaviour
{
    public Transform[] QuestPoints;  //生成一個座標的陣列
    public GameObject[] Quest;

    public static bool isGame;

    private void Start()
    {
        isGame = true;
        if (isGame == true)
        {
            RanQuest();
        }
    }

    void RanQuest()  //隨機位置 生成想要的物件
    {
        if (isGame == true)
        {
            int questpointIndex = Random.Range(0, QuestPoints.Length);  //擴充陣列時 隨機生成範圍改至與 重生點數量 相同
            int questIndex = Random.Range(0, Quest.Length);
            Instantiate(Quest[questIndex], QuestPoints[questpointIndex].position, QuestPoints[questpointIndex].rotation);
        }

    }
}
