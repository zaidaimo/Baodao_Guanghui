using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class close_menu : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Shop;
    public GameObject Picture;
    public GameObject Left;
    public GameObject Right;
    public void OnMouseDown()
    {
        Menu.SetActive(false);
        Shop.SetActive(true);
        Picture.SetActive(true);
        Left.SetActive(true);
        Right.SetActive(true);
    }
}
