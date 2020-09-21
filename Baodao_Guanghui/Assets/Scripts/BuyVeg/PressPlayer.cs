using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PressPlayer : MonoBehaviour
{
    #region 隨機產生需拔菜的數量 將需拔菜數量的 顯示轉為 字串
    public int Ran_Num1;  //隨機產生要購買的數量
    public Text Ran_Num_T1;  //隨機產生要購買的數量轉為 字串 顯示
    public int Ran_Num2;
    public Text Ran_Num_T2;
    public int Ran_Num3;
    public Text Ran_Num_T3;
    #endregion
    
    #region 玩家接到的數量 將玩家拔到的數量 顯示轉為 字串
    public int Player_Get1;  //玩家拿到幾個肉
    public Text Player_Get_T1;  //家玩家拿到的數量轉為 字串 顯示
    public int Player_Get2;
    public Text Player_Get_T2;
    public int Player_Get3;
    public Text Player_Get_T3;
    public int Player_Wrong;
    public Text Player_Wrong_T;
    #endregion
    
    #region 項目完成後 顯示勾勾
    public GameObject Check1; //一號項目完成後 顯示勾勾
    public GameObject Check2;
    public GameObject Check3;
    #endregion

    public Veg_Base camera_touch;  //遊戲結束時無法再點擊畫面
    public SpawnVeg[] Create;  //陣列
    public int Nowtime;  //顯示時間剩幾秒
    public Text Nowtime_T;

    #region 分數計算
    public GameObject Note;
    public int Right_Veg; //接對數量
    public Text Right_Veg_T;
    public int Right_Veg_Score; //接對總數
    public Text Right_Veg_Score_T;

    public int Wrong_Veg; //接錯數量
    public Text Wrong_Veg_T;
    public int Wrong_Veg_Score; //接錯總數
    public Text Wrong_Veg_Score_T;

    public int Total_Score;
    public Text Total_Score_T;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        HowMany_Buy();
        Player_Get1 = 0;  //玩家起始接到的數量為0
        Player_Get2 = 0;
        Player_Get3 = 0;
        Player_Wrong = 0;
        for (int a = 0; a < Create.Length; a++)
        {
            Create[a].StartCreate();  //呼叫StartCreate()功能

        }
        Nowtime = 60;  //開始時間定義為60秒
        Nowtime_T.text = Nowtime.ToString();  //顯示時間剩幾秒
        Invoke("GameCountDown", 1.0f);  //每一秒呼叫一次 GameCountDown()

    }
    #region 過關條件
    void HowMany_Buy()  //過關條件
    {
        Ran_Num1 = Random.Range(1, 4);  //產生要購買的數量1~3
        Ran_Num_T1.text = Ran_Num1.ToString();  //將數字轉為字串顯示
        Ran_Num2 = Random.Range(1, 4);
        Ran_Num_T2.text = Ran_Num2.ToString();
        Ran_Num3 = Random.Range(1, 4);
        Ran_Num_T3.text = Ran_Num3.ToString();
    }
    #endregion

    public void GameCountDown()  //開始倒數計時
    {
        Nowtime--;  //從60秒開始遞減
        Nowtime_T.text = Nowtime.ToString();  //顯示時間剩幾秒
        if (Nowtime == 0)  //時間到0秒時,遊戲結束
        {
            print("End Game");
            EndGame();
        }
        else
        {   //時間不為0秒時,跳下一次的遞減
            Invoke("GameCountDown", 1.0f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Sweet potato leaves")  //如果接到的物件是魷魚 && isGame == true
        {
            if (Player_Get1 < Ran_Num1)
            {
                print("項目一的肉加1");
                GetAdd(1, 0, 0, 0);
                Debug.Log("項目一的肉銷毀");

            }
            else
            {
                GetAdd(0, 0, 0, 1); //多接錯的肉+1
                Player_Get1 = Ran_Num1; //數值維持不變
            }
        }
        if (collision.gameObject.tag == "Water spinach")  //如果接到的物件是牛肉 
        {
            if (Player_Get2 < Ran_Num2)
            {
                print("項目二的肉加1");
                GetAdd(0, 1, 0, 0);
                Debug.Log("項目二的肉銷毀");
            }
            else
            {
                GetAdd(0, 0, 0, 1); //多接錯的肉+1
                Player_Get2 = Ran_Num2; //數值維持不變
            }

        }
        if (collision.gameObject.tag == "Shallots")  //如果接到的物件是豬排
        {
            if (Player_Get3 < Ran_Num3)
            {
                print("項目三的肉加1");
                GetAdd(0, 0, 1, 0);
                Debug.Log("項目三的肉銷毀");
            }
            else
            {
                GetAdd(0, 0, 0, 1); //多接錯的肉+1
                Player_Get3 = Ran_Num3; //數值維持不變
            }

        }
        else if (collision.gameObject.tag == "Others2")  //如果接到的物件是其他肉
        {
            print("接錯的肉加1");
            GetAdd(0, 0, 0, 1);
        }
    }
    public void GetAdd(int Get_Add1, int Get_Add2, int Get_Add3, int Get_Wrong)  //每接到一個肉+1
    {
        Player_Get1 += Get_Add1;  //每接到項目一的肉+1
        Player_Get_T1.text = Player_Get1.ToString();  //將每接到項目一的肉 轉為字串顯示
        if (Ran_Num1 == Player_Get1)  //項目一達到目標後 打勾
        {
            Debug.Log("已完成項目一");
            Check1.SetActive(true);
        }

        Player_Get2 += Get_Add2;
        Player_Get_T2.text = Player_Get2.ToString();
        if (Ran_Num2 == Player_Get2)
        {
            Debug.Log("已完成項目二");
            Check2.SetActive(true);
        }

        Player_Get3 += Get_Add3;
        Player_Get_T3.text = Player_Get3.ToString();
        if (Ran_Num3 == Player_Get3)
        {
            Debug.Log("已完成項目三");
            Check3.SetActive(true);
        }

        Player_Wrong += Get_Wrong;  //接錯的肉+1
        Player_Wrong_T.text = Player_Wrong.ToString();  //將接錯的肉 轉為字串顯示

        EndGame();
    }

    public void EndGame()
    {
        if (Ran_Num1 == Player_Get1 && Ran_Num2 == Player_Get2 && Ran_Num3 == Player_Get3)
        {
            /*for (int a = 0; a < Drop.Length; a++)  //結束遊戲時將肉取消顯示
            {
                Drop[a].isGame = false;
            }*/

            SpawnVeg.isGame = false;
            Note.SetActive(true);
        }
        FinishScore();
    }
    #region 分數計算 獲得零用錢數 = 基本零用錢100 + (拔對的數量X*倍率) - (拔錯的數量Y*倍率)
    public void FinishScore()  //分數
    {
        Right_Veg = Player_Get1 + Player_Get2 + Player_Get3; //全部接隊的肉相加
        Right_Veg_T.text = Right_Veg.ToString();

        Right_Veg_Score = Right_Veg * 10;
        Right_Veg_Score_T.text = Right_Veg_Score.ToString();

        Wrong_Veg = Player_Wrong;
        Wrong_Veg_T.text = Wrong_Veg.ToString();

        Wrong_Veg_Score = Wrong_Veg * -5;
        Wrong_Veg_Score_T.text = Wrong_Veg_Score.ToString();

        Total_Score = 100 + (Right_Veg * 10) - (Wrong_Veg * 5);  //獲得零用錢數 = 基本零用錢100 + (接對的數量X*倍率) - (接錯的數量Y*倍率)
        Total_Score_T.text = Total_Score.ToString();  //總分轉為字串顯示
    }
    #endregion
}
