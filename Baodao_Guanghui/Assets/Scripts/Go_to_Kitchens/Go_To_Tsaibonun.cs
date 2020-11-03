using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Go_To_Tsaibonun : MonoBehaviour
{
    public GameObject tsaibonun_kitchen;
    private void OnMouseDown()
    {
        tsaibonun_kitchen.SetActive(true);

        Destroy(gameObject);
    }
}
