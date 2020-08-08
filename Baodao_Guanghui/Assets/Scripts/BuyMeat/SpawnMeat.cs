using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnMeat : MonoBehaviour
{
    public Transform[] SpawnPoints;  //生成一個座標的陣列
    public float spawnTime = 2f;  //兩秒生成一次蔬菜
    public GameObject[] Meats;
    
    public int Ran_Num1;  //隨機產生要購買的數量
    public Text Ran_Num_T1;  //隨機產生要購買的 字串
    public int Ran_Num2;  
    public Text Ran_Num_T2;  
    public int Ran_Num3;  
    public Text Ran_Num_T3;  





    private void Start()
    {
        InvokeRepeating("SpawnMeats", spawnTime, spawnTime);  //反覆呼叫 (2秒生成,每2秒生成一次)
               
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

    void SpawnMeats()  //隨機位置 生成想要的物件
    {
        int spawnIndex = Random.Range(0, SpawnPoints.Length);  //擴充陣列時 隨機生成範圍改至與 重生點數量 相同
        int meatIndex = Random.Range(0, Meats.Length);
        Instantiate(Meats[meatIndex], SpawnPoints[spawnIndex].position, SpawnPoints[spawnIndex].rotation);
    }

    
}
