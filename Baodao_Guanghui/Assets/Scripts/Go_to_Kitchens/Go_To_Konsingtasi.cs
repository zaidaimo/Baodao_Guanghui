using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Go_To_Konsingtasi : MonoBehaviour
{
    public GameObject kongsingtsai_kitchen;
    private void OnMouseDown()
    {
        kongsingtsai_kitchen.SetActive(true);

        Destroy(gameObject);
    }
}
