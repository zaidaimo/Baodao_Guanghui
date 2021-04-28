using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money_Range : MonoBehaviour
{
    #region 達到一定條件即可做菜
    public GameObject bulb_BuyMeat;
    public GameObject bulb_tsaibonun;
    
    public GameObject Simp;
    public GameObject Mid;
    public GameObject Simp_Guest;
    public GameObject Mid_Guest;

    public GameObject Meat_Lock;
    public GameObject Kitchen_Lock;
    public GameObject Meat_Lock_Start;
    public GameObject Kitchen_Lock_Start;
    public GameObject Point_prompt;
    #endregion

    //public GameObject Left;
    //public GameObject Right;
    //public GameObject Left1;
    //public GameObject Right1;

    void Update()
    {
        //Money.PocketMoney = Money.PocketMoney + Player.Meat_Total_Score + Player_Quiz.Quiz_Total_Score + simp_.Simple_Guest_Total_Score;
        BuyMeat();
        Note_Meat();
        Tsaibonun();
        No_Tsaibonun();
        Point();
    }

    public void Point()  //解鎖買肉
    {
        if (Money.PocketMoney >= 1)
        {
            Point_prompt.SetActive(false);
        }
       
    }
    public void BuyMeat()  //解鎖買肉
    {
        if (Money.PocketMoney == 1200)
        {
            bulb_BuyMeat.SetActive(true);
            
        }
        else if (Money.PocketMoney >= 1200)
        {
            Meat_Lock.SetActive(false);
            Kitchen_Lock.SetActive(true);
            Meat_Lock_Start.SetActive(true);
            Kitchen_Lock_Start.SetActive(false);
        }

    }

    public void Note_Meat()  //普通客人
    {
        if (Money.PocketMoney >= 2000)
        {

            //Simp.SetActive(false);
            Mid.SetActive(true);
            //Simp_Guest.SetActive(false);
            Mid_Guest.SetActive(true);
        }
        
    }
    public void Tsaibonun()  //菜圃但
    {
        if (Money.PocketMoney >= 2800 && Money.PocketMoney < 3100)
        {
            bulb_tsaibonun.SetActive(true);
            Meat_Lock.SetActive(false);
            Kitchen_Lock.SetActive(false);
            Meat_Lock_Start.SetActive(true);
            Kitchen_Lock_Start.SetActive(true);
        }
       
    }

    public void No_Tsaibonun()  //菜圃但
    {
        if (Money.PocketMoney >= 30000)
        {
            bulb_tsaibonun.SetActive(false);
            Meat_Lock.SetActive(false);
            Kitchen_Lock.SetActive(false);
            Meat_Lock_Start.SetActive(true);
            Kitchen_Lock_Start.SetActive(true);


            //Simp.SetActive(false);
            Mid.SetActive(true);
            //Simp_Guest.SetActive(false);
            Mid_Guest.SetActive(true);
        }

    }

}
