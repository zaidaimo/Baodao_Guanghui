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
    //public GameObject bulb_konsingtsai;  //達到一定條件即可做菜
    //public GameObject bulb_diguayeah;
    //public GameObject bulb_kongbaogiding;
    #endregion
    
    public GameObject Left;
    public GameObject Right;
    public GameObject Left1;
    public GameObject Right1;
    public GameObject Meat_Lock;
    public GameObject Kitchen_Lock;
    public GameObject Meat_Teaching;
    public GameObject Meat_Start;
    void Update()
    {
        //Money.PocketMoney = Money.PocketMoney + Player.Meat_Total_Score + Player_Quiz.Quiz_Total_Score + simp_.Simple_Guest_Total_Score;
        BuyMeat();
        Note_Meat();
        Tsaibonun();
    }
    public void BuyMeat()  //解鎖買肉
    {
        if (Money.PocketMoney == 21500)
        {
            bulb_BuyMeat.SetActive(true);
            bulb_tsaibonun.SetActive(false);
            //Left.SetActive(true);
            //Right.SetActive(false);
            //Left1.SetActive(false);
            //Right1.SetActive(true);
           // Meat_Lock.SetActive(false);
           // Kitchen_Lock.SetActive(true);
           // Meat_Teaching.SetActive(true);
            //Meat_Start.SetActive(true);


        }
        else if (Money.PocketMoney > 21500)
        {
            //bulb_BuyMeat.SetActive(false);
            
        }

    }

    public void Note_Meat()  //普通客人
    {
        if (Money.PocketMoney >= 22000)
        {

            //Simp.SetActive(false);
            Destroy(Simp);
            Mid.SetActive(true);
            //Left.SetActive(true);
            //Right.SetActive(false);
            //Left1.SetActive(false);
            //Right1.SetActive(true);
            //Meat_Lock.SetActive(false);
            //Kitchen_Lock.SetActive(true);
        }
        else
        {
            //bulb_BuyMeat.SetActive(false);
        }

    }
    public void Tsaibonun()  //菜圃但
    {
        if (Money.PocketMoney > 22500)
        {
            bulb_tsaibonun.SetActive(true);
            Simp.SetActive(false);
            Mid.SetActive(true);
            //Left.SetActive(true);
            //Right.SetActive(true);
            //Left1.SetActive(true);
            //Right1.SetActive(true);
            //Meat_Lock.SetActive(false);
            //Kitchen_Lock.SetActive(false);
        }
        else
        {
            //bulb_tsaibonun.SetActive(false);
        }

    }
    public void Kongsingtsai()  //空心菜
    {
        if (Money.PocketMoney >= 50000)
        {
            //bulb_konsingtsai.SetActive(true);
        }
        else
        {
            //bulb_konsingtsai.SetActive(false);
        }

    }

    public void Diguayeah()  //地瓜葉
    {
        if (Money.PocketMoney >= 100000)
        {
           // bulb_diguayeah.SetActive(true);
        }
        else
        {
            //bulb_diguayeah.SetActive(false);
        }

    }

    public void Kongbaogiding()  //宮保雞丁
    {
        if (Money.PocketMoney >= 200000)
        {
            //bulb_kongbaogiding.SetActive(true);
        }
        else
        {
            //bulb_kongbaogiding.SetActive(false);
        }

    }


    
}
