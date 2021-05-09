using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Kitchen_Lock : MonoBehaviour
{
    void Update()
    {
        Destroy();
    }
    // Start is called before the first frame update
    public void Destroy()
    {
        if (Money.PocketMoney >= 1800)
        {
            Destroy(gameObject);
        }
    }
}
