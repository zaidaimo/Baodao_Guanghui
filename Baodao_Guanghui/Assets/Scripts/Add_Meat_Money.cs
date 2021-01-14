using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Add_Meat_Money : MonoBehaviour
{
    #region 第一頁 冰箱
    public GameObject origin_refri;
    public GameObject simp_refri;  //普通冰箱
    public GameObject adv_refri;  //進階冰箱
    public GameObject highlevel_refri;  //高階冰箱
    public GameObject simp_refri_Sure;
    public GameObject adv_refri_Sure;
    public GameObject highlevel_refri_Sure;

    public GameObject simp_refri_Buy_Btn;
    public GameObject adv_refri_Buy_Btn;
    public GameObject highlevel_refri_Buy_Btn;

    public GameObject use_simp_refri;
    public GameObject use_adv_refri;
    public GameObject use_highlevel_refri;
    #endregion

    #region 第二頁 魚缸
    public GameObject origin_fish;
    public GameObject simp_Fish;  //普通魚缸
    public GameObject adv_Fish;  //進階魚缸
    public GameObject highlevel_Fish;  //高階魚缸
    public GameObject simp_Fish_Sure;
    public GameObject adv_Fish_Sure;
    public GameObject highlevel_Fish_Sure;

    public GameObject simp_fish_Buy_Btn;
    public GameObject adv_fish_Buy_Btn;
    public GameObject highlevel_fish_Buy_Btn;

    public GameObject use_simp_fish;
    public GameObject use_adv_fish;
    public GameObject use_highlevel_fish;
    #endregion

    #region 第三頁 桌子
    public GameObject origin_table;
    public GameObject simp_table;  //圓桌
    public GameObject adv_table;  //方桌
    public GameObject highlevel_table;  //有轉盤的桌子
    public GameObject simp_table_Sure;
    public GameObject adv_table_Sure;
    public GameObject highlevel_table_Sure;

    public GameObject simp_table_Buy_Btn;
    public GameObject adv_table_Buy_Btn;
    public GameObject highlevel_table_Buy_Btn;

    public GameObject use_simp_table;
    public GameObject use_adv_table;
    public GameObject use_highlevel_table;
    #endregion

    #region 櫃台
    public GameObject origin_counter;
    public GameObject simp_counter;  //裝飾櫃台
    public GameObject mid_counter;  //大理石櫃台
    public GameObject simp_counter_Sure;
    public GameObject mid_counter_Sure;

    public GameObject simp_counter_Buy_Btn;
    public GameObject mid_counter_Buy_Btn;

    public GameObject use_simp_counter;
    public GameObject use_mid_counter;
    #endregion

    #region 桌飾
    public GameObject Money_Cat;  //招財貓
    public GameObject Money_Cat_Sure;
    public GameObject gold_frog;  //金蟾蜍
    public GameObject gold_frog_Sure;

    public GameObject Money_Cat_Buy_Btn;
    public GameObject gold_frog_Buy_Btn;

    public GameObject use_Money_Cat;
    public GameObject use_gold_frog;

    #endregion

    #region 壁飾
    public GameObject money_god;  //金蟾蜍
    public GameObject money_god_Sure;
    public GameObject tsun;  //春
    public GameObject tsun_Sure;
    public GameObject fu;  //福
    public GameObject fu_Sure;
    public GameObject plaque1;  //招財進寶
    public GameObject plaque1_Sure;
    public GameObject plaque2;  //千克萬來
    public GameObject plaque2_Sure;
    public GameObject plaque3;  //金蟾蜍
    public GameObject plaque3_Sure;
    public GameObject plaque4;  //金蟾蜍
    public GameObject plaque4_Sure;
    public GameObject plaque5;  //金蟾蜍
    public GameObject plaque5_Sure;

    public GameObject money_god_Buy_Btn;
    public GameObject tsun_Buy_Btn;
    public GameObject fu_Buy_Btn;
    public GameObject plaque1_Buy_Btn;
    public GameObject plaque2_Buy_Btn;
    public GameObject plaque3_Buy_Btn;
    public GameObject plaque4_Buy_Btn;
    public GameObject plaque5_Buy_Btn;

    public GameObject use_money_god;
    public GameObject use_tsun;
    public GameObject use_fu;
    public GameObject use_plaque1;
    public GameObject use_plaque2;
    public GameObject use_plaque3;
    public GameObject use_plaque4;
    public GameObject use_plaque5;
    #endregion

    public GameObject Not_Enough;
    public GameObject Shop;  //商店介面
    
    #region 達到一定條件即可做菜
    public GameObject bulb_konsingtsai;  //達到一定條件即可做菜
    public GameObject bulb_diguayeah;
    public GameObject bulb_tsaibonun;
    public GameObject bulb_kongbaogiding;
    #endregion

    void Start()
    {
        Money.PocketMoney = Money.PocketMoney + Player.Meat_Total_Score + Player_Quiz.Quiz_Total_Score+ simp_.Simple_Guest_Total_Score;
        //現有零用錢 = 已擁有的零用錢 + 接肉獲得的錢 + 驚嘆號獲得的錢 + 點擊簡單客人獲得的錢
        GetComponent<Text>().text = Money.PocketMoney.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //Money.PocketMoney = Money.PocketMoney + Player.Meat_Total_Score + Player_Quiz.Quiz_Total_Score + simp_.Simple_Guest_Total_Score;
        Kongsingtsai();
        Diguayeah();
    }
    #region 第一頁 買冰箱
    public void simp_refri_Sure_to_buy()  //普通冰箱
    {
        if (Money.PocketMoney >= 2000)
        {
            Money.PocketMoney = Money.PocketMoney - 2000;
            GetComponent<Text>().text = Money.PocketMoney.ToString();

            simp_refri.SetActive(true);
            adv_refri.SetActive(false);
            highlevel_refri.SetActive(false);
            origin_refri.SetActive(false);

            simp_refri_Sure.SetActive(false);
            Shop.SetActive(false);  //關閉商店
            simp_refri_Buy_Btn.SetActive(false);  //購買按鈕關閉
            use_simp_refri.SetActive(true);  //套用按鈕開啟
        }
        else
        {
            print("餘額不足");            
            Not_Enough.SetActive(true);
        }

    }

    public void to_use_simp_refri()
    {
        simp_refri.SetActive(true);
        adv_refri.SetActive(false);
        highlevel_refri.SetActive(false);
        origin_refri.SetActive(false);

        Shop.SetActive(false);  //關閉商店
    }

    public void adv_refri_Sure_to_buy()  //進階冰箱
    {
        if (Money.PocketMoney >= 5000)
        {
            Money.PocketMoney = Money.PocketMoney - 5000;
            GetComponent<Text>().text = Money.PocketMoney.ToString();

            adv_refri.SetActive(true);
            simp_refri.SetActive(false);
            highlevel_refri.SetActive(false);
            origin_refri.SetActive(false);

            adv_refri_Sure.SetActive(false);
            Shop.SetActive(false);
            adv_refri_Buy_Btn.SetActive(false);  //購買按鈕關閉
            use_adv_refri.SetActive(true);  //套用按鈕開啟
        }
        else
        {
            print("餘額不足");
            Not_Enough.SetActive(true);
        }

    }

    public void to_use_adv_refri()
    {
        adv_refri.SetActive(true);
        simp_refri.SetActive(false);
        highlevel_refri.SetActive(false);
        origin_refri.SetActive(false);

        Shop.SetActive(false);  //關閉商店
    }

    public void highlevel_refri_Sure_to_buy()  //高階冰箱
    {
        if (Money.PocketMoney >= 10000)
        {
            Money.PocketMoney = Money.PocketMoney - 10000;
            GetComponent<Text>().text = Money.PocketMoney.ToString();

            highlevel_refri.SetActive(true);
            adv_refri.SetActive(false);
            simp_refri.SetActive(false);
            origin_refri.SetActive(false);

            highlevel_refri_Sure.SetActive(false);
            Shop.SetActive(false);
            highlevel_refri_Buy_Btn.SetActive(false);  //購買按鈕關閉
            use_highlevel_refri.SetActive(true);  //套用按鈕開啟
        }
        else
        {
            print("餘額不足");
            Not_Enough.SetActive(true);
        }

    }

    public void to_use_highlevel_refri()
    {
        highlevel_refri.SetActive(true);
        adv_refri.SetActive(false);
        simp_refri.SetActive(false);
        origin_refri.SetActive(false);

        Shop.SetActive(false);  //關閉商店
    }
    #endregion

    #region 第二頁 魚缸
    public void simp_Fish_Sure_to_buy()  //普通水族箱
    {
        if (Money.PocketMoney >= 2000)
        {
            Money.PocketMoney = Money.PocketMoney - 2000;
            GetComponent<Text>().text = Money.PocketMoney.ToString();

            simp_Fish.SetActive(true);
            adv_Fish.SetActive(false);
            highlevel_Fish.SetActive(false);
            origin_fish.SetActive(false);

            simp_Fish_Sure.SetActive(false);
            Shop.SetActive(false);
            simp_fish_Buy_Btn.SetActive(false);  //購買按鈕關閉
            use_simp_fish.SetActive(true);  //套用按鈕開啟
        }
        else
        {
            print("餘額不足");
            Not_Enough.SetActive(true);
        }

    }

    public void to_use_simp_fish()
    {
        simp_Fish.SetActive(true);
        adv_Fish.SetActive(false);
        highlevel_Fish.SetActive(false);
        origin_fish.SetActive(false);

        Shop.SetActive(false);  //關閉商店
    }

    public void adv_Fish_Sure_to_buy()  //進階水族箱
    {
        if (Money.PocketMoney >= 5000)
        {
            Money.PocketMoney = Money.PocketMoney - 5000;
            GetComponent<Text>().text = Money.PocketMoney.ToString();

            adv_Fish.SetActive(true);
            simp_Fish.SetActive(false);
            highlevel_Fish.SetActive(false);
            origin_fish.SetActive(false);

            adv_Fish_Sure.SetActive(false);
            Shop.SetActive(false);
            adv_fish_Buy_Btn.SetActive(false);  //購買按鈕關閉
            use_adv_fish.SetActive(true);  //套用按鈕開啟
        }
        else
        {
            print("餘額不足");
            Not_Enough.SetActive(true);
        }

    }

    public void to_use_adv_fish()
    {
        adv_Fish.SetActive(true);
        simp_Fish.SetActive(false);
        highlevel_Fish.SetActive(false);
        origin_fish.SetActive(false);

        Shop.SetActive(false);  //關閉商店
    }

    public void highlevel_Fish_Sure_to_buy()  //高級水族箱
    {
        if (Money.PocketMoney >= 10000)
        {
            Money.PocketMoney = Money.PocketMoney - 10000;
            GetComponent<Text>().text = Money.PocketMoney.ToString();

            highlevel_Fish.SetActive(true);
            simp_Fish.SetActive(false);
            adv_Fish.SetActive(false);
            origin_fish.SetActive(false);

            highlevel_Fish_Sure.SetActive(false);
            Shop.SetActive(false);
            highlevel_fish_Buy_Btn.SetActive(false);  //購買按鈕關閉
            use_highlevel_fish.SetActive(true);  //套用按鈕開啟
        }
        else
        {
            print("餘額不足");
            Not_Enough.SetActive(true);
        }

    }

    public void to_use_highlevel_fish()
    {
        highlevel_Fish.SetActive(true);
        simp_Fish.SetActive(false);
        adv_Fish.SetActive(false);
        origin_fish.SetActive(false);

        Shop.SetActive(false);  //關閉商店
    }
    #endregion

    #region 第三頁 桌子

    public void simp_table_Sure_to_buy()  //圓桌
    {
        if (Money.PocketMoney >= 800)
        {
            Money.PocketMoney = Money.PocketMoney - 800;
            GetComponent<Text>().text = Money.PocketMoney.ToString();
             
            simp_table.SetActive(true);
            highlevel_table.SetActive(false);
            adv_table.SetActive(false);
            origin_table.SetActive(false);

            simp_table_Sure.SetActive(false);
            Shop.SetActive(false);
            simp_table_Buy_Btn.SetActive(false);  //購買按鈕關閉
            use_simp_table.SetActive(true);  //套用按鈕開啟
        }
        else
        {
            print("餘額不足");
            Not_Enough.SetActive(true);
        }

    }

    public void to_use_simp_table()
    {
        simp_table.SetActive(true);
        highlevel_table.SetActive(false);
        adv_table.SetActive(false);
        origin_table.SetActive(false);

        Shop.SetActive(false);  //關閉商店
    }

    public void adv_table_Sure_to_buy()  //方桌
    {
        if (Money.PocketMoney >= 800)
        {
            Money.PocketMoney = Money.PocketMoney - 800;
            GetComponent<Text>().text = Money.PocketMoney.ToString();
             
            adv_table.SetActive(true);
            highlevel_table.SetActive(false);
            simp_table.SetActive(false);
            origin_table.SetActive(false);

            adv_table_Sure.SetActive(false);
            Shop.SetActive(false);
            adv_table_Buy_Btn.SetActive(false);  //購買按鈕關閉
            use_adv_table.SetActive(true);  //套用按鈕開啟
        }
        else
        {
            print("餘額不足");
            Not_Enough.SetActive(true);
        }
    }

    public void to_use_adv_table()
    {
        adv_table.SetActive(true);
        highlevel_table.SetActive(false);
        simp_table.SetActive(false);
        origin_table.SetActive(false);

        Shop.SetActive(false);  //關閉商店
    }

    public void highlevel_table_Sure_to_buy()  //會轉桌
    {
        if (Money.PocketMoney >= 1500)
        {
            Money.PocketMoney = Money.PocketMoney - 1500;
            GetComponent<Text>().text = Money.PocketMoney.ToString();
             
            adv_table.SetActive(false);
            highlevel_table.SetActive(true);
            simp_table.SetActive(false);
            origin_table.SetActive(false);

            highlevel_table_Sure.SetActive(false);
            Shop.SetActive(false);
            highlevel_table_Buy_Btn.SetActive(false);  //購買按鈕關閉
            use_highlevel_table.SetActive(true);  //套用按鈕開啟
        }
        else
        {
            print("餘額不足");
            Not_Enough.SetActive(true);
        }
    }

    public void to_use_highlevel_table()
    {
        adv_table.SetActive(false);
        highlevel_table.SetActive(true);
        simp_table.SetActive(false);
        origin_table.SetActive(false);

        Shop.SetActive(false);  //關閉商店
    }
    #endregion

    #region 櫃台
    public void simp_counter_Sure_to_buy()  //有裝飾櫃台
    {
        if (Money.PocketMoney >= 5000)
        {
            Money.PocketMoney = Money.PocketMoney - 5000;
            GetComponent<Text>().text = Money.PocketMoney.ToString();
             
            origin_counter.SetActive(false);
            simp_counter.SetActive(true);
            mid_counter.SetActive(false);
             
            simp_counter_Sure.SetActive(false);
            Shop.SetActive(false);
            simp_counter_Buy_Btn.SetActive(false);  //購買按鈕關閉
            use_simp_counter.SetActive(true);  //套用按鈕開啟
        }
        else
        {
            print("餘額不足");
            Not_Enough.SetActive(true);
        }
    }

    public void to_use_simp_counter()
    {
        origin_counter.SetActive(false);
        simp_counter.SetActive(true);
        mid_counter.SetActive(false);

        Shop.SetActive(false);  //關閉商店
    }

    public void mid_counter_Sure_to_buy()  //大理石櫃台
    {
        if (Money.PocketMoney >= 10000)
        {
            Money.PocketMoney = Money.PocketMoney - 10000;
            GetComponent<Text>().text = Money.PocketMoney.ToString();
             
            origin_counter.SetActive(false);
            simp_counter.SetActive(false);
            mid_counter.SetActive(true);
             
            mid_counter_Sure.SetActive(false);
            Shop.SetActive(false);
            mid_counter_Buy_Btn.SetActive(false);  //購買按鈕關閉
            use_mid_counter.SetActive(true);  //套用按鈕開啟
        }
        else
        {
            print("餘額不足");
            Not_Enough.SetActive(true);
        }
    }

    public void to_use_mid_counter()
    {
        origin_counter.SetActive(false);
        simp_counter.SetActive(false);
        mid_counter.SetActive(true);

        Shop.SetActive(false);  //關閉商店
    }
    #endregion

    #region 桌飾
    public void Money_Cat_Sure_to_buy()  //招財貓
    {
        if (Money.PocketMoney >= 500)
        {
            Money.PocketMoney = Money.PocketMoney - 500;
            GetComponent<Text>().text = Money.PocketMoney.ToString();
             
            gold_frog.SetActive(false);
            Money_Cat.SetActive(true);
             
            Money_Cat_Sure.SetActive(false);
            Shop.SetActive(false);
            Money_Cat_Buy_Btn.SetActive(false);  //購買按鈕關閉
            use_Money_Cat.SetActive(true);  //套用按鈕開啟
        }
        else
        {
            print("餘額不足");
            Not_Enough.SetActive(true);
        }
    }

    public void to_use_Money_Cat()
    {
        gold_frog.SetActive(false);
        Money_Cat.SetActive(true);

        Shop.SetActive(false);  //關閉商店
    }

    public void gold_frog_Sure_to_buy()  //招財貓
    {
        if (Money.PocketMoney >= 500)
        {
            Money.PocketMoney = Money.PocketMoney - 500;
            GetComponent<Text>().text = Money.PocketMoney.ToString();
             
            gold_frog.SetActive(true);
            Money_Cat.SetActive(false);
             
            gold_frog_Sure.SetActive(false);
            Shop.SetActive(false);
            gold_frog_Buy_Btn.SetActive(false);  //購買按鈕關閉
            use_gold_frog.SetActive(true);  //套用按鈕開啟
        }
        else
        {
            print("餘額不足");
            Not_Enough.SetActive(true);
        }
    }

    public void to_use_gold_frog()
    {
        gold_frog.SetActive(true);
        Money_Cat.SetActive(false);

        Shop.SetActive(false);  //關閉商店
    }
    #endregion

    #region 壁飾
    public void money_god_Sure_to_buy()  //招財貓
    {
        if (Money.PocketMoney >= 800)
        {
            Money.PocketMoney = Money.PocketMoney - 800;
            GetComponent<Text>().text = Money.PocketMoney.ToString();

            money_god.SetActive(true);
            tsun.SetActive(false);
            fu.SetActive(false); 
            plaque1.SetActive(false);
            plaque2.SetActive(false);
            plaque3.SetActive(false);
            plaque4.SetActive(false);
            plaque5.SetActive(false);

            money_god_Sure.SetActive(false);
            Shop.SetActive(false);
            money_god_Buy_Btn.SetActive(false);  //購買按鈕關閉
            use_money_god.SetActive(true);  //套用按鈕開啟
        }
        else
        {
            print("餘額不足");
            Not_Enough.SetActive(true);
        }
    }

    public void to_use_money_god()
    {
        money_god.SetActive(true);
        tsun.SetActive(false);
        fu.SetActive(false);
        plaque1.SetActive(false);
        plaque2.SetActive(false);
        plaque3.SetActive(false);
        plaque4.SetActive(false);
        plaque5.SetActive(false);

        Shop.SetActive(false);  //關閉商店
    }

    public void tsun_Sure_to_buy()  //招財貓
    {
        if (Money.PocketMoney >= 100)
        {
            Money.PocketMoney = Money.PocketMoney - 100;
            GetComponent<Text>().text = Money.PocketMoney.ToString();

            money_god.SetActive(false);
            tsun.SetActive(true);
            fu.SetActive(false);
            plaque1.SetActive(false);
            plaque2.SetActive(false);
            plaque3.SetActive(false);
            plaque4.SetActive(false);
            plaque5.SetActive(false);

            tsun_Sure.SetActive(false);
            Shop.SetActive(false);
            tsun_Buy_Btn.SetActive(false);  //購買按鈕關閉
            use_tsun.SetActive(true);  //套用按鈕開啟
        }
        else
        {
            print("餘額不足");
            Not_Enough.SetActive(true);
        }
    }

    public void to_use_tsun()
    {
        money_god.SetActive(false);
        tsun.SetActive(true);
        fu.SetActive(false);
        plaque1.SetActive(false);
        plaque2.SetActive(false);
        plaque3.SetActive(false);
        plaque4.SetActive(false);
        plaque5.SetActive(false);

        Shop.SetActive(false);  //關閉商店
    }

    public void fu_Sure_to_buy()  //招財貓
    {
        if (Money.PocketMoney >= 100)
        {
            Money.PocketMoney = Money.PocketMoney - 100;
            GetComponent<Text>().text = Money.PocketMoney.ToString();

            money_god.SetActive(false);
            tsun.SetActive(false);
            fu.SetActive(true);
            plaque1.SetActive(false);
            plaque2.SetActive(false);
            plaque3.SetActive(false);
            plaque4.SetActive(false);
            plaque5.SetActive(false);

            fu_Sure.SetActive(false);
            Shop.SetActive(false);
            fu_Buy_Btn.SetActive(false);  //購買按鈕關閉
            use_fu.SetActive(true);  //套用按鈕開啟
        }
        else
        {
            print("餘額不足");
            Not_Enough.SetActive(true);
        }
    }

    public void to_use_fu()
    {
        money_god.SetActive(false);
        tsun.SetActive(false);
        fu.SetActive(true);
        plaque1.SetActive(false);
        plaque2.SetActive(false);
        plaque3.SetActive(false);
        plaque4.SetActive(false);
        plaque5.SetActive(false);

        Shop.SetActive(false);  //關閉商店
    }

    public void plaque1_Sure_to_buy()  //招財貓
    {
        if (Money.PocketMoney >= 1000)
        {
            Money.PocketMoney = Money.PocketMoney - 100;
            GetComponent<Text>().text = Money.PocketMoney.ToString();

            money_god.SetActive(false);
            tsun.SetActive(false);
            fu.SetActive(false);
            plaque1.SetActive(true);
            plaque2.SetActive(false);
            plaque3.SetActive(false);
            plaque4.SetActive(false);
            plaque5.SetActive(false);

            plaque1_Sure.SetActive(false);
            Shop.SetActive(false);
            plaque1_Buy_Btn.SetActive(false);  //購買按鈕關閉
            use_plaque1.SetActive(true);  //套用按鈕開啟
        }
        else
        {
            print("餘額不足");
            Not_Enough.SetActive(true);
        }
    }

    public void to_use_plaque1()
    {
        money_god.SetActive(false);
        tsun.SetActive(false);
        fu.SetActive(false);
        plaque1.SetActive(true);
        plaque2.SetActive(false);
        plaque3.SetActive(false);
        plaque4.SetActive(false);
        plaque5.SetActive(false);

        Shop.SetActive(false);  //關閉商店
    }

    public void plaque2_Sure_to_buy()  //招財貓
    {
        if (Money.PocketMoney >= 1000)
        {
            Money.PocketMoney = Money.PocketMoney - 1000;
            GetComponent<Text>().text = Money.PocketMoney.ToString();

            money_god.SetActive(false);
            tsun.SetActive(false);
            fu.SetActive(false);
            plaque1.SetActive(false);
            plaque2.SetActive(true);
            plaque3.SetActive(false);
            plaque4.SetActive(false);
            plaque5.SetActive(false);

            plaque2_Sure.SetActive(false);
            Shop.SetActive(false);
            plaque2_Buy_Btn.SetActive(false);  //購買按鈕關閉
            use_plaque2.SetActive(true);  //套用按鈕開啟
        }
        else
        {
            print("餘額不足");
            Not_Enough.SetActive(true);
        }
    }

    public void to_use_plaque2()
    {
        money_god.SetActive(false);
        tsun.SetActive(false);
        fu.SetActive(false);
        plaque1.SetActive(false);
        plaque2.SetActive(true);
        plaque3.SetActive(false);
        plaque4.SetActive(false);
        plaque5.SetActive(false);

        Shop.SetActive(false);  //關閉商店
    }

    public void plaque3_Sure_to_buy()  //招財貓
    {
        if (Money.PocketMoney >= 1000)
        {
            Money.PocketMoney = Money.PocketMoney - 1000;
            GetComponent<Text>().text = Money.PocketMoney.ToString();

            money_god.SetActive(false);
            tsun.SetActive(false);
            fu.SetActive(false);
            plaque1.SetActive(false);
            plaque2.SetActive(false);
            plaque3.SetActive(true);
            plaque4.SetActive(false);
            plaque5.SetActive(false);

            plaque3_Sure.SetActive(false);
            Shop.SetActive(false);
            plaque3_Buy_Btn.SetActive(false);  //購買按鈕關閉
            use_plaque3.SetActive(true);  //套用按鈕開啟
        }
        else
        {
            print("餘額不足");
            Not_Enough.SetActive(true);
        }
    }

    public void to_use_plaque3()
    {
        money_god.SetActive(false);
        tsun.SetActive(false);
        fu.SetActive(false);
        plaque1.SetActive(false);
        plaque2.SetActive(false);
        plaque3.SetActive(true);
        plaque4.SetActive(false);
        plaque5.SetActive(false);

        Shop.SetActive(false);  //關閉商店
    }

    public void plaque4_Sure_to_buy()  //招財貓
    {
        if (Money.PocketMoney >= 1000)
        {
            Money.PocketMoney = Money.PocketMoney - 1000;
            GetComponent<Text>().text = Money.PocketMoney.ToString();

            money_god.SetActive(false);
            tsun.SetActive(false);
            fu.SetActive(false);
            plaque1.SetActive(false);
            plaque2.SetActive(false);
            plaque3.SetActive(false);
            plaque4.SetActive(true);
            plaque5.SetActive(false);

            plaque4_Sure.SetActive(false);
            Shop.SetActive(false);
            plaque4_Buy_Btn.SetActive(false);  //購買按鈕關閉
            use_plaque4.SetActive(true);  //套用按鈕開啟
        }
        else
        {
            print("餘額不足");
            Not_Enough.SetActive(true);
        }
    }

    public void to_use_plaque4()
    {
        money_god.SetActive(false);
        tsun.SetActive(false);
        fu.SetActive(false);
        plaque1.SetActive(false);
        plaque2.SetActive(false);
        plaque3.SetActive(false);
        plaque4.SetActive(true);
        plaque5.SetActive(false);

        Shop.SetActive(false);  //關閉商店
    }

    public void plaque5_Sure_to_buy()  //招財貓
    {
        if (Money.PocketMoney >= 1000)
        {
            Money.PocketMoney = Money.PocketMoney - 1000;
            GetComponent<Text>().text = Money.PocketMoney.ToString();

            money_god.SetActive(false);
            tsun.SetActive(false);
            fu.SetActive(false);
            plaque1.SetActive(false);
            plaque2.SetActive(false);
            plaque3.SetActive(false);
            plaque4.SetActive(false);
            plaque5.SetActive(true);

            plaque5_Sure.SetActive(false);
            Shop.SetActive(false);
            plaque5_Buy_Btn.SetActive(false);  //購買按鈕關閉
            use_plaque5.SetActive(true);  //套用按鈕開啟
        }
        else
        {
            print("餘額不足");
            Not_Enough.SetActive(true);
        }
    }

    public void to_use_plaque5()
    {
        money_god.SetActive(false);
        tsun.SetActive(false);
        fu.SetActive(false);
        plaque1.SetActive(false);
        plaque2.SetActive(false);
        plaque3.SetActive(false);
        plaque4.SetActive(false);
        plaque5.SetActive(true);

        Shop.SetActive(false);  //關閉商店
    }
    #endregion

    #region 頁面切換

    public void Tsaibonun()  //菜圃但
    {
        if (Money.PocketMoney >= 500)
        {
            bulb_tsaibonun.SetActive(true);
        }
        else
        {
            bulb_tsaibonun.SetActive(false);
        }

    }
    public void Kongsingtsai()  //空心菜
    {
        if (Money.PocketMoney >= 5000)
        {
            bulb_konsingtsai.SetActive(true);
        }
        else
        {
            bulb_konsingtsai.SetActive(false);
        }

    }

    public void Diguayeah()  //地瓜葉
    {
        if (Money.PocketMoney >= 10000)
        {
            bulb_diguayeah.SetActive(true);
        }
        else
        {
            bulb_diguayeah.SetActive(false);
        }

    }

    

    public void Kongbaogiding()  //宮保雞丁
    {
        if (Money.PocketMoney >= 20000)
        {
            bulb_kongbaogiding.SetActive(true);
        }
        else
        {
            bulb_kongbaogiding.SetActive(false);
        }

    }
    #endregion

    public void Right_Dishes()
    {
        Money.PocketMoney = Money.PocketMoney+100;
        GetComponent<Text>().text = Money.PocketMoney.ToString();
    }
}