using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest_Base : MonoBehaviour
{
    public GameObject Notes;

    public GameObject Shop;
    public GameObject Picture;
    public GameObject Left;
    public GameObject Right;
    private void OnMouseDown()
    {
        Notes.SetActive(true);
        Shop.SetActive(false);
        Picture.SetActive(false);
        Left.SetActive(false);
        Right.SetActive(false);

        Destroy(gameObject);
    }
}
