using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Simple_Destroy : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        if (Money.PocketMoney >= 22000)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
