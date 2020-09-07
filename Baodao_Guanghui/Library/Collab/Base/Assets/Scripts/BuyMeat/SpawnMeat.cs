using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnMeat : MonoBehaviour
{
    public Transform[] SpawnPoints;  //生成一個座標的陣列
    public float spawnTime = 1f;  //1秒生成一次蔬菜
    public GameObject[] Meats;

    //public bool isGame;  //是否正在進行遊戲


    private void Start()
    {
        InvokeRepeating("SpawnMeats", spawnTime, spawnTime);  //反覆呼叫 (1秒生成,每1秒生成一次)
        
    }

    void CreateMeats()  //隨機位置 生成想要的物件
    {
        
        int spawnIndex = Random.Range(0, SpawnPoints.Length);  //擴充陣列時 隨機生成範圍改至與 重生點數量 相同
        int meatIndex = Random.Range(0, Meats.Length);
        Instantiate(Meats[meatIndex], SpawnPoints[spawnIndex].position, SpawnPoints[spawnIndex].rotation);
       
        
    }

    
}
