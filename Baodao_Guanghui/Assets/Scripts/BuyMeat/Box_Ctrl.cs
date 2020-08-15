using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Box_Ctrl : MonoBehaviour
{
    
    public int Ran_Num1;  //隨機產生需購買的數量
    public Text Ran_Num_T1;  //將需購買數量的 顯示轉為 字串
    public int Ran_Num2;
    public Text Ran_Num_T2;
    public int Ran_Num3;
    public Text Ran_Num_T3;

    public int Player_Get1;  //玩家接到的數量
    public Text Player_Get_T1;  //將玩家接到的數量 顯示轉為 字串
    public int Player_Get2;
    public Text Player_Get_T2;
    public int Player_Get3;
    public Text Player_Get_T3;

    public GameObject Check1; //一號項目完成後 顯示勾勾
    public GameObject Check2;
    public GameObject Check3;

    public GameObject Right_Btn;
    public GameObject Left_Btn;

    public float Ping;
    private bool IsStart = false;
    private float LastTime = 0;


    // Start is called before the first frame update
    void Start()
    {
        HowMany_Buy();
        Player_Get1 = 0;  //玩家起始接到的數量為0
        Player_Get2 = 0;
        Player_Get3 = 0;
    }

    void HowMany_Buy()  //過關條件
    {
        Ran_Num1 = Random.Range(1, 5);  //產生要購買的數量1~4
        Ran_Num_T1.text = Ran_Num1.ToString();  //將數字轉為字串顯示
        Ran_Num2 = Random.Range(1, 5);
        Ran_Num_T2.text = Ran_Num2.ToString();
        Ran_Num3 = Random.Range(1, 5);
        Ran_Num_T3.text = Ran_Num3.ToString();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (IsStart && Ping > 0 && LastTime > 0 && Time.time - LastTime > Ping)
        {
            Debug.Log("長按觸發");
            IsStart = false;
            LastTime = 0;
        }

    }

    public void LongPress_Right_Ctrl(bool bStart)
    {
        IsStart = bStart;

        if (IsStart)
        {
            LastTime = Time.time;
            Debug.Log("長按開始");
            gameObject.transform.position += new Vector3(120f, 0, 0) * Time.deltaTime;
        }
        else if (LastTime != 0)
        {
            LastTime = 0;
            Debug.Log("長按取消");
        }


    }

    public void LongPress_Left_Ctrl(bool bStart)
    {
        IsStart = bStart;

        if (IsStart)
        {
            LastTime = Time.time;
            Debug.Log("長按開始");
            gameObject.transform.position += new Vector3(-120f, 0, 0) * Time.deltaTime;
        }
        else if (LastTime != 0)
        {
            LastTime = 0;
            Debug.Log("長按取消");
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Edge")  //如果人物碰到邊界
        { 
            Debug.Log("已碰觸界線");

        }
    }

    public void GetAdd(int Get_Add1, int Get_Add2, int Get_Add3)  //每接到一個肉+1
    {
        Player_Get1 += Get_Add1;  //每接到項目一的肉+1
        Player_Get_T1.text = Player_Get1.ToString();  //將每接到項目一的肉 轉為字串顯示
        Player_Get2 += Get_Add2;
        Player_Get_T2.text = Player_Get2.ToString();
        Player_Get3 += Get_Add3;
        Player_Get_T3.text = Player_Get3.ToString();
    }
    public void GetFinish()  //達到目標後 打勾
    {
        if (Ran_Num1 == Player_Get1)
        {
            Debug.Log("已完成項目一");
            Check1.SetActive(true);
        }
        if (Ran_Num2 == Player_Get2)
        {
            Debug.Log("已完成項目二");
            Check2.SetActive(true);
        }
        if (Ran_Num3 == Player_Get3)
        {
            Debug.Log("已完成項目三");
            Check3.SetActive(true);
        }
    }

}





