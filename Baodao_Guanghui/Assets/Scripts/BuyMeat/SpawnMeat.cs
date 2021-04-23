using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnMeat : MonoBehaviour
{
    public Transform[] SpawnPoints;  //生成一個座標的陣列
    public float spawnTime = 0.05f;  //1秒生成一塊肉
    public GameObject[] Meats;
    public Player script;
    public static bool isGame;  //是否正在進行遊戲

    private void Start()
    {
        isGame = false;
        if(isGame==true)
        {
            InvokeRepeating("CreateMeats", spawnTime, spawnTime);  //反覆呼叫 (1秒生成,每1秒生成一次)
        }
        Debug.Log("需點擊教學以開始遊戲");
    }
    public void Start_Playing()
    {
        isGame = true;
        if (isGame == true)
        {
            InvokeRepeating("CreateMeats", spawnTime, spawnTime);  //反覆呼叫 (1秒生成,每1秒生成一次)
        }
        Debug.Log("開始遊戲");
    }

    private void Update()
    {
        if(isGame==false)
        {
            CancelInvoke();
        }
    }
    public void StartDrop()
    {
        InvokeRepeating("CreateMeats", spawnTime, spawnTime);  //反覆呼叫 (1秒生成,每1秒生成一次)
        
    }

    void CreateMeats()  //隨機位置 生成想要的物件
    {
        if(isGame == true)
        {
            int spawnIndex = Random.Range(0, SpawnPoints.Length);  //擴充陣列時 隨機生成範圍改至與 重生點數量 相同
            int meatIndex = Random.Range(0, Meats.Length);
            Instantiate(Meats[meatIndex], SpawnPoints[spawnIndex].position, SpawnPoints[spawnIndex].rotation);
        }
        
    }

    
}
