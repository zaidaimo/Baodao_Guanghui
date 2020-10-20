using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storys : MonoBehaviour
{
    public GameObject Photo;
    public GameObject Story;
    public GameObject Achive;

    public GameObject Shop;
    public GameObject Picture;
    public GameObject Left;
    public GameObject Right;

    private void OnMouseDown()
    {
        Photo.SetActive(false);
        Story.SetActive(true);
        Achive.SetActive(false);

        Achive.SetActive(false);

        Achive.SetActive(false); Achive.SetActive(false);
    }
}