using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    #region 隨機產生需購買的數量 將需購買數量的 顯示轉為 字串
    public int Ran_Num1;  //隨機產生需購買的數量
    public Text Ran_Num_T1;  //將需購買數量的 顯示轉為 字串
    public int Ran_Num2;
    public Text Ran_Num_T2;
    public int Ran_Num3;
    public Text Ran_Num_T3;
    #endregion

    #region 玩家接到的數量 將玩家接到的數量 顯示轉為 字串
    public int Player_Get1;  //玩家接到的數量
    public Text Player_Get_T1;  //將玩家接到的數量 顯示轉為 字串
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

    #region 玩家左右控制
    public GameObject Right_Btn;
    public GameObject Left_Btn;
    public float MoveSpeed;
    #endregion

    public Meat_Base camera_touch;  //遊戲結束時無法再點擊畫面
    public SpawnMeat[] Drop;  //陣列
    public Button Right, Left;

    #region 分數計算
    public GameObject Note;
    public int Right_Meat; //接對數量
    public Text Right_Meat_T;
    public int Right_Meat_Score; //接對總數
    public Text Right_Meat_Score_T;

    public int Wrong_Meat; //接錯數量
    public Text Wrong_Meat_T;
    public int Wrong_Meat_Score; //接錯總數
    public Text Wrong_Meat_Score_T;

    public static int Meat_Total_Score;
    public Text Meat_Total_Score_T;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        HowMany_Buy();
        Player_Get1 = 0;  //玩家起始接到的數量為0
        Player_Get2 = 0;
        Player_Get3 = 0;
        Player_Wrong = 0;
        for (int a = 0; a < Drop.Length; a++)
        {
            Drop[a].StartDrop();  //呼叫StartDrop()功能

        }

        //camera_touch.isGame = true;  //遊戲開始時 可點擊畫面
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

    #region 控制左右
    void Update()
    {
        LongPress_Right_Ctrl();
        LongPress_Left_Ctrl();
    }

    public void LongPress_Right_Ctrl()
    {
        if (Input.GetButtonDown("Jump"))  // * Time.deltaTime
        {
            transform.Translate(new Vector2(2, 0));
        }
    }

    public void LongPress_Left_Ctrl()
    {
        if (Input.GetButtonDown("Jump"))
        {
            transform.Translate(new Vector2(-2, 0) );
        }
    }
    #endregion

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Dried squid" )  //如果接到的物件是魷魚 && isGame == true
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
        if (collision.gameObject.tag == "Beef")  //如果接到的物件是牛肉 
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
        if (collision.gameObject.tag == "Pork ribs")  //如果接到的物件是豬排
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
        else if(collision.gameObject.tag == "Others")  //如果接到的物件是其他肉
        {
            print("接錯的肉加1");
            GetAdd(0, 0, 0, 1);
        }
    }

    public void GetAdd(int Get_Add1, int Get_Add2, int Get_Add3,int Get_Wrong)  //每接到一個肉+1
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

        if (Ran_Num1 == Player_Get1 && Ran_Num2 == Player_Get2 && Ran_Num3 == Player_Get3)
        {
            /*for (int a = 0; a < Drop.Length; a++)  //結束遊戲時將肉取消顯示
            {
                Drop[a].isGame = false;
            }*/
            Right.GetComponent<Button>().enabled = false;
            Left.GetComponent<Button>().enabled = false;
            SpawnMeat.isGame = false;
            Note.SetActive(true);
        }
        FinishScore();
    }
    #region 分數計算 獲得零用錢數 = 基本零用錢100 + (接對的數量X*倍率) - (接錯的數量Y*倍率)    
    public void FinishScore()  //分數
    {
        Right_Meat = Player_Get1 + Player_Get2 + Player_Get3; //全部接隊的肉相加
        Right_Meat_T.text = Right_Meat.ToString();

        Right_Meat_Score = Right_Meat * 10;
        Right_Meat_Score_T.text = Right_Meat_Score.ToString();

        Wrong_Meat = Player_Wrong;
        Wrong_Meat_T.text = Wrong_Meat.ToString();

        Wrong_Meat_Score = Wrong_Meat * -5;
        Wrong_Meat_Score_T.text = Wrong_Meat_Score.ToString();

        Meat_Total_Score = 100 + (Right_Meat * 10) - (Wrong_Meat * 5);  //獲得零用錢數 = 基本零用錢100 + (接對的數量X*倍率) - (接錯的數量Y*倍率)
        Meat_Total_Score_T.text = Meat_Total_Score.ToString();  //總分轉為字串顯示
    }
    #endregion
}





