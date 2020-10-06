using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting_Debug : MonoBehaviour
{
    public GameObject Menu;

    public void OnMouseDown()
    {
        Menu.SetActive(false);
        
    }
}
