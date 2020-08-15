using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnVeg : MonoBehaviour
{
    public Transform[] SpawnPoints;  //生成一個座標的陣列
    public float spawnTime = 2f;  //兩秒生成一次蔬菜
    public GameObject[] Vegs;
    
    public int Ran_Num1;  //隨機產生要購買的數量
    public Text Ran_Num_T1;  //隨機產生要購買的數量轉為 字串 顯示
    public int Ran_Num2;  
    public Text Ran_Num_T2;  
    public int Ran_Num3;  
    public Text Ran_Num_T3;

    public int Player_Get1;  //玩家拿到幾個肉
    public Text Player_Get_T1;  //家玩家拿到的數量轉為 字串 顯示
    public int Player_Get2;
    public Text Player_Get_T2;
    public int Player_Get3;
    public Text Player_Get_T3;


    private void Start()
    {
        InvokeRepeating("SpawnVegs", spawnTime, spawnTime);  //反覆呼叫 (2秒生成,每2秒生成一次)
        HowMany_Buy();
    }

    void HowMany_Buy()
    {
        Ran_Num1 = Random.Range(1, 7);  //產生要購買的數量1~6
        Ran_Num_T1.text = Ran_Num1.ToString();  //將數字轉為字串顯示
        Ran_Num2 = Random.Range(1, 7);  
        Ran_Num_T2.text = Ran_Num2.ToString();  
        Ran_Num3 = Random.Range(1, 7);  
        Ran_Num_T3.text = Ran_Num3.ToString();  
    }

    void SpawnVegs()  //隨機位置 生成想要的物件
    {
        int spawnIndex = Random.Range(0, SpawnPoints.Length);  //擴充陣列時 隨機生成範圍改至與 重生點數量 相同
        int vegIndex = Random.Range(0, Vegs.Length);
        Instantiate(Vegs[vegIndex], SpawnPoints[spawnIndex].position, SpawnPoints[spawnIndex].rotation);
    }

    
}
