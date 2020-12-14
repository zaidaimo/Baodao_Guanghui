using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Do_Hua_Guest : MonoBehaviour
{
    public GameObject Do_Hua_Quiz;

    public GameObject Right;
    public GameObject Left;
    public GameObject Shop;
    public GameObject Picture;
    private void OnMouseDown()
    {
        Do_Hua_Quiz.SetActive(true);

        Right.SetActive(false);
        Left.SetActive(false);
        Shop.SetActive(false);
        Picture.SetActive(false);
    }
}
