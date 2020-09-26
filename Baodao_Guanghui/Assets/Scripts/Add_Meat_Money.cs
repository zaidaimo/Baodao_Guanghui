using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Add_Meat_Money : MonoBehaviour
{
    //public GameObject origin_refri;
    public GameObject simp_refri;  //普通冰箱
    public GameObject adv_refri;  //進階冰箱
    public GameObject highlevel_refri;  //高階冰箱
    public GameObject simp_refri_Sure;
    public GameObject adv_refri_Sure;
    public GameObject highlevel_refri_Sure;

    public GameObject origin_fish;
    public GameObject simp_Fish;  //普通魚缸
    public GameObject adv_Fish;  //進階魚缸
    public GameObject highlevel_Fish;  //高階魚缸
    public GameObject simp_Fish_Sure;
    public GameObject adv_Fish_Sure;
    public GameObject highlevel_Fish_Sure;

    public GameObject origin_table;
    public GameObject simp_table;  //圓桌
    public GameObject adv_table;  //方桌
    public GameObject highlevel_table;  //有轉盤的桌子
    public GameObject simp_table_Sure;
    public GameObject adv_table_Sure;
    public GameObject highlevel_table_Sure;

    public GameObject Not_Enough;
    public GameObject Shop;  //商店介面

    void Start()
    {
        Money.PocketMoney = Money.PocketMoney + Player.Meat_Total_Score;
        GetComponent<Text>().text = Money.PocketMoney.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void simp_refri_Sure_to_buy()  //普通冰箱
    {
        if (Money.PocketMoney >= 2000)
        {
            Money.PocketMoney = Money.PocketMoney - 2000;
            GetComponent<Text>().text = Money.PocketMoney.ToString();

            simp_refri.SetActive(true);
            adv_refri.SetActive(false);
            highlevel_refri.SetActive(false);
            //origin_refri.SetActive(false);

            simp_refri_Sure.SetActive(false);
            Shop.SetActive(false);
        }
        else
        {
            print("餘額不足");            
            Not_Enough.SetActive(true);
        }

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
            //origin_refri.SetActive(false);

            adv_refri_Sure.SetActive(false);
            Shop.SetActive(false);
        }
        else
        {
            print("餘額不足");
            Not_Enough.SetActive(true);
        }

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
            //origin_refri.SetActive(false);

            highlevel_refri_Sure.SetActive(false);
            Shop.SetActive(false);
        }
        else
        {
            print("餘額不足");
            Not_Enough.SetActive(true);
        }

    }

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
        }
        else
        {
            print("餘額不足");
            Not_Enough.SetActive(true);
        }

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
        }
        else
        {
            print("餘額不足");
            Not_Enough.SetActive(true);
        }

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
        }
        else
        {
            print("餘額不足");
            Not_Enough.SetActive(true);
        }

    }

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
        }
        else
        {
            print("餘額不足");
            Not_Enough.SetActive(true);
        }

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
        }
        else
        {
            print("餘額不足");
            Not_Enough.SetActive(true);
        }
    }

    public void highlevel_table_Sure_to_buy()  //方桌
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
        }
        else
        {
            print("餘額不足");
            Not_Enough.SetActive(true);
        }
    }
}