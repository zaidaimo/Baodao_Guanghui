using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Hint : MonoBehaviour
{
    public GameObject Hint_Button;
    public GameObject[] NPCHints;
    public float spawnTime = 10f;  //60秒生成一次對話
    // Start is called before the first frame update
    void Start()
    {
        Hint_Button_Load();
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    public void Hint_Button_Load ()
    {
        Hint_Button.SetActive(true);
        InvokeRepeating("Hint_Button", spawnTime, spawnTime);  //反覆呼叫 (60秒生成,每60秒生成一次)
    }
    public void Hints()  //隨機出現NPC提示
    {
        
        int hintIndex = Random.Range(0, NPCHints.Length);  //擴充陣列時 隨機生成範圍改至與 重生點數量 相同
        
    }
}
