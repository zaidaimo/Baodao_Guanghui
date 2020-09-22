using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Add_Meat_Money : MonoBehaviour
{

    public GameObject simp_refri;
    public GameObject Not_Enough;
    public float DestroyTime;
    public GameObject Shop;

    void Start()
    {
        Money.PocketMoney = Money.PocketMoney + Player.Meat_Total_Score;
        GetComponent<Text>().text = Money.PocketMoney.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void simp_refri_Sure_to_buy()
    {
        if (Money.PocketMoney >= 2000)
        {
            Money.PocketMoney = Money.PocketMoney - 2000;
            GetComponent<Text>().text = Money.PocketMoney.ToString();

            simp_refri.SetActive(true);
            Shop.SetActive(false);
        }
        else
        {
            if (!Not_Enough.activeInHierarchy)
            { 
                Not_Enough.SetActive(true);
            }
            else
            {
                Not_Enough.SetActive(false);
            }

                
            //Destroy(Not_Enough, DestroyTime);
           
            print("餘額不足");
        }

    }


}
