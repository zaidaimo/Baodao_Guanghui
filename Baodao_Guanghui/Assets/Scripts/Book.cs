using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    public GameObject Photo;
    public GameObject Story;
    public GameObject Achive;


    private void OnMouseDown()
    {
        Photo.SetActive(true);
        Story.SetActive(false);
        Achive.SetActive(false);

    }
}