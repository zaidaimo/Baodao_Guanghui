using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Simple_Destroy : MonoBehaviour
{
    void Update()
    {
        Destroy();
    }
    // Start is called before the first frame update
    public void Destroy()
    {
        if (Money.PocketMoney >= 1000)
        {
            Destroy(gameObject);
        }
    }

}
