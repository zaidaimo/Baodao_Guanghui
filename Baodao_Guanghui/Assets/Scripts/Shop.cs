using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject simp_refri;

    // Start is called before the first frame update
    void Start()
    {
        
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
            //GetComponent<Text>().text = Money.PocketMoney.ToString();

            simp_refri.SetActive(true);
        }
        else
        {
            print("餘額不足");
        }

    }
}

