using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnVeg : MonoBehaviour
{
    public Transform[] SpawnPoints;  //生成一個座標的陣列
    public float spawnTime = 1f;  //兩秒生成一次蔬菜
    public GameObject[] Vegs;
    public PressPlayer script;
    public static bool isGame;  //是否正在進行遊戲

    private void Start()
    {
        isGame = true;
        if (isGame == true)
        {
            InvokeRepeating("CreateVegs", spawnTime, spawnTime);  //反覆呼叫 (1秒生成,每1秒生成一次)
        }
    }
    private void Update()
    {
        if (isGame == false)
        {
            CancelInvoke();
        }
    }
    public void StartCreate()
    {
        InvokeRepeating("CreateVegs", spawnTime, spawnTime);  //反覆呼叫 (1秒生成,每1秒生成一次)

    }
    void CreateVegs()  //隨機位置 生成想要的物件
    {
        if (isGame == true)
        {
            int spawnIndex = Random.Range(0, SpawnPoints.Length);  //擴充陣列時 隨機生成範圍改至與 重生點數量 相同
            int vegIndex = Random.Range(0, Vegs.Length);
            Instantiate(Vegs[vegIndex], SpawnPoints[spawnIndex].position, SpawnPoints[spawnIndex].rotation);
        }
    }

    
}
