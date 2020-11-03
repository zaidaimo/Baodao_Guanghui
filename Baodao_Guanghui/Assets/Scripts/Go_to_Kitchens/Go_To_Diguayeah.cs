using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Go_To_Diguayeah : MonoBehaviour
{
    public GameObject diguayeah_kitchen;
    private void OnMouseDown()
    {
        diguayeah_kitchen.SetActive(true);

        Destroy(gameObject);
    }
}
