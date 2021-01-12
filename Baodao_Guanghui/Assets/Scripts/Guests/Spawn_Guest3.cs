using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Guest3: MonoBehaviour
{
    public Transform[] SpawnPoints;  //生成一個座標的陣列
    public float spawnTime =0.01f;  //10秒生成一塊肉
    public GameObject[] Guests;
    
    public Do_Hua_Guest script;
    public static bool isGame;  //是否正在進行遊戲

    private void Start()
    {
        isGame = true;
        if (isGame == true)
        {
            InvokeRepeating("CreateGuests", spawnTime, 20);  //反覆呼叫 (1秒生成,每1秒生成一次)
        }
    }

    private void Update()
    {
        if (isGame == false)
        {
            CancelInvoke();
        }
    }
    public void StartDrop()
    {
        InvokeRepeating("CreateGuests", spawnTime, 50);  //反覆呼叫 (1秒生成,每1秒生成一次)

    }

    void CreateGuests()  //隨機位置 生成想要的物件
    {
        if (isGame == true)
        {
            int spawnIndex = Random.Range(0, SpawnPoints.Length);  //擴充陣列時 隨機生成範圍改至與 重生點數量 相同
            int guestIndex = Random.Range(0, Guests.Length);
            Instantiate(Guests[guestIndex], SpawnPoints[spawnIndex].position, SpawnPoints[spawnIndex].rotation);
        }

    }


}

